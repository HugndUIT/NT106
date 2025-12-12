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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void tb_nhapmonan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_danhsach_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_kqmonan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timmonan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_danhsach.Text))
            {
                MessageBox.Show("Chưa có món ăn nào!, vui lòng thêm món ăn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = tb_danhsach.Lines;
            List<string> foods = new List<string>();
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    foods.Add(line.Trim());
                }
            }
            Random random = new Random();
            int index = random.Next(foods.Count);
            string ansfood = foods[index];
            tb_kqmonan.Text = ansfood;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string food = tb_nhapmonan.Text.Trim();
            if (!string.IsNullOrEmpty(food))
            {
                tb_danhsach.AppendText(food + Environment.NewLine);
                tb_nhapmonan.Clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_danhsach.Clear();
            tb_kqmonan.Clear();
            tb_nhapmonan.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
