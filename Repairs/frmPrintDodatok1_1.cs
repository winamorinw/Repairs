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
    public partial class frmPrintDodatok1_1 : Form
    {
        public frmPrintDodatok1_1(string ID, string ZakCx, string ZakUch, string ZakBrig, string ZakDet, string IspCx, string IspUch,
            string IspBrig, string IspDet, string NameOs, string InvNumberOS, string Obekt, string PeriodData1, string PeriodData2,
            string b_bal_cena, string pasport, string mdl_crt, string poln_srok, string srok, string zamovnik, string edrpou, string Dat_Akta, string vikonav,
            string kod_ztr, string creditRah, string capitalCena)
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
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("edrpou", edrpou));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Dat_Akta", Dat_Akta));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("vikonav", vikonav));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("kod_ztr", kod_ztr));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("creditRah", creditRah));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("capitalCena", capitalCena));

        }

        private void frmPrintDodatok1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
