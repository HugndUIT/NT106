namespace NT106.Q12._2_Lab02_24520602
{
    partial class Lab02_Bai7
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
            tv_caythumuc = new TreeView();
            pn_noidung = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // tv_caythumuc
            // 
            tv_caythumuc.Location = new Point(12, 12);
            tv_caythumuc.Name = "tv_caythumuc";
            tv_caythumuc.Size = new Size(201, 426);
            tv_caythumuc.TabIndex = 0;
            tv_caythumuc.BeforeExpand += tv_caythumuc_BeforeExpand;
            tv_caythumuc.AfterSelect += tv_caythumuc_AfterSelect;
            // 
            // pn_noidung
            // 
            pn_noidung.BorderStyle = BorderStyle.FixedSingle;
            pn_noidung.Location = new Point(219, 12);
            pn_noidung.Name = "pn_noidung";
            pn_noidung.Size = new Size(569, 426);
            pn_noidung.TabIndex = 1;
            pn_noidung.Paint += pn_noidung_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "File content";
            // 
            // Lab02_Bai7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pn_noidung);
            Controls.Add(tv_caythumuc);
            Name = "Lab02_Bai7";
            Text = "Bài 07";
            Load += Lab02_Bai7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tv_caythumuc;
        private Panel pn_noidung;
        private Label label1;
    }
}