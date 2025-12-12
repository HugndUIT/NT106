namespace Lab03_Bai03
{
    partial class TCP_Server
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
            btn_listen = new Button();
            SuspendLayout();
            // 
            // rtb_messages
            // 
            rtb_messages.Location = new Point(12, 12);
            rtb_messages.Name = "rtb_messages";
            rtb_messages.Size = new Size(578, 426);
            rtb_messages.TabIndex = 1;
            rtb_messages.Text = "";
            rtb_messages.TextChanged += rtb_messages_TextChanged;
            // 
            // btn_listen
            // 
            btn_listen.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_listen.Location = new Point(598, 12);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(204, 94);
            btn_listen.TabIndex = 2;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // TCP_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(btn_listen);
            Controls.Add(rtb_messages);
            Name = "TCP_Server";
            Text = "TCP_Server";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_messages;
        private Button btn_listen;
    }
}