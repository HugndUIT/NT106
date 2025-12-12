using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_url.Text))
            {
                MessageBox.Show("Vui lòng nhập URL!");
                return;
            } 
            rtb_html.Text = Get_HTML(tb_url.Text);
        }

        private string Get_HTML(string URL)
        {
            WebRequest request = WebRequest.Create(URL);

            WebResponse response = request.GetResponse();

            Stream Data_Stream = response.GetResponseStream();

            StreamReader Reader = new StreamReader(Data_Stream);

            string Respone_Form_Server = Reader.ReadToEnd();

            response.Close();

            return Respone_Form_Server;
        }
    }
}

// https://student.uit.edu.vn/