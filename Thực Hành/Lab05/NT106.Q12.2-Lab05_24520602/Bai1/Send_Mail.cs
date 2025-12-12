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
using System.Threading.Tasks;

namespace Bai1
{
    public partial class Lab5_Bai1 : Form
    {
        public Lab5_Bai1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient();
            if (string.IsNullOrEmpty(tb_EmailReceiver.Text) 
                || string.IsNullOrEmpty(tb_EmailSender.Text) 
                || string.IsNullOrEmpty(tb_Subject.Text) 
                || string.IsNullOrEmpty(rtb_Body.Text))
                MessageBox.Show("Vui lòng nhập đi đủ thông tin!");
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("dangnguyen332006@gmail.com", "onjz liwb adzd dxyh"); //Mật khẩu riêng cho từng thiết bị 

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Khanh Dang", tb_EmailSender.Text));
                message.To.Add(new MailboxAddress("", tb_EmailReceiver.Text));
                message.Subject = tb_Subject.Text;

                message.Body = new TextPart("plain")
                {
                    Text = rtb_Body.Text
                };

                Task.Run(() =>
                {
                    client.Send(message);
                    MessageBox.Show("Tin nhắn gửi thành công!");

                });
    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error");
            }
        }
    }
}
