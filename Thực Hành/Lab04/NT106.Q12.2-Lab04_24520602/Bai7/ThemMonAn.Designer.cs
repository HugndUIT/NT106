namespace Bai7
{
    partial class ThemMonAn
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_TenMA = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_HinhAnh = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.tb_TenMonAn = new System.Windows.Forms.TextBox();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_HinhAnh = new System.Windows.Forms.TextBox();
            this.rtb_MoTa = new System.Windows.Forms.RichTextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(627, 136);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "THÊM MÓN ĂN";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TenMA
            // 
            this.lbl_TenMA.AutoSize = true;
            this.lbl_TenMA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenMA.Location = new System.Drawing.Point(49, 150);
            this.lbl_TenMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenMA.Name = "lbl_TenMA";
            this.lbl_TenMA.Size = new System.Drawing.Size(83, 19);
            this.lbl_TenMA.TabIndex = 1;
            this.lbl_TenMA.Text = "Tên món ăn:";
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gia.Location = new System.Drawing.Point(49, 200);
            this.lbl_Gia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(33, 19);
            this.lbl_Gia.TabIndex = 2;
            this.lbl_Gia.Text = "Giá:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(49, 250);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(54, 19);
            this.lbl_DiaChi.TabIndex = 3;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_HinhAnh
            // 
            this.lbl_HinhAnh.AutoSize = true;
            this.lbl_HinhAnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HinhAnh.Location = new System.Drawing.Point(49, 300);
            this.lbl_HinhAnh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HinhAnh.Name = "lbl_HinhAnh";
            this.lbl_HinhAnh.Size = new System.Drawing.Size(65, 19);
            this.lbl_HinhAnh.TabIndex = 4;
            this.lbl_HinhAnh.Text = "Hình ảnh:";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(49, 350);
            this.lbl_MoTa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(49, 19);
            this.lbl_MoTa.TabIndex = 5;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // tb_TenMonAn
            // 
            this.tb_TenMonAn.Location = new System.Drawing.Point(201, 147);
            this.tb_TenMonAn.Name = "tb_TenMonAn";
            this.tb_TenMonAn.Size = new System.Drawing.Size(360, 23);
            this.tb_TenMonAn.TabIndex = 6;
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(201, 197);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(360, 23);
            this.tb_Gia.TabIndex = 7;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(201, 247);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(360, 23);
            this.tb_DiaChi.TabIndex = 8;
            // 
            // tb_HinhAnh
            // 
            this.tb_HinhAnh.Location = new System.Drawing.Point(201, 297);
            this.tb_HinhAnh.Name = "tb_HinhAnh";
            this.tb_HinhAnh.Size = new System.Drawing.Size(360, 23);
            this.tb_HinhAnh.TabIndex = 9;
            // 
            // rtb_MoTa
            // 
            this.rtb_MoTa.Location = new System.Drawing.Point(201, 351);
            this.rtb_MoTa.Name = "rtb_MoTa";
            this.rtb_MoTa.Size = new System.Drawing.Size(360, 210);
            this.rtb_MoTa.TabIndex = 10;
            this.rtb_MoTa.Text = "";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(353, 567);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(101, 35);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(460, 567);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 35);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(627, 609);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.rtb_MoTa);
            this.Controls.Add(this.tb_HinhAnh);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.tb_TenMonAn);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.lbl_HinhAnh);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_Gia);
            this.Controls.Add(this.lbl_TenMA);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ThemMonAn";
            this.Text = "ThemMonAn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_TenMA;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_HinhAnh;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.TextBox tb_TenMonAn;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_HinhAnh;
        private System.Windows.Forms.RichTextBox rtb_MoTa;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Add;
    }
}