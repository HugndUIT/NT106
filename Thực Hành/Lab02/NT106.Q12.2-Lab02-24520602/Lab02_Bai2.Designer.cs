namespace NT106.Q12._2_Lab02_24520602
{
    partial class Lab02_Bai2
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
            rtb_thongtin = new RichTextBox();
            tb_characterscount = new TextBox();
            tb_wordscount = new TextBox();
            tb_linescount = new TextBox();
            tb_size = new TextBox();
            tb_filename = new TextBox();
            btn_thoat = new Button();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_docfile = new Button();
            tb_url = new TextBox();
            SuspendLayout();
            // 
            // rtb_thongtin
            // 
            rtb_thongtin.Location = new Point(450, 16);
            rtb_thongtin.Margin = new Padding(3, 4, 3, 4);
            rtb_thongtin.Name = "rtb_thongtin";
            rtb_thongtin.ReadOnly = true;
            rtb_thongtin.Size = new Size(454, 464);
            rtb_thongtin.TabIndex = 30;
            rtb_thongtin.Text = "";
            // 
            // tb_characterscount
            // 
            tb_characterscount.BackColor = SystemColors.ControlLightLight;
            tb_characterscount.BorderStyle = BorderStyle.FixedSingle;
            tb_characterscount.Location = new Point(194, 373);
            tb_characterscount.Margin = new Padding(3, 4, 3, 4);
            tb_characterscount.Name = "tb_characterscount";
            tb_characterscount.ReadOnly = true;
            tb_characterscount.Size = new Size(249, 27);
            tb_characterscount.TabIndex = 29;
            // 
            // tb_wordscount
            // 
            tb_wordscount.BackColor = SystemColors.ControlLightLight;
            tb_wordscount.BorderStyle = BorderStyle.FixedSingle;
            tb_wordscount.Location = new Point(194, 319);
            tb_wordscount.Margin = new Padding(3, 4, 3, 4);
            tb_wordscount.Name = "tb_wordscount";
            tb_wordscount.ReadOnly = true;
            tb_wordscount.RightToLeft = RightToLeft.No;
            tb_wordscount.Size = new Size(249, 27);
            tb_wordscount.TabIndex = 28;
            // 
            // tb_linescount
            // 
            tb_linescount.BackColor = SystemColors.ControlLightLight;
            tb_linescount.BorderStyle = BorderStyle.FixedSingle;
            tb_linescount.Location = new Point(194, 263);
            tb_linescount.Margin = new Padding(3, 4, 3, 4);
            tb_linescount.Name = "tb_linescount";
            tb_linescount.ReadOnly = true;
            tb_linescount.Size = new Size(249, 27);
            tb_linescount.TabIndex = 27;
            // 
            // tb_size
            // 
            tb_size.BackColor = SystemColors.ControlLightLight;
            tb_size.BorderStyle = BorderStyle.FixedSingle;
            tb_size.Location = new Point(194, 145);
            tb_size.Margin = new Padding(3, 4, 3, 4);
            tb_size.Name = "tb_size";
            tb_size.ReadOnly = true;
            tb_size.Size = new Size(249, 27);
            tb_size.TabIndex = 25;
            // 
            // tb_filename
            // 
            tb_filename.BackColor = SystemColors.ControlLightLight;
            tb_filename.BorderStyle = BorderStyle.FixedSingle;
            tb_filename.Location = new Point(194, 89);
            tb_filename.Margin = new Padding(3, 4, 3, 4);
            tb_filename.Name = "tb_filename";
            tb_filename.ReadOnly = true;
            tb_filename.Size = new Size(249, 27);
            tb_filename.TabIndex = 24;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(14, 412);
            btn_thoat.Margin = new Padding(3, 4, 3, 4);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(430, 69);
            btn_thoat.TabIndex = 23;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 320);
            label5.Name = "label5";
            label5.Size = new Size(142, 26);
            label5.TabIndex = 22;
            label5.Text = "Words count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 374);
            label6.Name = "label6";
            label6.Size = new Size(190, 26);
            label6.TabIndex = 21;
            label6.Text = "Characters count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 260);
            label4.Name = "label4";
            label4.Size = new Size(131, 26);
            label4.TabIndex = 20;
            label4.Text = "Lines count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 203);
            label3.Name = "label3";
            label3.Size = new Size(62, 26);
            label3.TabIndex = 19;
            label3.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 143);
            label2.Name = "label2";
            label2.Size = new Size(58, 26);
            label2.TabIndex = 18;
            label2.Text = "Size ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(14, 89);
            label1.Name = "label1";
            label1.Size = new Size(113, 26);
            label1.TabIndex = 17;
            label1.Text = "File name";
            // 
            // btn_docfile
            // 
            btn_docfile.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_docfile.Location = new Point(14, 16);
            btn_docfile.Margin = new Padding(3, 4, 3, 4);
            btn_docfile.Name = "btn_docfile";
            btn_docfile.Size = new Size(430, 69);
            btn_docfile.TabIndex = 16;
            btn_docfile.Text = "Đọc file";
            btn_docfile.UseVisualStyleBackColor = true;
            btn_docfile.Click += btn_docfile_Click;
            // 
            // tb_url
            // 
            tb_url.BackColor = SystemColors.ControlLightLight;
            tb_url.BorderStyle = BorderStyle.FixedSingle;
            tb_url.Location = new Point(194, 207);
            tb_url.Margin = new Padding(3, 4, 3, 4);
            tb_url.Name = "tb_url";
            tb_url.ReadOnly = true;
            tb_url.Size = new Size(249, 27);
            tb_url.TabIndex = 31;
            // 
            // Lab02_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 489);
            Controls.Add(tb_url);
            Controls.Add(rtb_thongtin);
            Controls.Add(tb_characterscount);
            Controls.Add(tb_wordscount);
            Controls.Add(tb_linescount);
            Controls.Add(tb_size);
            Controls.Add(tb_filename);
            Controls.Add(btn_thoat);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_docfile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab02_Bai2";
            Text = "Bài 02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_thongtin;
        private TextBox tb_characterscount;
        private TextBox tb_wordscount;
        private TextBox tb_linescount;
        private TextBox tb_size;
        private TextBox tb_filename;
        private Button btn_thoat;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_docfile;
        private TextBox tb_url;
    }
}