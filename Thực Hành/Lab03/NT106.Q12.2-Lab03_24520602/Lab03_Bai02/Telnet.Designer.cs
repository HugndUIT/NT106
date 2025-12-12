namespace Lab03_Bai02
{
    partial class Telnet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lv_message = new ListView();
            btn_listen = new Button();
            SuspendLayout();
            // 
            // lv_message
            // 
            lv_message.Location = new Point(12, 101);
            lv_message.Name = "lv_message";
            lv_message.Size = new Size(454, 339);
            lv_message.TabIndex = 1;
            lv_message.UseCompatibleStateImageBehavior = false;
            lv_message.SelectedIndexChanged += lv_message_SelectedIndexChanged;
            // 
            // btn_listen
            // 
            btn_listen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_listen.Location = new Point(12, 12);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(454, 83);
            btn_listen.TabIndex = 2;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // Telnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 452);
            Controls.Add(btn_listen);
            Controls.Add(lv_message);
            Name = "Telnet";
            Text = "Lab03_Bai02";
            ResumeLayout(false);
        }

        #endregion
        private ListView lv_message;
        private Button btn_listen;
    }
}
