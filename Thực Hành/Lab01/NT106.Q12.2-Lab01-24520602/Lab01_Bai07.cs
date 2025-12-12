using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            int day, month;
            if (string.IsNullOrEmpty(tb_nhapngaysinh.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tb_nhapthangsinh.Text))
            {
                MessageBox.Show("Vui lòng nhập tháng sinh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tb_nhapngaysinh.Text, out day))
            {
                MessageBox.Show("Nhập sai định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tb_nhapthangsinh.Text, out month))
            {
                MessageBox.Show("Nhập sai định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (month < 1 || month > 12)
            {
                MessageBox.Show("Tháng không hợp lệ! (1-12)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int[] daysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day < 1 || day > daysInMonth[month - 1])
            {
                MessageBox.Show("Ngày không hợp lệ cho tháng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (month)
            {
                case 1:
                    if (day <= 20)
                        tb_ketqua.Text = "Cung ma kết";
                    else
                        tb_ketqua.Text = "Cung bảo bình";
                    break;
                case 2:
                    if (day <= 19)
                        tb_ketqua.Text = "Cung bảo bình";
                    else
                        tb_ketqua.Text = "Cung song ngư";
                    break;
                case 3:
                    if (day <= 20)
                        tb_ketqua.Text = "Cung song ngư";
                    else
                        tb_ketqua.Text = "Cung bạch dương";
                    break;
                case 4:
                    if (day <= 20)
                        tb_ketqua.Text = "Cung bạch dương";
                    else
                        tb_ketqua.Text = "Cung kim ngưu";
                    break;
                case 5:
                    if (day <= 21)
                        tb_ketqua.Text = "Cung kim ngưu";
                    else
                        tb_ketqua.Text = "Cung song tử";
                    break;
                case 6:
                    if (day <= 21)
                        tb_ketqua.Text = "Cung song tử";
                    else
                        tb_ketqua.Text = "Cung cự giải";
                    break;
                case 7:
                    if (day <= 22)
                        tb_ketqua.Text = "Cung cự giải";
                    else
                        tb_ketqua.Text = "Cung sư tử";
                    break;
                case 8:
                    if (day <= 22)
                        tb_ketqua.Text = "Cung sư tử";
                    else
                        tb_ketqua.Text = "Cung xử nữ";
                    break;
                case 9:
                    if (day <= 20)
                        tb_ketqua.Text = "Cung xử nữ";
                    else
                        tb_ketqua.Text = "Cung thiên bình";
                    break;
                case 10:
                    if (day <= 23)
                        tb_ketqua.Text = "Cung thiên bình";
                    else
                        tb_ketqua.Text = "Cung thần nông";
                    break;
                case 11:
                    if (day <= 22)
                        tb_ketqua.Text = "Cung thần nông";
                    else
                        tb_ketqua.Text = "Cung nhân mã";
                    break;
                default:
                    if (day <= 21)
                        tb_ketqua.Text = "Cung nhân mã";
                    else
                        tb_ketqua.Text = "Cung ma kết";
                    break;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_nhapngaysinh.Clear();
            tb_nhapthangsinh.Clear();
            tb_ketqua.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_nhapngaysinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nhapthangsinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
