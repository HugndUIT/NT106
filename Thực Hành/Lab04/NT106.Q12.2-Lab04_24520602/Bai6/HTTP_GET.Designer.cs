namespace Bai6
{
    partial class HTTP_GET
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(480, 56);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(169, 65);
            this.btn_Login.TabIndex = 13;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // rtb_Message
            // 
            this.rtb_Message.Location = new System.Drawing.Point(18, 146);
            this.rtb_Message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.Size = new System.Drawing.Size(631, 317);
            this.rtb_Message.TabIndex = 12;
            this.rtb_Message.Text = "";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(116, 99);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(358, 22);
            this.tb_Password.TabIndex = 9;
            // 
            // tb_URL
            // 
            this.tb_URL.Location = new System.Drawing.Point(116, 13);
            this.tb_URL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(533, 22);
            this.tb_URL.TabIndex = 10;
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(116, 56);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(358, 22);
            this.tb_Username.TabIndex = 11;
            // 
            // lbl_URL
            // 
            this.lbl_URL.Location = new System.Drawing.Point(15, 3);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(105, 43);
            this.lbl_URL.TabIndex = 8;
            this.lbl_URL.Text = "URL:";
            this.lbl_URL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(15, 89);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(105, 43);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password:";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Location = new System.Drawing.Point(15, 46);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(105, 43);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Username:";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Bai_06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 477);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.rtb_Message);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_URL);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Form_Bai_06";
            this.Text = "Bài 06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_URL;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
    }
}

