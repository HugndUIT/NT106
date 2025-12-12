using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class FoodItemControl : UserControl
    {
        public string FoodID { get; private set; }

        public event EventHandler DeleteClicked;

        public FoodItemControl()
        {
            InitializeComponent();
        }

        public void SetData(string id, string name, string price, string address, string contributor, string img)
        {
            this.FoodID = id;
            lbl_Ten.Text = name;
            tb_Gia.Text = price;
            tb_DiaChi.Text = address;
            tb_DongGop.Text = contributor;


            try
            {

                if (string.IsNullOrWhiteSpace(img))
                {
                    ptb_HinhAnh.Image = null;
                    return;
                }

                img = img.Trim();


                bool isUrl = Uri.TryCreate(img, UriKind.Absolute, out Uri uriResult)
                             && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (isUrl)
                {
                    ptb_HinhAnh.LoadAsync(img);
                }
                else
                {
                    ptb_HinhAnh.Image = null;
                }
            }
            catch (Exception)
            {
                ptb_HinhAnh.Image = null;
            }
        }

        public void ShowDeleteButton(bool isVisible)
        {
            btn_Xoa.Visible = isVisible;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
