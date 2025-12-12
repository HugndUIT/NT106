namespace Bbai4
{
    partial class Dat_Ve_Phim
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
            this.cb_Phim = new System.Windows.Forms.ComboBox();
            this.cb_Phong = new System.Windows.Forms.ComboBox();
            this.btn_DatVe = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TenKhach = new System.Windows.Forms.TextBox();
            this.clb_Ghe = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_KQ = new System.Windows.Forms.TextBox();
            this.lbl_EmailCustomer = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Phim
            // 
            this.cb_Phim.FormattingEnabled = true;
            this.cb_Phim.Location = new System.Drawing.Point(244, 240);
            this.cb_Phim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Phim.Name = "cb_Phim";
            this.cb_Phim.Size = new System.Drawing.Size(365, 28);
            this.cb_Phim.TabIndex = 0;
            this.cb_Phim.SelectedIndexChanged += new System.EventHandler(this.cb_Phim_SelectedIndexChanged);
            // 
            // cb_Phong
            // 
            this.cb_Phong.FormattingEnabled = true;
            this.cb_Phong.Location = new System.Drawing.Point(244, 282);
            this.cb_Phong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Size = new System.Drawing.Size(365, 28);
            this.cb_Phong.TabIndex = 1;
            this.cb_Phong.SelectedIndexChanged += new System.EventHandler(this.cb_Phong_SelectedIndexChanged);
            // 
            // btn_DatVe
            // 
            this.btn_DatVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DatVe.Location = new System.Drawing.Point(764, 158);
            this.btn_DatVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DatVe.Name = "btn_DatVe";
            this.btn_DatVe.Size = new System.Drawing.Size(210, 46);
            this.btn_DatVe.TabIndex = 2;
            this.btn_DatVe.Text = "Đặt vé";
            this.btn_DatVe.UseVisualStyleBackColor = true;
            this.btn_DatVe.Click += new System.EventHandler(this.btn_DatVe_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.Location = new System.Drawing.Point(764, 236);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(210, 49);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá thông tin";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(297, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Phòng Vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(64, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(64, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(64, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phòng ";
            // 
            // tb_TenKhach
            // 
            this.tb_TenKhach.Location = new System.Drawing.Point(244, 160);
            this.tb_TenKhach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_TenKhach.Name = "tb_TenKhach";
            this.tb_TenKhach.Size = new System.Drawing.Size(365, 26);
            this.tb_TenKhach.TabIndex = 8;
            // 
            // clb_Ghe
            // 
            this.clb_Ghe.FormattingEnabled = true;
            this.clb_Ghe.Location = new System.Drawing.Point(15, 362);
            this.clb_Ghe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clb_Ghe.MultiColumn = true;
            this.clb_Ghe.Name = "clb_Ghe";
            this.clb_Ghe.Size = new System.Drawing.Size(448, 165);
            this.clb_Ghe.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_KQ);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(472, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(508, 259);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // tb_KQ
            // 
            this.tb_KQ.BackColor = System.Drawing.SystemColors.Control;
            this.tb_KQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_KQ.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KQ.Location = new System.Drawing.Point(8, 38);
            this.tb_KQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_KQ.Multiline = true;
            this.tb_KQ.Name = "tb_KQ";
            this.tb_KQ.Size = new System.Drawing.Size(494, 200);
            this.tb_KQ.TabIndex = 11;
            // 
            // lbl_EmailCustomer
            // 
            this.lbl_EmailCustomer.AutoSize = true;
            this.lbl_EmailCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_EmailCustomer.Location = new System.Drawing.Point(64, 198);
            this.lbl_EmailCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EmailCustomer.Name = "lbl_EmailCustomer";
            this.lbl_EmailCustomer.Size = new System.Drawing.Size(71, 32);
            this.lbl_EmailCustomer.TabIndex = 6;
            this.lbl_EmailCustomer.Text = "Email";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(244, 204);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(365, 26);
            this.tb_Email.TabIndex = 8;
            // 
            // Dat_Ve_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clb_Ghe);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_TenKhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_EmailCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_DatVe);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.cb_Phim);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dat_Ve_Phim";
            this.Text = "Quản Lý Phòng Vé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TenKhach;
        private System.Windows.Forms.Button btn_DatVe;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.CheckedListBox clb_Ghe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_KQ;
        private System.Windows.Forms.ComboBox cb_Phim;
        private System.Windows.Forms.ComboBox cb_Phong;
        private System.Windows.Forms.Label lbl_EmailCustomer;
        private System.Windows.Forms.TextBox tb_Email;
    }
}