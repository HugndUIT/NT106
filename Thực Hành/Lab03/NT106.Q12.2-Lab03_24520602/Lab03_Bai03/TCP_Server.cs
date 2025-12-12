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

namespace Lab03_Bai03
{
    public partial class TCP_Server : Form
    {
        public TCP_Server()
        {
            InitializeComponent();
        }

        void Start_Thread()
        {
            rtb_messages.Text += "Server Started\n";

            Socket Client_Socket;

            Socket Listener_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);

            Listener_Socket.Bind(ipepServer);

            Listener_Socket.Listen(-1);

            Client_Socket = Listener_Socket.Accept();

            string Buffer_Text = "";
            byte[] Buffer = new byte[1024];
            int Bytes_Read;

            while (Client_Socket.Connected)
            {
                Bytes_Read = Client_Socket.Receive(Buffer);
                if (Bytes_Read == 0) break;

                Buffer_Text = Encoding.UTF8.GetString(Buffer, 0, Bytes_Read);
                rtb_messages.Text += "From client: " + Buffer_Text + "\n";
            }

            Listener_Socket.Close();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            Thread Server_Thread = new Thread(new ThreadStart(Start_Thread));
            Server_Thread.IsBackground = true;
            Server_Thread.Start();
        }

        private void rtb_messages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
