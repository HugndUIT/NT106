using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class frm_AnGi: Form
    {
        public frm_AnGi(Model.FoodItem MonAn)
        {
            InitializeComponent();
            lbl_TenMon.Text = MonAn.TenMonAn;
            lbl_Gia.Text = $"Giá:       {MonAn.Gia}";
            lbl_DiaChi.Text = $"Địa chỉ:        {MonAn.DiaChi}";
            lbl_NguoiDongGop.Text = $"Người đóng góp:        {MonAn.NguoiDongGop}";
            ptb_HinhAnh.LoadAsync(MonAn.HinhAnh);
            this.Text = $"Ăn {MonAn.TenMonAn} đi!!!!!";
        }
    }
}
