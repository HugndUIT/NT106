using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab03_Bai02
{
    public partial class Telnet : Form
    {
        public Telnet()
        {
            InitializeComponent();

            lv_message.View = View.Details; 
            lv_message.FullRowSelect = true; 
            lv_message.GridLines = true; 
            lv_message.Columns.Add("Messages", lv_message.Width - 10);
        }

        void StartUnsafeThread()
        {
            try
            {
                int Bytes_Received = 0;

                byte[] Received = new byte[1];

                Socket Client_Socket;

                Socket Listener_Socket = new Socket(
                        AddressFamily.InterNetwork,
                        SocketType.Stream,
                        ProtocolType.Tcp
                        );

                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);

                Listener_Socket.Bind(ipepServer);

                Listener_Socket.Listen(-1);

                Client_Socket = Listener_Socket.Accept();

                lv_message.Items.Add(new ListViewItem("New client connected"));

                while (Client_Socket.Connected)
                {
                    string text = "";
                    do
                    {
                        Bytes_Received = Client_Socket.Receive(Received);
                        text += Encoding.ASCII.GetString(Received);
                    } while (text[text.Length - 1] != '\n');
                    lv_message.Items.Add(new ListViewItem(text));
                }

                Listener_Socket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            Thread Server_Thread = new Thread(new ThreadStart(StartUnsafeThread));
            Server_Thread.IsBackground = true;
            Server_Thread.Start();
        }

        private void lv_message_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
