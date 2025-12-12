using System.Drawing;
using System.Windows.Forms;

namespace Bai5
{
    partial class Hom_Nay_An_Gi
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
            this.lv_dsmonan = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.btn_chonmon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_KetQua = new System.Windows.Forms.GroupBox();
            this.ptb_KetQua = new System.Windows.Forms.PictureBox();
            this.tb_KetQua = new System.Windows.Forms.TextBox();
            this.gb_KetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_KetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_dsmonan
            // 
            this.lv_dsmonan.HideSelection = false;
            this.lv_dsmonan.Location = new System.Drawing.Point(10, 44);
            this.lv_dsmonan.Margin = new System.Windows.Forms.Padding(2);
            this.lv_dsmonan.Name = "lv_dsmonan";
            this.lv_dsmonan.Size = new System.Drawing.Size(227, 305);
            this.lv_dsmonan.TabIndex = 0;
            this.lv_dsmonan.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hôm Nay Ăn Gì?";
            // 
            // btn_themmon
            // 
            this.btn_themmon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmon.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_themmon.Location = new System.Drawing.Point(241, 46);
            this.btn_themmon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(187, 137);
            this.btn_themmon.TabIndex = 8;
            this.btn_themmon.Text = "Thêm món ăn";
            this.btn_themmon.UseVisualStyleBackColor = true;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // btn_chonmon
            // 
            this.btn_chonmon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonmon.ForeColor = System.Drawing.Color.Red;
            this.btn_chonmon.Location = new System.Drawing.Point(241, 206);
            this.btn_chonmon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chonmon.Name = "btn_chonmon";
            this.btn_chonmon.Size = new System.Drawing.Size(187, 140);
            this.btn_chonmon.TabIndex = 10;
            this.btn_chonmon.Text = "Chọn món ăn";
            this.btn_chonmon.UseVisualStyleBackColor = true;
            this.btn_chonmon.Click += new System.EventHandler(this.btn_chonmon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách món ăn";
            // 
            // gb_KetQua
            // 
            this.gb_KetQua.Controls.Add(this.ptb_KetQua);
            this.gb_KetQua.Controls.Add(this.tb_KetQua);
            this.gb_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_KetQua.Location = new System.Drawing.Point(433, 37);
            this.gb_KetQua.Name = "gb_KetQua";
            this.gb_KetQua.Size = new System.Drawing.Size(241, 307);
            this.gb_KetQua.TabIndex = 15;
            this.gb_KetQua.TabStop = false;
            this.gb_KetQua.Text = "Kết Quả";
            // 
            // ptb_KetQua
            // 
            this.ptb_KetQua.Location = new System.Drawing.Point(6, 143);
            this.ptb_KetQua.Name = "ptb_KetQua";
            this.ptb_KetQua.Size = new System.Drawing.Size(229, 149);
            this.ptb_KetQua.TabIndex = 17;
            this.ptb_KetQua.TabStop = false;
            // 
            // tb_KetQua
            // 
            this.tb_KetQua.BackColor = System.Drawing.Color.Silver;
            this.tb_KetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KetQua.Location = new System.Drawing.Point(6, 28);
            this.tb_KetQua.Multiline = true;
            this.tb_KetQua.Name = "tb_KetQua";
            this.tb_KetQua.Size = new System.Drawing.Size(229, 109);
            this.tb_KetQua.TabIndex = 16;
            // 
            // Hom_Nay_An_Gi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(686, 356);
            this.Controls.Add(this.gb_KetQua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_chonmon);
            this.Controls.Add(this.btn_themmon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_dsmonan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hom_Nay_An_Gi";
            this.Text = "Hôm Nay Ăn Gì";
            this.Load += new System.EventHandler(this.Hom_Nay_An_Gi_Load);
            this.gb_KetQua.ResumeLayout(false);
            this.gb_KetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_KetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView lv_dsmonan;
        private Label label1;
        private Button btn_themmon;
        private Button btn_chonmon;
        private Label label6;
        private GroupBox gb_KetQua;
        private PictureBox ptb_KetQua;
        private TextBox tb_KetQua;
    }
}

