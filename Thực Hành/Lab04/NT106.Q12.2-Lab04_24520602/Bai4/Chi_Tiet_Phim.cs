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
    public partial class Chi_Tiet_Phim : Form
    {
        public Chi_Tiet_Phim(string url)
        {
            InitializeComponent();
            Uri.TryCreate(url, UriKind.Absolute, out Uri result);
            wb_Chi_Tiet.Source = result;
        }
    }
}
