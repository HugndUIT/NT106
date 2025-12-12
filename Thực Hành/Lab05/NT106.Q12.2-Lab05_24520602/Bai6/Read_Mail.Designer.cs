namespace Bai6
{
    partial class Read_Mail
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
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.wb_Mail = new System.Windows.Forms.WebBrowser();
            this.rtb_Body = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(46, 38);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(50, 20);
            this.lbl_From.TabIndex = 0;
            this.lbl_From.Text = "From:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(46, 75);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(31, 20);
            this.lbl_To.TabIndex = 1;
            this.lbl_To.Text = "To:";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(45, 113);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(63, 20);
            this.lbl_Subject.TabIndex = 2;
            this.lbl_Subject.Text = "Subject";
            // 
            // wb_Mail
            // 
            this.wb_Mail.Location = new System.Drawing.Point(49, 173);
            this.wb_Mail.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Mail.Name = "wb_Mail";
            this.wb_Mail.Size = new System.Drawing.Size(1034, 490);
            this.wb_Mail.TabIndex = 3;
            this.wb_Mail.Visible = false;
            // 
            // rtb_Body
            // 
            this.rtb_Body.Location = new System.Drawing.Point(49, 173);
            this.rtb_Body.Name = "rtb_Body";
            this.rtb_Body.Size = new System.Drawing.Size(1034, 490);
            this.rtb_Body.TabIndex = 4;
            this.rtb_Body.Text = "";
            this.rtb_Body.Visible = false;
            // 
            // Read_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.rtb_Body);
            this.Controls.Add(this.wb_Mail);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Read_Mail";
            this.Text = "Read_Mail";
            this.Load += new System.EventHandler(this.Read_Mail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.WebBrowser wb_Mail;
        private System.Windows.Forms.RichTextBox rtb_Body;
    }
}