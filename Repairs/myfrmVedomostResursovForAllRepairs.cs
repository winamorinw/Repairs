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
    public partial class myfrmVedomostResursovForAllRepairs : Form
    {
        DAL dal = new DAL();
        int a = 0;//переменные для удачного показателя выполнения добавления в вед рес деталей металлолома, и возвр дет и самой ведомости ресурсов
        int b = 0;
        int c = 0;
        int d = 0;
        double bbalcena = 0;

        private string R_Division;
        public myfrmVedomostResursovForAllRepairs(string RDivision, string InvNum, string Obekt , string datn , string datk)
        {
            InitializeComponent();
            
            string InvNumm = InvNum;
            string Obektt = Obekt;
            this.label8.Text = InvNumm.ToString();
            this.label9.Text = Obektt.ToString();

            //string bbal_cena = dal.SelectB_Bal_cena(InvNumm, Obektt);
            //bbalcena = Convert.ToDouble(bbal_cena);            
            //bbalcena = Convert.ToDouble(bbal_cena.Replace(".",","));
            //this.label10.Text = bbalcena.ToString();

            string bbal_cena1 = dal.SelectB_Bal_cena(InvNumm, Obektt);
            if (bbal_cena1.Length == 0)
                bbal_cena1 = "0";
            
            string bbal_cena2 = (bbal_cena1.Replace(".", ","));
            //bbalcena = Convert.ToDouble(bbal_cena.Replace(".",","));
            bbalcena = Convert.ToDouble(bbal_cena2);
            //bbalcena = Convert.ToInt32(bbal_cena2);
            this.label10.Text = bbalcena.ToString();

            

            SettingsMyfrmVedomostResursovForAllRepairs();
            string R_Division = RDivision;
            this.label4.Text = R_Division.ToString();
            //this.label5.Text = DatBegRem.ToString();
            //this.label6.Text = DatEndRem.ToString();
            dtp_date1.Value = new DateTime(Convert.ToInt32((datn.Substring(0, 4))), Convert.ToInt32((datn.Substring(4, 2))), Convert.ToInt32((datn.Substring(6, 2))));
            dtp_date2.Value = new DateTime(Convert.ToInt32((datk.Substring(0, 4))), Convert.ToInt32((datk.Substring(4, 2))), Convert.ToInt32((datk.Substring(6, 2))));


          
        }

        private void myfrmVedomostResursovForAllRepairs_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("--66666-");
            Debug.WriteLine(dgv_RepPlaceVedRes.Rows.Count);
            dgv_RepPlaceVedRes.DataSource = dal.GetRepPlaceForRepairVedRes();
            Debug.WriteLine(dgv_RepPlaceVedRes.Rows.Count);
            Debug.WriteLine("--66666-");
            dgv_Vozvr_Met.DataSource = dal.GetAllVozvrMet();
            dgv_VozvrDet.DataSource = dal.GetAllVozvrDet();

            DataGridViewCheckBoxColumn ptichka = new DataGridViewCheckBoxColumn();
            ptichka.Name = "znak";
            //  ptichka.HeaderText = "Знак";
            //sprravochnik
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





        private void calculate()
        {

            //**** ТМЦ (за текущий месяц) на сумму
            string invnum = this.label8.Text.ToString();
            string objekt = this.label9.Text.ToString();
            string year_date2 = dtp_date2.Value.Year.ToString();
            string month_date2 = dtp_date2.Value.Month.ToString();
            double tmc_sum_tekmes = dal.ReturnSumReplaceParts(invnum, objekt, year_date2, month_date2);
            label16.Text = Convert.ToString(Math.Round(Convert.ToSingle(Convert.ToString(tmc_sum_tekmes)), 2));
            //***

            
            double sumall = 0;
            Debug.WriteLine("jkjkljhklhj");
            for (int i = 0; i < dgv_RepPlaceVedRes.Columns.Count; i++)
            {
                Debug.WriteLine(i + " " + dgv_RepPlaceVedRes.Columns[i].Name + " " + dgv_RepPlaceVedRes[i, 1].Value);
            
            }
            Debug.WriteLine(dgv_RepPlaceVedRes.Columns.Count);            
          
            Debug.WriteLine("4444444444");            

            for (int i = 0; i < dgv_RepPlaceVedRes.Rows.Count; i++)
            {

                if (Convert.ToBoolean(dgv_RepPlaceVedRes[14, i].Value))
                {
                    double o = Convert.ToDouble(dgv_RepPlaceVedRes[4, i].Value) * Convert.ToDouble(dgv_RepPlaceVedRes[12, i].Value);
                    sumall += o;
                }
            }
            label7.Text = Convert.ToString(sumall);
            
                //label7.Text = label7.Text.Replace(",00", "");

                //label10.Text = label10.Text.Replace(",00", "");

            btn_AddNewVedRes.Enabled = false;

            //string lab10 = this.label10.Text.Replace('.', ',');

            if (bbalcena == 0 && sumall + tmc_sum_tekmes > 50000 || bbalcena > 0 && sumall + tmc_sum_tekmes > 300000)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;

            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;

                btn_AddNewVedRes.Enabled = true;
            }
            label7.Text = Convert.ToString(Math.Round(Convert.ToSingle(Convert.ToString(sumall)), 2));
            if (!label7.Text.Contains(','))
            {
                label7.Text += ",00";
            }
            //if (!label10.Text.Contains('.'))
            //{
            //    label10.Text += ",00";
            //}

            label18.Text = Convert.ToString(Math.Round(Convert.ToSingle(Convert.ToString(sumall + tmc_sum_tekmes)), 2));
        }


        private void calculate2()
        {
            string invnum = this.label8.Text.ToString();
            string objekt = this.label9.Text.ToString();
            string year_date2 = dtp_date2.Value.Year.ToString();
            string month_date2 = dtp_date2.Value.Month.ToString();
            double  ss =dal.ReturnSumReplaceParts(invnum, objekt,year_date2, month_date2);
            label16.Text = Convert.ToString(Math.Round(Convert.ToSingle(Convert.ToString(ss)), 2));
           
           
        }



        //настройки для списуемых запчастей
        private void SettingsMyfrmVedomostResursovForAllRepairs() {

            Debug.WriteLine("**********");
            Debug.WriteLine(dgv_RepPlaceVedRes.Rows.Count);
            Debug.WriteLine(dgv_RepPlaceVedRes.RowCount);
            Debug.WriteLine("**********");

            if (dgv_RepPlaceVedRes.RowCount > 0)
            {
                dgv_RepPlaceVedRes.Columns["ReplacedID"].Visible = false;
                dgv_RepPlaceVedRes.Columns["JobID"].Visible = true;
                dgv_RepPlaceVedRes.Columns["JobID"].Visible = false;
                //dgv_RepPlaceVedRes.Columns["RepairID"].Visible = false;
                dgv_RepPlaceVedRes.Columns["PartID"].Visible = false;
                dgv_RepPlaceVedRes.Columns["ReplacedID1"].Visible = false;
                dgv_RepPlaceVedRes.Columns["DateInRep"].Visible = false;
                dgv_RepPlaceVedRes.Columns["Original"].Visible = false;

                dgv_RepPlaceVedRes.Columns["Quantity"].HeaderText = "Кол-во";
                dgv_RepPlaceVedRes.Columns["Name"].HeaderText = "Наименование";
                dgv_RepPlaceVedRes.Columns["Mera"].HeaderText = "Ед.Изм.";
                dgv_RepPlaceVedRes.Columns["EDNOME"].HeaderText = "Инв.№";
                dgv_RepPlaceVedRes.Columns["DataReplace"].HeaderText = "Установка";
                dgv_RepPlaceVedRes.Columns["Prace"].HeaderText = "Цена";  
                
                dgv_RepPlaceVedRes.Columns["EDNOME"].DisplayIndex = 1;
                dgv_RepPlaceVedRes.Columns["Name"].DisplayIndex = 2;
                dgv_RepPlaceVedRes.Columns["Quantity"].DisplayIndex = 3;
                dgv_RepPlaceVedRes.Columns["Mera"].DisplayIndex = 4;
                dgv_RepPlaceVedRes.Columns["DataReplace"].DisplayIndex = 5;

                dgv_RepPlaceVedRes.Columns["znak"].Width = 20;
                dgv_RepPlaceVedRes.Columns["EDNOME"].Width = 60;
                dgv_RepPlaceVedRes.Columns["Name"].Width = 200;
                dgv_RepPlaceVedRes.Columns["Quantity"].Width = 90;
                dgv_RepPlaceVedRes.Columns["Mera"].Width = 40;
                dgv_RepPlaceVedRes.Columns["DataReplace"].Width = 90;

                foreach (DataGridViewRow row in (dgv_RepPlaceVedRes as DataGridView).Rows) {
                   (row.Cells["znak"] as DataGridViewCheckBoxCell).Value = true;
                }

                calculate();
                calculate2();

            }

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
                MessageBox.Show("В " + kol_oshibok.ToString() + "-x строках даты установки материалов ВЫХОДЯТ ЗА ПРЕДЕЛЫ дат формирования ведомости!!!", "Ведомость не будет сформирована");
                return;  // прекращается формирование ведомости
            }

            // конец проверка дат установки материалов


            
            
            
            // проверяем есть ли записи по данному инв.№ за выбранный период
            string canformirovat = "no";
            //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
            cn.Open();
            //SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label8.Text.ToString() + " and ( PeriodData1 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "' or  PeriodData2 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "')", cn);
            //string invnn = this.label8.Text.ToString();
            //Debug.WriteLine(invnn.ToString());
            SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label8.Text.ToString() + " and ( ( '" + dtp_date1.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData2) ) and kod_rem!=8", cn);
             //kod_rem<>8 не берём в учет услуги с материалами

            Debug.WriteLine(cm0.CommandText);

            SqlDataReader dr0 = cm0.ExecuteReader();
            if (dr0.HasRows)
            {
                MessageBox.Show("Інв.№ " + this.label8.Text.ToString() + " за період з " + dtp_date1.Value.ToString("dd.MM.yyyy") + " по " + dtp_date2.Value.ToString("dd.MM.yyyy") + " вже ремонтує інший. Неможливо сформувати вфдомість ресурсів.");
                canformirovat = "no";
            }
            else
            {
                //MessageBox.Show("can form");
                canformirovat = "yes";
            }
            dr0.Close();



            if (radioButton4.Checked == false  && radioButton5.Checked == false)
            {
                MessageBox.Show("Оберіть статус ремонта");
                return;
            }


            if (canformirovat == "yes")
            {

            
            // Начало Определяем вид ремонта
            DAL dal = new DAL();
            string Rdivision = this.label4.Text.ToString();
            string DatBegRem = this.label5.Text.ToString();


            string DatEndRem = this.label6.Text.ToString();
            string Shpz;
            string RepairID = dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString();
            // MessageBox.Show(RepairID.ToString());
            int jobCode = dal.SelectJobCode(RepairID);
            //MessageBox.Show(jobCode.ToString());
            int kodrem;
            switch (jobCode)
            {
                case 36:
                    kodrem = 5; //Рем.поточ.
                    Shpz = "910100";
                    break;
                case 37:
                    kodrem = 6; // Рем.кап.
                    Shpz = "910200";
                    break;
                case 38:
                    kodrem = 8; // услуги с материалами
                    break;
                case 39:
                    kodrem = 9; // услуги без материалов
                    break;
                default:
                    kodrem = 2; // ТО
                    switch(Rdivision)
                        {
                        case "54":
                            Shpz = "232000";
                            break;
                        case "1":
                            Shpz = "2310401";
                            break;
                        case "5":
                            Shpz = "2310405";
                            break;
                        default :
                            Shpz = "";
                            break;
                    }
                  break;
            }
            //MessageBox.Show(kodrem.ToString());
            // Конец Определяем вид ремонта


            //MessageBox.Show(Rdivision);

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


            bool zaversh= false;
            if (radioButton4.Checked == true) zaversh= true;
            else zaversh = false;

            if (dal.CreateNewVedomodtResursov(dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString(),
                 dtp_date1.Value.ToString("yyyyMMdd"), dtp_date2.Value.ToString("yyyyMMdd"), kodrem, srok_zameni, zaversh) == true)

            
            //if (dal.CreateNewVedomodtResursov(dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString(),
            //     dtp_date1.Value.ToString("yyyyMMdd"), dtp_date2.Value.ToString("yyyyMMdd"), 
            //     Convert.ToInt32(cbx_sprrem.SelectedValue)) == true)
            {
                
               // MessageBox.Show("Ведомость ресурсов создана");
              //  txt_numberVed.Text = dal.ReturnVedomostNumber().ToString();
                

            }
            else {
                MessageBox.Show("Ошибка создания ведомости ресурсов");
                //txt_numberVed.Text =
                //    (dal.CreateNewVedomodtResursovstring(
                //        dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString(),
                //        dtp_date1.Value.ToString("yyyyMMdd"), dtp_date2.Value.ToString("yyyyMMdd")));
            }

            if (dgv_RepPlaceVedRes.RowCount > 0){
                //изменяем значения оригинала и номера ведомости ресурсов в ReplacedPart
                for (int i = 0; i < dgv_RepPlaceVedRes.RowCount; i++) { 
                if (Convert.ToBoolean(dgv_RepPlaceVedRes.Rows[i].Cells["znak"].Value) == true){
                    if (dal.UpdateRepPlaceVedRes(dgv_RepPlaceVedRes.Rows[i].Cells["ReplacedId"].Value.ToString(), dal.ReturnVedomostNumber().ToString()) == true)
                    {

                    }
                    else {
                        MessageBox.Show("Ошибка обновления ведомости ресурсов. Запчасти");
                    }              
                }       
                }
            }
                //изменение значения оригинала в возвратном металлоломе

                if (dgv_Vozvr_Met.RowCount > 0) {
                    for (int i = 0; i < dgv_Vozvr_Met.RowCount; i++)
                    {
                        if (Convert.ToBoolean(dgv_Vozvr_Met.Rows[i].Cells["znak"].Value) == true)
                        {
                            if (dal.UpdateRepPlaceVedVozvrMet(dgv_Vozvr_Met.Rows[i].Cells["Id"].Value.ToString(), dal.ReturnVedomostNumber().ToString()) == true)
                            {

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

        private void dgv_VozvrDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbx_sprrem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // DAL dal = new DAL();
           // string RepairID = dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString();
           //// MessageBox.Show(RepairID.ToString());
           // int jobCode = dal.SelectJobCode(RepairID);
           // //MessageBox.Show(jobCode.ToString());
           // int kodrem;
           // switch (jobCode)
           // {
           //     case 36:
           //         kodrem = 5; //Рем.поточ.
           //         break;
           //     case 37:
           //         kodrem = 6; // Рем.кап.
           //         break;
           //     default:
           //         kodrem = 2; // ТО
           //         break;
           // }

           // MessageBox.Show(kodrem.ToString());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            string Rdivision = this.label4.Text.ToString();
            string Shpz;
            string RepairID = dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString();
            // MessageBox.Show(RepairID.ToString());
            int jobCode = dal.SelectJobCode(RepairID);
            //MessageBox.Show(jobCode.ToString());
            int kodrem;
            switch (jobCode)
            {
                case 36:
                    kodrem = 5; //Рем.поточ.
                    Shpz = "910100";
                    break;
                case 37:
                    kodrem = 6; // Рем.кап.
                    Shpz = "910200";
                    break;
                default:
                    kodrem = 2; // ТО
                    switch (Rdivision)
                    {
                        case "54":
                            Shpz = "232000";
                            break;
                        case "1":
                            Shpz = "2310401";
                            break;
                        case "5":
                            Shpz = "2310405";
                            break;
                        default:
                            Shpz = "";
                            break;
                    }
                    break;
            }
            MessageBox.Show(Shpz.ToString());
        }

        private void dgv_RepPlaceVedRes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 14)
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
            radioButton3.Checked = true;
            calculate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                btn_AddNewVedRes.Enabled = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                btn_AddNewVedRes.Enabled = true;
            }

        }

        private void button2_Click_2(object sender, EventArgs e)
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
            MessageBox.Show(srok_zameni.ToString());
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            
            string canform="";
            //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
            cn.Open();
            SqlCommand cm0 = new SqlCommand(" select * from Vedomost_Resursov where InventoryNamber=" + this.label8.Text.ToString() + " and ( PeriodData1 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "' or  PeriodData2 between '" + dtp_date1.Value.ToString("yyyyMMdd") + "' and '" + dtp_date2.Value.ToString("yyyyMMdd") + "')",cn);
            Debug.WriteLine(cm0.CommandText);
            SqlDataReader dr0 = cm0.ExecuteReader();
            if (dr0.HasRows)
            {
                MessageBox.Show("Інв.№ " + this.label8.Text.ToString() + " за період з " + dtp_date1.Value.ToString("dd.MM.yyyy") + " по " + dtp_date1.Value.ToString("dd.MM.yyyy") + " вже ремонтує інший. Неможливо сформувати вфдомість ресурсів.");
                canform = "no";
            }
            else
            {
                MessageBox.Show("can form");
                canform = "yes";
            }
              dr0.Close();

              if (canform == "yes")
              { 
              
              
              }

        }

        private void button2_Click_4(object sender, EventArgs e)
        {
            string nd = " select * from Vedomost_Resursov where InventoryNamber=" + this.label8.Text.ToString() + " and ( ( '" + dtp_date1.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' <= PeriodData2) OR ('" + dtp_date1.Value.ToString("yyyyMMdd") + "' <= PeriodData1 AND '" + dtp_date2.Value.ToString("yyyyMMdd") + "' >= PeriodData2) )";
            Debug.WriteLine(nd.ToString());
        }

        private void button2_Click_5(object sender, EventArgs e)
        {
            string RepairID = dgv_RepPlaceVedRes.CurrentRow.Cells["RepairID"].Value.ToString();
            int jobCod = dal.SelectJobCode(RepairID);
            //MessageBox.Show(jobCode.ToString());
            int kodremm=0;
            switch (jobCod)
            {
                case 36:
                    kodremm = 5; //Рем.поточ.
                    break;
                case 37:
                    kodremm= 6; // Рем.кап.
                    break;
                case 38:
                    kodremm = 8; // услуги с материалами
                    break;
                case 39:
                    kodremm = 9; // услуги без материалов
                    break;
            }

            if (kodremm == 8)
            {
                MessageBox.Show("Не проверяем период");
            }
            else
            {
                MessageBox.Show("? Период");
            }
        }

        private void button2_Click_6(object sender, EventArgs e)
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

        
       
    }
}
