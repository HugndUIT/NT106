using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai04
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        TcpClient TCP_Client;

        NetworkStream Stream;

        Thread Client_Thread;

        private void Client_Load(object sender, EventArgs e)
        {
            try
            {
                TCP_Client = new TcpClient("127.0.0.1", 1111);

                Stream = TCP_Client.GetStream();

                Client_Thread = new Thread(Receive_Data);
                Client_Thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!\n" + ex.Message);
                this.Close();
            }
        }

        void Receive_Data()
        {
            try
            {
                byte[] Buffer = new byte[8192];
                int Bytes_Received = Stream.Read(Buffer, 0, Buffer.Length);

                string Json = Encoding.UTF8.GetString(Buffer, 0, Bytes_Received);

                var Data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(Json);

                Ghe_Da_Dat = JsonSerializer.Deserialize<HashSet<string>>(Data["Reserved_Seats"].GetRawText());
                Gia_Ve_Chuan = JsonSerializer.Deserialize<Dictionary<string, int>>(Data["Ticket_Price"].GetRawText());
                He_So_Gia_Ve = JsonSerializer.Deserialize<Dictionary<string, double>>(Data["Coefficient"].GetRawText());
                Phong_Chieu = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(Data["Screening_Room"].GetRawText());

                this.Invoke(new Action(() =>
                {
                    cb_chonphim.DataSource = Gia_Ve_Chuan.Keys.ToList();
                }
                ));

                Listen_For_Updates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving data:\n" + ex.Message);
            }
        }

        void Listen_For_Updates()
        {
            try
            {
                while (true)
                {
                    byte[] Buffer = new byte[4096];
                    int Bytes_Received = Stream.Read(Buffer, 0, Buffer.Length);
                    if (Bytes_Received == 0) break;

                    string Message = Encoding.UTF8.GetString(Buffer, 0, Bytes_Received);
                    var Data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(Message);

                    if (Data.ContainsKey("Type") && Data["Type"].GetString() == "Cập nhật ghế")
                    {
                        var UpdatedSeats = JsonSerializer.Deserialize<List<string>>(Data["Reserved_Seats"].GetRawText());

                        lock (Ghe_Da_Dat)
                        {
                            Ghe_Da_Dat = new HashSet<string>(UpdatedSeats);
                        }

                        this.Invoke(new Action(() =>
                        {
                            foreach (int i in Enumerable.Range(0, clb_chonghe.Items.Count))
                            {
                                string ghe = clb_chonghe.Items[i].ToString();
                                if (Ghe_Da_Dat.Contains(ghe))
                                    clb_chonghe.SetItemCheckState(i, CheckState.Indeterminate);
                            }
                        }
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => MessageBox.Show("Ngắt kết nối:\n" + ex.Message)));
            }
        }


        HashSet<string> Ghe_Da_Dat = new HashSet<string>();

        Dictionary<string, int> Gia_Ve_Chuan = new Dictionary<string, int>();

        Dictionary<string, List<string>> Phong_Chieu = new Dictionary<string, List<string>>();

        Dictionary<string, double> He_So_Gia_Ve = new Dictionary<string, double>();

        Dictionary<string, List<string>> Ghe_Theo_Khach = new Dictionary<string, List<string>>();

        private void cb_chonphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Phim = cb_chonphim.SelectedItem.ToString();
            cb_chonphong.DataSource = Phong_Chieu[Phim];
        }

        private void cb_chonphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Phong = cb_chonphong.SelectedItem.ToString();
            clb_chonghe.Items.Clear();
            foreach (var Hang_Ghe in new[] { "A", "B","C" })
            {
                for (int i = 1; i <= 5; i++)
                {
                    string Ghe = $"{Phong} - {Hang_Ghe}{i}";
                    int Index = clb_chonghe.Items.Add(Ghe, false);
                    if (Ghe_Da_Dat.Contains(Ghe))
                    {
                        clb_chonghe.SetItemCheckState(Index, CheckState.Indeterminate);
                    }
                }
            }
        }

        private void btn_datve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_tenkhachhang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                tb_tenkhachhang.Focus();
                return;
            }

            string Khach = tb_tenkhachhang.Text.Trim();

            if (!Ghe_Theo_Khach.ContainsKey(Khach))
                Ghe_Theo_Khach[Khach] = new List<string>();

            var Ghe_Cu = Ghe_Theo_Khach[Khach];

            var Ghe_Moi = clb_chonghe.CheckedItems.Cast<string>().Where(g => !Ghe_Da_Dat.Contains(g)).ToList();

            if (Ghe_Moi.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế");
                return;
            }

            var tatCaPhong = Ghe_Cu.Concat(Ghe_Moi).Select(g => g.Split('-')[0]).Distinct().ToList();

            if (tatCaPhong.Count > 1 && Ghe_Cu.Count + Ghe_Moi.Count > 2)
            {
                MessageBox.Show("Không thể chọn nhiều hơn 2 vé ở 2 quầy khác nhau");
                return;
            }

            string Phim = cb_chonphim.SelectedItem.ToString();

            int Gia_Chuan = Gia_Ve_Chuan[Phim];

            double Tong_Tien = 0;
            List<string> Chi_Tiet_Ve = new List<string>();
            foreach (var Ghe in Ghe_Moi)
            {
                Ghe_Theo_Khach[Khach].Add(Ghe);
                Ghe_Da_Dat.Add(Ghe);

                string tenGhe = Ghe.Split('-')[1];

                double heSo = He_So_Gia_Ve.ContainsKey(tenGhe) ? He_So_Gia_Ve[tenGhe] : 1;

                double Tien = Gia_Chuan * heSo;

                Tong_Tien += Tien;

                Chi_Tiet_Ve.Add($"{Ghe}");
            }

            try
            {
                var Data_Send = new
                {
                    Type = "Đặt vé",
                    New_Chair = Ghe_Moi,
                };

                string Json = JsonSerializer.Serialize(Data_Send);
                byte[] Buffer = Encoding.UTF8.GetBytes(Json);
                Stream.Write(Buffer, 0, Buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tb_thongtinve.Text = $"Họ tên: {tb_tenkhachhang.Text}" + Environment.NewLine +
                                 $"Phim: {Phim}" + Environment.NewLine +
                                 $"Phòng chiếu: {cb_chonphong.SelectedItem}" + Environment.NewLine +
                                 $"Ghế: {string.Join(", ", Chi_Tiet_Ve)}" + Environment.NewLine +
                                 $"Tổng tiền: {Tong_Tien}đ";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_thongtinve.Clear();
            tb_tenkhachhang.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clb_chonghe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_tenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_thongtinve_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
