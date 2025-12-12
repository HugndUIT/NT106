namespace Lab01
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_tenkhachhang = new TextBox();
            cb_chonphim = new ComboBox();
            cb_chonphong = new ComboBox();
            label5 = new Label();
            clb_chonghe = new CheckedListBox();
            btn_datve = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            label6 = new Label();
            tb_thongtinve = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 41);
            label1.TabIndex = 0;
            label1.Text = "Đặt vé xem phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.Location = new Point(5, 64);
            label2.Name = "label2";
            label2.Size = new Size(173, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(5, 105);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 2;
            label3.Text = "Chọn phim: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.Location = new Point(5, 149);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 3;
            label4.Text = "Chọn phòng chiếu: ";
            // 
            // tb_tenkhachhang
            // 
            tb_tenkhachhang.Location = new Point(204, 65);
            tb_tenkhachhang.Name = "tb_tenkhachhang";
            tb_tenkhachhang.Size = new Size(279, 27);
            tb_tenkhachhang.TabIndex = 4;
            tb_tenkhachhang.TextChanged += tb_tenkhachhang_TextChanged;
            // 
            // cb_chonphim
            // 
            cb_chonphim.FormattingEnabled = true;
            cb_chonphim.Location = new Point(204, 105);
            cb_chonphim.Name = "cb_chonphim";
            cb_chonphim.Size = new Size(279, 28);
            cb_chonphim.TabIndex = 5;
            cb_chonphim.SelectedIndexChanged += cb_chonphim_SelectedIndexChanged;
            // 
            // cb_chonphong
            // 
            cb_chonphong.FormattingEnabled = true;
            cb_chonphong.Location = new Point(204, 149);
            cb_chonphong.Name = "cb_chonphong";
            cb_chonphong.Size = new Size(279, 28);
            cb_chonphong.TabIndex = 6;
            cb_chonphong.SelectedIndexChanged += cb_chonphong_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label5.Location = new Point(479, 59);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 7;
            label5.Text = "Chọn ghế: ";
            label5.Click += label5_Click;
            // 
            // clb_chonghe
            // 
            clb_chonghe.FormattingEnabled = true;
            clb_chonghe.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            clb_chonghe.Location = new Point(489, 90);
            clb_chonghe.Name = "clb_chonghe";
            clb_chonghe.Size = new Size(86, 334);
            clb_chonghe.TabIndex = 8;
            clb_chonghe.SelectedIndexChanged += clb_chonghe_SelectedIndexChanged;
            // 
            // btn_datve
            // 
            btn_datve.Location = new Point(5, 188);
            btn_datve.Name = "btn_datve";
            btn_datve.Size = new Size(193, 46);
            btn_datve.TabIndex = 9;
            btn_datve.Text = "Đặt vé";
            btn_datve.UseVisualStyleBackColor = true;
            btn_datve.Click += btn_datve_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(204, 188);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(136, 46);
            btn_xoa.TabIndex = 10;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(346, 188);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(137, 46);
            btn_thoat.TabIndex = 11;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.Location = new Point(5, 233);
            label6.Name = "label6";
            label6.Size = new Size(142, 28);
            label6.TabIndex = 12;
            label6.Text = "Thông tin vé: ";
            label6.Click += label6_Click;
            // 
            // tb_thongtinve
            // 
            tb_thongtinve.BorderStyle = BorderStyle.FixedSingle;
            tb_thongtinve.Location = new Point(5, 264);
            tb_thongtinve.Multiline = true;
            tb_thongtinve.Name = "tb_thongtinve";
            tb_thongtinve.ReadOnly = true;
            tb_thongtinve.Size = new Size(478, 160);
            tb_thongtinve.TabIndex = 13;
            tb_thongtinve.TextChanged += tb_thongtinve_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.Location = new Point(5, 427);
            label7.Name = "label7";
            label7.Size = new Size(317, 115);
            label7.TabIndex = 14;
            label7.Text = "Lưu ý:\r\nVé thường: Ghế A2, A3, A4, C2, C3, C4\r\nVé VIP: Ghế B2, B3, B4\r\nVé vớt: Ghế A1, A5, C1, C5\r\nGhế đã tích là ghế đã được đặt";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 553);
            Controls.Add(label7);
            Controls.Add(tb_thongtinve);
            Controls.Add(label6);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_datve);
            Controls.Add(clb_chonghe);
            Controls.Add(label5);
            Controls.Add(cb_chonphong);
            Controls.Add(cb_chonphim);
            Controls.Add(tb_tenkhachhang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Bài 5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_tenkhachhang;
        private ComboBox cb_chonphim;
        private ComboBox cb_chonphong;
        private Label label5;
        private CheckedListBox clb_chonghe;
        private Button btn_datve;
        private Button btn_xoa;
        private Button btn_thoat;
        private Label label6;
        private TextBox tb_thongtinve;
        private Label label7;
    }
}