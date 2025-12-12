using Newtonsoft.Json.Linq;
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

namespace Bai7
{
    public partial class frm_HomNayAnGi_Login : Form
    {
        public frm_HomNayAnGi_Login()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            var url = "https://nt106.uitiot.vn/auth/token";

            if (string.IsNullOrEmpty(tb_Username.Text)) 
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!");
                return;
            }

            if (string.IsNullOrEmpty(tb_Password.Text)) 
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(tb_Username.Text), "username" },
                    { new StringContent(tb_Password.Text), "password" }
                };

                var post_string = await client.PostAsync(url, content);
                var response_string = await post_string.Content.ReadAsStringAsync();
                var response_json = JObject.Parse(response_string);

                if (!post_string.IsSuccessStatusCode)
                {
                    var detail = response_json["detail"].ToString();
                    MessageBox.Show($"Detail: {detail}");
                    return;
                } 
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    var token = response_json["access_token"].ToString();
                    frm_HomNayAnGi homNayAnGi = new frm_HomNayAnGi(token);
                    homNayAnGi.Show();
                }
            }
        }

        private void lbl_SignUp_Click(object sender, EventArgs e)
        {
            frm_HomNayAnGi_SignUp nayAnGi_SignUp = new frm_HomNayAnGi_SignUp();
            nayAnGi_SignUp.Show();
        }
    }
}
