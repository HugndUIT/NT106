using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace Lab03_Bai06
{
    public partial class Server : Form
    {
        TcpListener Server_Listener;

        Dictionary<string, TcpClient> Client_List = new Dictionary<string, TcpClient>();

        public Server()
        {
            InitializeComponent();

            lv_Message.View = View.Details;
            lv_Message.Columns.Add("Message", -2);
        }

        private void Notification(string Text)
        {
            if (lv_Message.InvokeRequired)
            {
                lv_Message.Invoke(new Action(() => Notification(Text)));
            }
            else
            {
                lv_Message.Items.Add(new ListViewItem(Text));
                lv_Message.EnsureVisible(lv_Message.Items.Count - 1);
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            Thread Server_Thread = new Thread(Start_Server);
            Server_Thread.IsBackground = true;
            Server_Thread.Start();
        }

        private void Start_Server()
        {
            try
            {
                Server_Listener = new TcpListener(IPAddress.Any, 8080);
                Server_Listener.Start();
                Notification("Server is listening on port 8080...");

                while (true)
                {
                    TcpClient Client = Server_Listener.AcceptTcpClient();
                    Thread Client_Thread = new Thread(() => Handle_Client(Client));
                    Client_Thread.IsBackground = true;
                    Client_Thread.Start();
                }
            }
            catch (Exception Ex)
            {
                Notification($"Server Error: {Ex.Message}");
            }
        }

        private void Handle_Client(TcpClient Client)
        {
            NetworkStream Stream = Client.GetStream();

            string Client_Name = null;

            try
            {
                while (true)
                {
                    byte[] Buffer = new byte[1024 * 5000];
                    int Bytes_Read = Stream.Read(Buffer, 0, Buffer.Length);

                    if (Bytes_Read == 0)
                        break;

                    byte[] Actual_Data = new byte[Bytes_Read];
                    Array.Copy(Buffer, Actual_Data, Bytes_Read);

                    Chat_Packet Packet = Deserialize<Chat_Packet>(Actual_Data);

                    switch (Packet.Type)
                    {
                        case PacketType.Connect:
                            Client_Name = Packet.Name;
                            Client_List.Add(Client_Name, Client);
                            Notification($"{Client_Name} connected.");
                            Broadcast(PacketType.Connect, $"{Client_Name} joined the group.", null);
                            Broadcast_Participants_List();
                            break;

                        case PacketType.Chat:
                            string Group_Message = $"{Client_Name}: {Packet.Message}";
                            Notification(Group_Message);
                            Broadcast(PacketType.Chat, Group_Message, Client_Name);
                            break;

                        case PacketType.Private_Chat:
                            Send_Private_Message(Client_Name, Packet.TargetName, Packet.Message);
                            break;

                        case PacketType.Disconnect:
                            break;
                    }
                }
            }
            catch 
            { 

            }
            finally
            {
                if (Client_Name != null)
                {
                    Client_List.Remove(Client_Name);
                    string Leave_Message = $"{Client_Name} left the group.";
                    Notification(Leave_Message);
                    Broadcast(PacketType.Disconnect, Leave_Message, null);
                    Broadcast_Participants_List();
                }
                Client.Close();
            }
        }

        private void Send_Private_Message(string Sender_Name, string Receiver_Name, string Message)
        {
            if (Client_List.ContainsKey(Receiver_Name))
            {
                Chat_Packet Packet_To_Receiver = new Chat_Packet
                {
                    Type = PacketType.Private_Chat,
                    SenderName = Sender_Name,
                    Message = Message
                };
                Send_Data(Client_List[Receiver_Name], Packet_To_Receiver);
            }
        }

        private void Send_Data(TcpClient Client, Chat_Packet Packet)
        {
            try
            {
                byte[] Data = Serialize(Packet);
                NetworkStream Stream = Client.GetStream();
                Stream.Write(Data, 0, Data.Length);
            }
            catch { }
        }

        private void Broadcast(PacketType Type, string Message, string Except_Name)
        {
            Chat_Packet Packet = new Chat_Packet
            {
                Type = Type,
                Message = Message
            };

            byte[] Data = Serialize(Packet);

            foreach (var Item in Client_List)
            {
                if (Item.Key != Except_Name)
                {
                    try
                    {
                        NetworkStream Stream = Item.Value.GetStream();
                        Stream.Write(Data, 0, Data.Length);
                    }
                    catch { }
                }
            }
        }

        private void Broadcast_Participants_List()
        {
            Chat_Packet Packet = new Chat_Packet
            {
                Type = PacketType.Update_Participants,
                Participants = new List<string>(Client_List.Keys)
            };

            byte[] Data = Serialize(Packet);

            foreach (var Item in Client_List.Values)
            {
                try
                {
                    NetworkStream Stream = Item.GetStream();
                    Stream.Write(Data, 0, Data.Length);
                }
                catch { }
            }
        }

        private byte[] Serialize(object Obj)
        {
            return JsonSerializer.SerializeToUtf8Bytes(Obj);
        }

        private T Deserialize<T>(byte[] Data)
        {
            if (Data == null || Data.Length == 0)
                return default;
            return JsonSerializer.Deserialize<T>(Data);
        }
    }
}