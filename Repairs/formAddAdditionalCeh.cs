using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repairs
{
    public partial class formAddAdditionalCeh : Form
    {
        public formAddAdditionalCeh()
        {
            InitializeComponent();
        }
        public string cex, uch, brig;
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "")
                numericUpDown1.Text = "0";
            if (numericUpDown2.Text == "")
                numericUpDown2.Text = "0";
            if (numericUpDown3.Text == "")
                numericUpDown3.Text = "0";
            cex = numericUpDown1.Text;
            uch = numericUpDown2.Text;
            brig = numericUpDown3.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
