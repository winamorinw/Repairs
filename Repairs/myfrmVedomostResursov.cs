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
using System.Data.OleDb;

namespace Repairs
{
    public partial class myfrmVedomostResursov : Form
    {
        DAL dal = new DAL();
        int a = 0;//переменные для удачного показателя выполнения добавления в вед рес деталей металлолома, и возвр дет и самой ведомости ресурсов
        int b = 0;
        int c = 0;
        int d = 0;
        private string tek_mes, tek_god;
        public myfrmVedomostResursov(string tekmes, string tekgod)
        {
            InitializeComponent();
            dgv_OSReplaced.DataSource = dal.GetAllRepairForVedomost();
            Settings_allRepair();

            dgv_OSReplacedOS.DataSource = dal.GetAllRepairForVedomostForOS();

            SettingsAllOS();
            tek_mes = tekmes.ToString();
            tek_god = tekgod.ToString();
            this.tabControl1.SelectedTab = tabPage2;
            
        }

        private void myfrmVedomostResursov_Load(object sender, EventArgs e)
        {

        }

        private void SettingsAllOS()
        {
            if (dgv_OSReplacedOS.RowCount > 0)
            {

                dgv_OSReplacedOS.Columns["inventoryNumber"].HeaderText = "Инв. №";
                dgv_OSReplacedOS.Columns["Name"].HeaderText = "Наименование";
                //dgv_OSReplacedOS.Columns["Name"].HeaderText = "Наименование";
                dgv_OSReplacedOS.Columns["Name"].Width = 380;
                dgv_OSReplacedOS.Columns["Obekt"].Width = 35;
                dgv_OSReplacedOS.Columns["Obekt"].HeaderText = "Об";

                dgv_OSReplacedOS.Columns["codbrig"].Visible = false;
                dgv_OSReplacedOS.Columns["coduth"].Visible = false;
                dgv_OSReplacedOS.Columns["coddet"].Visible = false;
                dgv_OSReplacedOS.Columns["codcx"].Visible = false;

            }
        }


        private void Settings_allRepair()
        {
            if (dgv_OSReplaced.RowCount > 0)
            {
                dgv_OSReplaced.Columns["TypeFlaut"].Visible = false;
                dgv_OSReplaced.Columns["Cause"].Visible = false;
                dgv_OSReplaced.Columns["Note"].Visible = false;
                dgv_OSReplaced.Columns["Responsible"].Visible = false;
               // dgv_OSReplaced.Columns["RepairID"].Visible = true;
                dgv_OSReplaced.Columns["RepairID"].Visible = false;
                dgv_OSReplaced.Columns["RDivision"].Visible = false;
                dgv_OSReplaced.Columns["Division"].Visible = false;
                dgv_OSReplaced.Columns["NotedataNext"].Visible = false;
                dgv_OSReplaced.Columns["dataNext"].Visible = false;
                dgv_OSReplaced.Columns["CODCX"].Visible = false;
                dgv_OSReplaced.Columns["CODUTH"].Visible = false;
                dgv_OSReplaced.Columns["CODDET"].Visible = false;
                dgv_OSReplaced.Columns["CODBRIG"].Visible = false;
                dgv_OSReplaced.Columns["NAMEDET"].Visible = false;
                dgv_OSReplaced.Columns["StoreName1"].Visible = false;





                dgv_OSReplaced.Columns["InventoryNumber"].HeaderText = "Инв.№";
                dgv_OSReplaced.Columns["DateIn"].HeaderText = "Дата отправки";
                dgv_OSReplaced.Columns["DateOut"].HeaderText = "Дата завершения";
                //dgv_OSReplaced.Columns["StoreName"].HeaderText = "Отправитель";
                dgv_OSReplaced.Columns["StoreName"].HeaderText = "Исполнитель";
                dgv_OSReplaced.Columns["Name"].HeaderText = "Наименование";
                dgv_OSReplaced.Columns["Obekt"].HeaderText = "Об";

                dgv_OSReplaced.Columns["Name"].DisplayIndex = 2;
                dgv_OSReplaced.Columns["Obekt"].DisplayIndex = 3;

                dgv_OSReplaced.Columns["InventoryNumber"].Width = 60;
                dgv_OSReplaced.Columns["Name"].Width = 160;
                dgv_OSReplaced.Columns["DateIn"].Width = 85;
                dgv_OSReplaced.Columns["DateOut"].Width = 85;
                dgv_OSReplaced.Columns["Obekt"].Width = 25;



                //dgv_Repair.Columns[1].HeaderText = "sdfaadf";
                //dgv_Repair.Columns["RepairID"].Visible = false;
            }
        }

