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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void tb_nhapsoA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_nhapsoB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbb_choncachtinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nhapsoA.Text))
            {
                MessageBox.Show("Vui lòng nhập A!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(tb_nhapsoA.Text, out long A))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nhapsoA.Clear();
                return;
            }
            if (string.IsNullOrEmpty(tb_nhapsoB.Text))
            {
                MessageBox.Show("Vui lòng nhập B!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(tb_nhapsoB.Text, out long B))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nhapsoB.Clear();
                return;
            }
            if (cbb_choncachtinh.SelectedIndex == 0)
            {
                long temp = B - A;
                for (int i = 1; i <= 10; i++)
                {
                    tb_ketqua.Text += temp.ToString() + " x " + i.ToString() + " = " + (temp * i).ToString() + Environment.NewLine;
                }
            }
            else if (cbb_choncachtinh.SelectedIndex == 1)
            {
                if (A <= B)
                {
                    MessageBox.Show("Vui lòng nhập A lớn hơn B!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_nhapsoA.Clear();
                    tb_nhapsoB.Clear();
                    return;
                } 
                else if (B <= 0)
                {
                    MessageBox.Show("Vui lòng nhập B > 0!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_nhapsoA.Clear();
                    tb_nhapsoB.Clear();
                    return;
                }
                long factorial = 1;
                for (int i = 1; i <= A - B; i++)
                {
                    factorial *= i;
                }
                tb_ketqua.Text += "(A - B)! = " + factorial.ToString() + Environment.NewLine;
                double sum = 0;
                for (int i = 1; i <= B; i++)
                {
                    sum += Math.Pow(A, i);
                }
                tb_ketqua.Text += "S = A^1 + A^2 + A^3 + A^4 + … + A^B = " + sum.ToString() + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cách tính!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_nhapsoA.Clear();
            tb_nhapsoB.Clear();
            tb_ketqua.Clear();
            cbb_choncachtinh.SelectedIndex = -1;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_ketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
