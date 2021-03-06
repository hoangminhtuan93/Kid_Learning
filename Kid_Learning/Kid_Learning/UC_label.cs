using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kid_Learning
{
    public partial class UC_label : UserControl
    {
        public string str_label = string.Empty;
        public string str_type = string.Empty;
        public UC_label()
        {
            InitializeComponent();
        }

        private void UC_label_Load(object sender, EventArgs e)
        {
            lbl_text.Text = str_label;

            if (str_type == "Alphabet")
            {
                lbl_text.Font = new Font("Tahoma", 85, FontStyle.Bold);
            }
            else if (str_type == "Number")
            {
                lbl_text.Font = new Font("Tahoma", 70, FontStyle.Bold);
            }
            else
            {

            }
        }

        private void lbl_text_Click(object sender, EventArgs e)
        {
            string str_link = string.Empty;
            if (str_type == "Alphabet")
            {
                str_link = Application.StartupPath + "\\sounds\\" + str_label + ".wav";
            }
            else if (str_type == "Number")
            {
                str_link = Application.StartupPath + "\\sounds\\" + str_label + ".mp3";
            }
            else
            {

            }

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = str_link;
            wplayer.controls.play();
        }

        private void lbl_text_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void lbl_text_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
