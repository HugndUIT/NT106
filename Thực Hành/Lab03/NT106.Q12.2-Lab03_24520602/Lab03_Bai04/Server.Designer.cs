namespace Lab03_Bai04
{
    partial class Server
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
            btn_start = new Button();
            btn_end = new Button();
            rtb_messages = new RichTextBox();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_start.Location = new Point(12, 12);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(212, 81);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_end
            // 
            btn_end.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_end.Location = new Point(12, 99);
            btn_end.Name = "btn_end";
            btn_end.Size = new Size(212, 81);
            btn_end.TabIndex = 1;
            btn_end.Text = "End";
            btn_end.UseVisualStyleBackColor = true;
            btn_end.Click += btn_end_Click;
            // 
            // rtb_messages
            // 
            rtb_messages.Location = new Point(230, 12);
            rtb_messages.Name = "rtb_messages";
            rtb_messages.Size = new Size(558, 344);
            rtb_messages.TabIndex = 4;
            rtb_messages.Text = "";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(rtb_messages);
            Controls.Add(btn_end);
            Controls.Add(btn_start);
            Name = "Server";
            Text = "Server";
            FormClosing += Server_FormClosing;
            Load += Server_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private Button btn_end;
        private RichTextBox rtb_messages;
    }
}