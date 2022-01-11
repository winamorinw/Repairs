using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Repairs
{
    public partial class frmReportHatch : Form
    {
        ReportDataSource Report1;
        public frmReportHatch()
        {
            InitializeComponent();
        }

        private void frmReportHatch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReportHatch". При необходимости она может быть перемещена или удалена.
            this.reportHatchTableAdapter.Fill(this.repairOSDS.ReportHatch);
            Report1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Report1.Name = "DataSet1";
            Report1.Value = repairOSDS.ReportHatch;
            this.reportViewer1.RefreshReport();
        }
    }
}
