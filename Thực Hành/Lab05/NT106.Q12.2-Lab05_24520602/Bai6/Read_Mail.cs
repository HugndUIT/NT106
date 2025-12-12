using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MailKit;
using MimeKit;


namespace Bai6
{
    public partial class Read_Mail : Form
    {
        public Read_Mail(MimeMessage message)
        {
            InitializeComponent();
            Mail = message;
        }

        MimeMessage Mail = new MimeMessage();
        private void Read_Mail_Load(object sender, EventArgs e)
        {
            ShowContent(Mail);
        }

        private void ShowContent(MimeMessage message)
        {
            lbl_From.Text += message.From.ToString();
            lbl_To.Text += message.To.ToString();
            lbl_Subject.Text = message.Subject;

            if(string.IsNullOrEmpty(message.HtmlBody))
            {
                wb_Mail.Visible = true;
                rtb_Body.Visible = false;
                wb_Mail.DocumentText = message.HtmlBody;
            }
            else
            {
                wb_Mail.Visible = false;
                rtb_Body.Visible = true;
                rtb_Body.Text = message.TextBody;
            }
        }
    }
}
