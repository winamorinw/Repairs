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
    public partial class frm_ZvitNabrSum : Form
    {
        public frm_ZvitNabrSum(string RDivision)
        {
            
            InitializeComponent();
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("RDivision", RDivision));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NameDet", NameDet));            
            //this.RepairTableAdapter.Fill(this.RepairsDataSet7.Repair);
            this.reportViewer1.RefreshReport();
            int nRDivision;
            nRDivision = Convert.ToInt32(RDivision);
            this.RepairTableAdapter.FillBy(this.repairsDataSet7.Repair, nRDivision);
            

        }

        private void frm_ZvitNabrSum_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairsDataSet7.Repair". При необходимости она может быть перемещена или удалена.
            //this.RepairTableAdapter.FillBy(this.repairsDataSet7.Repair,);
          
        }
    }
}
