using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;

namespace Repairs
{
    public partial class myfrmVedomostResursovForAllOS : Form
    {
        DAL dal = new DAL();
        int a = 0;//переменные для удачного показателя выполнения добавления в вед рес деталей металлолома, и возвр дет и самой ведомости ресурсов
        int b = 0;
        int c = 0;
        int d = 0;
        double bbalcena = 0;
        public myfrmVedomostResursovForAllOS(string inventnumber,string obekt, string datn, string datk )
        {
            InitializeComponent();
            SettingsMyfrmVedomostResursovForAllRepairs();
            string invnum = inventnumber;
            string objekt = obekt;
            label9.Text = invnum;
            label11.Text = objekt.ToString();

            DAL dal = new DAL();
            string bbal_cena1 = dal.SelectB_Bal_cena(invnum, obekt);
            string bbal_cena2 = (bbal_cena1.Replace(".", ","));
            //bbalcena = Convert.ToDouble(bbal_cena.Replace(".",","));
            if (bbal_cena2.Length > 0)
                bbalcena = Convert.ToDouble(bbal_cena2);
            else
                bbalcena = 0;
            
            //bbalcena = Convert.ToInt32(bbal_cena2);

            //bbalcena = dal.SelectB_Bal_cena_double(invnum, obekt);

            Debug.WriteLine(bbalcena);
            label6.Text = bbalcena.ToString();
            //dtp_date1.Value = datn;
            dtp_date1.Value = new DateTime(Convert.ToInt32((datn.Substring(0, 4))), Convert.ToInt32((datn.Substring(4, 2))), Convert.ToInt32((datn.Substring(6, 2))));
            dtp_date2.Value = new DateTime(Convert.ToInt32((datk.Substring(0, 4))), Convert.ToInt32((datk.Substring(4, 2))), Convert.ToInt32((datk.Substring(6, 2))));
            //dtp_date2.Value = Convert.ToDateTime(datk);
        }

        //private void myfrmVedomostResursovForAllOS_Load(object sender, EventArgs e)
        //{
 

        //}

        //настройки для списуемых запчастей
        private void SettingsMyfrmVedomostResursovForAllRepairs() {

            if (dgv_RepPlaceVedRes.RowCount > 0)
            {
                dgv_RepPlaceVedRes.Columns["ReplacedID"].Visible = false;
                dgv_RepPlaceVedRes.Columns["JobID"].Visible = false;
                dgv_RepPlaceVedRes.Columns["RepairID"].Visible = false;
                dgv_RepPlaceVedRes.Columns["PartID"].Visible = false;
               // dgv_RepPlaceVedRes.Columns["ReplacedID1"].Visible = false;
                dgv_RepPlaceVedRes.Columns["DateInRep"].Visible = false;
                dgv_RepPlaceVedRes.Columns["Original"].Visible = false;
                dgv_RepPlaceVedRes.Columns["Zavnom"].Visible = true;

                dgv_RepPlaceVedRes.Columns["Quantity"].HeaderText = "Кол-во";
                dgv_RepPlaceVedRes.Columns["Name"].HeaderText = "Наименование";
                dgv_RepPlaceVedRes.Columns["Mera"].HeaderText = "Ед.Изм.";
                dgv_RepPlaceVedRes.Columns["EDNOME"].HeaderText = "Инв.№";
                dgv_RepPlaceVedRes.Columns["DataReplace"].HeaderText = "Установка";
                dgv_RepPlaceVedRes.Columns["Prace"].HeaderText = "Цена";
                dgv_RepPlaceVedRes.Columns["Zavnom"].HeaderText = "Завод.№";
                
                dgv_RepPlaceVedRes.Columns["EDNOME"].DisplayIndex = 1;
                dgv_RepPlaceVedRes.Columns["Name"].DisplayIndex = 2;
                dgv_RepPlaceVedRes.Columns["Quantity"].DisplayIndex = 3;
                dgv_RepPlaceVedRes.Columns["Mera"].DisplayIndex = 4;
                dgv_RepPlaceVedRes.Columns["DataReplace"].DisplayIndex = 5;
                dgv_RepPlaceVedRes.Columns["Zavnom"].DisplayIndex = 6;

                dgv_RepPlaceVedRes.Columns["znak"].Width = 20;
                dgv_RepPlaceVedRes.Columns["EDNOME"].Width = 60;
                dgv_RepPlaceVedRes.Columns["Name"].Width = 200;
                dgv_RepPlaceVedRes.Columns["Quantity"].Width = 90;
                dgv_RepPlaceVedRes.Columns["Mera"].Width = 40;
                dgv_RepPlaceVedRes.Columns["DataReplace"].Width = 90;
                

                foreach (DataGridViewRow row in (dgv_RepPlaceVedRes as DataGridView).Rows)
                {
                    (row.Cells["znak"] as DataGridViewCheckBoxCell).Value = true;
                }
                calculate();
                
            }      
        }


