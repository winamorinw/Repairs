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
    public partial class frmPrintDodatok2_2_a : Form
    {
        public frmPrintDodatok2_2_a()
        {
            InitializeComponent();
        }

        private void frmPrintDodatok2_2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
