namespace Lab03_Bai04
{
    partial class Client
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
            label7 = new Label();
            label6 = new Label();
            ptb_ketquamonan = new PictureBox();
            tb_quyenhan = new TextBox();
            label5 = new Label();
            btn_xemmon = new Button();
            btn_themmon = new Button();
            tb_linkhinhanh = new TextBox();
            tb_nhaptennguoi = new TextBox();
            tb_nhapmonan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lv_dsmonan = new ListView();
            btn_chonmonrieng = new Button();
            btn_chonmonchung = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_ketquamonan).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(630, 537);
            label7.Name = "label7";
            label7.Size = new Size(211, 32);
            label7.TabIndex = 31;
            label7.Text = "Hình ảnh món ăn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 19);
            label6.Name = "label6";
            label6.Size = new Size(225, 32);
            label6.TabIndex = 30;
            label6.Text = "Danh sách món ăn";
            // 
            // ptb_ketquamonan
            // 
            ptb_ketquamonan.BackColor = Color.White;
            ptb_ketquamonan.BorderStyle = BorderStyle.FixedSingle;
            ptb_ketquamonan.Location = new Point(575, 272);
            ptb_ketquamonan.Name = "ptb_ketquamonan";
            ptb_ketquamonan.Size = new Size(323, 260);
            ptb_ketquamonan.TabIndex = 29;
            ptb_ketquamonan.TabStop = false;
            ptb_ketquamonan.Click += ptb_ketquamonan_Click;
            // 
            // tb_quyenhan
            // 
            tb_quyenhan.Location = new Point(526, 176);
            tb_quyenhan.Margin = new Padding(3, 4, 3, 4);
            tb_quyenhan.Name = "tb_quyenhan";
            tb_quyenhan.Size = new Size(372, 27);
            tb_quyenhan.TabIndex = 28;
            tb_quyenhan.TextChanged += tb_quyenhan_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(320, 169);
            label5.Name = "label5";
            label5.Size = new Size(209, 32);
            label5.TabIndex = 27;
            label5.Text = "Nhập quyền hạn:";
            // 
            // btn_xemmon
            // 
            btn_xemmon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xemmon.ForeColor = Color.Orange;
            btn_xemmon.Location = new Point(320, 340);
            btn_xemmon.Margin = new Padding(3, 4, 3, 4);
            btn_xemmon.Name = "btn_xemmon";
            btn_xemmon.Size = new Size(249, 59);
            btn_xemmon.TabIndex = 25;
            btn_xemmon.Text = "Xem danh sách";
            btn_xemmon.UseVisualStyleBackColor = true;
            btn_xemmon.Click += btn_xemmon_Click;
            // 
            // btn_themmon
            // 
            btn_themmon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_themmon.ForeColor = Color.ForestGreen;
            btn_themmon.Location = new Point(319, 272);
            btn_themmon.Margin = new Padding(3, 4, 3, 4);
            btn_themmon.Name = "btn_themmon";
            btn_themmon.Size = new Size(249, 60);
            btn_themmon.TabIndex = 24;
            btn_themmon.Text = "Thêm món ăn";
            btn_themmon.UseVisualStyleBackColor = true;
            btn_themmon.Click += btn_themmon_Click;
            // 
            // tb_linkhinhanh
            // 
            tb_linkhinhanh.Location = new Point(649, 231);
            tb_linkhinhanh.Margin = new Padding(3, 4, 3, 4);
            tb_linkhinhanh.Name = "tb_linkhinhanh";
            tb_linkhinhanh.Size = new Size(249, 27);
            tb_linkhinhanh.TabIndex = 23;
            tb_linkhinhanh.TextChanged += tb_linkhinhanh_TextChanged;
            // 
            // tb_nhaptennguoi
            // 
            tb_nhaptennguoi.Location = new Point(590, 120);
            tb_nhaptennguoi.Margin = new Padding(3, 4, 3, 4);
            tb_nhaptennguoi.Name = "tb_nhaptennguoi";
            tb_nhaptennguoi.Size = new Size(308, 27);
            tb_nhaptennguoi.TabIndex = 22;
            tb_nhaptennguoi.TextChanged += tb_nhaptennguoi_TextChanged;
            // 
            // tb_nhapmonan
            // 
            tb_nhapmonan.Location = new Point(492, 67);
            tb_nhapmonan.Margin = new Padding(3, 4, 3, 4);
            tb_nhapmonan.Name = "tb_nhapmonan";
            tb_nhapmonan.Size = new Size(406, 27);
            tb_nhapmonan.TabIndex = 21;
            tb_nhapmonan.TextChanged += tb_nhapmonan_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(320, 226);
            label4.Name = "label4";
            label4.Size = new Size(331, 32);
            label4.TabIndex = 20;
            label4.Text = "Nhập link hình ảnh món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 113);
            label3.Name = "label3";
            label3.Size = new Size(276, 32);
            label3.TabIndex = 19;
            label3.Text = "Nhập người đóng góp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(320, 64);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 18;
            label2.Text = "Nhập món ăn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(492, 12);
            label1.Name = "label1";
            label1.Size = new Size(248, 41);
            label1.TabIndex = 17;
            label1.Text = "Hôm Nay Ăn Gì?";
            // 
            // lv_dsmonan
            // 
            lv_dsmonan.Location = new Point(12, 64);
            lv_dsmonan.Margin = new Padding(3, 4, 3, 4);
            lv_dsmonan.Name = "lv_dsmonan";
            lv_dsmonan.Size = new Size(301, 468);
            lv_dsmonan.TabIndex = 16;
            lv_dsmonan.UseCompatibleStateImageBehavior = false;
            lv_dsmonan.SelectedIndexChanged += lv_dsmonan_SelectedIndexChanged;
            // 
            // btn_chonmonrieng
            // 
            btn_chonmonrieng.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chonmonrieng.ForeColor = Color.Red;
            btn_chonmonrieng.Location = new Point(319, 468);
            btn_chonmonrieng.Margin = new Padding(3, 4, 3, 4);
            btn_chonmonrieng.Name = "btn_chonmonrieng";
            btn_chonmonrieng.Size = new Size(249, 64);
            btn_chonmonrieng.TabIndex = 32;
            btn_chonmonrieng.Text = "Chọn riêng";
            btn_chonmonrieng.UseVisualStyleBackColor = true;
            btn_chonmonrieng.Click += btn_chonmonrieng_Click;
            // 
            // btn_chonmonchung
            // 
            btn_chonmonchung.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chonmonchung.ForeColor = Color.Red;
            btn_chonmonchung.Location = new Point(320, 407);
            btn_chonmonchung.Margin = new Padding(3, 4, 3, 4);
            btn_chonmonchung.Name = "btn_chonmonchung";
            btn_chonmonchung.Size = new Size(249, 53);
            btn_chonmonchung.TabIndex = 33;
            btn_chonmonchung.Text = "Chọn chung";
            btn_chonmonchung.UseVisualStyleBackColor = true;
            btn_chonmonchung.Click += btn_chonmonchung_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 578);
            Controls.Add(btn_chonmonchung);
            Controls.Add(btn_chonmonrieng);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ptb_ketquamonan);
            Controls.Add(tb_quyenhan);
            Controls.Add(label5);
            Controls.Add(btn_xemmon);
            Controls.Add(btn_themmon);
            Controls.Add(tb_linkhinhanh);
            Controls.Add(tb_nhaptennguoi);
            Controls.Add(tb_nhapmonan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lv_dsmonan);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_ketquamonan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private PictureBox ptb_ketquamonan;
        private TextBox tb_quyenhan;
        private Label label5;
        private Button btn_xemmon;
        private Button btn_themmon;
        private TextBox tb_linkhinhanh;
        private TextBox tb_nhaptennguoi;
        private TextBox tb_nhapmonan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lv_dsmonan;
        private Button btn_chonmonrieng;
        private Button btn_chonmonchung;
    }
}