using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections;
using System.Data.Common;

namespace Repairs
{
   
    public partial class myfrmAllVedomotsResursov : Form
    {
        DAL dal = new DAL();
        private string tek_mes, tek_god;
        public delegate void FFF();
        public event FFF FF;
        public delegate void FFFf();
        public event FFFf FFf;
        public string PeriodData2_1,PeriodData2_2;
        public bool all_ceh;
        public string VIBRAN_CEH;
//        public string dejstvie="";
        double vsegoZP =0;
        double sumNalogov = 0;
        double cexVitrProc = 0;
        double amortProc = 0;
        double TZV = 0;
        double Sum_mater = 0;

                        
        public myfrmAllVedomotsResursov(string tekmes, string tekgod, string Data2_1, string  Data2_2, bool all,string ceh)
        {
            InitializeComponent();
            //dejstvie = "";
            tek_mes = tekmes.ToString();
            tek_god = tekgod.ToString();
                
            //string Period_god2_1 = Data2_1.Substring(0,4);
            //string Period_mes2_1 = Data2_1.Substring(4, 2);
            //string Period_day2_1 = Data2_1.Substring(6, 2);
            PeriodData2_1 = Data2_1;
            PeriodData2_2 = Data2_2;

            string Period_god2_1 = Data2_1.Substring(0,4);
            string Period_mes2_1 = Data2_1.Substring(4, 2);
            string Period_day2_1 = Data2_1.Substring(6, 2);

            string Period_god2_2 = Data2_2.Substring(0, 4);
            string Period_mes2_2 = Data2_2.Substring(4, 2);
            string Period_day2_2 = Data2_2.Substring(6, 2);
            
            //bool all_ceh = all;
            all_ceh = all;
            
            VIBRAN_CEH = ceh;
            //this.Text = "Відомості ресурсів за період з " + PeriodData2_1.ToString() + " по " + PeriodData2_2.ToString();
            this.Text = "Відомості ресурсів за період з " + Period_day2_1.ToString() + "." + Period_mes2_1.ToString() + "." + Period_god2_1.ToString() + "p. " + " по " + Period_day2_2.ToString() + "." + Period_mes2_2.ToString() + "." + Period_god2_2.ToString();
            checkBox1.Visible = false;
            dgv_AllVedomostsResursob.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_AllVedomostsResursob.MultiSelect = false;
        }

        private void myfrmAllVedomotsResursov_Load(object sender, EventArgs e)
        {
            
            FFf();
            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
            SettingsAllVedRes();
            //if (dgv_AllVedomostsResursob.Rows[i].Cells["Original"].Value.ToString() == "1")
            //    this.button5.Visible = true;
            //else
            //    this.button5.Visible = false;
            FF();

            if ((Dostup.Login_user == "Boyarskij_DA" || Dostup.Login_user == "Vorobieva_IV" || Dostup.Login_user == "Vlasyuk_RV") && dgv_AllVedomostsResursob.Rows.Count > 0)
            {
                dgv_AllVedomostsResursob.Columns["IsCapital"].Visible = true;
            }
            else
            {
                labelCapital.Visible = false;
                buttonCapital.Visible = false;
            }
        }
        //при проходе по строкам меняем значения вспомогательных таблиц
        private void dgv_AllVedomostsResursob_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_AllVedomostsResursob.RowCount > 0)
            {
                dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());

                dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                SettingsAllRepPlace();
                SettingsAllVozvrDet();
                SettingsAllVozvrMet();


                // проверка на рабочий месяц
                string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
                string mes = PeriodData1.Substring(3, 2);
                string god = PeriodData1.Substring(6, 4);

                //*********
                //if (VIBRAN_CEH == "50" && all_ceh==true)

                if (String.Equals(Dostup.Codcx, "0"))
                {
                    
                    if (tek_mes.ToString() == mes.ToString() & tek_god.ToString() == god.ToString()) // проверка на рабочий месяц
                    {
                        
                        //MessageBox.Show("=");
                        btn_UpdateVedRes.Visible = true;
                        btn_DelVedRes.Visible = true;
                        btn_alterRepair.Visible = true;
                        btn_UpdateShpz.Visible = true;

                        checkBox1.Visible = false;
                        //this.button5.Visible = true;
                    }
                    else
                    {
                        //MessageBox.Show("<>");
                        btn_UpdateVedRes.Visible = false;
                        btn_DelVedRes.Visible = false; //15062018
                        btn_alterRepair.Visible = false;
                        btn_UpdateShpz.Visible = false;
                        //this.button5.Visible = false;
                        checkBox1.Visible = true;
                        checkBox1.Checked = true;
                    }

                    if (Dostup.Dostup_akt == "88")
                    {
                    btn_AvtomatAktF2.Visible=true;
                    }
                    else
                    {
                     btn_AvtomatAktF2.Visible=false;
                    }
                 

                }
                else
                {

                    if (Change_ceh.ALL == true)
                    {

                        btn_UpdateVedRes.Visible = false;
                        btn_DelVedRes.Visible = false; 
                        btn_alterRepair.Visible = false;
                        btn_UpdateShpz.Visible = false;
                        btn_procenti_akt.Visible = false;
                        //button1.Visible = false; 31.10.2019
                        button5.Visible = false;
                        btn_AvtomatAktF2.Visible = false;
                    }
                    else

                    {

                        if (tek_mes.ToString() == mes.ToString() & tek_god.ToString() == god.ToString()) // проверка на рабочий месяц
                        {
                            //MessageBox.Show("=");
                            btn_UpdateVedRes.Visible = true;
                            btn_DelVedRes.Visible = true;
                            btn_alterRepair.Visible = true;
                            btn_UpdateShpz.Visible = true;
                            //this.button5.Visible = true;
                            checkBox1.Visible = false;
                        }
                        else
                        {
                            //MessageBox.Show("<>");
                            btn_UpdateVedRes.Visible = false;
                            btn_DelVedRes.Visible = false; //15062018
                            btn_alterRepair.Visible = false;
                            btn_UpdateShpz.Visible = false;

                            //this.button5.Visible = false;
                            checkBox1.Visible = true;
                            checkBox1.Checked = true;
                        }

                        if (Dostup.Dostup_akt == "88")
                        {
                            btn_AvtomatAktF2.Visible = true;
                        }
                        else
                        {
                            btn_AvtomatAktF2.Visible = false;
                        }
                 

                        
                    }
                //    btn_UpdateVedRes.Visible = false;
                //    btn_DelVedRes.Visible = false;
                //    btn_alterRepair.Visible = false;
                //    btn_UpdateShpz.Visible = false;
                
                }




                //

