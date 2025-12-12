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
using System.Configuration;

namespace NT106.Q12._2_Lab02_24520602
{
    public partial class Lab02_Bai6 : Form
    {
        public Lab02_Bai6()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối SQL
        static string ConnectionSQL = "Data Source=SQLHomNayAnGi.db;Version=3;";
        
        private void Lab02_Bai6_Load(object sender, EventArgs e)
        {
          
        }

        private void tb_nhapmonan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_nhaptennguoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_quyenhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_linkhinhanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nhapmonan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }
            if (string.IsNullOrEmpty(tb_nhaptennguoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người cung cấp!");
                return;
            }
            if (string.IsNullOrEmpty(tb_quyenhan.Text))
            {
                MessageBox.Show("Vui lòng nhập quyền hạn nhà cung cấp!");
                return;
            }
            if (string.IsNullOrEmpty(tb_linkhinhanh.Text))
            {
                MessageBox.Show("Vui lòng nhập link hình ảnh!");
                return;
            }
            // Khởi tạo đường kết nối SQL
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionSQL))
            {
                // Kêt nối với SQL
                connect.Open();
                // Thêm người dùng
                string insertUsers = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@name, @authority)";
                // Thực hiện truy vấn
                using (SQLiteCommand command = new SQLiteCommand(insertUsers, connect))
                {
                    // Thay vào tham số trong câu SQL bằng dữ liệu của textbox
                    command.Parameters.AddWithValue("@name", tb_nhaptennguoi.Text);
                    command.Parameters.AddWithValue("@authority", tb_quyenhan.Text);
                    command.ExecuteNonQuery();
                }
                // Lấy ra ID (khóa chính) của dòng vừa mới được thêm gần nhất vào database
                long monanIDNCC = connect.LastInsertRowId; 
                // Thêm món ăn
                string insertFood = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@foodname, @linkimage, @idncc)";
                // Thực hiện truy vấn
                using (SQLiteCommand command = new SQLiteCommand(insertFood, connect))
                {
                    // Thay vào tham số trong câu SQL bằng dữ liệu của textbox
                    command.Parameters.AddWithValue("@foodname", tb_nhapmonan.Text);
                    command.Parameters.AddWithValue("@linkimage", tb_linkhinhanh.Text);
                    command.Parameters.AddWithValue("@idncc", monanIDNCC);
                    command.ExecuteNonQuery();
                }
                tb_nhapmonan.Clear();
                tb_linkhinhanh.Clear();
                tb_nhaptennguoi.Clear();
                tb_quyenhan.Clear();
                MessageBox.Show("Đã thêm món ăn thành công!");
            }
        }

        private void btn_xemmon_Click(object sender, EventArgs e)
        {
            //Xóa tất cả các dòng đang có trong ListView
            lv_dsmonan.Items.Clear();
            // Cho phép hiển thị dữ liệu theo dạng bảng có cột
            lv_dsmonan.View = View.Details;
            // Khi chọn một dòng, toàn bộ dòng được tô sáng
            lv_dsmonan.FullRowSelect = true;
            // Hiển thị đường kẻ giữa các ô trong bảng
            lv_dsmonan.GridLines = true;
            // Thêm một cột có tiêu đề “Tên món ăn”, rộng 300 pixel
            lv_dsmonan.Columns.Add("Tên món ăn", 300);
            // Thêm cột có tiêu đề "Người cung cấp", rộng 300 pixel
            lv_dsmonan.Columns.Add("Người cung cấp", 300);
            // Thêm cột có tiêu đề "Link hình ảnh" rộng 800 pixel
            lv_dsmonan.Columns.Add("Link hình ảnh", 800);
            // Khởi tạo đường kết nối SQL
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionSQL))
            {
                // Kết nói với SQL
                connect.Open();
                // Chọn các món ăn trong danh sách
                string selectData = "SELECT TenMonAn, HoVaTen, HinhAnh FROM MonAn JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                // Thực hiện truy vấn
                using (SQLiteCommand command = new SQLiteCommand(selectData, connect))
                {
                    // Thực thi câu lệnh và trá về dạng nhiều dòng (ExecuteReader), (SQLiteDataReacder) cho phép đọc dữ liệu từng dòng 1 từ kết quả truy vấn
                    using (SQLiteDataReader readData = command.ExecuteReader())
                    {
                        while (readData.Read())
                        {
                            // Tạo dòng đầu tiên với cột đầu tiên
                            ListViewItem item = new ListViewItem(readData["TenMonAn"].ToString());
                            // Thêm cột thứ 2
                            item.SubItems.Add(readData["HoVaTen"].ToString());
                            // Thêm cột thứ 3
                            item.SubItems.Add(readData["HinhAnh"].ToString());
                            // Thêm vào danh sách
                            lv_dsmonan.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btn_chonmon_Click(object sender, EventArgs e)
        {
            // Khởi tạo đường kết nối SQL
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionSQL))
            {
                // Kết nối với SQL
                connect.Open();
                // Đếm số món ăn
                string countFoods = "SELECT COUNT(*) FROM MonAn";
                // Thực hiện truy vấn
                using (SQLiteCommand command = new SQLiteCommand(countFoods, connect))
                {
                    // (ExecuteScalar) có kiểu dữ liệu object lấy giá trị duy nhất từ SQL
                    object cnt = command.ExecuteScalar();
                    // object là kiểu dữ liệu cơ sở có thể chứa bất kì kiểu dữ liệu nào
                    if (Convert.ToInt32(cnt) == 0)
                    {
                        MessageBox.Show("Danh sách món ăn trống!");
                        return;
                    }
                }
                // Chọn TenMonAn, HinhAnh, HoVaTen trong SQL
                string selectData = "SELECT TenMonAn, HinhAnh, HoVaTen FROM MonAn M JOIN NguoiDung D ON M.IDNCC = D.IDNCC";
                // Thực hiện truy vấn
                using (SQLiteCommand command = new SQLiteCommand(selectData, connect))
                {
                    // Danh sách có kiểu Food để lưu tạm thông tin
                    List<Food> foods = new List<Food>();
                    // Đọc dữ liệu từ SQL
                    using (SQLiteDataReader readData = command.ExecuteReader())
                    {
                        // Mỗi lần Read là xuống 1 dòng
                        while (readData.Read())
                        {
                            Food monan = new Food()
                            {
                                // Lấy dữ liệu từ cột TenMonAn bỏ vào FoodName
                                FoodName = readData["TenMonAn"].ToString(),
                                // Lấy dữ liệu từ cột HinhAnh bỏ vào Image
                                Image = readData["HinhAnh"].ToString(),
                                // Lấy dữ liệu từ cột HoVaTen bỏ vào NameNCC
                                NameNCC = readData["HoVaTen"].ToString()
                            };
                            foods.Add(monan);
                        }
                        // Dùng hàm random lấy món ăn
                        Random random = new Random();
                        int index = random.Next(foods.Count);
                        Food HomNay = foods[index];
                        try
                        {
                            ptb_ketquamonan.Load(HomNay.Image);
                            ptb_ketquamonan.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show($"Món ăn hôm nay: {HomNay.FoodName}\n" +
                                        $"Người cung cấp: {HomNay.NameNCC}"
                        );
                    }
                }
            }
        }

        private void lv_dsmonan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
    // Định nghĩa kiểu dữ liệu Food
    public class Food
    {
        public string FoodName { get; set; }
        public string Image { get; set; }
        public string NameNCC { get; set; }
    }
}
