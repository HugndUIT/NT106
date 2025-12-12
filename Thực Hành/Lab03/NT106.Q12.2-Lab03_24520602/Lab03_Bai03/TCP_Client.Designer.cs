namespace Lab03_Bai03
{
    partial class TCP_Client
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
            btn_connect = new Button();
            btn_send = new Button();
            btn_disconnect = new Button();
            SuspendLayout();
            // 
            // rtb_messages
            // 
            rtb_messages.Location = new Point(12, 12);
            rtb_messages.Name = "rtb_messages";
            rtb_messages.Size = new Size(539, 294);
            rtb_messages.TabIndex = 0;
            rtb_messages.Text = "";
            rtb_messages.TextChanged += rtb_messages_TextChanged;
            // 
            // btn_connect
            // 
            btn_connect.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_connect.Location = new Point(557, 12);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(204, 94);
            btn_connect.TabIndex = 1;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_send
            // 
            btn_send.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_send.Location = new Point(557, 112);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(204, 94);
            btn_send.TabIndex = 2;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_disconnect
            // 
            btn_disconnect.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_disconnect.Location = new Point(557, 212);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(204, 94);
            btn_disconnect.TabIndex = 3;
            btn_disconnect.Text = "Disconnect";
            btn_disconnect.UseVisualStyleBackColor = true;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // TCP_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 324);
            Controls.Add(btn_disconnect);
            Controls.Add(btn_send);
            Controls.Add(btn_connect);
            Controls.Add(rtb_messages);
            Name = "TCP_Client";
            Text = "TCP_Client";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_messages;
        private Button btn_connect;
        private Button btn_send;
        private Button btn_disconnect;
    }
}