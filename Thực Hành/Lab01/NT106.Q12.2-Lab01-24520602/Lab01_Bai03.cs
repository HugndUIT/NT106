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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tb_nhapso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_docso_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_nhapso.Text, out int number))
            {
                MessageBox.Show("Vui lòng nhập số đúng định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (number < 0 || number > 9)
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên trong khoảng từ 0 đến 9!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (number)
                {
                    case 0:
                        tb_ketqua.Text = "Không";
                        break;
                    case 1:
                        tb_ketqua.Text = "Một";
                        break;
                    case 2:
                        tb_ketqua.Text = "Hai";
                        break;
                    case 3:
                        tb_ketqua.Text = "Ba";
                        break;
                    case 4:
                        tb_ketqua.Text = "Bốn";
                        break;
                    case 5:
                        tb_ketqua.Text = "Năm";
                        break;
                    case 6:
                        tb_ketqua.Text = "Sáu";
                        break;
                    case 7:
                        tb_ketqua.Text = "Bảy";
                        break;
                    case 8:
                        tb_ketqua.Text = "Tám";
                        break;
                    default:
                        tb_ketqua.Text = "Chín";
                        break;
                }
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
