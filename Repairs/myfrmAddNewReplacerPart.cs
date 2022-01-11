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
    public partial class myfrmAddNewReplacerPart : Form
    {
        DAL dal = new DAL();
        DAL_DBF dal_dbf = new DAL_DBF();
        string DateIn;
        string DateOut;

        SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True"); 

        public void SettingsGetAllTMC()
        {
            dgv_ReplacedPart.Columns["CODCX"].Visible = false;
            dgv_ReplacedPart.Columns["CODUTH"].Visible = false;
            dgv_ReplacedPart.Columns["CODBRIG"].Visible = false;
            dgv_ReplacedPart.Columns["CODDET"].Visible = false;
            dgv_ReplacedPart.Columns["SHPZ"].Visible = false;
            dgv_ReplacedPart.Columns["SHPZ1"].Visible = false;
           // dgv_ReplacedPart.Columns["DATSHOP"].Visible = false;
            dgv_ReplacedPart.Columns["sum_KOL"].Visible = true ; //888


            dgv_ReplacedPart.Columns["norma_new"].Visible = false;
            dgv_ReplacedPart.Columns["texsod"].Visible = false;

            dgv_ReplacedPart.Columns["EDNOME"].HeaderText = "Номер";
            dgv_ReplacedPart.Columns["DATA"].HeaderText = "Дата надходження";
            dgv_ReplacedPart.Columns["NAME"].HeaderText = "Назва";
            dgv_ReplacedPart.Columns["MERA"].HeaderText = "Од. вим.";
            dgv_ReplacedPart.Columns["PRACE"].HeaderText = "Ціна";
            dgv_ReplacedPart.Columns["sum_KOL"].HeaderText = "Залишок поточ."; //888
            dgv_ReplacedPart.Columns["zavnom"].HeaderText = "Завод.№"; //888

            dgv_ReplacedPart.Columns["EDNOME"].DisplayIndex = 0;
            dgv_ReplacedPart.Columns["NAME"].DisplayIndex = 1;
            dgv_ReplacedPart.Columns["DATA"].DisplayIndex = 2;
            dgv_ReplacedPart.Columns["PRACE"].DisplayIndex = 5;
            dgv_ReplacedPart.Columns["sum_KOL"].DisplayIndex = 7;
            dgv_ReplacedPart.Columns["MERA"].DisplayIndex = 4;
            dgv_ReplacedPart.Columns["User_Kol"].DisplayIndex = 6;
            dgv_ReplacedPart.Columns["Finish_Kol"].DisplayIndex = 3;

            dgv_ReplacedPart.Columns["Name"].Width = 280;
            dgv_ReplacedPart.Columns["EDNOME"].Width = 70;
            dgv_ReplacedPart.Columns["mera"].Width = 50;
            dgv_ReplacedPart.Columns["tehno"].Width = 42;
            dgv_ReplacedPart.Columns["norma"].Width = 42;
            dgv_ReplacedPart.Columns["User_Kol"].Width = 75;
            dgv_ReplacedPart.Columns["Finish_Kol"].Width = 90;

            dgv_ReplacedPart.Columns["sum_KOL"].DefaultCellStyle.Format = "#0.000000";
            dgv_ReplacedPart.Columns["Finish_Kol"].DefaultCellStyle.Format = "#0.000000";

            dgv_ReplacedPart.Columns["sum_KOL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_ReplacedPart.Columns["Finish_Kol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            //dgv_ReplacedPart.AutoResizeColumns();
            //dgv_ReplacedPart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            //синими делаем ведомости ресурсов оригинала
            //for (int i = 0; i < dgv_ReplacedPart.RowCount; i++)
            //{
            //    if (dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Value.ToString() == "0")
            //    {
            //        //for (int j = 0; j < dgv_ReplacedPart.ColumnCount; j++)
            //        //{
            //            dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Style.BackColor = Color.Aqua;
            //            //***

            //            //**
            //        //}
            //    }
            //}

        }

        public void AlterDGVReplacedPart()
        {

            dgv_ReplacedPart.ReadOnly = false;
            try
            {
                for (int i = 0; i < dgv_ReplacedPart.RowCount; i++)
                {

                    DateTime date = new DateTime();
                    dgv_ReplacedPart.Rows[i].Cells["sum_KOL"].ValueType = typeof(String);

                    ArrayList rrr = new ArrayList();
                    date = Convert.ToDateTime(dgv_ReplacedPart.Rows[i].Cells["DATA"].Value);
                    double d = Convert.ToDouble(dgv_ReplacedPart.Rows[i].Cells["sum_KOL"].Value.ToString());
                    Double xxx = new Double();
                    dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].ReadOnly = false;
                    dgv_ReplacedPart.Rows[i].Cells["norma"].ReadOnly = false;
                    dgv_ReplacedPart.Rows[i].Cells["tehno"].ReadOnly = false;
                    xxx = d;

                    if (dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() == "130574" || dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() == "130574")
                    { 
                    }
                     //was  dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Value = Math.Round((Convert.ToDouble(dgv_ReplacedPart.Rows[i].Cells["sum_KOL"].Value) -
                     //   dal.ReturnDopZnach(dgv_ReplacedPart.Rows[i].Cells["prace"].Value.ToString().Replace(",", "."), date.ToString("yyyyMMdd"),
                     //   dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString(),
                     //   RepaircoddetName.Codcx, RepaircoddetName.Coduth, RepaircoddetName.Codbrig, RepaircoddetName.Coddet, dgv_ReplacedPart.Rows[i].Cells["shpz"].Value.ToString())), 6);



                    

                    dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Value = Math.Round((Convert.ToDouble(dgv_ReplacedPart.Rows[i].Cells["sum_KOL"].Value) -
                        dal.ReturnDopZnach(dgv_ReplacedPart.Rows[i].Cells["prace"].Value.ToString().Replace(",", "."), date.ToString("yyyyMMdd"),
                        dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString(),
                        RepaircoddetName.Codcx, RepaircoddetName.Coduth, RepaircoddetName.Codbrig, RepaircoddetName.Coddet, dgv_ReplacedPart.Rows[i].Cells["shpz"].Value.ToString(), dgv_ReplacedPart.Rows[i].Cells["zavnom"].Value.ToString())), 6);


                            

                    //MessageBox.Show(dal.ReturnDopZnach(dgv_ReplacedPart.Rows[i].Cells["prace"].Value.ToString().Replace(",", "."), date.ToString("yyyyMMdd"),
                    //    dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString(),
                    //    RepaircoddetName.Codcx, RepaircoddetName.Coduth, RepaircoddetName.Codbrig, RepaircoddetName.Coddet).ToString());
                    //устанавливаем значения нормы
                    if (dgv_ReplacedPart.Rows[i].Cells["norma_new"].Value.ToString().Trim() == "1" || dgv_ReplacedPart.Rows[i].Cells["norma_new"].Value.ToString().Trim() == "2")
                    {
                        dgv_ReplacedPart.Rows[i].Cells["norma"].Value = dgv_ReplacedPart.Rows[i].Cells["norma_new"].Value;
                    }
                    else
                    {
                        dgv_ReplacedPart.Rows[i].Cells["norma"].Value = "";
                    }

                    //устанавливаем значения технологии
                    if (dgv_ReplacedPart.Rows[i].Cells["texsod"].Value.ToString().Trim() == "1" || dgv_ReplacedPart.Rows[i].Cells["texsod"].Value.ToString().Trim() == "2")
                    {
                        dgv_ReplacedPart.Rows[i].Cells["tehno"].Value = dgv_ReplacedPart.Rows[i].Cells["texsod"].Value;
                    }
                    else
                    {
                        dgv_ReplacedPart.Rows[i].Cells["tehno"].Value = "";
                    }





                    //dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Value = Math.Round((Convert.ToDouble(dgv_ReplacedPart.Rows[i].Cells["sum_KOL"].Value) -
                    //    dal.ReturnDopZnach(dgv_ReplacedPart.Rows[i].Cells["prace"].Value.ToString().Replace(",", "."), date.ToString("yyyyMMdd"),
                    //    dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString(),
                    //    RepaircoddetName.Codcx, RepaircoddetName.Coduth, RepaircoddetName.Codbrig, RepaircoddetName.Coddet, dgv_ReplacedPart.Rows[i].Cells["shpz"].Value.ToString(), dgv_ReplacedPart.Rows[i].Cells["tehno"].Value.ToString(), dgv_ReplacedPart.Rows[i].Cells["norma"].Value.ToString())), 6);




                }
            }
            catch
            {
                MessageBox.Show("Вот помилка");
            }

        }

        public myfrmAddNewReplacerPart(String JobID, string DateIn_in, string DateOut_out)
        {
           DateIn=DateIn_in;
           DateOut=DateOut_out;

            InitializeComponent();
            ReplacedPart.JobID = JobID;
            if ((InfoRepair.NumberDivis == "9966") && (InfoRepair.NAMEDET.Trim().Length == 0))
            {
                btn_update.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(InfoRepair.RepairID + "   " + ReplacedPart.JobID);
        }

        //Нажатие кнопки сохранить
        private void button2_Click(object sender, EventArgs e)
        {
            int kol_zam_zapt = 0;
            //// Будем проверяем рабочий месяц по цеху
            string c_ceh = dgv_ReplacedPart.CurrentRow.Cells["CODCX"].Value.ToString();
            cn.Open();
            SqlCommand cm1 = new SqlCommand(" SELECT god FROM [Repairs].[dbo].[Status_mes_ceh] where StoreId='" +c_ceh+ "'", cn);
            object rab_god = cm1.ExecuteScalar();
            

            SqlCommand cm2 = new SqlCommand(" SELECT mes FROM [Repairs].[dbo].[Status_mes_ceh] where StoreId='" + c_ceh + "'", cn);
            object rab_mes = cm2.ExecuteScalar();
            cn.Close();

            int nrab_god = Convert.ToInt32(rab_god);
            int nrab_mes = Convert.ToInt32(rab_mes);

            /// Если год и месяц установки детали совпадают с рабочими, то можно установить
            /// 
            DateTime LastDatOfMonth ;
            //string c_dtp_dataReplaced = dtp_dataReplaced.Value.ToString("yyyyMMdd");


            if (InfoRepair.DateOut =="" || InfoRepair.DateOut ==null)
            {
                int allDayMonth = DateTime.DaysInMonth(nrab_god,nrab_mes);
                LastDatOfMonth = new DateTime(nrab_god, nrab_mes, allDayMonth);
            }
            else
                LastDatOfMonth = Convert.ToDateTime(InfoRepair.DateOut);

            if (rab_god.ToString() == dtp_dataReplaced.Value.Year.ToString() && rab_mes.ToString() == dtp_dataReplaced.Value.Month.ToString())
            {
                //MessageBox.Show(Convert.ToDateTime(InfoRepair.DateOut).ToShortDateString());

                if (Convert.ToDateTime(dtp_dataReplaced.Value.ToShortDateString()) >= Convert.ToDateTime(InfoRepair.DataIn.ToString()) && Convert.ToDateTime(dtp_dataReplaced.Value.ToShortDateString()) <= Convert.ToDateTime(LastDatOfMonth.ToShortDateString()) )
               {

            
            {
                if (dgv_ReplacedPart.RowCount == 0)
                {
                    MessageBox.Show("Зберігати нічого" + dgv_ReplacedPart.RowCount);
                }
                else
                    if (dgv_ReplacedPart.RowCount > 0)
                    {

                        ////// проверка (начало) , чтоб дата получения деталей была не больше даты завершения ремонта
                        //if (string.IsNullOrEmpty(DateOut)) // если дата окончания ремонта пустая, то проверку не делаем
                        //{ }
                        //else
                        //{
                        //    string mm = "";
                        //    try
                        //    {
                        //        for (int i = 0; i < dgv_ReplacedPart.RowCount; i++)
                        //        {
                        //        double res1;
                        //        string kk;
                        //        bool isInt1 = Double.TryParse(dgv_ReplacedPart.Rows[i].Cells["User_Kol"].Value.ToString(), out res1);

                        //        if ((isInt1 == true) & (res1 > 0) & Convert.ToDateTime(dgv_ReplacedPart.Rows[i].Cells["DATA"].Value.ToString()) > Convert.ToDateTime(DateOut))
                        //        {
                        //                mm = mm + dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() + "-  дата отриммання деталі  " + dgv_ReplacedPart.Rows[i].Cells["DATA"].Value.ToString() + " більше дати установки " + DateOut + "\n";
                        //        }
                        //        }
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        MessageBox.Show(ex.ToString());
                        //    }

                        //    if (mm.Length > 0)
                        //    {
                        //        MessageBox.Show(mm,"Перевірте дати");
                        //        return;
                        //    }
                        //    else { }
                        //}
                        //  // проверка (конец) , чтоб дата получения деталей была не больше даты завершения ремонта




                        for (int i = 0; i < dgv_ReplacedPart.RowCount; i++)
                        {
                            // fff
                           
                            
                            if (dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() == "752014")
                            {
                                string gg = "";
                            }


                            try
                            {
                                double res;
                                string eddnom = dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString();
                                bool isInt = Double.TryParse(dgv_ReplacedPart.Rows[i].Cells["User_Kol"].Value.ToString(), out res);


                                string dat_poluch = dgv_ReplacedPart.Rows[i].Cells["DATA"].Value.ToString();
                                string mm = "";
                                string mm1 = "";

                                if ((res > 0) & (String.IsNullOrEmpty(dgv_ReplacedPart.Rows[i].Cells["prace"].Value.ToString()) || dgv_ReplacedPart.Rows[i].Cells["prace"].Value.ToString() == "0"))
                                {
                                    MessageBox.Show("Не можна зберігати номенклатуру" + dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString()+ " з ціною " + dgv_ReplacedPart.Rows[i].Cells["prace"].Value.ToString());
                                    continue;
                                
                                }

                                //проверка (начало) , чтоб дата получения деталей была не больше даты завершения ремонта
                                if (DateOut.Length > 0)
                                {
                                    DateTime d_pol = Convert.ToDateTime(dat_poluch);
                                    DateTime d_out = Convert.ToDateTime(DateOut);
                                    DateTime d_ust = Convert.ToDateTime(dtp_dataReplaced.Value.ToShortDateString());
                                    if ((isInt == true) & (res > 0) & (d_pol > d_out))
                                    {
                                        mm = mm + dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() + "-  дата отриммання " + Convert.ToDateTime(dgv_ReplacedPart.Rows[i].Cells["DATA"].Value.ToString()).ToShortDateString() + " більше дати завершення ремонту " + Convert.ToDateTime(DateOut).ToShortDateString() + "\n";
                                    }
                                    if (mm.Length > 0)
                                    {
                                        MessageBox.Show(mm);
                                        continue;
                                    }
                                    //проверка (конец) , чтоб дата получения деталей была не больше даты завершения ремонта



                                    //проверка (начало) , чтоб дата получения деталей была не больше даты установки
                                    if ((isInt == true) & (res > 0) & (d_pol > d_ust))
                                    {
                                        mm1 = mm1 + dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() + "-  дата отриммання " + Convert.ToDateTime(dgv_ReplacedPart.Rows[i].Cells["DATA"].Value.ToString()).ToShortDateString() + " більше дати установки " + Convert.ToDateTime(DateOut).ToShortDateString() + "\n";
                                    }
                                    if (mm1.Length > 0)
                                    {
                                        MessageBox.Show(mm1);
                                        continue;
                                    }
                                    //проверка (конец) , чтоб дата получения деталей была не больше даты установки

                                }
                                else
                                {
                                    //проверка (начало) , чтоб дата получения деталей была не больше даты установки
                                    DateTime d_pol = Convert.ToDateTime(dat_poluch);
                                    DateTime d_ust = Convert.ToDateTime(dtp_dataReplaced.Value.ToShortDateString());
                                    if ((isInt == true) & (res > 0) & (d_pol > d_ust))
                                    {
                                        mm1 = mm1 + dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() + "-  дата отриммання " + Convert.ToDateTime(dgv_ReplacedPart.Rows[i].Cells["DATA"].Value.ToString()).ToShortDateString() + " більше дати установки " + Convert.ToDateTime(d_ust).ToShortDateString() + "\n";
                                    }
                                    if (mm1.Length > 0)
                                    {
                                        MessageBox.Show(mm1);
                                        continue;
                                    }
                                    //проверка (конец) , чтоб дата получения деталей была не больше даты установки

                                }


                                if ((isInt == true) & (res!=0) &  (res <= Convert.ToDouble(dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Value.ToString())) & eddnom.Trim().Substring(0,2)!="07" )
                                {
                                    ReplacedPart.EDNOME = dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString();
                                    ReplacedPart.Mera = dgv_ReplacedPart.Rows[i].Cells["Mera"].Value.ToString();
                                    ReplacedPart.Name = dgv_ReplacedPart.Rows[i].Cells["Name"].Value.ToString();
                                    ReplacedPart.Prace = dgv_ReplacedPart.Rows[i].Cells["Prace"].Value.ToString().Replace(',', '.');
                                    ReplacedPart.Quantity = dgv_ReplacedPart.Rows[i].Cells["User_kol"].Value.ToString().Replace(',', '.');
                                    ReplacedPart.DateReplace = dtp_dataReplaced.Value.ToString("yyyyMMdd");
                                    ReplacedPart.DateInRep = dgv_ReplacedPart.Rows[i].Cells["Data"].Value.ToString();
                                    ReplacedPart.Shpz = dgv_ReplacedPart.Rows[i].Cells["Shpz"].Value.ToString();
                                    ReplacedPart.Zavnom = dgv_ReplacedPart.Rows[i].Cells["Zavnom"].Value.ToString();
                                    if (dgv_ReplacedPart.Rows[i].Cells["norma"].Value == null)
                                    {
                                        ReplacedPart.Norma = "100";
                                    }
                                    else
                                    {
                                        ReplacedPart.Norma = dgv_ReplacedPart.Rows[i].Cells["norma"].Value.ToString().Trim();
                                    }

                                    if (dgv_ReplacedPart.Rows[i].Cells["tehno"].Value == null)
                                    {
                                        ReplacedPart.Tehno = "100";
                                    }
                                    else
                                    {
                                        ReplacedPart.Tehno = dgv_ReplacedPart.Rows[i].Cells["tehno"].Value.ToString().Trim();
                                    }
                                    DateTime date = new DateTime();
                                    date = Convert.ToDateTime(ReplacedPart.DateInRep);
                                    ReplacedPart.DateInRep = date.ToString("yyyyMMdd");

                                    DateTime DatNow = DateTime.Now; // Запоминаем дату для её сохранения в запчастях и в возвратных деталях

                                    if (dal.SaveNewReplacedPart(DatNow) == true)
                                    {
                                        // На автомате добавляем возвратніе детали

                                        string r_id = InfoRepair.RepairID;
                                        ReplacedPart.EDNOME = dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString();
                                        ReplacedPart.Name = dgv_ReplacedPart.Rows[i].Cells["Name"].Value.ToString();
                                        ReplacedPart.Prace = dgv_ReplacedPart.Rows[i].Cells["Prace"].Value.ToString().Replace(',', '.');
                                        ReplacedPart.Quantity = dgv_ReplacedPart.Rows[i].Cells["User_kol"].Value.ToString().Replace(',', '.');
                                        ReplacedPart.DateReplace = dtp_dataReplaced.Value.ToString("yyyyMMdd");

                                        //int kod_vozvrat_det = 0;
                                        int kol_found_vozv_det = 0;


                                        // проверяем на галочку из единого справочника, что єто возвратній материал 
                                        // если галочка есть, то сохраняем в возвратніе детали

                                        for (int ii = 0; ii < dgv_r_vozvr_det.RowCount; ii++)
                                        {
                                            string edn = dgv_r_vozvr_det.Rows[ii].Cells["EDNOME"].Value.ToString().Trim();
                                            if (edn ==ReplacedPart.EDNOME.Trim() )
                                                {
                                                    kol_found_vozv_det = kol_found_vozv_det + 1;
                                                    kol_zam_zapt = kol_zam_zapt + 1;
                                                }
                                        }

                                        if (kol_found_vozv_det > 0)
                                        {

                                            try
                                            {
                                                if (dal.SavevozvrDet(ReplacedPart.Name.Replace("'", "^"), ReplacedPart.Quantity, "", ReplacedPart.DateReplace, ReplacedPart.EDNOME,DatNow) == true)
                                                {
                                                    this.DialogResult = DialogResult.OK;
                                                }
                                                else
                                                {
                                                    this.DialogResult = DialogResult.Cancel;
                                                    MessageBox.Show("Помилка збереження повернутих деталів");
                                                }
                                            }
                                            catch
                                            {
                                            }


                                        }
                                        kol_found_vozv_det = 0;


                                    }
                                    else
                                    {
                                        MessageBox.Show("Помилка!!! Додавання інформації в БД не виконано!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Номенклатура " + dgv_ReplacedPart.Rows[i].Cells["EDNOME"].Value.ToString() + " " + dgv_ReplacedPart.Rows[i].Cells["Name"].Value.ToString() + 
                                        " не додано " + "\n\n" + "Перевірте!!! : " + "\n\n" + " - введіть числа через ( , ) " + "\n" + " - або перевищена кількість Доступно для списання" +
                                        "\n" + " - або ви нвосите 07 групу (заборонена на внесення 07 групи)" + "\n" + " - або кількість = 0");
                                    //MessageBox.Show("Кількість по ном. " + ReplacedPart.EDNOME + " " + dgv_ReplacedPart.Rows[i].Cells["Name"].Value.ToString() + " вказано не вірно!!! : " + "\n" + " - введіть числа через ( , ) " + "\n" + " - або перевищена кількість Доступно для списання" + "\n" + " - або ви нвосите 07 групу (заборонена на внесення 07 групи)");
                                }
                            }
                            catch
                            {
                                
                            }

                            this.Close();
                        }
                    }
            }
               }
               else
                {
                    MessageBox.Show("Фактическая дата установки материала не в пределах\n с " + InfoRepair.DataIn + " по " + LastDatOfMonth.ToShortDateString()); 
               }
        }
            else  
            {
                MessageBox.Show("Фактическая дата установки материала не в пределах\n Рабочего месяца (" +rab_mes + "мес." + rab_god + "год)");    
             }

            if (kol_zam_zapt > 0)
            {
                MessageBox.Show("Автоматично додано " + kol_zam_zapt.ToString() + " строк повернутих деталів.");    
            }
        }

        private void trt_Click(object sender, EventArgs e)
        {
            btn_AddNewRepPartNotMol.Visible = false;

            dgv_r_vozvr_det.DataSource = dal_dbf.Get_Priznak_vozvr_det();

            //MessageBox.Show("priznak vozvr det ");

            if (InfoRepair.NumberDivis != "9966")
            {
                dgv_ReplacedPart.DataSource = dal_dbf.GetAllTMCFORMOL();
            }
            else {
                dgv_ReplacedPart.DataSource = dal_dbf.GetAllTMCFORMOLKontragent();
            }

            //MessageBox.Show("get tmc");
            if (dgv_ReplacedPart.RowCount > 0)
            {

                dgv_ReplacedPart.Columns.Add("User_Kol", "Кіл-ть");
                dgv_ReplacedPart.Columns.Add("Finish_Kol", "Доступно для списання");
                dgv_ReplacedPart.Columns.Add("tehno", "Тех");
                dgv_ReplacedPart.Columns.Add("norma", "Норма");
                dgv_ReplacedPart.ReadOnly = false;
                dgv_ReplacedPart.Columns["User_Kol"].ReadOnly = false;
                dgv_ReplacedPart.Columns["Finish_Kol"].ReadOnly = false;
                dgv_ReplacedPart.Columns["tehno"].ReadOnly = false;
                dgv_ReplacedPart.Columns["norma"].ReadOnly = false;

                dgv_ReplacedPart.EnableHeadersVisualStyles = false;// Цвет шапки грида  color header grid
                dgv_ReplacedPart.Columns["Finish_Kol"].HeaderCell.Style.ForeColor = Color.Blue;
//9999999



                SettingsGetAllTMC();
                dgv_ReplacedPart.Visible = false;
            }

            dgv_ReplacedPart.Visible = true;

            AlterDGVReplacedPart();

            Null_to_white(); // нулевые значения красим белым

            //dgv_ReplacedPart.Columns["Finish_Kol"].DefaultCellStyle.Format = "#0.000000";
            btn_update.Visible = false;
        }

        private void btn_AddNewRepPartNotMol_Click(object sender, EventArgs e)
        {
            myfrmAddNewRepPartNotMol myfrmAddNewRepPartNotMol = new myfrmAddNewRepPartNotMol();
            myfrmAddNewRepPartNotMol.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myfrmAddNewReplacerPart_Load(object sender, EventArgs e)
        {

        }

        private void Null_to_white()
        {
            for (int i = 0; i < dgv_ReplacedPart.RowCount; i++)
            {
                if (dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Value.ToString() == "0")
                {
                    //for (int j = 0; j < dgv_ReplacedPart.ColumnCount; j++)
                    //{
                    dgv_ReplacedPart.Rows[i].Cells["Finish_Kol"].Style.ForeColor = Color.White;
                    //***

                    //**
                    //}
                }
            }
        }
    }
}
