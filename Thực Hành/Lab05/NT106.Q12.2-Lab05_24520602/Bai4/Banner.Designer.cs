namespace Bai4
{
    partial class Banner
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
            this.ptb_Anh_Phim = new System.Windows.Forms.PictureBox();
            this.lbl_Ten_Phim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh_Phim)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Anh_Phim
            // 
            this.ptb_Anh_Phim.Location = new System.Drawing.Point(3, 3);
            this.ptb_Anh_Phim.Name = "ptb_Anh_Phim";
            this.ptb_Anh_Phim.Size = new System.Drawing.Size(141, 136);
            this.ptb_Anh_Phim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Anh_Phim.TabIndex = 0;
            this.ptb_Anh_Phim.TabStop = false;
            // 
            // lbl_Ten_Phim
            // 
            this.lbl_Ten_Phim.AutoSize = true;
            this.lbl_Ten_Phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_Phim.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_Ten_Phim.Location = new System.Drawing.Point(150, 3);
            this.lbl_Ten_Phim.Name = "lbl_Ten_Phim";
            this.lbl_Ten_Phim.Size = new System.Drawing.Size(122, 31);
            this.lbl_Ten_Phim.TabIndex = 1;
            this.lbl_Ten_Phim.Text = "TenPhim";
            // 
            // Banner_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Ten_Phim);
            this.Controls.Add(this.ptb_Anh_Phim);
            this.Name = "Banner_Phim";
            this.Size = new System.Drawing.Size(488, 142);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh_Phim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Anh_Phim;
        private System.Windows.Forms.Label lbl_Ten_Phim;
    }
}
