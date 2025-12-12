namespace Bai4
{
    partial class Danh_Sach_Phim
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
            this.flp_Danh_Sach_Phim = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Mua_Ve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Danh_Sach_Phim
            // 
            this.flp_Danh_Sach_Phim.AutoScroll = true;
            this.flp_Danh_Sach_Phim.Location = new System.Drawing.Point(12, 88);
            this.flp_Danh_Sach_Phim.Name = "flp_Danh_Sach_Phim";
            this.flp_Danh_Sach_Phim.Size = new System.Drawing.Size(713, 387);
            this.flp_Danh_Sach_Phim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phim Đang Chiếu ";
            // 
            // btn_Mua_Ve
            // 
            this.btn_Mua_Ve.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mua_Ve.Location = new System.Drawing.Point(576, 31);
            this.btn_Mua_Ve.Name = "btn_Mua_Ve";
            this.btn_Mua_Ve.Size = new System.Drawing.Size(149, 48);
            this.btn_Mua_Ve.TabIndex = 2;
            this.btn_Mua_Ve.Text = "Mua Vé";
            this.btn_Mua_Ve.UseVisualStyleBackColor = true;
            this.btn_Mua_Ve.Click += new System.EventHandler(this.btn_Mua_Ve_Click);
            // 
            // Danh_Sach_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 518);
            this.Controls.Add(this.btn_Mua_Ve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_Danh_Sach_Phim);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Danh_Sach_Phim";
            this.Text = "Phim Đang Chiếu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Danh_Sach_Phim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Mua_Ve;
    }
}

