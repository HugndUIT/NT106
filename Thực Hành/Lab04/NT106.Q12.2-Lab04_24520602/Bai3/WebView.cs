using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class WebView : Form
    {
        private string LoadUrl;
        private bool InitialLoad = true;
        public WebView(string url)
        {
            InitializeComponent();
            LoadUrl = url;
            wv_WebMoi.EnsureCoreWebView2Async(null);
            wv_WebMoi.CoreWebView2InitializationCompleted += wv_WebMoi_CoreWebView2InitializationCompleted;
            wv_WebMoi.NavigationStarting += wv_WebMoi_NavigationStarting;
        }

        private void wv_WebMoi_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
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

        private void wv_WebMoi_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if(e.IsSuccess && !string.IsNullOrEmpty(LoadUrl))
            {
                wv_WebMoi.NavigationCompleted += wv_WebMoi_NavigationCompleted;
                wv_WebMoi.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
                wv_WebMoi.CoreWebView2.Navigate(LoadUrl);
            }   
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;

            WebView form = new WebView(e.Uri);
            form.Show();
        }

        private void wv_WebMoi_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            InitialLoad = false;
        }
    }
}
