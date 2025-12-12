using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace Lab03_Bai06
{
    public partial class Client_Global : Form
    {
        public Client_Global()
        {
            InitializeComponent();
            lv_Message.View = View.Details;
            lv_Message.Columns.Add("Message", -2);
        }

        TcpClient Tcp_Client;

        NetworkStream Stream;

        Thread Listen_Thread;

        string Client_Name;

        bool Running = false;

        Dictionary<string, Client_Private> Private_Chat = new Dictionary<string, Client_Private>();

        byte[] Serialize(object obj)
        {
            string Json_String = JsonSerializer.Serialize(obj);

            return Encoding.UTF8.GetBytes(Json_String);
        }

        T Deserialize<T>(byte[] Data)
        {
            if (Data == null || Data.Length == 0)
                return default;

            string Json_String = Encoding.UTF8.GetString(Data);

            return JsonSerializer.Deserialize<T>(Json_String);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên", "Lỗi");
                return;
            }

            Client_Name = tb_Name.Text;

            Connection();
        }

        public void Connection()
        {
            try
            {
                Tcp_Client = new TcpClient();
                Tcp_Client.Connect("127.0.0.1", 8080);
                Stream = Tcp_Client.GetStream();

                Chat_Packet Connect_Packet = new Chat_Packet
                {
                    Type = PacketType.Connect,
                    Name = Client_Name
                };

                Send_Packet(Connect_Packet);

                Running = true;

                Listen_Thread = new Thread(Receive);
                Listen_Thread.IsBackground = true;
                Listen_Thread.Start();

                Add_Message("Đã kết nối tới server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới server!\n" + ex.Message, "Lỗi");
            }
        }

        public void Receive()
        {
            try
            {
                while (Running)
                {
                    byte[] Buffer = new byte[1024 * 5000];
                    int Bytes_Read = Stream.Read(Buffer, 0, Buffer.Length);

                    if (Bytes_Read == 0)
                    {
                        Running = false;
                        break;
                    }

                    byte[] Actual_Data = new byte[Bytes_Read];

                    Array.Copy(Buffer, Actual_Data, Bytes_Read);

                    Chat_Packet Packet = Deserialize<Chat_Packet>(Actual_Data);

                    if (Packet == null) continue;

                    switch (Packet.Type)
                    {
                        case PacketType.Chat:

                        case PacketType.Connect:

                        case PacketType.Disconnect:
                            Invoke(new Action(() => Add_Message(Packet.Message)));
                            break;

                        case PacketType.Update_Participants:
                            Invoke(new Action(() => Update_Participants(Packet.Participants)));
                            break;

                        case PacketType.Private_Chat:
                            Invoke(new Action(() => Handle_Private_Message(Packet)));
                            break;
                    }
                }
            }
            catch
            {
                if (Running)
                    Invoke(new Action(() => Add_Message("Mất kết nối máy chủ!")));
            }
            finally
            {
                Running = false;

                try { Stream.Close(); } catch { }

                try { Tcp_Client.Close(); } catch { }
            }
        }

        private void Send_Packet(Chat_Packet Packet)
        {
            if (Tcp_Client == null || !Tcp_Client.Connected)
                return;

            byte[] Data = Serialize(Packet);
            Stream.Write(Data, 0, Data.Length);
        }

        public void Close_Connection()
        {
            if (!Running) 
                return;
            Running = false;

            try
            {
                Chat_Packet Disconnect_Packet = new Chat_Packet { Type = PacketType.Disconnect };
                Send_Packet(Disconnect_Packet);
            }
            catch { }

            try { Stream.Close(); } catch { }

            try { Tcp_Client.Close(); } catch { }
        }

        public void Send_Message()
        {
            if (string.IsNullOrWhiteSpace(tb_Message.Text)) return;

            Chat_Packet Data = new Chat_Packet
            {
                Type = PacketType.Chat,
                Message = tb_Message.Text
            };

            Send_Packet(Data);
        }

        private void Handle_Private_Message(Chat_Packet Packet)
        {
            string Sender_Name = Packet.SenderName;

            if (Private_Chat.ContainsKey(Sender_Name))
            {
                Private_Chat[Sender_Name].Receive_Message(Packet.Message, Sender_Name);
                Private_Chat[Sender_Name].Focus();
            }
            else
            {
                Client_Private Private_Form = new Client_Private(Client_Name, Sender_Name);

                Private_Form.Send_Private_Message += (pkt) =>
                {
                    try { if (Running) Send_Packet(pkt); } catch { }
                };

                Private_Form.FormClosed += (s, args) =>
                {
                    Private_Chat.Remove(Sender_Name);
                };

                Private_Chat.Add(Sender_Name, Private_Form);
                Private_Form.Show();
                Private_Form.Receive_Message(Packet.Message, Sender_Name);
            }
        }

        private void Update_Participants(List<string> participants)
        {
            lb_Participants.Items.Clear();
            foreach (string name in participants)
            {
                lb_Participants.Items.Add(name);
            }
        }

        void Add_Message(string s)
        {
            lv_Message.Items.Add(new ListViewItem() { Text = s });
        }

        private void Client_Global_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close_Connection();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Message.Text)) {
                MessageBox.Show("Vui lòng nhập tin nhắn!");
            }
            string message = tb_Message.Text;
            Send_Message();
            Add_Message("Me: " + message);
            tb_Message.Clear();
        }

        private void lb_Participants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Participants.SelectedItem == null) return;

            string Target_Name = lb_Participants.SelectedItem.ToString();

            if (Target_Name == Client_Name) return;

            if (Private_Chat.ContainsKey(Target_Name))
            {
                Private_Chat[Target_Name].Focus();
            }
            else
            {
                Client_Private Private_Form = new Client_Private(Client_Name, Target_Name);

                Private_Form.Send_Private_Message += (packet) =>
                {
                    try { if (Running) Send_Packet(packet); } catch { }
                };

                Private_Form.FormClosed += (s, args) => Private_Chat.Remove(Target_Name);

                Private_Chat.Add(Target_Name, Private_Form);

                Private_Form.Show();
            }
        }
    }
}