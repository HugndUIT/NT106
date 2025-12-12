using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai03
{
    public partial class TCP_Client : Form
    {
        public TCP_Client()
        {
            InitializeComponent();
        }

        TcpClient Client = null;

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                Client = new TcpClient("127.0.0.1", 8080);
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến server: " + ex.Message);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (Client == null || !Client.Connected)
            {
                MessageBox.Show("Chưa kết nối đến server!");
                return;
            }

            NetworkStream ns = Client.GetStream();
            Byte[] Data = Encoding.UTF8.GetBytes(rtb_messages.Text);
            ns.Write(Data, 0, Data.Length);
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (Client != null && Client.Connected)
            {
                NetworkStream ns = Client.GetStream();
                byte[] Data = Encoding.UTF8.GetBytes("Client closed\n");
                ns.Write(Data, 0, Data.Length);
                ns.Close();
                Client.Close();
                MessageBox.Show("Đã ngắt kết nối.");
                this.Close();
            }
        }

        private void rtb_messages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
