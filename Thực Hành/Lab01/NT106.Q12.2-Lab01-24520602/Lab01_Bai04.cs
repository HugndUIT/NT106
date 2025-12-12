using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string[] sotunhien = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        private string DocBaSo(int n)
        {
            if (n == 0) return "";
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donvi = n % 10;
            string kq = "";
            if (tram > 0)
            {
                kq += sotunhien[tram] + " trăm";
                if (chuc == 0 && donvi > 0) kq += " lẻ";
            }
            if (chuc > 1)
            {
                kq += " " + sotunhien[chuc] + " mươi";
                if (donvi == 1) kq += " mốt";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + sotunhien[donvi];
            }
            else if (chuc == 1)
            {
                kq += " mười";
                if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + sotunhien[donvi];
            }
            else if (chuc == 0 && donvi > 0 && tram > 0)
            {
                if (donvi == 5) kq += " năm";
                else kq += " " + sotunhien[donvi];
            }
            else if (chuc == 0 && tram == 0 && donvi > 0)
            {
                kq += sotunhien[donvi];
            }
            return kq.Trim();
        }

        private string DocSo(long n)
        {
            if (n == 0) return "Không";
            string[] hang = { "", "nghìn", "triệu", "tỷ" };
            string ketQua = "";
            int i = 0;
            while (n > 0 && i < hang.Length)
            {
                int temp = (int)(n % 1000);
                if (temp > 0)
                {
                    string sotram = DocBaSo(temp);
                    if (ketQua.Length > 0) ketQua = sotram + " " + hang[i] + ", " + ketQua;
                    else ketQua = sotram + " " + hang[i];
                }
                n /= 1000;
                i++;
            }
            return char.ToUpper(ketQua[0]) + ketQua.Substring(1);
        }

        private void tb_nhapso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(tb_nhapso.Text, out long so))
            {
                MessageBox.Show("Nhập sai định dạng! Vui lòng nhập số tự nhiên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (so < 0)
            {
                MessageBox.Show("Nhập sai định dạng! Vui lòng nhập số tự nhiên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tb_ketqua.Text = DocSo(so);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_nhapso.Clear();
            tb_ketqua.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
