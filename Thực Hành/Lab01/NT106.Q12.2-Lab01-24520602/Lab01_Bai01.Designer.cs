namespace Lab01
{
    partial class Form1
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
            btn_thoat = new Button();
            btn_tinhtoan = new Button();
            tb_ketqua = new TextBox();
            tb_nhapsothuhai = new TextBox();
            tb_nhapsothunhat = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(359, 358);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(144, 54);
            btn_thoat.TabIndex = 17;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_tinhtoan
            // 
            btn_tinhtoan.Location = new Point(116, 358);
            btn_tinhtoan.Name = "btn_tinhtoan";
            btn_tinhtoan.Size = new Size(144, 54);
            btn_tinhtoan.TabIndex = 16;
            btn_tinhtoan.Text = "Tính Toán";
            btn_tinhtoan.UseVisualStyleBackColor = true;
            btn_tinhtoan.Click += btn_tinhtoan_Click;
            // 
            // tb_ketqua
            // 
            tb_ketqua.Location = new Point(359, 289);
            tb_ketqua.Name = "tb_ketqua";
            tb_ketqua.ReadOnly = true;
            tb_ketqua.Size = new Size(326, 27);
            tb_ketqua.TabIndex = 15;
            tb_ketqua.TextChanged += tb_ketqua_TextChanged;
            // 
            // tb_nhapsothuhai
            // 
            tb_nhapsothuhai.Location = new Point(359, 205);
            tb_nhapsothuhai.Name = "tb_nhapsothuhai";
            tb_nhapsothuhai.Size = new Size(326, 27);
            tb_nhapsothuhai.TabIndex = 14;
            tb_nhapsothuhai.TextChanged += tb_nhapsothuhai_TextChanged;
            // 
            // tb_nhapsothunhat
            // 
            tb_nhapsothunhat.Location = new Point(359, 125);
            tb_nhapsothunhat.Name = "tb_nhapsothunhat";
            tb_nhapsothunhat.Size = new Size(326, 27);
            tb_nhapsothunhat.TabIndex = 13;
            tb_nhapsothunhat.TextChanged += tb_nhapsothunhat_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(116, 289);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 12;
            label4.Text = "KẾT QUẢ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(116, 205);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 11;
            label3.Text = "NHẬP SỐ THỨ 2";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(116, 125);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 10;
            label2.Text = "NHẬP SỐ THỨ 1";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(116, 38);
            label1.Name = "label1";
            label1.Size = new Size(569, 54);
            label1.TabIndex = 9;
            label1.Text = "TÍNH TỔNG HAI SỐ NGUYÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_tinhtoan);
            Controls.Add(tb_ketqua);
            Controls.Add(tb_nhapsothuhai);
            Controls.Add(tb_nhapsothunhat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_thoat;
        private Button btn_tinhtoan;
        private TextBox tb_ketqua;
        private TextBox tb_nhapsothuhai;
        private TextBox tb_nhapsothunhat;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
