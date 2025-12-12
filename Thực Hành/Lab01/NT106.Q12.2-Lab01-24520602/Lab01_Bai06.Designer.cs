namespace Lab01
{
    partial class Form6
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
            label6 = new Label();
            tb_ketqua = new TextBox();
            label5 = new Label();
            btn_thoat = new Button();
            btn_xoa = new Button();
            btn_tinh = new Button();
            label4 = new Label();
            cbb_choncachtinh = new ComboBox();
            tb_nhapsoB = new TextBox();
            tb_nhapsoA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(194, 466);
            label6.Name = "label6";
            label6.Size = new Size(333, 77);
            label6.TabIndex = 38;
            label6.Text = "Lưu ý: \r\n- Muốn tính giai thừa hãy nhập A > B\r\n- Muốn tính tổng S hãy nhập B > 0\r\n";
            // 
            // tb_ketqua
            // 
            tb_ketqua.BorderStyle = BorderStyle.FixedSingle;
            tb_ketqua.Location = new Point(194, 249);
            tb_ketqua.Multiline = true;
            tb_ketqua.Name = "tb_ketqua";
            tb_ketqua.ReadOnly = true;
            tb_ketqua.ScrollBars = ScrollBars.Vertical;
            tb_ketqua.Size = new Size(374, 214);
            tb_ketqua.TabIndex = 37;
            tb_ketqua.TextChanged += tb_ketqua_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(7, 243);
            label5.Name = "label5";
            label5.Size = new Size(96, 31);
            label5.TabIndex = 36;
            label5.Text = "Kết quả";
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_thoat.Location = new Point(423, 183);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(145, 40);
            btn_thoat.TabIndex = 35;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_xoa.Location = new Point(423, 118);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(145, 40);
            btn_xoa.TabIndex = 34;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_tinh
            // 
            btn_tinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_tinh.Location = new Point(423, 54);
            btn_tinh.Name = "btn_tinh";
            btn_tinh.Size = new Size(145, 40);
            btn_tinh.TabIndex = 33;
            btn_tinh.Text = "Tính";
            btn_tinh.UseVisualStyleBackColor = true;
            btn_tinh.Click += btn_tinh_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(7, 181);
            label4.Name = "label4";
            label4.Size = new Size(174, 31);
            label4.TabIndex = 32;
            label4.Text = "Chọn cách tính";
            // 
            // cbb_choncachtinh
            // 
            cbb_choncachtinh.FormattingEnabled = true;
            cbb_choncachtinh.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cbb_choncachtinh.Location = new Point(194, 187);
            cbb_choncachtinh.Name = "cbb_choncachtinh";
            cbb_choncachtinh.Size = new Size(191, 28);
            cbb_choncachtinh.TabIndex = 31;
            cbb_choncachtinh.SelectedIndexChanged += cbb_choncachtinh_SelectedIndexChanged;
            // 
            // tb_nhapsoB
            // 
            tb_nhapsoB.Location = new Point(194, 125);
            tb_nhapsoB.Name = "tb_nhapsoB";
            tb_nhapsoB.Size = new Size(191, 27);
            tb_nhapsoB.TabIndex = 30;
            tb_nhapsoB.TextChanged += tb_nhapsoB_TextChanged;
            // 
            // tb_nhapsoA
            // 
            tb_nhapsoA.Location = new Point(194, 61);
            tb_nhapsoA.Name = "tb_nhapsoA";
            tb_nhapsoA.Size = new Size(191, 27);
            tb_nhapsoA.TabIndex = 29;
            tb_nhapsoA.TextChanged += tb_nhapsoA_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(7, 119);
            label3.Name = "label3";
            label3.Size = new Size(123, 31);
            label3.TabIndex = 28;
            label3.Text = "Nhập số B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 27;
            label2.Text = "Nhập số A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(194, 7);
            label1.Name = "label1";
            label1.Size = new Size(191, 38);
            label1.TabIndex = 26;
            label1.Text = "CALCULATOR";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 555);
            Controls.Add(label6);
            Controls.Add(tb_ketqua);
            Controls.Add(label5);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tinh);
            Controls.Add(label4);
            Controls.Add(cbb_choncachtinh);
            Controls.Add(tb_nhapsoB);
            Controls.Add(tb_nhapsoA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Bài 6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox tb_ketqua;
        private Label label5;
        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_tinh;
        private Label label4;
        private ComboBox cbb_choncachtinh;
        private TextBox tb_nhapsoB;
        private TextBox tb_nhapsoA;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}