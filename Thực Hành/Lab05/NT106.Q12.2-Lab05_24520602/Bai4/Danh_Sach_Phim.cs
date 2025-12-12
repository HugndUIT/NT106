using Bbai4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Danh_Sach_Phim : Form
    {
        public Danh_Sach_Phim()
        {
            InitializeComponent();
            LoadFilm();
        }

        private void LoadFilm()
        {
            using (WebClient My_Client = new WebClient())
            {

                My_Client.Encoding = Encoding.UTF8;
                string Html_Content = My_Client.DownloadString("https://betacinemas.vn/phim.htm");

                HtmlAgilityPack.HtmlDocument HtmlDoc = new HtmlAgilityPack.HtmlDocument();
                HtmlDoc.LoadHtml(Html_Content);

                var MovieInfo = HtmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'padding-bottom-30')]/div[@class='row']");

                foreach (var Movie in MovieInfo)
                {

                    var anh = Movie.SelectSingleNode(".//div[contains(@class, 'product-item')]//img");
                    string linkanh = anh.GetAttributeValue("src", "");

                    var Chi_Tiet_Phim = Movie.SelectSingleNode(".//div[contains(@class, 'film-info')]//h3/a");
                    string Ten_Phim = WebUtility.HtmlDecode(Chi_Tiet_Phim.InnerText.Trim());

                    if (!string.IsNullOrEmpty(Ten_Phim))
                    {

                        Banner Banner = new Banner(Ten_Phim, linkanh);

                        flp_Danh_Sach_Phim.Controls.Add(Banner);
                    }
                }
            }
        }

        private void btn_Mua_Ve_Click(object sender, EventArgs e)
        {
            Dat_Ve_Phim form = new Dat_Ve_Phim();
            form.Show();
        }
    }
}
