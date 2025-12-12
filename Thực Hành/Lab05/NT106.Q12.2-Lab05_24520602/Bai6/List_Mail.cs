using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace Bai6
{
    public partial class frm_Bai6 : Form
    {
        public frm_Bai6()
        {
            InitializeComponent();
            listMail = new List<MimeMessage>();
        }

        List<MimeMessage> listMail;

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            tb_Email.Clear();
            tb_Password.Clear();
            tb_Email.Enabled = true;
            tb_Password.Enabled = true;
            gb_CaiDat.Enabled = true;
            btn_Login.Visible = true;
            btn_Log_Out.Visible = false;
            btn_Refresh.Visible = false;
            btn_Send_Mail.Visible = false;
            lv_Mail.Items.Clear();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lv_Mail.Items.Clear();
            listMail.Clear();
            using (var client = new ImapClient())
            {
                client.Connect(tb_IMAP.Text, (int)nUD_Port1.Value);
                client.Authenticate(tb_Email.Text, tb_Password.Text);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                int count = 0;
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    listMail.Add(message);
                    AddInfo(message, count);
                    count++;
                }
            }
        }

        private void AddInfo(MimeMessage message, int count)
        {
            ListViewItem Item = new ListViewItem(count.ToString());
            Item.SubItems.Add(message.From.ToString());
            Item.SubItems.Add(message.Subject.ToString());
            Item.SubItems.Add(message.Date.ToString());
            lv_Mail.Items.Add(Item);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            lv_Mail.Items.Clear();
            listMail.Clear();
            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect(tb_IMAP.Text, (int)nUD_Port1.Value);
                    client.Authenticate(tb_Email.Text, tb_Password.Text);
                    MessageBox.Show("Đăng nhập thành công");

                    gb_CaiDat.Enabled = false;
                    tb_Email.Enabled = false;
                    tb_Password.Enabled = false;
                    btn_Login.Visible = false;
                    btn_Log_Out.Visible = true;
                    btn_Refresh.Visible = true;
                    btn_Send_Mail.Visible = true;

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    int count = 0;
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        listMail.Add(message);
                        AddInfo(message, count);
                        count++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đăng nhập: {ex.Message}", "Lỗi");
                }
            }
        }


        private void btn_Send_Mail_Click(object sender, EventArgs e)
        {
            frm_SendEmail form = new frm_SendEmail(tb_Email.Text, tb_Password.Text, tb_SMTP.Text, (int)nUD_Port2.Value);
            form.Show();
        }

        private void lv_Mail_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lv_Mail.SelectedIndices.Count > 0)
            {
                int index = lv_Mail.SelectedIndices[0];
                if (index >= 0 && index < listMail.Count)
                {
                    MimeMessage mail = listMail[index];
                    Read_Mail _rm = new Read_Mail(mail);
                    _rm.Show();
                }
            }
        }
    }
}
