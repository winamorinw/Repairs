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
    public partial class frmPrintAktF2 : Form
    {
        public frmPrintAktF2(string ID,string shpz, double vsegoZP, double sumNalogov, double cexVitrProc, double amortProc, double TZV, string vsegomat,
            string ZakCx, string ZakUch, string ZakBrig, string ZakDet, string IspCx, string IspUch, string  IspBrig, string IspDet,
            string State1,string FIO1,string State2,string FIO2,string State3,string FIO3,string State4,string FIO4,
            string NameOs, string InvNumberOS, string Obekt, string PeriodData1, string PeriodData2, string SumVsego, string FIO5, string State5, double VidrahProc, double TZVGrn, double CexVitrGrn, double AmortGrn,
            double SumVsegoo, string zaversh, string InvNumberOS_Usl, string Obekt_Usl)
        {
            InitializeComponent();

            try
            {
                this.Tmp_JobAKTTableAdapter.Fill(this.repairsDataSet5.Tmp_JobAKT);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                // Не удалось включить ограничения
                //MessageBox.Show("tut");
            }


            //this.Tmp_JobAKTTableAdapter.Fill(this.repairsDataSet5.Tmp_JobAKT);

            //this.Tmp_JobAKTTableAdapter.Fill(this.repairsDataSet8.Tmp_JobAKT);
            DAL dal = new DAL();
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ID", ID));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("shpz", shpz));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("vsegoZP", vsegoZP.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sumNalogov", sumNalogov.ToString()));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cexVitrProc", cexVitrProc.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("amortProc", amortProc.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TZV", TZV.ToString()));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("vsegomat", vsegomat));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakCx", ZakCx));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakUch", ZakUch));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakBrig", ZakBrig));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ZakDet", ZakDet));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspCx", IspCx));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspUch", IspUch));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspBrig", IspBrig));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IspDet", IspDet));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("State1", State1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FIO1", FIO1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("State2", State2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FIO2", FIO2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("State3", State3));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FIO3", FIO3));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("State4", State4));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FIO4", FIO4));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("State5", State5));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FIO5", FIO5));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NameOs", NameOs));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("InvNumberOS", InvNumberOS));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Obekt", Obekt));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PeriodData1", PeriodData1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PeriodData2", PeriodData2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("SumVsego", SumVsego));


            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("VidrahProc", VidrahProc.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TZVGrn", TZVGrn.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CexVitrGrn", CexVitrGrn.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("AmortGrn", AmortGrn.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("SumVsegoo", SumVsegoo.ToString()));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("InvNumberOS_Usl", InvNumberOS_Usl.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Obekt_Usl", Obekt_Usl.ToString()));

            if (zaversh == "")
            { zaversh = "False"; }

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("zaversh", zaversh.ToString()));

            //            VidrahProc, TZVGrn, CexVitrGrn, AmortGrn, SumVsegoo

            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nameOS", nameOS));
            this.reportViewer1.RefreshReport();

        }

        private void frmPrintAktF2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairsDataSet5.Tmp_JobAKT". При необходимости она может быть перемещена или удалена.
            //this.Tmp_JobAKTTableAdapter.Fill(this.repairsDataSet5.Tmp_JobAKT);
            //this.Tmp_JobAKTTableAdapter.Fill(this.repairsDataSet8.Tmp_JobAKT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairsDataSet5.Tmp_JobAKT". При необходимости она может быть перемещена или удалена.
            
            //string Zakazchik_codcx=
            //string Zakazchik_coduth=
            //string Zakazchik_codbrig=
            //string Zakazchik_coddet=

//            string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();

  //          string vsegoZP = dgv_AllVedomostsResursob.CurrentRow.Cells["vsegoZP"].Value.ToString();
            //string sumNalogov = dgv_AllVedomostsResursob.CurrentRow.Cells["sumNalogov"].Value.ToString();
            //string cexVitrProc = dgv_AllVedomostsResursob.CurrentRow.Cells["cexVitrProc"].Value.ToString();
            //string amortProc = dgv_AllVedomostsResursob.CurrentRow.Cells["amortProc"].Value.ToString();
            //string TZV = dgv_AllVedomostsResursob.CurrentRow.Cells["TZV"].Value.ToString();


            //string State1 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg1f2"].Value.ToString();
            //string FIO1 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO1f2"].Value.ToString();
            //string State2 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg2f2"].Value.ToString();
            //string FIO2 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO2f2"].Value.ToString();

            //string State3 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg3f2"].Value.ToString();
            //string FIO3 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO3f2"].Value.ToString();
            //string State4 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg4f2"].Value.ToString();
            //string FIO4 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO4f2"].Value.ToString();

            //string ZakCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_codcx"].Value.ToString();
            //string ZakUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_coduth"].Value.ToString();
           // string ZakBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_codbrig"].Value.ToString();
            //string ZakDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_coddet"].Value.ToString();

            //string IspCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            //string IspUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
            //string IspBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
            //string IspDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();

            //string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
            //string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();
            //string Shpz = dgv_AllVedomostsResursob.CurrentRow.Cells["SHpz"].Value.ToString();
            //string Obekt = dgv_AllVedomostsResursob.CurrentRow.Cells["Obekt"].Value.ToString();
            //string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
            //string PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();



            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("vsegoZP", vsegoZP));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sumNalogov", sumNalogov));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Zakazchik_codbrig", Zakazchik_codbrig));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Zakazchik_coddet", Zakazchik_coddet));
            // this.Tmp_JobAKTTableAdapter.Fill(this.RepairsDataSet5.Tmp_JobAKT);

            //this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.Fill(this.RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF, d1,
            //   d2, ceh, uch, brig, det);
            //this.reportViewer1.RefreshReport();
            //reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }




    }
}
