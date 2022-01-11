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
    public partial class frmPrintDodatok1_2 : Form
    {

        private string ID, ZakCx, ZakUch, ZakBrig,ZakDet,  IspCx,  IspUch, IspBrig,  IspDet, NameOs, InvNumberOS;
        private string Obekt, PeriodData1, PeriodData2, b_bal_cena, pasport, mdl_crt, poln_srok, srok, RepID;
        private string capitalCena;

        public frmPrintDodatok1_2(string s_ID, string s_ZakCx, string s_ZakUch, string s_ZakBrig, string s_ZakDet, string s_IspCx, string s_IspUch,
            string s_IspBrig, string s_IspDet, string s_NameOs, string s_InvNumberOS, string s_Obekt, string s_PeriodData1, string s_PeriodData2,
            string s_b_bal_cena, string s_pasport, string s_mdl_crt, string s_poln_srok, string s_srok, string s_RepID, string capitalCena)
        {
            InitializeComponent();
            RepID = s_RepID;
            ID = s_ID;
            ZakCx= s_ZakCx;
            ZakUch = s_ZakUch;
            ZakBrig = s_ZakBrig;
            ZakDet = s_ZakDet;
            IspCx = s_IspCx;
            IspUch = s_IspUch;
            IspBrig = s_IspBrig;
            IspDet = s_IspDet;
            NameOs = s_NameOs;
            InvNumberOS = s_InvNumberOS;
            Obekt = s_Obekt;
            PeriodData1 = s_PeriodData1;
            PeriodData2 = s_PeriodData2;
            b_bal_cena = s_b_bal_cena;
            pasport = s_pasport;
            mdl_crt = s_mdl_crt;
            poln_srok = s_poln_srok;
            srok = s_srok;
            RepID= s_RepID;
            this.capitalCena = capitalCena;
           try
            {
                this.Jobs_FromAktF2_for_dodatok_1_2TableAdapter.Fill(RepairsDataSet5.Jobs_FromAktF2_for_dodatok_1_2, Convert.ToInt32(RepID));
                int count = jobs_FromAktF2_for_dodatok_1_2_kolTableAdapter1.GetData(Convert.ToInt32(RepID))[0].Column1;
               if(count!=0)
                {
                    this.Jobs_FromAktF2_for_dodatok_1_2TableAdapter.FillByTitle(RepairsDataSet5.Jobs_FromAktF2_for_dodatok_1_2, Convert.ToInt32(RepID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("capitalCena", capitalCena));
            this.reportViewer1.RefreshReport();
        }
     }
}



    
