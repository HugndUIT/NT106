using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bai7.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai7
{
    public partial class frm_HomNayAnGi : Form
    {
        private readonly string NguoiThem;
        private readonly HttpClient HttpClient;
        private readonly string AuthToken;
        private bool _isProgrammaticChange = false;

        List<FoodItem> All_Dishes = new List<FoodItem>();
        public frm_HomNayAnGi(string token)
        {
            InitializeComponent();
            this.AuthToken = token;

            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://nt106.uitiot.vn");
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);

            SetupPaginationControls();
        }

        private void SetupPaginationControls()
        {
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("15");
            comboBox2.SelectedIndex = 0;

        }

        private async void Frm_HomNayAnGi_Load(object sender, EventArgs e)
        {
            await Load_Data_For_Active_Tab();
        }

        private async void Tc_DanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Reset_Page_And_Load_Data();
        }

        private async void ComboBox_Pagination_Changed(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            await Load_Data_For_Active_Tab();
        }

        private async Task Reset_Page_And_Load_Data()
        {
            comboBox1.Items.Clear();

            await Load_Data_For_Active_Tab();
        }

        private async Task Load_Data_For_Active_Tab()
        {
            int Current_Page = comboBox1.SelectedItem != null ? int.Parse(comboBox1.SelectedItem.ToString()) : 1;
            int Page_Size = comboBox2.SelectedItem != null ? int.Parse(comboBox2.SelectedItem.ToString()) : 5;

            try
            {
                if (tc_DanhSachMonAn.SelectedTab == tPage_All)
                {
                    await Load_All_Dishes(Current_Page, Page_Size);
                }
                else if (tc_DanhSachMonAn.SelectedTab == tPage_CuaToi)
                {
                    await Load_My_Dishes(Current_Page, Page_Size);
                }
            }
            catch
            {

            }
        }

        private async Task Load_All_Dishes(int Page, int Page_Size)
        {

            try
            {
                All_Dishes.Clear();
                do
                {
                    var Api_Request_Body = new ApiRequest { Current = Page, PageSize = Page_Size };
                    string Json_Request_Body = JsonConvert.SerializeObject(Api_Request_Body);
                    var Content = new StringContent(Json_Request_Body, Encoding.UTF8, "application/json");

                    HttpResponseMessage Response = await HttpClient.PostAsync("/api/v1/monan/all", Content);
                    string Json_Response = await Response.Content.ReadAsStringAsync();

                    if (!Response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Lỗi tải 'All': {Json_Response}", "Lỗi API");
                        break;
                    }

                    var Api_Response = JsonConvert.DeserializeObject<ApiResponse>(Json_Response);

                    if (Api_Response.Data == null || Api_Response.Data.Count == 0)
                        break;

                    All_Dishes.AddRange(Api_Response.Data);
                    if (All_Dishes.Count >= Api_Response.Pagination.Total)
                        break;

                    Page++;
                } while (true);

                var Dishes_To_Show = All_Dishes.Count > Page_Size ? All_Dishes.GetRange(0, Page_Size) : All_Dishes;

                await Update_Dishes_UI(flp_MenuAll, Dishes_To_Show);

                Update_Pagination_Controls(new PaginationInfo
                {
                    Current = 1,
                    PageSize = Page_Size,
                    Total = All_Dishes.Count
                });


                comboBox1.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Lỗi: {Ex.Message}", "Lỗi kết nối");
            }
        }

        private async Task Load_My_Dishes(int Page, int Page_Size)
        {
            var requestBody = new ApiRequest { Current = Page, PageSize = Page_Size };
            try
            {
                string jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await HttpClient.PostAsync("/api/v1/monan/my-dishes", content);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);
                    await Update_Dishes_UI(flp_Menu, apiResponse.Data);
                    Update_Pagination_Controls(apiResponse.Pagination);
                }
                else
                {
                    MessageBox.Show($"Lỗi tải 'My Dishes': {jsonResponse}", "Lỗi API");
                    flp_Menu.Controls.Clear();
                    Update_Pagination_Controls(new PaginationInfo { Current = 1, PageSize = Page_Size, Total = 0 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi kết nối");
            }
        }

        private async Task XoaMonAn(string id, FoodItemControl controlRemove)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://nt106.uitiot.vn");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);

                try
                {
                    HttpResponseMessage response = await client.DeleteAsync($"/api/v1/monan/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xoá món thành công");

                        controlRemove.Parent.Controls.Remove(controlRemove);
                        controlRemove.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xoá món", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }

        private async Task Update_Dishes_UI(FlowLayoutPanel Panel, List<FoodItem> Dishes)
        {
            Panel.SuspendLayout();
            Panel.Controls.Clear();

            foreach (var Dish in Dishes)
            {
                FoodItemControl Item_Control = new FoodItemControl();
                string Food_Image = Dish.HinhAnh;
                Item_Control.SetData(Dish.Id, Dish.TenMonAn, Dish.Gia, Dish.DiaChi, Dish.NguoiDongGop, Food_Image);
                Panel.Controls.Add(Item_Control);

                bool IsMyFood = (tc_DanhSachMonAn.SelectedTab == tPage_CuaToi);

                Item_Control.ShowDeleteButton(IsMyFood);

                Item_Control.DeleteClicked += async (s, e) =>
                {
                    await XoaMonAn(Dish.Id, Item_Control);
                };

                Panel.Controls.Add(Item_Control);
            }

            Panel.ResumeLayout();
        }

        private void Update_Pagination_Controls(PaginationInfo Pagination)
        {

            _isProgrammaticChange = true;

            try
            {
                int totalRecords = Pagination.Total;
                int Total_Pages = Math.Max(1, (int)Math.Ceiling((double)totalRecords / Pagination.PageSize));

                comboBox1.BeginUpdate();
                comboBox1.Items.Clear();

                for (int i = 1; i <= Total_Pages; i++)
                {
                    comboBox1.Items.Add(i.ToString());
                }
                comboBox1.EndUpdate();

                if (Pagination.Current <= Total_Pages)
                {
                    comboBox1.SelectedIndex = Pagination.Current - 1;
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
            finally
            {

                _isProgrammaticChange = false;
            }
        }

        private async void btn_AnGi_Click(object sender, EventArgs e)
        {
            string apiUrl = "";
            if (tc_DanhSachMonAn.SelectedIndex == 0)
            {
                apiUrl = "https://nt106.uitiot.vn/api/v1/monan/all";
            }
            else
            {
                apiUrl = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
            }

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AuthToken);
                try
                {
                    var payload = new
                    {
                        page = 1,
                        page_size = 9999
                    };

                    string JsonString = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(JsonString, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        JObject jsonResponse = JObject.Parse(responseBody);

                        var listMonAn = jsonResponse["data"].ToObject<List<FoodItem>>();

                        if (listMonAn != null && listMonAn.Count > 0)
                        {
                            Random rnd = new Random();
                            int index = rnd.Next(listMonAn.Count);
                            FoodItem KetQua = listMonAn[index];
                            frm_AnGi Angi = new frm_AnGi(KetQua);
                            Angi.Show();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }

        private async Task Render_Local_Data()
        {

            int Current_Page = comboBox1.SelectedItem != null ? int.Parse(comboBox1.SelectedItem.ToString()) : 1;
            int Page_Size = comboBox2.SelectedItem != null ? int.Parse(comboBox2.SelectedItem.ToString()) : 5;

            int skip = (Current_Page - 1) * Page_Size;


            if (skip >= All_Dishes.Count) return;


            int take = Math.Min(Page_Size, All_Dishes.Count - skip);

            var Dishes_To_Show = All_Dishes.GetRange(skip, take);


            await Update_Dishes_UI(flp_MenuAll, Dishes_To_Show);
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_isProgrammaticChange) return;

            if (tc_DanhSachMonAn.SelectedTab == tPage_All)
            {
                if (All_Dishes == null || All_Dishes.Count == 0) return;
                await Render_Local_Data();
            }
            else if (tc_DanhSachMonAn.SelectedTab == tPage_CuaToi)
            {
                await Load_Data_For_Active_Tab();
            }
        }
        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            ThemMonAn AddFood = new ThemMonAn(NguoiThem, AuthToken);
            AddFood.Show();
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
