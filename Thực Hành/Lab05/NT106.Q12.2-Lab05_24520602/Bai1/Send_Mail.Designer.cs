namespace Bai1
{
    partial class Lab5_Bai1
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
            this.tb_EmailSender = new System.Windows.Forms.TextBox();
            this.tb_EmailReceiver = new System.Windows.Forms.TextBox();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.rtb_Body = new System.Windows.Forms.RichTextBox();
            this.lbl_Sender = new System.Windows.Forms.Label();
            this.lbl_Receiver = new System.Windows.Forms.Label();
            this.lbl_Subjects = new System.Windows.Forms.Label();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(48, 45);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(121, 59);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_EmailSender
            // 
            this.tb_EmailSender.Location = new System.Drawing.Point(346, 45);
            this.tb_EmailSender.Name = "tb_EmailSender";
            this.tb_EmailSender.Size = new System.Drawing.Size(354, 30);
            this.tb_EmailSender.TabIndex = 1;
            // 
            // tb_EmailReceiver
            // 
            this.tb_EmailReceiver.Location = new System.Drawing.Point(346, 92);
            this.tb_EmailReceiver.Name = "tb_EmailReceiver";
            this.tb_EmailReceiver.Size = new System.Drawing.Size(354, 30);
            this.tb_EmailReceiver.TabIndex = 2;
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(244, 139);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(648, 30);
            this.tb_Subject.TabIndex = 3;
            // 
            // rtb_Body
            // 
            this.rtb_Body.Location = new System.Drawing.Point(244, 190);
            this.rtb_Body.Name = "rtb_Body";
            this.rtb_Body.Size = new System.Drawing.Size(648, 284);
            this.rtb_Body.TabIndex = 4;
            this.rtb_Body.Text = "";
            // 
            // lbl_Sender
            // 
            this.lbl_Sender.AutoSize = true;
            this.lbl_Sender.Location = new System.Drawing.Point(240, 53);
            this.lbl_Sender.Name = "lbl_Sender";
            this.lbl_Sender.Size = new System.Drawing.Size(58, 22);
            this.lbl_Sender.TabIndex = 5;
            this.lbl_Sender.Text = "From:";
            // 
            // lbl_Receiver
            // 
            this.lbl_Receiver.AutoSize = true;
            this.lbl_Receiver.Location = new System.Drawing.Point(261, 100);
            this.lbl_Receiver.Name = "lbl_Receiver";
            this.lbl_Receiver.Size = new System.Drawing.Size(37, 22);
            this.lbl_Receiver.TabIndex = 6;
            this.lbl_Receiver.Text = "To:";
            // 
            // lbl_Subjects
            // 
            this.lbl_Subjects.AutoSize = true;
            this.lbl_Subjects.Location = new System.Drawing.Point(86, 147);
            this.lbl_Subjects.Name = "lbl_Subjects";
            this.lbl_Subjects.Size = new System.Drawing.Size(83, 22);
            this.lbl_Subjects.TabIndex = 7;
            this.lbl_Subjects.Text = "Subjects:";
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Location = new System.Drawing.Point(111, 224);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(58, 22);
            this.lbl_Body.TabIndex = 8;
            this.lbl_Body.Text = "Body:";
            // 
            // Lab5_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.lbl_Subjects);
            this.Controls.Add(this.lbl_Receiver);
            this.Controls.Add(this.lbl_Sender);
            this.Controls.Add(this.rtb_Body);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.tb_EmailReceiver);
            this.Controls.Add(this.tb_EmailSender);
            this.Controls.Add(this.btn_Send);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Lab5_Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_EmailSender;
        private System.Windows.Forms.TextBox tb_EmailReceiver;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.RichTextBox rtb_Body;
        private System.Windows.Forms.Label lbl_Sender;
        private System.Windows.Forms.Label lbl_Receiver;
        private System.Windows.Forms.Label lbl_Subjects;
        private System.Windows.Forms.Label lbl_Body;
    }
}

