namespace Lab03_Bai01
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btn_UDP_client_Click(object sender, EventArgs e)
        {
            UDP_Client Client = new UDP_Client();
            Client.Show();
        }

        private void btn_UDP_server_Click(object sender, EventArgs e)
        {
            foreach (Form Forms in Application.OpenForms)
            {
                if (Forms is UDP_Server)
                {
                    Forms.BringToFront();
                    return;
                }
            }
            UDP_Server Server = new UDP_Server();
            Server.Show();
        }
    }
}
