using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kid_Learning
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        public string[] arr_alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string[] arr_nummber = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public string str_type = string.Empty;
        private void frm_Main_Load(object sender, EventArgs e)
        {
            tbLP_modify();
        }

        private void tbLP_modify()
        {
            UC_label cell_tbLP;
            int int_cell = 0;
            if (str_type == "Alphabet")
            {
                int_cell = arr_alphabet.Count();
            }
            else if (str_type == "Number")
            {
                int_cell = arr_nummber.Count();
            }
            else
            {

            }

            for (int i = 0; i < int_cell; i++)
            {
                cell_tbLP = new UC_label();
                cell_tbLP.str_type = str_type;
                if (str_type == "Alphabet")
                {
                    cell_tbLP.str_label = arr_alphabet[i];
                }
                else if (str_type == "Number")
                {
                    cell_tbLP.str_label = arr_nummber[i];
                }
                else
                {

                }
                tbLP_main.Controls.Add(cell_tbLP);
            }
        }

        private void btn_read_all_Click(object sender, EventArgs e)
        {
            string str_link = string.Empty;
            int int_cell = 0;
            if (str_type == "Alphabet")
            {
                int_cell = arr_alphabet.Count();
                this.Text = "Learning Number";
            }
            else if (str_type == "Number")
            {
                int_cell = arr_nummber.Count();
                this.Text = "Learning Number";
            }
            else
            {

            }
            for (int i = 0; i < int_cell; i++)
            {
                this.tbLP_main.GetControlFromPosition(i % 7, i / 7).BackColor = Color.Red;

                if (str_type == "Alphabet")
                {
                    str_link = Application.StartupPath + "\\sounds\\" + arr_alphabet[i] + ".wav";
                }
                else if (str_type == "Number")
                {
                    str_link = Application.StartupPath + "\\sounds\\" + arr_nummber[i] + ".mp3";
                }
                else
                {

                }

                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = str_link;
                wplayer.controls.play();
                wait(1500);
                this.tbLP_main.GetControlFromPosition(i % 7, i / 7).BackColor = Color.Transparent;
            }
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
