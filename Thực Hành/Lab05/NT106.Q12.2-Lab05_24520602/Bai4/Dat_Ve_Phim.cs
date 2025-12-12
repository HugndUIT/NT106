using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Bbai4
{
    public partial class Dat_Ve_Phim : Form
    {
        public Dat_Ve_Phim()
        {
            InitializeComponent();
            Xu_Ly_HTML();
            Xu_Ly_Load_Ds();
        }

        public class Movie
        {
            public string Ten_Phim { get; set; }
            public string The_Loai { get; set; }
            public string Thoi_Luong { get; set; }
            public List<string> Phong_Chieu { get; set; }
            public int Gia_Ve { get; set; }
        }

        List<Movie> Danh_Sach_Phim = new List<Movie>();

        Dictionary<string, List<string>> Ghe_Da_Dat = new Dictionary<string, List<string>>();

        public void Xu_Ly_HTML()
        {
            string URL = "https://www.betacinemas.vn/phim.htm";

            var Web = new HtmlWeb();
            var Content = Web.Load(URL);

            var Nodes = Content.DocumentNode.SelectNodes("//div[contains(@class,'film-info')]");
            if (Nodes == null) return;

            foreach (var Film in Nodes)
            {
                var Name_Node = Film.SelectSingleNode(".//h3/a");
                string Name = Name_Node?.InnerText.Trim();

                var Genre_Node = Film.SelectSingleNode(".//li[span[contains(text(),'Thể loại:')]]/text()");
                string Genre = Genre_Node?.InnerText.Trim();

                if (!string.IsNullOrEmpty(Genre))
                {
                    Genre = Regex.Replace(Genre, @"\s+", " ").Trim();
                }

                var Duration_Node = Film.SelectSingleNode("//li[span[contains(text(),'Thời lượng:')]]/text()");
                string Duration = Duration_Node?.InnerText.Trim();

                if (!string.IsNullOrEmpty(Duration))
                {
                    Duration = Regex.Replace(Duration, @"\s+", " ").Trim();
                }

                Danh_Sach_Phim.Add(new Movie
                {
                    Ten_Phim = Name,
                    The_Loai = Genre,
                    Thoi_Luong = Duration,
                    Phong_Chieu = new List<string> { "1", "2", "3" },
                    Gia_Ve = 36000
                });
            }

            var Options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };

            string Json = JsonSerializer.Serialize(Danh_Sach_Phim, Options);
            File.WriteAllText("Thong_Tin_Phim.json", Json, Encoding.UTF8);
        }

        public void Xu_Ly_Load_Ds()
        {
            cb_Phim.DataSource = Danh_Sach_Phim.Select(Phim => Phim.Ten_Phim).ToList();
        }

        private void cb_Phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Phim = cb_Phim.SelectedItem.ToString();

            var Movie = Danh_Sach_Phim.FirstOrDefault(P => P.Ten_Phim == Phim);

            if (Movie != null)
            {
                cb_Phong.DataSource = Movie.Phong_Chieu;
            }
        }

        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Phong.SelectedItem == null || cb_Phim.SelectedItem == null) return;

            string Phong = cb_Phong.SelectedItem.ToString();
            string TenPhim = cb_Phim.SelectedItem.ToString();

            clb_Ghe.Items.Clear();

            foreach (var Hang_Ghe in new[] { "A", "B", "C" })
            {
                for (int i = 1; i <= 5; i++)
                {
                    string Ghe_Hien_Thi = $"{Phong} - {Hang_Ghe}{i}";

                    string Key_Kiem_Tra = $"{TenPhim} - {Ghe_Hien_Thi}";

                    int Index = clb_Ghe.Items.Add(Ghe_Hien_Thi, false);

                    if (Ghe_Da_Dat.Values.Any(G => G.Contains(Key_Kiem_Tra)))
                    {
                        clb_Ghe.SetItemCheckState(Index, CheckState.Indeterminate);
                    }
                }
            }
        }

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenKhach.Text) || 
                cb_Phim.SelectedIndex == -1 || 
                cb_Phong.SelectedIndex == -1 ||
                string.IsNullOrEmpty(tb_Email.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                tb_TenKhach.Focus();
                return;
            }

            string Khach = tb_TenKhach.Text.Trim();
            string TenPhim = cb_Phim.SelectedItem.ToString();

            if (!Ghe_Da_Dat.ContainsKey(Khach))
                Ghe_Da_Dat[Khach] = new List<string>();

            var Cac_Ghe_Dang_Chon = clb_Ghe.CheckedItems.Cast<string>().ToList();

            List<string> Ghe_Moi_Hop_Le = new List<string>();

            foreach (var Ghe_Hien_Thi in Cac_Ghe_Dang_Chon)
            {
                string Key_Luu_Tru = $"{TenPhim} - {Ghe_Hien_Thi}";

                bool Da_Bi_Dat = Ghe_Da_Dat.Values.Any(List => List.Contains(Key_Luu_Tru));

                if (!Da_Bi_Dat)
                {
                    Ghe_Moi_Hop_Le.Add(Ghe_Hien_Thi);
                }
            }

            if (Ghe_Moi_Hop_Le.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế hoặc ghế bạn chọn đã có người nhanh tay đặt trước!");
                return;
            }

            var movie = Danh_Sach_Phim.FirstOrDefault(P => P.Ten_Phim == TenPhim);
            if (movie == null) return;

            int Gia_Ve = movie.Gia_Ve;
            double Tong_Tien = 0;
            List<string> Chi_Tiet_Ve_In_Ra = new List<string>();

            foreach (var Ghe_Hien_Thi in Ghe_Moi_Hop_Le)
            {
                string Key_Luu_Tru = $"{TenPhim} - {Ghe_Hien_Thi}";
                Ghe_Da_Dat[Khach].Add(Key_Luu_Tru);

                Tong_Tien += Gia_Ve;

                Chi_Tiet_Ve_In_Ra.Add(Ghe_Hien_Thi);
            }

            cb_Phong_SelectedIndexChanged(sender, e);

            tb_KQ.Text = $"Họ tên: {Khach}" + Environment.NewLine +
                         $"Phim: {TenPhim}" + Environment.NewLine +
                         $"Thể loại: {movie.The_Loai}" + Environment.NewLine +
                         $"Thời lượng: {movie.Thoi_Luong}" + Environment.NewLine +
                         $"Phòng chiếu: {cb_Phong.SelectedItem}" + Environment.NewLine +
                         $"Ghế: {string.Join(", ", Chi_Tiet_Ve_In_Ra)}" + Environment.NewLine +
                         $"Tổng tiền: {Tong_Tien}đ";
            try
            {
                using (var Client = new SmtpClient())
                {
                    Client.Connect("smtp.gmail.com", 465, true);
                    Client.Authenticate("hungnd.attt2024@gmail.com", "rigu cwqp sjrd bkmk");

                    var Message = new MimeMessage();
                    Message.From.Add(new MailboxAddress("Rạp phim 3 chú hề", "hungnd.attt2024@gmail.com"));
                    Message.To.Add(new MailboxAddress("", tb_Email.Text));
                    Message.Subject = "Hóa đơn vé xem phim";

                    Message.Body = new TextPart("plain")
                    {
                        Text = $"Họ tên: {Khach}" + "\n" +
                               $"Phim: {TenPhim}" + "\n" +
                               $"Thể loại: {movie.The_Loai}" + "\n" +
                               $"Thời lượng: {movie.Thoi_Luong}" + "\n" +
                               $"Phòng chiếu: {cb_Phong.SelectedItem}" + "\n" +
                               $"Ghế: {string.Join(", ", Chi_Tiet_Ve_In_Ra)}" + "\n" +
                               $"Tổng tiền: {Tong_Tien}đ" + "\n" + 
                               "Nơi nào bạn ngồi nơi đó là long ngai!"
                    };

                    Client.Send(Message);

                    MessageBox.Show("Gửi email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_Email.Text = "";
                    tb_TenKhach.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            tb_KQ.Clear();
            tb_TenKhach.Clear();
        }
    }
}
