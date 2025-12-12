namespace Lab01
{
    partial class Form9
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
            label3 = new Label();
            tb_kqmonan = new TextBox();
            btn_timmonan = new Button();
            btn_thoat = new Button();
            btn_xoa = new Button();
            btn_them = new Button();
            tb_danhsach = new TextBox();
            label2 = new Label();
            tb_nhapmonan = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(514, 137);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 50;
            label3.Text = "Món ăn hôm nay là:";
            // 
            // tb_kqmonan
            // 
            tb_kqmonan.Location = new Point(514, 175);
            tb_kqmonan.Name = "tb_kqmonan";
            tb_kqmonan.ReadOnly = true;
            tb_kqmonan.Size = new Size(274, 27);
            tb_kqmonan.TabIndex = 49;
            tb_kqmonan.TextChanged += tb_kqmonan_TextChanged;
            // 
            // btn_timmonan
            // 
            btn_timmonan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_timmonan.Location = new Point(514, 76);
            btn_timmonan.Name = "btn_timmonan";
            btn_timmonan.Size = new Size(274, 57);
            btn_timmonan.TabIndex = 48;
            btn_timmonan.Text = "Tìm món ăn";
            btn_timmonan.UseVisualStyleBackColor = true;
            btn_timmonan.Click += btn_timmonan_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_thoat.Location = new Point(12, 329);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(154, 63);
            btn_thoat.TabIndex = 47;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_xoa.Location = new Point(12, 234);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(154, 64);
            btn_xoa.TabIndex = 46;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_them.Location = new Point(12, 139);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(154, 63);
            btn_them.TabIndex = 45;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // tb_danhsach
            // 
            tb_danhsach.BorderStyle = BorderStyle.FixedSingle;
            tb_danhsach.Location = new Point(186, 77);
            tb_danhsach.Multiline = true;
            tb_danhsach.Name = "tb_danhsach";
            tb_danhsach.ReadOnly = true;
            tb_danhsach.ScrollBars = ScrollBars.Vertical;
            tb_danhsach.Size = new Size(295, 357);
            tb_danhsach.TabIndex = 44;
            tb_danhsach.TextChanged += tb_danhsach_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 43;
            label2.Text = "Danh sách món";
            // 
            // tb_nhapmonan
            // 
            tb_nhapmonan.Location = new Point(186, 17);
            tb_nhapmonan.Name = "tb_nhapmonan";
            tb_nhapmonan.Size = new Size(295, 27);
            tb_nhapmonan.TabIndex = 42;
            tb_nhapmonan.TextChanged += tb_nhapmonan_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 41;
            label1.Text = "Nhập món ăn";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(tb_kqmonan);
            Controls.Add(btn_timmonan);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(tb_danhsach);
            Controls.Add(label2);
            Controls.Add(tb_nhapmonan);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Bài 9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox tb_kqmonan;
        private Button btn_timmonan;
        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_them;
        private TextBox tb_danhsach;
        private Label label2;
        private TextBox tb_nhapmonan;
        private Label label1;
    }
}