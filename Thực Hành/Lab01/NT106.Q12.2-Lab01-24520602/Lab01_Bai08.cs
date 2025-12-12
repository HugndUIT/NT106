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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void tb_nhapthongtin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nhapthongtin.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string info = tb_nhapthongtin.Text;
            string[] words = info.Split(',');
            string name = words[0];
            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
            {
                MessageBox.Show("Tên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 1; i < words.Length; i++)
            {
                string numStr = words[i].Trim();
                if (!double.TryParse(numStr, out _))
                {
                    MessageBox.Show($"Giá trị '{numStr}' không phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            List<double> score = new List<double>();
            for (int i = 1; i < words.Length; i++)
            {
                score.Add(double.Parse(words[i]));
            }
            tb_ketqua.Text += "Họ và tên: " + name + Environment.NewLine;
            for (int i = 0; i < score.Count; i++)
            {
                tb_ketqua.Text += "Môn " + (i + 1).ToString() + ": " + score[i].ToString() + " ";
            }
            tb_ketqua.Text += Environment.NewLine;
            double dtb = score.Average();
            tb_ketqua.Text += "Điểm trung bình: " + dtb.ToString("0.00") + Environment.NewLine;
            double diemMax = score.Max();
            double diemMin = score.Min();
            tb_ketqua.Text += "Điểm cao nhất: " + diemMax + Environment.NewLine;
            tb_ketqua.Text += "Điểm thấp nhất: " + diemMin + Environment.NewLine;
            int soMonDau = 0;
            foreach (double diem in score)
            {
                if (diem >= 5)
                    soMonDau++;
            }
            int soMonRot = score.Count - soMonDau;
            tb_ketqua.Text += "Số môn đậu: " + soMonDau + Environment.NewLine;
            tb_ketqua.Text += "Số môn rớt: " + soMonRot + Environment.NewLine;
            string xepLoai = "";
            bool allcaohon65 = true;
            foreach (double diem in score)
            {
                if (diem < 6.5)
                {
                    allcaohon65 = false;
                    break;
                }
            }
            bool allcaohon5 = true;
            foreach (double diem in score)
            {
                if (diem < 5)
                {
                    allcaohon5 = false;
                    break;
                }
            }
            bool allcaohon35 = true;
            foreach (double diem in score)
            {
                if (diem < 3.5)
                {
                    allcaohon35 = false;
                    break;
                }
            }
            bool allcaohon2 = true;
            foreach (double diem in score)
            {
                if (diem < 2)
                {
                    allcaohon2 = false;
                    break;
                }
            }
            if (dtb >= 8 && allcaohon65)
            {
                xepLoai = "Giỏi";
            }
            else if (dtb >= 6.5 && allcaohon5)
            {
                xepLoai = "Khá";
            }
            else if (dtb >= 5 && allcaohon35)
            {
                xepLoai = "Trung bình";
            }
            else if (dtb >= 3.5 && allcaohon2)
            {
                xepLoai = "Yếu";
            }
            else
            {
                xepLoai = "Kém";
            }
            tb_ketqua.Text += "Xếp loại: " + xepLoai + Environment.NewLine;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_nhapthongtin.Clear();
            tb_ketqua.Clear();  
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
