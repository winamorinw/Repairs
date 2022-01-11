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
    public partial class ReportPTO_VozvrDetPrint : Form
    {
        public ReportPTO_VozvrDetPrint(int IdPTO)
        {
            InitializeComponent();
            //idPTO = Convert.ToInt32(dgvPTO.CurrentRow.Cells["idPTO"].Value);
            int IddPTO = IdPTO;
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IdPTO",IddPTO.ToString()));
            this.PTOTableAdapter.Fill(this.RepairsDataSet18.PTO, IdPTO);
            this.reportViewer1.RefreshReport();

        }

        private void ReportPTO_VozvrDetPrint_Load(object sender, EventArgs e)
        {
            
//            this.PTOTableAdapter.Fill(this.RepairsDataSet18.PTO,478);
//            this.reportViewer1.RefreshReport();


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