        private void dgv_OSReplaced_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_OSReplaced.Rows[e.RowIndex].Cells["NameDet"].Value.ToString().Length > 0)
            {
                txt_Responsible.Text = dgv_OSReplaced.Rows[e.RowIndex].Cells["NameDet"].Value.ToString();
            }
            else
            {
                txt_Responsible.Text = dgv_OSReplaced.Rows[e.RowIndex].Cells["Responsible"].Value.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dgv_OSReplaced.RowCount > 0)
            //{

            //    InfoRepair.RepairID = dgv_OSReplaced.CurrentRow.Cells["RepairID"].Value.ToString();
            //    string RDivision = dgv_OSReplaced.CurrentRow.Cells["RDivision"].Value.ToString(); // цех исполнитель
            //    string InvNum = dgv_OSReplaced.CurrentRow.Cells["InventoryNumber"].Value.ToString(); // цех исполнитель
            //    string Obekt = dgv_OSReplaced.CurrentRow.Cells["Obekt"].Value.ToString(); // цех исполнитель

            //    myfrmVedomostResursovForAllRepairs myfrmVedomostResursovForAllRepairs = new myfrmVedomostResursovForAllRepairs(RDivision,InvNum,Obekt);
            //    myfrmVedomostResursovForAllRepairs.ShowDialog();
            //}


            //else {
            //    MessageBox.Show("Нет данных для формирования ведомости ресурсов");
            
