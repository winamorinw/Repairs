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
    public partial class myfrmAllAkt : Form

    {

        DAL dal = new DAL();
        private string tek_mes, tek_god;
        public delegate void FFF();
        public event FFF FF;
        public delegate void FFFf();
        public event FFFf FFf;
        public string PeriodData2_1, PeriodData2_2;
        public bool all_ceh;
        public string VIBRAN_CEH;
        double vsegoZP = 0;
        double sumNalogov = 0;
        double cexVitrProc = 0;
        double amortProc = 0;
        double TZV = 0;
        double Sum_mater = 0;
        public string remusl="";

        public myfrmAllAkt(string tekmes, string tekgod, string Data2_1, string Data2_2, bool all, string ceh, string rem_usl)
        {
            remusl = rem_usl;
            InitializeComponent();
            //dejstvie = "";
            tek_mes = tekmes.ToString();
            tek_god = tekgod.ToString();
            //string Period_god2_1 = Data2_1.Substring(0,4);
            //string Period_mes2_1 = Data2_1.Substring(4, 2);
            //string Period_day2_1 = Data2_1.Substring(6, 2);
            PeriodData2_1 = Data2_1;
            PeriodData2_2 = Data2_2;

            string Period_god2_1 = Data2_1.Substring(0, 4);
            string Period_mes2_1 = Data2_1.Substring(4, 2);
            string Period_day2_1 = Data2_1.Substring(6, 2);

            string Period_god2_2 = Data2_2.Substring(0, 4);
            string Period_mes2_2 = Data2_2.Substring(4, 2);
            string Period_day2_2 = Data2_2.Substring(6, 2);

            //bool all_ceh = all;
            all_ceh = all;

            VIBRAN_CEH = ceh;

            if (Change_ceh.ALL)
            {
                button1.Visible = false;
                btn_DrukAktF2.Visible = false;
                btn_procenti_akt.Visible = false;
                btn_UpdateShpz.Visible = false;
            }
            else
            {
                button1.Visible = true;
                btn_DrukAktF2.Visible = true;
                btn_procenti_akt.Visible = true;
                btn_UpdateShpz.Visible = true;

            }
            //this.Text = "Відомості ресурсів за період з " + PeriodData2_1.ToString() + " по " + PeriodData2_2.ToString();
            this.Text = "Акти по послугам за період з " + Period_day2_1.ToString() + "." + Period_mes2_1.ToString() + "." + Period_god2_1.ToString() + "p. " + " по " + Period_day2_2.ToString() + "." + Period_mes2_2.ToString() + "." + Period_god2_2.ToString();


        }

        private void myfrmAllAkt_Load(object sender, EventArgs e)
        {
            FFf();
            dgv_os_usl.DataSource = dal.GetAllAktsUsl(PeriodData2_1, PeriodData2_2);
            SettingsAllAktUsl();


            FF();
        }

      

        private void SettingsAllAktUsl()
        {
            if (dgv_os_usl.RowCount > 0)
            {

                dgv_os_usl.Columns["Id"].Visible = true;
                dgv_os_usl.Columns["InventoryNamber"].Visible = true;
                dgv_os_usl.Columns["NameOS"].Visible = true;
                dgv_os_usl.Columns["obekt"].Visible = true;
                dgv_os_usl.Columns["PeriodData1"].Visible = true;
                dgv_os_usl.Columns["PeriodData2"].Visible = true;
                dgv_os_usl.Columns["Ispolnitel_codcx"].Visible = true;
                dgv_os_usl.Columns["Ispolnitel_coduth"].Visible = true;
                dgv_os_usl.Columns["Ispolnitel_codbrig"].Visible = true;
                dgv_os_usl.Columns["Ispolnitel_coddet"].Visible = true;
                dgv_os_usl.Columns["Ispolnitel_name"].Visible = true;
                dgv_os_usl.Columns["Zakazchik_codcx"].Visible = true;
                dgv_os_usl.Columns["Shpz"].Visible = true;


              //  dgv_os_usl.Columns["Inv_usl"].Visible = true;
//                dgv_os_usl.Columns["Obekt_usl"].Visible = true;
       //         dgv_os_usl.Columns["name_inv_usl"].Visible = true;

                dgv_os_usl.Columns["RepairID"].Visible = false;
                dgv_os_usl.Columns["Zakazchik_coduth"].Visible = false;
                dgv_os_usl.Columns["Zakazchik_codbrig"].Visible = false;
                dgv_os_usl.Columns["Zakazchik_coddet"].Visible = false;
                dgv_os_usl.Columns["VedomostNumber"].Visible = false;
                dgv_os_usl.Columns["Original"].Visible = false;

                dgv_os_usl.Columns["dolg1"].Visible = false;
                dgv_os_usl.Columns["FIO1"].Visible = false;
                dgv_os_usl.Columns["dolg2"].Visible = false;
                dgv_os_usl.Columns["FIO2"].Visible = false;
                dgv_os_usl.Columns["dolg3"].Visible = false;
                dgv_os_usl.Columns["FIO3"].Visible = false;
                dgv_os_usl.Columns["dolg4"].Visible = false;
                dgv_os_usl.Columns["FIO4"].Visible = false;
                dgv_os_usl.Columns["FIO1f2"].Visible = false;
                dgv_os_usl.Columns["dolg1f2"].Visible = false;
                dgv_os_usl.Columns["FIO2f2"].Visible = false;
                dgv_os_usl.Columns["dolg2f2"].Visible = false;
                dgv_os_usl.Columns["FIO3f2"].Visible = false;
                dgv_os_usl.Columns["dolg3f2"].Visible = false;
                dgv_os_usl.Columns["FIO4f2"].Visible = false;
                dgv_os_usl.Columns["dolg4f2"].Visible = false;
                dgv_os_usl.Columns["FIO5f2"].Visible = false;
                dgv_os_usl.Columns["dolg5f2"].Visible = false;

                dgv_os_usl.Columns["kod_rem"].Visible = false;
                dgv_os_usl.Columns["CexvitrProc"].Visible = false;
                dgv_os_usl.Columns["amortProc"].Visible = false;
                dgv_os_usl.Columns["VsegoZP"].Visible = false;
                dgv_os_usl.Columns["SumNalogov"].Visible = false;
                dgv_os_usl.Columns["TZV"].Visible = false;
                dgv_os_usl.Columns["VidrahProc"].Visible = false;
                dgv_os_usl.Columns["VsegoMat"].Visible = false;
                dgv_os_usl.Columns["TzvGrn"].Visible = false;
                dgv_os_usl.Columns["CehVitrGrn"].Visible = false;
                dgv_os_usl.Columns["AmortGrn"].Visible = false;
                dgv_os_usl.Columns["Vsego_F"].Visible = false;
                dgv_os_usl.Columns["zaversh"].Visible = false;


                dgv_os_usl.Columns["Id"].HeaderText = "№ акта";
                dgv_os_usl.Columns["InventoryNamber"].HeaderText = "Інв.№";
                dgv_os_usl.Columns["NameOS"].HeaderText = "Послуги цехів ";
                dgv_os_usl.Columns["obekt"].HeaderText = "Об.";
                dgv_os_usl.Columns["PeriodData1"].HeaderText = "Початок вик.послуги";
                dgv_os_usl.Columns["PeriodData2"].HeaderText = "Завершення вик.послуги";
                dgv_os_usl.Columns["Ispolnitel_codcx"].HeaderText = "Цех виконавець";
                dgv_os_usl.Columns["Ispolnitel_coduth"].HeaderText = "Діл.";
                dgv_os_usl.Columns["Ispolnitel_codbrig"].HeaderText = "Бюр.";
                dgv_os_usl.Columns["Ispolnitel_coddet"].HeaderText = "Пізв.";
                dgv_os_usl.Columns["Ispolnitel_name"].HeaderText = "Найменування пізвіт.особи";
                dgv_os_usl.Columns["Zakazchik_codcx"].HeaderText = "Цех замовник";
                dgv_os_usl.Columns["Shpz"].HeaderText = "ШВЗ";


                dgv_os_usl.Columns["Inv_usl"].HeaderText = "Інв.(послуга)";
                dgv_os_usl.Columns["Obekt_usl"].HeaderText = "об.(послуга)";
                dgv_os_usl.Columns["Name_inv_usl"].HeaderText = "Назва інв.(послуга)";

                dgv_os_usl.Columns["Id"].Width = 50;
                dgv_os_usl.Columns["InventoryNamber"].Width = 60;
                dgv_os_usl.Columns["NameOS"].Width = 290;
                dgv_os_usl.Columns["obekt"].Width = 25;
                dgv_os_usl.Columns["PeriodData1"].Width = 75;
                dgv_os_usl.Columns["PeriodData2"].Width = 75;
                dgv_os_usl.Columns["Ispolnitel_codcx"].Width = 30;
                dgv_os_usl.Columns["Ispolnitel_coduth"].Width = 30;
                dgv_os_usl.Columns["Ispolnitel_codbrig"].Width = 30;
                dgv_os_usl.Columns["Ispolnitel_coddet"].Width = 30;
                dgv_os_usl.Columns["Ispolnitel_name"].Width = 250;
                dgv_os_usl.Columns["Zakazchik_codcx"].Width = 30;
                dgv_os_usl.Columns["Shpz"].Width = 80;

                dgv_os_usl.Columns["Inv_usl"].Width = 65;
                dgv_os_usl.Columns["Obekt_usl"].Width = 25;
                dgv_os_usl.Columns["name_inv_usl"].Width = 300;

                dgv_os_usl.Columns["Id"].DisplayIndex = 0;
                dgv_os_usl.Columns["InventoryNamber"].DisplayIndex = 1;
                dgv_os_usl.Columns["NameOS"].DisplayIndex = 2;
                dgv_os_usl.Columns["obekt"].DisplayIndex = 3;
                dgv_os_usl.Columns["PeriodData1"].DisplayIndex = 4;
                dgv_os_usl.Columns["PeriodData2"].DisplayIndex = 5;
                dgv_os_usl.Columns["Ispolnitel_codcx"].DisplayIndex = 6;
                dgv_os_usl.Columns["Ispolnitel_coduth"].DisplayIndex = 7;
                dgv_os_usl.Columns["Ispolnitel_codbrig"].DisplayIndex = 8;
                dgv_os_usl.Columns["Ispolnitel_coddet"].DisplayIndex = 9;
                dgv_os_usl.Columns["Ispolnitel_name"].DisplayIndex = 10;
                dgv_os_usl.Columns["Zakazchik_codcx"].DisplayIndex = 11;
                dgv_os_usl.Columns["Shpz"].DisplayIndex = 12;

                dgv_os_usl.Columns["Inv_usl"].DisplayIndex = 13;
                dgv_os_usl.Columns["Obekt_usl"].DisplayIndex = 14;
                dgv_os_usl.Columns["Name_inv_usl"].DisplayIndex = 15;

            }
            else
            {
                    button1.Visible = false;
                    btn_DrukAktF2.Visible = false;
                    btn_procenti_akt.Visible = false;
                    btn_UpdateShpz.Visible = false;
            }

        }

        private void txt_SearchInv_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchInv.Text.Length > 2)
            {
                // dgv_Repair.DataSource = dal.GetAllRepair();
                SearchForInventory();
            }
            else
            {
                dgv_os_usl.DataSource = dal.GetAllAktsUsl(PeriodData2_1, PeriodData2_2);
                SettingsAllAktUsl();

            }
        }

        private void SearchForInventory()
        {

            dgv_os_usl.ReadOnly = false;
            for (int i = 0; i < dgv_os_usl.RowCount; i++)
            {
                if (dgv_os_usl.Rows[i].Cells["InventoryNamber"].Value.ToString().Contains(txt_SearchInv.Text) == false)
                {
                    dgv_os_usl.CurrentCell = null;
                    dgv_os_usl.Rows[i].Visible = false;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_procenti_akt_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_os_usl.CurrentRow.Index;

            string vsegoZP = dgv_os_usl.CurrentRow.Cells["vsegoZP"].Value.ToString();
            string sumNalogov = dgv_os_usl.CurrentRow.Cells["sumNalogov"].Value.ToString();
            string ID = dgv_os_usl.CurrentRow.Cells["ID"].Value.ToString();
            string cexVitrProc = dgv_os_usl.CurrentRow.Cells["cexVitrProc"].Value.ToString();
            string amortProc = dgv_os_usl.CurrentRow.Cells["amortProc"].Value.ToString();
            string TZV = dgv_os_usl.CurrentRow.Cells["TZV"].Value.ToString();


            string NameOs = dgv_os_usl.CurrentRow.Cells["NameOS"].Value.ToString();
            string InvNumberOS = dgv_os_usl.CurrentRow.Cells["InventoryNamber"].Value.ToString();
            string Obekt = dgv_os_usl.CurrentRow.Cells["Obekt"].Value.ToString();
            string State1 = dgv_os_usl.CurrentRow.Cells["dolg1f2"].Value.ToString();
            string FIO1 = dgv_os_usl.CurrentRow.Cells["FIO1f2"].Value.ToString();
            string State2 = dgv_os_usl.CurrentRow.Cells["dolg2f2"].Value.ToString();
            string FIO2 = dgv_os_usl.CurrentRow.Cells["FIO2f2"].Value.ToString();

            string State3 = dgv_os_usl.CurrentRow.Cells["dolg3f2"].Value.ToString();
            string FIO3 = dgv_os_usl.CurrentRow.Cells["FIO3f2"].Value.ToString();
            string State4 = dgv_os_usl.CurrentRow.Cells["dolg4f2"].Value.ToString();
            string FIO4 = dgv_os_usl.CurrentRow.Cells["FIO4f2"].Value.ToString();

            string State5 = dgv_os_usl.CurrentRow.Cells["dolg5f2"].Value.ToString();
            string FIO5 = dgv_os_usl.CurrentRow.Cells["FIO5f2"].Value.ToString();

            //string ID = dgv_os_usl.CurrentRow.Cells["ID"].Value.ToString();
            string Shpz = dgv_os_usl.CurrentRow.Cells["SHpz"].Value.ToString();

            string IspCx = dgv_os_usl.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            string IspUch = dgv_os_usl.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
            string IspBrig = dgv_os_usl.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
            string IspDet = dgv_os_usl.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();


            string PeriodData1 = dgv_os_usl.CurrentRow.Cells["PeriodData1"].Value.ToString();
            string PeriodData2 = dgv_os_usl.CurrentRow.Cells["PeriodData2"].Value.ToString();
            string mes = PeriodData1.Substring(3, 2);
            string god = PeriodData1.Substring(6, 4);

            //string IspBrig2 = (IspBrig.ToString()== null ? "0" : IspBrig.ToString());   // iif

            string VidrahProc = dgv_os_usl.CurrentRow.Cells["VidrahProc"].Value.ToString();
            string VsegoMat = dgv_os_usl.CurrentRow.Cells["VsegoMat"].Value.ToString();
            string TzvGrn = dgv_os_usl.CurrentRow.Cells["TzvGrn"].Value.ToString();
            string CehVitrGrn = dgv_os_usl.CurrentRow.Cells["CehVitrGrn"].Value.ToString();
            string AmortGrn = dgv_os_usl.CurrentRow.Cells["AmortGrn"].Value.ToString();
            string Vsego_F = dgv_os_usl.CurrentRow.Cells["Vsego_F"].Value.ToString();
            string Rep_ID = dgv_os_usl.CurrentRow.Cells["RepairID"].Value.ToString();

            string NameOs_Usl = dgv_os_usl.CurrentRow.Cells["Name_inv_usl"].Value.ToString();
            string InvNumberOS_Usl = dgv_os_usl.CurrentRow.Cells["Inv_usl"].Value.ToString();
            string Obekt_Usl = dgv_os_usl.CurrentRow.Cells["Obekt_usl"].Value.ToString();


           myfrmProcentsForAKT myfrmProcentsForAKT = new myfrmProcentsForAKT(ID, vsegoZP, sumNalogov, cexVitrProc, amortProc, TZV,
                NameOs, InvNumberOS, FIO1, State1, FIO2, State2, FIO3, State3, FIO4, State4, IspCx, IspUch, IspBrig, IspDet, mes, god, FIO5, State5, Obekt, PeriodData2,
                VidrahProc, VsegoMat, TzvGrn, CehVitrGrn, AmortGrn, Vsego_F, Shpz, "usl",Rep_ID,InvNumberOS_Usl,Obekt_Usl,NameOs_Usl );
            myfrmProcentsForAKT.ShowDialog();


            // if (myfrmProcentsForAKT.ShowDialog() == DialogResult.OK)
            //{
            dgv_os_usl.DataSource = dal.GetAllAktsUsl(PeriodData2_1, PeriodData2_2);
            SettingsAllAktUsl();
     
            dgv_os_usl.FirstDisplayedCell = dgv_os_usl.Rows[a].Cells["id"];
            dgv_os_usl.Rows[a].Selected = true;


            //}
            //else
            //{
            //    MessageBox.Show("DialogResult.No");
            //}



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_os_usl.CurrentRow.Index;

            string NameOs = dgv_os_usl.CurrentRow.Cells["NameOS"].Value.ToString();
            string InvNumberOS = dgv_os_usl.CurrentRow.Cells["InventoryNamber"].Value.ToString();
            string ID = dgv_os_usl.CurrentRow.Cells["ID"].Value.ToString();
            string Repair_id = dgv_os_usl.CurrentRow.Cells["RepairID"].Value.ToString();

            myfrmJobsForAKT myfrmJobsForAKT = new myfrmJobsForAKT(ID, NameOs, InvNumberOS,"usl",Repair_id);
            myfrmJobsForAKT.ShowDialog();


            // if (myfrmProcentsForAKT.ShowDialog() == DialogResult.OK)
            //{

            dgv_os_usl.DataSource = dal.GetAllAktsUsl(PeriodData2_1, PeriodData2_2);
            SettingsAllAktUsl();

            dgv_os_usl.FirstDisplayedCell = dgv_os_usl.Rows[a].Cells["id"];
            dgv_os_usl.Rows[a].Selected = true;


        }

        private void btn_DrukAktF2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Не працює. Ще розробляється.");

            {
                DAL dal = new DAL();
                string ID = dgv_os_usl.CurrentRow.Cells["ID"].Value.ToString();

                string shpz = dgv_os_usl.CurrentRow.Cells["SHpz"].Value.ToString();
                vsegoZP = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["vsegoZP"].Value.ToString()), 2));
                sumNalogov = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["sumNalogov"].Value.ToString()), 2));
                cexVitrProc = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["cexVitrProc"].Value.ToString()), 2));
                amortProc = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["amortProc"].Value.ToString()), 2));
                TZV = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["TZV"].Value.ToString()), 2));
                Sum_mater = Math.Round(dal.sum_mater(Convert.ToInt32(ID)), 2);
                string zaversh = dgv_os_usl.CurrentRow.Cells["zaversh"].Value.ToString();
                //double VidrahProc2 = 0;
                //double VsegoMat2 = 0;
                //double TzvGrn2 = 0;
                //double CehVitrGrn2 = 0;
                //double AmortGrn2 = 0;
                //double Vsego_F2 = 0;

                //VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F

                string vsegomat = Sum_mater.ToString();


                //\\
                //|\\\
                //|/\\\\
                //|//\\\\\
                //|///\\\\\\
                //|////\\\\\\\   
                //|/////\\\\\\\  
                //|//////\\\\\\\ 
                //|///////\\\\\\\
                //##################

                string State1 = dgv_os_usl.CurrentRow.Cells["dolg1f2"].Value.ToString();
                string FIO1 = dgv_os_usl.CurrentRow.Cells["FIO1f2"].Value.ToString();
                string State2 = dgv_os_usl.CurrentRow.Cells["dolg2f2"].Value.ToString();
                string FIO2 = dgv_os_usl.CurrentRow.Cells["FIO2f2"].Value.ToString();

                string State3 = dgv_os_usl.CurrentRow.Cells["dolg3f2"].Value.ToString();
                string FIO3 = dgv_os_usl.CurrentRow.Cells["FIO3f2"].Value.ToString();
                string State4 = dgv_os_usl.CurrentRow.Cells["dolg4f2"].Value.ToString();
                string FIO4 = dgv_os_usl.CurrentRow.Cells["FIO4f2"].Value.ToString();

                string State5 = dgv_os_usl.CurrentRow.Cells["dolg5f2"].Value.ToString();
                string FIO5 = dgv_os_usl.CurrentRow.Cells["FIO5f2"].Value.ToString();

                if (FIO5 == null || FIO5 == "")
                    FIO5 = "";

                if (State5 == null || State5 == "")
                    State5 = "";


                string ZakCx = dgv_os_usl.CurrentRow.Cells["Zakazchik_codcx"].Value.ToString();
                string ZakUch = dgv_os_usl.CurrentRow.Cells["Zakazchik_coduth"].Value.ToString();
                string ZakBrig = dgv_os_usl.CurrentRow.Cells["Zakazchik_codbrig"].Value.ToString();
                string ZakDet = dgv_os_usl.CurrentRow.Cells["Zakazchik_coddet"].Value.ToString();

                string IspCx = dgv_os_usl.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
                string IspUch = dgv_os_usl.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
                string IspBrig = dgv_os_usl.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
                string IspDet = dgv_os_usl.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();

                string NameOs = dgv_os_usl.CurrentRow.Cells["NameOS"].Value.ToString();
                string InvNumberOS = dgv_os_usl.CurrentRow.Cells["InventoryNamber"].Value.ToString();

                string Obekt = dgv_os_usl.CurrentRow.Cells["Obekt"].Value.ToString();

                string PeriodData1 = dgv_os_usl.CurrentRow.Cells["PeriodData1"].Value.ToString();
                string PeriodData2 = dgv_os_usl.CurrentRow.Cells["PeriodData2"].Value.ToString();

                string InvNumberOS_Usl=dgv_os_usl.CurrentRow.Cells["inv_usl"].Value.ToString();
                string Obekt_Usl = dgv_os_usl.CurrentRow.Cells["obekt_usl"].Value.ToString();
                

                double CexVitrGrn = 0;
                double AmortGrn = 0;
                double VidrahProc = 0;
                double TZVGrn = 0;
                double SumVsegoo = 0;
                string SumVsego = "0";

                if (Convert.ToDateTime(PeriodData2.ToString()).Year < 2018)
                {
                    if (IspCx == "54")
                    {
                        TZVGrn = Math.Round(Math.Round(Sum_mater, 2) * Math.Round(TZV, 2) / 100, 2);
                        string PD2 = dgv_os_usl.CurrentRow.Cells["PeriodData2"].Value.ToString();
                        string dd = PD2.Substring(6, 4);
                        if (Convert.ToInt32(dd) < 2018)
                        {
                            CexVitrGrn = Math.Round((Math.Round(vsegoZP, 2) + Math.Round(sumNalogov, 2) + Math.Round(Sum_mater, 2) + Math.Round(TZVGrn, 2)) * Math.Round(cexVitrProc, 2) / 100, 2); // считать до 2018 года  Заявка от12.01.2018 № 61.5/236
                            AmortGrn = Math.Round((Math.Round(vsegoZP, 2) + Math.Round(sumNalogov, 2) + Math.Round(Sum_mater, 2) + Math.Round(TZVGrn, 2)) * Math.Round(amortProc, 2) / 100, 2); // считать до 2018 года   Заявка от12.01.2018 № 61.5/236
                        }
                        else
                        {
                            CexVitrGrn = Math.Round(Math.Round(vsegoZP, 2) * Math.Round(cexVitrProc, 2) / 100, 2); //считать с 2018 года    Заявка от12.01.2018 № 61.5/236
                            AmortGrn = Math.Round(Math.Round(vsegoZP, 2) * Math.Round(amortProc, 2) / 100, 2); // считать с 2018 года   Заявка от12.01.2018 № 61.5/236
                        }

                        VidrahProc = Math.Round(Math.Round(sumNalogov, 2) / Math.Round(vsegoZP, 2) * 100, 2);

                        SumVsegoo = Math.Round(Math.Round(Convert.ToDouble(vsegoZP), 2) + Math.Round(Convert.ToDouble(sumNalogov), 2)
                                        + Math.Round(Convert.ToDouble(vsegomat), 2)
                                        + Math.Round(Convert.ToDouble(TZVGrn), 2)
                                        + Math.Round(Convert.ToDouble(CexVitrGrn), 2)
                                        + Math.Round(Convert.ToDouble(AmortGrn), 2), 2);

                    }
                    else
                    {
                        VidrahProc = Math.Round(Math.Round(sumNalogov, 2) / Math.Round(vsegoZP, 2) * 100, 2);
                        TZVGrn = Math.Round(Math.Round(Sum_mater, 2) * Math.Round(TZV, 2) / 100, 2);
                        CexVitrGrn = Math.Round(Math.Round(vsegoZP, 2) * Math.Round(cexVitrProc, 2) / 100, 2);
                        AmortGrn = Math.Round(Math.Round(vsegoZP, 2) * Math.Round(amortProc, 2) / 100, 2);
                        SumVsegoo = Math.Round(Math.Round(Convert.ToDouble(vsegoZP), 2) + Math.Round(Convert.ToDouble(sumNalogov), 2)
                                        + Math.Round(Convert.ToDouble(vsegomat), 2)
                                        + Math.Round(Convert.ToDouble(TZVGrn), 2)
                                        + Math.Round(Convert.ToDouble(CexVitrGrn), 2)
                                        + Math.Round(Convert.ToDouble(AmortGrn), 2), 2);


                    }
                    SumVsego = Math.Round(Math.Round(Convert.ToDouble(vsegoZP), 2) + Math.Round(Convert.ToDouble(sumNalogov), 2)
                                + Math.Round(Convert.ToDouble(vsegomat), 2)
                                + Math.Round(Convert.ToDouble(vsegomat) * Convert.ToDouble(TZV) / 100, 2)
                                + Math.Round(Convert.ToDouble(vsegoZP) * Convert.ToDouble(cexVitrProc) / 100, 2)
                                + Math.Round(Convert.ToDouble(vsegoZP) * Convert.ToDouble(amortProc) / 100, 2), 2).ToString();

                    //VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F
                }
                else
                {

                    //MessageBox.Show("2018");
                    VidrahProc = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["VidrahProc"].Value.ToString()), 2));
                    vsegomat = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["VsegoMat"].Value.ToString()), 2)).ToString();
                    TZVGrn = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["TzvGrn"].Value.ToString()), 2));
                    CexVitrGrn = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["CehVitrGrn"].Value.ToString()), 2));
                    AmortGrn = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["AmortGrn"].Value.ToString()), 2));
                    SumVsegoo = (Math.Round(Convert.ToDouble(dgv_os_usl.CurrentRow.Cells["Vsego_F"].Value.ToString()), 2));

                    //VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F
                }

                if (dal.DelFromTmp_JobAKT() == true) //очищаем временную табличку Tmp_JobAKT
                {
                }

                if (dal.SaveToTmp_JobAKT_Step1(ID, remusl) == true)  //заполняем временную табличку Tmp_JobAKT шаг1
                {
                    // MessageBox.Show("Виконано");
                }
                else
                {
                    MessageBox.Show("Error.Step1.");
                }

                if (dal.SaveToTmp_JobAKT_Step2(ID,remusl) == true)  //заполняем временную табличку Tmp_JobAKT шаг2
                {
                    //MessageBox.Show("Виконано");
                }
                else
                {
                    MessageBox.Show("Error.Step2.");
                }

                frmPrintAktF2 frmPrintAktF2 = new frmPrintAktF2(ID, shpz, Math.Round(vsegoZP, 2), Math.Round(sumNalogov, 2), Math.Round(cexVitrProc, 2), Math.Round(amortProc, 2),
                                Math.Round(TZV, 2), vsegomat,
                                ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, State1, FIO1, State2, FIO2, State3, FIO3, State4, FIO4,
                                NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, SumVsego, FIO5, State5, VidrahProc, TZVGrn, CexVitrGrn, AmortGrn, SumVsegoo, zaversh, InvNumberOS_Usl, Obekt_Usl);
                frmPrintAktF2.ShowDialog();


            }
        }

        private void btn_UpdateVedRes_Click(object sender, EventArgs e)
        {
            {
                int a = 0;
                a = dgv_os_usl.CurrentRow.Index;

                string ID = dgv_os_usl.CurrentRow.Cells["ID"].Value.ToString();
                string NameOs = dgv_os_usl.CurrentRow.Cells["NameOS"].Value.ToString();
                string InvNumberOS = dgv_os_usl.CurrentRow.Cells["InventoryNamber"].Value.ToString();
                string Obekt = dgv_os_usl.CurrentRow.Cells["Obekt"].Value.ToString();
                string Shpz = dgv_os_usl.CurrentRow.Cells["SHpz"].Value.ToString();

                string IspCx = dgv_os_usl.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
                string IspUch = dgv_os_usl.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
                string IspBrig = dgv_os_usl.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
                string IspDet = dgv_os_usl.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();

                string PeriodData1 = dgv_os_usl.CurrentRow.Cells["PeriodData1"].Value.ToString();
                string PeriodData2 = dgv_os_usl.CurrentRow.Cells["PeriodData2"].Value.ToString();
                string mes = PeriodData1.Substring(3, 2);
                string god = PeriodData1.Substring(6, 4);


                myfrmRedZhpz myfrmRedZhpz = new myfrmRedZhpz(ID, NameOs, InvNumberOS, IspCx, IspUch, IspBrig, IspDet, mes, god, Obekt, PeriodData2, Shpz);
                myfrmRedZhpz.ShowDialog();


                // if (myfrmProcentsForAKT.ShowDialog() == DialogResult.OK)
                //{
                dgv_os_usl.DataSource = dal.GetAllAktsUsl(PeriodData2_1, PeriodData2_2);
                SettingsAllAktUsl();

                dgv_os_usl.FirstDisplayedCell = dgv_os_usl.Rows[a].Cells["id"];
                dgv_os_usl.Rows[a].Selected = true;


                //}
                //else
                //{
                //    MessageBox.Show("DialogResult.No");
                //}



            }
        }
    }
}
