namespace NT106.Q12._2_Lab02_24520602
{
    partial class Lab02_Bai1
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
            btn_docfile = new Button();
            btn_ghifile = new Button();
            rtb_thongtin = new RichTextBox();
            SuspendLayout();
            // 
            // btn_docfile
            // 
            btn_docfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_docfile.Location = new Point(22, 19);
            btn_docfile.Name = "btn_docfile";
            btn_docfile.Size = new Size(212, 67);
            btn_docfile.TabIndex = 0;
            btn_docfile.Text = "ĐỌC FILE";
            btn_docfile.UseVisualStyleBackColor = true;
            btn_docfile.Click += btn_docfile_Click;
            // 
            // btn_ghifile
            // 
            btn_ghifile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ghifile.Location = new Point(22, 107);
            btn_ghifile.Name = "btn_ghifile";
            btn_ghifile.Size = new Size(212, 67);
            btn_ghifile.TabIndex = 1;
            btn_ghifile.Text = "GHI FILE";
            btn_ghifile.UseVisualStyleBackColor = true;
            btn_ghifile.Click += btn_ghifile_Click;
            // 
            // rtb_thongtin
            // 
            rtb_thongtin.Location = new Point(240, 19);
            rtb_thongtin.Name = "rtb_thongtin";
            rtb_thongtin.Size = new Size(389, 154);
            rtb_thongtin.TabIndex = 2;
            rtb_thongtin.Text = "";
            rtb_thongtin.TextChanged += rtb_thongtin_TextChanged;
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 185);
            Controls.Add(rtb_thongtin);
            Controls.Add(btn_ghifile);
            Controls.Add(btn_docfile);
            Name = "Lab02_Bai01";
            Text = "Bài 01";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_docfile;
        private Button btn_ghifile;
        private RichTextBox rtb_thongtin;
    }
}
