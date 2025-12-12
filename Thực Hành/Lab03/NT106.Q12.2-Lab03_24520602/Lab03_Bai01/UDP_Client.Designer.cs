namespace Lab03_Bai01
{
    partial class UDP_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtb_messages = new RichTextBox();
            label2 = new Label();
            tb_IP_server = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tb_port_server = new TextBox();
            btn_send_client = new Button();
            SuspendLayout();
            // 
            // rtb_messages
            // 
            rtb_messages.Location = new Point(33, 131);
            rtb_messages.Name = "rtb_messages";
            rtb_messages.Size = new Size(639, 316);
            rtb_messages.TabIndex = 14;
            rtb_messages.Text = "";
            rtb_messages.TextChanged += rtb_messages_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 97);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 13;
            label2.Text = "Messages";
            // 
            // tb_IP_server
            // 
            tb_IP_server.Location = new Point(219, 45);
            tb_IP_server.Name = "tb_IP_server";
            tb_IP_server.Size = new Size(231, 27);
            tb_IP_server.TabIndex = 11;
            tb_IP_server.TextChanged += tb_IP_server_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 10;
            label1.Text = "IP Remote Host";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(456, 39);
            label3.Name = "label3";
            label3.Size = new Size(60, 31);
            label3.TabIndex = 15;
            label3.Text = "Port";
            // 
            // tb_port_server
            // 
            tb_port_server.Location = new Point(522, 45);
            tb_port_server.Name = "tb_port_server";
            tb_port_server.Size = new Size(150, 27);
            tb_port_server.TabIndex = 16;
            tb_port_server.TextChanged += tb_port_server_TextChanged;
            // 
            // btn_send_client
            // 
            btn_send_client.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_send_client.Location = new Point(243, 453);
            btn_send_client.Name = "btn_send_client";
            btn_send_client.Size = new Size(207, 61);
            btn_send_client.TabIndex = 17;
            btn_send_client.Text = "Send Messages";
            btn_send_client.UseVisualStyleBackColor = true;
            btn_send_client.Click += btn_send_client_Click;
            // 
            // UDP_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 526);
            Controls.Add(btn_send_client);
            Controls.Add(tb_port_server);
            Controls.Add(label3);
            Controls.Add(rtb_messages);
            Controls.Add(label2);
            Controls.Add(tb_IP_server);
            Controls.Add(label1);
            Name = "UDP_Client";
            Text = "UDP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_messages;
        private Label label2;
        private TextBox tb_IP_server;
        private Label label1;
        private Label label3;
        private TextBox tb_port_server;
        private Button btn_send_client;
    }
}