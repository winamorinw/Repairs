using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Repairs
{
    public partial class myfrmProcentsForAKT : Form
    {
        public string remusl;
        string repid;
        public myfrmProcentsForAKT(string ID,string vsegoZP, string sumNalogov, string cexVitrProc,string amortProc,string TZV,
                                 string NameOS,string InvNumber,
                     string FIO1,  string State1, string FIO2, string State2, string FIO3, string State3, string FIO4, string State4,
                    string cx, string uch, string brig, string det, string mes, string god, string FIO5, string State5, string Obekt, string PeriodData2,
             string VidrahProc, string VsegoMat, string TzvGrn, string CehVitrGrn, string AmortGrn, string Vsego_F, string Shpz, string rem_usl,string rep_id, 
            string InvNumber_Usl, string Obekt_Usl, string NameOS_Usl )
        

        {

            InitializeComponent();
            //MessageBox.Show(ID);
            remusl=rem_usl;
            repid = rep_id;


            switch (remusl)
            {
                case "rem":
                    lbl_VedR.Text = ("Відомість ресурсів № ");
                    break;
                case "usl":
                    lbl_VedR.Text = ("Акт(Ф2) №");
                    break;
                default:
                    break;
            }


            this.lbl_inv_usl.Text = InvNumber_Usl;
            this.lbl_inv_nam_usl.Text = NameOS_Usl;
            this.lbl_obekt_usl.Text = Obekt_Usl;


            lbl_ID.Text = ID;
            lbl_Name.Text = NameOS;
            lbl_Inv.Text = InvNumber;
            lbl_mes.Text = mes;
            lbl_god.Text = god;
            lbl_cex.Text = cx;
            lbl_uch.Text = uch;
            lbl_brig.Text = brig;
            lbl_det.Text = det;
            lbl_obekt.Text = Obekt;
            lbl_data2.Text = PeriodData2.ToString();
            lbl_shpz.Text = Shpz;

            txtBx_VsegoZP.Text = vsegoZP.ToString();
            txtBx_SumNalogov.Text = sumNalogov.ToString();
            txtBx_CexVitrProc.Text = cexVitrProc.ToString();
            txtBx_AmortProc.Text = amortProc.ToString();
            txtBx_TZV.Text = TZV.ToString();

            txtBx_VidrahProc.Text = VidrahProc.ToString();
            txtBx_VsegoMat.Text = VsegoMat.ToString();
            txtBx_TZVGrn.Text = TzvGrn.ToString();
            txtBx_CexVitrGrn.Text = CehVitrGrn.ToString();
            txtBx_AmortGrn.Text = AmortGrn.ToString();
            txt_Vsego_F.Text = Vsego_F.ToString();


            DAL dal =new DAL();

            switch (remusl)
            {
                case "rem":
                    cbx_FIO1.DataSource = dal.GetAllFIO1f2(cx, uch, brig, det, "rem");
                        cbx_FIO1.DisplayMember = "fio1f2";
                        cbx_FIO1.ValueMember = "fio1f2";
                        int index_fio1 = cbx_FIO1.FindStringExact(FIO1);
                        cbx_FIO1.SelectedIndex = index_fio1;

                        cbx_FIO2.DataSource = dal.GetAllFIO2f2(cx, uch, brig, det, "rem");
                        cbx_FIO2.DisplayMember = "fio2f2";
                        cbx_FIO2.ValueMember = "fio2f2";
                        int index_fio2 = cbx_FIO2.FindStringExact(FIO2);
                        cbx_FIO2.SelectedIndex = index_fio2;

                        cbx_FIO3.DataSource = dal.GetAllFIO3f2(cx, uch, brig, det, "rem");
                        cbx_FIO3.DisplayMember = "fio3f2";
                        cbx_FIO3.ValueMember = "fio3f2";
                        int index_fio3 = cbx_FIO3.FindStringExact(FIO3);
                        cbx_FIO3.SelectedIndex = index_fio3;

                        cbx_FIO4.DataSource = dal.GetAllFIO4f2(cx, uch, brig, det, "rem");
                        cbx_FIO4.DisplayMember = "fio4f2";
                        cbx_FIO4.ValueMember = "fio4f2";
                        int index_fio4 = cbx_FIO4.FindStringExact(FIO4);
                        cbx_FIO4.SelectedIndex = index_fio4;

                        cbx_FIO5.DataSource = dal.GetAllFIO5f2(cx, uch, brig, det, "rem");
                        cbx_FIO5.DisplayMember = "fio5f2";
                        cbx_FIO5.ValueMember = "fio5f2";
                        int index_fio5 = cbx_FIO5.FindStringExact(FIO5);
                        cbx_FIO5.SelectedIndex = index_fio5;
                        if (String.IsNullOrEmpty(cbx_FIO5.Text))
                            cbx_FIO5.Text = "";

                        cbx_State1.DataSource = dal.GetAllState1f2(cx, uch, brig, det, "rem");
                        cbx_State1.DisplayMember = "dolg1f2";
                        cbx_State1.ValueMember = "dolg1f2";
                        int index_State1 = cbx_State1.FindStringExact(State1);
                        cbx_State1.SelectedIndex = index_State1;

                        cbx_State2.DataSource = dal.GetAllState2f2(cx, uch, brig, det, "rem");
                        cbx_State2.DisplayMember = "dolg2f2";
                        cbx_State2.ValueMember = "dolg2f2";
                        int index_State2 = cbx_State2.FindStringExact(State2);
                        cbx_State2.SelectedIndex = index_State2;

                        cbx_State3.DataSource = dal.GetAllState3f2(cx, uch, brig, det, "rem");
                        cbx_State3.DisplayMember = "dolg3f2";
                        cbx_State3.ValueMember = "dolg3f2";
                        int index_State3 = cbx_State3.FindStringExact(State3);
                        cbx_State3.SelectedIndex = index_State3;

                        cbx_State4.DataSource = dal.GetAllState4f2(cx, uch, brig, det, "rem");
                        cbx_State4.DisplayMember = "dolg4f2";
                        cbx_State4.ValueMember = "dolg4f2";
                        int index_State4 = cbx_State4.FindStringExact(State4);
                        cbx_State4.SelectedIndex = index_State4;


                        cbx_State5.DataSource = dal.GetAllState5f2(cx, uch, brig, det, "rem");
                        cbx_State5.DisplayMember = "dolg5f2";
                        cbx_State5.ValueMember = "dolg5f2";
                        int index_State5 = cbx_State5.FindStringExact(State5);
                        cbx_State5.SelectedIndex = index_State5;

                    break;
                case "usl":
                    lbl_VedR.Text = ("Акт(Ф2) №");
                    cbx_FIO1.DataSource = dal.GetAllFIO1f2(cx, uch, brig, det, "usl");
                        cbx_FIO1.DisplayMember = "fio1f2";
                        cbx_FIO1.ValueMember = "fio1f2";
                        index_fio1 = cbx_FIO1.FindStringExact(FIO1);
                        cbx_FIO1.SelectedIndex = index_fio1;

                        cbx_FIO2.DataSource = dal.GetAllFIO2f2(cx, uch, brig, det, "usl");
                        cbx_FIO2.DisplayMember = "fio2f2";
                        cbx_FIO2.ValueMember = "fio2f2";
                        index_fio2 = cbx_FIO2.FindStringExact(FIO2);
                        cbx_FIO2.SelectedIndex = index_fio2;

                        cbx_FIO3.DataSource = dal.GetAllFIO3f2(cx, uch, brig, det, "usl");
                        cbx_FIO3.DisplayMember = "fio3f2";
                        cbx_FIO3.ValueMember = "fio3f2";
                        index_fio3 = cbx_FIO3.FindStringExact(FIO3);
                        cbx_FIO3.SelectedIndex = index_fio3;

                        cbx_FIO4.DataSource = dal.GetAllFIO4f2(cx, uch, brig, det, "usl");
                        cbx_FIO4.DisplayMember = "fio4f2";
                        cbx_FIO4.ValueMember = "fio4f2";
                        index_fio4 = cbx_FIO4.FindStringExact(FIO4);
                        cbx_FIO4.SelectedIndex = index_fio4;

                        cbx_FIO5.DataSource = dal.GetAllFIO5f2(cx, uch, brig, det, "usl");
                        cbx_FIO5.DisplayMember = "fio5f2";
                        cbx_FIO5.ValueMember = "fio5f2";
                        index_fio5 = cbx_FIO5.FindStringExact(FIO5);
                        cbx_FIO5.SelectedIndex = index_fio5;
                        if (String.IsNullOrEmpty(cbx_FIO5.Text))
                            cbx_FIO5.Text = "";

                        cbx_State1.DataSource = dal.GetAllState1f2(cx, uch, brig, det, "usl");
                        cbx_State1.DisplayMember = "dolg1f2";
                        cbx_State1.ValueMember = "dolg1f2";
                        index_State1 = cbx_State1.FindStringExact(State1);
                        cbx_State1.SelectedIndex = index_State1;

                        cbx_State2.DataSource = dal.GetAllState2f2(cx, uch, brig, det, "usl");
                        cbx_State2.DisplayMember = "dolg2f2";
                        cbx_State2.ValueMember = "dolg2f2";
                        index_State2 = cbx_State2.FindStringExact(State2);
                        cbx_State2.SelectedIndex = index_State2;

                        cbx_State3.DataSource = dal.GetAllState3f2(cx, uch, brig, det, "usl");
                        cbx_State3.DisplayMember = "dolg3f2";
                        cbx_State3.ValueMember = "dolg3f2";
                        index_State3 = cbx_State3.FindStringExact(State3);
                        cbx_State3.SelectedIndex = index_State3;

                        cbx_State4.DataSource = dal.GetAllState4f2(cx, uch, brig, det, "usl");
                        cbx_State4.DisplayMember = "dolg4f2";
                        cbx_State4.ValueMember = "dolg4f2";
                        index_State4 = cbx_State4.FindStringExact(State4);
                        cbx_State4.SelectedIndex = index_State4;


                        cbx_State5.DataSource = dal.GetAllState5f2(cx, uch, brig, det, "usl");
                        cbx_State5.DisplayMember = "dolg5f2";
                        cbx_State5.ValueMember = "dolg5f2";
                        index_State5 = cbx_State5.FindStringExact(State5);
                        cbx_State5.SelectedIndex = index_State5;

                    break;
                default:
                    break;
            }
            
            
            //cbx_FIO1.DataSource = dal.GetAllFIO1f2(cx, uch, brig, det);
            //cbx_FIO1.DisplayMember = "fio1f2";
            //cbx_FIO1.ValueMember = "fio1f2";
            //int index_fio1 = cbx_FIO1.FindStringExact(FIO1);
            //cbx_FIO1.SelectedIndex = index_fio1;

            //cbx_FIO2.DataSource = dal.GetAllFIO2f2(cx, uch, brig, det);
            //cbx_FIO2.DisplayMember = "fio2f2";
            //cbx_FIO2.ValueMember = "fio2f2";
            //int index_fio2 = cbx_FIO2.FindStringExact(FIO2);
            //cbx_FIO2.SelectedIndex = index_fio2;

            //cbx_FIO3.DataSource = dal.GetAllFIO3f2(cx, uch, brig, det);
            //cbx_FIO3.DisplayMember = "fio3f2";
            //cbx_FIO3.ValueMember = "fio3f2";
            //int index_fio3 = cbx_FIO3.FindStringExact(FIO3);
            //cbx_FIO3.SelectedIndex = index_fio3;

            //cbx_FIO4.DataSource = dal.GetAllFIO4f2(cx, uch, brig, det);
            //cbx_FIO4.DisplayMember = "fio4f2";
            //cbx_FIO4.ValueMember = "fio4f2";
            //int index_fio4 = cbx_FIO4.FindStringExact(FIO4);
            //cbx_FIO4.SelectedIndex = index_fio4;

            //cbx_FIO5.DataSource = dal.GetAllFIO5f2(cx, uch, brig, det);
            //cbx_FIO5.DisplayMember = "fio5f2";
            //cbx_FIO5.ValueMember = "fio5f2";
            //int index_fio5 = cbx_FIO5.FindStringExact(FIO5);
            //cbx_FIO5.SelectedIndex = index_fio5;
            //if (String.IsNullOrEmpty(cbx_FIO5.Text))
            //    cbx_FIO5.Text = "";
            
            //cbx_State1.DataSource = dal.GetAllState1f2(cx, uch, brig, det);
            //cbx_State1.DisplayMember = "dolg1f2";
            //cbx_State1.ValueMember = "dolg1f2";
            //int index_State1 = cbx_State1.FindStringExact(State1);
            //cbx_State1.SelectedIndex = index_State1;

            //cbx_State2.DataSource = dal.GetAllState2f2(cx, uch, brig, det);
            //cbx_State2.DisplayMember = "dolg2f2";
            //cbx_State2.ValueMember = "dolg2f2";
            //int index_State2 = cbx_State2.FindStringExact(State2);
            //cbx_State2.SelectedIndex = index_State2;

            //cbx_State3.DataSource = dal.GetAllState3f2(cx, uch, brig, det);
            //cbx_State3.DisplayMember = "dolg3f2";
            //cbx_State3.ValueMember = "dolg3f2";
            //int index_State3 = cbx_State3.FindStringExact(State3);
            //cbx_State3.SelectedIndex = index_State3;

            //cbx_State4.DataSource = dal.GetAllState4f2(cx, uch, brig, det);
            //cbx_State4.DisplayMember = "dolg4f2";
            //cbx_State4.ValueMember = "dolg4f2";
            //int index_State4 = cbx_State4.FindStringExact(State4);
            //cbx_State4.SelectedIndex = index_State4;


            //cbx_State5.DataSource = dal.GetAllState5f2(cx, uch, brig, det);
            //cbx_State5.DisplayMember = "dolg5f2";
            //cbx_State5.ValueMember = "dolg5f2";
            //int index_State5 = cbx_State5.FindStringExact(State5);
            //cbx_State5.SelectedIndex = index_State5;

            if (String.IsNullOrEmpty(cbx_State5.Text))
                cbx_State5.Text = "";


            if (String.IsNullOrEmpty(txtBx_VsegoZP.Text))
                txtBx_VsegoZP.Text = "0,00";
            if (String.IsNullOrEmpty(txtBx_SumNalogov.Text))
                txtBx_SumNalogov.Text = "0,00";
            
            if (String.IsNullOrEmpty(txtBx_CexVitrProc.Text))
                txtBx_CexVitrProc.Text = "0,00";
            else txtBx_CexVitrProc.Text = cexVitrProc.ToString();

            if (String.IsNullOrEmpty(txtBx_AmortProc.Text))
                txtBx_AmortProc.Text = "0,00";
            if (String.IsNullOrEmpty(txtBx_TZV.Text))
                txtBx_TZV.Text = "0,00";


      
        }

        private void myfrmProcentsForAKT_Load(object sender, EventArgs e)
        {
            if ( lbl_Name.Text.Contains("послуг"))
            {
                this.label20.Visible = true;
                this.lbl_inv_usl.Visible = true;
                this.lbl_inv_nam_usl.Visible = true;
                this.lbl_obekt_usl.Visible = true;


                this.button4.Visible = false;
                this.button5.Visible = false;
                this.button6.Visible = false;
                //this.lbl_inv_usl.Text = InvNumber_Usl;
                //this.lbl_inv_nam_usl.Text = NameOS_Usl;
                //this.lbl_obekt_usl.Text = Obekt_Usl;

            }
            else
            {
                this.label20.Visible = false;
                this.lbl_inv_usl.Visible = false;
                this.lbl_inv_nam_usl.Visible = false;
                this.lbl_obekt_usl.Visible = false;

            }
        }





        private void button1_Click(object sender, EventArgs e)
            
        {
            
            //double sum_money=
            //vrved.sum_money
            int ID = Convert.ToInt32(lbl_ID.Text);
            // Высчитываем общую сумму всех материалов 'по ведомости ресурсов по ОС' из табл.ReplacedPart
            DAL dal = new DAL();
            double Sum_mater = 0;
             switch (remusl)
            {
                case "rem":
                      Sum_mater=Math.Round(dal.sum_mater(ID),2);
                      break;
                default:
                      Sum_mater = 0;
                      break;
            }

            double VsegoMat = Sum_mater;
            // eof

            double df9 = Math.Round(VsegoMat,2);
            txtBx_VsegoMat.Text = df9.ToString();

            double VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV;

            if (String.IsNullOrEmpty(txtBx_VsegoZP.Text))
                VsegoZP = 0.00;
            else
            {
                txtBx_VsegoZP.Text = txtBx_VsegoZP.Text.Replace(".", ","); // Замена точки на запятую
                VsegoZP = Convert.ToDouble(txtBx_VsegoZP.Text);
            }


            if (String.IsNullOrEmpty(txtBx_SumNalogov.Text))
                SumNalogov = 0.00;
            else
            {
                txtBx_SumNalogov.Text = txtBx_SumNalogov.Text.Replace(".", ","); // Замена точки на запятую
                SumNalogov = Convert.ToDouble(txtBx_SumNalogov.Text);
            }
            if (String.IsNullOrEmpty(txtBx_CexVitrProc.Text))
                CexVitrProc = 0.00;
            else
            {
                txtBx_CexVitrProc.Text = txtBx_CexVitrProc.Text.Replace(".", ","); // Замена точки на запятую
                CexVitrProc = Convert.ToDouble(txtBx_CexVitrProc.Text);
            }

            if (String.IsNullOrEmpty(txtBx_AmortProc.Text))
                AmortProc = 0.00;
            else
            {
                txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
            }

            if (String.IsNullOrEmpty(txtBx_TZV.Text))
                TZV = 0.00;
            else
            {
                txtBx_TZV.Text = txtBx_TZV.Text.Replace(".", ","); // Замена точки на запятую
                TZV = Convert.ToDouble(txtBx_TZV.Text);
            }


            //double df6 = Math.Round(Convert.ToDouble(txtBx_VsegoZP.Text) * Convert.ToDouble(txtBx_CexVitrProc.Text) / Convert.ToDouble(100),2);
            //double df7 = Math.Round(Convert.ToDouble(txtBx_VsegoZP.Text) * Convert.ToDouble(txtBx_AmortProc.Text) / Convert.ToDouble(100),2);
            //double df1 = Math.Round(Convert.ToDouble(txtBx_SumNalogov.Text) / Convert.ToDouble(txtBx_VsegoZP.Text) * Convert.ToDouble(100),2);
            //double df10 = Math.Round(VsegoMat * Convert.ToDouble(txtBx_TZV.Text) / Convert.ToDouble(100),2);

                double df10 = 0;
                double df1 = 0;
                double df6 = 0;
                double df7 = 0;


            if (lbl_cex.Text == "54")
            {
                df10 = Math.Round(VsegoMat * TZV / 100, 2);
                if (VsegoZP == 0 || VsegoZP == null)
                    df1 = 0;
                else
                    df1 = Math.Round(SumNalogov / VsegoZP * 100, 2);

                df6 = 0;
                df7 = 0;
                

                if (Convert.ToDateTime(lbl_data2.Text).Year < 2018)
                {
                    df6 = Math.Round((VsegoZP + SumNalogov + df9) + Math.Round(df10*CexVitrProc / 100, 2),2);
                    df7 = Math.Round((VsegoZP + SumNalogov + df9) + Math.Round(df10 * AmortProc / 100, 2), 2);
                }
                else
                {
                    df6 = Math.Round(VsegoZP * CexVitrProc / 100, 2);
                    df7 = Math.Round(VsegoZP * AmortProc / 100, 2);
                }


                txtBx_CexVitrGrn.Text = df6.ToString();
                txtBx_AmortGrn.Text = df7.ToString();
                txtBx_VidrahProc.Text = df1.ToString();
                txtBx_TZVGrn.Text = df10.ToString();
                txtBx_TZV.Text = TZV.ToString();

            }
            else
            {
                df6 = Math.Round(VsegoZP * CexVitrProc / 100, 2);
                df7 = Math.Round(VsegoZP * AmortProc / 100, 2);

                if (VsegoZP == 0 || VsegoZP == null)
                    df1 = 0;
                else
                    df1 = Math.Round(SumNalogov / VsegoZP * 100, 2);

                df10 = Math.Round(VsegoMat * TZV / 100, 2);
                txtBx_CexVitrGrn.Text = df6.ToString();
                txtBx_AmortGrn.Text = df7.ToString();
                txtBx_VidrahProc.Text = df1.ToString();
                txtBx_TZVGrn.Text = df10.ToString();

            }

            txt_Vsego_F.Text = (VsegoZP + SumNalogov + VsegoMat + df10 + df6 + df7).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV;
            int err1;
            int ID_VedResursov = Convert.ToInt32(lbl_ID.Text);
          
            if (String.IsNullOrEmpty(txtBx_VsegoZP.Text))
                VsegoZP ="0,00";
            else
            {
                //txtBx_VsegoZP.Text = txtBx_VsegoZP.Text.Replace(".", ","); // Замена точки на запятую
                //VsegoZP = Convert.ToDouble(txtBx_VsegoZP.Text);
                VsegoZP = txtBx_VsegoZP.Text.Replace(".", ",");
            }


            if (String.IsNullOrEmpty(txtBx_SumNalogov.Text))
                SumNalogov = "0,00";
            else
            {
               // txtBx_SumNalogov.Text = txtBx_SumNalogov.Text.Replace(".", ","); // Замена точки на запятую
               // SumNalogov = Convert.ToDouble(txtBx_SumNalogov.Text);
                SumNalogov = txtBx_SumNalogov.Text.Replace(".", ","); // Замена точки на запятую
            }
            if (String.IsNullOrEmpty(txtBx_CexVitrProc.Text))
                CexVitrProc = "0,00";
            else
            {
              //  txtBx_CexVitrProc.Text = txtBx_CexVitrProc.Text.Replace(".", ","); // Замена точки на запятую
              // CexVitrProc = Convert.ToDouble(txtBx_CexVitrProc.Text);
                CexVitrProc = txtBx_CexVitrProc.Text.Replace(".", ","); // Замена точки на запятую
            }

            if (String.IsNullOrEmpty(txtBx_AmortProc.Text))
                AmortProc ="0,00";
            else
            {
                //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                //AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
                AmortProc = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
            }
            if (String.IsNullOrEmpty(txtBx_TZV.Text))
                TZV = "0,00";
            else
            {
                //txtBx_TZV.Text = txtBx_TZV.Text.Replace(".", ","); // Замена точки на запятую
                //TZV = Convert.ToDouble(txtBx_TZV.Text);
                TZV = txtBx_TZV.Text.Replace(".", ","); // Замена точки на запятую
            }


     
            
            string VidrahProc = "0,00";
            string VsegoMat = "0,00";
            string TzvGrn = "0,00";
            string CehVitrGrn = "0,00";
            string AmortGrn = "0,00";
            string Vsego_F = "0,00";
            if (String.IsNullOrEmpty(txtBx_VidrahProc.Text))
                VidrahProc = "0,00";
            else
            {
                //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                //AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
                VidrahProc = txtBx_VidrahProc.Text.Replace(".", ","); // Замена точки на запятую
            }
            if (String.IsNullOrEmpty(txtBx_VsegoMat.Text))
                VsegoMat = "0,00";
            else
            {
                //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                //AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
                VsegoMat = txtBx_VsegoMat.Text.Replace(".", ","); // Замена точки на запятую
            }

            if (String.IsNullOrEmpty(txtBx_TZVGrn.Text))
                TzvGrn = "0,00";
            else
            {
                //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                //AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
                TzvGrn = txtBx_TZVGrn.Text.Replace(".", ","); // Замена точки на запятую
            }
            if (String.IsNullOrEmpty(txtBx_CexVitrGrn.Text))
                CehVitrGrn = "0,00";
            else
            {
                //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                //AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
                CehVitrGrn = txtBx_CexVitrGrn.Text.Replace(".", ","); // Замена точки на запятую
            }
            if (String.IsNullOrEmpty(txtBx_AmortGrn.Text))
                AmortGrn = "0,00";
            else
            {
                //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                //AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
                AmortGrn = txtBx_AmortGrn.Text.Replace(".", ","); // Замена точки на запятую
            }
            if (String.IsNullOrEmpty(txt_Vsego_F.Text))
                Vsego_F = "0,00";
            else
            {
                //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                //AmortProc = Convert.ToDouble(txtBx_AmortProc.Text);
                Vsego_F = txt_Vsego_F.Text.Replace(".", ","); // Замена точки на запятую
            }


            VsegoZP = VsegoZP.Replace(",", ".");
            SumNalogov =SumNalogov.Replace(",", ".");
            CexVitrProc =CexVitrProc.Replace(",", ".");
            AmortProc =AmortProc.Replace(",", ".");
            TZV = TZV.Replace(",", ".");

            VidrahProc = VidrahProc.Replace(",", ".");
            VsegoMat = VsegoMat.Replace(",", ".");
            TzvGrn = TzvGrn.Replace(",", ".");
            CehVitrGrn = CehVitrGrn.Replace(",", ".");
            AmortGrn = AmortGrn.Replace(",", ".");
            Vsego_F = Vsego_F.Replace(",", ".");

            if (remusl == "rem")
            {


                DAL dal = new DAL();
                //textBox1.Text=dal.UpdateVedRWithProc2(ID_VedResursov, VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV);

                if (dal.UpdateVedRWithProc(ID_VedResursov, VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV, remusl) == true)
                {
                    MessageBox.Show("Інформацію по процентам(1) Збережено.");
                    //this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Помилка в збережені(1) процентів.");
                    //this.DialogResult = DialogResult.Cancel;
                }


                if (dal.UpdateVedRWithProc2(ID_VedResursov, VidrahProc, VsegoMat, TzvGrn, CehVitrGrn, AmortGrn, Vsego_F, remusl) == true)
                {
                    MessageBox.Show("Інформацію по процентам(2) Збережено.");
                    //this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Помилка в збережені(2) процентів.");
                    //this.DialogResult = DialogResult.Cancel;
                }

                string FF5;
                string dd5;
                if ((cbx_FIO5.Text.Trim() == "") || (cbx_FIO5.Text.Trim() == null))
                    FF5 = "";
                else
                    FF5 = cbx_FIO5.Text.Trim();

                if ((cbx_State5.Text.Trim() == "") || (cbx_State5.Text.Trim() == null))
                    dd5 = "";
                else
                    dd5 = cbx_State5.Text.Trim();


                //+++            if (dal.UpdateAKT_Form2(cbx_FIO1.Text.Trim(), cbx_FIO2.Text.Trim(),  cbx_FIO3.Text.Trim(), cbx_FIO4.Text.Trim(),
                //+++                cbx_State1.Text.Trim(), cbx_State2.Text.Trim(), cbx_State3.Text.Trim(), cbx_State4.Text.Trim(), cbx_FIO5.Text.Trim(), cbx_State5.Text.Trim(), lbl_ID.Text) == true)
                if (dal.UpdateAKT_Form2(cbx_FIO1.Text.Trim(), cbx_FIO2.Text.Trim(), cbx_FIO3.Text.Trim(), cbx_FIO4.Text.Trim(),cbx_State1.Text.Trim(), cbx_State2.Text.Trim(), cbx_State3.Text.Trim(), cbx_State4.Text.Trim(), FF5, dd5, lbl_ID.Text, remusl.ToString()) == true)
                {
                    MessageBox.Show("Підписи оновлені");
                    //this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Помилка оновлення підписів!");
                    //this.DialogResult = DialogResult.Cancel;

                }

                this.Close();
            }

            if (remusl == "usl")
            {

                MessageBox.Show("Ще не працює");
                DAL dal = new DAL();
                //textBox1.Text=dal.UpdateVedRWithProc2(ID_VedResursov, VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV);

                if (dal.UpdateVedRWithProc(ID_VedResursov, VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV, remusl) == true)
                {
                    MessageBox.Show("Інформацію по процентам(1) Збережено.");
                    //this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Помилка в збережені(1) процентів.");
                    //this.DialogResult = DialogResult.Cancel;
                }


                if (dal.UpdateVedRWithProc2(ID_VedResursov, VidrahProc, VsegoMat, TzvGrn, CehVitrGrn, AmortGrn, Vsego_F, remusl) == true)
                {
                    MessageBox.Show("Інформацію по процентам(2) Збережено.");
                    //this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Помилка в збережені(2) процентів.");
                    //this.DialogResult = DialogResult.Cancel;
                }

                string FF5;
                string dd5;
                if ((cbx_FIO5.Text.Trim() == "") || (cbx_FIO5.Text.Trim() == null))
                    FF5 = "";
                else
                    FF5 = cbx_FIO5.Text.Trim();

                if ((cbx_State5.Text.Trim() == "") || (cbx_State5.Text.Trim() == null))
                    dd5 = "";
                else
                    dd5 = cbx_State5.Text.Trim();


                //+++            if (dal.UpdateAKT_Form2(cbx_FIO1.Text.Trim(), cbx_FIO2.Text.Trim(),  cbx_FIO3.Text.Trim(), cbx_FIO4.Text.Trim(),
                //+++                cbx_State1.Text.Trim(), cbx_State2.Text.Trim(), cbx_State3.Text.Trim(), cbx_State4.Text.Trim(), cbx_FIO5.Text.Trim(), cbx_State5.Text.Trim(), lbl_ID.Text) == true)
                if (dal.UpdateAKT_Form2(cbx_FIO1.Text.Trim(), cbx_FIO2.Text.Trim(), cbx_FIO3.Text.Trim(), cbx_FIO4.Text.Trim(), cbx_State1.Text.Trim(), cbx_State2.Text.Trim(), cbx_State3.Text.Trim(), cbx_State4.Text.Trim(), FF5, dd5, lbl_ID.Text, remusl.ToString()) == true)
                {
                    MessageBox.Show("Підписи оновлені");
                    //this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Помилка оновлення підписів!");
                    //this.DialogResult = DialogResult.Cancel;

                }

                this.Close();
            }

        }


        
        private void txtBx_CexVitrProc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myfrmPrintForm2 myfrmPrintForm2 = new myfrmPrintForm2();
            myfrmPrintForm2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //lbl_mes.Text.ToString() - mes
            //lbl_god.Text.ToString()) - god
            DAL_DBF dal_dbf = new DAL_DBF();

            string mes, god, inv, cx, uch, brig, det, obekt, shpz;
            mes = lbl_mes.Text.ToString();
            //string mes = "02";
            god = lbl_god.Text.ToString();
            cx = lbl_cex.Text.ToString();
            uch = lbl_uch.Text.ToString();
            brig = lbl_brig.Text.ToString();
            det = lbl_det.Text.ToString();
            shpz = lbl_shpz.Text.ToString();

            if (lbl_Name.Text.Contains("послуг") && lbl_inv_usl.Text.Length>1)
            {
                inv = lbl_inv_usl.Text.ToString();
                obekt = lbl_obekt_usl.Text.ToString();

            }
            else
            {
                 inv = lbl_Inv.Text.ToString();
                 obekt = lbl_obekt.Text.ToString();
            }
            dgv_ZP.DataSource = dal_dbf.GetZP(mes, god, inv,cx,uch,brig,obekt,shpz);
            if (dgv_ZP.RowCount > 0)
            {
                double ssumZP=0.00;
                double ssumNalogov=0.00;
                for (int i = 0; i < dgv_ZP.RowCount; i++)
                {
                    string Kt = dgv_ZP.Rows[i].Cells["Kt"].Value.ToString();
                    string Kt2 = Kt.Substring(0, 2);
                    
                    if (Kt2=="66") // подсчитываем ЗП
                    {
                        ssumZP = ssumZP + Convert.ToDouble(dgv_ZP.Rows[i].Cells["Sum"].Value);
                    }
                    
                    if (Kt2 == "65") // подсчитываем отчисления
                    {
                        ssumNalogov = ssumNalogov + Convert.ToDouble(dgv_ZP.Rows[i].Cells["Sum"].Value);
                    }

                }
               
                txtBx_VsegoZP.Text = ssumZP.ToString();
                txtBx_SumNalogov.Text = ssumNalogov.ToString();
                //VsegoZP = Convert.ToDouble(txtBx_VsegoZP.Text);
            }
            else
            {
                MessageBox.Show("Не знайдено.");
            }

            
           
            // dgv_ZP.DataSource = dal_dbf.GetAllTMC();
            //string VsegoZP = dal_dbf.GetZP(mes,god, inv);
            //string SumNalogov = "0";
           // F:\BUX\1C_Exch\dbf\zp.....(mes(01...12),god(2016)).dbf
          //  Зарплата  SUM sum to a FOR alltrim(inno)='90135' AND  substr(kt,1,2)='65'
          //  Відрахування  SUM sum to a FOR alltrim(inno)='90135' AND  substr(kt,1,2)='61'
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mes = lbl_mes.Text.ToString();
            //string mes = "02";
            string god = lbl_god.Text.ToString();
            string inv = lbl_Inv.Text.ToString();
            string cx = lbl_cex.Text.ToString();
            string uch = lbl_uch.Text.ToString();
            string brig = lbl_brig.Text.ToString();
            string det = lbl_det.Text.ToString();
            
            string CexVitrProc = txtBx_CexVitrProc.Text.ToString();
            if (String.IsNullOrEmpty(txtBx_CexVitrProc.Text))
                CexVitrProc = "0,00";
            else
            {
                CexVitrProc = txtBx_CexVitrProc.Text.Replace(".", ","); // Замена точки на запятую
            }
            CexVitrProc = CexVitrProc.Replace(",", ".");

            DAL DAL = new DAL();
            DialogResult res = MessageBox.Show("Дійсно замінити цехові витрати по всіх ОЗ по МВО " + cx.ToString() + "." + uch.ToString() + "." + brig.ToString() + "." + det.ToString() + " за " + mes.ToString() +
                "-ий місяць " + god.ToString() + " рік", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
              //  MessageBox.Show("Yes");
                if (DAL.UpdateVedResAKTCexVitrProc(CexVitrProc, god, mes, cx, uch, brig, det) == true)
                {
                    MessageBox.Show("Цехові витрати замінено!");
                }
                else
                {
                    MessageBox.Show("Помилка заміни Цехових витрат!");
                }

            }
            else
            {
                MessageBox.Show("No");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                string mes = lbl_mes.Text.ToString();
                string god = lbl_god.Text.ToString();
                string inv = lbl_Inv.Text.ToString();
                string cx = lbl_cex.Text.ToString();
                string uch = lbl_uch.Text.ToString();
                string brig = lbl_brig.Text.ToString();
                string det = lbl_det.Text.ToString();

                string amortProc = txtBx_AmortProc.Text.ToString();
                if (String.IsNullOrEmpty(txtBx_AmortProc.Text))
                    amortProc = "0,00";
                else
                {
                    amortProc = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                }
                amortProc = amortProc.Replace(",", ".");


                txtBx_AmortProc.Text = amortProc.ToString();
            
            
                DAL DAL = new DAL();
                DialogResult res = MessageBox.Show("Дійсно замінити Амортизацію по всіх ОЗ по МВО " + cx.ToString() + "." + uch.ToString() + "." + brig.ToString() + "." + det.ToString() + " за " + mes.ToString() +
                    "-ий місяць " + god.ToString() + " рік", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //  MessageBox.Show("Yes");
                    if (DAL.UpdateVedResAKTamortProc(amortProc, god, mes, cx, uch, brig, det) == true)
                    {
                        MessageBox.Show("Амортизацію замінено!");
                    }
                    else
                    {
                        MessageBox.Show("Помилка заміни Амортизації!");
                    }

                }
                else
                {
                    MessageBox.Show("No");
                }


            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mes = lbl_mes.Text.ToString();
            string god = lbl_god.Text.ToString();
            string inv = lbl_Inv.Text.ToString();
            string cx = lbl_cex.Text.ToString();
            string uch = lbl_uch.Text.ToString();
            string brig = lbl_brig.Text.ToString();
            string det = lbl_det.Text.ToString();

            //txtBx_TZV.Text = TZV.ToString();
            string TZV = txtBx_TZV.Text.ToString();
            if (String.IsNullOrEmpty(txtBx_TZV.Text))
                TZV = "0,00";
            else
            {
                TZV = txtBx_TZV.Text.Replace(".", ","); // Замена точки на запятую
            }
            TZV = TZV.Replace(",", ".");


            txtBx_TZV.Text = TZV.ToString();


            DAL DAL = new DAL();
            DialogResult res = MessageBox.Show("Дійсно замінити ТЗВ по всіх ОЗ по МВО " + cx.ToString() + "." + uch.ToString() + "." + brig.ToString() + "." + det.ToString() + " за " + mes.ToString() +
                "-ий місяць " + god.ToString() + " рік", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //  MessageBox.Show("Yes");
                if (DAL.UpdateVedResAKTTZV(TZV, god, mes, cx, uch, brig, det) == true)
                {
                    MessageBox.Show("ТЗВ замінено!");
                }
                else
                {
                    MessageBox.Show("Помилка заміни TЗВ!");
                }

            }
            else
            {
                MessageBox.Show("No");
            }

        }


        private string Found_fio_or_dolg(string REPID,string NAMPOLE)
        {
            string constr = Properties.Settings.Default.RepairOSConnStr;
            SqlConnection SqlCon = new SqlConnection(constr);
            //string my_result = "";
            SqlCommand com = new SqlCommand("SELECT " +NAMPOLE+ " FROM [Repairs].[dbo].[PodpisiForAktF2] where RepairID= @R_ID", SqlCon);
            com.Parameters.Add("@R_ID", SqlDbType.NVarChar).Value = REPID;
            //com.Parameters.Add("@nampole", SqlDbType.NVarChar).Value = NAMPOLE;
            SqlCon.Open();
            object ress = com.ExecuteScalar();
            SqlCon.Close();
            string my_result = "";
            if (ress == null)
                my_result = "";
            else
                my_result = ress.ToString();
            return my_result;
        }


   

        private void button7_Click(object sender, EventArgs e)
        {
             DialogResult res = MessageBox.Show("Дійсно перетянути підписи  ", "Оновлення інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
     
                //string constr = Properties.Settings.Default.RepairOSConnStr;
                //SqlConnection SqlCon = new SqlConnection(constr);
               
                //SqlCommand com = new SqlCommand("SELECT FIO1f2 FROM [Repairs].[dbo].[PodpisiForAktF2] where RepairID= @R_ID", SqlCon);
                //com.Parameters.Add("@R_ID", SqlDbType.NVarChar).Value =repid;
                //SqlCon.Open();
                //object resFIO1f2 = com.ExecuteScalar();
                //SqlCon.Close();
                //if (resFIO1f2 == null)
                //    cbx_FIO1.Text = "";
                //else
                //   cbx_FIO1.Text = resFIO1f2.ToString();

                cbx_FIO1.Text = Found_fio_or_dolg(repid, "FIO1f2");
                cbx_FIO2.Text = Found_fio_or_dolg(repid, "FIO2f2");
                cbx_FIO3.Text = Found_fio_or_dolg(repid, "FIO3f2");
                cbx_FIO4.Text = Found_fio_or_dolg(repid, "FIO4f2");
                cbx_FIO5.Text = Found_fio_or_dolg(repid, "FIO5f2");

                cbx_State1.Text = Found_fio_or_dolg(repid, "dolg1f2");
                cbx_State2.Text = Found_fio_or_dolg(repid, "dolg2f2");
                cbx_State3.Text = Found_fio_or_dolg(repid, "dolg3f2");
                cbx_State4.Text = Found_fio_or_dolg(repid, "dolg4f2");
                cbx_State5.Text = Found_fio_or_dolg(repid, "dolg5f2");

               }

        }
        
    }
}
