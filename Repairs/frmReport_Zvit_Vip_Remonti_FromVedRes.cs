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
    public partial class frmReport_Zvit_Vip_Remonti_FromVedRes : Form
    {
        public frmReport_Zvit_Vip_Remonti_FromVedRes(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();
        }

        private void frmReport_Zvit_Vip_Remonti_FromVedRes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RDSet12.Vedomost_Resursov". При необходимости она может быть перемещена или удалена.
            dtpBeg.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string addQuery = " ";
            if (String.Equals(Dostup.Codcx, "0"))
            {
                //this.RepairTableAdapter.Fill(this.RepairsDataSet10.Repair, dtpBeg.Value, dtpEnd.Value);
                try
                {

                    this.Vedomost_ResursovTableAdapter.Fill(this.RDSet12.Vedomost_Resursov, dtpBeg.Value, dtpEnd.Value);
                }
                catch { }
            }
            else
            {
                //this.RepairTableAdapter.FillBy(this.RepairsDataSet10.Repair, dtpBeg.Value, dtpEnd.Value, Dostup.Codcx);
                try
                {
                    this.Vedomost_ResursovTableAdapter.FillBy(this.RDSet12.Vedomost_Resursov, dtpBeg.Value, dtpEnd.Value, Dostup.Codcx);
                }
                catch { }

            }
            //this.Vedomost_ResursovTableAdapter.Fill(this.RDSet12.Vedomost_Resursov,dtpBeg.Value,dtpEnd.Value);
            string data1 = dtpBeg.Value.ToShortDateString();
            string data2 = dtpEnd.Value.ToShortDateString();
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data1", data1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data2", data2));
            this.reportViewer1.RefreshReport();

        }
    }
}
