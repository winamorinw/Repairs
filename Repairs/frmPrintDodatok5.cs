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
    public partial class frmPrintDodatok5 : Form
    {
        public frmPrintDodatok5()
        {
            InitializeComponent();
        }

        private void frmPrintDodatok5_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
