namespace Bai7
{
    partial class FoodItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_DongGop = new System.Windows.Forms.Label();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_DongGop = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_HinhAnh.Location = new System.Drawing.Point(9, 9);
            this.ptb_HinhAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(111, 110);
            this.ptb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_HinhAnh.TabIndex = 0;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Ten.Location = new System.Drawing.Point(129, 9);
            this.lbl_Ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(125, 25);
            this.lbl_Ten.TabIndex = 1;
            this.lbl_Ten.Text = "Tên món ăn";
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Location = new System.Drawing.Point(139, 44);
            this.lbl_Gia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(26, 13);
            this.lbl_Gia.TabIndex = 2;
            this.lbl_Gia.Text = "Giá:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(139, 70);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(43, 13);
            this.lbl_DiaChi.TabIndex = 3;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_DongGop
            // 
            this.lbl_DongGop.AutoSize = true;
            this.lbl_DongGop.Location = new System.Drawing.Point(139, 95);
            this.lbl_DongGop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DongGop.Name = "lbl_DongGop";
            this.lbl_DongGop.Size = new System.Drawing.Size(57, 13);
            this.lbl_DongGop.TabIndex = 4;
            this.lbl_DongGop.Text = "Đóng góp:";
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(204, 40);
            this.tb_Gia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.ReadOnly = true;
            this.tb_Gia.Size = new System.Drawing.Size(129, 20);
            this.tb_Gia.TabIndex = 5;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(204, 68);
            this.tb_DiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.ReadOnly = true;
            this.tb_DiaChi.Size = new System.Drawing.Size(129, 20);
            this.tb_DiaChi.TabIndex = 6;
            // 
            // tb_DongGop
            // 
            this.tb_DongGop.Location = new System.Drawing.Point(204, 93);
            this.tb_DongGop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_DongGop.Name = "tb_DongGop";
            this.tb_DongGop.ReadOnly = true;
            this.tb_DongGop.Size = new System.Drawing.Size(129, 20);
            this.tb_DongGop.TabIndex = 7;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(259, 9);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FoodItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.tb_DongGop);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.lbl_DongGop);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_Gia);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FoodItemControl";
            this.Size = new System.Drawing.Size(366, 123);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_HinhAnh;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_DongGop;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_DongGop;
        private System.Windows.Forms.Button btn_Xoa;
    }
}
