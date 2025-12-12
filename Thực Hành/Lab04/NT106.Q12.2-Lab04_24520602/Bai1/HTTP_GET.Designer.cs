namespace Bai1
{
    partial class Form1
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
            this.tb_url = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.rtb_html = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(12, 12);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(546, 22);
            this.tb_url.TabIndex = 0;
            // 
            // btn_get
            // 
            this.btn_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(564, 11);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(95, 23);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "GET";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // rtb_html
            // 
            this.rtb_html.Location = new System.Drawing.Point(12, 40);
            this.rtb_html.Name = "rtb_html";
            this.rtb_html.Size = new System.Drawing.Size(647, 429);
            this.rtb_html.TabIndex = 2;
            this.rtb_html.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 481);
            this.Controls.Add(this.rtb_html);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.tb_url);
            this.Name = "Form1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.RichTextBox rtb_html;
    }
}

