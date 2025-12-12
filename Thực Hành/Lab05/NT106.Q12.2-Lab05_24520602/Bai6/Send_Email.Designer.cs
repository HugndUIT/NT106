namespace Bai6
{
    partial class frm_SendEmail
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
            this.lbl_Sender = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Received = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.lbl_Attach = new System.Windows.Forms.Label();
            this.rtb_Body = new System.Windows.Forms.RichTextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_Attach = new System.Windows.Forms.TextBox();
            this.tb_EmailSender = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_EmailReceived = new System.Windows.Forms.TextBox();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.cb_HTML = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_Sender
            // 
            this.lbl_Sender.AutoSize = true;
            this.lbl_Sender.Location = new System.Drawing.Point(51, 56);
            this.lbl_Sender.Name = "lbl_Sender";
            this.lbl_Sender.Size = new System.Drawing.Size(48, 20);
            this.lbl_Sender.TabIndex = 0;
            this.lbl_Sender.Text = "From";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(51, 114);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Received
            // 
            this.lbl_Received.AutoSize = true;
            this.lbl_Received.Location = new System.Drawing.Point(51, 172);
            this.lbl_Received.Name = "lbl_Received";
            this.lbl_Received.Size = new System.Drawing.Size(28, 20);
            this.lbl_Received.TabIndex = 2;
            this.lbl_Received.Text = "To";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(51, 235);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(65, 20);
            this.lbl_Subject.TabIndex = 3;
            this.lbl_Subject.Text = "Subject";
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Location = new System.Drawing.Point(51, 312);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(47, 20);
            this.lbl_Body.TabIndex = 4;
            this.lbl_Body.Text = "Body";
            // 
            // lbl_Attach
            // 
            this.lbl_Attach.AutoSize = true;
            this.lbl_Attach.Location = new System.Drawing.Point(46, 737);
            this.lbl_Attach.Name = "lbl_Attach";
            this.lbl_Attach.Size = new System.Drawing.Size(94, 20);
            this.lbl_Attach.TabIndex = 5;
            this.lbl_Attach.Text = "Attachment";
            // 
            // rtb_Body
            // 
            this.rtb_Body.Location = new System.Drawing.Point(163, 356);
            this.rtb_Body.Name = "rtb_Body";
            this.rtb_Body.Size = new System.Drawing.Size(565, 354);
            this.rtb_Body.TabIndex = 6;
            this.rtb_Body.Text = "";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(599, 734);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(129, 30);
            this.btn_Browse.TabIndex = 7;
            this.btn_Browse.Text = "Browse...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(599, 781);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(129, 45);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_Attach
            // 
            this.tb_Attach.Location = new System.Drawing.Point(163, 734);
            this.tb_Attach.Name = "tb_Attach";
            this.tb_Attach.ReadOnly = true;
            this.tb_Attach.Size = new System.Drawing.Size(426, 26);
            this.tb_Attach.TabIndex = 9;
            // 
            // tb_EmailSender
            // 
            this.tb_EmailSender.Location = new System.Drawing.Point(163, 53);
            this.tb_EmailSender.Name = "tb_EmailSender";
            this.tb_EmailSender.ReadOnly = true;
            this.tb_EmailSender.Size = new System.Drawing.Size(565, 26);
            this.tb_EmailSender.TabIndex = 10;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(163, 111);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(565, 26);
            this.tb_Name.TabIndex = 11;
            // 
            // tb_EmailReceived
            // 
            this.tb_EmailReceived.Location = new System.Drawing.Point(163, 169);
            this.tb_EmailReceived.Name = "tb_EmailReceived";
            this.tb_EmailReceived.Size = new System.Drawing.Size(565, 26);
            this.tb_EmailReceived.TabIndex = 12;
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(163, 232);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(565, 26);
            this.tb_Subject.TabIndex = 13;
            // 
            // cb_HTML
            // 
            this.cb_HTML.AutoSize = true;
            this.cb_HTML.Location = new System.Drawing.Point(163, 311);
            this.cb_HTML.Name = "cb_HTML";
            this.cb_HTML.Size = new System.Drawing.Size(78, 24);
            this.cb_HTML.TabIndex = 14;
            this.cb_HTML.Text = "HTML";
            this.cb_HTML.UseVisualStyleBackColor = true;
            // 
            // frm_SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 838);
            this.Controls.Add(this.cb_HTML);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.tb_EmailReceived);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_EmailSender);
            this.Controls.Add(this.tb_Attach);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.rtb_Body);
            this.Controls.Add(this.lbl_Attach);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_Received);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Sender);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SendEmail";
            this.Text = "Send email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sender;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Received;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.Label lbl_Attach;
        private System.Windows.Forms.RichTextBox rtb_Body;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_Attach;
        private System.Windows.Forms.TextBox tb_EmailSender;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_EmailReceived;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.CheckBox cb_HTML;
    }
}