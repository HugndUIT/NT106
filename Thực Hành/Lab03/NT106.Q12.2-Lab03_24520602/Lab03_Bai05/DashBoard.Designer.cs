namespace Lab03_Bai04
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
            btn_server = new Button();
            btn_client = new Button();
            SuspendLayout();
            // 
            // btn_server
            // 
            btn_server.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_server.Location = new Point(36, 31);
            btn_server.Name = "btn_server";
            btn_server.Size = new Size(422, 44);
            btn_server.TabIndex = 0;
            btn_server.Text = "Open Server";
            btn_server.UseVisualStyleBackColor = true;
            btn_server.Click += btn_server_Click;
            // 
            // btn_client
            // 
            btn_client.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_client.Location = new Point(36, 106);
            btn_client.Name = "btn_client";
            btn_client.Size = new Size(422, 44);
            btn_client.TabIndex = 1;
            btn_client.Text = "Open Client";
            btn_client.UseVisualStyleBackColor = true;
            btn_client.Click += btn_client_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 193);
            Controls.Add(btn_client);
            Controls.Add(btn_server);
            Name = "DashBoard";
            Text = "Lab03_Bai05";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_server;
        private Button btn_client;
    }
}
