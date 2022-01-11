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
    public partial class myfrmReport_ActBuOprihod : Form
    {
        public myfrmReport_ActBuOprihod()
        {
            InitializeComponent();
        }

        private void myfrmReport_ActBuOprihod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ActOprihodBU.Report_Acts". При необходимости она может быть перемещена или удалена.
            this.Report_ActsTableAdapter.Fill(this.ActOprihodBU.Report_Acts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ActOprihodBU.Report_B_U_Form_ACT". При необходимости она может быть перемещена или удалена.
            this.Report_B_U_Form_ACTTableAdapter.Fill(this.ActOprihodBU.Report_B_U_Form_ACT);
            rptv_BUAct.LocalReport.ReportEmbeddedResource = "Repairs.Report_OprihodAct_BU.rdlc";
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Report_B_U_Form_ACTTableAdapter.Fill(this.ActOprihodBU.Report_B_U_Form_ACT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
