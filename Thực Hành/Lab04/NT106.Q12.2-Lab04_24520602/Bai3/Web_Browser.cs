using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;

namespace Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();

        }

        private bool InitialLoad = false;

        private void btn_Load_Click(object sender, EventArgs e)
        {
            string url = tb_Url.Text;
            if (!string.IsNullOrEmpty(url))
            {
                Uri result;
                if (Uri.TryCreate(url, UriKind.Absolute, out result))
                {
                    InitialLoad = true;
                    wv_Web.Source = result;
                }
                else
                {
                    MessageBox.Show("URL không hợp lệ", "Lỗi");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL của web", "Lỗi");
                return;
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            wv_Web.Reload();
        }

        private void btn_DownFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Url.Text))
            {
                try
                {
                    using (WebClient myClient = new WebClient())
                    {
                        using (Stream response = myClient.OpenRead(tb_Url.Text))
                        {
                            string path = @"C:\Users\Admin\Downloads\web.html";
                            myClient.DownloadFile(tb_Url.Text, path);
                            MessageBox.Show("Tải file thành công");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi tải file", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL của web", "Lỗi");
                return;
            }
        }

        
        private void btn_DownResource_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Url.Text))
            {
                string downloadFolder = @"C:\Users\Admin\Downloads\";
                using (WebClient myClient = new WebClient())
                {
                    string htmlcontent = myClient.DownloadString(tb_Url.Text);

                    HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
                    htmldoc.LoadHtml(htmlcontent);
                    var imgs = htmldoc.DocumentNode.SelectNodes("//img");
                    if (imgs == null)
                    {
                        MessageBox.Show("Không có file hình ảnh nào trong url trên");
                        return;
                    }

                    if (!Uri.TryCreate(tb_Url.Text, UriKind.Absolute, out Uri baseUri))
                    {
                        MessageBox.Show("URL không hợp lệ", "Lỗi");
                        return;
                    }

                    foreach (var img in imgs.Where(i => i.GetAttributeValue("src", string.Empty) != string.Empty))
                    {
                        string srcimg = img.GetAttributeValue("src", string.Empty);

                        if (!Uri.TryCreate(baseUri, srcimg, out Uri fulllink))
                        {
                            continue;
                        }
                        string link = fulllink.AbsoluteUri;
                        string fileName = Path.GetFileName(fulllink.AbsolutePath);
                        string fullPath = Path.Combine(downloadFolder, fileName);

                        try
                        {
                            myClient.DownloadFile(link, fullPath);
                        }
                        catch(Exception ex)
                        {

                        }
                    }
                }
                MessageBox.Show("Tải resource thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL của web", "Lỗi");
                return;
            }
        }
        

        private void wv_Web_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                wv_Web.NavigationStarting += wv_Web_NavigationStarting;
                wv_Web.NavigationCompleted += wv_Web_NavigationCompleted;
                wv_Web.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            }
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
            WebView form = new WebView(e.Uri);
            form.Show();
        }

        private void wv_Web_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            InitialLoad = false;
        }

        private void wv_Web_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (InitialLoad)
            {
                return;
            }

            if (e.IsUserInitiated)
            {
                string Url = e.Uri;
                e.Cancel = true;
                WebView form = new WebView(Url);
                form.Show();
            }

        }
    }
}
