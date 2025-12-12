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
using System.Threading;

namespace Lab03_Bai01
{
    public partial class UDP_Server : Form
    {
        public UDP_Server()
        {
            InitializeComponent();
        }

        static UdpClient Server = null;

        Thread Thread_Server;     
        
        bool Is_Running = false;          

        private void tb_port_server_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtb_received_messages_TextChanged(object sender, EventArgs e)
        {

        }

        private void Server_Thread()
        {
            if (!int.TryParse(tb_port_server.Text, out int Port))
            {
                MessageBox.Show("Port không hợp lệ!");
                return;
            }

            Server = new UdpClient(Port);

            IPEndPoint IP_Client = new IPEndPoint(IPAddress.Any, Port);

            try
            {
                while (Is_Running)
                {
                    Byte[] Received_Bytes = Server.Receive(ref IP_Client);
                    string Return_Data = Encoding.UTF8.GetString(Received_Bytes);
                    string Messages = IP_Client.Address.ToString() + ": " + Return_Data.ToString();
                    Append_Text(Messages);
                }
            }
            catch (SocketException)
            {
                
            }
        }

        private void Append_Text(string text)
        {
            if (rtb_received_messages.InvokeRequired)
            {
                rtb_received_messages.Invoke(new Action<string>(Append_Text), text);
            }
            else
            {
                rtb_received_messages.Text += text + Environment.NewLine;
            }
        }

        private void btn_listen_server_Click(object sender, EventArgs e)
        {
            if (Is_Running)
            {
                MessageBox.Show("Server đang chạy rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Is_Running = true;

            Thread_Server = new Thread(new ThreadStart(Server_Thread));
            Thread_Server.IsBackground = true;
            Thread_Server.Start();
        }

        private void btn_end_server_Click(object sender, EventArgs e)
        {
            if (Is_Running)
            {
                Is_Running = false; 
                Server?.Close();   
                Server?.Dispose();
                Append_Text("Server đã dừng lắng nghe.");
            }
            else
            {
                MessageBox.Show("Server chưa chạy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}