            //}
        }

        private void btn_formVedRes_Click(object sender, EventArgs e)
        {


            // проверка на рабочий месяц
            string theMonth = dateTimePicker2.Value.ToString("MM");
            string theYear = dateTimePicker2.Value.ToString("yyyy");
            string isp_codcx = dgv_OSReplaced.CurrentRow.Cells["RDivision"].Value.ToString();
            string ffound = "no";
            string canform = "no";
            // Определяем 
            cn.Open();
            SqlCommand cm1 = new SqlCommand("select count(StoreId) as kolstr from  [Repairs].[dbo].[Status_mes_ceh] where StoreId = " + isp_codcx.ToString(), cn);
            Debug.WriteLine(cm1.CommandText);

            int kolstr = Convert.ToInt32(cm1.ExecuteScalar()); // Взяли значение из первой левой ячейки
            switch (kolstr)
            {
                case 1:
                    ffound = "yes";
                    break;
                case 0:
                    MessageBox.Show("Не знайдено цеха в довіднику Store");
                    ffound = "no";
                    break;
                default:
                    MessageBox.Show("В довіднику Store більше одного запису по цеху: " + isp_codcx.ToString());
                    ffound = "no";
                    break;
            }
            if (ffound == "yes")
            {
                SqlCommand cm2 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where mes = " + theMonth + " and god = " + theYear + " and StoreId = " + isp_codcx, cn);
                SqlDataReader dr = cm2.ExecuteReader();  // Выполняем выборку
                if (dr.HasRows)
                {
                    btn_formVedResOS.Visible = true;
                    canform = "yes";

                }
                else
                {
                    btn_formVedResOS.Visible = false;
                    MessageBox.Show("Формування неможливе. По цеху " + isp_codcx.ToString() + " робочий місяць інший.");
                    canform = "no";

                }


                dr.Close();

                //    MessageBox.Show("Ви не маєте прав. Робочий місяць - "+tek_mes.ToString()+"  "+tek_god.ToString()+"p.");
            }

            cn.Close();



            if (canform == "yes") // проверка на рабочий месяц
            {

                if (dgv_OSReplaced.RowCount > 0)
                {

                    InfoRepair.RepairID = dgv_OSReplaced.CurrentRow.Cells["RepairID"].Value.ToString();
                    string RDivision = dgv_OSReplaced.CurrentRow.Cells["RDivision"].Value.ToString(); // цех исполнитель
                    //string DatBegRem = dgv_OSReplaced.CurrentRow.Cells["DateIn"].Value.ToString(); // дата нач. ремонта
                    //string DatEndRem = dgv_OSReplaced.CurrentRow.Cells["DateOut"].Value.ToString(); // дата оконч. ремонта
                    string InvNum = dgv_OSReplaced.CurrentRow.Cells["InventoryNumber"].Value.ToString();
                    string Obekt = dgv_OSReplaced.CurrentRow.Cells["Obekt"].Value.ToString();
                    string datn = dateTimePicker1.Value.ToString("yyyyMMdd");
                    string datk = dateTimePicker2.Value.ToString("yyyyMMdd");

                    myfrmVedomostResursovForAllRepairs myfrmVedomostResursovForAllRepairs = new myfrmVedomostResursovForAllRepairs(RDivision, InvNum, Obekt,datn,datk);
                    myfrmVedomostResursovForAllRepairs.ShowDialog();

                    if (myfrmVedomostResursovForAllRepairs.DialogResult == DialogResult.OK)
                    {
                        dgv_OSReplaced.DataSource = dal.GetAllRepairForVedomost();
                        Settings_allRepair();

                        dgv_OSReplacedOS.DataSource = dal.GetAllRepairForVedomostForOS();
                        SettingsAllOS();

                    }


                }


                else
                {
                    MessageBox.Show("Нет данных для формирования ведомости ресурсов");

                }

            }
            else
            {
                // MessageBox.Show("Неможливо сформувати. Робочий місяць:"+tek_mes.ToString()+"-"+tek_god.ToString()+"p.");
            }
        


         

          

       
      












            ////string aa =Month(dateTimePicker2.Value());
            //string theMonth = dateTimePicker2.Value.ToString("MM");
            //string theYear = dateTimePicker2.Value.ToString("yyyy");
            //if (tek_mes.ToString() == theMonth.ToString() & tek_god.ToString() == theYear.ToString()) // проверка на рабочий месяц
            //{

            //    //if theMonth=tek_mes 
            //    if (dgv_OSReplaced.RowCount > 0)
            //    {

            //        InfoRepair.RepairID = dgv_OSReplaced.CurrentRow.Cells["RepairID"].Value.ToString();
            //        string RDivision = dgv_OSReplaced.CurrentRow.Cells["RDivision"].Value.ToString(); // цех исполнитель
            //        //string DatBegRem = dgv_OSReplaced.CurrentRow.Cells["DateIn"].Value.ToString(); // дата нач. ремонта
            //        //string DatEndRem = dgv_OSReplaced.CurrentRow.Cells["DateOut"].Value.ToString(); // дата оконч. ремонта
            //        string InvNum = dgv_OSReplaced.CurrentRow.Cells["InventoryNumber"].Value.ToString();
            //        string Obekt = dgv_OSReplaced.CurrentRow.Cells["Obekt"].Value.ToString();

            //        myfrmVedomostResursovForAllRepairs myfrmVedomostResursovForAllRepairs = new myfrmVedomostResursovForAllRepairs(RDivision, InvNum, Obekt);
            //        myfrmVedomostResursovForAllRepairs.ShowDialog();

            //        if (myfrmVedomostResursovForAllRepairs.DialogResult == DialogResult.OK)
            //        {
            //            dgv_OSReplaced.DataSource = dal.GetAllRepairForVedomost();
            //            Settings_allRepair();

            //            dgv_OSReplacedOS.DataSource = dal.GetAllRepairForVedomostForOS();
            //            SettingsAllOS();

            //        }

            //    }


            //    else
            //    {
            //        MessageBox.Show("Нет данных для формирования ведомости ресурсов");

            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Неможливо сформувати. Робочий місяць:" + tek_mes.ToString() + "-" + tek_god.ToString() + "p.");
            //}





        }

        private void btn_formVedResOS_Click(object sender, EventArgs e)
        {
            // Убрала проверку на списано ли ОС, т.к. надо пользователям открывать доступ на f:\osr\db
            //  MessageBox.Show("Проверить ОС");
            //  int KolNeSpisOS = 99;
            //  DAL_DBF DAL_DBF = new DAL_DBF();
            // KolNeSpisOS = Convert.ToInt32(DAL_DBF.ReturnKolNotSpisOS(dgv_OSReplacedOS.CurrentRow.Cells["InventoryNumber"].Value.ToString(), dgv_OSReplacedOS.CurrentRow.Cells["Obekt"].Value.ToString()));
            

            //if (KolNeSpisOS==1)
            //{ 
            //   // MessageBox.Show("Не списано");
            //}
            //else
            //{
            //  MessageBox.Show("Нельзя сформировать ведомость.\nОС уже списано или на консервации, или выведен из эксплуатации.");
            //  return;
            //}


            string inv=dgv_OSReplacedOS.CurrentRow.Cells["InventoryNumber"].Value.ToString();
            string ob_inv = dgv_OSReplacedOS.CurrentRow.Cells["Obekt"].Value.ToString();

            if (inv.Length == 7 && inv.Substring(0, 1) == "9")
            { // не делаем проверку ОС,т.к. єто ОС по услугам
            }
            else
            {
                int int_ob_inv;
                if (String.IsNullOrEmpty(ob_inv))
                {
                    int_ob_inv = 0;
                }
                else
                {
                    int_ob_inv = Convert.ToInt32(ob_inv);
                }

                //  проверку на списано ли ОС,  доступ на f:\slovary\okrt.dbf
                //  MessageBox.Show("Проверить ОС");

                DataTable YourResultSet = new DataTable();
                if (inv.ToUpper().EndsWith("М") || inv.ToUpper().EndsWith("M"))
                {
                    OleDbConnection yourConnectionHandler = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=\\uaesb-fs-001\sys\SLOVARY\");
                    yourConnectionHandler.Open();
                    try
                    {

                        if (yourConnectionHandler.State == ConnectionState.Open)
                        {
                            string mySQL = @"";
                            // //23.12.2019 mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949400') and (LEFT(ok.kod_ztr,6)!='949410')  and (ok.obekt=0 OR isnull(ok.obekt)) AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))";
                            mySQL = @" SELECT count(Inven) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\spis_mal.dbf WHERE Inven=" + inv.Remove(inv.Length-1,1); //23.12.2019
                            OleDbCommand MyQuery = new OleDbCommand(mySQL, yourConnectionHandler);
                            OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                            DA.Fill(YourResultSet);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        System.Environment.Exit(0);
                    }
                    yourConnectionHandler.Close();
                }
                else
                {
                    OleDbConnection yourConnectionHandler = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=\\uaesb-fs-001\sys\SLOVARY\");
                    yourConnectionHandler.Open();
                    try
                    {

                        if (yourConnectionHandler.State == ConnectionState.Open)
                        {
                            string mySQL = @"";
                            if (int_ob_inv == 0)
                            {
                                // //23.12.2019 mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949400') and (LEFT(ok.kod_ztr,6)!='949410')  and (ok.obekt=0 OR isnull(ok.obekt)) AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))";
                                mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949410')  and (ok.obekt=0 OR isnull(ok.obekt)) AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))"; //23.12.2019
                            }
                            else
                            {
                                // //23.12.2019 mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949400') and (LEFT(ok.kod_ztr,6)!='949410')  and ok.obekt=" + ob_inv + " AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))";
                                mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949410')  and ok.obekt=" + ob_inv + " AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))";
                            }
                            OleDbCommand MyQuery = new OleDbCommand(mySQL, yourConnectionHandler);
                            OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                            DA.Fill(YourResultSet);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        System.Environment.Exit(0);
                    }
                    yourConnectionHandler.Close();
                }

                int kkol = Convert.ToInt32(YourResultSet.Rows[0][0]);
                if (inv.ToUpper().EndsWith("М") || inv.ToUpper().EndsWith("M"))
                {
                    kkol = 1;
                }

                if (kkol == 0)
                {
                    MessageBox.Show("Нельзя сформировать\nинв. " + inv.ToString() + "/" + ob_inv.ToString() + " уже списано или на консервации, или виведено из эксплуатации.");
                    return;

                }
                else
                {
                    // MessageBox.Show("Можно");
                }


                cn.Close();

            }
        
            // проверка на рабочий месяц
            string theMonth = dateTimePicker3.Value.ToString("MM");
            string theYear = dateTimePicker3.Value.ToString("yyyy");
            string isp_codcx = dgv_OSReplacedOS.CurrentRow.Cells["CODCX"].Value.ToString();
            string ffound = "no";
            string canform = "no";
            // Определяем 
            cn.Open();
            SqlCommand cm1 = new SqlCommand("select count(StoreId) as kolstr from  [Repairs].[dbo].[Status_mes_ceh] where StoreId = " + isp_codcx.ToString(), cn);
            Debug.WriteLine(cm1.CommandText);

            int kolstr = Convert.ToInt32(cm1.ExecuteScalar()); // Взяли значение из первой левой ячейки
            switch (kolstr)
            {
                case 1:
                    ffound = "yes";
                    break;
                case 0:
                    MessageBox.Show("Не знайдено цеха в довіднику Store");
                    ffound = "no";
                    break;
                default:
                    MessageBox.Show("В довіднику Store більше одного запису по цеху: " + isp_codcx.ToString());
                    ffound = "no";
                    break;
            }
            if (ffound == "yes")
            {
                SqlCommand cm2 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where mes = " + theMonth + " and god = " + theYear + " and StoreId = " + isp_codcx, cn);
                SqlDataReader dr = cm2.ExecuteReader();  // Выполняем выборку
                if (dr.HasRows)
                {
                    btn_formVedResOS.Visible = true;
                    canform = "yes";

                }
                else
                {
                    btn_formVedResOS.Visible = false;
                    MessageBox.Show("Формування неможливе. По цеху " + isp_codcx.ToString() + " робочий місяць інший.");
                    canform = "no";

                }


                dr.Close();

                //    MessageBox.Show("Ви не маєте прав. Робочий місяць - "+tek_mes.ToString()+"  "+tek_god.ToString()+"p.");
            }

            cn.Close();
            
            
           
            if (canform == "yes") // проверка на рабочий месяц
            {

            if (dgv_OSReplacedOS.RowCount > 0)
            {

                InfoRepair.InventotyNomber = dgv_OSReplacedOS.CurrentRow.Cells["InventoryNumber"].Value.ToString();
                InfoRepair.Obekt = dgv_OSReplacedOS.CurrentRow.Cells["Obekt"].Value.ToString();
                InfoRepair.CODCX = dgv_OSReplacedOS.CurrentRow.Cells["CODCX"].Value.ToString();
                InfoRepair.CODUTH = dgv_OSReplacedOS.CurrentRow.Cells["CODUTH"].Value.ToString();
                InfoRepair.CODBRIG = dgv_OSReplacedOS.CurrentRow.Cells["CODBRIG"].Value.ToString();
                InfoRepair.CODDET = dgv_OSReplacedOS.CurrentRow.Cells["CODDET"].Value.ToString();
                Debug.WriteLine(dgv_OSReplacedOS.CurrentRow.Cells["InventoryNumber"].Value.ToString());
                string datn = dateTimePicker4.Value.ToString("yyyyMMdd");
                string datk = dateTimePicker3.Value.ToString("yyyyMMdd");

                myfrmVedomostResursovForAllOS myfrmVedomostResursovForAllOS = new myfrmVedomostResursovForAllOS(InfoRepair.InventotyNomber, InfoRepair.Obekt,datn,datk);
               
               // MessageBox.Show(InfoRepair.InventotyNomber);
                myfrmVedomostResursovForAllOS.ShowDialog();

                if (myfrmVedomostResursovForAllOS.DialogResult == DialogResult.OK) {
                    dgv_OSReplaced.DataSource = dal.GetAllRepairForVedomost();
                    Settings_allRepair();

                    dgv_OSReplacedOS.DataSource = dal.GetAllRepairForVedomostForOS();
                    SettingsAllOS();
                
                }



            }


            else
            {
                MessageBox.Show("Нет данных для формирования ведомости ресурсов");

            }
        
        }
            else
            {
               // MessageBox.Show("Неможливо сформувати. Робочий місяць:"+tek_mes.ToString()+"-"+tek_god.ToString()+"p.");
            }
        
        
        }

        private void dgv_OSReplacedOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show( dgv_OSReplaced.CurrentRow.Cells["RDivision"].Value.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string RDivision=dgv_OSReplaced.CurrentRow.Cells["RDivision"].Value.ToString();
            switch(RDivision)
            {
                case "1":
                    break;
                case "3":
                    break;
                case "2":
                    break;
            }

         

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //{

            //    // проверка на рабочий месяц
                
            //    string PeriodData1 = dgv_AllVedomostsResursob.CurrentRow.Cells["PeriodData2"].Value.ToString();
            //    string isp_codcx = dgv_AllVedomostsResursob.CurrentRow.Cells["Ispolnitel_codcx"].Value.ToString();
            //    string mes = PeriodData1.Substring(3, 2);
            //    string god = PeriodData1.Substring(6, 4);
            //    string ffound = "no";
            //    //string pravo_vip = "no";
            //    // Определяем какой рабочий месяц по цеху исполнителю
            //    cn.Open();
            //    SqlCommand cm1 = new SqlCommand("select count(StoreId) as kolstr from  [Repairs].[dbo].[Status_mes_ceh] where StoreId = " + isp_codcx.ToString(), cn);
            //    Debug.WriteLine(cm1.CommandText);

            //    int kolstr = Convert.ToInt32(cm1.ExecuteScalar()); // Взяли значение из первой левой ячейки
            //    switch (kolstr)
            //    {
            //        case 1:
            //            ffound = "yes";
            //            break;
            //        case 0:
            //            MessageBox.Show("Не знайдено цеха в довіднику Store");
            //            ffound = "no";
            //            break;
            //        default:
            //            MessageBox.Show("В довіднику Store більше одного запису по цеху: " + isp_codcx.ToString());
            //            ffound = "no";
            //            break;
            //    }
            //    if (ffound == "yes")
            //    {
            //        SqlCommand cm2 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where mes = " + mes + " and god = " + god + " and StoreId = " + isp_codcx, cn);
            //        SqlDataReader dr = cm2.ExecuteReader();  // Выполняем выборку
            //        if (dr.HasRows)
            //        {
            //            btn_DelVedRes.Enabled = true;
            //            btn_UpdateVedRes.Enabled = true;
            //        }
            //        else
            //        {
            //            btn_DelVedRes.Enabled = false;
            //            btn_UpdateVedRes.Enabled = false;

            //        }


            //        dr.Close();

            //        //    MessageBox.Show("Ви не маєте прав. Робочий місяць - "+tek_mes.ToString()+"  "+tek_god.ToString()+"p.");
            //    }

            //    cn.Close();

            //}

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True"); 
        private void button2_Click_2(object sender, EventArgs e)
        {
        //        // проверка на рабочий месяц
        //    string theMonth = dateTimePicker2.Value.ToString("MM");
        //    string theYear = dateTimePicker2.Value.ToString("yyyy");
        //    string isp_codcx =  dgv_OSReplacedOS.CurrentRow.Cells["CODCX"].Value.ToString();
            
            
        //    //MessageBox.Show(tek_mes.ToString() + "=" + theMonth.ToString() + "...." + tek_god.ToString() + "=" + theYear.ToString());
        //    //if (tek_mes.ToString()==theMonth.ToString() & tek_god.ToString()==theYear.ToString()) // проверка на рабочий месяц
               
        //        string ffound = "no";
        //        //string pravo_vip = "no";
        //        // Определяем какой рабочий месяц по цеху исполнителю
        //        cn.Open();
        //        SqlCommand cm1 = new SqlCommand("select count(StoreId) as kolstr from  [Repairs].[dbo].[Status_mes_ceh] where StoreId = " + isp_codcx.ToString(), cn);
        //        Debug.WriteLine(cm1.CommandText);

        //        int kolstr = Convert.ToInt32(cm1.ExecuteScalar()); // Взяли значение из первой левой ячейки
        //        switch (kolstr)
        //        {
        //            case 1:
        //                ffound = "yes";
        //                break;
        //            case 0:
        //                MessageBox.Show("Не знайдено цеха в довіднику Store");
        //                ffound = "no";
        //                break;
        //            default:
        //                MessageBox.Show("В довіднику Store більше одного запису по цеху: " + isp_codcx.ToString());
        //                ffound = "no";
        //                break;
        //        }
        //        if (ffound == "yes")
        //        {
        //            SqlCommand cm2 = new SqlCommand("select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where mes = " +theMonth + " and god = " + theYear + " and StoreId = " + isp_codcx, cn);
        //            SqlDataReader dr = cm2.ExecuteReader();  // Выполняем выборку
        //            if (dr.HasRows)
        //            {
        //                btn_formVedResOS.Visible  = true;
                        
        //            }
        //            else
        //            {
        //                btn_formVedResOS.Visible  = false;
        //                MessageBox.Show("Формування неможливе. По цеху "+isp_codcx.ToString()+" робочий місяць інший.");

        //            }


        //            dr.Close();

        //            //    MessageBox.Show("Ви не маєте прав. Робочий місяць - "+tek_mes.ToString()+"  "+tek_god.ToString()+"p.");
        //        }

        //        cn.Close();













        }
    }
}
