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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tb_sothunhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_sothuhai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_sothuba_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_max_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            double a, b, c, max, min;
            if (!double.TryParse(tb_sothunhat.Text, out a) || !double.TryParse(tb_sothuhai.Text, out b) || !double.TryParse(tb_sothuba.Text, out c)) 
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (a >= b && a >= c) max = a;
                else if (b >= a && b >= c) max = b;
                else max = c;
                tb_max.Text = max.ToString();
                if (a <= b && a <= c) min = a;
                else if (b <= a && b <= c) min = b;
                else min = c;
                tb_min.Text = min.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_sothunhat.Clear();
            tb_sothuhai.Clear();
            tb_sothuba.Clear();
            tb_max.Clear();
            tb_min.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
