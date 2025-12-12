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
    public partial class Lab02_Bai2 : Form
    {
        public Lab02_Bai2()
        {
            InitializeComponent();
        }

        private void btn_docfile_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_thongtin.Clear();
                // Chọn tệp muốn đọc từ máy tính
                OpenFileDialog ofd = new OpenFileDialog();
                // Hiển thị các tệp có đuôi .txt để chọn
                ofd.Filter = "Text files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    // Hiển thị tên file
                    tb_filename.Text = ofd.SafeFileName.ToString();
                    // Hiển thị kích thước file
                    tb_size.Text = fs.Length + " bytes";
                    // Hiển thị url
                    tb_url.Text = ofd.FileName.ToString();
                    int linecount = 0, wordcount = 0, charcount = 0;
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        linecount++;
                        charcount += line.Length;
                        wordcount += line.Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).Length;
                        rtb_thongtin.AppendText(line + Environment.NewLine);
                    }
                    // Hiển thị số dòng
                    tb_linescount.Text = linecount.ToString();
                    // Hiển thị số chữ
                    tb_wordscount.Text = wordcount.ToString();
                    // Hiển thị số kí tự
                    tb_characterscount.Text = charcount.ToString();
                    sr.Close();
                    fs.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
