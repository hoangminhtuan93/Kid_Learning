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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_alphabet_Click(object sender, EventArgs e)
        {
            frm_Main frm = new frm_Main();
            frm.str_type = "Alphabet";
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btn_number_Click(object sender, EventArgs e)
        {
            frm_Main frm = new frm_Main();
            frm.str_type = "Number";
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