        //private void calculate2()
        //{
        //    SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
        //    cn.Open();
        //    //SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label9.Text.ToString() + " and ( PeriodData1 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "' or  PeriodData2 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "')", cn);
        //    SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label9.Text.ToString() + " and ( ( '" + dtp_date1.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData2) )", cn);

        //    Debug.WriteLine(cm0.CommandText);
        //    SqlDataReader dr0 = cm0.ExecuteReader();
        //    if (dr0.HasRows)
        //    {
        //        MessageBox.Show("Інв.№ " + this.label9.Text.ToString() + " за період з " + dtp_date1.Value.ToString("dd.MM.yyyy") + " по " + dtp_date2.Value.ToString("dd.MM.yyyy") + " вже ремонтує інший. Неможливо сформувати вфдомість ресурсів.");
        //        canformirovat = "no";
        //    }
        //    else
        //    {
        //        //MessageBox.Show("can form");
        //        canformirovat = "yes";
        //    }
        //    dr0.Close();
        //}

        private void calculate()
        {



            //**** ТМЦ (за текущий месяц) на сумму
            string invnum = this.label9.Text.ToString();
            string objekt = this.label11.Text.ToString();
            string year_date2 = dtp_date2.Value.Year.ToString();
            string month_date2 = dtp_date2.Value.Month.ToString();
            double tmc_sum_tekmes = dal.ReturnSumReplaceParts(invnum, objekt, year_date2, month_date2);
            label16.Text = Convert.ToString(Math.Round(Convert.ToSingle(Convert.ToString(tmc_sum_tekmes)), 2));
            //***


            double sumall = 0;


            for (int i = 0; i < dgv_RepPlaceVedRes.Rows.Count; i++)
            {

                if (Convert.ToBoolean(dgv_RepPlaceVedRes["znak", i].Value))
                {
                    double o = Convert.ToDouble(dgv_RepPlaceVedRes["Quantity", i].Value) * Convert.ToDouble(dgv_RepPlaceVedRes["Prace", i].Value);
                    sumall += o;
                }
            }
            label7.Text = Convert.ToString(sumall);
            //?????????????

            btn_AddNewVedRes.Enabled = false ;
            //label7.Text = label7.Text.Replace(",00", "");
            //label6.Text = label6.Text.Replace(",00", "");
            //string lab6 = this.label6.Text.Replace('.', ',');
            //if (Convert.ToDouble(lab6) == 0 && sumall + tmc_sum_tekmes > 50000 || Convert.ToDouble(lab6) > 0 && sumall + tmc_sum_tekmes > 300000)
            if (bbalcena == 0 && sumall + tmc_sum_tekmes > 50000 || bbalcena > 0 && sumall + tmc_sum_tekmes > 300000)
            {
                radioButton1.Visible = true;
                label10.Visible = true;
                radioButton2.Visible = true;
                
            } 
            else
            {
                radioButton1.Visible = false;
                label10.Visible = false;
                radioButton2.Visible = false;
                
                btn_AddNewVedRes.Enabled = true;
            }
            label7.Text = Convert.ToString(Math.Round(Convert.ToSingle(Convert.ToString(sumall)), 2));
            if (!label7.Text.Contains(','))
            {
                label7.Text += ",00";
            }
            //if (!label6.Text.Contains('.'))
            //{
            //    label6.Text += ",00";
            //}
            label18.Text = Convert.ToString(Math.Round(Convert.ToSingle(Convert.ToString(sumall + tmc_sum_tekmes)), 2));
        }

