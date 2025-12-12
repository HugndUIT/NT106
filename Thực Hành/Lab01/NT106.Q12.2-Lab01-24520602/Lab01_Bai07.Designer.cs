namespace Lab01
{
    partial class Form7
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
            tb_ketqua = new TextBox();
            btn_thoat = new Button();
            btn_xoa = new Button();
            btn_tim = new Button();
            label4 = new Label();
            tb_nhapthangsinh = new TextBox();
            tb_nhapngaysinh = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_ketqua
            // 
            tb_ketqua.Location = new Point(218, 215);
            tb_ketqua.Name = "tb_ketqua";
            tb_ketqua.ReadOnly = true;
            tb_ketqua.Size = new Size(191, 27);
            tb_ketqua.TabIndex = 42;
            tb_ketqua.TextChanged += tb_ketqua_TextChanged;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_thoat.Location = new Point(447, 213);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(145, 40);
            btn_thoat.TabIndex = 41;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_xoa.Location = new Point(447, 148);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(145, 40);
            btn_xoa.TabIndex = 40;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_tim
            // 
            btn_tim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_tim.Location = new Point(447, 84);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(145, 40);
            btn_tim.TabIndex = 39;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(13, 211);
            label4.Name = "label4";
            label4.Size = new Size(96, 31);
            label4.TabIndex = 38;
            label4.Text = "Kết quả";
            // 
            // tb_nhapthangsinh
            // 
            tb_nhapthangsinh.Location = new Point(218, 155);
            tb_nhapthangsinh.Name = "tb_nhapthangsinh";
            tb_nhapthangsinh.Size = new Size(191, 27);
            tb_nhapthangsinh.TabIndex = 37;
            tb_nhapthangsinh.TextChanged += tb_nhapthangsinh_TextChanged;
            // 
            // tb_nhapngaysinh
            // 
            tb_nhapngaysinh.Location = new Point(218, 91);
            tb_nhapngaysinh.Name = "tb_nhapngaysinh";
            tb_nhapngaysinh.Size = new Size(191, 27);
            tb_nhapngaysinh.TabIndex = 36;
            tb_nhapngaysinh.TextChanged += tb_nhapngaysinh_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(13, 151);
            label3.Name = "label3";
            label3.Size = new Size(192, 31);
            label3.TabIndex = 35;
            label3.Text = "Nhập tháng sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(13, 87);
            label2.Name = "label2";
            label2.Size = new Size(181, 31);
            label2.TabIndex = 34;
            label2.Text = "Nhập ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 41);
            label1.TabIndex = 33;
            label1.Text = "CUNG HOÀNG ĐẠO";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 266);
            Controls.Add(tb_ketqua);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tim);
            Controls.Add(label4);
            Controls.Add(tb_nhapthangsinh);
            Controls.Add(tb_nhapngaysinh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Bài 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ketqua;
        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_tim;
        private Label label4;
        private TextBox tb_nhapthangsinh;
        private TextBox tb_nhapngaysinh;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}