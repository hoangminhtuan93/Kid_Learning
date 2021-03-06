namespace Kid_Learning
{
    partial class frm_Menu
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
            this.btn_alphabet = new System.Windows.Forms.Button();
            this.btn_number = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alphabet
            // 
            this.btn_alphabet.Location = new System.Drawing.Point(99, 74);
            this.btn_alphabet.Name = "btn_alphabet";
            this.btn_alphabet.Size = new System.Drawing.Size(123, 62);
            this.btn_alphabet.TabIndex = 0;
            this.btn_alphabet.Text = "Alphabet";
            this.btn_alphabet.UseVisualStyleBackColor = true;
            this.btn_alphabet.Click += new System.EventHandler(this.btn_alphabet_Click);
            // 
            // btn_number
            // 
            this.btn_number.Location = new System.Drawing.Point(318, 74);
            this.btn_number.Name = "btn_number";
            this.btn_number.Size = new System.Drawing.Size(123, 62);
            this.btn_number.TabIndex = 1;
            this.btn_number.Text = "Number";
            this.btn_number.UseVisualStyleBackColor = true;
            this.btn_number.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 239);
            this.Controls.Add(this.btn_number);
            this.Controls.Add(this.btn_alphabet);
            this.Name = "frm_Menu";
            this.Text = "Kid Learning";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alphabet;
        private System.Windows.Forms.Button btn_number;
    }
}