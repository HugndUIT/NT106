namespace NT106.Q12._2_Lab02_24520602
{
    partial class Lab02_Bai6
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
            lv_dsmonan = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_nhapmonan = new TextBox();
            tb_nhaptennguoi = new TextBox();
            tb_linkhinhanh = new TextBox();
            btn_themmon = new Button();
            btn_xemmon = new Button();
            btn_chonmon = new Button();
            tb_quyenhan = new TextBox();
            label5 = new Label();
            ptb_ketquamonan = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptb_ketquamonan).BeginInit();
            SuspendLayout();
            // 
            // lv_dsmonan
            // 
            lv_dsmonan.Location = new Point(14, 68);
            lv_dsmonan.Margin = new Padding(3, 4, 3, 4);
            lv_dsmonan.Name = "lv_dsmonan";
            lv_dsmonan.Size = new Size(301, 468);
            lv_dsmonan.TabIndex = 0;
            lv_dsmonan.UseCompatibleStateImageBehavior = false;
            lv_dsmonan.SelectedIndexChanged += lv_dsmonan_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 16);
            label1.Name = "label1";
            label1.Size = new Size(248, 41);
            label1.TabIndex = 1;
            label1.Text = "Hôm Nay Ăn Gì?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 68);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 2;
            label2.Text = "Nhập món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(322, 117);
            label3.Name = "label3";
            label3.Size = new Size(276, 32);
            label3.TabIndex = 3;
            label3.Text = "Nhập người đóng góp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(322, 230);
            label4.Name = "label4";
            label4.Size = new Size(331, 32);
            label4.TabIndex = 4;
            label4.Text = "Nhập link hình ảnh món ăn:";
            // 
            // tb_nhapmonan
            // 
            tb_nhapmonan.Location = new Point(494, 71);
            tb_nhapmonan.Margin = new Padding(3, 4, 3, 4);
            tb_nhapmonan.Name = "tb_nhapmonan";
            tb_nhapmonan.Size = new Size(406, 27);
            tb_nhapmonan.TabIndex = 5;
            tb_nhapmonan.TextChanged += tb_nhapmonan_TextChanged;
            // 
            // tb_nhaptennguoi
            // 
            tb_nhaptennguoi.Location = new Point(592, 124);
            tb_nhaptennguoi.Margin = new Padding(3, 4, 3, 4);
            tb_nhaptennguoi.Name = "tb_nhaptennguoi";
            tb_nhaptennguoi.Size = new Size(308, 27);
            tb_nhaptennguoi.TabIndex = 6;
            tb_nhaptennguoi.TextChanged += tb_nhaptennguoi_TextChanged;
            // 
            // tb_linkhinhanh
            // 
            tb_linkhinhanh.Location = new Point(651, 235);
            tb_linkhinhanh.Margin = new Padding(3, 4, 3, 4);
            tb_linkhinhanh.Name = "tb_linkhinhanh";
            tb_linkhinhanh.Size = new Size(249, 27);
            tb_linkhinhanh.TabIndex = 7;
            tb_linkhinhanh.TextChanged += tb_linkhinhanh_TextChanged;
            // 
            // btn_themmon
            // 
            btn_themmon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_themmon.ForeColor = Color.ForestGreen;
            btn_themmon.Location = new Point(321, 276);
            btn_themmon.Margin = new Padding(3, 4, 3, 4);
            btn_themmon.Name = "btn_themmon";
            btn_themmon.Size = new Size(249, 79);
            btn_themmon.TabIndex = 8;
            btn_themmon.Text = "Thêm món ăn";
            btn_themmon.UseVisualStyleBackColor = true;
            btn_themmon.Click += btn_themmon_Click;
            // 
            // btn_xemmon
            // 
            btn_xemmon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xemmon.ForeColor = Color.Orange;
            btn_xemmon.Location = new Point(321, 363);
            btn_xemmon.Margin = new Padding(3, 4, 3, 4);
            btn_xemmon.Name = "btn_xemmon";
            btn_xemmon.Size = new Size(249, 85);
            btn_xemmon.TabIndex = 9;
            btn_xemmon.Text = "Xem danh sách";
            btn_xemmon.UseVisualStyleBackColor = true;
            btn_xemmon.Click += btn_xemmon_Click;
            // 
            // btn_chonmon
            // 
            btn_chonmon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chonmon.ForeColor = Color.Red;
            btn_chonmon.Location = new Point(322, 456);
            btn_chonmon.Margin = new Padding(3, 4, 3, 4);
            btn_chonmon.Name = "btn_chonmon";
            btn_chonmon.Size = new Size(249, 80);
            btn_chonmon.TabIndex = 10;
            btn_chonmon.Text = "Chọn món ăn";
            btn_chonmon.UseVisualStyleBackColor = true;
            btn_chonmon.Click += btn_chonmon_Click;
            // 
            // tb_quyenhan
            // 
            tb_quyenhan.Location = new Point(528, 180);
            tb_quyenhan.Margin = new Padding(3, 4, 3, 4);
            tb_quyenhan.Name = "tb_quyenhan";
            tb_quyenhan.Size = new Size(372, 27);
            tb_quyenhan.TabIndex = 12;
            tb_quyenhan.TextChanged += tb_quyenhan_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(322, 173);
            label5.Name = "label5";
            label5.Size = new Size(209, 32);
            label5.TabIndex = 11;
            label5.Text = "Nhập quyền hạn:";
            // 
            // ptb_ketquamonan
            // 
            ptb_ketquamonan.BackColor = Color.White;
            ptb_ketquamonan.BorderStyle = BorderStyle.FixedSingle;
            ptb_ketquamonan.Location = new Point(577, 276);
            ptb_ketquamonan.Name = "ptb_ketquamonan";
            ptb_ketquamonan.Size = new Size(323, 260);
            ptb_ketquamonan.TabIndex = 13;
            ptb_ketquamonan.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 23);
            label6.Name = "label6";
            label6.Size = new Size(225, 32);
            label6.TabIndex = 14;
            label6.Text = "Danh sách món ăn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(631, 535);
            label7.Name = "label7";
            label7.Size = new Size(211, 32);
            label7.TabIndex = 15;
            label7.Text = "Hình ảnh món ăn";
            // 
            // Lab02_Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(914, 576);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ptb_ketquamonan);
            Controls.Add(tb_quyenhan);
            Controls.Add(label5);
            Controls.Add(btn_chonmon);
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
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab02_Bai6";
            Text = "Bài 06";
            Load += Lab02_Bai6_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_ketquamonan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_dsmonan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_nhapmonan;
        private TextBox tb_nhaptennguoi;
        private TextBox tb_linkhinhanh;
        private Button btn_themmon;
        private Button btn_xemmon;
        private Button btn_chonmon;
        private TextBox tb_quyenhan;
        private Label label5;
        private PictureBox ptb_ketquamonan;
        private Label label6;
        private Label label7;
    }
}