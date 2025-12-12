namespace Lab01
{
    partial class Form2
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
            tb_min = new TextBox();
            tb_max = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_thoat = new Button();
            btn_xoa = new Button();
            btn_tim = new Button();
            tb_sothuba = new TextBox();
            tb_sothuhai = new TextBox();
            tb_sothunhat = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_min
            // 
            tb_min.Location = new Point(163, 278);
            tb_min.Name = "tb_min";
            tb_min.ReadOnly = true;
            tb_min.Size = new Size(173, 27);
            tb_min.TabIndex = 27;
            tb_min.TextChanged += tb_min_TextChanged;
            // 
            // tb_max
            // 
            tb_max.Location = new Point(163, 231);
            tb_max.Name = "tb_max";
            tb_max.ReadOnly = true;
            tb_max.Size = new Size(173, 27);
            tb_max.TabIndex = 26;
            tb_max.TextChanged += tb_max_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(50, 278);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 25;
            label6.Text = "MIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(50, 231);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 24;
            label5.Text = "MAX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(50, 9);
            label4.Name = "label4";
            label4.Size = new Size(430, 41);
            label4.TabIndex = 23;
            label4.Text = "TÌM SỐ LỚN NHẤT, BÉ NHẤT";
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_thoat.Location = new Point(365, 207);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(131, 40);
            btn_thoat.TabIndex = 22;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_xoa.Location = new Point(365, 158);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(131, 40);
            btn_xoa.TabIndex = 21;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_tim
            // 
            btn_tim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_tim.Location = new Point(365, 107);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(131, 40);
            btn_tim.TabIndex = 20;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // tb_sothuba
            // 
            tb_sothuba.Location = new Point(163, 175);
            tb_sothuba.Name = "tb_sothuba";
            tb_sothuba.Size = new Size(173, 27);
            tb_sothuba.TabIndex = 19;
            tb_sothuba.TextChanged += tb_sothuba_TextChanged;
            // 
            // tb_sothuhai
            // 
            tb_sothuhai.Location = new Point(163, 126);
            tb_sothuhai.Name = "tb_sothuhai";
            tb_sothuhai.Size = new Size(173, 27);
            tb_sothuhai.TabIndex = 18;
            tb_sothuhai.TextChanged += tb_sothuhai_TextChanged;
            // 
            // tb_sothunhat
            // 
            tb_sothunhat.Location = new Point(163, 75);
            tb_sothunhat.Name = "tb_sothunhat";
            tb_sothunhat.Size = new Size(173, 27);
            tb_sothunhat.TabIndex = 17;
            tb_sothunhat.TextChanged += tb_sothunhat_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(5, 178);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 16;
            label3.Text = "SỐ THỨ BA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(5, 126);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 15;
            label2.Text = "SỐ THỨ HAI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(5, 75);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 14;
            label1.Text = "SỐ THỨ NHẤT";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 324);
            Controls.Add(tb_min);
            Controls.Add(tb_max);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tim);
            Controls.Add(tb_sothuba);
            Controls.Add(tb_sothuhai);
            Controls.Add(tb_sothunhat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_min;
        private TextBox tb_max;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_tim;
        private TextBox tb_sothuba;
        private TextBox tb_sothuhai;
        private TextBox tb_sothunhat;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}