namespace Lab03_Bai04
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Server)
                {
                    form.BringToFront();
                    MessageBox.Show("Server is running!");
                    return;
                }
            }
            Server May_Chu  = new Server();
            May_Chu.Show();
        }

        private void btn_client_Click(object sender, EventArgs e) 
        { 
            Client May_Khach = new Client();
            May_Khach.Show();
        }
    }
}
