namespace Bai6
{
    partial class frm_Bai6
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("#", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("From", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Subject", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Datetime", System.Windows.Forms.HorizontalAlignment.Left);
            this.lv_Mail = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_DangNhap = new System.Windows.Forms.GroupBox();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Send_Mail = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.gb_CaiDat = new System.Windows.Forms.GroupBox();
            this.lbl_Port2 = new System.Windows.Forms.Label();
            this.lbl_Smtp = new System.Windows.Forms.Label();
            this.lbl_Port1 = new System.Windows.Forms.Label();
            this.lbl_Imap = new System.Windows.Forms.Label();
            this.nUD_Port2 = new System.Windows.Forms.NumericUpDown();
            this.nUD_Port1 = new System.Windows.Forms.NumericUpDown();
            this.tb_SMTP = new System.Windows.Forms.TextBox();
            this.tb_IMAP = new System.Windows.Forms.TextBox();
            this.gb_DangNhap.SuspendLayout();
            this.gb_CaiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Port2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Port1)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_Mail
            // 
            this.lv_Mail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Sender,
            this.Subject,
            this.datetime});
            listViewGroup1.Header = "#";
            listViewGroup1.Name = "STT";
            listViewGroup1.Tag = "Int";
            listViewGroup2.Header = "From";
            listViewGroup2.Name = "Receiver";
            listViewGroup2.Tag = "String";
            listViewGroup3.Header = "Subject";
            listViewGroup3.Name = "Subject";
            listViewGroup3.Tag = "String";
            listViewGroup4.Header = "Datetime";
            listViewGroup4.Name = "DateReceived";
            listViewGroup4.Tag = "DateTime";
            this.lv_Mail.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.lv_Mail.HideSelection = false;
            this.lv_Mail.Location = new System.Drawing.Point(33, 218);
            this.lv_Mail.Name = "lv_Mail";
            this.lv_Mail.Size = new System.Drawing.Size(1015, 463);
            this.lv_Mail.TabIndex = 0;
            this.lv_Mail.UseCompatibleStateImageBehavior = false;
            this.lv_Mail.View = System.Windows.Forms.View.Details;
            this.lv_Mail.SelectedIndexChanged += new System.EventHandler(this.lv_Mail_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "#";
            // 
            // Sender
            // 
            this.Sender.Text = "From";
            this.Sender.Width = 324;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 372;
            // 
            // datetime
            // 
            this.datetime.Text = "Datetime";
            this.datetime.Width = 253;
            // 
            // gb_DangNhap
            // 
            this.gb_DangNhap.Controls.Add(this.btn_Log_Out);
            this.gb_DangNhap.Controls.Add(this.btn_Refresh);
            this.gb_DangNhap.Controls.Add(this.btn_Send_Mail);
            this.gb_DangNhap.Controls.Add(this.btn_Login);
            this.gb_DangNhap.Controls.Add(this.tb_Password);
            this.gb_DangNhap.Controls.Add(this.tb_Email);
            this.gb_DangNhap.Controls.Add(this.lbl_Password);
            this.gb_DangNhap.Controls.Add(this.lbl_Email);
            this.gb_DangNhap.Location = new System.Drawing.Point(33, 33);
            this.gb_DangNhap.Name = "gb_DangNhap";
            this.gb_DangNhap.Size = new System.Drawing.Size(384, 156);
            this.gb_DangNhap.TabIndex = 1;
            this.gb_DangNhap.TabStop = false;
            this.gb_DangNhap.Text = "Đăng nhập";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Location = new System.Drawing.Point(261, 108);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(105, 42);
            this.btn_Log_Out.TabIndex = 7;
            this.btn_Log_Out.Text = "Đăng xuất";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Visible = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(137, 108);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(105, 42);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Visible = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Send_Mail
            // 
            this.btn_Send_Mail.Location = new System.Drawing.Point(6, 108);
            this.btn_Send_Mail.Name = "btn_Send_Mail";
            this.btn_Send_Mail.Size = new System.Drawing.Size(105, 42);
            this.btn_Send_Mail.TabIndex = 5;
            this.btn_Send_Mail.Text = "Gửi mail";
            this.btn_Send_Mail.UseVisualStyleBackColor = true;
            this.btn_Send_Mail.Visible = false;
            this.btn_Send_Mail.Click += new System.EventHandler(this.btn_Send_Mail_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(261, 108);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(105, 42);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(147, 71);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(219, 30);
            this.tb_Password.TabIndex = 3;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(147, 30);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(219, 30);
            this.tb_Email.TabIndex = 2;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(42, 74);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(82, 22);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Mật khẩu";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(36, 33);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(88, 22);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Tài khoản";
            // 
            // gb_CaiDat
            // 
            this.gb_CaiDat.Controls.Add(this.lbl_Port2);
            this.gb_CaiDat.Controls.Add(this.lbl_Smtp);
            this.gb_CaiDat.Controls.Add(this.lbl_Port1);
            this.gb_CaiDat.Controls.Add(this.lbl_Imap);
            this.gb_CaiDat.Controls.Add(this.nUD_Port2);
            this.gb_CaiDat.Controls.Add(this.nUD_Port1);
            this.gb_CaiDat.Controls.Add(this.tb_SMTP);
            this.gb_CaiDat.Controls.Add(this.tb_IMAP);
            this.gb_CaiDat.Location = new System.Drawing.Point(423, 33);
            this.gb_CaiDat.Name = "gb_CaiDat";
            this.gb_CaiDat.Size = new System.Drawing.Size(625, 156);
            this.gb_CaiDat.TabIndex = 2;
            this.gb_CaiDat.TabStop = false;
            this.gb_CaiDat.Text = "Cài đặt";
            // 
            // lbl_Port2
            // 
            this.lbl_Port2.AutoSize = true;
            this.lbl_Port2.Location = new System.Drawing.Point(323, 100);
            this.lbl_Port2.Name = "lbl_Port2";
            this.lbl_Port2.Size = new System.Drawing.Size(43, 22);
            this.lbl_Port2.TabIndex = 7;
            this.lbl_Port2.Text = "Port";
            // 
            // lbl_Smtp
            // 
            this.lbl_Smtp.AutoSize = true;
            this.lbl_Smtp.Location = new System.Drawing.Point(323, 42);
            this.lbl_Smtp.Name = "lbl_Smtp";
            this.lbl_Smtp.Size = new System.Drawing.Size(61, 22);
            this.lbl_Smtp.TabIndex = 6;
            this.lbl_Smtp.Text = "SMTP";
            // 
            // lbl_Port1
            // 
            this.lbl_Port1.AutoSize = true;
            this.lbl_Port1.Location = new System.Drawing.Point(25, 100);
            this.lbl_Port1.Name = "lbl_Port1";
            this.lbl_Port1.Size = new System.Drawing.Size(43, 22);
            this.lbl_Port1.TabIndex = 5;
            this.lbl_Port1.Text = "Port";
            // 
            // lbl_Imap
            // 
            this.lbl_Imap.AutoSize = true;
            this.lbl_Imap.Location = new System.Drawing.Point(25, 42);
            this.lbl_Imap.Name = "lbl_Imap";
            this.lbl_Imap.Size = new System.Drawing.Size(58, 22);
            this.lbl_Imap.TabIndex = 4;
            this.lbl_Imap.Text = "IMAP";
            // 
            // nUD_Port2
            // 
            this.nUD_Port2.Location = new System.Drawing.Point(400, 98);
            this.nUD_Port2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nUD_Port2.Name = "nUD_Port2";
            this.nUD_Port2.Size = new System.Drawing.Size(197, 30);
            this.nUD_Port2.TabIndex = 3;
            // 
            // nUD_Port1
            // 
            this.nUD_Port1.Location = new System.Drawing.Point(100, 98);
            this.nUD_Port1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nUD_Port1.Name = "nUD_Port1";
            this.nUD_Port1.Size = new System.Drawing.Size(197, 30);
            this.nUD_Port1.TabIndex = 2;
            // 
            // tb_SMTP
            // 
            this.tb_SMTP.Location = new System.Drawing.Point(400, 39);
            this.tb_SMTP.Name = "tb_SMTP";
            this.tb_SMTP.Size = new System.Drawing.Size(197, 30);
            this.tb_SMTP.TabIndex = 1;
            // 
            // tb_IMAP
            // 
            this.tb_IMAP.Location = new System.Drawing.Point(100, 39);
            this.tb_IMAP.Name = "tb_IMAP";
            this.tb_IMAP.Size = new System.Drawing.Size(197, 30);
            this.tb_IMAP.TabIndex = 0;
            // 
            // frm_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 693);
            this.Controls.Add(this.gb_CaiDat);
            this.Controls.Add(this.gb_DangNhap);
            this.Controls.Add(this.lv_Mail);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_Bai6";
            this.Text = "Bài 6";
            this.gb_DangNhap.ResumeLayout(false);
            this.gb_DangNhap.PerformLayout();
            this.gb_CaiDat.ResumeLayout(false);
            this.gb_CaiDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Port2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Port1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Mail;
        private System.Windows.Forms.GroupBox gb_DangNhap;
        private System.Windows.Forms.GroupBox gb_CaiDat;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Port2;
        private System.Windows.Forms.Label lbl_Smtp;
        private System.Windows.Forms.Label lbl_Port1;
        private System.Windows.Forms.Label lbl_Imap;
        private System.Windows.Forms.NumericUpDown nUD_Port2;
        private System.Windows.Forms.NumericUpDown nUD_Port1;
        private System.Windows.Forms.TextBox tb_SMTP;
        private System.Windows.Forms.TextBox tb_IMAP;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader datetime;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Send_Mail;
    }
}