                //if (dgv_AllVedomostsResursob.CurrentRow.Cells["Original"].Value.ToString() == "1")
                //    this.button5.Visible = true;
                //else
                //    this.button5.Visible = false;
                if (labelCapital.Visible)
                {
                    bool flag = Convert.ToBoolean(dgv_AllVedomostsResursob.CurrentRow.Cells["IsCapital"].Value);
                    if (flag)
                    {
                        labelCapital.Text = "Капитальный";
                    }
                    else
                    {
                        labelCapital.Text = "Обычный";
                    }
                }

            }
        }

        //печать ведомости ресурсов
        private void btn_PrintVedRes_Click(object sender, EventArgs e)
        {
            
            string PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.RepairOSConnStr))
            {
                try
                {
                    conn.Open();
                    //заполняем список запчастей 
                    SqlCommand cmd2 = new SqlCommand("NewVRRepPart", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd2.ExecuteNonQuery();
                    //заполняем возвратные детали
                    SqlCommand cmd3 = new SqlCommand("NewVRVozvrDet", conn);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd3.ExecuteNonQuery();
                    //заполняем возвратный металлолом
                    SqlCommand cmd4 = new SqlCommand("NewVRVozvrMet", conn);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd4.ExecuteNonQuery();
                    //заполняем шапку ведомости ресурсов 

                    SqlCommand cmd1 = new SqlCommand("NewVRVedRes", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            myfrmPrintVedRes myfrmPrintVedRes = new myfrmPrintVedRes();
            myfrmPrintVedRes.ShowDialog();
           

        }

        private void SettingsAllVedRes()
        {
            if (dgv_AllVedomostsResursob.RowCount > 0)
            {

                dgv_AllVedomostsResursob.Columns["kol"].Visible = false;
                dgv_AllVedomostsResursob.Columns["kol1"].Visible = false;
                dgv_AllVedomostsResursob.Columns["Zakazchik_codcx"].Visible = false;
                dgv_AllVedomostsResursob.Columns["Zakazchik_coduth"].Visible = false;
                //dgv_AllVedomostsResursob.Columns["Ispolnitel_codcx"].Visible = false;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_codcx"].Visible = true;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coduth"].Visible = true;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_codbrig"].Visible = true;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coddet"].Visible = true;
                dgv_AllVedomostsResursob.Columns["VedomostNumber"].Visible = false;
                dgv_AllVedomostsResursob.Columns["Original"].Visible = false;
                dgv_AllVedomostsResursob.Columns["RepairID"].Visible = false;
                dgv_AllVedomostsResursob.Columns["kod_rem"].Visible = false;

                dgv_AllVedomostsResursob.Columns["Zakazchik_codbrig"].Visible = false;
                dgv_AllVedomostsResursob.Columns["Zakazchik_coddet"].Visible = false;
                dgv_AllVedomostsResursob.Columns["CexvitrProc"].Visible = false;
                dgv_AllVedomostsResursob.Columns["amortProc"].Visible = false;
                dgv_AllVedomostsResursob.Columns["VsegoZP"].Visible = false;
                dgv_AllVedomostsResursob.Columns["SumNalogov"].Visible = false;
                dgv_AllVedomostsResursob.Columns["TZV"].Visible = false;
                dgv_AllVedomostsResursob.Columns["b_bal_cena"].Visible = true;

                dgv_AllVedomostsResursob.Columns["VidrahProc"].Visible = false;
                dgv_AllVedomostsResursob.Columns["VsegoMat"].Visible = false;
                dgv_AllVedomostsResursob.Columns["TzvGrn"].Visible = false;
                dgv_AllVedomostsResursob.Columns["CehVitrGrn"].Visible = false;
                dgv_AllVedomostsResursob.Columns["AmortGrn"].Visible = false;
                dgv_AllVedomostsResursob.Columns["Vsego_F"].Visible = false;
                dgv_AllVedomostsResursob.Columns["zaversh"].Visible = true;


                dgv_AllVedomostsResursob.Columns["Ispolnitel_codcx"].HeaderText = "Цех вик";
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coduth"].HeaderText = "";
                dgv_AllVedomostsResursob.Columns["Ispolnitel_codbrig"].HeaderText = "";
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coddet"].HeaderText = "";

                dgv_AllVedomostsResursob.Columns["ID"].HeaderText = "№ ";
                dgv_AllVedomostsResursob.Columns["InventoryNamber"].HeaderText = "Інв№";
                dgv_AllVedomostsResursob.Columns["NameOS"].HeaderText = "Найменування";
                dgv_AllVedomostsResursob.Columns["PeriodData1"].HeaderText = "З ";
                dgv_AllVedomostsResursob.Columns["PeriodData2"].HeaderText = "По ";
                dgv_AllVedomostsResursob.Columns["Shpz"].HeaderText = "ШВВ";
                dgv_AllVedomostsResursob.Columns["b_bal_cena"].HeaderText = "Залиш.вартість";

                dgv_AllVedomostsResursob.Columns["dolg1"].HeaderText = "Пос.1";
                dgv_AllVedomostsResursob.Columns["FIO1"].HeaderText = "ПІБ1";
                dgv_AllVedomostsResursob.Columns["dolg2"].HeaderText = "Пос.2";
                dgv_AllVedomostsResursob.Columns["FIO2"].HeaderText = "ПІБ2";
                dgv_AllVedomostsResursob.Columns["dolg3"].HeaderText = "Пос.3";
                dgv_AllVedomostsResursob.Columns["FIO3"].HeaderText = "ПІБ3";
                dgv_AllVedomostsResursob.Columns["dolg4"].HeaderText = "Пос.4";
                dgv_AllVedomostsResursob.Columns["FIO4"].HeaderText = "ПІБ4";

                dgv_AllVedomostsResursob.Columns["dolg1f2"].HeaderText = "Пос.1 ф2";
                dgv_AllVedomostsResursob.Columns["FIO1f2"].HeaderText = "ПІБ1 ф2";
                dgv_AllVedomostsResursob.Columns["dolg2f2"].HeaderText = "Пос.2 ф2";
                dgv_AllVedomostsResursob.Columns["FIO2f2"].HeaderText = "ПІБ2 ф2";

                dgv_AllVedomostsResursob.Columns["dolg3f2"].HeaderText = "Пос.3 ф2";
                dgv_AllVedomostsResursob.Columns["FIO3f2"].HeaderText = "ПІБ3 ф2";
                dgv_AllVedomostsResursob.Columns["dolg4f2"].HeaderText = "Пос.4 ф2";
                dgv_AllVedomostsResursob.Columns["FIO4f2"].HeaderText = "ПІБ4 ф2";

                dgv_AllVedomostsResursob.Columns["dolg5f2"].HeaderText = "Пос.5 ф2";
                dgv_AllVedomostsResursob.Columns["FIO5f2"].HeaderText = "ПІБ5 ф2";
                dgv_AllVedomostsResursob.Columns["zaversh"].HeaderText = "Завершен";


                dgv_AllVedomostsResursob.Columns["Ispolnitel_codcx"].Width = 20;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coduth"].Width = 20;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_codbrig"].Width = 20;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coddet"].Width = 20;


                dgv_AllVedomostsResursob.Columns["Ispolnitel_Name"].HeaderText = "Подотчет";
                dgv_AllVedomostsResursob.Columns["obekt"].HeaderText = "об";


                dgv_AllVedomostsResursob.Columns["ID"].Width = 50;
                dgv_AllVedomostsResursob.Columns["InventoryNamber"].Width = 60;
                dgv_AllVedomostsResursob.Columns["NameOS"].Width = 100;
                dgv_AllVedomostsResursob.Columns["PeriodData1"].Width = 70;
                dgv_AllVedomostsResursob.Columns["PeriodData2"].Width = 70;
                dgv_AllVedomostsResursob.Columns["Shpz"].Width = 60;
                dgv_AllVedomostsResursob.Columns["b_bal_cena"].Width = 80;

                dgv_AllVedomostsResursob.Columns["dolg1"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO1"].Width = 100;
                dgv_AllVedomostsResursob.Columns["dolg2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO2"].Width = 100;

                dgv_AllVedomostsResursob.Columns["dolg3"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO3"].Width = 100;
                dgv_AllVedomostsResursob.Columns["dolg4"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO4"].Width = 100;


                //dgv_AllVedomostsResursob.Columns["dolg5"].Width = 100;
                //dgv_AllVedomostsResursob.Columns["FIO5"].Width = 100;

                dgv_AllVedomostsResursob.Columns["dolg1f2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO1f2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["dolg2f2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO2f2"].Width = 100;

                dgv_AllVedomostsResursob.Columns["dolg3f2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO3f2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["dolg4f2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO4f2"].Width = 100;

                dgv_AllVedomostsResursob.Columns["dolg5f2"].Width = 100;
                dgv_AllVedomostsResursob.Columns["FIO5f2"].Width = 100;



                dgv_AllVedomostsResursob.Columns["Ispolnitel_Name"].Width = 170;
                dgv_AllVedomostsResursob.Columns["obekt"].Width = 20;
                dgv_AllVedomostsResursob.Columns["zaversh"].Width = 60;

                //dgv_AllVedomostsResursob.Columns["b_bal_cena"].DisplayIndex = 15;


                dgv_AllVedomostsResursob.Columns["ID"].DisplayIndex = 0;
                dgv_AllVedomostsResursob.Columns["InventoryNamber"].DisplayIndex = 1;
                dgv_AllVedomostsResursob.Columns["NameOS"].DisplayIndex = 2;
                dgv_AllVedomostsResursob.Columns["obekt"].DisplayIndex = 3;
                dgv_AllVedomostsResursob.Columns["PeriodData1"].DisplayIndex = 4;
                dgv_AllVedomostsResursob.Columns["PeriodData2"].DisplayIndex = 5;
                dgv_AllVedomostsResursob.Columns["Shpz"].DisplayIndex = 6;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_codcx"].DisplayIndex = 7;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coduth"].DisplayIndex = 8;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_codbrig"].DisplayIndex = 9;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_coddet"].DisplayIndex = 10;
                dgv_AllVedomostsResursob.Columns["Ispolnitel_Name"].DisplayIndex = 11;
                dgv_AllVedomostsResursob.Columns["b_bal_cena"].DisplayIndex = 12;

                dgv_AllVedomostsResursob.Columns["IsCapital"].Visible = false;
                dgv_AllVedomostsResursob.Columns["IsCapital"].DisplayIndex = 3;
                dgv_AllVedomostsResursob.Columns["IsCapital"].HeaderText = "Кап";
                dgv_AllVedomostsResursob.Columns["IsCapital"].Width = 30;


                //синими делаем ведомости ресурсов оригинала
                for (int i = 0; i < dgv_AllVedomostsResursob.RowCount; i++)
                {
                    if (dgv_AllVedomostsResursob.Rows[i].Cells["Original"].Value.ToString() == "3")
                    {
                        for (int j = 0; j < dgv_AllVedomostsResursob.ColumnCount; j++)
                        {
                            dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.BackColor = Color.Aqua;
                            //***

                            //**
                        }
                    }
                }
                //повторяющиеся ведомости ресурсов делаем рыжими
                for (int i = 0; i < dgv_AllVedomostsResursob.RowCount; i++)
                {
                    if ((Convert.ToInt32(dgv_AllVedomostsResursob.Rows[i].Cells["kol"].Value.ToString()) > 1) && (dgv_AllVedomostsResursob.Rows[i].Cells["Original"].Value.ToString() != "3"))
                    {
                        for (int j = 0; j < dgv_AllVedomostsResursob.ColumnCount; j++)
                        {
                            // dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.Font.Bold = true;
                            dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.ForeColor = Color.Crimson;
                            dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.BackColor = Color.Gold;

                        }
                    }
                }

                //удаленные ведомости ресурсов делаем другим цветом
                for (int i = 0; i < dgv_AllVedomostsResursob.RowCount; i++)
                {
                    if (dgv_AllVedomostsResursob.Rows[i].Cells["Original"].Value.ToString() == "4")
                    {
                        for (int j = 0; j < dgv_AllVedomostsResursob.ColumnCount; j++)
                        {
                            dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.BackColor = Color.DarkOliveGreen;
                            //.DarkOrange;
                        }
                    }
                }

                ////ОС ремонтируемые разными людьми делаем 
                //for (int i = 0; i < dgv_AllVedomostsResursob.RowCount; i++)
                //{
                //    if (Convert.ToInt32(dgv_AllVedomostsResursob.Rows[i].Cells["kol1"].Value.ToString()) > Convert.ToInt32(dgv_AllVedomostsResursob.Rows[i].Cells["kol"].Value.ToString()))
                //    {
                //        for (int j = 0; j < dgv_AllVedomostsResursob.ColumnCount; j++)
                //        {
                //            // dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.Font.Bold = true;
                //            dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.ForeColor = Color.White;
                //            dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.BackColor = Color.Black;

                //        }
                //    }
                //}

                //наш тест  Чернім цветом инв№ ремонтируется в пределах месяца разніми цехами
                for (int i = 0; i < dgv_AllVedomostsResursob.RowCount - 1; i++)
                {
                    for (int k = i + 1; k < dgv_AllVedomostsResursob.RowCount; k++)
                    {
                        if (dgv_AllVedomostsResursob.Rows[i].Cells["InventoryNamber"].Value.ToString() == dgv_AllVedomostsResursob.Rows[k].Cells["InventoryNamber"].Value.ToString() &&
                           dgv_AllVedomostsResursob.Rows[i].Cells["obekt"].Value.ToString() == dgv_AllVedomostsResursob.Rows[k].Cells["obekt"].Value.ToString() &&
                            dgv_AllVedomostsResursob.Rows[i].Cells["Ispolnitel_codcx"].Value.ToString() != dgv_AllVedomostsResursob.Rows[k].Cells["Ispolnitel_codcx"].Value.ToString() &&

                           (
                                (((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata1"].Value)).Date >= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata1"].Value)).Date &&
                            ((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata2"].Value)).Date <= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata2"].Value)))
                            ||

                            (((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata1"].Value)).Date <= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata1"].Value)).Date &&
                            ((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata2"].Value)).Date >= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata2"].Value)))
                            ||

                            (((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata1"].Value)).Date <= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata1"].Value)).Date &&
                            ((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata2"].Value)).Date <= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata2"].Value)) &&
                            ((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata2"].Value)).Date >= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata1"].Value)).Date)
                            ||

                            (((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata1"].Value)).Date >= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata1"].Value)).Date &&
                            ((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata2"].Value)).Date >= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata2"].Value)) &&
                            ((DateTime)(dgv_AllVedomostsResursob.Rows[i].Cells["perioddata2"].Value)).Date <= ((DateTime)(dgv_AllVedomostsResursob.Rows[k].Cells["perioddata1"].Value)).Date)

                            )
                            )
                        {
                            for (int j = 0; j < dgv_AllVedomostsResursob.ColumnCount; j++)
                            {
                                // dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.Font.Bold = true;

                                //цвет ты уже сама подберешь.... 


                                //dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                //dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.BackColor = Color.SlateGray;


                                //dgv_AllVedomostsResursob.Rows[k].Cells[j].Style.ForeColor = Color.White;
                                //dgv_AllVedomostsResursob.Rows[k].Cells[j].Style.BackColor = Color.SlateGray;



                                dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.BackColor = Color.Black;


                                dgv_AllVedomostsResursob.Rows[k].Cells[j].Style.ForeColor = Color.White;
                                dgv_AllVedomostsResursob.Rows[k].Cells[j].Style.BackColor = Color.Black;
                            }

                        }

                    }



                    //if (Convert.ToInt32(dgv_AllVedomostsResursob.Rows[i].Cells["kol1"].Value.ToString()) > Convert.ToInt32(dgv_AllVedomostsResursob.Rows[i].Cells["kol"].Value.ToString()))
                    //{
                    //    for (int j = 0; j < dgv_AllVedomostsResursob.ColumnCount; j++)
                    //    {
                    //        // dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.Font.Bold = true;
                    //        dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    //        dgv_AllVedomostsResursob.Rows[i].Cells[j].Style.BackColor = Color.Violet;

                    //    }
                    //}
                }






            }
            else 
            {
                btn_AvtomatAktF2.Visible = false;
            }
        }

        private void SettingsAllRepPlace()
        {
            if (dgv_RepPlace.RowCount > 0)
            {
                dgv_RepPlace.Columns["ReplacedId"].Visible = false;
                dgv_RepPlace.Columns["JobId"].Visible = false;
                dgv_RepPlace.Columns["PartId"].Visible = false;
                dgv_RepPlace.Columns["RepairID"].Visible = false;
                dgv_RepPlace.Columns["User_kol"].Visible = false;
                dgv_RepPlace.Columns["DataToday"].Visible = false;
                dgv_RepPlace.Columns["Original"].Visible = false;
                dgv_RepPlace.Columns["VedomostNumber"].Visible = false;
                dgv_RepPlace.Columns["Shpz"].Visible = false;
                dgv_RepPlace.Columns["Zavnom"].Visible = true;

                dgv_RepPlace.Columns["Quantity"].HeaderText = "Кол-во";
                dgv_RepPlace.Columns["EDNOME"].HeaderText = "Номер";
                dgv_RepPlace.Columns["DateinRep"].HeaderText = "Д.пост.";
                dgv_RepPlace.Columns["Name"].HeaderText = "Наименование";
                dgv_RepPlace.Columns["Mera"].HeaderText = "Ед.Изм";
                dgv_RepPlace.Columns["Prace"].HeaderText = "Цена";
                dgv_RepPlace.Columns["DataReplace"].HeaderText = "Д. уст.";
                dgv_RepPlace.Columns["tehno"].HeaderText = "Тех";
                dgv_RepPlace.Columns["norma"].HeaderText = "Нор";
                dgv_RepPlace.Columns["Zavnom"].HeaderText = "Завод.№";

                dgv_RepPlace.Columns["Quantity"].Width = 60;
                dgv_RepPlace.Columns["EDNOME"].Width = 50;
                dgv_RepPlace.Columns["DateinRep"].Width = 70;
                dgv_RepPlace.Columns["Name"].Width = 140;
                dgv_RepPlace.Columns["Mera"].Width = 30;
                dgv_RepPlace.Columns["Prace"].Width = 80;
                dgv_RepPlace.Columns["DataReplace"].Width = 70;
                dgv_RepPlace.Columns["tehno"].Width = 30;
                dgv_RepPlace.Columns["norma"].Width = 30;

                dgv_RepPlace.Columns["EDNOME"].DisplayIndex = 2;
                dgv_RepPlace.Columns["DateinRep"].DisplayIndex = 1;
                dgv_RepPlace.Columns["Name"].DisplayIndex = 3;
                dgv_RepPlace.Columns["Quantity"].DisplayIndex = 4;
                dgv_RepPlace.Columns["Mera"].DisplayIndex = 5;
                dgv_RepPlace.Columns["Prace"].DisplayIndex = 6;
                dgv_RepPlace.Columns["DataReplace"].DisplayIndex = 7;
                dgv_RepPlace.Columns["tehno"].DisplayIndex = 8;
                dgv_RepPlace.Columns["norma"].DisplayIndex = 9;
            }

        }

        private void SettingsAllVozvrDet()
        {
            if (dgv_Det.RowCount > 0)
            {
                dgv_Det.Columns["ID"].Visible = false;
                dgv_Det.Columns["DataToday"].Visible = false;
                dgv_Det.Columns["Original"].Visible = false;
                dgv_Det.Columns["RepairID"].Visible = false;
                dgv_Det.Columns["VedomostNumber"].Visible = false;

                dgv_Det.Columns["Name"].HeaderText = "Наименование";
                dgv_Det.Columns["Quantity"].HeaderText = "Кол-во";
                dgv_Det.Columns["Note"].HeaderText = "Прим.";
                dgv_Det.Columns["DataVozvr"].HeaderText = "Д.возвр.";

                dgv_Det.Columns["Name"].Width = 110;
                dgv_Det.Columns["Quantity"].Width = 60;
                dgv_Det.Columns["Note"].Width = 60;
                dgv_Det.Columns["DataVozvr"].Width = 70;
            }
        }


        private void SettingsAllVozvrMet()
        {
            if (dgv_Met.RowCount > 0)
            {
                dgv_Met.Columns["ID"].Visible = false;
                dgv_Met.Columns["DataToday"].Visible = false;
                dgv_Met.Columns["Original"].Visible = false;
                dgv_Met.Columns["RepairID"].Visible = false;
                dgv_Met.Columns["VedomostNumber"].Visible = false;

                dgv_Met.Columns["Name"].HeaderText = "Наименование";
                dgv_Met.Columns["EdIzm"].HeaderText = "Ед.Изм";
                dgv_Met.Columns["Price"].HeaderText = "Цена";
                dgv_Met.Columns["Quantity"].HeaderText = "Кол-во";
                dgv_Met.Columns["Sum"].HeaderText = "Сумма";
                dgv_Met.Columns["Note"].HeaderText = "Прим";
                dgv_Met.Columns["datavozvr"].HeaderText = "Д.возвр.";

                dgv_Met.Columns["Name"].Width = 90;
                dgv_Met.Columns["EdIzm"].Width = 40;
                dgv_Met.Columns["Price"].Width = 50;
                dgv_Met.Columns["Quantity"].Width = 60;
                dgv_Met.Columns["Sum"].Width = 50;
                dgv_Met.Columns["Note"].Width = 60;
                dgv_Met.Columns["datavozvr"].Width = 70;
            }
        }

        //удалить ведомость ресурсов
        private void btn_DelVedRes_Click(object sender, EventArgs e)
        {
            
             var res = MessageBox.Show("Действительно удалить ведомость?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (res == DialogResult.No)
             { 
                 return;
             }
        

            if (dgv_AllVedomostsResursob.RowCount > 0)
            {
                //MessageBox.Show(dgv_AllVedomostsResursob.CurrentRow.Cells["Original"].Value.ToString());
                 // string ff="";

                if (dgv_AllVedomostsResursob.CurrentRow.Cells["Original"].Value.ToString() == "0" )
                {
                    if (dal.DeleteVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()) == false)
                    {
                        MessageBox.Show("Где-то тут ошибка!");
                    }
                    else
                    {
                        dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1,PeriodData2_2);
                        SettingsAllVedRes();
                    }
                }
                else
                {
                    MessageBox.Show("Запись находится в состоянии оригинала");
                }

            }
            else
            {
                MessageBox.Show("Удалять нечего, или возникла другая ошибка! ");
            }
        }

        //обновление информации о ведомости ресурсов
        private void btn_UpdateVedRes_Click(object sender, EventArgs e)
        {
            int a = 0;

            if ((dgv_AllVedomostsResursob.RowCount > 0) && (dgv_AllVedomostsResursob.CurrentRow.Cells["Original"].Value.ToString() == "0"))
            {
                string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
                string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();
                string DateIn = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
                string DateOut = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
                string State1 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg1"].Value.ToString();
                string FIO1 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO1"].Value.ToString();
                string State2 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg2"].Value.ToString();
                string FIO2 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO2"].Value.ToString();

                string State3 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg3"].Value.ToString();
                string FIO3 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO3"].Value.ToString();
                string State4 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg4"].Value.ToString();
                string FIO4 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO4"].Value.ToString();

                //string State5 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg5"].Value.ToString();
                //string FIO5 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO5"].Value.ToString();

                string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();
                string Shpz = dgv_AllVedomostsResursob.CurrentRow.Cells["SHpz"].Value.ToString();

                string IspCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
                string IspUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
                string IspBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
                string IspDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();

                string kod_rem = dgv_AllVedomostsResursob.CurrentRow.Cells["kod_rem"].Value.ToString();

                a = dgv_AllVedomostsResursob.CurrentRow.Index;

                myfrmUpdateAllVedRes myfrmUpdateAllVedRes = new myfrmUpdateAllVedRes(NameOs, InvNumberOS, DateIn, DateOut,
                    State1, FIO1, State2, FIO2, State3, FIO3, State4, FIO4, ID, Shpz, IspCx, IspUch, IspBrig, IspDet, kod_rem);
                // myfrmUpdateAllVedRes.ShowDialog();

                if (myfrmUpdateAllVedRes.ShowDialog() == DialogResult.OK)
                {
                    dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
                    SettingsAllVedRes();
                    dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                    dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                    dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                    SettingsAllRepPlace();
                    SettingsAllVozvrDet();
                    SettingsAllVozvrMet();
                    dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
                    dgv_AllVedomostsResursob.Rows[a].Selected = true;
                    dgv_AllVedomostsResursob.CurrentCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"]; // возврат на прежднюю строку

                }
            }
            else
            {
                MessageBox.Show("Нечего редактировать или запись находится в состоянии оригинала! ");
            }
        }

        private void btn_alterRepair_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;

            Vedomost.Id = dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString();
            myfrmUpdateReplacedPart myfrmUpdateReplacedPart = new myfrmUpdateReplacedPart();
            myfrmUpdateReplacedPart.ShowDialog();

            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
            SettingsAllVedRes();
            dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            SettingsAllRepPlace();
            SettingsAllVozvrDet();
            SettingsAllVozvrMet();
            dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
            dgv_AllVedomostsResursob.Rows[a].Selected = true;




        }

        private void dgv_RepPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1,PeriodData2_2);
                //dgv_AllVedomostsResursob.DataSource =dal.GetAllVedomostsResursov(string PeriodData2_1, string PeriodData2_2);
                SettingsAllVedRes();

            }

        }


        private void SearchForInventory()
        {

            dgv_AllVedomostsResursob.ReadOnly = false;
            for (int i = 0; i < dgv_AllVedomostsResursob.RowCount; i++)
            {
                if (dgv_AllVedomostsResursob.Rows[i].Cells["InventoryNamber"].Value.ToString().Contains(txt_SearchInv.Text) == false)
                {
                    dgv_AllVedomostsResursob.CurrentCell = null;
                    dgv_AllVedomostsResursob.Rows[i].Visible = false;
                }
            }

        }
        //Обновление информации о форме 2
        private void btn_Update_F_2_Click(object sender, EventArgs e)
        {
            if ((dgv_AllVedomostsResursob.RowCount > 0) && (dgv_AllVedomostsResursob.CurrentRow.Cells["Original"].Value.ToString() == "0"))
            {
                string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
                string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();
                //  string DateIn = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
                //  string DateOut = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
                //string State1 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg1f2"].Value.ToString();
                string FIO1 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO1f2"].Value.ToString();
                //string State2 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg2f2"].Value.ToString();
                string FIO2 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO2f2"].Value.ToString();

                //string State3 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg3f2"].Value.ToString();
                string FIO3 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO3f2"].Value.ToString();
                //string State4 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg4f2"].Value.ToString();
                string FIO4 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO4f2"].Value.ToString();
                string FIO5 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO5f2"].Value.ToString();

                string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();
                string Shpz = dgv_AllVedomostsResursob.CurrentRow.Cells["SHpz"].Value.ToString();

                string IspCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
                string IspUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
                string IspBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
                string IspDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();

                myfrmUpdateAllForm2 myfrmUpdateAllForm2 = new myfrmUpdateAllForm2(NameOs, InvNumberOS,
                     FIO1, FIO2, FIO3, FIO4, ID, IspCx, IspUch, IspBrig, IspDet);
                // myfrmUpdateAllVedRes.ShowDialog();

                if (myfrmUpdateAllForm2.ShowDialog() == DialogResult.OK)
                {
                    dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);

                    SettingsAllVedRes();
                    dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                    dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                    dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
                    SettingsAllRepPlace();
                    SettingsAllVozvrDet();
                    SettingsAllVozvrMet();
                }
            }
            else
            {
                MessageBox.Show("Нечего редактировать или запись находится в состоянии оригинала! Форма 2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.RepairOSConnStr))
            {
                try
                {
                    conn.Open();
                    //заполняем список запчастей 
                    SqlCommand cmd2 = new SqlCommand("NewVRRepPart", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd2.ExecuteNonQuery();
                    //заполняем возвратные детали
                    SqlCommand cmd3 = new SqlCommand("NewVRVozvrDet", conn);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd3.ExecuteNonQuery();
                    //заполняем возвратный металлолом
                    SqlCommand cmd4 = new SqlCommand("NewVRVozvrMet", conn);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd4.ExecuteNonQuery();
                    //заполняем шапку ведомости ресурсов 
                    SqlCommand cmd1 = new SqlCommand("NewVRVedRes", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@VRNumber", Convert.ToInt32(dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            myfrmPrintForm2 myfrmPrintForm2 = new myfrmPrintForm2();
            myfrmPrintForm2.ShowDialog();
        }

        private void btn_ProizTezhOtchet_Click(object sender, EventArgs e)
        {
            myfrmProizvodstvennoTehOtchet myfrmProizvodstvennoTehOtchet = new myfrmProizvodstvennoTehOtchet();
            myfrmProizvodstvennoTehOtchet.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_AllVedomostsResursob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
           /* if (this.Text.Count()>58)
            {
                this.Text=this.Text.Remove(58);       
            }

            string connection_string = Properties.Settings.Default.RepairOSConnStr;
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string InventoryNumber  = dgv_AllVedomostsResursob.Rows[e.RowIndex].Cells[4].Value.ToString();
            string RepairID         =   string.Empty;
            string JobCode          =   string.Empty;
            string JobName          =   string.Empty;
            

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP (1) *  FROM [Repairs].[dbo].[Repair] where InventoryNumber = '" + InventoryNumber + "' order by datein desc",conn);
            SqlDataReader dr = sqlCommand.ExecuteReader(); 
            if (dr.HasRows)
            {
                while (dr.Read())
                {   
                    RepairID = dr.GetValue(0).ToString();
                }
            }
            else{}
            dr.Close();

            sqlCommand.CommandText = "SELECT TOP (1) [JobId],[RepairId],[JobCode] FROM [Repairs].[dbo].[Job] where RepairId = " + RepairID;   
            dr = sqlCommand.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    JobCode = dr.GetValue(2).ToString(); 
                }
            }
            else{}
            dr.Close();

            
            sqlCommand.CommandText = "SELECT TOP(1)[JobName] FROM[Repairs].[dbo].[RefJob] where JobCode = " + JobCode;
            if (JobCode.Length > 0)
            {
                dr = sqlCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        JobName = dr.GetValue(0).ToString();
                    }
                }
                else { }
                dr.Close();
            }
            
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
             
            this.Text += "   |    \"" + JobName + "\"";
            conn.Close();*/
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;

            string vsegoZP = dgv_AllVedomostsResursob.CurrentRow.Cells["vsegoZP"].Value.ToString();
            string sumNalogov = dgv_AllVedomostsResursob.CurrentRow.Cells["sumNalogov"].Value.ToString();
            string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();
            string cexVitrProc = dgv_AllVedomostsResursob.CurrentRow.Cells["cexVitrProc"].Value.ToString();
            string amortProc = dgv_AllVedomostsResursob.CurrentRow.Cells["amortProc"].Value.ToString();
            string TZV = dgv_AllVedomostsResursob.CurrentRow.Cells["TZV"].Value.ToString();


            string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
            string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();
            string Obekt = dgv_AllVedomostsResursob.CurrentRow.Cells["Obekt"].Value.ToString();
            string State1 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg1f2"].Value.ToString();
            string FIO1 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO1f2"].Value.ToString();
            string State2 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg2f2"].Value.ToString();
            string FIO2 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO2f2"].Value.ToString();

            string State3 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg3f2"].Value.ToString();
            string FIO3 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO3f2"].Value.ToString();
            string State4 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg4f2"].Value.ToString();
            string FIO4 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO4f2"].Value.ToString();

            string State5 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg5f2"].Value.ToString();
            string FIO5 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO5f2"].Value.ToString();

            //string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();
            string Shpz = dgv_AllVedomostsResursob.CurrentRow.Cells["SHpz"].Value.ToString();

            string IspCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            string IspUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
            string IspBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
            string IspDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();


            string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
            string PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
            string mes = PeriodData1.Substring(3, 2);
            string god = PeriodData1.Substring(6, 4);

            //string IspBrig2 = (IspBrig.ToString()== null ? "0" : IspBrig.ToString());   // iif

            string VidrahProc = dgv_AllVedomostsResursob.CurrentRow.Cells["VidrahProc"].Value.ToString();
            string VsegoMat = dgv_AllVedomostsResursob.CurrentRow.Cells["VsegoMat"].Value.ToString();
            string TzvGrn = dgv_AllVedomostsResursob.CurrentRow.Cells["TzvGrn"].Value.ToString();
            string CehVitrGrn = dgv_AllVedomostsResursob.CurrentRow.Cells["CehVitrGrn"].Value.ToString();
            string AmortGrn = dgv_AllVedomostsResursob.CurrentRow.Cells["AmortGrn"].Value.ToString();
            string Vsego_F = dgv_AllVedomostsResursob.CurrentRow.Cells["Vsego_F"].Value.ToString();
            string Rep_ID = dgv_AllVedomostsResursob.CurrentRow.Cells["RepairID"].Value.ToString();

            myfrmProcentsForAKT myfrmProcentsForAKT = new myfrmProcentsForAKT(ID, vsegoZP, sumNalogov, cexVitrProc, amortProc, TZV,
                NameOs, InvNumberOS, FIO1, State1, FIO2, State2, FIO3, State3, FIO4, State4, IspCx, IspUch, IspBrig, IspDet, mes, god, FIO5, State5,Obekt,PeriodData2,
                VidrahProc, VsegoMat, TzvGrn, CehVitrGrn, AmortGrn, Vsego_F, Shpz,"rem",Rep_ID,"","","");
            myfrmProcentsForAKT.ShowDialog();


            // if (myfrmProcentsForAKT.ShowDialog() == DialogResult.OK)
            //{
            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
            SettingsAllVedRes();
            dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            SettingsAllRepPlace();
            SettingsAllVozvrDet();
            SettingsAllVozvrMet();

            dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
            dgv_AllVedomostsResursob.Rows[a].Selected = true;
            dgv_AllVedomostsResursob.CurrentCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"]; // возврат на прежднюю строку

            //}
            //else
            //{
            //    MessageBox.Show("DialogResult.No");
            //}



        }

        private void button1_Click_3(object sender, EventArgs e) //Печать АКТа
        {
            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;

            DAL dal = new DAL();
            string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();

            string shpz = dgv_AllVedomostsResursob.CurrentRow.Cells["SHpz"].Value.ToString();



            //double vsegoZP = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["vsegoZP"].Value.ToString()), 2));
            //double sumNalogov = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["sumNalogov"].Value.ToString()), 2));
            //double cexVitrProc = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["cexVitrProc"].Value.ToString()), 2));
            //double amortProc = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["amortProc"].Value.ToString()), 2));
            //double TZV = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["TZV"].Value.ToString()), 2));
            //double Sum_mater = Math.Round(dal.sum_mater(Convert.ToInt32(ID)), 2);
            if (String.IsNullOrEmpty(dgv_AllVedomostsResursob.CurrentRow.Cells["vsegoZP"].Value.ToString())) vsegoZP = 0d;
            else vsegoZP = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["vsegoZP"].Value.ToString()), 2));

             

            if (String.IsNullOrEmpty(dgv_AllVedomostsResursob.CurrentRow.Cells["sumNalogov"].Value.ToString())) sumNalogov = 0d;
            else sumNalogov = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["sumNalogov"].Value.ToString()), 2));
            //vsegoZP = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["vsegoZP"].Value.ToString()), 2));
            //sumNalogov = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["sumNalogov"].Value.ToString()), 2));
            try
            {
                cexVitrProc = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["cexVitrProc"].Value.ToString().Replace(".", ",")), 2));
                amortProc = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["amortProc"].Value.ToString()), 2));
                TZV = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["TZV"].Value.ToString()), 2));
            }
            catch
            {
                
                MessageBox.Show("Нельзя распечатать, потому что в ведомости нет полной информации о зарплате! Зайдите в % по АКТу(ф2) и последовательно выполните 3 действия:\n1. Перенести ЗП в відрах\n2. Перерахувати\n3. Зберегти зміни");
                return;
            }
            //*-
            Sum_mater = Math.Round(dal.sum_mater(Convert.ToInt32(ID)), 2);


            string zaversh = dgv_AllVedomostsResursob.CurrentRow.Cells["zaversh"].Value.ToString();
            //double VidrahProc2 = 0;
            //double VsegoMat2 = 0;
            //double TzvGrn2 = 0;
            //double CehVitrGrn2 = 0;
            //double AmortGrn2 = 0;
            //double Vsego_F2 = 0;

            //VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F


            
            string vsegomat = Sum_mater.ToString();


            string State1 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg1f2"].Value.ToString();
            string FIO1 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO1f2"].Value.ToString();
            string State2 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg2f2"].Value.ToString();
            string FIO2 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO2f2"].Value.ToString();

            string State3 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg3f2"].Value.ToString();
            string FIO3 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO3f2"].Value.ToString();
            string State4 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg4f2"].Value.ToString();
            string FIO4 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO4f2"].Value.ToString();

            string State5 = dgv_AllVedomostsResursob.CurrentRow.Cells["dolg5f2"].Value.ToString();
            string FIO5 = dgv_AllVedomostsResursob.CurrentRow.Cells["FIO5f2"].Value.ToString();

            if (FIO5 == null || FIO5 == "")
                FIO5 = "";

            if (State5 == null || State5 == "")
                State5 = "";


            string ZakCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_codcx"].Value.ToString();
            string ZakUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_coduth"].Value.ToString();
            string ZakBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_codbrig"].Value.ToString();
            string ZakDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_coddet"].Value.ToString();

            string IspCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            string IspUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
            string IspBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
            string IspDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();

            string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
            string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();

            string Obekt = dgv_AllVedomostsResursob.CurrentRow.Cells["Obekt"].Value.ToString();

            string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
            string PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();


             double CexVitrGrn = 0;
                double AmortGrn = 0;
                double VidrahProc =0;
                double TZVGrn = 0;
                double SumVsegoo =0;
                string SumVsego = "0";

                if (Convert.ToDateTime(PeriodData2.ToString()).Year < 2018)
                {
                    if (IspCx == "54")
                    {
                        TZVGrn = Math.Round(Math.Round(Sum_mater, 2) * Math.Round(TZV, 2) / 100, 2);
                        string PD2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
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

                    VidrahProc = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["VidrahProc"].Value.ToString()), 2));
                    vsegomat = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["VsegoMat"].Value.ToString()), 2)).ToString();
                    TZVGrn = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["TzvGrn"].Value.ToString()), 2));
                    CexVitrGrn = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["CehVitrGrn"].Value.ToString()), 2));
                    AmortGrn = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["AmortGrn"].Value.ToString()), 2));
                    SumVsegoo = (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["Vsego_F"].Value.ToString()), 2));
                    //MessageBox.Show("2018");
                    

                    //VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F


                }


            if (dal.DelFromTmp_JobAKT() == true) //очищаем временную табличку Tmp_JobAKT
            {
            }

            if (dal.SaveToTmp_JobAKT_Step1(ID,"rem") == true)  //заполняем временную табличку Tmp_JobAKT шаг1
            {
                // MessageBox.Show("Виконано");
            }
            else
            {
                //MessageBox.Show("Error.Step1.");
            }

            if (dal.SaveToTmp_JobAKT_Step2(ID,"rem") == true)  //заполняем временную табличку Tmp_JobAKT шаг2
            {
                //MessageBox.Show("Виконано");
            }
            else
            {
                //MessageBox.Show("Error.Step2.");
            }

            //// Передаем параметры в отчет
            // reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date1", date1T));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date2", date2T));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fulname", s));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("podpis", name));

            //this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.Fill(this.RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF, d1,
            //   d2, ceh, uch, brig, det);
            //this.reportViewer1.RefreshReport();
            //reportViewer1.RefreshReport();



            //string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
            //string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();

            //string Obekt = dgv_AllVedomostsResursob.CurrentRow.Cells["Obekt"].Value.ToString();
            //string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
            //string PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();



            //frmPrintAktF2 frmPrintAktF2 = new frmPrintAktF2(ID,shpz, Math.Round(vsegoZP,2), Math.Round(sumNalogov,2), Math.Round(cexVitrProc,2), Math.Round(amortProc,2),
            //    Math.Round(TZV,2),vsegomat,
            //    ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, State1,FIO1,State2,FIO2,State3,FIO3,State4,FIO4,
            //    NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, SumVsego, FIO5, State5);
            //frmPrintAktF2.ShowDialog();
             
            frmPrintAktF2 frmPrintAktF2 = new frmPrintAktF2(ID, shpz, Math.Round(vsegoZP, 2), Math.Round(sumNalogov, 2), Math.Round(cexVitrProc, 2), Math.Round(amortProc, 2),
                            Math.Round(TZV, 2), vsegomat,
                            ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, State1, FIO1, State2, FIO2, State3, FIO3, State4, FIO4,
                            NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, SumVsego, FIO5, State5, VidrahProc, TZVGrn, CexVitrGrn, AmortGrn, SumVsegoo, zaversh,"","");
            frmPrintAktF2.ShowDialog();
            dgv_AllVedomostsResursob.Rows[a].Selected = true;

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;

            string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
            string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();
            string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();
            string Repair_id=dgv_AllVedomostsResursob.CurrentRow.Cells["RepairID"].Value.ToString();


            myfrmJobsForAKT myfrmJobsForAKT = new myfrmJobsForAKT(ID, NameOs, InvNumberOS, "rem", Repair_id);
            myfrmJobsForAKT.ShowDialog();


            // if (myfrmProcentsForAKT.ShowDialog() == DialogResult.OK)
            //{
            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
            SettingsAllVedRes();
            dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            SettingsAllRepPlace();
            SettingsAllVozvrDet();
            SettingsAllVozvrMet();

            dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
            dgv_AllVedomostsResursob.Rows[a].Selected = true;
            dgv_AllVedomostsResursob.CurrentCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"]; // возврат на прежднюю строку

        }

        SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True");
        private void button2_Click(object sender, EventArgs e)
        {
            
            //string isp_codcx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            //string PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
            //string mes = PeriodData2.Substring(3, 2);
            //string god = PeriodData2.Substring(6, 4);
            //string canshifr = "no";
            
            //////найдем раб.месяц,год по цеху
            //cn.Open();
            //DataTable tab_rab_mes = new DataTable();
            //    SqlCommand cm2 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
            //    SqlDataReader dr = cm2.ExecuteReader();  // Выполняем выборку
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //           //MessageBox.Show(dr.GetValue(0) + " - " + dr.GetValue(1) + " - " + dr.GetValue(2)); //  Берем из строки значения StoreId,god,mes
            //            string rabmes = dr.GetValue(1).ToString(); // нашли текущий месяц
            //            string rabgod = dr.GetValue(2).ToString(); // нашли текущий год
            //            //tab_rab_mes.Rows.Add(dr["StoreId"].ToString(),
            //              //                   dr["god"].ToString(),
            //                //                 dr["mes"].ToString());
            //        }

            //        //MessageBox.Show("Робочий місяць - " + tab_rab_mes.["StoreId"].ToString());
            //        canshifr = "yes";
            //    }
            //    else
            //    {
            //        MessageBox.Show("Шифрування неможливе. Не знайден цех " + isp_codcx.ToString() + " в довіднику цехів.");
            //        canshifr = "no";
            //    }
            //    dr.Close();
            //cn.Close();
        }



        private void btn_UpdateShpz_Click(object sender, EventArgs e)
        {
            //int a = 0;
            //a = dgv_AllVedomostsResursob.CurrentRow.Index;

            //DAL dal = new DAL();
            //string shpz;
            //int kodrem;
            //int cex;
            //string rabmes;
            //string rabgod;
            //string isp_codcx;
            //string canshifr;


            //shpz = "2310401";
            //shpz = "1/1";
            //kodrem = 1;
            //cex = 1;


            //dgv_mes_god_ceh.DataSource = dal.TekMesGodForCeh(cex.ToString());
            //string tek_mes_ceh = dgv_mes_god_ceh.CurrentRow.Cells["mes"].Value.ToString();
            //string tek_god_ceh = dgv_mes_god_ceh.CurrentRow.Cells["god"].Value.ToString();
            //if (tek_mes_ceh == "" || tek_mes_ceh == "0" || tek_god_ceh == "" || tek_god_ceh == "0")
            //{
            //    canshifr = "yes";
            //}
            //else
            //    canshifr = "no";
            //{

            //}

            //MessageBox.Show(canshifr.ToString() + tek_god_ceh.ToString() + tek_mes_ceh.ToString() + cex.ToString());
            ////////********* 1

        ////////       shpz = "232000";
        ////////       shpz = "1/54";
        ////////       kodrem = 1;
        ////////       cex = 54;

               //if (canshifr == "yes")
               //{
               //    if (dal.UpdateShpz(shpz, tek_mes_ceh, tek_god_ceh, kodrem, cex) == true)  // проставляем ШПЗ
               //    {
               //        MessageBox.Show("Виконано");
               //    }
               //    else
               //    {
               //        MessageBox.Show("Не виконано ТО (1).");
               //    }
               //}
               //else
               //{
               //    MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");
               //}









        ////////     выбираем текущий месяц год по цеху 54
        ////////    ********** 1
        ////////       isp_codcx = cex.ToString();
        ////////       canshifr = "no";
        ////////       rabmes = "";
        ////////       rabgod = "";
        ////////       //найдем раб.месяц,год по цеху
        ////////       cn.Open();
        ////////       DataTable tab_rab_mes1 = new DataTable();
        ////////       SqlCommand cm1 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
        ////////       SqlDataReader dr1 = cm1.ExecuteReader();  // Выполняем выборку
        ////////       if (dr1.HasRows)
        ////////       {
                   
        ////////           rabmes = (string)dr1["mes"];
        ////////           rabgod = (string)dr1["god"];
        ////////           rabmes =  dr1.GetValue(2).ToString(); // нашли текущий месяц
        ////////           rabgod = dr1.GetValue(1).ToString(); 

        ////////           Debug.Write("-----------------------");
        ////////           Debug.Write(rabmes);
        ////////           Debug.Write(rabgod);
        ////////           Debug.Write("-----------------------");


        ////////           canshifr = "yes";
        ////////       }
        ////////       else
        ////////       {
        ////////           canshifr = "no";
        ////////       }
        ////////       dr1.Close();
        ////////       cn.Close();
        ////////    ********* 1
        ////////       if (canshifr == "yes")
        ////////       {
        ////////           if (dal.UpdateShpz(shpz, rabmes, rabgod, kodrem, cex) == true)  // проставляем ШПЗ
        ////////           {
        ////////                MessageBox.Show("Виконано");
        ////////           }
        ////////           else
        ////////           {
        ////////                 MessageBox.Show("Не виконано ТО1 (54).");
        ////////           }
        ////////       }
        ////////       else
        ////////       {
        ////////           MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");               
        ////////       }



        ////////    2
        ////////    shpz = "232000";
        ////////    shpz = "2/54";
        ////////    kodrem = 2;
        ////////    cex = 54;
        ////////    ********** 2
        ////////    isp_codcx = cex.ToString();
        ////////    canshifr = "no";
        ////////    rabmes = "";
        ////////    rabgod = "";
        ////////    //найдем раб.месяц,год по цеху
        ////////    cn.Open();
        ////////    DataTable tab_rab_mes2 = new DataTable();
        ////////    SqlCommand cm2 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
        ////////    SqlDataReader dr2 = cm2.ExecuteReader();  // Выполняем выборку
        ////////    if (dr2.HasRows)
        ////////    {
        ////////        rabmes = dr2.GetValue(2).ToString(); // нашли текущий месяц
        ////////        rabgod = dr2.GetValue(1).ToString();
        ////////        canshifr = "yes";
        ////////    }
        ////////    else
        ////////    {
        ////////        canshifr = "no";
        ////////    }
        ////////    dr2.Close();
        ////////    cn.Close();
        ////////    ********* 2

        ////////    if (canshifr == "yes")
        ////////       {

        ////////            if (dal.UpdateShpz(shpz, rabmes, rabgod, kodrem, cex) == true)  // проставляем ШПЗ
        ////////            {
        ////////                 MessageBox.Show("Виконано");
        ////////            }
        ////////            else
        ////////            {
        ////////         MessageBox.Show("Не виконано ТО2 (54).");
        ////////            }
        ////////         }
        ////////     else
        ////////     {
        ////////        MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");
        ////////     }



        ////////    3
        ////////    shpz = "232000";
        ////////    shpz = "2/54";
        ////////    kodrem = 2;
        ////////    cex = 51;
        ////////    ********** 3
        ////////    isp_codcx = cex.ToString();
        ////////    canshifr = "no";
        ////////    rabmes = "";
        ////////    rabgod = "";
        ////////    //найдем раб.месяц,год по цеху
        ////////    cn.Open();
        ////////    DataTable tab_rab_mes3 = new DataTable();
        ////////    SqlCommand cm3 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
        ////////    SqlDataReader dr3 = cm3.ExecuteReader();  // Выполняем выборку
        ////////    if (dr3.HasRows)
        ////////    {
        ////////        rabmes = dr3.GetValue(2).ToString(); // нашли текущий месяц
        ////////        rabgod = dr3.GetValue(1).ToString();
        ////////        canshifr = "yes";
        ////////    }
        ////////    else
        ////////    {
        ////////        canshifr = "no";
        ////////    }
        ////////    dr3.Close();
        ////////    cn.Close();
        ////////    ********* 3

        ////////    if (canshifr == "yes")
        ////////    {
        ////////        if (dal.UpdateShpz(shpz, rabmes, rabgod, kodrem, cex) == true)  // проставляем ШПЗ
        ////////        {
        ////////             MessageBox.Show("Виконано");
        ////////        }
        ////////        else
        ////////        {
        ////////             MessageBox.Show("Не виконано ТО2 (54).");
        ////////        }
        ////////    }
        ////////    else
        ////////    {
        ////////        MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");
        ////////    }


        ////////    4
        ////////    shpz = "2310401";
        ////////    shpz = "1/1";
        ////////    kodrem = 1;
        ////////    cex = 1;
        ////////    ********** 4
        ////////    isp_codcx = cex.ToString();
        ////////    canshifr = "no";
        ////////    rabmes = "";
        ////////    rabgod = "";
        ////////    //найдем раб.месяц,год по цеху
        ////////    cn.Open();
        ////////    DataTable tab_rab_mes4 = new DataTable();
        ////////    SqlCommand cm4 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
        ////////    SqlDataReader dr4 = cm4.ExecuteReader();  // Выполняем выборку
        ////////    if (dr4.HasRows)
        ////////    {
        ////////        rabmes = dr4.GetValue(2).ToString(); // нашли текущий месяц
        ////////        rabgod = dr4.GetValue(1).ToString();
        ////////        canshifr = "yes";
        ////////    }
        ////////    else
        ////////    {
        ////////        canshifr = "no";
        ////////    }
        ////////    dr4.Close();
        ////////    cn.Close();
        ////////    ********* 4

        ////////    if (canshifr == "yes")
        ////////    {

        ////////        select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=1 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) and Ispolnitel_codcx=1--ТО
        ////////        select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=2 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) and Ispolnitel_codcx=1--ТО
        ////////        if (dal.UpdateShpz(shpz, rabmes, rabgod, kodrem, cex) == true)  // проставляем ШПЗ
        ////////        {
        ////////             MessageBox.Show("Виконано");
        ////////        }
        ////////        else
        ////////        {
        ////////             MessageBox.Show("Не виконано ТО1 (1).");
        ////////        }
        ////////    }
        ////////    else
        ////////    {
        ////////        MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");
        ////////    }



        ////////    shpz = "2310401";
        ////////    shpz = "2/1";
        ////////    kodrem = 2;
        ////////    cex = 1;
        ////////    ********** 5
        ////////    isp_codcx = cex.ToString();
        ////////    canshifr = "no";
        ////////    rabmes = "";
        ////////    rabgod = "";
        ////////    //найдем раб.месяц,год по цеху
        ////////    cn.Open();
        ////////    DataTable tab_rab_mes5 = new DataTable();
        ////////    SqlCommand cm5 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
        ////////    SqlDataReader dr5 = cm4.ExecuteReader();  // Выполняем выборку
        ////////    if (dr5.HasRows)
        ////////    {
        ////////        rabmes = dr5.GetValue(2).ToString(); // нашли текущий месяц
        ////////        rabgod = dr5.GetValue(1).ToString();
        ////////        canshifr = "yes";
        ////////    }
        ////////    else
        ////////    {
        ////////        canshifr = "no";
        ////////    }
        ////////    dr5.Close();
        ////////    cn.Close();
        ////////    ********* 5

        ////////    select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=1 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) and Ispolnitel_codcx=1--ТО
        ////////    select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=2 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) and Ispolnitel_codcx=1--ТО

        ////////    if (canshifr == "yes")
        ////////    {

        ////////        if (dal.UpdateShpz(shpz, rabmes, rabgod, kodrem, cex) == true)  // проставляем ШПЗ
        ////////        {
        ////////             MessageBox.Show("Виконано");
        ////////        }
        ////////        else
        ////////        {
        ////////               MessageBox.Show("Не виконано ТО2 (1).");
        ////////        }
        ////////    }
        ////////    else 
        ////////    {
        ////////        MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");
        ////////    }

        ////////    shpz = "2310405";
        ////////    shpz = "1/5";
        ////////    kodrem = 1;
        ////////    cex = 5;
        ////////    ********** 6
        ////////    isp_codcx = cex.ToString();
        ////////    canshifr = "no";
        ////////    rabmes = "";
        ////////    rabgod = "";
        ////////    //найдем раб.месяц,год по цеху
        ////////    cn.Open();
        ////////    DataTable tab_rab_mes6 = new DataTable();
        ////////    SqlCommand cm6 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
        ////////    SqlDataReader dr6 = cm4.ExecuteReader();  // Выполняем выборку
        ////////    if (dr6.HasRows)
        ////////    {
        ////////        rabmes = dr6.GetValue(2).ToString(); // нашли текущий месяц
        ////////        rabgod = dr6.GetValue(1).ToString();
        ////////        canshifr = "yes";
        ////////    }
        ////////    else
        ////////    {
        ////////        canshifr = "no";
        ////////    }
        ////////    dr6.Close();
        ////////    cn.Close();
        ////////    ********* 6

        ////////    select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=1 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) and Ispolnitel_codcx=5--ТО
        ////////    select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=2 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) and Ispolnitel_codcx=5--ТО
        ////////    if (canshifr == "yes")
        ////////    {

        ////////        if (dal.UpdateShpz(shpz, rabmes, rabgod, kodrem, cex) == true)  // проставляем ШПЗ
        ////////        {
        ////////             MessageBox.Show("Виконано");
        ////////        }
        ////////        else
        ////////        {
        ////////             MessageBox.Show("Не виконано ТО1 (5).");
        ////////        }
        ////////    }
        ////////    else
        ////////    {
        ////////        MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");
        ////////    }

        ////////    shpz = "2310405";
        ////////    shpz = "2/5";
        ////////    kodrem = 2;
        ////////    cex = 5;
        ////////    ********** 7
        ////////    isp_codcx = cex.ToString();
        ////////    canshifr = "no";
        ////////    rabmes = "";
        ////////    rabgod = "";
        ////////    //найдем раб.месяц,год по цеху
        ////////    cn.Open();
        ////////    DataTable tab_rab_mes7 = new DataTable();
        ////////    SqlCommand cm7 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId = " + isp_codcx, cn);
        ////////    SqlDataReader dr7 = cm7.ExecuteReader();  // Выполняем выборку
        ////////    if (dr7.HasRows)
        ////////    {
        ////////        rabmes = dr7.GetValue(2).ToString(); // нашли текущий месяц
        ////////        rabgod = dr7.GetValue(1).ToString();
        ////////        canshifr = "yes";
        ////////    }
        ////////    else
        ////////    {
        ////////        canshifr = "no";
        ////////    }
        ////////    dr7.Close();
        ////////    cn.Close();
        ////////    ********* 7

        ////////    if (canshifr == "yes")
        ////////    {

        ////////        if (dal.UpdateShpz(shpz, rabmes, rabgod, kodrem, cex) == true)  // проставляем ШПЗ
        ////////        {
        ////////             MessageBox.Show("Виконано");
        ////////        }
        ////////        else
        ////////        {
        ////////              MessageBox.Show("Не виконано ТО2 (5).");
        ////////        }
        ////////    }
        ////////    else
        ////////    {
        ////////        MessageBox.Show("Цех не прошифрован. Не знайден цех " + cex.ToString() + " в довіднику цехів.");
        ////////    }

        ////////    shpz = "910100";
        ////////    shpz = "55";
        ////////    kodrem = 5;
        ////////    select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=5 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) --Поточ.рем

        ////////    if (dal.UpdateShpz2(shpz, kodrem) == true)  // проставляем ШПЗ
        ////////    {
        ////////         MessageBox.Show("Виконано");
        ////////    }
        ////////    else
        ////////    {
        ////////          MessageBox.Show("Не виконано Поточ.рем.(5)");
        ////////    }


        ////////    shpz = "910200";
        ////////    shpz = "66";
        ////////    kodrem = 6;
        ////////    if (dal.UpdateShpz2(shpz, kodrem) == true)  // проставляем ШПЗ
        ////////    {
        ////////         MessageBox.Show("Виконано");
        ////////    }
        ////////    else
        ////////    {
        ////////          MessageBox.Show("Не виконано Кап.рем.(6)");
        ////////    }
        ////////    select * from Vedomost_Resursov where month(PeriodData2)=4 and year(PeriodData2)=2016 and kod_rem=6 and ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) --Кап.рем.

            //MessageBox.Show("Виконано.");


            //dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov();
            //SettingsAllVedRes();
            //dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            //dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            //dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            //SettingsAllRepPlace();
            //SettingsAllVozvrDet();
            //SettingsAllVozvrMet();

            //dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
            //dgv_AllVedomostsResursob.Rows[a].Selected = true;


        }




        private void button3_Click(object sender, EventArgs e)
        {

            ////notifyIcon1.Visible = true;
            //notifyIcon1.Icon = SystemIcons.Application;
            ////notifyIcon1.BalloonTipTitle = "Balloon Tip Title";
            //notifyIcon1.BalloonTipText = "Balloon Tip Text.";
            //notifyIcon1.ShowBalloonTip(3000);

        }

        //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True");

        private void button3_Click_1(object sender, EventArgs e)
        {

            //// проверка на рабочий месяц
            //string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
            //string isp_codcx =  dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            //string mes = PeriodData1.Substring(3, 2);
            //string god = PeriodData1.Substring(6, 4);
            //string ffound = "no";
            ////string pravo_vip = "no";
            //// Определяем какой рабочий месяц по цеху исполнителю
            //cn.Open();
            //SqlCommand cm1 = new SqlCommand("select count(StoreId) as kolstr from  [Repairs].[dbo].[Status_mes_ceh] where StoreId = " + isp_codcx.ToString(), cn);
            //Debug.WriteLine(cm1.CommandText);

            //int kolstr = Convert.ToInt32(cm1.ExecuteScalar()); // Взяли значение из первой левой ячейки
            //switch (kolstr) 
            //{
            //    case 1:
            //             ffound = "yes";
            //             break;
            //    case 0:
            //             MessageBox.Show("Не знайдено цеха в довіднику Store");
            //             ffound = "no";
            //             break;
            //    default:
            //              MessageBox.Show("В довіднику Store більше одного запису по цеху: "+isp_codcx.ToString() );
            //              ffound = "no";
            //              break;
            //}
            //if (ffound == "yes")
            //{
            //    SqlCommand cm2 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where mes = " + mes + " and god = " + god + " and StoreId = " + isp_codcx, cn);
            //    SqlDataReader dr = cm2.ExecuteReader();  // Выполняем выборку
            //    if (dr.HasRows)
            //    {
            //      btn_DelVedRes.Enabled=true;
            //      btn_UpdateVedRes.Enabled=true; 
            //    }
            //    else
            //    {
            //      btn_DelVedRes.Enabled= false ;
            //      btn_UpdateVedRes.Enabled= false  ; 
                
            //    }


            //    dr.Close(); 
                
            //    //    MessageBox.Show("Ви не маєте прав. Робочий місяць - "+tek_mes.ToString()+"  "+tek_god.ToString()+"p.");
            //    }

            //cn.Close();

            }

        private void btn_UpdateShpz_Click_1(object sender, EventArgs e)
        {

            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;

            DAL dal = new DAL();

            int ceh ;
            ceh=1;
            string shpz;
            shpz = "";
            string canshifr = "no";
            
            Debug.WriteLine("--------------------");
            cn.Open();
            SqlCommand s0 = new SqlCommand("select god from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            int tekgod = Convert.ToInt32(s0.ExecuteScalar());
            Debug.WriteLine(tek_god.ToString());
            cn.Close();

            cn.Open();
            SqlCommand s1 = new SqlCommand("select mes from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            int tekmes = Convert.ToInt32(s1.ExecuteScalar());
            Debug.WriteLine(tek_mes.ToString());
            cn.Close();
            Debug.WriteLine("--------------------");


            if (tekgod==0 || tekgod==null || tekmes==0 || tekmes==null )
            {
                canshifr = "no";
            }
            else
            {
                canshifr = "yes";
            }




            if (canshifr == "yes")
            {

                Debug.WriteLine("can ");
                int kodrem = 1;
                shpz = "2310401";
                //ceh = 1;

                if (dal.UpdateShpz(shpz, tekmes.ToString(), tekgod.ToString(), kodrem, ceh) == true)  // проставляем ШПЗ
                {
                    // MessageBox.Show("Виконано");
                }
                else
                {
                      //MessageBox.Show("Не виконано  kod_rem=1 cex=1");
                }
                kodrem = 2;
                shpz = "2310401";
                //ceh = 1;

                if (dal.UpdateShpz(shpz, tekmes.ToString(), tekgod.ToString(), kodrem, ceh) == true)  // проставляем ШПЗ
                {
                     //MessageBox.Show("Виконано");
                }
                else
                {
                      //MessageBox.Show("Не виконано kod_rem=2 cex=1");
                }

            }
            else
            {
                MessageBox.Show("Робочий місяць або рік не визначен для Цеха: " + ceh.ToString() );
            }

            //*************************beg 2
            ceh = 5;
            canshifr = "no";
            Debug.WriteLine("--------------------");
            cn.Open();
            SqlCommand s20 = new SqlCommand("select god from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            tekgod = Convert.ToInt32(s20.ExecuteScalar());
            Debug.WriteLine(tek_god.ToString());
            cn.Close();

            cn.Open();
            SqlCommand s21 = new SqlCommand("select mes from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            tekmes = Convert.ToInt32(s21.ExecuteScalar());
            Debug.WriteLine(tek_mes.ToString());
            cn.Close();
            Debug.WriteLine("--------------------");
            if (tekgod == 0 || tekgod == null || tekmes == 0 || tekmes == null)
            {
                canshifr = "no";
            }
            else
            {
                canshifr = "yes";
            }

            if (canshifr == "yes")
            {

                Debug.WriteLine("can ");
                int kodrem = 1;
                shpz = "2310405";
                //ceh = 5;

                if (dal.UpdateShpz(shpz, tekmes.ToString(), tekgod.ToString(), kodrem, ceh) == true)  // проставляем ШПЗ
                {
                    //MessageBox.Show("Виконано");
                }
                else
                {
//                    MessageBox.Show("Не виконано  kod_rem=1 cex=1");
                }
                kodrem = 2;
                shpz = "2310405";
                //ceh = 5;

                if (dal.UpdateShpz(shpz, tekmes.ToString(), tekgod.ToString(), kodrem, ceh) == true)  // проставляем ШПЗ
                {
                    //MessageBox.Show("Виконано");
                }
                else
                {
                    //MessageBox.Show("Не виконано kod_rem=2 cex=1");
                }

            }
            else
            {
                MessageBox.Show("Робочий місяць або рік не визначен для Цеха: " + ceh.ToString());
            }
            //*************************end 2



            //*************************beg 3
            ceh = 54;
            canshifr = "no";
            Debug.WriteLine("--------------------");
            cn.Open();
            SqlCommand s30 = new SqlCommand("select god from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            tekgod = Convert.ToInt32(s30.ExecuteScalar());
            Debug.WriteLine(tek_god.ToString());
            cn.Close();

            cn.Open();
            SqlCommand s31 = new SqlCommand("select mes from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            tekmes = Convert.ToInt32(s31.ExecuteScalar());
            Debug.WriteLine(tek_mes.ToString());
            cn.Close();
            Debug.WriteLine("--------------------");
            if (tekgod == 0 || tekgod == null || tekmes == 0 || tekmes == null)
            {
                canshifr = "no";
            }
            else
            {
                canshifr = "yes";
            }

            if (canshifr == "yes")
            {

                Debug.WriteLine("can ");
                int kodrem = 1;
                shpz = "232000";
                //ceh = 54;

                if (dal.UpdateShpz(shpz, tekmes.ToString(), tekgod.ToString(), kodrem, ceh) == true)  // проставляем ШПЗ
                {
                    //MessageBox.Show("Виконано");
                }
                else
                {
                    //MessageBox.Show("Не виконано  kod_rem=1 cex=1");
                }
                kodrem = 2;
                shpz = "232000";
                //ceh = 54;

                if (dal.UpdateShpz(shpz, tekmes.ToString(), tekgod.ToString(), kodrem, ceh) == true)  // проставляем ШПЗ
                {
                  //  MessageBox.Show("Виконано");
                }
                else
                {
                    //MessageBox.Show("Не виконано kod_rem=2 cex=1");
                }

            }
            else
            {
                MessageBox.Show("Робочий місяць або рік не визначен для Цеха: " + ceh.ToString());
            }
            //*************************end 3


            //*************************beg 4
            ceh = 51;
            canshifr = "no";
            Debug.WriteLine("--------------------");
            cn.Open();
            SqlCommand s40 = new SqlCommand("select god from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            tekgod = Convert.ToInt32(s40.ExecuteScalar());
            Debug.WriteLine(tek_god.ToString());
            cn.Close();

            cn.Open();
            SqlCommand s41 = new SqlCommand("select mes from  [Repairs].[dbo].[Status_mes_ceh] where StoreId ='" + ceh.ToString() + "'", cn);
            tekmes = Convert.ToInt32(s41.ExecuteScalar());
            Debug.WriteLine(tek_mes.ToString());
            cn.Close();
            Debug.WriteLine("--------------------");
            if (tekgod == 0 || tekgod == null || tekmes == 0 || tekmes == null)
            {
                canshifr = "no";
            }
            else
            {
                canshifr = "yes";
            }

            if (canshifr == "yes")
            {

                Debug.WriteLine("can ");
                int kodrem = 2;
                shpz = "232000";
                //ceh = 51;

                if (dal.UpdateShpz(shpz, tekmes.ToString(), tekgod.ToString(), kodrem, ceh) == true)  // проставляем ШПЗ
                {
                    //MessageBox.Show("Виконано");
                }
                else
                {
                    //MessageBox.Show("Не виконано  kod_rem=1 cex=1");
                }

            }
            else
            {
                MessageBox.Show("Робочий місяць або рік не визначен для Цеха: " + ceh.ToString());
            }
            //*************************end 4

            //*************************beg 5
            if (dal.UpdateShpz2("9101000",5) == true)  // проставляем ШПЗ
            {
                //MessageBox.Show("Виконано");
            }
            else
            {
                //MessageBox.Show("Не виконано  kod_rem=1 cex=1");
            }
            //*************************end 5

            //*************************beg 6
            if (dal.UpdateShpz2("9102000", 6) == true)  // проставляем ШПЗ
            {
                //MessageBox.Show("Виконано");
            }
            else
            {
                //MessageBox.Show("Не виконано  kod_rem=1 cex=1");
            }
            //*************************end 5

            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1,PeriodData2_2);
            SettingsAllVedRes();
            dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            SettingsAllRepPlace();
            SettingsAllVozvrDet();
            SettingsAllVozvrMet();

            dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
            dgv_AllVedomostsResursob.Rows[a].Selected = true;
            MessageBox.Show("Виконано.");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;

            dal = new DAL();
            string Rep_ID = dgv_AllVedomostsResursob.CurrentRow.Cells["RepairID"].Value.ToString();
            string ID = dgv_AllVedomostsResursob.CurrentRow.Cells["ID"].Value.ToString();
            string ZakCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_codcx"].Value.ToString();
            string ZakUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_coduth"].Value.ToString();
            string ZakBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_codbrig"].Value.ToString();
            string ZakDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Zakazchik_coddet"].Value.ToString();
            string IspCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            string IspUch = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coduth"].Value.ToString();
            string IspBrig = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codbrig"].Value.ToString();
            string IspDet = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_coddet"].Value.ToString();
            //string NomAkt="111";
            //string DatAkt="555";
            string NameOs = dgv_AllVedomostsResursob.CurrentRow.Cells["NameOS"].Value.ToString();
            string InvNumberOS = dgv_AllVedomostsResursob.CurrentRow.Cells["InventoryNamber"].Value.ToString();
            string Obekt = dgv_AllVedomostsResursob.CurrentRow.Cells["Obekt"].Value.ToString();
            
          

            string Dat_Rem1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString().Substring(1,10);
            string Dat_Rem2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString().Substring(1, 10);



            //Для этой печати надо брать даты по RepairID - т.к. есть переходящие ремонты изменено 06.05.2020 Воробьева

            //           string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
            //            string PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
            //            string Dat_Akta = PeriodData2;
            string PeriodData1, PeriodData2;
            if (checkBox1.Checked)
            {
                string Dat_LongRem_beg, Dat_LongRem_end;
                cn.Open();
                SqlCommand s33 = new SqlCommand("SELECT min(vr.PeriodData1) as dat1 from Vedomost_Resursov vr WHERE vr.RepairID ='" + Rep_ID.ToString() + "'", cn);
                Debug.WriteLine(s33);
                Dat_LongRem_beg = Convert.ToString(s33.ExecuteScalar());
                PeriodData1 = Dat_LongRem_beg;
                cn.Close();
                cn.Open();
                SqlCommand s34 = new SqlCommand("SELECT max(vr.PeriodData2) as dat2 from Vedomost_Resursov vr WHERE vr.RepairID ='" + Rep_ID.ToString() + "'", cn);
                Debug.WriteLine(s34);
                Dat_LongRem_end = Convert.ToString(s34.ExecuteScalar());
                PeriodData2 = Dat_LongRem_end;
                cn.Close();
            }
            else
            {
                PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString();
                PeriodData2 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
            }


            string Dat_Akta = PeriodData2;

            //Для этой печати надо брать даты по RepairID - т.к. есть переходящие ремонты



            DateTime PD1 = Convert.ToDateTime(dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData1"].Value.ToString());
            DateTime PD2 = Convert.ToDateTime(dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString());

            string zamovnik="" ;
            string edrpou = "00191329";
            if(PD2.Year < 2018)
            {
                zamovnik = "ПрАТ ''ЄВРАЗ СУХА БАЛКА''";
            }
            else
            {
                zamovnik="ПрАТ ''СУХА БАЛКА''";
            }
            //string vikonav = zamovnik+"  "+IspCx.ToString().Trim()+"."+IspUch.ToString().Trim()+"."+IspBrig.ToString().Trim()+"."+IspDet.ToString().Trim();
            //string vikonav = zamovnik;
            string vikonav = IspCx.ToString().Trim()+"."+IspUch.ToString().Trim();
            
            //int koldn = (((TimeSpan)(PD1 - PD2)).Days-1)*(-1); // Кол-во дней  между двумя датами в днях

            cn.Open();
            SqlCommand s0 = new SqlCommand("select b_bal_cena FROM [Repairs].[dbo].[SprOS] where InventoryNumber='"+ InvNumberOS.ToString()+"' and obekt='" + Obekt.ToString() + "'", cn);
            Debug.WriteLine(s0);
            string b_bal_cena = s0.ExecuteScalar().ToString();
            cn.Close();
            
            cn.Open();
            SqlCommand s1 = new SqlCommand("select pasport FROM [Repairs].[dbo].[SprOS] where InventoryNumber='"+ InvNumberOS.ToString()+"' and obekt='" + Obekt.ToString() + "'", cn);
            string pasport = s1.ExecuteScalar().ToString();
            if (pasport == null)
            {
                pasport = "0";
            }
            cn.Close();

            cn.Open();
            SqlCommand s2 = new SqlCommand("select mdl_crt FROM [Repairs].[dbo].[SprOS] where InventoryNumber='"+ InvNumberOS.ToString()+"' and obekt='" + Obekt.ToString() + "'", cn);
            string mdl_crt = s2.ExecuteScalar().ToString();
            cn.Close();

            cn.Open();
            SqlCommand s3 = new SqlCommand("select poln_srok FROM [Repairs].[dbo].[SprOS] where InventoryNumber='"+ InvNumberOS.ToString()+"' and obekt='" + Obekt.ToString() + "'", cn);
            int poln_srok = 0;
            string poln_srokk = s3.ExecuteScalar().ToString();
                if (poln_srokk == null || poln_srokk.Trim() == String.Empty)
                {
                    poln_srok = 0;
                }
            cn.Close();


            cn.Open();
            SqlCommand s4 = new SqlCommand("select srok FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            string srokk = s4.ExecuteScalar().ToString();
            int srok = 0;
            if (srokk == null || srokk.Trim() == String.Empty)
            {
                srok = 0;
            }
            else
            {
                srok = Convert.ToInt32(s4.ExecuteScalar());
            }
            cn.Close();

            
           Debug.WriteLine(b_bal_cena.ToString());
           Debug.WriteLine(pasport.ToString());
           Debug.WriteLine(mdl_crt.ToString());
           Debug.WriteLine(poln_srok.ToString());
           Debug.WriteLine(srok.ToString());


            bool isCapital = Convert.ToBoolean(dgv_AllVedomostsResursob.CurrentRow.Cells["IsCapital"].Value);
            string creditRah = isCapital ? "" : "910100";
            string capitalCena = "";
            if (!String.IsNullOrEmpty(dgv_AllVedomostsResursob.CurrentRow.Cells["sumNalogov"].Value.ToString()) && !isCapital)
            {
                //capitalCena = isCapital ? "" : (Math.Round(Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["Vsego_F"].Value.ToString()), 2)).ToString();
                capitalCena = isCapital ? "" : string.Format("{0:0.00}", Convert.ToDouble(dgv_AllVedomostsResursob.CurrentRow.Cells["Vsego_F"].Value));
            }

            frm_vibor_druk frm_vibor_druk = new frm_vibor_druk(ID, ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, b_bal_cena.ToString(), pasport.ToString(), mdl_crt.ToString(), poln_srok.ToString(), srok.ToString(), zamovnik, edrpou, Dat_Akta, Dat_Rem1, Dat_Rem2, vikonav, "podrjadchik_no", Convert.ToDateTime(PeriodData2).Year,Rep_ID, creditRah, capitalCena);
           frm_vibor_druk.ShowDialog();

           
           //MessageBox.Show(dejstvie);
           //if (dejstvie == "zaversh_rem")
           //{

           //    frmPrintDodatok2_1 frmPrintDodatok2_1 = new frmPrintDodatok2_1(ID, ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, b_bal_cena.ToString(), pasport.ToString(), mdl_crt.ToString(), poln_srok.ToString(), srok.ToString());
           //    frmPrintDodatok2_1.ShowDialog();

           //    frmPrintDodatok2_2 frmPrintDodatok2_2 = new frmPrintDodatok2_2();
           //    frmPrintDodatok2_2.ShowDialog();

           //    frmPrintDodatok3 frmPrintDodatok3 = new frmPrintDodatok3();
           //    frmPrintDodatok3.ShowDialog();
           //}

           //if (dejstvie == "nezaversh_rem")
           //{

           //    frmPrintDodatok4_1 frmPrintDodatok4_1 = new frmPrintDodatok4_1(ID, ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, b_bal_cena.ToString(), pasport.ToString(), mdl_crt.ToString(), poln_srok.ToString(), srok.ToString());
           //    frmPrintDodatok4_1.ShowDialog();

           //    frmPrintDodatok4_2 frmPrintDodatok4_2 = new frmPrintDodatok4_2();
           //    frmPrintDodatok4_2.ShowDialog();

           //    frmPrintDodatok5 frmPrintDodatok5 = new frmPrintDodatok5();
           //    frmPrintDodatok5.ShowDialog();
           //}
           dgv_AllVedomostsResursob.Rows[a].Selected = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;
            
            int b = 0;
            b = dgv_RepPlace.CurrentRow.Index;

            string ReplacedId = dgv_RepPlace.CurrentRow.Cells["ReplacedId"].Value.ToString();
            //MessageBox.Show(ReplacedId.ToString());

            frm_change_dat frm_change_dat = new frm_change_dat(ReplacedId);
            frm_change_dat.ShowDialog();

            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
            SettingsAllVedRes();
            dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            SettingsAllRepPlace();
            SettingsAllVozvrDet();
            SettingsAllVozvrMet();

            dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
            dgv_AllVedomostsResursob.Rows[a].Selected = true;
            dgv_AllVedomostsResursob.Focus();
            //dgv_RepPlace.FirstDisplayedCell = dgv_RepPlace.Rows[b].Cells["ReplacedId"];
            //dgv_RepPlace.Rows[b].Selected = true;


            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string pp = Dostup.AddQueryVedRes();
            //string data1 = PeriodData2_1;
            //string data2 = PeriodData2_2;
            frmReport_Zvit_Spisok_FromVedRes frmReport_Zvit_Spisok_FromVedRes = new frmReport_Zvit_Spisok_FromVedRes(pp, PeriodData2_1, PeriodData2_2, all_ceh, VIBRAN_CEH);
            frmReport_Zvit_Spisok_FromVedRes.ShowDialog();


        }

        private void buttonCapital_Click(object sender, EventArgs e)
        {

            var id = (int)dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value; 
            bool flag = !Convert.ToBoolean(dgv_AllVedomostsResursob.CurrentRow.Cells["IsCapital"].Value);
            dal.UpdateVedResIsCapital(id, flag);
            
            int selected_row = dgv_AllVedomostsResursob.CurrentRow.Index;
            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
            SettingsAllVedRes();
            dgv_AllVedomostsResursob.Columns["IsCapital"].Visible = true;

            dgv_AllVedomostsResursob.ClearSelection();
            //dgv_AllVedomostsResursob.Rows[selected_row].Selected = true;
            //dgv_AllVedomostsResursob.Rows[selected_row].Cells[1].Selected = true;
            dgv_AllVedomostsResursob.CurrentCell = dgv_AllVedomostsResursob.Rows[selected_row].Cells[2];

            dgv_AllVedomostsResursob_CellEnter(new object(), new DataGridViewCellEventArgs(0,selected_row));

            
            if (flag)
            {
                labelCapital.Text = "Капитальный";
            }
            else {
                labelCapital.Text = "Обычный";
            }
             
        }

        private void dgv_AllVedomostsResursob_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Enter");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_AvtomatAktF2_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_AllVedomostsResursob.CurrentRow.Index;

            try
            {
                string IspCx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();

                myFrmReplaceZnachForAktiForCeh myFrmReplaceZnachForAktiForCeh = new myFrmReplaceZnachForAktiForCeh(IspCx);
                myFrmReplaceZnachForAktiForCeh.ShowDialog();
            }
            catch { Exception ex;  };



            dgv_AllVedomostsResursob.DataSource = dal.GetAllVedomostsResursov(PeriodData2_1, PeriodData2_2);
            SettingsAllVedRes();
            dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Det.DataSource = dal.GetVozvrDetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            dgv_Met.DataSource = dal.GetVozvrMetForVedRes(dgv_AllVedomostsResursob.CurrentRow.Cells["Id"].Value.ToString());
            SettingsAllRepPlace();
            SettingsAllVozvrDet();
            SettingsAllVozvrMet();

            dgv_AllVedomostsResursob.FirstDisplayedCell = dgv_AllVedomostsResursob.Rows[a].Cells["id"];
            dgv_AllVedomostsResursob.Rows[a].Selected = true;
        }

       

            
            



            //this.dataTable2TableAdapter.Fill(this.tabl.DataTable2, Convert.ToInt32(label2.Text));
            //if (tekmes == 1) { } else { dataGridView1.Rows[a].Selected = true; }
            



            
            //if (tek_mes.ToString() == mes.ToString() & tek_god.ToString() == god.ToString()) // проверка на рабочий месяц
            //{
            //    //MessageBox.Show("=");
            //    btn_UpdateVedRes.Visible = true;
            //    btn_DelVedRes.Visible = true;
            //    btn_alterRepair.Visible = true;
            //    btn_UpdateShpz.Visible = true;
            //}
            //else
            //{
            //    //MessageBox.Show("<>"); 
            //    btn_UpdateVedRes.Visible = false;
            //    btn_DelVedRes.Visible = false;
            //    btn_alterRepair.Visible = false;
            //    btn_UpdateShpz.Visible = false;
            //}
        





    }
}
