namespace Lab03_Bai03
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_TCP_client_Click(object sender, EventArgs e)
        {
            TCP_Client Client = new TCP_Client();
            Client.Show();
        }

        private void btn_TCP_server_Click(object sender, EventArgs e)
        {
            foreach (Form Forms in Application.OpenForms)
            {
                if (Forms is TCP_Server)
                {
                    Forms.BringToFront();
                    return;
                }
            }
            TCP_Server Server = new TCP_Server();
            Server.Show();
        }
    }
}
