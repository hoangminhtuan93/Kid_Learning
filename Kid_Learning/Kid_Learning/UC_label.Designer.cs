namespace Kid_Learning
{
    partial class UC_label
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_text.Font = new System.Drawing.Font("Tahoma", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_text.Location = new System.Drawing.Point(0, 0);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(179, 179);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_text.Click += new System.EventHandler(this.lbl_text_Click);
            this.lbl_text.MouseLeave += new System.EventHandler(this.lbl_text_MouseLeave);
            this.lbl_text.MouseHover += new System.EventHandler(this.lbl_text_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 14);
            this.panel1.TabIndex = 1;
            // 
            // UC_label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_text);
            this.Name = "UC_label";
            this.Size = new System.Drawing.Size(179, 179);
            this.Load += new System.EventHandler(this.UC_label_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Panel panel1;
    }
}
