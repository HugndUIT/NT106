namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_nhapsothunhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nhapsothuhai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_nhapsothunhat.Text, out int num1) && int.TryParse(tb_nhapsothuhai.Text, out int num2))
            {
                int sum = num1 + num2;
                tb_ketqua.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
