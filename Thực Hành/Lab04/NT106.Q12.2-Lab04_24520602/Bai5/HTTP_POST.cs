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
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Bai5
{
    public partial class HTTP_POST : Form
    {
        public HTTP_POST()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            var url = tb_URL.Text;
            var username = tb_Username.Text;
            var password = tb_Password.Text;

            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };

                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                var responseObject = JObject.Parse(responseString);

                if (!response.IsSuccessStatusCode)
                {
                    rtb_Message.Clear();
                    var detail = responseObject["detail"].ToString();
                    rtb_Message.Text += $"Detail: {detail}\r\n";
                    return;
                }

                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();

                rtb_Message.Clear();
                rtb_Message.Text += $"{tokenType}\r\n";
                rtb_Message.Text += $"{accessToken}\r\n \r\n \r\n";
                rtb_Message.Text += "Đăng nhập thành công \r\n";
            }
        }
    }
}
