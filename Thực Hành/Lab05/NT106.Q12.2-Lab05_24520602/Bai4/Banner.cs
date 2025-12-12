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
    public partial class Banner : UserControl
    {
        private string TenPhim;
        private string Anh;

        public Banner(string tenphim, string anh)

        {

            InitializeComponent();

            TenPhim = tenphim;
            lbl_Ten_Phim.Text = TenPhim;
            ptb_Anh_Phim.LoadAsync(anh);

        }
    }
}
