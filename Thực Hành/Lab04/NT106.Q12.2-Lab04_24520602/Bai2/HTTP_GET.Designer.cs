namespace Bai2
{
    partial class frm_Bai2
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
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.tb_FileSave = new System.Windows.Forms.TextBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.rtb_FileHTML = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_URL
            // 
            this.tb_URL.Location = new System.Drawing.Point(30, 23);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(645, 27);
            this.tb_URL.TabIndex = 0;
            // 
            // tb_FileSave
            // 
            this.tb_FileSave.Location = new System.Drawing.Point(30, 70);
            this.tb_FileSave.Name = "tb_FileSave";
            this.tb_FileSave.Size = new System.Drawing.Size(645, 27);
            this.tb_FileSave.TabIndex = 1;
            this.tb_FileSave.Click += new System.EventHandler(this.tb_FileSave_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(717, 19);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(131, 37);
            this.btn_Download.TabIndex = 2;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // rtb_FileHTML
            // 
            this.rtb_FileHTML.Location = new System.Drawing.Point(30, 133);
            this.rtb_FileHTML.Name = "rtb_FileHTML";
            this.rtb_FileHTML.Size = new System.Drawing.Size(818, 352);
            this.rtb_FileHTML.TabIndex = 3;
            this.rtb_FileHTML.Text = "";
            // 
            // frm_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 518);
            this.Controls.Add(this.rtb_FileHTML);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.tb_FileSave);
            this.Controls.Add(this.tb_URL);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Bai2";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.TextBox tb_FileSave;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.RichTextBox rtb_FileHTML;
    }
}

