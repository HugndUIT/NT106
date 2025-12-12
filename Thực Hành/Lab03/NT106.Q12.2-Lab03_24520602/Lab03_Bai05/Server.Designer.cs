namespace Lab03_Bai04
{
    partial class Server
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
            lv_Message = new ListView();
            columnHeader1 = new ColumnHeader();
            btn_Listen = new Button();
            SuspendLayout();
            // 
            // lv_Message
            // 
            lv_Message.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lv_Message.Location = new Point(12, 74);
            lv_Message.Margin = new Padding(3, 4, 3, 4);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(776, 363);
            lv_Message.TabIndex = 3;
            lv_Message.UseCompatibleStateImageBehavior = false;
            lv_Message.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Message";
            columnHeader1.Width = 772;
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(598, 13);
            btn_Listen.Margin = new Padding(3, 4, 3, 4);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(190, 55);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lv_Message);
            Controls.Add(btn_Listen);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_Message;
        private ColumnHeader columnHeader1;
        private Button btn_Listen;
    }
}