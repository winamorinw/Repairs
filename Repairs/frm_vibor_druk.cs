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
    public partial class frm_vibor_druk : Form
    {

        public string sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt;
        public string sPeriodData1, sPeriodData2, sb_bal_cena, spasport, smdl_crt, spoln_srok, ssrok, szamovnik, sedrpou, sDat_Akta, sDat_Rem1, sDat_Rem2, svikonav, spodrjadchik, sRepID;
        private int god_blank;
        public string kod_ztr;
        public string creditRah;
        public string capitalCena;
        public frm_vibor_druk(string ID, string ZakCx, string ZakUch, string ZakBrig, string ZakDet, string IspCx, string IspUch,
            string IspBrig, string IspDet, string NameOs, string InvNumberOS, string Obekt, string PeriodData1, string PeriodData2,
            string b_bal_cena, string pasport, string mdl_crt, string poln_srok, string srok, string zamovnik, string edrpou, string Dat_Akta, string Dat_Rem1, string Dat_Rem2, string vikonav, string podrjadchik, int godblank, string RepID, string creditRah, string capitalCena)
        {
            

            InitializeComponent();
            sID = ID;
            sZakCx=ZakCx;
            sZakUch=ZakUch;
            sZakBrig=ZakBrig;
            sZakDet=ZakDet;
            sIspCx=IspCx;
            sIspUch=IspUch;
            sIspBrig=IspBrig;
            sIspDet=IspDet;
            sNameOs=NameOs;
            sInvNumberOS=InvNumberOS;
            sObekt=Obekt;
            sPeriodData1=PeriodData1;
            sPeriodData2=PeriodData2;
            sb_bal_cena=b_bal_cena;
            spasport=pasport;
            smdl_crt=mdl_crt;
            spoln_srok=poln_srok;
            ssrok = srok;
            szamovnik=zamovnik;
            sedrpou = edrpou;
            sDat_Akta = Dat_Akta;
            //sDat_Rem1 = PeriodData1;
            //sDat_Rem2 = PeriodData2;
            svikonav = vikonav;
            spodrjadchik = podrjadchik;
            god_blank =godblank;
            sRepID = RepID;

            var dal = new DAL();
            kod_ztr = dal.GetKodZtr(sInvNumberOS);

            this.creditRah = creditRah;
            if(this.creditRah == "")
            {
                kod_ztr = "";
            }
            this.capitalCena = capitalCena;



            if (spodrjadchik == "podrjadchik_yes")
            {
                sDat_Rem1 = sPeriodData1;
                sDat_Rem2 = sPeriodData2;
            }
            else
            {
                DateTime dat = new DateTime(1900, 1, 1);


                sDat_Rem1 = dat.ToShortDateString();
                sDat_Rem2 = dat.ToShortDateString();
            }

            if (god_blank < 2019)
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (god_blank < 2019)
            {

                frmPrintDodatok1_1 frmPrintDodatok1_1 = new frmPrintDodatok1_1(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), szamovnik, sedrpou, sDat_Akta, svikonav, kod_ztr, creditRah, capitalCena);
                frmPrintDodatok1_1.ShowDialog();

                frmPrintDodatok1_2 frmPrintDodatok1_2 = new frmPrintDodatok1_2(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(),sRepID, capitalCena);
                frmPrintDodatok1_2.ShowDialog();

                frmPrintDodatok2_1_a frmPrintDodatok2_1 = new frmPrintDodatok2_1_a(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), szamovnik, sDat_Akta, sDat_Rem1, sDat_Rem2, svikonav);
                frmPrintDodatok2_1.ShowDialog();

                frmPrintDodatok2_2_a frmPrintDodatok2_2 = new frmPrintDodatok2_2_a();
                frmPrintDodatok2_2.ShowDialog();

                frmPrintDodatok3 frmPrintDodatok3 = new frmPrintDodatok3();
                frmPrintDodatok3.ShowDialog();
                this.Close();
            }
            else
            { 
                frmPrintDodatok1_1 frmPrintDodatok1_1 = new frmPrintDodatok1_1(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), szamovnik, sedrpou, sDat_Akta, svikonav, kod_ztr, creditRah, capitalCena);
                frmPrintDodatok1_1.ShowDialog();
                
                frmPrintDodatok1_2 frmPrintDodatok1_2 = new frmPrintDodatok1_2(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(),sRepID, capitalCena);
                frmPrintDodatok1_2.ShowDialog();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (god_blank < 2019)
            {
                frmPrintDodatok4_1_a frmPrintDodatok4_1 = new frmPrintDodatok4_1_a(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), sDat_Rem1.ToString(), sDat_Rem2.ToString(), svikonav, sDat_Akta);
                frmPrintDodatok4_1.ShowDialog();

                frmPrintDodatok4_2_a frmPrintDodatok4_2 = new frmPrintDodatok4_2_a();
                frmPrintDodatok4_2.ShowDialog();

                frmPrintDodatok5 frmPrintDodatok5 = new frmPrintDodatok5();
                frmPrintDodatok5.ShowDialog();
                this.Close();
            }
            else
            {
                frmPrintDodatok4_1_b frmPrintDodatok4_1_b = new frmPrintDodatok4_1_b(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), sDat_Rem1.ToString(), sDat_Rem2.ToString(), svikonav, sDat_Akta);
                frmPrintDodatok4_1_b.ShowDialog();

                frmPrintDodatok4_2_b frmPrintDodatok4_2_b = new frmPrintDodatok4_2_b();
                frmPrintDodatok4_2_b.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm_vibor_druk_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                frmPrintDodatok1_1 frmPrintDodatok1_1 = new frmPrintDodatok1_1(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), szamovnik, sedrpou, sDat_Akta, svikonav, kod_ztr, creditRah, capitalCena);
                frmPrintDodatok1_1.ShowDialog();

                frmPrintDodatok1_2 frmPrintDodatok1_2 = new frmPrintDodatok1_2(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), sRepID, capitalCena);
                frmPrintDodatok1_2.ShowDialog();
  
                frmPrintDodatok2_1_b frmPrintDodatok2_1_b = new frmPrintDodatok2_1_b(sID, sZakCx, sZakUch, sZakBrig, sZakDet, sIspCx, sIspUch, sIspBrig, sIspDet, sNameOs, sInvNumberOS, sObekt, sPeriodData1, sPeriodData2, sb_bal_cena.ToString(), spasport.ToString(), smdl_crt.ToString(), spoln_srok.ToString(), ssrok.ToString(), szamovnik, sDat_Akta, sDat_Rem1, sDat_Rem2, svikonav);
                frmPrintDodatok2_1_b.ShowDialog();

                frmPrintDodatok2_2_b frmPrintDodatok2_2_b = new frmPrintDodatok2_2_b();
                frmPrintDodatok2_2_b.ShowDialog();

            this.Close();

        }
    }
}
