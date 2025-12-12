namespace Bai7
{
    partial class frm_AnGi
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
            this.p_MonAn = new System.Windows.Forms.Panel();
            this.lbl_NguoiDongGop = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.lbl_TenMon = new System.Windows.Forms.Label();
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.p_MonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // p_MonAn
            // 
            this.p_MonAn.Controls.Add(this.lbl_NguoiDongGop);
            this.p_MonAn.Controls.Add(this.lbl_DiaChi);
            this.p_MonAn.Controls.Add(this.lbl_Gia);
            this.p_MonAn.Controls.Add(this.lbl_TenMon);
            this.p_MonAn.Controls.Add(this.ptb_HinhAnh);
            this.p_MonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_MonAn.Location = new System.Drawing.Point(0, 0);
            this.p_MonAn.Margin = new System.Windows.Forms.Padding(2);
            this.p_MonAn.Name = "p_MonAn";
            this.p_MonAn.Size = new System.Drawing.Size(507, 162);
            this.p_MonAn.TabIndex = 0;
            // 
            // lbl_NguoiDongGop
            // 
            this.lbl_NguoiDongGop.AutoSize = true;
            this.lbl_NguoiDongGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NguoiDongGop.Location = new System.Drawing.Point(168, 117);
            this.lbl_NguoiDongGop.Name = "lbl_NguoiDongGop";
            this.lbl_NguoiDongGop.Size = new System.Drawing.Size(51, 20);
            this.lbl_NguoiDongGop.TabIndex = 5;
            this.lbl_NguoiDongGop.Text = "label3";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(168, 87);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(51, 20);
            this.lbl_DiaChi.TabIndex = 4;
            this.lbl_DiaChi.Text = "label2";
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gia.Location = new System.Drawing.Point(168, 54);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(51, 20);
            this.lbl_Gia.TabIndex = 3;
            this.lbl_Gia.Text = "label1";
            // 
            // lbl_TenMon
            // 
            this.lbl_TenMon.AutoSize = true;
            this.lbl_TenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenMon.Location = new System.Drawing.Point(166, 12);
            this.lbl_TenMon.Name = "lbl_TenMon";
            this.lbl_TenMon.Size = new System.Drawing.Size(76, 26);
            this.lbl_TenMon.TabIndex = 2;
            this.lbl_TenMon.Text = "label1";
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.Location = new System.Drawing.Point(12, 12);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(135, 138);
            this.ptb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_HinhAnh.TabIndex = 1;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // frm_AnGi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 162);
            this.Controls.Add(this.p_MonAn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_AnGi";
            this.Text = "Ăn [món ăn] đi!";
            this.p_MonAn.ResumeLayout(false);
            this.p_MonAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_MonAn;
        private System.Windows.Forms.Label lbl_NguoiDongGop;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.Label lbl_TenMon;
        private System.Windows.Forms.PictureBox ptb_HinhAnh;
    }
}