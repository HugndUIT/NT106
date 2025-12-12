using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai2
{
    public partial class frm_Bai2 : Form
    {
        public frm_Bai2()
        {
            InitializeComponent();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            if (string.IsNullOrEmpty(tb_URL.Text) || string.IsNullOrEmpty(tb_FileSave.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            try
            {
                using (Stream Respone = webClient.OpenRead(tb_URL.Text))
                {
                    try
                    {
                        Task.Run(() =>
                            {
                               webClient.DownloadFile(tb_URL.Text, tb_FileSave.Text);
                            }
                        );

                        this.Invoke(new Action(() =>
                        {
                            try
                            {
                                using (StreamReader sr = new StreamReader(Respone))
                                {
                                    rtb_FileHTML.Text = sr.ReadToEnd();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi đọc dữ liệu " + ex.Message);
                            }
                        }
                        ));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở file " + ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi truy cập trang web: " + ex.Message);
            }
        }

        private void tb_FileSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tb_FileSave.Text = ofd.FileName;
        }
    }
}
