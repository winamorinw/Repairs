/* Changelog
 * 
 * Закрытие главной формы теперь вызывает диалог закрытия приложения.
 * Переместил дату и время в правую часть строки состояния.
 * Перевел на русский язык.
 * Сделал передачу параметров в создающиеся формы через конструкторы форм.
 * 
 * 
 */
// 1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection;
using System.Deployment.Application;

namespace Repairs
{
    
    public partial class frmMain : Form
    {

        SqlConnection cn = new SqlConnection();
        Form fmSearchClassDiseases;
        public string user_l;  //логин
        public string user_p;  //право доступа
        public string user_n;  //цех
        public string user_nam;//имя пользователя
        //public string ver_prog;//версия пргораммы
        

        public string dostup_tmc_;
        public string cod_cx;
        public string cod_uth;
        public string cod_brig;
        public string cod_det;
        public string kod_dostup_pr;
        public string ceh_dostup_pr;

        public string tek_mes;
        public string tek_god;

        DAL dal = new DAL();

        string constr = Properties.Settings.Default.RepairOSConnStr;

        private SqlConnectionStringBuilder sbConn;

        public static bool tryToEscape()
        {
            bool ret = true;
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit(); else ret = false;
            return ret;
        }
        public string customName = "";


        public frmMain()
        {
            InitializeComponent();

            
            try
            {
                var version = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                this.Text = $"Ремонты и ТО v.{String.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision)}";
            }
            catch (Exception ex)
            {
                var version = Assembly.GetExecutingAssembly().GetName().Version;
                this.Text = $"Ремонты и ТО v.{String.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision)}";
            }
            
            //проверка инициализации пользователя

            ArrayList users = new ArrayList();
            string username = Environment.UserName;
            if (username == "Vlasyuk_RV")
            {
                //username = "";// "Kharenko_AV";// "Danilenko_NV";
            }
            if (customName != "")
            {
                username = customName;
            }
            string query = string.Format(@"SELECT TOP 1000 [login_user] ,[name] ,[plot] ,[dostup] ,[dostup_tmc] ,[codcx] ,[coduth]  ,[codbrig]  ,[coddet], [kod_dostup_pr], [ceh_dostup_pr],[gosti],[dostup_akt]  FROM [Repairs].[dbo].[Users_list] where login_user = '{0}'", username);
            //string query = string.Format(@"SELECT TOP 1000 [login_user] ,[name] ,[plot] ,[dostup] ,[dostup_tmc] ,[codcx] ,[coduth]  ,[codbrig]  ,[coddet]  FROM [Repairs].[dbo].[Users_list] where login_user = 'Ryabets_GA'");
            //string query = string.Format(@"SELECT TOP 1000 [login_user] ,[name] ,[plot] ,[dostup] ,[dostup_tmc] ,[codcx] ,[coduth]  ,[codbrig]  ,[coddet]  FROM [Repairs].[dbo].[Users_list] where login_user = 'Potapova_AS'");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            users.Add(result);
                        }
                    }
                }
                catch { }
                if (users.Count > 0)
                {                    
                   // MessageBox.Show("Ура "+ Environment.UserDomainName + Environment.UserName + Environment.UserInteractive);
                    Dostup.Login_user = username;
                    cn.ConnectionString = Repairs.Properties.Settings.Default.RepairOSConnStr;
                    dgv_dostup.Visible = false;
                    
                    dgv_dostup.DataSource = dal.GetInfoDostup();
                    Dostup.Codcx = dgv_dostup.Rows[0].Cells["codcx"].Value.ToString();
                    Dostup.Coduth = dgv_dostup.Rows[0].Cells["coduth"].Value.ToString();
                    Dostup.Codbrig = dgv_dostup.Rows[0].Cells["codbrig"].Value.ToString();
                    Dostup.Coddet = dgv_dostup.Rows[0].Cells["coddet"].Value.ToString();
                    Dostup.Plot = dgv_dostup.Rows[0].Cells["plot"].Value.ToString();
                    Dostup.Name = dgv_dostup.Rows[0].Cells["name"].Value.ToString();
                    Dostup.Dostup1 = dgv_dostup.Rows[0].Cells["dostup"].Value.ToString();
                    Dostup.Dostup_tmc = dgv_dostup.Rows[0].Cells["dostup_tmc"].Value.ToString();
                    Dostup.Kod_dostup_pr = dgv_dostup.Rows[0].Cells["kod_dostup_pr"].Value.ToString();
                    Dostup.Ceh_dostup_pr = dgv_dostup.Rows[0].Cells["ceh_dostup_pr"].Value.ToString();
                    Dostup.Gosti = dgv_dostup.Rows[0].Cells["gosti"].Value.ToString();
                    Dostup.Dostup_akt = dgv_dostup.Rows[0].Cells["dostup_akt"].Value.ToString();
                    // Перевірка на доступні додаткові цеха для користувача і якщо вони є - дати вибір
                    var cehList = dal.GetUserAndAdditionalCeh(username);
                    if(cehList.Count > 1)
                    {
                        var additionalForm = new formChooseAdditionalCeh(cehList);
                        if (additionalForm.ShowDialog() == DialogResult.OK)
                        {
                            var row = (DbDataRecord)cehList[additionalForm.selectedIndex];
                            Dostup.Codcx = row[0].ToString();
                            Dostup.Coduth = row[1].ToString();
                            Dostup.Codbrig = row[2].ToString();
                            tslblMes.Text = $"{Dostup.Codcx} {Dostup.Coduth} {Dostup.Codbrig}";
                        }
                        else
                        {
                            MessageBox.Show(@"Ви не обрали цех!");
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@" У Вас не існують права доступу до цієі програми! 
Зверніться до служби підтримкм. тел.404-29-85   "  + Environment.UserName) ;
                    Environment.Exit(0);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Plot". При необходимости она может быть перемещена или удалена.
       
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Users_list". При необходимости она может быть перемещена или удалена.
            this.users_listTableAdapter.Fill(this.repairOSDS.Users_list);
            sbConn = new SqlConnectionStringBuilder();
            try
            {
                sbConn.ConnectionString = Repairs.Properties.Settings.Default.RepairOSConnStr;
                this.users_listTableAdapter.Fill(this.repairOSDS.Users_list);
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка!1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user_l = sbConn.UserID;
            /*
            string username = Environment.UserName;
            if (enableCustomName)
            {
                username = customName;
            }
            SqlDataAdapter sqlDA_ok2 = new SqlDataAdapter("SELECT plot, dostup, name, dostup_tmc, codcx, coduth, codbrig, coddet,kod_dostup_pr, ceh_dostup_pr  FROM Users_list WHERE login_user = '" + username + "'", cn);
            DataTable tab = new DataTable();
            sqlDA_ok2.Fill(tab);
            cn.Close();
            user_p = tab.Rows[0][1].ToString();
            user_n = tab.Rows[0][0].ToString();
            dostup_tmc_ = tab.Rows[0]["dostup_tmc"].ToString();
            cod_cx = tab.Rows[0]["codcx"].ToString();
            cod_uth = tab.Rows[0]["coduth"].ToString();
            cod_brig = tab.Rows[0]["codbrig"].ToString();
            cod_det = tab.Rows[0]["coddet"].ToString();
            kod_dostup_pr = tab.Rows[0]["kod_dostup_pr"].ToString();
            ceh_dostup_pr = tab.Rows[0]["ceh_dostup_pr"].ToString();

            user_nam = tab.Rows[0][2].ToString();
            tslblUser.Text = "Користувач: " + user_nam;
            tslblDate.Text ="Дата: " + DateTime.Now.ToShortDateString();
            */
            user_p = Dostup.Dostup1;
            
            user_n = Dostup.Plot;
            dostup_tmc_ = Dostup.Dostup_tmc;
            cod_cx = Dostup.Codcx;
            cod_uth = Dostup.Coduth;
            cod_brig = Dostup.Codbrig;
            cod_det = Dostup.Coddet;
            kod_dostup_pr = Dostup.Kod_dostup_pr;
            ceh_dostup_pr = Dostup.Ceh_dostup_pr;

            user_nam = Dostup.Name;
            tslblUser.Text = "Користувач: " + user_nam;
            tslblDate.Text = "Дата: " + DateTime.Now.ToShortDateString();

            Debug.Print(user_p + "\n" + dostup_tmc_ + "\n" + kod_dostup_pr + "\n" + ceh_dostup_pr + "\n" + user_nam + "\n");

            if (user_p == "1")
            {
                toolStripButton2.Visible = false;
            }
            else
                if (user_p == "2")
                {
                    toolStripButton1.Visible = false;
                }

            
                
            switch (Environment.UserName.ToUpper().Trim())
            {
                case "KUDINA_NI":
                case "RYABETS_GA":
                case "PARFELYUK_AS":
                //case "MOSIENKO_AV":
                //case "DANILENKO_NV":
                case "VELIKAYA_EM":
                case "POLUDEN_NV":
                case "PODBILSKAYA_AV":
                case "PISKUN_NA":
                case "GRIGORIEVA_OL":
                case "POSYPAJ_AV":
                case "KUZMINSKAYA_MA":
                case "VLASYUK_RV":
                    сервісToolStripMenuItem.Visible = true;
                    break;
                default:
                    {
                        сервісToolStripMenuItem.Visible = false;
                        break;
                    }

            }

            switch (Environment.UserName.ToUpper().Trim())
            {
                case "KUDINA_NI":
                //case "MOSIENKO_AV":
                case "DANILENKO_NV":
                //case "POLUDEN_NV":
                case "PODBILSKAYA_AV":
                case "VELIKAYA_EM":
                //case "PUZYRCHUK_SA":
                case "MALYSHKO_AI":
                case "RYABETS_GA":
                case "GRIGORIEVA_OL":
                case "PARFELYUK_AS":
                case "VIKHROVSKAYA_IZ":
                case "KUZMINSKAYA_MA":
                case "RUBANENKO_VV":
                case "BOYARSKIJ_DA":
                case "VLASYUK_RV":
                    формуванняПТЗToolStripMenuItem.Enabled = true;
                    break;
                default:
                    {
                        формуванняПТЗToolStripMenuItem.Enabled = false;
                        break;
                    }
            }
            switch (Environment.UserName.ToUpper().Trim())
            {
                case "GRIGORIEVA_OL":
                case "RUBANENKO_VV":
                case "KUZMINSKAYA_MA":
                case "POSYPAJ_AV":
                    переводМесяцаToolStripMenuItem.Visible = true;
                    break;
            }
            металобрухтToolStripMenuItem.Visible = false;
            додатковіЦехиToolStripMenuItem.Visible = false;
            
            if(! new string[] { "BOYARSKIJ_DA", "GRIGORIEVA_EA", "SKLYAROVA_OA" }.Contains(Environment.UserName.ToUpper().Trim()))
            {
                додатиКористувачаToolStripMenuItem.Visible = false;
            }
            if (Dostup.Dostup1 == "4" && Dostup.Dostup_tmc == "4")
            {
                металобрухтToolStripMenuItem.Visible = true;
            }
            if (Environment.UserName.ToUpper().Trim() == "PARFELYUK_AS" || Environment.UserName.ToUpper().Trim() == "BOYARSKIJ_DA")
            {
                переводМесяцаToolStripMenuItem.Visible = true;
                додатковіЦехиToolStripMenuItem.Visible = true;
            }
            int k_d_pr =0;
            if (Dostup.Kod_dostup_pr.Trim() == null ||Dostup.Kod_dostup_pr.Trim() =="")
                k_d_pr = 0;
            else
                k_d_pr = Convert.ToInt32(Dostup.Kod_dostup_pr);

            if (k_d_pr == 1 || k_d_pr == 2 || k_d_pr == 3 || k_d_pr == 4 || k_d_pr == 5 || k_d_pr == 10 || k_d_pr ==6 || k_d_pr == 1000) 
            {
                простоїToolStripMenuItem.Visible = true;


                switch (k_d_pr)
                {
                    
                    case 1: // gosti  tolko prosmotr
                        {
                            вводІнформаціїToolStripMenuItem.Visible = false;
                            продивитисьToolStripMenuItem.Visible = true;
                            break;
                        }
                    case 3: // mehanik
                    case 4: //energetik
                    case 5: //glavnij inzhener
                    case 6: // nach_shahti
                        {
                            вводІнформаціїToolStripMenuItem.Visible = false;
                            продивитисьToolStripMenuItem.Visible = true;
                            break;
                        }

                    case 2:
                    case 10: // Admin
                        {
                            вводІнформаціїToolStripMenuItem.Visible = true;
                            продивитисьToolStripMenuItem.Visible = true;
                            break;
                        }
                    case 1000: // True Admin
                        переводМесяцаToolStripMenuItem.Visible = true;
                        формуванняПТЗToolStripMenuItem.Enabled = true;
                        сервісToolStripMenuItem.Visible = true;
                        Dostup.Ceh_dostup_pr = "88";
                        break;
                    case 0:
                    default:
                        {
                            вводІнформаціїToolStripMenuItem.Visible = false;
                            продивитисьToolStripMenuItem.Visible = false;
                            break;
                        }

                }


            }
            else
            {
                простоїToolStripMenuItem.Visible= false;
                вводІнформаціїToolStripMenuItem.Visible = false;
                продивитисьToolStripMenuItem.Visible = false;

            }


            if (Dostup.Gosti == "1")  // для гостей только просмотр ремонтов и простоев
            {
                ремонтыToolStripMenuItem.Visible=false;
                отчетыToolStripMenuItem.Visible = true;
                люкиToolStripMenuItem.Visible = false;
                довидникиToolStripMenuItem.Visible = false;
                справкаToolStripMenuItem.Visible = false;
                актыToolStripMenuItem.Visible = false;
                аналитикаToolStripMenuItem.Visible = false;
                сервісToolStripMenuItem.Visible = false;
                простоїToolStripMenuItem.Visible = true;
                выходToolStripMenuItem.Visible = true;
                вводІнформаціїToolStripMenuItem.Visible = false;
                формуванняПТЗToolStripMenuItem.Visible = false;

                toolStripButton1.Visible=false;
                toolStripButton2.Visible=false;
                toolStripButton10.Visible=false;
                toolStripButton4.Visible=false;
                toolStripButton3.Visible=false;
                toolStripButton11.Visible=false;
                toolStripButton12.Visible=false;
                toolStripButton13.Visible = false;

                toolStripButton14.Visible = false;
                toolStripButton5.Visible = false;
                toolStripButton7.Visible = false;
                toolStripButton8.Visible = false;
                toolStripButton9.Visible = false;
                toolStripButton15.Visible = false;
                toolStripButton6.Visible =false ;
                tsbClose.Visible=false;

                металобрухтToolStripMenuItem.Visible = false;
            }

            DAL dal = new DAL();
            dgv_mes_god.DataSource = dal.TekMesGod();
            tek_mes = dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
            if (tek_mes.Length==1)
                tek_mes ="0"+dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
            tek_god = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();


            //tslblMes.Text = "Робочий місяць: " + tek_mes.ToString()+"-"+tek_god.ToString()+"p."; 25,11,2016 
            //tslblMes.Text = "Робочий місяць індивідуальний для кожного цеху";
            tslblMes.Text = "";
            //формуванняПТЗToolStripMenuItem.Enabled = true;

        }


        private void users_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.repairOSDS);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslblTime.Text = "Час: " + DateTime.Now.ToLongTimeString();
        }


        //обработчик кнопки выйти
         private void tsbClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ві дійсно бажаєте вийти?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) Application.Exit();
        }
        //нажатие ремонты
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmGetToRepair(user_l, user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det,tek_mes,tek_god);
                /*(fmSearchClassDiseases as frmGetToRepair).user_l = user_l;
                (fmSearchClassDiseases as frmGetToRepair).user_n = user_n;
                (fmSearchClassDiseases as frmGetToRepair).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //ремонты ОС
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
                {
                    MessageBox.Show("  1 ");
                    MessageBox.Show(user_n.ToString() + " " + user_p.ToString() + " " + dostup_tmc_.ToString() + " " + cod_cx.ToString() + 
                        " " + cod_uth.ToString() + " " + cod_brig.ToString() + " " + cod_det.ToString() + 
                        "user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det");
                    fmSearchClassDiseases = new frmCarriagesRepair(user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
                    /*(fmSearchClassDiseases as frmCarriagesRepair).user_n = user_n;
                    (fmSearchClassDiseases as frmCarriagesRepair).user_p = user_p;*/
                    MessageBox.Show("  2 ");
                    fmSearchClassDiseases.MdiParent = this;
                    fmSearchClassDiseases.ShowDialog();
                }
            }
            catch {
               
                MessageBox.Show("Ремонти");
            }
        }

        private void tsRepair_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //справочник цехов
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmStores(user_p);
                /*(fmSearchClassDiseases as frmStores).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //время работы оборудования 
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmWorkOS(user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det, tek_mes, tek_god);
                /*(fmSearchClassDiseases as frmWorkOS).user_n = user_n;
                (fmSearchClassDiseases as frmWorkOS).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //отчет по ремонтам
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmReport("main", user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
                /*(fmSearchClassDiseases as frmReport).frm = "main";*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //агрегатный журнал
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MyfrmAgrJournal myfrmAgrJournal = new MyfrmAgrJournal();
            myfrmAgrJournal.ShowDialog();
        }
        //отчет по запчастям
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmReportParts();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справочник ОС
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmOS(user_p);
                /*(fmSearchClassDiseases as frmOS).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справочник запчастей
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmParts();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //плановые работы
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmPlanRepairs(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
                /*(fmSearchClassDiseases as frmPlanRepairs).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //отчет по типовым работам
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmReportPlan();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справка
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Repairs_help.chm", HelpNavigator.TableOfContents);
        }

        /// <summary>
        /// Метод вызывается перед закрытием формы
        /// </summary>
        /// <param name="sender">object. Объект, вызвавший метод.</param>
        /// <param name="e">FormClosingEventArgs. Содержит свойства, показывающие причину закрытия и позволяющие отменить закрытие.</param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                //если причина закрытия - ручное закрытие формы, то вызывается подтверждение закрытия.
                if (!tryToEscape()) e.Cancel = true;
            //отмена закрытия если пользователь не подтвердил в диалогое.
        }
        //справочник типов ремонтов
        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmSprRefJob(user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //Справочник ремонтных узлов 
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmSprRefPlace(user_n, user_p);
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //отправка в ремонт
        private void tsmZmist_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                myfrmGetToRepairs myfrmGetToRepairs = new myfrmGetToRepairs(user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);

                myfrmGetToRepairs.ShowDialog();

                //fmSearchClassDiseases = new myfrmGetToRepair();
                ///*(fmSearchClassDiseases as frmGetToRepair).user_l = user_l;
                //(fmSearchClassDiseases as frmGetToRepair).user_n = user_n;
                //(fmSearchClassDiseases as frmGetToRepair).user_p = user_p;*/
                //fmSearchClassDiseases.MdiParent = this;
                //fmSearchClassDiseases.Show();
            }


           // Help.ShowHelp(this, "Repairs_help.chm", HelpNavigator.TableOfContents);
        }
        //люки
        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmHatch();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {

        }
        // Ремонты/ремонт ОС
        private void ремонтОСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            //    {
            //        fmSearchClassDiseases = new frmCarriagesRepair(user_n, user_p);
            //        /*(fmSearchClassDiseases as frmCarriagesRepair).user_n = user_n;
            //        (fmSearchClassDiseases as frmCarriagesRepair).user_p = user_p;*/
            //        fmSearchClassDiseases.MdiParent = this;
            //        fmSearchClassDiseases.Show();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Ремонты");
            //}


            myfrmCarriagesRepairs myfrmCarriagesRepairs = new myfrmCarriagesRepairs(user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            myfrmCarriagesRepairs.Show();
        }
        //Ремонт/плановые работы
        private void плановыеРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmPlanRepairs(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
                /*(fmSearchClassDiseases as frmPlanRepairs).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //время работы оборудования
        private void времяРаботыОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmWorkOS(user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det,tek_mes,tek_god);
                /*(fmSearchClassDiseases as frmWorkOS).user_n = user_n;
                (fmSearchClassDiseases as frmWorkOS).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справочники/цеха
        private void справочникЦеховToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmStores(user_p);
                /*(fmSearchClassDiseases as frmStores).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справочники/основные средства
        private void справочникОсновныхСредствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmOS(user_p);
                /*(fmSearchClassDiseases as frmOS).user_p = user_p;*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справочник/запчасти
        private void справочникЗапчастейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmParts();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справочник / типы ремонтов
        private void типыРемонтовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmSprRefJob(user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //справочник / ремонтные узлы
        private void ремонтныеУзлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmSprRefPlace(user_n, user_p);
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //отчеты / отчет по ремонтам
        private void отчетПоРемонтамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmReport("main", user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
                /*(fmSearchClassDiseases as frmReport).frm = "main";*/
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //отчеты / агрегатный журнал
        private void агрегатныйЖурналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyfrmAgrJournal myfrmAgrJournal = new MyfrmAgrJournal();
            myfrmAgrJournal.ShowDialog();

        }
        //отчеты / отчет по запчастям
        private void отчетПоЗапчастямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmReportParts();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //отчеты / отчет по типовым работам
        private void отчетПоТиповымРаботамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmReportPlan();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //люки 
        private void люкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
            {
                fmSearchClassDiseases = new frmHatch();
                fmSearchClassDiseases.MdiParent = this;
                fmSearchClassDiseases.Show();
            }
        }
        //ТМЦ 
        private void тМЦToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (fmSearchClassDiseases == null || fmSearchClassDiseases.IsDisposed)
           // {
            myTMCReport myTMCReport = new myTMCReport(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
             //   myTMCReport.MdiParent = this;
                  myTMCReport.Show();
            }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmHelp myfrmHelp = new myfrmHelp();
            myfrmHelp.ShowDialog();
        }

        private void ведомостьРесурсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //myfrmVedomostResursov myfrmVedomostResursov = new myfrmVedomostResursov();
            //myfrmVedomostResursov.ShowDialog(); 
        }

        private void актНаОприходываниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrm_AktOprihod myfrmActOprihod = new myfrm_AktOprihod();
            myfrmActOprihod.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви дійсно бажаєте вийти?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) Application.Exit();
        }

        private void актыНаОприходываниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmActsOprihod myfrmActsOprihod = new myfrmActsOprihod();
            myfrmActsOprihod.ShowDialog();

        }

        private void ведомостиРесуровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /////
            Change_ceh cc = new Change_ceh(tek_mes, tek_god);
            cc.ShowDialog();
        
            //myfrmAllVedomotsResursov myfrmAllVedomotsResursov = new myfrmAllVedomotsResursov(tek_mes, tek_god);
           // myfrmAllVedomotsResursov.ShowDialog();
        }

        private void ведомостьРесурсовToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            myfrmVedomostResursov myfrmVedomostResursov = new myfrmVedomostResursov(tek_mes, tek_god);
            myfrmVedomostResursov.ShowDialog(); 
        }

        private void поОСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmAnalitika myfrmAnalitika = new myfrmAnalitika();
            myfrmAnalitika.ShowDialog();
        }

        private void menuRepair_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчетПоТМЦToolStripMenuItem_Click(object sender, EventArgs e)
        {
      //   select* from Repair r  inner join ReplacedPart rp on r.RepairID = rp.RepairID where r.codcx = 50 and r.coduth = 2 and r.codbrig = 3 and
      // isnull(dateout,'99991231')>= '20160101'

        }
        //myfrmPTO myfmPTO;

        private void пТОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //myfrmPTO myfmPTO = new myfrmPTO(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            ////   myTMCReport.MdiParent = this;
            //myfmPTO.Show();

        }

        private void друкПТОToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //myfrmDrukPTO myfrmDrukPTO = new myfrmDrukPTO(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            //myfrmDrukPTO.ShowDialog();
        }

        private void формуванняПТЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmPTO myfmPTO = new myfrmPTO(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det,tek_mes, tek_god);
            //   myTMCReport.MdiParent = this;
            myfmPTO.Show();
        }

        private void друкПТЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmDrukPTO myfrmDrukPTO = new myfrmDrukPTO(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            myfrmDrukPTO.ShowDialog();
        }

        private void закритиРобочийМісяцьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        //   // MessageBox.Show(Dostup.Login_user);
        //    DAL dal = new DAL();
        //    //string tekmes = dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
        //    //string tekgod = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();

        //    DialogResult res = MessageBox.Show("Дійсно бажаєте закрити місяць " + tek_mes.ToString() + "-" + tek_god.ToString() + "p." , "Закриття місяця", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (res == DialogResult.Yes)
        //    {
        //         // MessageBox.Show("Yes");
        //          int nextmes =0 ;
        //          int nextgod =0 ;
                 
        //         switch (Convert.ToInt32(tek_mes.ToString()))
        //          {
        //             case 12:
        //                   nextmes = 1;
        //                   nextgod = (Convert.ToInt32(tek_god.ToString()) + 1);
        //                   break;
        //             case 1:
        //             case 2:
        //             case 3:
        //             case 4:
        //             case 5:
        //             case 6:
        //             case 7:
        //             case 8:
        //             case 9:
        //             case 10:
        //             case 11:
        //                   nextmes = (Convert.ToInt32(tek_mes.ToString()) + 1);
        //                   nextgod = Convert.ToInt32(tek_god.ToString()) ;
        //                    break;
        //          }

        //         int stroka = dal.NewZapisOpenMes(nextgod, nextmes);

        //         switch (stroka)
        //         { 
        //             case 0:
        //               //  MessageBox.Show("Добавляем строку новую");
        //                 int kolzap=dal.NewZapisOpenMes(nextgod, nextmes);
        //                 MessageBox.Show(kolzap.ToString());
        //                 if (kolzap==0)
        //                 {
        //                 //    MessageBox.Show("can Add");
        //                     if (dal.NewZapisInsertMes(nextgod, nextmes) == true)
        //                     {
        //                   //      MessageBox.Show("yes");
        //                     }
        //                     else
        //                     {
        //                      //   MessageBox.Show("Помилка11.Не додається.");
        //                     }


        //                 }
        //                 else
        //                 {
        //                  //   MessageBox.Show("Помилка12.Не додається.");
        //                 }

        //                 break;
        //             case 1:
        //                 //MessageBox.Show("Помилка13.Не додається.");
        //                    break;
        //             case 2:
        //                   // MessageBox.Show("Помилка14.Не додається.");
        //                    break;
                            
        //       }
        //    ////   //  MessageBox.Show(nextmes.ToString() + "   " + nextgod.ToString());

        //         if (dal.UpdateZakrMes(tek_god, tek_mes, nextgod, nextmes) == true)
        //         {
        //             //   MessageBox.Show("Місяць закрит!");
        //            // MessageBox.Show("Місяць " + tek_mes.ToString() + "   " + tek_god.ToString() + "p. закрит.");
        //         }
        //         else
        //         {
        //             MessageBox.Show("Помилка закриття місяця!");
        //         }

        //         if (dal.UpdateOpenMes(tek_god, tek_mes, nextgod, nextmes) == true)
        //         {
        //             // MessageBox.Show("Місяць відкрит!");
        //             MessageBox.Show("Місяць " + nextmes.ToString() + "   " + nextgod.ToString() + "p. відкрит.");
        //         }
        //         else
        //         {
        //             MessageBox.Show("Помилка відкриття місяця!");
        //         }

        //         dgv_mes_god.DataSource = dal.TekMesGod();
        //         tek_mes = dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
        //         tek_god = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();
        //         if (tek_mes.Length == 1)
        //             tek_mes = "0" + dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
        //         tek_god = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();

        //         tslblMes.Text = "Робочий місяць: " + tek_mes.ToString() + "-" + tek_god.ToString() + "p.";


        //}

        ////private void друкПТОToolStripMenuItem_Click(object sender, EventArgs e)
        ////{
        ////    myfmDrukPTO = new myfrmDrukPTO(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
        ////    //   myTMCReport.MdiParent = this;
        ////    myfmPTO.Show();
        ////}






        }

        private void відкритиМісяцьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////switch (Dostup.Login_user)
            ////{    case "kudina":
            ////     case "mosienko":
            ////        break;
            ////    default :
            ////        MessageBox.Show("У вас не існують права на відкриття місяця.");
            ////        break;
                 
            ////}
            
            
            //DAL dal = new DAL();
            //tek_mes = dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
            //tek_god = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();

            //DialogResult res = MessageBox.Show("Дійсно бажаєте відкрити попередній місяць? " , "Відкриття місяця", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (res == DialogResult.Yes)
            //{
            //    // MessageBox.Show("Yes");
            //    int nextmes = 0;
            //    int nextgod = 0;

            //    switch (Convert.ToInt32(tek_mes.ToString()))
            //    {
            //        case 1:
            //            nextmes = 12;
            //            nextgod = (Convert.ToInt32(tek_god.ToString()) - 1);
            //            break;
            //        case 2:
            //        case 3:
            //        case 4:
            //        case 5:
            //        case 6:
            //        case 7:
            //        case 8:
            //        case 9:
            //        case 10:
            //        case 11:
            //        case 12:
            //            nextmes = (Convert.ToInt32(tek_mes.ToString()) - 1);
            //            nextgod = Convert.ToInt32(tek_god.ToString());
            //            break;
            //    }

            //    int stroka = dal.NewZapisOpenMes(nextgod, nextmes);

            //    switch (stroka)
            //    {
            //        case 0:
            //           // MessageBox.Show("Добавляем строку новую");
            //            int kolzap = dal.NewZapisOpenMes(nextgod, nextmes);
            //            MessageBox.Show(kolzap.ToString());
            //            if (kolzap == 0)
            //            {
            //              //  MessageBox.Show("can Add");
            //                if (dal.NewZapisInsertMes(nextgod, nextmes) == true)
            //                {
            //                  //  MessageBox.Show("yes");
            //                }
            //                else
            //                {
            //                    //MessageBox.Show("Помилка1.Не додається.");
            //                }


            //            }
            //            else
            //            {
            //              //  MessageBox.Show("Не додається.");
            //            }

            //            break;
            //        case 1:
            //            //MessageBox.Show("Не додається.");
            //            break;
            //        case 2:
            //            //MessageBox.Show("Не додається.");
            //            break;

            //    }
            //    ////   //  MessageBox.Show(nextmes.ToString() + "   " + nextgod.ToString());

            //    if (dal.UpdateZakrMes(tek_god, tek_mes, nextgod, nextmes) == true)
            //    {
            //        //   MessageBox.Show("Місяць закрит!");
            //       // MessageBox.Show("Місяць " + tek_mes.ToString() + "   " + tek_god.ToString() + "p. закрит.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Помилка закриття місяця!");
            //    }

            //    if (dal.UpdateOpenMes(tek_god, tek_mes, nextgod, nextmes) == true)
            //    {
            //        // MessageBox.Show("Місяць відкрит!");
            //        MessageBox.Show("Місяць " + nextmes.ToString() + "   " + nextgod.ToString() + "p. відкрит.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Помилка відкриття місяця!");
            //    }

            //    dgv_mes_god.DataSource = dal.TekMesGod();
            //    tek_mes = dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
            //    tek_god = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();
            //    if (tek_mes.Length == 1)
            //        tek_mes = "0" + dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
            //    tek_god = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();
            //    tslblMes.Text = "Робочий місяць: " + tek_mes.ToString() + "-" + tek_god.ToString() + "p.";



            //}
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReport_Vip_Remonti frmReport_Vip_Remonti = new frmReport_Vip_Remonti(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            frmReport_Vip_Remonti.ShowDialog();

        }

        private void звітЗВідРесToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport_Zvit_Vip_Remonti_FromVedRes frmReport_Zvit_Vip_Remonti_FromVedRes = new frmReport_Zvit_Vip_Remonti_FromVedRes(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            frmReport_Zvit_Vip_Remonti_FromVedRes.ShowDialog();
        }

        private void звітПроВитраченийЧасНаВиконанняРемонтівТаТОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport_Zvit_Vitrach_Chas frmReport_Zvit_Vitrach_Chas = new frmReport_Zvit_Vitrach_Chas(user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            frmReport_Zvit_Vitrach_Chas.ShowDialog();
        }

        private void продивитисьСтатусиМісяцівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_change_year frm_change_year = new frm_change_year();
            frm_change_year.ShowDialog(); 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
         

        }

        private void актиПоПослугамToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void формуванняСпискаОЗПоПослугамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmFormAktUsl myfrmFormAktUsl = new myfrmFormAktUsl();
            myfrmFormAktUsl.ShowDialog(); 
        }

        private void неСписаніМетеріалиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void простоїToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вводІнформаціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmProstoi_Vvod myfrmVvodProstoi = new myfrmProstoi_Vvod("add","");
            myfrmVvodProstoi.ShowDialog();
        }

        private void продивитисьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfrmProstoi_Prosm myfrmProstoi_Prosm = new myfrmProstoi_Prosm();
            myfrmProstoi_Prosm.ShowDialog();

        }

        private void друкАктаФ2ТаДодатківПоРемонтамВиконанихПідряднимиОрганізаціямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFrm_AktF2_podrjadchiki myFrm_AktF2_podrjadchiki = new myFrm_AktF2_podrjadchiki();
            myFrm_AktF2_podrjadchiki.ShowDialog();
        }

        private void історіяРемонтуОЗЗаПеріодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportIstoriyaOS frmReportIstoriyaOS = new frmReportIstoriyaOS();
            frmReportIstoriyaOS.ShowDialog();

        }

        private void металобрухтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTypeMetallManager = new frmTypeMetallManager();
            frmTypeMetallManager.ShowDialog();
        }

        private void переводМесяцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCurrentMonthSelection formCurrentMonthSelection = new formCurrentMonthSelection();
            formCurrentMonthSelection.ShowDialog();
        }

        private void додатковіЦехиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new formAddRemoveAdditionalCeh();
            form.ShowDialog();
        }

        private void додатиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new formUsersListManager();
            form.ShowDialog();
        }
    }
}