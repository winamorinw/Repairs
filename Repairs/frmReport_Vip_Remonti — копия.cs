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
    public partial class frmReport_Vip_Remonti : Form
    {

        public frmReport_Vip_Remonti(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtpEnd", dtpEnd));
            //this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            //string lusern=usern;
            //string luserp=userp;
            //string ldostup_tmc=dostup_tmc;
            //string lcodcx=codcx;
            //string lcoduth=coduth;
            //string lcodbrig=codbrig;
            //string lcoddet = coddet;
           // MessageBox.Show(lusern+' '+luserp+' '+ldostup_tmc+' '+lcodcx+' '+lcoduth+' '+lcodbrig+' '+lcoddet);
        }

        private void frmReport_Vip_Remonti_Load(object sender, EventArgs e)
        {
            dtpBeg.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string addQuery=" ";
            if (String.Equals(Dostup.Codcx, "0"))
            {
                this.RepairTableAdapter.Fill(this.RepairsDataSet10.Repair, dtpBeg.Value, dtpEnd.Value);
            }
            else
            {
                this.RepairTableAdapter.FillBy(this.RepairsDataSet10.Repair, dtpBeg.Value, dtpEnd.Value,Dostup.Codcx);
            }

            //MessageBox.Show(addQuery);
            
            //this.RepairTableAdapter.Fill(this.RepairsDataSet10.Repair, dtpBeg.Value, dtpEnd.Value);
            string data1 = dtpBeg.Value.ToShortDateString();
            string data2 = dtpEnd.Value.ToShortDateString();
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data1", data1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data2", data2));
            this.reportViewer1.RefreshReport();
        }

        private void RepairBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
