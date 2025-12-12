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

namespace Bai6
{
    public partial class frm_SendEmail: Form
    {
        int Port;
        string Host;
        string Email;
        string Password;

        public frm_SendEmail(string Email, string Password, string Host, int Port)
        {
            InitializeComponent();
            this.Host = Host;
            this.Port = Port;
            this.Email = Email;
            this.Password = Password;
            tb_EmailSender.Text = Email;
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_Attach.Text = ofd.FileName;
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_EmailReceived.Text)
                || string.IsNullOrEmpty(tb_Subject.Text)
                || string.IsNullOrEmpty(rtb_Body.Text))
            {
                MessageBox.Show("Vui lòng nhập đi đủ thông tin!");
                return;
            }

            try
            {
                using (var Client = new SmtpClient())
                {
                    Client.Connect(Host, Port, true);
                    Client.Authenticate(Email, Password);

                    var Message = new MimeMessage();
                    Message.From.Add(new MailboxAddress(tb_Name.Text, tb_EmailSender.Text));
                    Message.To.Add(new MailboxAddress("", tb_EmailReceived.Text));
                    Message.Subject = tb_Subject.Text;
                    var builder = new BodyBuilder();

                    if (cb_HTML.Checked)
                    {
                        builder.HtmlBody = rtb_Body.Text;
                    }
                    else
                    {
                        builder.TextBody = rtb_Body.Text;
                    }

                    string File_Path = tb_Attach.Text;
                    if (!string.IsNullOrEmpty(File_Path) && System.IO.File.Exists(File_Path))
                    {
                        builder.Attachments.Add(File_Path);
                    }

                    Message.Body = builder.ToMessageBody();

                    Client.Send(Message);

                    MessageBox.Show("Gửi email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_EmailReceived.Text = "";
                    tb_Subject.Text = "";
                    rtb_Body.Text = "";
                    tb_Attach.Text = "";
                    cb_HTML.Checked = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error");
            }
        }
    }
}
