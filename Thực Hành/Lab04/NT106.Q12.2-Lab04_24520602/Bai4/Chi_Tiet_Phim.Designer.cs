namespace Bai4
{
    partial class Chi_Tiet_Phim
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
            this.wb_Chi_Tiet = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wb_Chi_Tiet)).BeginInit();
            this.SuspendLayout();
            // 
            // wb_Chi_Tiet
            // 
            this.wb_Chi_Tiet.AllowExternalDrop = true;
            this.wb_Chi_Tiet.CreationProperties = null;
            this.wb_Chi_Tiet.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wb_Chi_Tiet.Location = new System.Drawing.Point(12, 12);
            this.wb_Chi_Tiet.Name = "wb_Chi_Tiet";
            this.wb_Chi_Tiet.Size = new System.Drawing.Size(776, 426);
            this.wb_Chi_Tiet.TabIndex = 0;
            this.wb_Chi_Tiet.ZoomFactor = 1D;
            // 
            // Chi_Tiet_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wb_Chi_Tiet);
            this.Name = "Chi_Tiet_Phim";
            this.Text = "Website_Phim";
            ((System.ComponentModel.ISupportInitialize)(this.wb_Chi_Tiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wb_Chi_Tiet;
    }
}