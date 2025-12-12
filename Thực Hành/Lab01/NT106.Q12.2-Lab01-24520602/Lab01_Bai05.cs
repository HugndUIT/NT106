using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Form5 : Form
    {
        HashSet<string> gheDaDat = new HashSet<string>();
        public Form5()
        {
            InitializeComponent();
            foreach (var phong in new[] { "1", "2", "3" })
            {
                gheDaDat.Add($"{phong}-B1");
                gheDaDat.Add($"{phong}-B5");
            }
        }

        Dictionary<string, int> giaVeChuan = new Dictionary<string, int>()
        {
            {"Đào, phở và piano", 45000},
            {"Mai", 100000},
            {"Gặp lại chị bầu", 70000},
            {"Tarot", 90000}
        };

        Dictionary<string, List<string>> phongChieu = new Dictionary<string, List<string>>()
        {
            {"Đào, phở và piano", new List<string> {"1", "2", "3"} },
            {"Mai", new List<string> {"2", "3"} },
            {"Gặp lại chị bầu", new List<string> {"1"} },
            {"Tarot", new List<string> {"3"} }
        };

        static Dictionary<string, double> heSoGiaVe = new Dictionary<string, double>()
        {
            {"A1", 0.25}, {"A5", 0.25}, {"C1", 0.25}, {"C5", 0.25},
            {"A2", 1}, {"A3", 1}, {"A4", 1},
            {"C2", 1}, {"C3", 1}, {"C4", 1},
            {"B2", 2}, {"B3", 2}, {"B4", 2}
        };

        private void Form5_Load(object sender, EventArgs e)
        {
            cb_chonphim.DataSource = giaVeChuan.Keys.ToList();
        }

        private void clb_chonghe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_tenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_chonphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phim = cb_chonphim.SelectedItem.ToString();
            cb_chonphong.DataSource = phongChieu[phim];
        }

        private void cb_chonphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phong = cb_chonphong.SelectedItem.ToString();
            clb_chonghe.Items.Clear();
            foreach (var hang in new[] { "A", "B", "C" })
            {
                for (int i = 1; i <= 5; i++)
                {
                    string ghe = $"{phong}-{hang}{i}";
                    int index = clb_chonghe.Items.Add(ghe, false); 
                    if (gheDaDat.Contains(ghe))
                    {
                        clb_chonghe.SetItemCheckState(index, CheckState.Indeterminate);
                    }
                }
            }
        }

        private void tb_thongtinve_TextChanged(object sender, EventArgs e)
        {

        }

        Dictionary<string, List<string>> gheTheoKhach = new Dictionary<string, List<string>>();

        private void btn_datve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_tenkhachhang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                tb_tenkhachhang.Focus();
                return;
            }
            string khach = tb_tenkhachhang.Text.Trim();
            if (!gheTheoKhach.ContainsKey(khach))
                gheTheoKhach[khach] = new List<string>();
            var gheCu = gheTheoKhach[khach];
            var gheChon = clb_chonghe.CheckedItems.Cast<string>().Where(g => !gheDaDat.Contains(g)).ToList();
            if (gheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế");
                return;
            }
            var tatCaPhong = gheCu.Concat(gheChon).Select(g => g.Split('-')[0]).Distinct().ToList();
            if (tatCaPhong.Count > 1 && gheCu.Count + gheChon.Count > 2)
            {
                MessageBox.Show("Không thể chọn nhiều hơn 2 vé ở 2 phòng chiếu khác nhau");
                return;
            }
            string phim = cb_chonphim.SelectedItem.ToString();
            int giaChuan = giaVeChuan[phim];
            double tongTien = 0;
            List<string> chiTietVe = new List<string>();
            foreach (var ghe in gheChon)
            {
                gheTheoKhach[khach].Add(ghe);  
                gheDaDat.Add(ghe);             

                string tenGhe = ghe.Split('-')[1];
                double heSo = heSoGiaVe.ContainsKey(tenGhe) ? heSoGiaVe[tenGhe] : 1;
                double tien = giaChuan * heSo;
                tongTien += tien;
                chiTietVe.Add($"{ghe}");
            }
            tb_thongtinve.Text = $"Họ tên: {tb_tenkhachhang.Text}" + Environment.NewLine +
                                 $"Phim: {phim}" + Environment.NewLine +
                                 $"Phòng chiếu: {cb_chonphong.SelectedItem}" + Environment.NewLine +
                                 $"Ghế: {string.Join(", ", chiTietVe)}" + Environment.NewLine +
                                 $"Tổng tiền: {tongTien}đ";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_tenkhachhang.Clear();
            tb_thongtinve.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
