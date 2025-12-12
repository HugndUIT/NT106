namespace Lab03_Bai01
{
    partial class UDP_Server
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
            label2 = new Label();
            btn_listen_server = new Button();
            tb_port_server = new TextBox();
            label1 = new Label();
            btn_end_server = new Button();
            rtb_received_messages = new RichTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 85);
            label2.Name = "label2";
            label2.Size = new Size(216, 31);
            label2.TabIndex = 8;
            label2.Text = "Received Messages";
            // 
            // btn_listen_server
            // 
            btn_listen_server.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_listen_server.Location = new Point(305, 12);
            btn_listen_server.Name = "btn_listen_server";
            btn_listen_server.Size = new Size(207, 61);
            btn_listen_server.TabIndex = 7;
            btn_listen_server.Text = "Listen";
            btn_listen_server.UseVisualStyleBackColor = true;
            btn_listen_server.Click += btn_listen_server_Click;
            // 
            // tb_port_server
            // 
            tb_port_server.Location = new Point(120, 31);
            tb_port_server.Name = "tb_port_server";
            tb_port_server.Size = new Size(150, 27);
            tb_port_server.TabIndex = 6;
            tb_port_server.TextChanged += tb_port_server_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 31);
            label1.TabIndex = 5;
            label1.Text = "Port";
            // 
            // btn_end_server
            // 
            btn_end_server.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_end_server.Location = new Point(540, 12);
            btn_end_server.Name = "btn_end_server";
            btn_end_server.Size = new Size(207, 61);
            btn_end_server.TabIndex = 10;
            btn_end_server.Text = "End Server";
            btn_end_server.UseVisualStyleBackColor = true;
            btn_end_server.Click += btn_end_server_Click;
            // 
            // rtb_received_messages
            // 
            rtb_received_messages.Location = new Point(54, 119);
            rtb_received_messages.Name = "rtb_received_messages";
            rtb_received_messages.Size = new Size(693, 338);
            rtb_received_messages.TabIndex = 11;
            rtb_received_messages.Text = "";
            rtb_received_messages.TextChanged += rtb_received_messages_TextChanged;
            // 
            // UDP_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(rtb_received_messages);
            Controls.Add(btn_end_server);
            Controls.Add(label2);
            Controls.Add(btn_listen_server);
            Controls.Add(tb_port_server);
            Controls.Add(label1);
            Name = "UDP_Server";
            Text = "UDP_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btn_listen_server;
        private TextBox tb_port_server;
        private Label label1;
        private Button btn_end_server;
        private RichTextBox rtb_received_messages;
    }
}