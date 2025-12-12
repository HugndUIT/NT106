using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Bai5
{
    public partial class Send_Mail : Form
    {
        public Send_Mail()
        {
            InitializeComponent();
            ds = new List<(string TenMon, string Link)>();
        }

        List<(string TenMon, string Link)> ds;
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_EmailSender.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu xác thực", "Lỗi");
                return;
            }

            if(ds.Count() == 0)
            {
                MessageBox.Show("Chưa có món ăn trong danh sách gửi đi!", "Lỗi");
                return;
            }

            var client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(tb_EmailSender.Text, tb_Password.Text); 

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(string.IsNullOrEmpty(tb_Name.Text) ? "Người ẩn danh" : tb_Name.Text.Trim()
                    , tb_EmailSender.Text.Trim()));
                message.To.Add(new MailboxAddress("", "lab5.24520549.24520254.24520602@gmail.com"));
                message.Subject = "Đóng góp món ăn";

                message.Body = new TextPart("plain")
                {
                    Text = MakeBody()
                };

                Task.Run(() =>
                {
                    client.Send(message);
                    MessageBox.Show("Tin nhắn gửi thành công!");

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error");
            }

            ds.Clear();
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(tb_tenmonan.Text) ||
                string.IsNullOrEmpty(tb_link.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên món ăn và link ảnh!", "Cảnh báo!!");
                return;
            }

            ds.Add((tb_tenmonan.Text, tb_link.Text));

            MessageBox.Show("Đã thêm món ăn");
            tb_tenmonan.Clear();
            tb_link.Clear();
        }

        private string MakeBody()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var mon in ds)
            {
                sb.AppendLine($"{mon.TenMon};{mon.Link}");
            }

            return sb.ToString();
        }
    }
}
