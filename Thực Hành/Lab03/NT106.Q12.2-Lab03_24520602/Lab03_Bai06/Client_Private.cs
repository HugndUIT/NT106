using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai06
{
    public partial class Client_Private : Form
    {
        string My_Name;

        string Friend_Name;

        public Action<Chat_Packet> Send_Private_Message;

        public Client_Private(string My_Name, string Friend_Name)
        {
            InitializeComponent();

            this.My_Name = My_Name;
            this.Friend_Name = Friend_Name;
            this.Text = Friend_Name;

            lv_Message.View = View.Details;
            lv_Message.Columns.Add("Message", -2);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string Message_Text = tb_Message.Text;
            if (string.IsNullOrEmpty(Message_Text))
            {
                MessageBox.Show("Vui lòng nhập tin nhắn", "Lỗi");
                return;
            }

            Chat_Packet Packet = new Chat_Packet
            {
                Type = PacketType.Private_Chat,
                TargetName = Friend_Name,
                Message = Message_Text
            };

            Send_Private_Message.Invoke(Packet);

            Add_Message("Me: " + Message_Text);
            tb_Message.Clear();
        }

        public void Receive_Message(string Message, string Sender_Name)
        {
            Add_Message($"{Sender_Name}: {Message}");
        }

        private void Add_Message(string Text)
        {
            if (lv_Message.InvokeRequired)
            {
                lv_Message.Invoke(new Action(() => Add_Message(Text)));
            }
            else
            {
                lv_Message.Items.Add(new ListViewItem(Text));
                lv_Message.EnsureVisible(lv_Message.Items.Count - 1);
            }
        }
    }
}