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
    public partial class frm_print_spis_vedres : Form
    {
        public frm_print_spis_vedres()
        {
            InitializeComponent();
        }

        private void frm_print_spis_vedres_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
