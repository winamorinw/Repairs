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
    public partial class myfrmPrintForm2 : Form
    {
        public myfrmPrintForm2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void myfrmPrintForm2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "VedomostResursov.VRVed". При необходимости она может быть перемещена или удалена.
            try
            {
                this.VRVedTableAdapter.Fill(this.VedomostResursov.VRVed);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            this.reportViewer1.RefreshReport();
        }
    }
}
