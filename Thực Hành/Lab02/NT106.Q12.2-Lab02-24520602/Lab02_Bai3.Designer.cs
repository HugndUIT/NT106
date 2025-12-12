namespace NT106.Q12._2_Lab02_24520602
{
    partial class Lab02_Bai3
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
            btn_docfile = new Button();
            btn_luufile = new Button();
            btn_tinhtoan = new Button();
            rtb_noidung = new RichTextBox();
            SuspendLayout();
            // 
            // btn_docfile
            // 
            btn_docfile.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_docfile.Location = new Point(14, 16);
            btn_docfile.Margin = new Padding(3, 4, 3, 4);
            btn_docfile.Name = "btn_docfile";
            btn_docfile.Size = new Size(131, 73);
            btn_docfile.TabIndex = 0;
            btn_docfile.Text = "Đọc file";
            btn_docfile.UseVisualStyleBackColor = true;
            btn_docfile.Click += btn_docfile_Click;
            // 
            // btn_luufile
            // 
            btn_luufile.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_luufile.Location = new Point(315, 16);
            btn_luufile.Margin = new Padding(3, 4, 3, 4);
            btn_luufile.Name = "btn_luufile";
            btn_luufile.Size = new Size(131, 73);
            btn_luufile.TabIndex = 1;
            btn_luufile.Text = "Lưu file";
            btn_luufile.UseVisualStyleBackColor = true;
            btn_luufile.Click += btn_luufile_Click;
            // 
            // btn_tinhtoan
            // 
            btn_tinhtoan.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tinhtoan.Location = new Point(152, 16);
            btn_tinhtoan.Margin = new Padding(3, 4, 3, 4);
            btn_tinhtoan.Name = "btn_tinhtoan";
            btn_tinhtoan.Size = new Size(157, 73);
            btn_tinhtoan.TabIndex = 2;
            btn_tinhtoan.Text = "Tính toán";
            btn_tinhtoan.UseVisualStyleBackColor = true;
            btn_tinhtoan.Click += btn_tinhtoan_Click;
            // 
            // rtb_noidung
            // 
            rtb_noidung.BorderStyle = BorderStyle.FixedSingle;
            rtb_noidung.Location = new Point(14, 97);
            rtb_noidung.Margin = new Padding(3, 4, 3, 4);
            rtb_noidung.Name = "rtb_noidung";
            rtb_noidung.Size = new Size(432, 492);
            rtb_noidung.TabIndex = 3;
            rtb_noidung.Text = "";
            rtb_noidung.TextChanged += rtb_noidung_TextChanged;
            // 
            // Lab02_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 600);
            Controls.Add(rtb_noidung);
            Controls.Add(btn_tinhtoan);
            Controls.Add(btn_luufile);
            Controls.Add(btn_docfile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab02_Bai3";
            Text = "Bài 03";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_docfile;
        private Button btn_luufile;
        private Button btn_tinhtoan;
        private RichTextBox rtb_noidung;
    }
}