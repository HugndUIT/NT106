using System.IO;
namespace NT106.Q12._2_Lab02_24520602
{
    public partial class Lab02_Bai1 : Form
    {
        public Lab02_Bai1()
        {
            InitializeComponent();
        }

        private void btn_docfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input1.txt"))
                {
                    string info = sr.ReadToEnd();
                    rtb_thongtin.Text = info.Trim();
                }
                MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đọc file không thành công!", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void btn_ghifile_Click(object sender, EventArgs e)
        {
            try
            {
                string info = rtb_thongtin.Text.ToUpper().Trim();
                if (string.IsNullOrEmpty(info))
                {
                    MessageBox.Show("Không có nội dung nào để ghi!");
                    return;
                }
                using (StreamWriter sw = new StreamWriter("output1.txt"))
                {
                    sw.WriteLine(info);
                }
                MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi file không thành công!", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void rtb_thongtin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}