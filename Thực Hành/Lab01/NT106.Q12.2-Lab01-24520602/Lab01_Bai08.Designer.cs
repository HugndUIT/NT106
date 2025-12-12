namespace Lab01
{
    partial class Form8
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
            label5 = new Label();
            btn_thoat = new Button();
            btn_xoa = new Button();
            btn_tracuu = new Button();
            tb_nhapthongtin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_ketqua
            // 
            tb_ketqua.BorderStyle = BorderStyle.FixedSingle;
            tb_ketqua.Location = new Point(18, 213);
            tb_ketqua.Multiline = true;
            tb_ketqua.Name = "tb_ketqua";
            tb_ketqua.ReadOnly = true;
            tb_ketqua.Size = new Size(562, 166);
            tb_ketqua.TabIndex = 45;
            tb_ketqua.TextChanged += tb_ketqua_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(228, 171);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 44;
            label5.Text = "Kết quả tra cứu";
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_thoat.Location = new Point(418, 116);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(162, 40);
            btn_thoat.TabIndex = 43;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_xoa.Location = new Point(211, 116);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(176, 40);
            btn_xoa.TabIndex = 42;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_tracuu
            // 
            btn_tracuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_tracuu.Location = new Point(18, 116);
            btn_tracuu.Name = "btn_tracuu";
            btn_tracuu.Size = new Size(165, 40);
            btn_tracuu.TabIndex = 41;
            btn_tracuu.Text = "Tra cứu";
            btn_tracuu.UseVisualStyleBackColor = true;
            btn_tracuu.Click += btn_tracuu_Click;
            // 
            // tb_nhapthongtin
            // 
            tb_nhapthongtin.Location = new Point(211, 66);
            tb_nhapthongtin.Name = "tb_nhapthongtin";
            tb_nhapthongtin.Size = new Size(369, 27);
            tb_nhapthongtin.TabIndex = 40;
            tb_nhapthongtin.TextChanged += tb_nhapthongtin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 39;
            label2.Text = "Nhập Thông Tin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 38;
            label1.Text = "Danh Sách Điểm";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 390);
            Controls.Add(tb_ketqua);
            Controls.Add(label5);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tracuu);
            Controls.Add(tb_nhapthongtin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Bài 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ketqua;
        private Label label5;
        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_tracuu;
        private TextBox tb_nhapthongtin;
        private Label label2;
        private Label label1;
    }
}