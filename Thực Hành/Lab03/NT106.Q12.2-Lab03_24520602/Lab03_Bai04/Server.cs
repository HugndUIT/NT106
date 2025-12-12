using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab03_Bai04
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            this.FormClosing += Server_FormClosing;
        }

        TcpListener TCP_Server;

        Thread Server_Thread;

        bool Is_Running = false;

        List<TcpClient> Clients = new List<TcpClient>();

        private void Server_Load(object sender, EventArgs e)
        {
            foreach (var Phong in new[] { "1", "2", "3" })
            {
                Ghe_Da_Dat.Add($"{Phong} - B1");
                Ghe_Da_Dat.Add($"{Phong} - B5");
            }
        }

        Dictionary<string, Dictionary<int, List<string>>> Thong_Tin_Ve = new Dictionary<string, Dictionary<int, List<string>>>();

        Dictionary<string, int> Gia_Ve_Chuan = new Dictionary<string, int>();

        Dictionary<string, List<string>> Phong_Chieu = new Dictionary<string, List<string>>();

        HashSet<string> Ghe_Da_Dat = new HashSet<string>();

        Dictionary<string, double> He_So_Gia_Ve = new Dictionary<string, double>()
        {
            {"A1", 0.25}, {"A5", 0.25}, {"C1", 0.25}, {"C5", 0.25},
            {"A2", 1}, {"A3", 1}, {"A4", 1},
            {"C2", 1}, {"C3", 1}, {"C4", 1},
            {"B2", 2}, {"B3", 2}, {"B4", 2}
        };

        void Start_Server()
        {
            TCP_Server = new TcpListener(IPAddress.Any, 1111);
            TCP_Server.Start();

            Thong_Tin_Ve = JsonSerializer.Deserialize<Dictionary<string, Dictionary<int, List<string>>>>(File.ReadAllText("Input.json"));

            try
            {
                foreach (var Thong_Tin in Thong_Tin_Ve)
                {
                    string Ten_Phim = Thong_Tin.Key;
                    int Gia_Ve = Thong_Tin.Value.Keys.First();
                    List<string> Phong = Thong_Tin.Value.Values.First();
                    Gia_Ve_Chuan[Ten_Phim] = Gia_Ve;
                    Phong_Chieu[Ten_Phim] = Phong;
                }

                while (Is_Running)
                {
                    TcpClient TCP_Client = null;

                    try
                    {
                        TCP_Client = TCP_Server.AcceptTcpClient(); 
                    }
                    catch (SocketException)
                    {
                        break;
                    }

                    lock (Clients)
                    {
                        Clients.Add(TCP_Client);
                    }

                    Show_Text("Client connected!");

                    NetworkStream Stream = TCP_Client.GetStream();

                    var Data = new
                    {
                        Ticket_Price = Gia_Ve_Chuan,
                        Screening_Room = Phong_Chieu,
                        Reserved_Seats = Ghe_Da_Dat.ToList(),
                        Coefficient = He_So_Gia_Ve
                    };

                    string Json = JsonSerializer.Serialize(Data);
                    byte[] Sent = Encoding.UTF8.GetBytes(Json);
                    Stream.Write(Sent, 0, Sent.Length);

                    Thread Client_Thread = new Thread(Handle_Client);
                    Client_Thread.Start(TCP_Client);
                }
            }
            catch (SocketException)
            {
                Show_Text("Socket lỗi khi nhận client!");
            }
            catch (Exception ex)
            {
                Show_Text("Lỗi: " + ex.Message);
            }
        }

        void Handle_Client(object obj)
        {
            TcpClient Client = (TcpClient)obj;
            NetworkStream Stream = Client.GetStream();
            Stream.ReadTimeout = 1000;

            byte[] Received = new byte[4096];
            int Bytes_Received;
            try
            {
                while (Is_Running)
                {
                    try
                    {
                        try
                        {
                            Bytes_Received = Stream.Read(Received, 0, Received.Length);
                            if (Bytes_Received == 0)
                                break; 
                        }
                        catch (IOException)
                        {
                            if (!Is_Running) break;
                            continue;
                        }

                        string Message = Encoding.UTF8.GetString(Received, 0, Bytes_Received);

                        var Data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(Message);

                        if (Data.ContainsKey("Type") && Data["Type"].GetString() == "Đặt vé")
                        {
                            var Ghe_Moi = JsonSerializer.Deserialize<List<string>>(Data["New_Chair"].GetRawText());

                            lock (Ghe_Da_Dat)
                            {
                                foreach (var Ghe in Ghe_Moi)
                                {
                                    Ghe_Da_Dat.Add(Ghe);
                                }
                            }

                            Show_Text($"Đã cập nhật {Ghe_Moi.Count} ghế mới từ client.");

                            Broadcast_Update();
                        }
                    }
                    catch (Exception ex)
                    {
                        Show_Text("Lỗi khi xử lý JSON: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Show_Text("Lỗi client: " + ex.Message);
            }
            finally
            {
                Client.Close();
            }
        }

        void Broadcast_Update()
        {
            var Update_Data = new
            {
                Type = "Cập nhật ghế",
                Reserved_Seats = Ghe_Da_Dat.ToList()
            };

            string json = JsonSerializer.Serialize(Update_Data);
            byte[] Sent = Encoding.UTF8.GetBytes(json);

            lock (Clients)
            {
                foreach (var client in Clients.ToList())
                {
                    try
                    {
                        if (client.Connected)
                        {
                            NetworkStream stream = client.GetStream();
                            stream.Write(Sent, 0, Sent.Length);
                        }
                    }
                    catch
                    {
                        Clients.Remove(client);
                    }
                }
            }
        }

        void Show_Text(string Text)
        {
            if (rtb_messages.InvokeRequired)
            {
                rtb_messages.Invoke(new Action(() => rtb_messages.Text += Text + Environment.NewLine));
            }
            else
            {
                rtb_messages.Text += Text + Environment.NewLine;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!Is_Running)
            {
                Is_Running = true;
                Server_Thread = new Thread(Start_Server);
                Server_Thread.Start();
                Show_Text("Server started...");
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (Is_Running)
            {
                Is_Running = false;

                try
                {
                    TCP_Server.Stop(); 
                }
                catch { }

                lock (Clients)
                {
                    foreach (var client in Clients)
                    {
                        try
                        {
                            client.Close();
                        }
                        catch { }
                    }
                    Clients.Clear();
                }

                if (Server_Thread != null && Server_Thread.IsAlive)
                {
                    Server_Thread.Join(500); 
                }

                Show_Text("Server stopped!");
            }
            else
            {
                MessageBox.Show("Server chưa chạy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Is_Running)
            {
                btn_end_Click(sender, e); 
            }
        }
    }
}
