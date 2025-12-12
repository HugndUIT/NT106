using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MimeKit;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;

namespace Bai5
{
    public partial class Hom_Nay_An_Gi : Form
    {
        Timer CapNhatMon;

        // Chuỗi kết nối SQL
        static string ConnectionSQL = "Data Source=SQLHomNayAnGi.db;Version=3;";
        public Hom_Nay_An_Gi()
        {
            InitializeComponent();
            lv_dsmonan.Items.Clear();
            lv_dsmonan.Columns.Clear();
            lv_dsmonan.View = View.Details;
            lv_dsmonan.Columns.Add("Tên Món", 100);
            lv_dsmonan.Columns.Add("Người đóng góp", 100);
            CapNhatMon = new Timer();
            CapNhatMon.Interval = 10000;
            CapNhatMon.Tick += CapNhatMon_Tick;
        }

        private void Hom_Nay_An_Gi_Load(object sender, EventArgs e)
        {
            LoadMonAn();

            CapNhatMon.Start();
        }

        private async void CapNhatMon_Tick(object sender, EventArgs e)
        {
            CapNhatMon.Stop();

            bool IsUpdate = await Task.Run(() => ThemMonDB());
            if (IsUpdate)
            {
                LoadMonAn();
            }
            CapNhatMon.Start();
        }

        private bool ThemMonDB()
        {
            bool IsUpdate = false;

            try
            {
                using(var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com",993);
                    client.Authenticate("lab5.24520549.24520254.24520602@gmail.com", "opgg amtv ynsy bpdw");
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadWrite);

                    var query = SearchQuery.NotSeen.And(SearchQuery.SubjectContains("Đóng góp món ăn"));
                    var mails = inbox.Search(query);

                    foreach(var mail in mails)
                    {
                        var message = inbox.GetMessage(mail);
                        string NguoiGui = "Người ẩn danh";
                        var sender = message.From.Mailboxes.FirstOrDefault();

                        if (sender != null)
                        {
                            if (!string.IsNullOrEmpty(sender.Name))
                            {
                                NguoiGui = sender.Name;
                            }
                        }
                        string NoiDung = message.TextBody;

                        string[] lines = NoiDung.Split(new [] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var line in lines)
                        {
                            string[] parts = line.Split(';');
                            if(parts.Length == 2)
                            {
                                string TenMon = parts[0].Trim();
                                string HinhAnh = parts[1].Trim();
                                if(!string.IsNullOrEmpty(TenMon) && !string.IsNullOrEmpty(HinhAnh))
                                {
                                    InsertMonAn(TenMon,HinhAnh,NguoiGui);
                                    IsUpdate = true;
                                }
                            }
                        }
                        inbox.AddFlags(mail, MessageFlags.Seen, true);
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return IsUpdate;
        }

        private void InsertMonAn(string tenmon, string anh, string nguoiDongGop)
        {
            using(SQLiteConnection conn = new SQLiteConnection(ConnectionSQL))
            {
                conn.Open();
                int id = -1;

                string CheckUser = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @hoTen";
                using (SQLiteCommand cmd = new SQLiteCommand(CheckUser, conn))
                {
                    cmd.Parameters.AddWithValue("@hoTen", nguoiDongGop);
                    var result = cmd.ExecuteScalar();
                    if(result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                    else
                    {
                        string InsertUser = "INSERT INTO NguoiDung (HoVaTen) VALUES (@hoTen); SELECT last_insert_rowid();";
                        using(SQLiteCommand cmdInsertUser = new SQLiteCommand(InsertUser, conn))
                        {
                            cmdInsertUser.Parameters.AddWithValue("@hoTen", nguoiDongGop);
                            id = (int)cmdInsertUser.ExecuteScalar();
                        }
                    }
                }

                string queryInsertMon = "INSERT INTO MonAn (TenMonAn,HinhAnh,IDNCC) VALUES (@tenMon, @hinhAnh, @idNCC)";
                using (SQLiteCommand cmdInsertMon = new SQLiteCommand(queryInsertMon, conn))
                {
                    cmdInsertMon.Parameters.AddWithValue("@tenMon", tenmon);
                    cmdInsertMon.Parameters.AddWithValue("@hinhAnh", anh);
                    cmdInsertMon.Parameters.AddWithValue("@idNCC", id);
                    cmdInsertMon.ExecuteNonQuery();
                }
            }
        }

        private void LoadMonAn()
        {
            lv_dsmonan.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionSQL))
            {
                conn.Open();
                string query = @"SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen FROM MonAn m LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenMon = reader["TenMonAn"].ToString();

                            string nguoiDongGop = reader["HoVaTen"] != DBNull.Value? reader["HoVaTen"].ToString(): "Người ẩn danh";

                            ListViewItem item = new ListViewItem(tenMon);
                            item.SubItems.Add(nguoiDongGop);
  
                            lv_dsmonan.Items.Add(item);
                        }
                    }
                }
            }
        }

        // Định nghĩa kiểu dữ liệu Food
        public class Food
        {
            public string FoodName { get; set; }
            public string Image { get; set; }
            public string NameNCC { get; set; }
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            Send_Mail form = new Send_Mail();
            form.Show();
        }

        private void btn_chonmon_Click(object sender, EventArgs e)
        {
            if(ptb_KetQua.Image != null)
            {
                ptb_KetQua.Image = null;
            }
            tb_KetQua.Clear();

            using (SQLiteConnection connect = new SQLiteConnection(ConnectionSQL))
            {
                connect.Open();
                string countFoods = "SELECT COUNT(*) FROM MonAn";
                using (SQLiteCommand command = new SQLiteCommand(countFoods, connect))
                {
                    object cnt = command.ExecuteScalar();
                    if (Convert.ToInt32(cnt) == 0)
                    {
                        MessageBox.Show("Danh sách món ăn trống!");
                        return;
                    }
                }
                string selectData = "SELECT TenMonAn, HinhAnh, HoVaTen FROM MonAn M JOIN NguoiDung D ON M.IDNCC = D.IDNCC";
                using (SQLiteCommand command = new SQLiteCommand(selectData, connect))
                {
                    List<Food> foods = new List<Food>();
                    using (SQLiteDataReader readData = command.ExecuteReader())
                    {
                        while (readData.Read())
                        {
                            Food monan = new Food()
                            {
                                FoodName = readData["TenMonAn"].ToString(),
                                Image = readData["HinhAnh"].ToString(),
                                NameNCC = readData["HoVaTen"].ToString()
                            };
                            foods.Add(monan);
                        }
                        Random random = new Random();
                        int index = random.Next(foods.Count);
                        Food HomNay = foods[index];
                        try
                        {
                            ptb_KetQua.Load(HomNay.Image);
                            ptb_KetQua.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        tb_KetQua.Text += $"Món Ăn: {HomNay.FoodName}\r\n";
                        tb_KetQua.Text += $"Người đóng góp: {HomNay.NameNCC}\r\n";
                       
                    }
                }
            }
        }
    }
}