        //настройки для возвратных деталей
        private void Settings_dgv_VozvrDet() {
            if (dgv_VozvrDet.RowCount > 0)
            {
                dgv_VozvrDet.Columns["ID"].Visible = false;
                dgv_VozvrDet.Columns["Quantity"].HeaderText = "Кол-во";
                dgv_VozvrDet.Columns["Name"].HeaderText = "Наименование";
                dgv_VozvrDet.Columns["Note"].HeaderText = "Примечание";
                dgv_VozvrDet.Columns["DataVozvr"].HeaderText = "Дата возвр.";
                dgv_VozvrDet.ReadOnly = false;
                DataGridViewCheckBoxColumn ptichka = new DataGridViewCheckBoxColumn();
                ptichka.Name = "znak";
                dgv_VozvrDet.Columns.Add(ptichka);
                dgv_VozvrDet.Columns["znak"].DisplayIndex = 0;
                foreach (DataGridViewRow row in (dgv_VozvrDet as DataGridView).Rows)
                {
                    (row.Cells["znak"] as DataGridViewCheckBoxCell).Value = true;
                    (row.Cells["znak"] as DataGridViewCheckBoxCell).ReadOnly = false;
                }
                dgv_VozvrDet.Columns["znak"].Width = 20;
            }        
        }


