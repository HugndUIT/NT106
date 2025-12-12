using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bai7.Model;

namespace Bai7
{
    public partial class ThemMonAn : Form
    {
        string NguoiDongGop;
        string TokenAccess;
        public ThemMonAn(string nguoidonggop, string token)
        {
            InitializeComponent();
            NguoiDongGop = nguoidonggop;
            TokenAccess = token;
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenMonAn.Text) || string.IsNullOrEmpty(tb_Gia.Text) || string.IsNullOrEmpty(tb_DiaChi.Text) || string.IsNullOrEmpty(tb_HinhAnh.Text) || string.IsNullOrEmpty(rtb_MoTa.Text))
            {
                MessageBox.Show("Không bỏ trống thông tin!", "Lỗi");
                return;
            }

            var url = "https://nt106.uitiot.vn/api/v1/monan/add";

            var monan = new FoodItem
            {
                TenMonAn = tb_TenMonAn.Text,
                Gia = tb_Gia.Text,
                DiaChi = tb_DiaChi.Text,
                HinhAnh = tb_HinhAnh.Text,
                MoTa = rtb_MoTa.Text,
            };

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", TokenAccess);
                try
                {
                    string JsonString = JsonConvert.SerializeObject(monan);
                    var content = new StringContent(JsonString, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm món ăn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm món ăn không thành công", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi::{ex.Message}", "Lỗi");
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_TenMonAn.Clear();
            tb_Gia.Clear();
            tb_DiaChi.Clear();
            tb_HinhAnh.Clear();
            rtb_MoTa.Clear();
        }
    }

}
