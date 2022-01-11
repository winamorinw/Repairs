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
    public partial class frmPrintDodatok2_1_b : Form
    {
        public frmPrintDodatok2_1_b(string ID,string  ZakCx,string  ZakUch,string  ZakBrig,string  ZakDet,string  IspCx,string  IspUch,
            string IspBrig, string IspDet, string NameOs, string InvNumberOS, string Obekt, string PeriodData1, string PeriodData2,
            string b_bal_cena, string pasport, string mdl_crt, string poln_srok, string srok, string zamovnik, string Dat_Akta, string Dat_Rem1, string Dat_Rem2, string vikonav)
        {
            InitializeComponent();

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ID", ID));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakCx", ZakCx));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakUch", ZakUch));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakBrig", ZakBrig));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakDet", ZakDet));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspCx", IspCx));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspUch", IspUch));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspBrig", IspBrig));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspDet", IspDet));


            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NameOs", NameOs));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("InvNumberOS", InvNumberOS));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Obekt", Obekt));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PeriodData1", PeriodData1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PeriodData2", PeriodData2));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("b_bal_cena", b_bal_cena));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pasport", pasport));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mdl_crt", mdl_crt));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("poln_srok", poln_srok));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("srok", srok));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("zamovnik", zamovnik));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Dat_Akta", Dat_Akta));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Dat_Rem1", Dat_Rem1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Dat_Rem2", Dat_Rem2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("vikonav", vikonav));
        }
        


//        b_bal_cena , pasport, mdl_crt, poln_srok, srok


        private void frmPrintDodatok2_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "VedomostResursov.VRVed". При необходимости она может быть перемещена или удалена.
            //this.VRVedTableAdapter.Fill(this.VedomostResursov.VRVed);
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