        //настройки для возвратного металлолома
        private void Settings_dgv_VozvrMet()
        {
            if (dgv_Vozvr_Met.RowCount > 0)
            {
                dgv_Vozvr_Met.Columns["ID"].Visible = false;
                dgv_Vozvr_Met.Columns["Quantity"].HeaderText = "Кол-во";
                dgv_Vozvr_Met.Columns["Name"].HeaderText = "Наименование";
                dgv_Vozvr_Met.Columns["Note"].HeaderText = "Примечание";
                dgv_Vozvr_Met.Columns["DataVozvr"].HeaderText = "Дата возвр.";

                dgv_Vozvr_Met.Columns["EdIzm"].HeaderText = "Ед.Изм";
                dgv_Vozvr_Met.Columns["Price"].HeaderText = "Цена";
                dgv_Vozvr_Met.Columns["Sum"].HeaderText = "Сумма";

                dgv_Vozvr_Met.ReadOnly = false;
                DataGridViewCheckBoxColumn ptichka = new DataGridViewCheckBoxColumn();
                ptichka.Name = "znak";
                dgv_Vozvr_Met.Columns.Add(ptichka);
                dgv_Vozvr_Met.Columns["znak"].DisplayIndex = 0;
                foreach (DataGridViewRow row in (dgv_Vozvr_Met as DataGridView).Rows)
                {
                    (row.Cells["znak"] as DataGridViewCheckBoxCell).Value = true;
                    (row.Cells["znak"] as DataGridViewCheckBoxCell).ReadOnly = false;
                }
                dgv_Vozvr_Met.Columns["znak"].Width = 20;
                dgv_Vozvr_Met.Columns["EdIzm"].Width = 40;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // начало проверка дат установки материалов
            int kol_oshibok = 0;
            if (dgv_RepPlaceVedRes.RowCount > 0)
            {
                //изменяем значения оригинала и номера ведомости ресурсов в ReplacedPart
                for (int i = 0; i < dgv_RepPlaceVedRes.RowCount; i++)
                {

                    if (Convert.ToBoolean(dgv_RepPlaceVedRes.Rows[i].Cells["znak"].Value) == true) // проверяем только выбранные  строки
                    {
                        DateTime tekdat = Convert.ToDateTime(dgv_RepPlaceVedRes.Rows[i].Cells["DataReplace"].Value.ToString());
                        if (tekdat >= dtp_date1.Value && tekdat <= dtp_date2.Value)
                        {
                        }
                        else
                        {
                            kol_oshibok = kol_oshibok + 1;
                        }

                    }


                }
            }
            if (kol_oshibok == 0)
            {
                MessageBox.Show("Всё в порядке");
            }
            else
            {
                MessageBox.Show("В " + kol_oshibok.ToString() + "-x строках даты установки материалов ВЫХОДЯТ ЗА ПРЕДЕЛЫ дат формирования ведомости!!!","Ведомость не будет сформирована");
                return;  // прекращается формирование ведомости
            }

            // конец проверка дат установки материалов
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
            cn.Open();
            string canformirovat = "";

            // сюда добавить проверку на 54.4 для 48
            // узнать кто юзер 
           // string username = "Sitaruk_AV";// Environment.UserName;
            //Dostup.Login_user = username;

            //dgvLogin.DataSource = dal.GetInfoDostup();

        /*    Dostup.Codcx = dgvLogin.Rows[0].Cells["codcx"].Value.ToString();
            Dostup.Coduth = dgvLogin.Rows[0].Cells["coduth"].Value.ToString();
            Dostup.Codbrig = dgvLogin.Rows[0].Cells["codbrig"].Value.ToString();
            Dostup.Coddet = dgvLogin.Rows[0].Cells["coddet"].Value.ToString();
            Dostup.Plot = dgvLogin.Rows[0].Cells["plot"].Value.ToString();
            Dostup.Name = dgvLogin.Rows[0].Cells["name"].Value.ToString();
            Dostup.Dostup1 = dgvLogin.Rows[0].Cells["dostup"].Value.ToString();
            Dostup.Dostup_tmc = dgvLogin.Rows[0].Cells["dostup_tmc"].Value.ToString();
            Dostup.Kod_dostup_pr = dgvLogin.Rows[0].Cells["kod_dostup_pr"].Value.ToString();
            Dostup.Ceh_dostup_pr = dgvLogin.Rows[0].Cells["ceh_dostup_pr"].Value.ToString();
            Dostup.Gosti = dgvLogin.Rows[0].Cells["gosti"].Value.ToString();
            Dostup.Dostup_akt = dgvLogin.Rows[0].Cells["dostup_akt"].Value.ToString();*/
            // если 54.4 


            if (Dostup.Codcx == "54")
            {
                // ispolnitel_ceh == 40 && ispolmitel_uch == 8


                //"select * from Vedomost_Resursov where InventoryNamber='" + this.label9.Text.ToString() + "' and Obekt=" + this.label11.Text.ToString() + "  and Ispolnitel_codcx = 40 and Ispolnitel_coduth = 8" 
                string q_check = "select * from Vedomost_Resursov where InventoryNamber='" + this.label9.Text.ToString() + "' and Obekt=" + this.label11.Text.ToString() + "  and Ispolnitel_codcx = 40 and Ispolnitel_coduth = 8";
                SqlCommand cm00 = new SqlCommand(q_check, cn);
                Debug.WriteLine(cm00.CommandText);
                SqlDataReader dr00 = cm00.ExecuteReader();

                if (dr00.HasRows)
                {
                    Debug.WriteLine("1");

                    canformirovat = "yes";
                }
                else
                {
                    //SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label9.Text.ToString() + " and ( PeriodData1 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "' or  PeriodData2 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "')", cn);
                    SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber='" + this.label9.Text.ToString() + "' and Obekt=" + this.label11.Text.ToString() + "  and ( ( '" + dtp_date1.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData2) ) and kod_rem!=8", cn);
                    //kod_rem<>8 не берём в учет услуги с материалами

                    Debug.WriteLine(cm0.CommandText);
                    SqlDataReader dr0 = cm0.ExecuteReader();

                    if (dr0.HasRows)
                    {
                        MessageBox.Show("Інв.№ " + this.label9.Text.ToString() + " за період з " + dtp_date1.Value.ToString("dd.MM.yyyy") + " по " + dtp_date2.Value.ToString("dd.MM.yyyy") + " вже ремонтує інший. Неможливо сформувати вдомість ресурсів.");
                        canformirovat = "no";
                    }
                    else
                    {
                        //MessageBox.Show("can form");
                        canformirovat = "yes";
                    }
                    dr0.Close();
                }
            }
          




            // проверяем есть ли записи по данному инв.№ за выбранный период
            
            //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
            

            




            
            


            if (radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("Оберіть статус ремонта");
                return;
            }


            if (canformirovat == "yes")
            {
            
            
            // Начало Определяем вид ремонта
            DAL dal = new DAL();
            string Shpz = "";
            string RepairID = dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString();
            // MessageBox.Show(RepairID.ToString());
            int jobCode = dal.SelectJobCode(RepairID);
            //MessageBox.Show(jobCode.ToString());
            int kodrem;
            switch (jobCode)
            {
                case 36:
                    kodrem = 5; //Рем.поточ.
                    break;
                case 37:
                    kodrem = 6; // Рем.кап.
                    break;
                case 9:
                    kodrem = 2; // ТО
                    break;
                case 38:
                    kodrem = 8; // услуги с материалами
                    break;
                case 39:
                    kodrem = 9; // услуги без материалов
                    break;
                default:
                    kodrem = 2; // ТО
                    break;
            }
            //MessageBox.Show(kodrem.ToString());
            // Конец Определяем вид ремонта

            // запоминаем срок заменЫ  begin
            int srok_zameni = 0;
            if (radioButton1.Checked == true)
            {
                srok_zameni = 1;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    srok_zameni = 2;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        srok_zameni = 3;

                    }
                    else
                    {
                        srok_zameni = 0;

                    }

                }
            }
            // запоминаем срок заменЫ end


            bool zaversh = false;
            if (radioButton4.Checked == true) zaversh = true;
            else zaversh = false;

            if (dal.CreateNewVedomodtResursov(dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString(),
                dtp_date1.Value.ToString("yyyyMMdd"), dtp_date2.Value.ToString("yyyyMMdd"), kodrem, srok_zameni, zaversh) == true)

            //if (dal.CreateNewVedomodtResursov(dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString(),
            //     dtp_date1.Value.ToString("yyyyMMdd"), dtp_date2.Value.ToString("yyyyMMdd"),
            //     Convert.ToInt32(cbx_sprrem.SelectedValue)) == true)
            {

             //   MessageBox.Show(dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString());
             //   MessageBox.Show("Ведомость ресурсов создана");
              //  txt_numberVed.Text = dal.ReturnVedomostNumber().ToString();
               // int num_ved = dal.ReturnVedomostNumber();
                a = 1;
            }
            else
            {
                MessageBox.Show("Ошибка создания ведомости ресурсов");
                //txt_numberVed.Text =
                //    (dal.CreateNewVedomodtResursovstring(
                //        dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString(),
                //        dtp_date1.Value.ToString("yyyyMMdd"), dtp_date2.Value.ToString("yyyyMMdd")));
            }

            if (dgv_RepPlaceVedRes.RowCount > 0)
            {
                //изменяем значения оригинала и номера ведомости ресурсов в ReplacedPart
                for (int i = 0; i < dgv_RepPlaceVedRes.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgv_RepPlaceVedRes.Rows[i].Cells["znak"].Value) == true)
                    {
                        if (dal.UpdateRepPlaceVedRes(dgv_RepPlaceVedRes.Rows[i].Cells["ReplacedId"].Value.ToString(), dal.ReturnVedomostNumber().ToString()) == true)
                        {
                            b = 1;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления ведомости ресурсов. Запчасти");
                        }
                    }
                }
            }
            //изменение значения оригинала в возвратном металлоломе

            if (dgv_Vozvr_Met.RowCount > 0)
            {
                for (int i = 0; i < dgv_Vozvr_Met.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgv_Vozvr_Met.Rows[i].Cells["znak"].Value) == true)
                    {
                        if (dal.UpdateRepPlaceVedVozvrMet(dgv_Vozvr_Met.Rows[i].Cells["Id"].Value.ToString(), dal.ReturnVedomostNumber().ToString()) == true)
                        {
                            c = 1;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления ведомости ресурсов. Возвратный металлолом");
                        }
                    }
                }


            }

