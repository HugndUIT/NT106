using Lab03_Bai05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai04
{
    public partial class Client : Form
    {
        TcpClient TCP_Client;

        NetworkStream Stream;

        Thread Client_Thread;

        public Client()
        {
            InitializeComponent();
            lv_dsmonan.View = View.Details;
            lv_dsmonan.Columns.Add("Tên món ăn", 150);
            lv_dsmonan.Columns.Add("Người đăng", 120);
            lv_dsmonan.Columns.Add("Hình ảnh", 200);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            try
            {
                TCP_Client = new TcpClient("127.0.0.1", 8080);
                Stream = TCP_Client.GetStream();

                Client_Thread = new Thread(Handle_Server);
                Client_Thread.IsBackground = true;
                Client_Thread.Start();

                MessageBox.Show("Đã kết nối tới server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới server: " + ex.Message);
                this.Close();
            }
        }

        private void Handle_Server()
        {
            try
            {
                while (true)
                {
                    byte[] Length_Buffer = new byte[4];
                    int Read = Stream.Read(Length_Buffer, 0, 4);

                    if (Read == 0) break;

                    int Packet_Length = BitConverter.ToInt32(Length_Buffer, 0);
                    byte[] Data_Buffer = new byte[Packet_Length];

                    int Total_Read = 0;
                    while (Total_Read < Packet_Length)
                    {
                        int Bytes_Read = Stream.Read(Data_Buffer, Total_Read, Packet_Length - Total_Read);
                        if (Bytes_Read == 0) break;
                        Total_Read += Bytes_Read;
                    }

                    Respond_Packet Packet = JsonSerializer.Deserialize<Respond_Packet>(Data_Buffer);

                    if (Packet == null) continue;

                    switch (Packet.Type)
                    {
                        case Respond_Type.See_Food:
                            Display_Food(Packet);
                            break;

                        case Respond_Type.Add_Food:
                            Display_Food(Packet);
                            break;

                        case Respond_Type.Choose_Food:
                            Display_Image(Packet);
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mất kết nối với server!");
            }
        }

        private void Display_Food(Respond_Packet Packet)
        {
            if (lv_dsmonan.InvokeRequired)
            {
                lv_dsmonan.Invoke(new Action(() => Display_Food(Packet)));
                return;
            }

            ListViewItem item = new ListViewItem(Packet.Food_Name);
            item.SubItems.Add(Packet.Name_NCC);
            item.SubItems.Add(Packet.Image);
            lv_dsmonan.Items.Add(item);
        }

        private void Display_Image(Respond_Packet Packet)
        {
            if (ptb_ketquamonan.InvokeRequired)
            {
                ptb_ketquamonan.Invoke(new Action(() => Display_Image(Packet)));
                return;
            }

            MessageBox.Show(Packet.Food_Name, Packet.Name_NCC);

            try
            {
                ptb_ketquamonan.Load(Packet.Image);
                ptb_ketquamonan.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                ptb_ketquamonan.Image = null;
            }
        }

        private void Send_Data(Require_Packet Packet)
        {
            try
            {
                byte[] Data = JsonSerializer.SerializeToUtf8Bytes(Packet);
                byte[] Length_Bytes = BitConverter.GetBytes(Data.Length);

                Stream.Write(Length_Bytes, 0, Length_Bytes.Length);
                Stream.Write(Data, 0, Data.Length);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Lỗi gửi dữ liệu: " + Ex.Message);
            }
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nhaptennguoi.Text) ||
                string.IsNullOrWhiteSpace(tb_quyenhan.Text) ||
                string.IsNullOrWhiteSpace(tb_nhapmonan.Text) ||
                string.IsNullOrWhiteSpace(tb_linkhinhanh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            Require_Packet Packet = new Require_Packet()
            {
                Type = Require_Type.Add_Food,
                Ho_Ten = tb_nhaptennguoi.Text,
                Quyen_Han = tb_quyenhan.Text,
                Ten_Mon_An = tb_nhapmonan.Text,
                Hinh_Anh = tb_linkhinhanh.Text
            };

            tb_nhapmonan.Clear();
            tb_linkhinhanh.Clear();
            tb_quyenhan.Clear();

            Send_Data(Packet);
        }

        private void btn_xemmon_Click(object sender, EventArgs e)
        {
            lv_dsmonan.Items.Clear();

            Require_Packet Packet = new Require_Packet()
            {
                Type = Require_Type.See_Food
            };

            Send_Data(Packet);
        }

        private void btn_chonmonchung_Click(object sender, EventArgs e)
        {
            Require_Packet Packet = new Require_Packet()
            {
                Type = Require_Type.Chosse_Food_Global
            };

            Send_Data(Packet);
        }

        private void btn_chonmonrieng_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nhaptennguoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng trước khi chọn món riêng!");
                return;
            }

            Require_Packet Packet = new Require_Packet()
            {
                Type = Require_Type.Choose_Food_Personal,
                Ho_Ten = tb_nhaptennguoi.Text
            };

            Send_Data(Packet);
        }

        private void tb_nhapmonan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nhaptennguoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_quyenhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_linkhinhanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptb_ketquamonan_Click(object sender, EventArgs e)
        {

        }

        private void lv_dsmonan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Stream?.Close();
                TCP_Client?.Close();
            }
            catch { }
        }
    }
}
