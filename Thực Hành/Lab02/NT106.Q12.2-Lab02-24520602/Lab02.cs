using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.Q12._2_Lab02_24520602
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void Bai_01_Click(object sender, EventArgs e)
        {
            Lab02_Bai1 Bai1 = new Lab02_Bai1();
            Bai1.Show();
        }

        private void Bai_02_Click(object sender, EventArgs e)
        {
            Lab02_Bai2 Bai2 = new Lab02_Bai2();
            Bai2.Show();
        }

        private void Bai_03_Click(object sender, EventArgs e)
        {
            Lab02_Bai3 Bai3 = new Lab02_Bai3();
            Bai3.Show();
        }

        private void Bai_04_Click_1(object sender, EventArgs e)
        {
            Lab02_Bai4 Bai4 = new Lab02_Bai4();
            Bai4.Show();
        }

        private void Bai_05_Click(object sender, EventArgs e)
        {
            Lab02_Bai5 Bai5 = new Lab02_Bai5();
            Bai5.Show();
        }

        private void Bai_06_Click(object sender, EventArgs e)
        {
            Lab02_Bai6 Bai6 = new Lab02_Bai6();
            Bai6.Show();
        }

        private void Bai_07_Click(object sender, EventArgs e)
        {
            Lab02_Bai7 Bai7 = new Lab02_Bai7();
            Bai7.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
