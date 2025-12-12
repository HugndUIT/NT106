using System;
using System.Windows.Forms;
using MailKit.Net.Pop3;

namespace Bai3
{
    public partial class Mail_Reader_Pop : Form
    {
        public Mail_Reader_Pop()
        {
            InitializeComponent();
            lv_danhsachmail.View = View.Details;    
            lv_danhsachmail.Items.Clear();  
            lv_danhsachmail.Columns.Clear();
            lv_danhsachmail.Columns.Add("Email", 200);
            lv_danhsachmail.Columns.Add("From", 200);
            lv_danhsachmail.Columns.Add("Time", 200);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_email.Text) || string.IsNullOrEmpty(tb_password.Text)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (var Client = new Pop3Client())
                {
                    Client.Connect("pop.gmail.com", 995, true);
                    Client.Authenticate(tb_email.Text.Trim(), tb_password.Text.Trim());

                    var Count_Mail = Client.Count;

                    lbl_total.Text = "Total: ";
                    lbl_total.Text += Count_Mail.ToString();

                    for (int i = 0; i < Count_Mail; i++)
                    {
                        var Message = Client.GetMessage(i);
                        ListViewItem Item = new ListViewItem(Message.Subject.ToString());
                        Item.SubItems.Add(Message.From.ToString());
                        Item.SubItems.Add(Message.Date.ToString());
                        lv_danhsachmail.Items.Add(Item);
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

// App password: rigu cwqp sjrd bkmk 