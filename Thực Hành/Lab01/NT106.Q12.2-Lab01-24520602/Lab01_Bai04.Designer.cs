namespace Lab01
{
    partial class Form4
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
            label3 = new Label();
            btn_thoat = new Button();
            btn_xoa = new Button();
            btn_doc = new Button();
            tb_nhapso = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_ketqua
            // 
            tb_ketqua.Location = new Point(274, 122);
            tb_ketqua.Name = "tb_ketqua";
            tb_ketqua.ReadOnly = true;
            tb_ketqua.Size = new Size(242, 27);
            tb_ketqua.TabIndex = 29;
            tb_ketqua.TextChanged += tb_ketqua_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Salmon;
            label3.Location = new Point(72, 116);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 28;
            label3.Text = "KẾT QUẢ";
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_thoat.Location = new Point(371, 170);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(145, 40);
            btn_thoat.TabIndex = 27;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_xoa.Location = new Point(209, 170);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(145, 40);
            btn_xoa.TabIndex = 26;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_doc
            // 
            btn_doc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_doc.Location = new Point(37, 170);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(145, 40);
            btn_doc.TabIndex = 25;
            btn_doc.Text = "Đọc";
            btn_doc.UseVisualStyleBackColor = true;
            btn_doc.Click += btn_doc_Click;
            // 
            // tb_nhapso
            // 
            tb_nhapso.Location = new Point(274, 72);
            tb_nhapso.Name = "tb_nhapso";
            tb_nhapso.Size = new Size(242, 27);
            tb_nhapso.TabIndex = 24;
            tb_nhapso.TextChanged += tb_nhapso_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Salmon;
            label2.Location = new Point(11, 72);
            label2.Name = "label2";
            label2.Size = new Size(238, 31);
            label2.TabIndex = 23;
            label2.Text = "NHẬP SỐ TỰ NHIÊN ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(209, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 41);
            label1.TabIndex = 22;
            label1.Text = "ĐỌC SỐ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 230);
            Controls.Add(tb_ketqua);
            Controls.Add(label3);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_doc);
            Controls.Add(tb_nhapso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Bài 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ketqua;
        private Label label3;
        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_doc;
        private TextBox tb_nhapso;
        private Label label2;
        private Label label1;
    }
}