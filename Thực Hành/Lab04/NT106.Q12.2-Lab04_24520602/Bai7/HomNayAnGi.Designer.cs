namespace Bai7
{
    partial class frm_HomNayAnGi
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
            this.btn_AnGi = new System.Windows.Forms.Button();
            this.btn_ThemMon = new System.Windows.Forms.Button();
            this.tc_DanhSachMonAn = new System.Windows.Forms.TabControl();
            this.tPage_All = new System.Windows.Forms.TabPage();
            this.flp_MenuAll = new System.Windows.Forms.FlowLayoutPanel();
            this.tPage_CuaToi = new System.Windows.Forms.TabPage();
            this.flp_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Welcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Logout = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_Page = new System.Windows.Forms.Label();
            this.lbl_PageSize = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tc_DanhSachMonAn.SuspendLayout();
            this.tPage_All.SuspendLayout();
            this.tPage_CuaToi.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(366, 81);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "HÔM NAY ĂN GÌ?";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_AnGi
            // 
            this.btn_AnGi.BackColor = System.Drawing.Color.Peru;
            this.btn_AnGi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnGi.Location = new System.Drawing.Point(312, 92);
            this.btn_AnGi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AnGi.Name = "btn_AnGi";
            this.btn_AnGi.Size = new System.Drawing.Size(174, 69);
            this.btn_AnGi.TabIndex = 1;
            this.btn_AnGi.Text = "Ăn gì giờ?";
            this.btn_AnGi.UseVisualStyleBackColor = false;
            this.btn_AnGi.Click += new System.EventHandler(this.btn_AnGi_Click);
            // 
            // btn_ThemMon
            // 
            this.btn_ThemMon.BackColor = System.Drawing.Color.Peru;
            this.btn_ThemMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMon.Location = new System.Drawing.Point(501, 92);
            this.btn_ThemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemMon.Name = "btn_ThemMon";
            this.btn_ThemMon.Size = new System.Drawing.Size(174, 69);
            this.btn_ThemMon.TabIndex = 2;
            this.btn_ThemMon.Text = "Thêm món ăn";
            this.btn_ThemMon.UseVisualStyleBackColor = false;
            this.btn_ThemMon.Click += new System.EventHandler(this.btn_ThemMon_Click);
            // 
            // tc_DanhSachMonAn
            // 
            this.tc_DanhSachMonAn.Controls.Add(this.tPage_All);
            this.tc_DanhSachMonAn.Controls.Add(this.tPage_CuaToi);
            this.tc_DanhSachMonAn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_DanhSachMonAn.Location = new System.Drawing.Point(43, 166);
            this.tc_DanhSachMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_DanhSachMonAn.Multiline = true;
            this.tc_DanhSachMonAn.Name = "tc_DanhSachMonAn";
            this.tc_DanhSachMonAn.SelectedIndex = 0;
            this.tc_DanhSachMonAn.Size = new System.Drawing.Size(632, 468);
            this.tc_DanhSachMonAn.TabIndex = 3;
            this.tc_DanhSachMonAn.SelectedIndexChanged += new System.EventHandler(this.Tc_DanhSachMonAn_SelectedIndexChanged);
            // 
            // tPage_All
            // 
            this.tPage_All.Controls.Add(this.flp_MenuAll);
            this.tPage_All.Location = new System.Drawing.Point(4, 31);
            this.tPage_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPage_All.Name = "tPage_All";
            this.tPage_All.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPage_All.Size = new System.Drawing.Size(624, 433);
            this.tPage_All.TabIndex = 0;
            this.tPage_All.Text = "All";
            this.tPage_All.UseVisualStyleBackColor = true;
            // 
            // flp_MenuAll
            // 
            this.flp_MenuAll.AutoScroll = true;
            this.flp_MenuAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_MenuAll.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_MenuAll.Location = new System.Drawing.Point(3, 2);
            this.flp_MenuAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_MenuAll.Name = "flp_MenuAll";
            this.flp_MenuAll.Size = new System.Drawing.Size(618, 429);
            this.flp_MenuAll.TabIndex = 0;
            this.flp_MenuAll.WrapContents = false;
            // 
            // tPage_CuaToi
            // 
            this.tPage_CuaToi.Controls.Add(this.flp_Menu);
            this.tPage_CuaToi.Location = new System.Drawing.Point(4, 31);
            this.tPage_CuaToi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPage_CuaToi.Name = "tPage_CuaToi";
            this.tPage_CuaToi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPage_CuaToi.Size = new System.Drawing.Size(624, 433);
            this.tPage_CuaToi.TabIndex = 1;
            this.tPage_CuaToi.Text = "Tôi đóng góp";
            this.tPage_CuaToi.UseVisualStyleBackColor = true;
            // 
            // flp_Menu
            // 
            this.flp_Menu.AutoScroll = true;
            this.flp_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Menu.Location = new System.Drawing.Point(3, 2);
            this.flp_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_Menu.Name = "flp_Menu";
            this.flp_Menu.Size = new System.Drawing.Size(618, 429);
            this.flp_Menu.TabIndex = 0;
            this.flp_Menu.WrapContents = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Welcome,
            this.lbl_Logout,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(714, 29);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(130, 22);
            this.lbl_Welcome.Text = "Welcome, User";
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.ActiveLinkColor = System.Drawing.Color.Red;
            this.lbl_Logout.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(64, 22);
            this.lbl_Logout.Text = "Logout";
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.SpringGreen;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 21);
            // 
            // lbl_Page
            // 
            this.lbl_Page.AutoSize = true;
            this.lbl_Page.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Page.Location = new System.Drawing.Point(420, 650);
            this.lbl_Page.Name = "lbl_Page";
            this.lbl_Page.Size = new System.Drawing.Size(48, 22);
            this.lbl_Page.TabIndex = 5;
            this.lbl_Page.Text = "Page";
            // 
            // lbl_PageSize
            // 
            this.lbl_PageSize.AutoSize = true;
            this.lbl_PageSize.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PageSize.Location = new System.Drawing.Point(536, 646);
            this.lbl_PageSize.Name = "lbl_PageSize";
            this.lbl_PageSize.Size = new System.Drawing.Size(84, 22);
            this.lbl_PageSize.TabIndex = 6;
            this.lbl_PageSize.Text = "Page size";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(483, 644);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(626, 642);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 28);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Pagination_Changed);
            // 
            // frm_HomNayAnGi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(714, 710);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_PageSize);
            this.Controls.Add(this.lbl_Page);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tc_DanhSachMonAn);
            this.Controls.Add(this.btn_ThemMon);
            this.Controls.Add(this.btn_AnGi);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_HomNayAnGi";
            this.Text = "Hôm nay ăn gì?";
            this.Load += new System.EventHandler(this.Frm_HomNayAnGi_Load);
            this.tc_DanhSachMonAn.ResumeLayout(false);
            this.tPage_All.ResumeLayout(false);
            this.tPage_CuaToi.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_AnGi;
        private System.Windows.Forms.Button btn_ThemMon;
        private System.Windows.Forms.TabControl tc_DanhSachMonAn;
        private System.Windows.Forms.TabPage tPage_All;
        private System.Windows.Forms.TabPage tPage_CuaToi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Welcome;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Logout;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label lbl_Page;
        private System.Windows.Forms.Label lbl_PageSize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.FlowLayoutPanel flp_MenuAll;
        private System.Windows.Forms.FlowLayoutPanel flp_Menu;
    }
}