namespace Lab03_Bai03
{
    partial class Dashboard
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
            btn_TCP_server = new Button();
            btn_TCP_client = new Button();
            SuspendLayout();
            // 
            // btn_TCP_server
            // 
            btn_TCP_server.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TCP_server.Location = new Point(12, 146);
            btn_TCP_server.Name = "btn_TCP_server";
            btn_TCP_server.Size = new Size(726, 102);
            btn_TCP_server.TabIndex = 3;
            btn_TCP_server.Text = "TCP Server";
            btn_TCP_server.UseVisualStyleBackColor = true;
            btn_TCP_server.Click += btn_TCP_server_Click;
            // 
            // btn_TCP_client
            // 
            btn_TCP_client.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TCP_client.Location = new Point(12, 12);
            btn_TCP_client.Name = "btn_TCP_client";
            btn_TCP_client.Size = new Size(726, 102);
            btn_TCP_client.TabIndex = 2;
            btn_TCP_client.Text = "TCP Client";
            btn_TCP_client.UseVisualStyleBackColor = true;
            btn_TCP_client.Click += btn_TCP_client_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 260);
            Controls.Add(btn_TCP_server);
            Controls.Add(btn_TCP_client);
            Name = "Dashboard";
            Text = "Lab03_Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_TCP_server;
        private Button btn_TCP_client;
    }
}
