using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Banner_Phim : UserControl
    {
        public event EventHandler<string> BannerSelect;
        private string TenPhim;
        private string URL;
        private string Anh;

        public Banner_Phim(string tenphim, string url, string anh)

        {

            InitializeComponent();

            TenPhim = tenphim;
            URL = url;
            lbl_Ten_Phim.Text = TenPhim;
            lbl_URL.Text = URL;
            ptb_Anh_Phim.LoadAsync(anh);

            this.DoubleClick += Banner_Phim_DoubleClick;
            lbl_Ten_Phim.DoubleClick += Banner_Phim_DoubleClick;
            lbl_URL.DoubleClick += Banner_Phim_DoubleClick;
            ptb_Anh_Phim.DoubleClick += Banner_Phim_DoubleClick;

        }
        private void Banner_Phim_DoubleClick(object sender, EventArgs e)
        {
            BannerSelect(this, this.URL);
        }
    }
}
