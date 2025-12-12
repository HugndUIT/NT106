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
using Lab03_Bai05;
using System.Text.Json;
using System.Data.SQLite;

namespace Lab03_Bai04
{
    public partial class Server : Form
    {
        TcpListener TCP_Server;

        Dictionary<TcpClient, string> Client_List = new Dictionary<TcpClient, string>();

        string ConnectionSQL = @"Data Source=C:\Users\ASUS\Downloads\NT106.Q12.2-Lab03_24520602\Lab03_Bai05\HomNayAnGi.db;Version=3;";

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

        public Server()
        {
            InitializeComponent();

            lv_Message.View = View.Details;
            lv_Message.Columns.Add("Message", -2);
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            Thread Server_Thread = new Thread(Start_Server);
            Server_Thread.IsBackground = true;
            Server_Thread.Start();
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

        private void Start_Server()
        {
            try
            {
                TCP_Server = new TcpListener(IPAddress.Any, 8080);
                TCP_Server.Start();
                Notification("Server is listening on port 8080...");

                while (true)
                {
                    TcpClient TCP_Client = TCP_Server.AcceptTcpClient();
                    if (!Client_List.ContainsKey(TCP_Client))
                        Client_List.Add(TCP_Client, "");
                    Thread Client_Thread = new Thread(() => Handle_Client(TCP_Client));
                    Client_Thread.IsBackground = true;
                    Client_Thread.Start();
                }
            }
            catch (Exception Ex)
            {
                Notification($"Server Error: {Ex.Message}");
            }
        }

        private void Handle_Client(TcpClient TCP_Client)
        {
            NetworkStream Network_Stream = TCP_Client.GetStream();

            try
            {
                while (true)
                {
                    byte[] Length_Buffer = new byte[4];
                    int Bytes_Read = Network_Stream.Read(Length_Buffer, 0, 4);
                    if (Bytes_Read == 0) break;

                    int Packet_Length = BitConverter.ToInt32(Length_Buffer, 0);
                    byte[] Bytes_Buffer = new byte[Packet_Length];

                    int Total_Read = 0;
                    while (Total_Read < Packet_Length)
                    {
                        int Chunk_Read = Network_Stream.Read(Bytes_Buffer, Total_Read, Packet_Length - Total_Read);
                        if (Chunk_Read == 0) break;
                        Total_Read += Chunk_Read;
                    }

                    Require_Packet Require_Packet = Deserialize<Require_Packet>(Bytes_Buffer);

                    if (!string.IsNullOrEmpty(Require_Packet.Ho_Ten))
                    {
                        Client_List[TCP_Client] = Require_Packet.Ho_Ten;
                    }

                    switch (Require_Packet.Type)
                    {
                        case Require_Type.Add_Food:
                            Add_Food(Require_Packet);
                            break;

                        case Require_Type.See_Food:
                            See_Food(TCP_Client);
                            break;

                        case Require_Type.Chosse_Food_Global:
                            Chosse_Food_Global(TCP_Client);
                            break;

                        case Require_Type.Choose_Food_Personal:
                            Choose_Food_Personal(TCP_Client);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                Notification(Ex.Message);
            }
            finally
            {
                Notification("Client disconnected!");
                Client_List.Remove(TCP_Client);
                TCP_Client.Close();
            }
        }

        private void Add_Food(Require_Packet Packet)
        {
            using (SQLiteConnection Connect = new SQLiteConnection(ConnectionSQL))
            {
                Connect.Open();

                string Insert_Users = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@name, @authority)";

                using (SQLiteCommand Command = new SQLiteCommand(Insert_Users, Connect))
                {
                    Command.Parameters.AddWithValue("@name", Packet.Ho_Ten);
                    Command.Parameters.AddWithValue("@authority", Packet.Quyen_Han);
                    Command.ExecuteNonQuery();
                }

                long Monan_IDNCC = Connect.LastInsertRowId; 

                string Insert_Food = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@foodname, @linkimage, @idncc)";

                using (SQLiteCommand Command = new SQLiteCommand(Insert_Food, Connect))
                {
                    Command.Parameters.AddWithValue("@foodname", Packet.Ten_Mon_An);
                    Command.Parameters.AddWithValue("@linkimage", Packet.Hinh_Anh);
                    Command.Parameters.AddWithValue("@idncc", Monan_IDNCC);
                    Command.ExecuteNonQuery();
                }

                Notification("Đã thêm món ăn thành công!");

                Respond_Packet respond = new Respond_Packet()
                {
                    Type = Respond_Type.Add_Food,
                    Food_Name = Packet.Ten_Mon_An,
                    Image = Packet.Hinh_Anh,
                    Name_NCC = Packet.Ho_Ten
                };

                Send_Broadcast_Data(respond);
            }
        }

        private void See_Food(TcpClient Client)
        {
            using (SQLiteConnection Connect = new SQLiteConnection(ConnectionSQL))
            {
                Connect.Open();
                
                string Select_Data = "SELECT TenMonAn, HoVaTen, HinhAnh FROM MonAn JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";

                using (SQLiteCommand Command = new SQLiteCommand(Select_Data, Connect))
                {
                    using (SQLiteDataReader Read_Data = Command.ExecuteReader())
                    {
                        while (Read_Data.Read())
                        {
                            Respond_Packet Packet = new Respond_Packet();
                            Packet.Type = (Respond_Type)1;
                            Packet.Food_Name = Read_Data["TenMonAn"].ToString();
                            Packet.Image = Read_Data["HinhAnh"].ToString();
                            Packet.Name_NCC = Read_Data["HoVaTen"].ToString();

                            Send_Data(Client, Packet);
                        }
                    }
                }
            }
        }

        private void Chosse_Food_Global(TcpClient Client)
        {
            using (SQLiteConnection Connect = new SQLiteConnection(ConnectionSQL))
            {

                Connect.Open();

                string Count_Foods = "SELECT COUNT(*) FROM MonAn";

                using (SQLiteCommand Command = new SQLiteCommand(Count_Foods, Connect))
                {
                    object Count = Command.ExecuteScalar();
                    
                    if (Convert.ToInt32(Count) == 0)
                    {
                        MessageBox.Show("Danh sách món ăn trống!");
                        return;
                    }
                }

                string Select_Data = "SELECT TenMonAn, HinhAnh, HoVaTen FROM MonAn M JOIN NguoiDung D ON M.IDNCC = D.IDNCC";

                using (SQLiteCommand Command = new SQLiteCommand(Select_Data, Connect))
                {
                    List<Respond_Packet> Packets = new List<Respond_Packet>();

                    using (SQLiteDataReader Read_Data = Command.ExecuteReader())
                    {
                        while (Read_Data.Read())
                        {
                            Respond_Packet Packet = new Respond_Packet()
                            {
                                Food_Name = Read_Data["TenMonAn"].ToString(),

                                Image = Read_Data["HinhAnh"].ToString(),

                                Name_NCC = Read_Data["HoVaTen"].ToString()
                            };
                            Packets.Add(Packet);
                        }

                        Random random = new Random();
                        int Index = random.Next(Packets.Count);
                        Respond_Packet MonAnHomNay = Packets[Index];
                        MonAnHomNay.Type = (Respond_Type)2;

                        Send_Data(Client, MonAnHomNay);
                    }
                }
            }
        }

        private void Choose_Food_Personal(TcpClient Client)
        {
            if (!Client_List.ContainsKey(Client))
            {
                Respond_Packet NotFound = new Respond_Packet()
                {
                    Type = Respond_Type.Choose_Food,
                    Food_Name = "Bạn chưa đăng ký tên hoặc chưa thêm món nào!",
                    Image = "",
                    Name_NCC = "Unknown"
                };
                Send_Data(Client, NotFound);
                return;
            }

            string User_Name = Client_List[Client];

            using (SQLiteConnection Connect = new SQLiteConnection(ConnectionSQL))
            {
                Connect.Open();

                string Select_Data = @"SELECT TenMonAn, HinhAnh, HoVaTen FROM MonAn M JOIN NguoiDung D ON M.IDNCC = D.IDNCC WHERE D.HoVaTen = @name";

                using (SQLiteCommand Command = new SQLiteCommand(Select_Data, Connect))
                {
                    Command.Parameters.AddWithValue("@name", User_Name);

                    List<Respond_Packet> Packets = new List<Respond_Packet>();

                    using (SQLiteDataReader Read_Data = Command.ExecuteReader())
                    {
                        while (Read_Data.Read())
                        {
                            Respond_Packet Respond = new Respond_Packet()
                            {
                                Food_Name = Read_Data["TenMonAn"].ToString(),
                                Image = Read_Data["HinhAnh"].ToString(),
                                Name_NCC = Read_Data["HoVaTen"].ToString()
                            };
                            Packets.Add(Respond);
                        }
                    }

                    if (Packets.Count == 0)
                    {
                        Respond_Packet NotFound = new Respond_Packet()
                        {
                            Type = Respond_Type.Choose_Food,
                            Food_Name = "Không có món nào do bạn thêm!",
                            Image = "",
                            Name_NCC = User_Name
                        };
                        Send_Data(Client, NotFound);
                        return;
                    }

                    Random random = new Random();
                    Respond_Packet RandomFood = Packets[random.Next(Packets.Count)];
                    RandomFood.Type = Respond_Type.Choose_Food;

                    Send_Data(Client, RandomFood);
                }
            }
        }

        private void Send_Data(TcpClient TCP_Client, Respond_Packet Packet)
        {
            try
            {
                byte[] Bytes_Data = Serialize(Packet);
                byte[] Bytes_Length = BitConverter.GetBytes(Bytes_Data.Length);
                NetworkStream Network_Stream = TCP_Client.GetStream();

                Network_Stream.Write(Bytes_Length, 0, Bytes_Length.Length);
                Network_Stream.Write(Bytes_Data, 0, Bytes_Data.Length);
            }
            catch { }
        }

        private void Send_Broadcast_Data(Respond_Packet Packet)
        {
            byte[] Data = Serialize(Packet);
            byte[] Length_Bytes = BitConverter.GetBytes(Data.Length);

            List<TcpClient> DisconnectedClients = new List<TcpClient>();

            foreach (var pair in Client_List)
            {
                TcpClient Client = pair.Key;
                try
                {
                    NetworkStream Stream = Client.GetStream();
                    Stream.Write(Length_Bytes, 0, Length_Bytes.Length);
                    Stream.Write(Data, 0, Data.Length);
                }
                catch
                {
                    DisconnectedClients.Add(Client);
                }
            }

            foreach (var Client in DisconnectedClients)
            {
                Client_List.Remove(Client);
            }
        }
    }
}
