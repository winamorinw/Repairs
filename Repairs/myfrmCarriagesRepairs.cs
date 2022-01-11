using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Repairs
{
    public partial class myfrmCarriagesRepairs : Form
    {
        DAL dal = new DAL();
        // переменная для передачи значения от формы ремонты к форме вида работы
        string s;
        private string user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;
        public myfrmCarriagesRepairs(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();
            ArrayList allRepairs = dal.GetAllRepair("");
            dgv_Repair.DataSource = allRepairs;
            Settings_allRepair();
            user_n = usern;
            user_p = userp;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
            Dostup.A = 0;
            if(Dostup.Codcx != "0")
            {
                groupBox12.Visible = false;
            }
        }

        SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True");

        //Настройка ремонтов
        private void Settings_allRepair()
        {
            if (dgv_Repair.RowCount > 0)
            {
                dgv_Repair.Columns["no_pp"].Visible = true;
                dgv_Repair.Columns["TypeFlaut"].Visible = false;
                dgv_Repair.Columns["Cause"].Visible = false;
                dgv_Repair.Columns["Note"].Visible = false;
                dgv_Repair.Columns["Responsible"].Visible = false;
                dgv_Repair.Columns["RepairID"].Visible = false;
                dgv_Repair.Columns["RDivision"].Visible = false;
                dgv_Repair.Columns["Division"].Visible = false;
                dgv_Repair.Columns["NotedataNext"].Visible = false;
                dgv_Repair.Columns["dataNext"].Visible = false;
                dgv_Repair.Columns["CODCX"].Visible = false;
                dgv_Repair.Columns["CODUTH"].Visible = false;
                dgv_Repair.Columns["CODDET"].Visible = false;
                dgv_Repair.Columns["CODBRIG"].Visible = false;
                dgv_Repair.Columns["NAMEDET"].Visible = false;
                dgv_Repair.Columns["b_bal_cena"].Visible = true;
                
                dgv_Repair.Columns["FIO1f2"].Visible = false;
                dgv_Repair.Columns["FIO2f2"].Visible = false;
                dgv_Repair.Columns["FIO3f2"].Visible = false;
                dgv_Repair.Columns["FIO4f2"].Visible = false;
                dgv_Repair.Columns["FIO5f2"].Visible = false;
                dgv_Repair.Columns["dolg1f2"].Visible = false;
                dgv_Repair.Columns["dolg2f2"].Visible = false;
                dgv_Repair.Columns["dolg3f2"].Visible = false;
                dgv_Repair.Columns["dolg4f2"].Visible = false;
                dgv_Repair.Columns["dolg5f2"].Visible = false;

                dgv_Repair.Columns["d_rem"].Visible = false;

                dgv_Repair.Columns["Inv_usl"].Visible = true;
                dgv_Repair.Columns["Obekt_usl"].Visible = true;
                dgv_Repair.Columns["name_inv_usl"].Visible = true;


                dgv_Repair.Columns["no_pp"].HeaderText = "№ п/п";
                dgv_Repair.Columns["d_rem"].HeaderText = "Ост.дат.рем.";
                dgv_Repair.Columns["InventoryNumber"].HeaderText = "Інв.№";
                dgv_Repair.Columns["DateIn"].HeaderText = "Дата відправки";
                dgv_Repair.Columns["DateOut"].HeaderText = "Дата завершення";
                dgv_Repair.Columns["StoreName1"].HeaderText = "Відправник";
                dgv_Repair.Columns["StoreName"].HeaderText = "Одержувач";
                dgv_Repair.Columns["Name"].HeaderText = "Найменування";
                dgv_Repair.Columns["Obekt"].HeaderText = "Об";
                dgv_Repair.Columns["b_bal_cena"].HeaderText = "Залиш.варт.";


                dgv_Repair.Columns["Inv_usl"].HeaderText = "Інв.(послуга)";
                dgv_Repair.Columns["Obekt_usl"].HeaderText = "об.(послуга)";
                dgv_Repair.Columns["name_inv_usl"].HeaderText = "Назва інв.(послуга)";



                dgv_Repair.Columns["no_pp"].Width = 25;
                dgv_Repair.Columns["d_rem"].Width = 25;
                dgv_Repair.Columns["Name"].DisplayIndex = 2;
                dgv_Repair.Columns["InventoryNumber"].Width = 65;
                dgv_Repair.Columns["Name"].Width = 185;
                dgv_Repair.Columns["DateIn"].Width = 83;
                dgv_Repair.Columns["DateOut"].Width = 83;
                dgv_Repair.Columns["Obekt"].Width = 25;
                dgv_Repair.Columns["StoreName1"].Width = dgv_Repair.Columns["StoreName"].Width - 25;
                dgv_Repair.Columns["b_bal_cena"].Width = 80;

                dgv_Repair.Columns["Inv_usl"].Width = 65;
                dgv_Repair.Columns["Obekt_usl"].Width = 25;
                dgv_Repair.Columns["name_inv_usl"].Width = 300;
            }
        }

        //Настройка выполненых ремонтов
        private void Settings_allJobs()
        {
            dgv_Job.Columns["JobId"].Visible = false;
            dgv_Job.Columns["RepairId"].Visible = false;
            dgv_Job.Columns["JobCode"].Visible = false;

            dgv_Job.Columns["JobName"].HeaderText = "Назва ремонту";
            dgv_Job.Columns["T_Inspect"].HeaderText = "План";

            dgv_Job.Columns["JobName"].Width = 320;
            dgv_Job.Columns["T_Inspect"].Width = 50;
        }


        //Настройка выполненых ремонтов
        private void Settings_allJobsForAktF2()
        {
            dgv_Job_For_AktF2.Columns["Id"].Visible = false;
            dgv_Job_For_AktF2.Columns["ID_Repair"].Visible = false;
            dgv_Job_For_AktF2.Columns["Nam_job"].Visible = true;
            dgv_Job_For_AktF2.Columns["Ch_chas"].Visible = true;

            dgv_Job_For_AktF2.Columns["Id"].HeaderText = "ID";
            dgv_Job_For_AktF2.Columns["ID_Repair"].HeaderText = "ID_Repair";
            dgv_Job_For_AktF2.Columns["Nam_job"].HeaderText = "Назва роботи";
            dgv_Job_For_AktF2.Columns["Ch_chas"].HeaderText = "Чел/час";

            dgv_Job_For_AktF2.Columns["Id"].Width = 20;
            dgv_Job_For_AktF2.Columns["ID_Repair"].Width = 20;
            dgv_Job_For_AktF2.Columns["Nam_job"].Width = 300;
            dgv_Job_For_AktF2.Columns["Ch_chas"].Width=80;
            

        }

    
           //Настройка списка заменяемой части
        private void Settings_allPlacePart()
        {
            dgv_PlacePart.Columns["PlaceName"].HeaderText = "Місце встановлення";
            dgv_PlacePart.Columns["PlaceName"].Width = dgv_PlacePart.Width;
        }


        //настройка заменяеых запчастей
        private void Settings_ReplacedPart()
        {
            if (dgv_ReplacedPart.RowCount > 0)
            {
                dgv_ReplacedPart.Columns["JobId"].Visible = false;
                dgv_ReplacedPart.Columns["PartId"].Visible = false;
                dgv_ReplacedPart.Columns["ReplacedId"].Visible = false;
                dgv_ReplacedPart.Columns["Original"].Visible = false;
                dgv_ReplacedPart.Columns["TypeRepPartID"].Visible = false;
                dgv_ReplacedPart.Columns["RepairID"].Visible = false;
                dgv_ReplacedPart.Columns["Zavnom"].Visible = true;


                if (Environment.UserName.ToUpper().Trim() == "PARFELYUK_AS" || Environment.UserName.ToUpper().Trim() == "KUDINA_NI" || Environment.UserName.ToUpper().Trim() == "GRIGORIEVA_OL")
                {
                    dgv_ReplacedPart.Columns["DataToday"].Visible = true;
                    dgv_ReplacedPart.Columns["DataToday"].HeaderText = "Дата внесения инфо.";
                    dgv_ReplacedPart.Columns["DataToday"].Width = 130;
                }
                else 
                { 
                    dgv_ReplacedPart.Columns["DataToday"].Visible = false;
                }

                

                dgv_ReplacedPart.Columns["Name"].HeaderText = "Найменування";
                dgv_ReplacedPart.Columns["Quantity"].HeaderText = "Кіл-ть";
                dgv_ReplacedPart.Columns["Mera"].HeaderText = "Од.";
                dgv_ReplacedPart.Columns["PartName"].HeaderText = "Стара назва";
                dgv_ReplacedPart.Columns["EDNOME"].HeaderText = "Номер";
                dgv_ReplacedPart.Columns["DateInRep"].HeaderText = "Дата отримання";
                dgv_ReplacedPart.Columns["DataReplace"].HeaderText = "Дата встановлення";
                dgv_ReplacedPart.Columns["Prace"].HeaderText = "Ціна";
                dgv_ReplacedPart.Columns["Zavnom"].HeaderText = "Завод.№";

                dgv_ReplacedPart.Columns["Name"].DisplayIndex = 1;
                dgv_ReplacedPart.Columns["Quantity"].DisplayIndex = 2;
                dgv_ReplacedPart.Columns["Mera"].DisplayIndex = 3;
                dgv_ReplacedPart.Columns["PartName"].DisplayIndex = 4;
                dgv_ReplacedPart.Columns["Prace"].DisplayIndex = 5;
                dgv_ReplacedPart.Columns["Zavnom"].DisplayIndex = 13;

                dgv_ReplacedPart.Columns["Name"].Width = 255;
                dgv_ReplacedPart.Columns["Quantity"].Width = 90;
                dgv_ReplacedPart.Columns["Mera"].Width = 30;


                SettingsColorRepPart();
                SettingsColorRepPartTypeRes3();
            }
            //Проверка на пустые строки у родительской таблице
            //if (dgv_Job.RowCount == 0)
            //{
            //    dgv_ReplacedPart.DataSource = null;
            //}


        }

        //при выборе строки ДГВ Ремонты меняется значение текстовых полей
        private void dgv_Repair_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            {

                //при выборе строки ДГВ меняется значение текстовых полей
                txt_TypeFlaut.Text = dgv_Repair.Rows[e.RowIndex].Cells["TypeFlaut"].Value.ToString();
                txt_Note.Text = dgv_Repair.Rows[e.RowIndex].Cells["Note"].Value.ToString();


                if (dgv_Repair.Rows[e.RowIndex].Cells["NameDet"].Value.ToString().Length > 0)
                {
                    txt_Responsible.Text = dgv_Repair.Rows[e.RowIndex].Cells["NameDet"].Value.ToString();
                }
                else
                {
                    txt_Responsible.Text = dgv_Repair.Rows[e.RowIndex].Cells["Responsible"].Value.ToString();
                }

                txt_Cause.Text = dgv_Repair.Rows[e.RowIndex].Cells["Cause"].Value.ToString();

                txt_NextNone.Text = dgv_Repair.Rows[e.RowIndex].Cells["NotedataNext"].Value.ToString();

                if (dgv_Repair.Rows[e.RowIndex].Cells["dataNext"].Value.ToString().Length > 0)
                {
                    dtp_dataNext.Text = dgv_Repair.Rows[e.RowIndex].Cells["dataNext"].Value.ToString();
                    txt_pic.Visible = false;
                }
                else
                {
                    txt_pic.Visible = true;
                }



                if (dgv_Repair.Rows[e.RowIndex].Cells["d_rem"].Value.ToString().Length > 0)
                {
                    dtp_d_rem.Text = dgv_Repair.Rows[e.RowIndex].Cells["d_rem"].Value.ToString();
                    dtp_d_rem.Visible = true;
                    // txt_d_rem.Visible = true;
                }
                else
                {
                    dtp_d_rem.Text = dgv_Repair.Rows[e.RowIndex].Cells["d_rem"].Value.ToString();
                    //txt_d_rem.Visible = false;
                    dtp_d_rem.Visible = false;
                }




                // MessageBox.Show(dgv_Job.RowCount.ToString());

                //меняем значения подотчетных таблиц
                //выполненные работы
                dgv_Job.DataSource = dal.GetAllJobForRepair(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                if (dgv_Job.RowCount > 0)
                {
                    Settings_allJobs();
                }
                else
                {
                    dgv_ReplacedPart.Visible = false;
                }
                //Записываем данные для дальнейшей передачи их в форму редактирования
                InfoRepair.AsRDivis = dgv_Repair.Rows[e.RowIndex].Cells["StoreName"].Value.ToString();
                InfoRepair.Divis = dgv_Repair.Rows[e.RowIndex].Cells["StoreName1"].Value.ToString();
                InfoRepair.DataIn = dgv_Repair.Rows[e.RowIndex].Cells["DateIn"].Value.ToString();
                InfoRepair.TypeFlaut = dgv_Repair.Rows[e.RowIndex].Cells["TypeFlaut"].Value.ToString();
                InfoRepair.Cause = dgv_Repair.Rows[e.RowIndex].Cells["Cause"].Value.ToString();
                InfoRepair.Note = dgv_Repair.Rows[e.RowIndex].Cells["Note"].Value.ToString();
                InfoRepair.DateOut = dgv_Repair.Rows[e.RowIndex].Cells["DateOut"].Value.ToString();
                InfoRepair.DateNext = dgv_Repair.Rows[e.RowIndex].Cells["dataNext"].Value.ToString();
                InfoRepair.Notedatanext = dgv_Repair.Rows[e.RowIndex].Cells["NotedataNext"].Value.ToString();
                InfoRepair.Responsible = dgv_Repair.Rows[e.RowIndex].Cells["Responsible"].Value.ToString();
                InfoRepair.RepairID = dgv_Repair.Rows[e.RowIndex].Cells["RepairID"].Value.ToString();
                InfoRepair.CODCX = dgv_Repair.Rows[e.RowIndex].Cells["CODCX"].Value.ToString();
                InfoRepair.CODBRIG = dgv_Repair.Rows[e.RowIndex].Cells["CODBRIG"].Value.ToString();
                InfoRepair.CODUTH = dgv_Repair.Rows[e.RowIndex].Cells["CODUTH"].Value.ToString();
                InfoRepair.CODDET = dgv_Repair.Rows[e.RowIndex].Cells["CODDET"].Value.ToString();
                InfoRepair.NAMEDET = dgv_Repair.Rows[e.RowIndex].Cells["NAMEDET"].Value.ToString();
                InfoRepair.NumberDivis = dgv_Repair.Rows[e.RowIndex].Cells["Rdivision"].Value.ToString();
                InfoRepair.Obekt = dgv_Repair.Rows[e.RowIndex].Cells["Obekt"].Value.ToString();


                try
                {
                    if (dgv_Repair.Rows[e.RowIndex].Cells["Name"].Value.ToString().Contains("послуг") && (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "39")) // посл без  матеріалів
                    {
                        button5.Visible = true;
                    }
                    else
                    {
                        button5.Visible = false;
                    }
                }
                catch 
                { }

                dgv_VozvrMet.DataSource = dal.GetAllVozvrMet();
                if (dgv_VozvrMet.RowCount > 0)
                {
                    SettingsAllVozvrMet();
                }


                dgv_VozvrDet.DataSource = dal.GetAllVozvrDet();

                if (dgv_VozvrDet.RowCount > 0)
                {
                    SettingsAllVozvrDet();
                }

                dgv_Job_For_AktF2.DataSource = dal.GetAllJobForAktF2_FromRepair(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                if (dgv_Job_For_AktF2.RowCount > 0)
                {
                    Settings_allJobsForAktF2();
                }


                txt_FIO1f2.Text = dgv_Repair.CurrentRow.Cells["FIO1f2"].Value.ToString();
                txt_FIO5f2.Text = dgv_Repair.CurrentRow.Cells["FIO5f2"].Value.ToString();
                txt_FIO2f2.Text = dgv_Repair.CurrentRow.Cells["FIO2f2"].Value.ToString();
                txt_FIO3f2.Text = dgv_Repair.CurrentRow.Cells["FIO3f2"].Value.ToString();
                txt_FIO4f2.Text = dgv_Repair.CurrentRow.Cells["FIO4f2"].Value.ToString();
                txt_dolg1f2.Text = dgv_Repair.CurrentRow.Cells["dolg1f2"].Value.ToString();
                txt_dolg5f2.Text = dgv_Repair.CurrentRow.Cells["dolg5f2"].Value.ToString();
                txt_dolg2f2.Text = dgv_Repair.CurrentRow.Cells["dolg2f2"].Value.ToString();
                txt_dolg3f2.Text = dgv_Repair.CurrentRow.Cells["dolg3f2"].Value.ToString();
                txt_dolg4f2.Text = dgv_Repair.CurrentRow.Cells["dolg4f2"].Value.ToString();


                //txt_FIO1f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["FIO1f2"].Value.ToString();
                //txt_FIO5f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["FIO5f2"].Value.ToString();
                //txt_FIO2f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["FIO2f2"].Value.ToString();
                //txt_FIO3f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["FIO3f2"].Value.ToString();
                //txt_FIO4f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["FIO4f2"].Value.ToString();
                //txt_dolg1f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["dolg1f2"].Value.ToString();
                //txt_dolg5f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["dolg5f2"].Value.ToString();
                //txt_dolg2f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["dolg2f2"].Value.ToString();
                //txt_dolg3f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["dolg3f2"].Value.ToString();
                //txt_dolg4f2.Text = dgv_Repair.Rows[e.RowIndex].Cells["dolg4f2"].Value.ToString();

            }

        }

        //выбор строки вида ремонт. По умолчанию - первая
        private void dgv_Job_CellEnter(object sender, DataGridViewCellEventArgs e)
        {




            //отображение заменяемой запчасти
         dgv_ReplacedPart.Visible = true;
            dgv_ReplacedPart.DataSource = dal.getAllReplacedPartForJob(dgv_Job.CurrentRow.Cells["JobId"].Value.ToString());
            Settings_ReplacedPart();
            dgv_ReplacedPart.Visible = true;
            // dgv_ReplacedPart.Columns[1].HeaderText = "dsffsd";


            dgv_PlacePart.Visible = false;

        }

        private void dgv_ReplacedPart_CellEnter(object sender, DataGridViewCellEventArgs e)
        {



            dgv_PlacePart.DataSource = dal.getAllPlacePart(dgv_ReplacedPart.CurrentRow.Cells["ReplacedId"].Value.ToString());

            //  if(dgv_PlacePart.CurrentRow.Cells["ReplacedId"].Value != null)
            PlacePart.Replaced_Id = dgv_ReplacedPart.CurrentRow.Cells["ReplacedId"].Value.ToString();

            if (dgv_PlacePart.RowCount > 0)
            {
                Settings_allPlacePart();
                dgv_PlacePart.Visible = false;
            }
            dgv_PlacePart.Visible = true;
        }

        private void btn_AddNewJob_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;

            if (dgv_Job.RowCount == 0)
            {  
            //строка передачи названия и инвентарного номера
            s = (dgv_Repair.CurrentRow.Cells["Name"].Value.ToString() + " ( інв.№ " + dgv_Repair.CurrentRow.Cells["inventoryNumber"].Value.ToString() + " )");
            // MessageBox.Show(myfrmNewJob.ShowDialog());           
            //получаем ИД ремонта
            string Repair_ID = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();

            myfrmNewJob myfrmNewJob = new myfrmNewJob(s, Repair_ID);
            if (myfrmNewJob.ShowDialog() == DialogResult.OK)
            {
                //  MessageBox.Show("Выполняемая работа добавлена");
                //MessageBox.Show(myfrmNewJob.ShowDialog().ToString());
                dgv_Job.DataSource = dal.GetAllJobForRepair(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                Settings_allJobs();
                //textBox1.Text = dal.GetAllJobForRepairqUERY(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Помилка!!! Робота не додана!");
                //textBox1.Text = dal.GetAllJobForRepairqUERY(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                // MessageBox.Show(myfrmNewJob.ShowDialog().ToString());
            }

             }
            else
            {
                MessageBox.Show("Не дозволено додавати більше 1 виду роботи!");
            }

            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку
        }
        //Добавление запчасти

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;

            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True"); 
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("select count(blocked) from [Repairs].[dbo].[Status_mes_mol] where cod_cx='" + InfoRepair.CODCX + "' and cod_uth='" + InfoRepair.CODUTH + "' and cod_brig='" + InfoRepair.CODBRIG + "' and cod_det='" + InfoRepair.CODDET + "' and blocked='так'", cn);
            int kol = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

            string dalee = "";

            if (kol > 0)
            {
                dalee = "no";
            }
            else
            {
                dalee = "yes";
            }
            cn.Close();

            if (dalee == "no")
            {
                MessageBox.Show("Заборонено вносити матеріали по МВО.","Зверніться до первічного відділу.");
                return ;
            }


            
            string canadd = "";

            if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "9")
            {
                canadd = "yes";
            }


            if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() != "9" && dgv_Job_For_AktF2.RowCount < 1)
            {
                canadd = "no";
            }
            if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() != "9" && dgv_Job_For_AktF2.RowCount > 0)
            {
                if (txt_dolg1f2.Text.Length < 1 || txt_dolg2f2.Text.Length < 1)
                {
                    canadd = "no";
                }
                else
                {
                    canadd = "yes";
                }
            }


            if (canadd == "no")
            {
                MessageBox.Show("Не все заполнено. Проверьте Выполненные работы и Подписи.","Не достаточно информации.");
                this.tabControl1.SelectedTab = tabPage3;
            }
            else

            {
            // dgv_Repair.DataSource = dal.GetAllRepair();


            if ((dgv_Repair.CurrentRow.Cells["NAMEDET"].Value.ToString().Length > 0) || (dgv_Repair.CurrentRow.Cells["RDivision"].Value.ToString() == "9966"))
            {
                RepaircoddetName.Codcx = dgv_Repair.CurrentRow.Cells["codcx"].Value.ToString();
                RepaircoddetName.Coduth = dgv_Repair.CurrentRow.Cells["coduth"].Value.ToString();
                RepaircoddetName.Codbrig = dgv_Repair.CurrentRow.Cells["codbrig"].Value.ToString();
                RepaircoddetName.Coddet = dgv_Repair.CurrentRow.Cells["coddet"].Value.ToString();

                if (Convert.ToInt32(dgv_Job.SelectedCells.Count) > 0)
                {

                    if (((Dostup.Codcx == RepaircoddetName.Codcx) && (Dostup.Coduth == RepaircoddetName.Coduth) &&
                        (Dostup.Codbrig == RepaircoddetName.Codbrig)
                        )
                        || ((Dostup.Codcx == RepaircoddetName.Codcx) && (Dostup.Coduth == "88")) || (dgv_Repair.CurrentRow.Cells["RDivision"].Value.ToString() == "9966") || Dostup.Kod_dostup_pr == "1000" )
                    {

                        try
                        {
                            //строка передачи названия и инвентарного номера
                            s = (dgv_Repair.CurrentRow.Cells["Name"].Value.ToString() + " ( інв.№ " + dgv_Repair.CurrentRow.Cells["inventoryNumber"].Value.ToString() + " )");
                            // MessageBox.Show(myfrmNewJob.ShowDialog());           
                            //получаем ИД ремонта
                            string Repair_ID = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();

                            //  MessageBox.Show(Convert.ToInt32(dgv_Job.CurrentRow.Cells["JobID"].Value).ToString());
                            // MessageBox.Show(Repair_ID);

                            string JobID = dgv_Job.CurrentRow.Cells["JobID"].Value.ToString();

                            //  MessageBox.Show(Repair_ID + "  " + JobID);

                            myfrmAddNewReplacerPart myfrmAddNewReplacerPart = new myfrmAddNewReplacerPart(JobID, dgv_Repair.CurrentRow.Cells["DateIn"].Value.ToString(), dgv_Repair.CurrentRow.Cells["DateOut"].Value.ToString());
                            myfrmAddNewReplacerPart.ShowDialog();

                            dgv_ReplacedPart.DataSource = dal.getAllReplacedPartForJob(dgv_Job.CurrentRow.Cells["JobId"].Value.ToString());
                            Settings_ReplacedPart();
                            
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка! Треба обрати Виконувану роботу!" + ex.Message);

                        }

                    }
                    else
                    {
                        MessageBox.Show(@"Вы не можете додати заміняєму запчастину.Ви не виконавець роботы!!! Ви не МВО");
                    }



                }
                else { MessageBox.Show("Необхідно додати Вконуючу роботу"); }
            }
            else
            {
                MessageBox.Show("Треба натиснути на кнопку РЕДАГУВАТИ та обрати МВО"); 
            }

            //SettingsAllVozvrDet();
        }
            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку

        }
        //Выделяем списанные детали
        private void SettingsColorRepPart()
        {
            if (dgv_ReplacedPart.RowCount > 0)
            {
                for (int i = 0; i < dgv_ReplacedPart.RowCount; i++)
                {
                    if (dgv_ReplacedPart.Rows[i].Cells["Original"].Value.ToString() == "1")
                    {
                        for (int j = 0; j < dgv_ReplacedPart.ColumnCount; j++)
                        {
                            dgv_ReplacedPart.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        if (dgv_ReplacedPart.Rows[i].Cells["Original"].Value.ToString() == "3")
                        {
                            for (int j = 0; j < dgv_ReplacedPart.ColumnCount; j++)
                            {
                                dgv_ReplacedPart.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;
                            }
                        }
                    }
                }
            }
        }

        //выделяем списанный металлолом
        private void SettingsColorRepMet()
        {
            if (dgv_VozvrMet.RowCount > 0)
            {
                for (int i = 0; i < dgv_VozvrMet.RowCount; i++)
                {
                    if (dgv_VozvrMet.Rows[i].Cells["Original"].Value.ToString() == "1")
                    {
                        for (int j = 0; j < dgv_VozvrMet.ColumnCount; j++)
                        {
                            dgv_VozvrMet.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        if (dgv_VozvrMet.Rows[i].Cells["Original"].Value.ToString() == "3")
                        {
                            for (int j = 0; j < dgv_VozvrMet.ColumnCount; j++)
                            {
                                dgv_VozvrMet.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;
                            }
                        }
                    }
                }
            }
        }


        //выделяем списанный детали
        private void SettingsColorRepDet()
        {
            if (dgv_VozvrDet.RowCount > 0)
            {
                for (int i = 0; i < dgv_VozvrDet.RowCount; i++)
                {
                    if (dgv_VozvrDet.Rows[i].Cells["Original"].Value.ToString() == "1")
                    {
                        for (int j = 0; j < dgv_VozvrDet.ColumnCount; j++)
                        {
                            dgv_VozvrDet.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        if (dgv_VozvrDet.Rows[i].Cells["Original"].Value.ToString() == "3")
                        {
                            for (int j = 0; j < dgv_VozvrDet.ColumnCount; j++)
                            {
                                dgv_VozvrDet.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;
                            }
                        }
                    }
                }
            }
        }



        //выделяем "Другие ресурсы шахты"
        private void SettingsColorRepPartTypeRes3()
        {
            if (dgv_ReplacedPart.RowCount > 0)
            {
                for (int i = 0; i < dgv_ReplacedPart.RowCount; i++)
                {
                    if (dgv_ReplacedPart.Rows[i].Cells["TypeRepPartID"].Value.ToString() == "3")
                    {
                        for (int j = 0; j < dgv_ReplacedPart.ColumnCount; j++)
                        {
                            dgv_ReplacedPart.Rows[i].Cells[j].Style.ForeColor = Color.Red;
          
                        }
                    }

                }

            }
        }








        //Редактирование ремонта
        private void btn_alterRepair_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;
            try
            {
                if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "39") // Если послуги без материалів не редактировать если есть акт по услугам
                {
                    SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True"); 
                    cn.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT top (1) ID from Akti_Usl where repairid='" + dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString() + "'", cn);
                    int kol = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                    string dalee = "";

                    if (kol > 0)
                    {
                        dalee = "no";
                    }
                    else
                    {
                        dalee = "yes";
                    }
                    cn.Close();

                    if (dalee == "no")
                    {
                        MessageBox.Show("Нельзя редактировать, т.к. уже сформирован акт по услуге № " + kol.ToString());
                        return;
                    }
                }
            }
            catch { }

            string rremid = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();
            if (((dgv_Job.RowCount > 0) && (dgv_Job.Visible == true)) || ((dgv_ReplacedPart.Visible == true) && (dgv_ReplacedPart.RowCount > 0)))
            {
                Dostup.Visib = 1;

            }
            else { Dostup.Visib = 0; }




            s = (dgv_Repair.CurrentRow.Cells["Name"].Value.ToString() + " ( инв.№ " + dgv_Repair.CurrentRow.Cells["inventoryNumber"].Value.ToString() + " )");
            //получаем ИД ремонта
            string Repair_ID = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();
            myfrmAlterReport myfrmAlterReport = new myfrmAlterReport();





            if (myfrmAlterReport.ShowDialog() == DialogResult.OK)
            {
                dgv_Repair.DataSource = dal.GetAllRepair("");
            }

            // myfrmAlterReport.ShowDialog();
            dgv_Repair.DataSource = dal.GetAllRepair("");

            // переходим на нужную строку
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair[2, i].FormattedValue.ToString().Contains(Text = rremid))
                    dgv_Repair.CurrentCell = dgv_Repair.Rows[i].Cells[3];
            }

            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataDourceToDataSearch();
            if (dgv_Repair.RowCount > 0)
            {
                Settings_allRepair();
            }

        }

        private void dataDourceToDataSearch()
        {
            Dostup.A = 1;
            Dostup.DateIn1 = dtp_datein1.Value.ToString("yyyyMMdd");
            Dostup.DateIn2 = dtp_datein2.Value.ToString("yyyyMMdd");
            dgv_Repair.DataSource = dal.GetAllRepair("");
            // Dostup.A = 0;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;

            dgv_PlacePart.Visible = false;

            myfrmNewPlacePart myfrmNewPlacePart = new myfrmNewPlacePart();

            //  myfrmNewPlacePart.ShowDialog();

            if (myfrmNewPlacePart.ShowDialog() == DialogResult.OK)
            {
                //  MessageBox.Show("Место установки работа добавлена");
                //MessageBox.Show(myfrmNewJob.ShowDialog().ToString());
                //dgv_з.DataSource = dal.GetAllJobForRepair(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                // Settings_allJobs();
            }
            else
            {
                MessageBox.Show("Помилка!!! Місце встановлення не додано!");
                // MessageBox.Show(myfrmNewJob.ShowDialog().ToString());

            }

            dgv_PlacePart.DataSource = dal.getAllPlacePart(dgv_ReplacedPart.CurrentRow.Cells["ReplacedId"].Value.ToString());
            dgv_PlacePart.Visible = true;

            if (dgv_PlacePart.RowCount > 0)
            {
                Settings_allPlacePart();
            }

            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку

        }
        //удаление места установки
        private void button10_Click(object sender, EventArgs e)
        {
            string message = "Ви Вилучаєте місце встановлення ";
            //+ dgv_Repair.CurrentRow.Cells["InventoryNumber"].Value.ToString() +
            //"  " + dgv_Repair.CurrentRow.Cells["Name"].Value.ToString();
            const string caption = "Уважно подумай!!!";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if ((result == DialogResult.Yes) && (dgv_PlacePart.RowCount > 0))
            {
                if (dal.DeletePlacePart(dgv_ReplacedPart.CurrentRow.Cells["ReplacedID"].Value.ToString(), dgv_PlacePart.CurrentRow.Cells["PlaceCode"].Value.ToString()) == true)
                {
                    //  MessageBox.Show("Запись удачно удалена");
                    dgv_PlacePart.DataSource = dal.getAllPlacePart(dgv_ReplacedPart.CurrentRow.Cells["ReplacedID"].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Помилка! Не вдалось вилучити запис! ");
                }
            }
            else
            {
                MessageBox.Show("Нічого вилучати");

            }



        }
        //удалить заменяемую запчасть
        private void btn_deleteRepPart_Click(object sender, EventArgs e)
        {
            if (dgv_PlacePart.RowCount > 0)
            {
                MessageBox.Show("Помилка!!! Необхідно вилучити всі місця встановлення деталей");
            }
            //удаляем запись
            else
            {
                //  if ((dgv_ReplacedPart.CurrentRow.Cells["Original"].Value.ToString() == "1") |
                //  (dgv_ReplacedPart.CurrentRow.Cells["Original"].Value.ToString() == "3"))
                //  MessageBox.Show("Вилучити неможливо. Деталь вже у сформованій відомості ресурсів.");


                if (dgv_ReplacedPart.CurrentRow.Cells["Original"].Value.ToString() == "3")
                {
                    MessageBox.Show("Вилучити неможливо. Відомість ресурсів вже списана.");

                }
                else
                {
                    RepaircoddetName.Codcx = dgv_Repair.CurrentRow.Cells["codcx"].Value.ToString();
                    RepaircoddetName.Coduth = dgv_Repair.CurrentRow.Cells["coduth"].Value.ToString();
                    RepaircoddetName.Codbrig = dgv_Repair.CurrentRow.Cells["codbrig"].Value.ToString();
                    RepaircoddetName.Coddet = dgv_Repair.CurrentRow.Cells["coddet"].Value.ToString();
                    if (((Dostup.Codcx == RepaircoddetName.Codcx) && (Dostup.Coduth == RepaircoddetName.Coduth) &&
                        (Dostup.Codbrig == RepaircoddetName.Codbrig)) || ((Dostup.Codcx == RepaircoddetName.Codcx) && (Dostup.Coduth == "88")) || (dgv_Repair.CurrentRow.Cells["RDivision"].Value.ToString() == "9966"))
                    {
                        string message = "Ви Вилучаєте замінну запчастину ";
                        const string caption = "Уважно подумай!!!";
                        var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                        if ((result == DialogResult.Yes) && (dgv_ReplacedPart.RowCount > 0) && dgv_Job.SelectedCells.Count >= 1)
                        {
                            string c_repid = dgv_ReplacedPart.CurrentRow.Cells["RepairID"].Value.ToString();
                            string c_nam_nomenkl = dgv_ReplacedPart.CurrentRow.Cells["Name"].Value.ToString();
                            string с_replacedID= dgv_ReplacedPart.CurrentRow.Cells["ReplacedID"].Value.ToString();

                            if (dal.DeleteReplacedPart(dgv_ReplacedPart.CurrentRow.Cells["ReplacedID"].Value.ToString()) == true)
                            {
                                MessageBox.Show("Запис вдало вилучена");
                                //************
                                SqlCommand cmd = new SqlCommand("select count(id) from [Repairs].[dbo].VozvrDet where RepairID='" + c_repid + "' and name='" + c_nam_nomenkl .Trim()+ "'", con);
                                con.Open();
                                string kk = cmd.ExecuteScalar().ToString();
                                con.Close();
                                if (Convert.ToInt32(kk) > 0)
                                {
                                    MessageBox.Show("Не забудьте вилучити повернені деталі");
                                    this.tabControl1.SelectedTab = tabPage2;
                                    
                                }

                                //*************
                                dgv_ReplacedPart.DataSource = dal.getAllReplacedPartForJob(dgv_Job.CurrentRow.Cells["JobId"].Value.ToString());
                                Settings_ReplacedPart();
                            }
                            else
                            {
                                MessageBox.Show("Помилка! Не вдалось вилучити запис! ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Нічого вилучати");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Ви не можете додавати замінну запчастину.
Ви не виконавець роботи!!! Ви не МВО");
                    }
                }
            }
        }
        //Удаление выполняемой работы
        private void btn_deleteJob_Click(object sender, EventArgs e)
        {
            string rremid = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();
            try
            {
                if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "39") // Если послуги без материалів не редактировать если есть акт по услугам
                {
                    SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True"); 
                    cn.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT top (1) ID  from Akti_Usl where repairid='" + dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString() + "'", cn);
                    int kol = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                    string dalee = "";

                    if (kol > 0)
                    {
                        dalee = "no";
                    }
                    else
                    {
                        dalee = "yes";
                    }
                    cn.Close();

                    if (dalee == "no")
                    {
                        MessageBox.Show("Нельзя удалять, т.к. уже сформирован акт по услуге № " + kol.ToString());
                        return;
                    }
                }

            }
            catch { }

            if ((dgv_PlacePart.RowCount > 0) || (dgv_ReplacedPart.RowCount > 0))
            {
               // MessageBox.Show("ОШИБКА!!! Необходимо удалить все места установки деталей или установленные детали!")

                MessageBox.Show("Помилка!!! Необхідно вилучити всі місця встановлення деталей або встановленні деталі!");
            }
            //удаляем запись
            else
            {
                string message = ("Ви вилучаєте Вид ремонту. ");
                const string caption = ("Уважно подумай!!!");
                var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                if ((result == DialogResult.Yes) && (dgv_Job.RowCount > 0))
                {
                    if (dal.DeleteJob(dgv_Job.CurrentRow.Cells["JobID"].Value.ToString()) == true)
                    {
                        MessageBox.Show("Запис вдало вилучена");
                        dgv_Job.DataSource = dal.GetAllJobForRepair(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Помилка! Не вдалось вилучити запис! ");
                    }


                    dgv_Repair.DataSource = dal.GetAllRepair("");

                    // переходим на нужную строку
                    for (int i = 0; i < dgv_Repair.RowCount; i++)
                    {
                        if (dgv_Repair[2, i].FormattedValue.ToString().Contains(Text = rremid))
                            dgv_Repair.CurrentCell = dgv_Repair.Rows[i].Cells[3];
                    }

                }
                else
                {
                    MessageBox.Show("Нічого вилучати");
                }
            }



          
          


        }

        //Добавление возвратноq Детали
        private void btn_AddVozvrDet_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;

            myfrmAddNewVozvrDet myfrmAddNewVozvrDet = new myfrmAddNewVozvrDet();
            if (myfrmAddNewVozvrDet.ShowDialog() == DialogResult.OK)
            {
                dgv_VozvrDet.DataSource = dal.GetAllVozvrDet();

                if (dgv_VozvrDet.RowCount > 0)
                {
                    SettingsAllVozvrDet();
                }
            }
            else
            {
                MessageBox.Show("Помилка!!! Запис не додано!!!");
            }
            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку
        }
        //Добавление металлолома

        private void SettingsAllVozvrMet()
        {
            dgv_VozvrMet.Columns["Name"].HeaderText = "Назва";
            dgv_VozvrMet.Columns["EdIzm"].HeaderText = "Од.вим.";
            dgv_VozvrMet.Columns["Price"].HeaderText = "Ціна";
            dgv_VozvrMet.Columns["Quantity"].HeaderText = "Кіл-ть";
            dgv_VozvrMet.Columns["Sum"].HeaderText = "Сума";
            dgv_VozvrMet.Columns["Note"].HeaderText = "Примітка";
            dgv_VozvrMet.Columns["DataVozvr"].HeaderText = "Дата Повернення";

            dgv_VozvrMet.Columns["Name"].DisplayIndex = 1;
            dgv_VozvrMet.Columns["EdIzm"].DisplayIndex = 3;
            dgv_VozvrMet.Columns["Price"].DisplayIndex = 5;
            dgv_VozvrMet.Columns["Quantity"].DisplayIndex = 2;
            dgv_VozvrMet.Columns["Sum"].DisplayIndex = 4;
            dgv_VozvrMet.Columns["Note"].DisplayIndex = 6;
            dgv_VozvrMet.Columns["DataVozvr"].DisplayIndex = 7;

            dgv_VozvrMet.Columns["EdIzm"].Width = 50;
            dgv_VozvrMet.Columns["Name"].Width = 170;
            dgv_VozvrMet.Columns["Quantity"].Width = 70;

            dgv_VozvrMet.Columns["ID"].Visible = false;
            SettingsColorRepMet();
        }


        private void SettingsAllVozvrDet()
        {
            dgv_VozvrDet.Columns["Name"].HeaderText = "Назва";
            dgv_VozvrDet.Columns["Quantity"].HeaderText = "Кіл-ть";
            dgv_VozvrDet.Columns["Note"].HeaderText = "Примітка";
            dgv_VozvrDet.Columns["DataVozvr"].HeaderText = "Дата Повернення";
            dgv_VozvrDet.Columns["Name"].Width = 170;
            dgv_VozvrDet.Columns["Quantity"].Width = 70;

            dgv_VozvrDet.Columns["ID"].Visible = false;
            dgv_VozvrDet.Columns["DataToday"].Visible = false;
            SettingsColorRepDet();
        }

        //Добавление возвратного металлолома
        private void button4_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;

            myfrmAddNewVozvrMet myfrmAddNewVozvrMet = new myfrmAddNewVozvrMet();
            if (myfrmAddNewVozvrMet.ShowDialog() == DialogResult.OK)
            {
                dgv_VozvrMet.DataSource = dal.GetAllVozvrMet();

                if (dgv_VozvrMet.RowCount > 0)
                {
                    SettingsAllVozvrMet();
                }
            }
            else
            {
                MessageBox.Show("Помилка!!! Запис не додано!!!");
            }
            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку
        }
        //удаление Возвращаемого металлолома

        private void btn_DelVozvrMet_Click(object sender, EventArgs e)
        {

            if (dgv_VozvrMet.RowCount > 0)
            {
                if (dgv_VozvrMet.CurrentRow.Cells["original"].Value.ToString() == "3")
                {
                    MessageBox.Show("Запис - оригінал! ");
                }
                else
                {
                    if (dal.DeleteVozvrMet(dgv_VozvrMet.CurrentRow.Cells["ID"].Value.ToString()) == true)
                    {
                        MessageBox.Show("Запис вдало вилучена!");
                        dgv_VozvrMet.DataSource = dal.GetAllVozvrMet();
                        if (dgv_VozvrMet.RowCount > 0)
                        {
                            SettingsAllVozvrMet();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Помилка вилучення!!!");
                    }
                }
            }
        }

        //Удаление возвратной детали
        private void btn_DelVozvrDet_Click(object sender, EventArgs e)
        {

            if (dgv_VozvrDet.RowCount > 0)
            {
                if (dal.DeleteVozvrDet(dgv_VozvrDet.CurrentRow.Cells["ID"].Value.ToString()) == true)
                {
                    MessageBox.Show("Запис вдало вилучено!");
                    dgv_VozvrDet.DataSource = dal.GetAllVozvrDet();
                    if (dgv_VozvrDet.RowCount > 0)
                    {
                        SettingsAllVozvrDet();
                    }
                }
                else
                {
                    MessageBox.Show("Помилка вилучення!!!");
                }
            }
        }
        //поиск по инвентарному номеру
        private void txt_SearchInv_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchInv.Text.Length > 2)
            {
                SearchForInventory();
            }
            else
            {
                dgv_Repair.DataSource = dal.GetAllRepair("");
            }
        }

        //поиск по названию
        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchName.Text.Length > 2)
            {
                SearchForName();
            }
            else
            {
                dgv_Repair.DataSource = dal.GetAllRepair("");
            }
        }
        private void txt_SearchCeh_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchCeh.Text.Length > 0)
            {
                SearchForCeh();
            }
            else
            {
                dgv_Repair.DataSource = dal.GetAllRepair("");
            }
        }
        //в ремонте
        private void rbtn_YesRepair_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_NotRepair.Checked == true)
            {
                dgv_Repair.DataSource = dal.GetAllRepair("");
                SearchForNotDataEnd();
            }
        }
        //ремонт закончен
        private void rbtn_NotRepair_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_YesRepair.Checked == true)
            {
                dgv_Repair.DataSource = dal.GetAllRepair("");
                SearchForYesDataEnd();
            }
        }

        //поиск в ремонте (дата пустая)
        private void SearchForNotDataEnd()
        {
            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["DateOut"].Value.ToString() == "")
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }
        }

        //поиск в ремонте (дата не пустая)
        private void SearchForYesDataEnd()
        {
            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["DateOut"].Value.ToString().Length > 2)
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }
        }
        private void SearchForCeh()
        {
            dgv_Repair.ReadOnly = false;
            dgv_Repair.CurrentCell = null;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["RDivision"].Value.ToString() != txt_SearchCeh.Text)
                {
                    dgv_Repair.Rows[i].Visible = false;
                }
                else
                {
                    dgv_Repair.Rows[i].Visible = true;
                }
            }
        }
        //поиск по инвентарному номеру
        private void SearchForInventory()
        {

            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["InventoryNumber"].Value.ToString().Contains(txt_SearchInv.Text) == false)
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }
        }
        //поиск по названию
        private void SearchForName()
        {
            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["Name"].Value.ToString().ToLowerInvariant().Contains(txt_SearchName.Text) == false)
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }

        }

        private void myfrmCarriagesRepairs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DAL dal = new DAL();
            //string ID = dgv_Repair.CurrentRow.Cells["ID"].Value.ToString();
            //string RepairID = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();
            //dal.GetAllRepair();
            //string ID = "9266";
            
           // string InvNum= dgv_Repair.CurrentRow.Cells["RDivision"].Value.ToString();
            string RDivision = dgv_Repair.CurrentRow.Cells["RDivision"].Value.ToString();
            //string RDivision="1";
            frm_ZvitNabrSum frm_ZvitNabrSum = new frm_ZvitNabrSum(RDivision);
            frm_ZvitNabrSum.ShowDialog();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string InventoryNumber = dgv_Repair.CurrentRow.Cells["InventoryNumber"].Value.ToString();
            //string Original = dgv_Repair.CurrentRow.Cells["Original"].Value.ToString();
            //DateTime DateIn = dgv_Repair.CurrentRow.Cells["DateIn"].Value.to;
           // string DateIn="02.03.2016";

            //string RDivision="1";
            DAL dal = new DAL();
            // считаем сумму по ОС не закрітіх ремонтов
            //double sum = dal.SumPoInv(InventoryNumber, DateIn);
           // string sum = dal.SumPoInv2(InventoryNumber);
            string sum = dal.SumPoInv(InventoryNumber).ToString();
            //textBox1.Text = sum.ToString();
            MessageBox.Show(sum.ToString()+"грн.  - Загальна сума по незакритим запчастинам");
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(Dostup.AddQueryAlterRepair());
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_Job_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Repair_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;

            DAL dal = new DAL();
            string ID_Repair; string name_job;
            ID_Repair = dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString();
            frmAddJobInRepairForAKT_F2 frmAddJobInRepairForAKT_F2 = new frmAddJobInRepairForAKT_F2(ID_Repair);
            
            if (frmAddJobInRepairForAKT_F2.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show("Add");
            }
            else
            {
                MessageBox.Show("Помилка!!! не додано!");
            }
            if (dgv_Job_For_AktF2.RowCount > 0)
            {
                dgv_Job_For_AktF2.DataSource = dal.GetAllJobForAktF2_FromRepair(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                Settings_allJobsForAktF2();
            }

            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_Job_For_AktF2.RowCount < 1)
            {
                MessageBox.Show("Нет записи для удаления.");
                
            }
            else
            {

                var result = MessageBox.Show("Действительно удалить работу?", "Удаление работы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ((result == DialogResult.Yes) && (dgv_Job_For_AktF2.RowCount > 0))
                {

                    //string ID;
                    //ID = dgv_Job_For_AktF2.CurrentRow.Cells["Id"].Value.ToString();
                    //MessageBox.Show(ID);
                    DAL dal = new DAL();
                    if (dal.DeleteJobFromAKT2(dgv_Job_For_AktF2.CurrentRow.Cells["Id"].Value.ToString()) == true)
                    {
                    //    //  MessageBox.Show("Запись удачно удалена");
                    }
                    else
                    {
                        MessageBox.Show("Помилка! Не вдалось вилучити запис! ");
                    }
                    //dgv_JobFromAKT.DataSource = dal.GetJobFromAKT(ID, remusl.ToString());
                    if (dgv_Job_For_AktF2.RowCount > 0)
                    {

                        dgv_Job_For_AktF2.DataSource = dal.GetAllJobForAktF2_FromRepair(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString());
                        if(dgv_Job_For_AktF2.Rows.Count > 0)
                            Settings_allJobsForAktF2();

                    }                    
                    //SettingsJob();


                }
            }
        }

        private void btn_alter_ReplacedPart_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Job_For_AktF2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_Repair.CurrentRow.Index;

            string rremid = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();
            string nam_remusl = "";
            if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "38" || dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "39") // послуги
            {
                if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "38") //&& послуги з матер
                {
                    nam_remusl = "usl_mat";
                }
                else
                {
                    nam_remusl = "usl";
                }

            }
            else
            {
                nam_remusl = "rem";
            }

            myfrmPidpisiForAktF2 myfrmPidpisiForAktF2 = new myfrmPidpisiForAktF2(dgv_Repair.CurrentRow.Cells["RepairId"].Value.ToString(),nam_remusl,  txt_FIO1f2.Text.ToString(), txt_dolg1f2.Text.ToString(),
                txt_FIO2f2.Text.ToString(), txt_dolg2f2.Text.ToString(), txt_FIO3f2.Text.ToString(), txt_dolg3f2.Text.ToString(), txt_FIO4f2.Text.ToString(),
                txt_dolg4f2.Text.ToString(), txt_FIO5f2.Text.ToString(), txt_dolg5f2.Text.ToString(), dgv_Repair.CurrentRow.Cells["CODCX"].Value.ToString(),
                dgv_Repair.CurrentRow.Cells["CODUTH"].Value.ToString(), dgv_Repair.CurrentRow.Cells["CODBRIG"].Value.ToString(),
                dgv_Repair.CurrentRow.Cells["CODDET"].Value.ToString());


            myfrmPidpisiForAktF2.ShowDialog();
            dgv_Repair.DataSource = dal.GetAllRepair("");


            // переходим на нужную строку
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair[2, i].FormattedValue.ToString().Contains(Text = rremid))
                    dgv_Repair.CurrentCell = dgv_Repair.Rows[i].Cells[3];
            }

            dgv_Repair.FirstDisplayedCell = dgv_Repair.Rows[a].Cells["no_pp"];
            dgv_Repair.Rows[a].Selected = true;
            dgv_Repair.CurrentCell = dgv_Repair.Rows[a].Cells["no_pp"]; // возврат на прежднюю строку

  
        }

        private void dgv_VozvrDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgv_Job.CurrentRow.Cells["JobCode"].Value.ToString() == "39") // Если послуги без материалів не редактировать если есть акт по услугам
                {
                    SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True");
                    cn.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT top (1) ID  from Akti_Usl where repairid='" + dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString() + "'", cn);
                    int kol = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                    string dalee = "";

                    if (kol > 0)
                    {
                        dalee = "no";
                    }
                    else
                    {
                        dalee = "yes";
                    }
                    cn.Close();

                    if (dalee == "no")
                    {
                        MessageBox.Show("Нельзя изменить инв.ОС, т.к. уже сформирован акт по услуге № " + kol.ToString());
                        return;
                    }
                }

            }
            catch { }

            string rremid = dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString();
            myfrmSearchTMC myfrmSearchTMC = new myfrmSearchTMC("rem", "", "");
            myfrmSearchTMC.FormClosed += (closedSender, closedE) =>
            {
               
                {
                    //txt_invNum.Text = Inv_Number.Inv_n;
                    //txt_InvName.Text = Inv_Number.Inv_name;
                    //txt_Obekt.Text = Inv_Number.Obekt;
                    if (Inv_Number.Inv_n.Length<2)
                    {
                        return;
                    }

                    if (dal.UpdateRepair_inv_usl(Inv_Number.Inv_n, Inv_Number.Obekt) == true)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                    }

                    if (this.DialogResult == DialogResult.OK)
                    {


                        dgv_Repair.DataSource = dal.GetAllRepair("");
                        // myfrmAlterReport.ShowDialog();
                        dgv_Repair.DataSource = dal.GetAllRepair("");
                        // переходим на нужную строку
                        for (int i = 0; i < dgv_Repair.RowCount; i++)
                        {
                            if (dgv_Repair[2, i].FormattedValue.ToString().Contains(Text = rremid))
                                dgv_Repair.CurrentCell = dgv_Repair.Rows[i].Cells[3];
                        }
                    }
                }




            };
            //исправил. надо вернуть на место
            myfrmSearchTMC.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button11.PerformClick();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dgv_Repair.DataSource = dal.GetAllRepair("queryNotInVed");
            }
        }


      
    }


    //передача значений для редактирования формы (информации о ремонте)
    public class InfoRepair
    {
        private static string asRDivis = "";
        private static string divis = "";

        private static string numberdivis = "";

        private static string typeFlaut = "";
        private static string cause = "";
        private static string responsible = "";
        private static string note = "";
        private static string notedatanext = "";
        private static string datain = "19990101";
        private static string datanext = "";
        private static string dataout = "";
        private static string inventotyNumber = "";
        private static string obekt = "";

        public static string InventotyNomber { get; set; }

        public static string AsRDivis
        {
            get { return asRDivis; }
            set { asRDivis = value; }
        }

        public static string Divis
        {
            get { return divis; }
            set { divis = value; }
        }

        public static string DataIn
        {
            get { return datain; }
            set { datain = value; }
        }

        public static string TypeFlaut
        {
            get { return typeFlaut; }
            set { typeFlaut = value; }
        }

        public static string Cause
        {
            get;
            set;
        }

        public static string Note { get; set; }
        public static string DateOut { get; set; }

        public static string DateNext { get; set; }
        public static string Notedatanext { get; set; }
        public static string Responsible { get; set; }
        public static string CODCX { get; set; }
        public static string CODUTH { get; set; }
        public static string CODBRIG { get; set; }
        public static string CODDET { get; set; }
        public static string NAMEDET { get; set; }
        public static string RepairID { get; set; }
        public static string NumberDivis { get; set; }
        public static string Obekt { get; set; }
    }
}