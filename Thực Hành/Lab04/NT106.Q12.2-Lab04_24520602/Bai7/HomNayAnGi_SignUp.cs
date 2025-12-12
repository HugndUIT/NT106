using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bai7
{
    public partial class frm_HomNayAnGi_SignUp: Form
    {
        public frm_HomNayAnGi_SignUp()
        {
            InitializeComponent();
        }

        private async void btn_DangKy_Click(object sender, EventArgs e)
        {
            var url = "https://nt106.uitiot.vn/api/v1/user/signup";

            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text) ||
                string.IsNullOrEmpty(tb_Email.Text) || string.IsNullOrEmpty(tb_Phone.Text) || 
                string.IsNullOrEmpty(tb_FirstName.Text) || string.IsNullOrEmpty(tb_LastName.Text) ||
                (!rtbn_Female.Checked && !rbtn_Male.Checked) ||
                cbb_Language.SelectedIndex == -1) 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (var client = new HttpClient())
            {
                var data = new
                {
                    username = tb_Username.Text,
                    password = tb_Password.Text,
                    email = tb_Email.Text,
                    first_name = tb_FirstName.Text,
                    last_name = tb_LastName.Text,
                    sex = rtbn_Female.Checked ? 1 : 0,
                    birthday = dtp_Birthday.Value.ToString("yyyy-MM-dd"),
                    language = cbb_Language.SelectedItem.ToString(),
                    phone = tb_Phone.Text
                };

                string json = JsonConvert.SerializeObject(data);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

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
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                }
            }
        }
    }
}