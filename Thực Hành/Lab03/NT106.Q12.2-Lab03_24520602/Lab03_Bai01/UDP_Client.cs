using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab03_Bai01
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }

        private void tb_IP_server_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_port_server_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtb_messages_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_client_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_IP_server.Text))
            {
                MessageBox.Show("Vui lòng nhập IP!");
                return;
            }
            if (string.IsNullOrEmpty(tb_port_server.Text)) 
            {
                MessageBox.Show("Vui lòng nhập Port!");
                return;
            }
            if (string.IsNullOrEmpty(rtb_messages.Text))
            {
                MessageBox.Show("Không có nội dung gì để gửi");
                return;
            }
            try
            {
                UdpClient Client = new UdpClient();

                Byte[] Send_Bytes = Encoding.UTF8.GetBytes(rtb_messages.Text);

                Client.Send(Send_Bytes, Send_Bytes.Length, tb_IP_server.Text, int.Parse(tb_port_server.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
