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
    public partial class frmParts : Form
    {
        public frmParts()
        {
            InitializeComponent();
        }

    

        private void frmParts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefPart". При необходимости она может быть перемещена или удалена.
            this.refPartTableAdapter.Fill(this.repairOSDS.RefPart);
           

        }
    }
}
