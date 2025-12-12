namespace Lab03_Bai01
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_UDP_client = new Button();
            btn_UDP_server = new Button();
            SuspendLayout();
            // 
            // btn_UDP_client
            // 
            btn_UDP_client.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UDP_client.Location = new Point(25, 39);
            btn_UDP_client.Name = "btn_UDP_client";
            btn_UDP_client.Size = new Size(210, 102);
            btn_UDP_client.TabIndex = 0;
            btn_UDP_client.Text = "UDP Client";
            btn_UDP_client.UseVisualStyleBackColor = true;
            btn_UDP_client.Click += btn_UDP_client_Click;
            // 
            // btn_UDP_server
            // 
            btn_UDP_server.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UDP_server.Location = new Point(288, 39);
            btn_UDP_server.Name = "btn_UDP_server";
            btn_UDP_server.Size = new Size(204, 102);
            btn_UDP_server.TabIndex = 1;
            btn_UDP_server.Text = "UDP Server";
            btn_UDP_server.UseVisualStyleBackColor = true;
            btn_UDP_server.Click += btn_UDP_server_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 178);
            Controls.Add(btn_UDP_server);
            Controls.Add(btn_UDP_client);
            Name = "DashBoard";
            Text = "Lab03_Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_UDP_client;
        private Button btn_UDP_server;
    }
}
