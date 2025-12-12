using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;


namespace Bai2
{
    public partial class Mail_Reader : Form
    {
        public Mail_Reader()
        {
            InitializeComponent();
            LoadListView();
        }

        private void LoadListView()
        {
            lv_Info.View = View.Details;
            lv_Info.Items.Clear();
            lv_Info.Columns.Clear();
            lv_Info.Columns.Add("Email", 300);
            lv_Info.Columns.Add("From", 300);
            lv_Info.Columns.Add("Thời gian", 200);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Email.Text) || string.IsNullOrEmpty(tb_Password.Text)) 
            {
                MessageBox.Show("Không bỏ trống thông tin nào", "Lỗi");
                return;
            }

            lbl_Recent.Text = "";
            lbl_Total.Text = "";
            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(tb_Email.Text, tb_Password.Text);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    AddInfo(message);
                }
                lbl_Recent.Text = inbox.Recent.ToString();
                lbl_Total.Text = inbox.Count.ToString();
            }
        }

        private void AddInfo(MimeMessage message)
        {
            ListViewItem Item = new ListViewItem(message.Subject.ToString());
            Item.SubItems.Add(message.From.ToString());
            Item.SubItems.Add(message.Date.ToString());
            lv_Info.Items.Add(Item);
        }
    }
}
//app password:pews jhiz anla tsjy