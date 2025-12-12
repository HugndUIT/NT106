using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NT106.Q12._2_Lab02_24520602
{
    public partial class Lab02_Bai4 : Form
    {
        public Lab02_Bai4()
        {
            InitializeComponent();
        }

        static List<SinhVien> Dssv = new List<SinhVien>();

        int TrangHienTai = 0;

        private void btn_ghifile_Click(object sender, EventArgs e)
        {
            try
            {
                var json = JsonSerializer.Serialize(Dssv);
                File.WriteAllText("Input4.json", json);
                MessageBox.Show("Ghi file thành công!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienThiTrang(int trang)
        {
            var Listsv = JsonSerializer.Deserialize<List<SinhVien>>(File.ReadAllText("Output4.json"));
            if (Listsv == null || Listsv.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống!");
                return;
            }
            if (trang < 0 || trang > Listsv.Count - 1) return;
            TrangHienTai = trang;
            SinhVien sv = Listsv[trang];
            tb_xuatten.Text = sv.HoTen;
            tb_xuatmssv.Text = sv.MSSV.ToString();
            tb_xuatsdt.Text = sv.DienThoai;
            tb_xuatdiem1.Text = sv.Diem1.ToString();
            tb_xuatdiem2.Text = sv.Diem2.ToString();
            tb_xuatdiem3.Text = sv.Diem3.ToString();
            tb_xuatdtb.Text = sv.DTB.ToString();
            tb_sotrang.Text = (trang + 1).ToString();
        }

        private bool KiemTraHopLe()
        {
            if (string.IsNullOrEmpty(tb_nhapten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return false;
            }
            if (tb_nhapten.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Họ tên không được chứa số");
                return false;
            }
            if (tb_nhapmssv.Text.Length != 8 || !int.TryParse(tb_nhapmssv.Text, out _))
            {
                MessageBox.Show("Mã số sinh viên phải là số có 8 chữ số!");
                return false;
            }
            if (!tb_nhapsdt.Text.StartsWith("0") || tb_nhapsdt.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!");
                return false;
            }
            if (!float.TryParse(tb_nhapdiemmon1.Text, out float d1) ||
                !float.TryParse(tb_nhapdiemmon2.Text, out float d2) ||
                !float.TryParse(tb_nhapdiemmon3.Text, out float d3) ||
                d1 < 0 || d1 > 10 || d2 < 0 || d2 > 10 || d3 < 0 || d3 > 10)
            {
                MessageBox.Show("Điểm các môn phải từ 0 đến 10!");
                return false;
            }
            return true;
        }

        private void btn_themsv_Click_1(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;
            SinhVien sv = new SinhVien
            {
                HoTen = tb_nhapten.Text,
                MSSV = int.Parse(tb_nhapmssv.Text),
                DienThoai = tb_nhapsdt.Text,
                Diem1 = float.Parse(tb_nhapdiemmon1.Text),
                Diem2 = float.Parse(tb_nhapdiemmon2.Text),
                Diem3 = float.Parse(tb_nhapdiemmon3.Text)
            };
            Dssv.Add(sv);
            tb_nhapten.Clear();
            tb_nhapmssv.Clear();
            tb_nhapsdt.Clear();
            tb_nhapdiemmon1.Clear();
            tb_nhapdiemmon2.Clear();
            tb_nhapdiemmon3.Clear();
            rtb_thongtin.AppendText(
                $"Họ tên: {sv.HoTen}\n" +
                $"MSSV: {sv.MSSV}\n" +
                $"Điện thoại: {sv.DienThoai}\n" +
                $"Điểm 1: {sv.Diem1}\n" +
                $"Điểm 2: {sv.Diem2}\n" +
                $"Điểm 3: {sv.Diem3}\n" +
                $"Điểm TB: {sv.DTB:F2}\n\n"
            );
            MessageBox.Show("Thêm sinh viên thành công!");
        }

        private void btn_docfile_Click(object sender, EventArgs e)
        {
            Dssv.Clear();
            Dssv = JsonSerializer.Deserialize<List<SinhVien>>(File.ReadAllText("Input4.json"));
            foreach (var sv in Dssv)
            {
                sv.TinhDiemTB();
            }
            var json = JsonSerializer.Serialize(Dssv);
            File.WriteAllText("Output4.json", json);
            MessageBox.Show("Đọc file thành công!");
            HienThiTrang(0);
        }

        private void btn_trangtruoc_Click(object sender, EventArgs e)
        {
            if (Dssv == null || Dssv.Count == 0)
            {
                MessageBox.Show("Danh sách trống! Hãy đọc file trước.");
                return;
            }
            if (TrangHienTai > 0)
            {
                TrangHienTai--;
                HienThiTrang(TrangHienTai);
            }
            else
            {
                MessageBox.Show("Đây là trang đầu tiên!");
            }
        }

        private void btn_trangsau_Click(object sender, EventArgs e)
        {
            if (Dssv == null || Dssv.Count == 0)
            {
                MessageBox.Show("Danh sách trống! Hãy đọc file trước.");
                return;
            }
            if (TrangHienTai < Dssv.Count - 1)
            {
                TrangHienTai++;
                HienThiTrang(TrangHienTai);
            }
            else
            {
                MessageBox.Show("Đây là trang cuối cùng!");
            }
        }
    }

    public class SinhVien
    {
        public string HoTen { get; set; }
        public int MSSV { get; set; }
        public string DienThoai { get; set; }
        public float Diem1 { get; set; }
        public float Diem2 { get; set; }
        public float Diem3 { get; set; }
        public float DTB { get; set; }
        public void TinhDiemTB()
        {
            DTB = (Diem1 + Diem2 + Diem3) / 3;
        }
    }
}
