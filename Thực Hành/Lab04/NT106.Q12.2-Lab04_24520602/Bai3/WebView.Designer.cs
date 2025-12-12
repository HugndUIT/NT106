namespace Bai3
{
    partial class WebView
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
            this.wv_WebMoi = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wv_WebMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // wv_WebMoi
            // 
            this.wv_WebMoi.AllowExternalDrop = true;
            this.wv_WebMoi.CreationProperties = null;
            this.wv_WebMoi.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv_WebMoi.Location = new System.Drawing.Point(12, 12);
            this.wv_WebMoi.Name = "wv_WebMoi";
            this.wv_WebMoi.Size = new System.Drawing.Size(776, 426);
            this.wv_WebMoi.TabIndex = 0;
            this.wv_WebMoi.ZoomFactor = 1D;
            // 
            // Web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wv_WebMoi);
            this.Name = "Web";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.wv_WebMoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wv_WebMoi;
    }
}