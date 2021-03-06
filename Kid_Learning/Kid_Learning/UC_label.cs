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
        public UC_label()
        {
            InitializeComponent();
        }

        private void UC_label_Load(object sender, EventArgs e)
        {
            lbl_text.Text = str_label;
        }

        private void lbl_text_Click(object sender, EventArgs e)
        {
            string str_link = Application.StartupPath + "\\sounds\\" + str_label + ".wav";
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(str_link);
            //player.SoundLocation = str_link;
            //player.Load();
            //player.PlaySync();

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
