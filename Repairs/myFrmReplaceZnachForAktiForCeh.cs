using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data.Odbc;
//using System.Data.OleDb;

namespace Repairs
{
    public partial class myFrmReplaceZnachForAktiForCeh : Form
    {
        string nomceh;


        public myFrmReplaceZnachForAktiForCeh(string IspCx)
        {
            InitializeComponent();
            nomceh = IspCx;
        }
        
       // SqlConnection con;
       // SqlDataAdapter da;

        private void myFrmReplaceZnachForAktiForCeh_Load(object sender, EventArgs e)
        {
            
            label2.Text = Found_rab_mes (nomceh, "Store.StoreID");
            label3.Text = Found_rab_mes(nomceh, "Store.StoreName");
            label5.Text = Found_rab_mes(nomceh, "Status_mes_ceh.mes");
            label6.Text = Found_rab_mes(nomceh, "Status_mes_ceh.god");


        }

        
        private string Found_rab_mes(string NOMCEH, string NAMPOLE)
        {
            string constr = Properties.Settings.Default.RepairOSConnStr;
            SqlConnection SqlCon = new SqlConnection(constr);
            //string my_result = "";
            SqlCommand com = new SqlCommand("SELECT " + NAMPOLE + " FROM [Repairs].[dbo].[Store]    INNER JOIN Status_mes_ceh ON Store.StoreID = Status_mes_ceh.StoreId "+
                "WHERE Status_mes_ceh.StoreId=@N_CEH", SqlCon);
            com.Parameters.Add("@N_CEH", SqlDbType.NVarChar).Value = NOMCEH;
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

        private void txtBx_CexVitrProc_TextChanged(object sender, EventArgs e)
        {

        }


        private int proverka()
        {
            float num; // проверка является ли значение числом


            if (radioButton3.Checked == true && radioButton4.Checked == false && radioButton5.Checked == false)
            {
                return 1;
            }
            else
            {
                if (radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    //return 0;
                    if (!float.TryParse(txtBx_nuth.Text, out num))
                    {
                        MessageBox.Show("Значення Дільниця не є числом. Перевірте написання.");
                        txtBx_nuth.Select();
                        return 0;
                    }
                    else 
                    {
                        if (String.IsNullOrEmpty(txtBx_nuth.Text.Trim()) || txtBx_nuth.Text.Trim() == "0")
                        {
                            MessageBox.Show("Заповніть поле ''Дільниця''.");
                            txtBx_nuth.Select();
                            return 0;
                        }
                        else { return 1; }
                    }
                }
                else
                {
                    return 1;
                }
            }
            
            //else
            //{
            //    if (radioButton4.Checked == true || radioButton5.Checked == true)
            //    {
            //        // проверка является ли значение числом
            //        if (!float.TryParse(txtBx_nuth.Text, out num))
            //        {
            //            MessageBox.Show("Значення Дільниця не є числом. Перевірте написання.");
            //            txtBx_nuth.Select();
            //            return 0;
            //        }
            //        if (String.IsNullOrEmpty(txtBx_nuth.Text.Trim()) || txtBx_nuth.Text.Trim() == "0")
            //        {
            //            MessageBox.Show("Заповніть поле ''Дільниця''.");
            //            txtBx_nuth.Select();
            //            return 0;
            //        }
            //    }
            //    else
            //    {
            //        return 1;
            //    }

              

            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
                       
            string CexVitrProc = txtBx_CexVitrProc.Text.ToString();
            if (String.IsNullOrEmpty(txtBx_CexVitrProc.Text))
                CexVitrProc = "0,00";
            else
            {
                CexVitrProc = txtBx_CexVitrProc.Text.Replace(".", ","); // Замена точки на запятую
            }
           
            float num; // проверка является ли значение числом
            if (!float.TryParse(CexVitrProc, out num))
            {
                MessageBox.Show("Значення Цехові витрати не є числом. Перевірте написання.");
                txtBx_CexVitrProc.Select();
                return ;
            }

            //if (proverka() == 0)
            //{
            //    return;
            //}

            string nceh = label2.Text.Trim();
            
            string nuth = txtBx_nuth.Text.Trim();
            if (String.IsNullOrEmpty(nuth))
                nuth = "0";
             string nbrig = txtBx_nbrig.Text.Trim();
            if (String.IsNullOrEmpty(nbrig))
                nbrig = "0";
            string namceh = label3.Text.Trim();
            string rmes = label5.Text.Trim();
            string rgod = label6.Text.Trim();
            string vibor = "";
            string vibor2 = "";
            string zapros = "";
            string vibor3 = "";
            string vibor4 = "";

            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                vibor = "по всіх Актах"; vibor2 = "all"; 
                if (radioButton3.Checked == true && radioButton4.Checked == false && radioButton5.Checked == false)
                {
                    vibor3 = " по цеху " + nceh;
                    vibor4 = "ceh";
                    zapros = "select count(id) from Vedomost_Resursov  where (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' )";
                }
                else
                {
                    if (radioButton4.Checked == true && radioButton5.Checked == false)
                    {
                        vibor3 = " по цеху " + nceh+"."+nuth;
                        vibor4 = "ceh_uth";
                        zapros = "select count(id) from Vedomost_Resursov  where (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' )";
                    }
                    if (radioButton4.Checked == false && radioButton5.Checked == true)
                    {
                        vibor3 = " по цеху " + nceh + "." + nuth+"."+nbrig;
                        vibor4 = "ceh_uth_br";
                        zapros = "select count(id) from Vedomost_Resursov  where (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' and Ispolnitel_codbrig='" + nbrig + "' )";
                    }
                }
                
            }
            else
            {
                vibor = "по Актах з пустими значеннями";
                vibor2 = "pustie";

                //zapros = "select count(id) from Vedomost_Resursov  where (cexVitrProc=0 or cexVitrProc is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' )";
             
                if (radioButton3.Checked == true && radioButton4.Checked == false && radioButton5.Checked == false)
                {
                    vibor3 = " по цеху " + nceh ;
                    vibor4 = "ceh";
                    zapros = "select count(id) from Vedomost_Resursov  where (cexVitrProc=0 or cexVitrProc is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' )";

                }
                else
                {
                    if (radioButton4.Checked == true && radioButton5.Checked == false)
                    {
                        vibor3 = " по цеху " + nceh + "." + nuth ;
                        vibor4 = "ceh_uth";
                        zapros = "select count(id) from Vedomost_Resursov  where (cexVitrProc=0 or cexVitrProc is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' )";
                    }
                    if (radioButton4.Checked == false && radioButton5.Checked == true)
                    {
                        vibor3 = " по цеху " + nceh + "." + nuth + "." + nbrig;
                        vibor4 = "ceh_uth_br";
                        zapros = "select count(id) from Vedomost_Resursov  where (cexVitrProc=0 or cexVitrProc is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' and Ispolnitel_codbrig='" + nbrig + "' )";
                    }
                }
        
                string constr = Properties.Settings.Default.RepairOSConnStr;
                SqlConnection SqlCon = new SqlConnection(constr);
                //string my_result = "";
                SqlCommand com = new SqlCommand(zapros, SqlCon);
                SqlCon.Open();
                object ress = com.ExecuteScalar();
                SqlCon.Close();
             
                if (Convert.ToInt32(ress) > 0)
                { }
                else
                {
                    //MessageBox.Show("Інформаії по Цеху "+nceh+ "  діл."+nuth+"  не існує. Заміна Цехових не буде виконана");
                        MessageBox.Show("Інформаії " + vibor3 + " не існує. Заміна Цехових не буде виконана");
                        return;
                }
            }

            
            DAL DAL = new DAL();
            DialogResult res = MessageBox.Show("Д І Й С Н О   З А М І Н И Т И\n\nцехові витрати = " + CexVitrProc + "%\n\n" + vibor + "\n\nп"+vibor3+"\n\nза " +
                  rmes.ToString() + " міс." + rgod.ToString() + " рік", "Зробіть вибір", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
              //  MessageBox.Show("Yes");

                //(DAL.UpdateVedResAKT_TZV_ForCeh
                if (DAL.UpdateVedResAKT_CexVitrProc_ForCehUth(nceh, nuth,nbrig, CexVitrProc.Replace(",", "."), rgod, rmes, vibor2,vibor4) == true)
                {
                    //MessageBox.Show("Цехові витрати замінено!");
                }
                else
                {
                    //MessageBox.Show("Помилка заміни Цехових витрат!");
                }
                MessageBox.Show("Виконано!");
            }
            else
            {
                MessageBox.Show("Відміна");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
    
            string TZV = txtBx_TZV.Text.ToString();
            if (String.IsNullOrEmpty(txtBx_TZV.Text))
                TZV = "0,00";
            else
            {
                TZV = txtBx_TZV.Text.Replace(".", ","); // Замена точки на запятую
            }
           
            float num; // проверка является ли значение числом
            if (!float.TryParse(TZV, out num))
            {
                MessageBox.Show("Значення ТЗВ не є числом. Перевірте написання.");
                txtBx_TZV.Select();
                return ;
            }

            //if (proverka() == 0)
            //{
            //    return;
            //}

            string nceh = label2.Text.Trim();
            
            string nuth = txtBx_nuth.Text.Trim();
            if (String.IsNullOrEmpty(nuth))
                nuth = "0";
             string nbrig = txtBx_nbrig.Text.Trim();
            if (String.IsNullOrEmpty(nbrig))
                nbrig = "0";
            string namceh = label3.Text.Trim();
            string rmes = label5.Text.Trim();
            string rgod = label6.Text.Trim();
            string vibor = "";
            string vibor2 = "";
            string zapros = "";
            string vibor3 = "";
            string vibor4 = "";

            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                vibor = "по всіх Актах"; vibor2 = "all"; 
                if (radioButton3.Checked == true && radioButton4.Checked == false && radioButton5.Checked == false)
                {
                    vibor3 = " по цеху " + nceh;
                    vibor4 = "ceh";
                    zapros = "select count(id) from Vedomost_Resursov  where (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' )";
                }
                else
                {
                    if (radioButton4.Checked == true && radioButton5.Checked == false)
                    {
                        vibor3 = " по цеху " + nceh+"."+nuth;
                        vibor4 = "ceh_uth";
                        zapros = "select count(id) from Vedomost_Resursov  where (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' )";
                    }
                    if (radioButton4.Checked == false && radioButton5.Checked == true)
                    {
                        vibor3 = " по цеху " + nceh + "." + nuth+"."+nbrig;
                        vibor4 = "ceh_uth_br";
                        zapros = "select count(id) from Vedomost_Resursov  where (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' and Ispolnitel_codbrig='" + nbrig + "' )";
                    }
                }
                
            }
            else
            {
                vibor = "по Актах з пустими значеннями";
                vibor2 = "pustie";

                //zapros = "select count(id) from Vedomost_Resursov  where (cexVitrProc=0 or cexVitrProc is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' )";
             
                if (radioButton3.Checked == true && radioButton4.Checked == false && radioButton5.Checked == false)
                {
                    vibor3 = " по цеху " + nceh ;
                    vibor4 = "ceh";
                    zapros = "select count(id) from Vedomost_Resursov  where (tzv=0 or tzv is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' )";

                }
                else
                {
                    if (radioButton4.Checked == true && radioButton5.Checked == false)
                    {
                        vibor3 = " по цеху " + nceh + "." + nuth ;
                        vibor4 = "ceh_uth";
                        zapros = "select count(id) from Vedomost_Resursov  where (tzv=0 or tzv is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' )";
                    }
                    if (radioButton4.Checked == false && radioButton5.Checked == true)
                    {
                        vibor3 = " по цеху " + nceh + "." + nuth + "." + nbrig;
                        vibor4 = "ceh_uth_br";
                        zapros = "select count(id) from Vedomost_Resursov  where (tzv=0 or tzv is null) and (YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' and Ispolnitel_coduth='" + nuth + "' and Ispolnitel_codbrig='" + nbrig + "' )";
                    }
                }
        
                string constr = Properties.Settings.Default.RepairOSConnStr;
                SqlConnection SqlCon = new SqlConnection(constr);
                //string my_result = "";
                SqlCommand com = new SqlCommand(zapros, SqlCon);
                SqlCon.Open();
                object ress = com.ExecuteScalar();
                SqlCon.Close();
             
                if (Convert.ToInt32(ress) > 0)
                { }
                else
                {
                    //MessageBox.Show("Інформаії по Цеху "+nceh+ "  діл."+nuth+"  не існує. Заміна Цехових не буде виконана");
                        MessageBox.Show("Інформаії " + vibor3 + " не існує. Заміна ТЗВ не буде виконана");
                        return;
                }
            }

            
            DAL DAL = new DAL();
            DialogResult res = MessageBox.Show("Д І Й С Н О   З А М І Н И Т И\n\nТЗВ = " + TZV + "%\n\n" + vibor + "\n\nп"+vibor3+"\n\nза " +
                  rmes.ToString() + " міс." + rgod.ToString() + " рік", "Зробіть вибір", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
              //  MessageBox.Show("Yes");

                if(DAL.UpdateVedResAKT_TZV_ForCehUth(nceh, nuth,nbrig, TZV.Replace(",", "."), rgod, rmes, vibor2,vibor4) == true)
                //if (DAL.UpdateVedResAKT_CexVitrProc_ForCehUth(nceh, nuth,nbrig, CexVitrProc.Replace(",", "."), rgod, rmes, vibor2,vibor4) == true)
                {
                   // MessageBox.Show("ТЗВ замінено!");
                }
                else
                {
                   // MessageBox.Show("Помилка заміни ТЗВ!");
                }

                MessageBox.Show("Виконано!");
            }
            else
            {
                MessageBox.Show("Відміна");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string nceh = label2.Text.Trim();
            string namceh = label3.Text.Trim();
            string rmes = label5.Text.Trim();
            string rgod = label6.Text.Trim();
            string vibor = "";
            string vibor2 = "";

            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                vibor = "по всіх Актах";
                vibor2 = "all";
            }
            else
            {
                vibor= "по пустим значенням";
                vibor2 = "pustie";
            }


            DAL DAL = new DAL();
            DialogResult res = MessageBox.Show("Д І Й С Н О   О Н О В И Т И\n\nПідписи\n\n" + vibor + "\n\nпо Цеху " + nceh.ToString() + " " + namceh.ToString() + "\n\nза " +
                  rmes.ToString() + " міс." + rgod.ToString() + " рік", "Зробіть вибір", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
               // MessageBox.Show("Yes");
                    if (DAL.UpdateVedResAKT_PidpisiCeh("FIO1f2", rgod, rmes, nceh, vibor2) == true) {}
                    if (DAL.UpdateVedResAKT_PidpisiCeh("dolg1f2", rgod, rmes, nceh, vibor2) == true) {}

                    if (DAL.UpdateVedResAKT_PidpisiCeh("FIO2f2", rgod, rmes, nceh, vibor2) == true) {}
                    if (DAL.UpdateVedResAKT_PidpisiCeh("dolg2f2", rgod, rmes, nceh, vibor2) == true) {}

                    if (DAL.UpdateVedResAKT_PidpisiCeh("FIO3f2", rgod, rmes, nceh, vibor2) == true) {}
                    if (DAL.UpdateVedResAKT_PidpisiCeh("dolg3f2", rgod, rmes, nceh, vibor2) == true) {}

                    if (DAL.UpdateVedResAKT_PidpisiCeh("FIO4f2", rgod, rmes, nceh, vibor2) == true) {}
                    if (DAL.UpdateVedResAKT_PidpisiCeh("dolg4f2", rgod, rmes, nceh, vibor2) == true) {}

                    if (DAL.UpdateVedResAKT_PidpisiCeh("FIO5f2", rgod, rmes, nceh, vibor2) == true) {}
                    if (DAL.UpdateVedResAKT_PidpisiCeh("dolg5f2", rgod, rmes, nceh, vibor2) == true) { }

                    MessageBox.Show("Оновлення підписів виконано!"); 
               
                
                // віполняем замену
                //FIO1 = Found_fio_or_dolg(repid, "FIO1f2");
                //FIO2 = Found_fio_or_dolg(repid, "FIO2f2");
                //FIO3 = Found_fio_or_dolg(repid, "FIO3f2");
                //FIO4 = Found_fio_or_dolg(repid, "FIO4f2");
                //FIO5 = Found_fio_or_dolg(repid, "FIO5f2");

                //State1 = Found_fio_or_dolg(repid, "dolg1f2");
                //State2 = Found_fio_or_dolg(repid, "dolg2f2");
                //State3 = Found_fio_or_dolg(repid, "dolg3f2");
                //State4 = Found_fio_or_dolg(repid, "dolg4f2");
                //State5 = Found_fio_or_dolg(repid, "dolg5f2");
            }
            else
            { MessageBox.Show("Відміна"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nceh = label2.Text.Trim();
            string namceh = label3.Text.Trim();
            string rmes = label5.Text.Trim();
            string rgod = label6.Text.Trim();
            string vibor = "";
            if (radioButton1.Checked == true && radioButton2.Checked == false)
            { vibor = "по всіх Актах"; }
            else
            { vibor = "по Актах з пустими значеннями"; }
            DAL DAL = new DAL();
            DAL_DBF dal_dbf = new DAL_DBF();
            DialogResult res = MessageBox.Show("Д І Й С Н О   З А М І Н И Т И\n\nЗарплату\n\n" + vibor + "\n\nпо Цеху " + nceh.ToString() + " " + namceh.ToString() + "\n\nза " +
                  rmes.ToString() + " міс." + rgod.ToString() + " рік", "Зробіть вибір", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //MessageBox.Show("Yes");
                SqlConnection con;
                con = new SqlConnection("Data Source=UAESB-sql-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();

                if (radioButton1.Checked == true && radioButton2.Checked == false)
                { //vibor = "по всіх Актах";
                   da = new SqlDataAdapter("SELECT [ID],[RepairID],[InventoryNamber],Obekt,[PeriodData1],[PeriodData2] ,[Shpz],[Ispolnitel_codcx],[Ispolnitel_coduth],[Ispolnitel_codbrig],[Ispolnitel_coddet] " +
                     ",[vidrahProc],[TZV],[cexVitrProc],[vsegoMat],[amortProc],[vsegoZP],[sumNalogov],[tzvGrn],[cehVitrGrn],[amortGrn],[vsego_F]" +
                     " FROM [Repairs].[dbo].[Vedomost_Resursov]" +
                     " where YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' ", con);
                }
                else
                { //vibor = "по Актах з пустими значеннями";
                  da = new SqlDataAdapter("SELECT [ID],[RepairID],[InventoryNamber],Obekt,[PeriodData1],[PeriodData2] ,[Shpz],[Ispolnitel_codcx],[Ispolnitel_coduth],[Ispolnitel_codbrig],[Ispolnitel_coddet] " +
                     ",[vidrahProc],[TZV],[cexVitrProc],[vsegoMat],[amortProc],[vsegoZP],[sumNalogov],[tzvGrn],[cehVitrGrn],[amortGrn],[vsego_F]" +
                     " FROM [Repairs].[dbo].[Vedomost_Resursov]" +
                     " where (vsegoZP=0 or vsegoZP is null ) and YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' ", con);
                }


                
                if (rmes.Length == 1)
                {
                    rmes = "0" + rmes;
                }
                DataTable tab = new DataTable();
                da.Fill(tab); //Загрузка в DataTable
                if (Convert.ToInt32(tab.Rows.Count) > 0)
                {
                    for (int ii = 0; ii < tab.Rows.Count; ii++)
                    {
                        try
                        {
                            dgv_ZP.DataSource = "";
                            dgv_ZP.DataSource = dal_dbf.GetZP(rmes, rgod, tab.Rows[ii][2].ToString(), tab.Rows[ii][7].ToString(), tab.Rows[ii][8].ToString(), tab.Rows[ii][9].ToString(), tab.Rows[ii][3].ToString(), tab.Rows[ii][6].ToString());
                        }
                        catch 
                        {
                        };

                        if (dgv_ZP.RowCount > 0)
                        {
                            MessageBox.Show(tab.Rows[ii][0].ToString()); 

                            double ssumZP = 0.00;
                            double ssumNalogov = 0.00;
                            for (int i = 0; i < dgv_ZP.RowCount; i++)
                            {
                                string Kt = dgv_ZP.Rows[i].Cells["Kt"].Value.ToString();
                                string Kt2 = Kt.Substring(0, 2);

                                if (Kt2 == "66") // подсчитываем ЗП
                                {
                                    ssumZP = ssumZP + Convert.ToDouble(dgv_ZP.Rows[i].Cells["Sum"].Value);
                                }

                                if (Kt2 == "65") // подсчитываем отчисления
                                {
                                    ssumNalogov = ssumNalogov + Convert.ToDouble(dgv_ZP.Rows[i].Cells["Sum"].Value);
                                }
                            }
                            //    txtBx_VsegoZP.Text = ssumZP.ToString();
                            //    txtBx_SumNalogov.Text = ssumNalogov.ToString();

                            // Делаем update 
                            if (DAL.UpdateVedResAKT_ZP(tab.Rows[ii][0].ToString(), ssumZP.ToString(), ssumNalogov.ToString()) == true)
                            {
                               // MessageBox.Show("Інформацію по процентам(1) Збережено.");
                                //this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                //MessageBox.Show("Помилка в збережені(1) процентів.");
                                //this.DialogResult = DialogResult.Cancel;
                            }
                        }
                    }
                }
                else
                { MessageBox.Show("Не існують пусті значення по ЗП по Цеху");
                }
                da.Dispose();
                con.Close();


                //foreach (DataRow dataRow in dt_ved_r.Rows)
                //{
                //    // Console.WriteLine("—————-");
                //    foreach (DataColumn dataColumn in dtUsl.Columns)
                //    {
                //        if (insertINTOTABUsl(dataRow[0].ToString(), dataRow[1].ToString(), dataRow[2].ToString(), dataRow[3].ToString(), dataRow[4].ToString(), dataRow[5].ToString(), dataRow[6].ToString(), dataRow[7].ToString()) == true)
                //        {
                //        }
                //        else
                //        {
                //            Console.WriteLine("Ошибка добавления ОС-услуги");
                //        }
                //    }
                //    // Console.WriteLine("1");
                //}


                //dgv_ZP.DataSource = dal_dbf.GetZP(mes, god, inv, cx, uch, brig, obekt, shpz);
                //if (dgv_ZP.RowCount > 0)
                //{
                //    double ssumZP = 0.00;
                //    double ssumNalogov = 0.00;
                //    for (int i = 0; i < dgv_ZP.RowCount; i++)
                //    {
                //        string Kt = dgv_ZP.Rows[i].Cells["Kt"].Value.ToString();
                //        string Kt2 = Kt.Substring(0, 2);

                //        if (Kt2 == "66") // подсчитываем ЗП
                //        {
                //            ssumZP = ssumZP + Convert.ToDouble(dgv_ZP.Rows[i].Cells["Sum"].Value);
                //        }

                //        if (Kt2 == "65") // подсчитываем отчисления
                //        {
                //            ssumNalogov = ssumNalogov + Convert.ToDouble(dgv_ZP.Rows[i].Cells["Sum"].Value);
                //        }

                //    }

                //    txtBx_VsegoZP.Text = ssumZP.ToString();
                //    txtBx_SumNalogov.Text = ssumNalogov.ToString();
                  
                //}

                MessageBox.Show("Виконано");
             }
              else
                                   
            {
                MessageBox.Show("Відміна");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nceh = label2.Text.Trim();
            string namceh = label3.Text.Trim();
            string rmes = label5.Text.Trim();
            string rgod = label6.Text.Trim();
            string vibor = "";
            if (radioButton1.Checked == true && radioButton2.Checked == false)
            { vibor = "по всіх Актах"; }
            else
            { vibor = "по Актах з пустими значеннями"; }
            DAL DAL = new DAL();
            DialogResult res = MessageBox.Show("Д І Й С Н О   З А М І Н И Т И\n\nПерарахування\n\nпо Цеху " + nceh.ToString() + " " + namceh.ToString() + "\n\nза " +
                  rmes.ToString() + " міс." + rgod.ToString() + " рік", "Зробіть вибір", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
                //**************

                SqlConnection con;
                con = new SqlConnection("Data Source=UAESB-sql-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("SELECT [ID],[RepairID],[InventoryNamber],Obekt,[PeriodData1],[PeriodData2] ,[Shpz],[Ispolnitel_codcx],[Ispolnitel_coduth],[Ispolnitel_codbrig],[Ispolnitel_coddet] " +
                     ",[vidrahProc],[TZV],[cexVitrProc],[vsegoMat],[amortProc],[vsegoZP],[sumNalogov],[tzvGrn],[cehVitrGrn],[amortGrn],[vsego_F]" +
                     "FROM [Repairs].[dbo].[Vedomost_Resursov]" +
                     "where YEAR(PeriodData2)='" + rgod + "' and  MONTH(PeriodData2)='" + rmes + "' and Ispolnitel_codcx='" + nceh + "' ", con);
                if (rmes.Length == 1)
                {
                    rmes = "0" + rmes;
                }
                string remusl = "rem";
                DataTable tab = new DataTable();
                da.Fill(tab); //Загрузка в DataTable
                if (Convert.ToInt32(tab.Rows.Count) > 0)
                {
                    for (int ii = 0; ii < tab.Rows.Count; ii++)
                    {
                        string vsego_F;
                        double VsegoMat;
                        double df9;
                        double VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV;
                        try
                        {
                            //string vsego_F="";
                            int ID = Convert.ToInt32(tab.Rows[ii][0].ToString());
                            // Высчитываем общую сумму всех материалов 'по ведомости ресурсов по ОС' из табл.ReplacedPart
                            DAL dal = new DAL();
                            double Sum_mater = 0;
                            Sum_mater=Math.Round(dal.sum_mater(ID),2);
                            VsegoMat = Sum_mater;
                            df9 = Math.Round(VsegoMat,2);
                            

                            ////if (String.IsNullOrEmpty(txtBx_VsegoZP.Text))
                            if (String.IsNullOrEmpty(tab.Rows[ii][16].ToString()))
                                VsegoZP = 0.00;
                            else
                            {
                            //   // txtBx_VsegoZP.Text = txtBx_VsegoZP.Text.Replace(".", ","); // Замена точки на запятую
                                VsegoZP = Convert.ToDouble(tab.Rows[ii][16].ToString());
                            }

                            if (String.IsNullOrEmpty(tab.Rows[ii][17].ToString()))
                                SumNalogov = 0.00;
                            else
                            {
                                //txtBx_SumNalogov.Text = txtBx_SumNalogov.Text.Replace(".", ","); // Замена точки на запятую
                                SumNalogov = Convert.ToDouble(tab.Rows[ii][17].ToString());
                            }
                            if (String.IsNullOrEmpty(tab.Rows[ii][13].ToString()))
                                CexVitrProc = 0.00;
                            else
                            {
                            //    txtBx_CexVitrProc.Text = txtBx_CexVitrProc.Text.Replace(".", ","); // Замена точки на запятую
                                CexVitrProc = Convert.ToDouble(tab.Rows[ii][13].ToString());
                            }

                            if (String.IsNullOrEmpty(tab.Rows[ii][15].ToString()))
                                AmortProc = 0.00;
                            else
                            {
                            //    //txtBx_AmortProc.Text = txtBx_AmortProc.Text.Replace(".", ","); // Замена точки на запятую
                                AmortProc = Convert.ToDouble(tab.Rows[ii][15].ToString());
                            }

                            if (String.IsNullOrEmpty(tab.Rows[ii][12].ToString()))
                                TZV = 0.00;
                            else
                            {
                            //    //txtBx_TZV.Text = txtBx_TZV.Text.Replace(".", ","); // Замена точки на запятую
                                TZV = Convert.ToDouble(tab.Rows[ii][12].ToString());
                            }

                                double df10 = 0;
                                double df1 = 0;
                                double df6 = 0;
                                double df7 = 0;

                                if (nceh == "54")
                                {
                                    df10 = Math.Round(VsegoMat * TZV / 100, 2);
                                    if (VsegoZP == 0 || VsegoZP == null)
                                        df1 = 0;
                                    else
                                        df1 = Math.Round(SumNalogov / VsegoZP * 100, 2);

                                    df6 = 0;
                                    df7 = 0;


                                    //if (Convert.ToDateTime(lbl_data2.Text).Year < 2018)
                                    //{
                                    //    df6 = Math.Round((VsegoZP + SumNalogov + df9) + Math.Round(df10*CexVitrProc / 100, 2),2);
                                    //    df7 = Math.Round((VsegoZP + SumNalogov + df9) + Math.Round(df10 * AmortProc / 100, 2), 2);
                                    //}
                                    //else
                                    //{
                                    df6 = Math.Round(VsegoZP * CexVitrProc / 100, 2);
                                    df7 = Math.Round(VsegoZP * AmortProc / 100, 2);
                                    // }


                                    //txtBx_CexVitrGrn.Text = df6.ToString();
                                    //txtBx_AmortGrn.Text = df7.ToString();
                                    //txtBx_VidrahProc.Text = df1.ToString();
                                    //txtBx_TZVGrn.Text = df10.ToString();
                                    //txtBx_TZV.Text = TZV.ToString();

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
                                    //txtBx_CexVitrGrn.Text = df6.ToString();
                                    //txtBx_AmortGrn.Text = df7.ToString();
                                    //txtBx_VidrahProc.Text = df1.ToString();
                                    //txtBx_TZVGrn.Text = df10.ToString();

                                }

                                vsego_F = (VsegoZP + SumNalogov + VsegoMat + df10 + df6 + df7).ToString();
                               // теперь записываем в ведомость ресурсов наши расчёты
                                if (DAL.UpdateVedResAKT_ZP2(tab.Rows[ii][0].ToString(), df6, df7, df1, df10, Convert.ToDouble(vsego_F),VsegoMat) == true)
                                {
                                    // MessageBox.Show("Інформацію по процентам(1) Збережено.");
                                    //this.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    //MessageBox.Show("Помилка в збережені(1) процентів.");
                                    //this.DialogResult = DialogResult.Cancel;
                                }   


                        }
                        catch { };
                    }
                }
                //**************

                DAL.UpdateVedRes_with_nol("amortProc");
                DAL.UpdateVedRes_with_nol("cexVitrProc");

                MessageBox.Show("Перерахування виконано!");
            }
            else
            {
               
                
                
//update Vedomost_Resursov set amortProc=0 where amortProc is null 
//update Vedomost_Resursov set cexVitrProc=0 where cexVitrProc is null 
                MessageBox.Show("Відміна");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nceh = label2.Text.Trim();
            string namceh = label3.Text.Trim();
            string rmes = label5.Text.Trim();
            string rgod = label6.Text.Trim();

            myFrmProsmDannie_Aktov myFrmProsmDannie_Aktov = new myFrmProsmDannie_Aktov(rmes,rgod,nceh,namceh);
            myFrmProsmDannie_Aktov.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label5.Text) == 12)
            {
                label5.Text = "01";
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            else
            {
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                label6.Text = (Convert.ToInt32(label6.Text)).ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label5.Text) == 1)
            {
                label5.Text = "12";
                label6.Text = (Convert.ToInt32(label6.Text) - 1).ToString();
            }
            else
            {
                label5.Text = (Convert.ToInt32(label5.Text) - 1).ToString();
                label6.Text = (Convert.ToInt32(label6.Text)).ToString();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtBx_nuth.Text="";
            txtBx_nbrig.Text="";
            txtBx_nuth.Enabled = false;
            txtBx_nbrig.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtBx_nuth.Text = "";
            txtBx_nbrig.Text = "";
            txtBx_nuth.Enabled = true;
            txtBx_nbrig.Enabled = false;
            txtBx_nuth.Select();

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtBx_nuth.Text = "";
            txtBx_nbrig.Text = "";
            txtBx_nuth.Enabled = true;
            txtBx_nbrig.Enabled = true;
            txtBx_nuth.Select();
        }

    }
}
