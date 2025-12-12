using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Bai6
{
    public partial class HTTP_GET : Form
    {
        public HTTP_GET()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click_1(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/auth/token";
            string user_name = tb_Username.Text.Trim();
            string password = tb_Password.Text.Trim();

            using (HttpClient client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent (user_name), "username" },
                    { new StringContent (password), "password" }
                };

                var response = await client.PostAsync(url, content);

                var response_string = await response.Content.ReadAsStringAsync();

                rtb_Message.Text = "";

                var response_object = JObject.Parse(response_string);

                if (!response.IsSuccessStatusCode)
                {
                    var detail = response_object["detail"].ToString();
                    rtb_Message.Text = $"Lỗi đăng nhập: {detail}";
                    return;
                }

                var accessToken = response_object["access_token"].ToString();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var Get_User_Url = tb_URL.Text.Trim();
                var Get_User_Response = await client.GetAsync(Get_User_Url);
                var Get_User_Response_String = await Get_User_Response.Content.ReadAsStringAsync();
                var JSON_String = JObject.Parse(Get_User_Response_String);

                rtb_Message.Text += "Username: " + JSON_String["username"] + "\n";
                rtb_Message.Text += "Email: " + JSON_String["email"] + "\n";
                rtb_Message.Text += "Password: " + JSON_String["password"] + "\n";
                rtb_Message.Text += "First name: " + JSON_String["first_name"] + "\n";
                rtb_Message.Text += "Last name: " + JSON_String["last_name"] + "\n";
                rtb_Message.Text += "Sex: " + JSON_String["sex"] + "\n";
                rtb_Message.Text += "Birthday: " + JSON_String["birthday"] + "\n";
                rtb_Message.Text += "Language: " + JSON_String["language"] + "\n";
                rtb_Message.Text += "Phone: " + JSON_String["phone"] + "\n";
            }
        }
    }
}