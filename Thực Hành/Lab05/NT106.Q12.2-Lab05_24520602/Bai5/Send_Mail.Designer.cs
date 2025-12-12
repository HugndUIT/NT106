namespace Bai5
{
    partial class Send_Mail
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
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_EmailSender = new System.Windows.Forms.TextBox();
            this.lbl_Sender = new System.Windows.Forms.Label();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tenmonan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(651, 312);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(145, 56);
            this.btn_Send.TabIndex = 23;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(161, 154);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(635, 26);
            this.tb_Name.TabIndex = 26;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(35, 160);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 20);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Name";
            // 
            // tb_EmailSender
            // 
            this.tb_EmailSender.Location = new System.Drawing.Point(161, 50);
            this.tb_EmailSender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EmailSender.Name = "tb_EmailSender";
            this.tb_EmailSender.Size = new System.Drawing.Size(635, 26);
            this.tb_EmailSender.TabIndex = 25;
            // 
            // lbl_Sender
            // 
            this.lbl_Sender.AutoSize = true;
            this.lbl_Sender.Location = new System.Drawing.Point(35, 54);
            this.lbl_Sender.Name = "lbl_Sender";
            this.lbl_Sender.Size = new System.Drawing.Size(46, 20);
            this.lbl_Sender.TabIndex = 15;
            this.lbl_Sender.Text = "From";
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(161, 255);
            this.tb_link.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(635, 26);
            this.tb_link.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Link hình ảnh";
            // 
            // tb_tenmonan
            // 
            this.tb_tenmonan.Location = new System.Drawing.Point(161, 208);
            this.tb_tenmonan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tenmonan.Name = "tb_tenmonan";
            this.tb_tenmonan.Size = new System.Drawing.Size(635, 26);
            this.tb_tenmonan.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên món ăn";
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(481, 312);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(145, 56);
            this.btn_AddFood.TabIndex = 33;
            this.btn_AddFood.Text = "Add";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(35, 112);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 20);
            this.lbl_password.TabIndex = 34;
            this.lbl_password.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(161, 106);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(635, 26);
            this.tb_Password.TabIndex = 35;
            // 
            // Send_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 392);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_AddFood);
            this.Controls.Add(this.tb_tenmonan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_EmailSender);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Sender);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Send_Mail";
            this.Text = "Send_Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_EmailSender;
        private System.Windows.Forms.Label lbl_Sender;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tenmonan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_Password;
    }
}