            //изменеие значения оригинала в возвратных деталях

            if (dgv_VozvrDet.RowCount > 0)
            {
                for (int i = 0; i < dgv_VozvrDet.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgv_VozvrDet.Rows[i].Cells["znak"].Value) == true)
                    {
                        if (dal.UpdateRepPlaceVedVozvrDet(dgv_VozvrDet.Rows[i].Cells["Id"].Value.ToString(), dal.ReturnVedomostNumber().ToString()) == true)
                        {
                            d = 1;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления ведомости ресурсов. Возвратные детали");
                        }
                    }
                }


            }




            this.DialogResult = DialogResult.OK;
      




            //проходим по трем гридам, если птички установлены напртив них, то изменяем значения оригинала на 1 и обновляем значения номера ведомости ресурсов на ИД ведомости ре

        }

        }

        private void SettingsInvNumbed()
        {


        }




        private void myfrmVedomostResursovForAllOS_Load_1(object sender, EventArgs e)
        {
           // MessageBox.Show(InfoRepair.InventotyNomber);
            dgv_RepPlaceVedRes.DataSource = dal.GetRepPlaceForOSVedRes();
            dgv_Vozvr_Met.DataSource = dal.GetAllVozvrMetforOS();
            dgv_VozvrDet.DataSource = dal.GetAllVozvrDetforOS();

            DataGridViewCheckBoxColumn ptichka = new DataGridViewCheckBoxColumn();
            ptichka.Name = "znak";
            //  ptichka.HeaderText = "Знак";
            cbx_sprrem.DataSource = dal.GetAllsprrem();
            cbx_sprrem.DisplayMember = "name_rem";
            cbx_sprrem.ValueMember = "kod_rem";



            if (dgv_RepPlaceVedRes.RowCount > 0)
            {
                dgv_RepPlaceVedRes.Columns.Add(ptichka);
                dgv_RepPlaceVedRes.Columns["znak"].DisplayIndex = 0;
                dgv_RepPlaceVedRes.ReadOnly = false;
                dgv_RepPlaceVedRes.Columns["znak"].ReadOnly = false;
                dgv_RepPlaceVedRes.Columns["znak"].HeaderText = "Знак";
            }

            //if (dgv_Vozvr_Met.RowCount > 0)
            //{
            //    //dgv_Vozvr_Met.Columns.Add(ptichka);
            // //   dgv_Vozvr_Met.Columns["znak"].DisplayIndex = 0;
            //    dgv_Vozvr_Met.ReadOnly = false;
            //    dgv_Vozvr_Met.Columns["znak"].ReadOnly = false;
            //    dgv_Vozvr_Met.Columns["znak"].HeaderText = "Знак";
            //}

            //if (dgv_VozvrDet.RowCount > 0)
            //{
            //   // dgv_VozvrDet.Columns.Add(ptichka);
            //    dgv_VozvrDet.Columns["znak"].DisplayIndex = 0;
            //    dgv_VozvrDet.ReadOnly = false;
            //    dgv_VozvrDet.Columns["znak"].ReadOnly = false;
            //    dgv_VozvrDet.Columns["znak"].HeaderText = "Знак";
            //}



            SettingsMyfrmVedomostResursovForAllRepairs();

            Settings_dgv_VozvrDet();
            Settings_dgv_VozvrMet();



          
        }

      
        private void dgv_RepPlaceVedRes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {
                if (Convert.ToBoolean(dgv_RepPlaceVedRes[e.ColumnIndex, e.RowIndex].Value))
                {
                    dgv_RepPlaceVedRes[e.ColumnIndex, e.RowIndex].Value = false;

                }
                else
                {
                    dgv_RepPlaceVedRes[e.ColumnIndex, e.RowIndex].Value = true;
                }
            }
            radioButton3.Checked=true;
            calculate();
        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                btn_AddNewVedRes.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                btn_AddNewVedRes.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int srok_zameni = 0;
            if (radioButton1.Checked == true)
            {
                srok_zameni = 1;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    srok_zameni = 2;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                       srok_zameni = 3;

                    }
                    else
                    {
                       srok_zameni = 0;

                    }

                }
            }
            MessageBox.Show(srok_zameni.ToString());
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // запоминаем срок заменЫ  begin
            int srok_zameni = 0;
            if (radioButton1.Checked == true)
            {
                srok_zameni = 1;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    srok_zameni = 2;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        srok_zameni = 3;

                    }
                    else
                    {
                        srok_zameni = 0;

                    }

                }
            }
            // запоминаем срок заменЫ end
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // проверяем есть ли записи по данному инв.№ за выбранный период
            string canformirovat = "";
            //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
            

            cn.Open();
            //SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label9.Text.ToString() + " and ( PeriodData1 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "' or  PeriodData2 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "')", cn);
            SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label9.Text.ToString() + " and ( ( '" + dtp_date1.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData2) )", cn);

            Debug.WriteLine(cm0.CommandText);
            SqlDataReader dr0 = cm0.ExecuteReader();
            if (dr0.HasRows)
            {
                MessageBox.Show("Інв.№ " + this.label9.Text.ToString() + " за період з " + dtp_date1.Value.ToString("dd.MM.yyyy") + " по " + dtp_date1.Value.ToString("dd.MM.yyyy") + " вже ремонтує інший. Неможливо сформувати вфдомість ресурсів.");
                canformirovat = "no";
            }
            else
            {
                MessageBox.Show("can form");
                canformirovat = "yes";
            }
            dr0.Close();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            string canformirovat = "no";
            //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
            

            cn.Open();
            //SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label8.Text.ToString() + " and ( PeriodData1 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "' or  PeriodData2 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "')", cn);
            SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label9.Text.ToString() + " and ( ( '" + dtp_date1.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData2) )", cn);
            Debug.WriteLine(cm0.CommandText);

            SqlDataReader dr0 = cm0.ExecuteReader();
            if (dr0.HasRows)
            {
                MessageBox.Show("Інв.№ " + this.label8.Text.ToString() + " за період з " + dtp_date1.Value.ToString("dd.MM.yyyy") + " по " + dtp_date1.Value.ToString("dd.MM.yyyy") + " вже ремонтує інший. Неможливо сформувати вфдомість ресурсів.");
                canformirovat = "no";
            }
            else
            {
                //MessageBox.Show("can form");
                canformirovat = "yes";
            }
            dr0.Close();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            string w=" select * from Vedomost_Resursov where InventoryNamber=" + this.label9.Text.ToString() + " and ( ( '" + dtp_date1.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData2) )";
            Debug.WriteLine(w.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int kol_oshibok = 0;
            if (dgv_RepPlaceVedRes.RowCount > 0)
            {
                //изменяем значения оригинала и номера ведомости ресурсов в ReplacedPart
                for (int i = 0; i < dgv_RepPlaceVedRes.RowCount; i++)
                {
                    DateTime tekdat = Convert.ToDateTime(dgv_RepPlaceVedRes.Rows[i].Cells["DataReplace"].Value.ToString());
                    if (tekdat >= dtp_date1.Value && tekdat <= dtp_date2.Value)
                    {
                    }
                    else
                    {
                        kol_oshibok = kol_oshibok + 1;
                    }
                }
            }
            if (kol_oshibok == 0)
            {
                MessageBox.Show("Всё в порядке");
            }
            else
            {
                MessageBox.Show("В " + kol_oshibok.ToString() + "-x строках даты установки материалов ВЫХОДЯТ ЗА ПРЕДЕЛЫ дат формирования ведомости!!!"); 
            }
        }

        //private void dgv_VozvrDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
