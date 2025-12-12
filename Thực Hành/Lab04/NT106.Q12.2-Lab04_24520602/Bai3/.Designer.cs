namespace Bai3
{
    partial class Bai3
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_DownFile = new System.Windows.Forms.Button();
            this.btn_DownResource = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.wv_Web = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wv_Web)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(16, 15);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(113, 36);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_DownFile
            // 
            this.btn_DownFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DownFile.Location = new System.Drawing.Point(792, 53);
            this.btn_DownFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DownFile.Name = "btn_DownFile";
            this.btn_DownFile.Size = new System.Drawing.Size(119, 36);
            this.btn_DownFile.TabIndex = 1;
            this.btn_DownFile.Text = "Down Files";
            this.btn_DownFile.UseVisualStyleBackColor = true;
            this.btn_DownFile.Click += new System.EventHandler(this.btn_DownFile_Click);
            // 
            // btn_DownResource
            // 
            this.btn_DownResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DownResource.Location = new System.Drawing.Point(919, 54);
            this.btn_DownResource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DownResource.Name = "btn_DownResource";
            this.btn_DownResource.Size = new System.Drawing.Size(168, 36);
            this.btn_DownResource.TabIndex = 2;
            this.btn_DownResource.Text = "Down Resources";
            this.btn_DownResource.UseVisualStyleBackColor = true;
            this.btn_DownResource.Click += new System.EventHandler(this.btn_DownResource_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(976, 15);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(111, 36);
            this.btn_Reload.TabIndex = 3;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // tb_Url
            // 
            this.tb_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Url.Location = new System.Drawing.Point(137, 15);
            this.tb_Url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(829, 30);
            this.tb_Url.TabIndex = 4;
            // 
            // wv_Web
            // 
            this.wv_Web.AllowExternalDrop = true;
            this.wv_Web.CreationProperties = null;
            this.wv_Web.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv_Web.Location = new System.Drawing.Point(16, 101);
            this.wv_Web.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wv_Web.Name = "wv_Web";
            this.wv_Web.Size = new System.Drawing.Size(1071, 482);
            this.wv_Web.TabIndex = 5;
            this.wv_Web.ZoomFactor = 1D;
            this.wv_Web.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.wv_Web_CoreWebView2InitializationCompleted);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 598);
            this.Controls.Add(this.wv_Web);
            this.Controls.Add(this.tb_Url);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_DownResource);
            this.Controls.Add(this.btn_DownFile);
            this.Controls.Add(this.btn_Load);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai3";
            this.Text = "Bài 3";
            ((System.ComponentModel.ISupportInitialize)(this.wv_Web)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_DownFile;
        private System.Windows.Forms.Button btn_DownResource;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.TextBox tb_Url;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv_Web;
    }
}

