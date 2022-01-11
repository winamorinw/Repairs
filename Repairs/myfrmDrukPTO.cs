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

namespace Repairs
{
    public partial class myfrmDrukPTO : Form
    {
        DAL_DBF dal_dbf = new DAL_DBF();
        DAL dal = new DAL();
        private string nceh,nuth,nbrig,ndet;



        public myfrmDrukPTO(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();
            //cmb_reportBoy.DataSource = dal_dbf.GetAllReportBoy();
            //cmb_reportBoy.DisplayMember = "fulname";
            //cmb_reportBoy.ValueMember = "fulcode";


            DTPbeg.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);

            int days = DateTime.DaysInMonth(DTPbeg.Value.Year, DTPbeg.Value.Month); // показівает количесво дней в месяце
            var dd2 = new DateTime(DTPbeg.Value.Year, DTPbeg.Value.Month, days);
            DTPend.Value = Convert.ToDateTime(dd2); // устанавливаем последнее число месяца


            //cmb_reportBoy.DataSource = dal.GetAllReportBoyZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            //cmb_reportBoy.DisplayMember = "fulname1";
            //cmb_reportBoy.ValueMember = "fulcode1";


            //cmb_reportCeh.DataSource = dal.GetAllReportCehZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            //cmb_reportCeh.DisplayMember = "fulname";
            //cmb_reportCeh.ValueMember = "fulcode";
            
            //cmb_reportBoy.SelectedValue = "1 1 1 1";
            //clickShowGrid();


            //cmb_reportBoy.DataSource = dal.GetAllReportBoyZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            //cmb_reportBoy.DisplayMember = "fulname";
            //cmb_reportBoy.ValueMember = "fulcode";

            //cmb_reportCeh.DataSource = dal.GetAllReportCehZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            //cmb_reportCeh.DisplayMember = "fulname";
            //cmb_reportCeh.ValueMember = "fulcode";



        }

        //public void cmb_reportBoy_zapolnenie(DateTime dat1,DateTime dat2)
        //{

        //    DataTable dt = new DataTable();
        //    SqlConnection con;
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da,dd;
        //    con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
        //    con.Open();
        //    //string query = (@"select distinct codcx,coduth,codbrig,coddet,FIO_MOL from PTO  order by codcx,coduth,codbrig,coddet where Data1pto =  " + dat1);
        //    //

        //    string query = (@"select distinct codcx,coduth,codbrig,coddet,FIO_MOL from PTO where Data1pto ='" + dat1.ToShortDateString() + "' order by codcx,coduth,codbrig,coddet");
        //    Debug.WriteLine(query.ToString());
        //    da = new SqlDataAdapter("select distinct codcx,coduth,codbrig,coddet,FIO_MOL from PTO where Data1pto ='" + dat1.ToShortDateString() + "' order by codcx,coduth,codbrig,coddet", con);
            

        //    //da = new SqlDataAdapter("select distinct codcx,coduth,codbrig,coddet,FIO_MOL from PTO  order by codcx,coduth,codbrig,coddet " , con);
            

        //    da.Fill(dt); //Загрузка данных о сотрудниках в DataTable
        //    for (int i = 0; i < dt.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
        //    {

        //        //cmb_reportBoy.Items.Add(dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString());//+ " " + dt.Rows[i][4].ToString());
        //        cmb_reportBoy.Items.Add(dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString()+ " " + dt.Rows[i][4].ToString());
        //        //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
        //    }
        //    da.Dispose();
        //    con.Close();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //DTPbeg.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);

            //int days = DateTime.DaysInMonth(DTPbeg.Value.Year, DTPbeg.Value.Month); // показівает количесво дней в месяце
            //var dd2 = new DateTime(DTPbeg.Value.Year, DTPbeg.Value.Month, days);
            //DTPend.Value = Convert.ToDateTime(dd2); // устанавливаем последнее число месяца
            ////this.btn_formuvPTO.Visible = false;
            //cmb_reportBoy.DataSource = dal.GetAllReportBoyZaPeriod(DTPbeg.ToString(), DTPbeg.ToString());
            //cmb_reportBoy.DisplayMember = "fulname";

            ////cmb_reportBoy.DataSource = 
            //////cmb_reportBoy_zapolnenie(DTPbeg.Value, DTPend.Value);
            ////cmb_reportBoy.DataSource = dal.GetAllReportBoyZaPeriod(DTPbeg.Value.ToShortDateString(),DTPend.Value.ToShortDateString());
            //////cmb_reportBoy.DisplayMember = "fulname";
            ////cmb_reportBoy.DisplayMember
            ////cmb_reportBoy.ValueMember = "fulcode";

            //////cmb_reportBoy.DataSource = dal_dbf.GetAllReportBoy();
            ////cmb_reportBoy.DisplayMember = "fulname";
            ////cmb_reportBoy.ValueMember = "fulcode";
        }




        private void clickShowGrid(string selectvalue)
        {
            //nceh = cmb_reportBoy.SelectedItem.ToString();
            //string vib = cmb_reportBoy.SelectedValue.ToString();
            DAL dal = new DAL();
            //ArrayList DanFind = new ArrayList();        

           

            Grid_Viev.DataSource = dal_dbf.GetDanReportBoy(cmb_reportBoy.SelectedValue.ToString());
            
            //string aa = cmb_reportBoy.SelectedItem.SelectedText.ToString();
            //string aa1 = cmb_reportBoy.SelectedValue.ToString();
            //Grid_Viev.DataSource = dal_dbf.GetDanReportBoy(cmb_reportBoy.SelectedItem.ToString());
            string ncodcx, ncoduth, ncodbrig, ncoddet, namedet, datbeg, datend;
            ncodcx = Grid_Viev.Rows[0].Cells["codcx"].Value.ToString(); // код цеха 
            ncoduth = Grid_Viev.Rows[0].Cells["coduth"].Value.ToString(); // код участка
            ncodbrig = Grid_Viev.Rows[0].Cells["codbrig"].Value.ToString(); // код  бригады
            ncoddet = Grid_Viev.Rows[0].Cells["coddet"].Value.ToString(); // код 
            namedet = Grid_Viev.Rows[0].Cells["namedet"].Value.ToString();
            datbeg = DTPbeg.Value.ToString("yyyyMMdd");
            datend = DTPend.Value.ToString("yyyyMMdd");
            // MessageBox.Show(dateTimePicker1.Value.ToShortDateString());


            dgvPTO.DataSource = dal.GetDanFromPTO(ncodcx, ncoduth, ncodbrig, ncoddet, datbeg, datend);
            // textBox1.Text=dal.GetDanFromPTO2(ncodcx, ncoduth, ncodbrig, ncoddet, datbeg, datend);// Для просмотра результата в текстбокс


            int k;
            if (dgvPTO.RowCount > 0)
            {
                string idPTO;
                idPTO = dgvPTO.Rows[0].Cells["idPTO"].Value.ToString();
                dgvPTOFromVedR.DataSource = dal.GetDanPTOFromVedR(idPTO);

                dgvPTO.Columns["IdPTO"].Visible = false;
                //dgvPTO.Columns["NomPTO"].Visible = true;
                //dgvPTO.Columns["Data1PTO"].Visible = true;
                //dgvPTO.Columns["Data2PTO"].Visible = true;
                dgvPTO.Columns["codcx"].Visible = false;
                dgvPTO.Columns["coduth"].Visible = false;
                dgvPTO.Columns["codbrig"].Visible = false;
                dgvPTO.Columns["coddet"].Visible = false;
                dgvPTO.Columns["FIO_Mol"].Visible = false;
                //dgvPTO.Columns["UserName"].Visible = false;
                //dgvPTO.Columns["Original"].Visible = false;

                dgvPTO.Columns["NomPTO"].HeaderText = "№ ПТЗ";
                dgvPTO.Columns["Data1PTO"].HeaderText = "З";
                dgvPTO.Columns["Data2PTO"].HeaderText = "По";

                dgvPTO.Columns["NomPTO"].Width = 100;
                dgvPTO.Columns["Data1PTO"].Width = 80;
                dgvPTO.Columns["Data2PTO"].Width = 80;



                dgvPTOFromVedR.Columns["IdPTO"].Visible = false;
                dgvPTOFromVedR.Columns["InventoryNamber"].Visible = true;
                dgvPTOFromVedR.Columns["NameOS"].Visible = true;
                ////dgvPTO.Columns["Data1PTO"].Visible = true;
                ////dgvPTO.Columns["Data2PTO"].Visible = true;
                //dgvPTOFromVedR.Columns["codcx"].Visible = false;
                //dgvPTOFromVedR.Columns["coduth"].Visible = false;
                //dgvPTO.Columns["codbrig"].Visible = false;
                //dgvPTO.Columns["coddet"].Visible = false;
                //dgvPTO.Columns["FIO_Mol"].Visible = false;
                ////dgvPTO.Columns["UserName"].Visible = false;
                ////dgvPTO.Columns["Original"].Visible = false;

                dgvPTOFromVedR.Columns["InventoryNamber"].HeaderText = "Інвентар.№";
                dgvPTOFromVedR.Columns["NameOS"].HeaderText = "Наазва";
                //dgvPTOFromVedR.Columns["Data2PTO"].HeaderText = "По";

                dgvPTOFromVedR.Columns["InventoryNamber"].Width = 80;
                dgvPTOFromVedR.Columns["NameOS"].Width = 250;

            }
            else
            {
                MessageBox.Show("За Вашим запитом нічого не знайдено!");
            }








            //if (dgvPTOFromVedR.RowCount > 0)
            //{

            //    dgvPTO.Select();
            //    if ((ncodcx.ToString() == "1" || (ncodcx.ToString() == "51" && ncoduth.ToString() == "1")) && (Environment.UserName.ToUpper().Trim() == "KUDINA_NI" || Environment.UserName.ToUpper().Trim() == "PISKUN_NA"))
            //    {

            //        this.button2.Visible = true;
            //        MessageBox.Show("true " + ncodcx.ToString() + "  " + ncoduth.ToString());
            //    }
            //    else
            //    {
            //        this.button2.Visible = false;
            //        MessageBox.Show("false " + ncodcx.ToString() + "  " + ncoduth.ToString());
            //    }



            //}
            //else
            //{
            //    this.button2.Visible = false;
            //}
        
        }













        private void clickShowGridCeh(string selectvalue)
        {
            //nceh = cmb_reportBoy.SelectedItem.ToString();
            //string vib = cmb_reportBoy.SelectedValue.ToString();
            DAL dal = new DAL();
            //ArrayList DanFind = new ArrayList();          
            //Grid_Viev.DataSource = cmb_reportCeh.SelectedItem.ToString();

            //string aa = cmb_reportBoy.SelectedItem.SelectedText.ToString();
            //string aa1 = cmb_reportBoy.SelectedValue.ToString();


            //Grid_Viev.DataSource = dal_dbf.GetDanReportBoy(cmb_reportBoy.SelectedItem.ToString());
            string ncodcx, datbeg, datend;
            //ncodcx = Grid_Viev.Rows[0].Cells["codcx"].Value.ToString(); // код цеха 
            ncodcx = selectvalue;//cmb_reportCeh.SelectedValue.ToString();
            datbeg = DTPbeg.Value.ToString("yyyyMMdd");
            datend = DTPend.Value.ToString("yyyyMMdd");
            // MessageBox.Show(dateTimePicker1.Value.ToShortDateString());


            dgvPTO.DataSource = dal.GetDanFromPTOCeh(ncodcx, datbeg.ToString(), datend.ToString());
            // textBox1.Text=dal.GetDanFromPTO2(ncodcx, ncoduth, ncodbrig, ncoddet, datbeg, datend);// Для просмотра результата в текстбокс

          
                int k;
                if (dgvPTO.RowCount > 0)
                {
                    string idPTO;
                    idPTO = dgvPTO.Rows[0].Cells["idPTO"].Value.ToString();
                    dgvPTOFromVedR.DataSource = dal.GetDanPTOFromVedR(idPTO);

                    dgvPTO.Columns["IdPTO"].Visible = false;
                    //dgvPTO.Columns["NomPTO"].Visible = true;
                    //dgvPTO.Columns["Data1PTO"].Visible = true;
                    //dgvPTO.Columns["Data2PTO"].Visible = true;
                    dgvPTO.Columns["codcx"].Visible = true;
                    dgvPTO.Columns["coduth"].Visible = true;
                    dgvPTO.Columns["codbrig"].Visible = true;
                    dgvPTO.Columns["coddet"].Visible = true;
                    dgvPTO.Columns["FIO_Mol"].Visible = true;
                    //dgvPTO.Columns["UserName"].Visible = false;
                    //dgvPTO.Columns["Original"].Visible = false;

                    dgvPTO.Columns["NomPTO"].HeaderText = "№ ПТЗ";
                    dgvPTO.Columns["Data1PTO"].HeaderText = "З";
                    dgvPTO.Columns["Data2PTO"].HeaderText = "По";
                    dgvPTO.Columns["codcx"].HeaderText = "";
                    dgvPTO.Columns["coduth"].HeaderText = "";
                    dgvPTO.Columns["codbrig"].HeaderText = "";
                    dgvPTO.Columns["coddet"].HeaderText = "";
                    dgvPTO.Columns["FIO_Mol"].HeaderText = "МВО";

                    dgvPTO.Columns["NomPTO"].Width = 40;
                    dgvPTO.Columns["Data1PTO"].Width = 70;
                    dgvPTO.Columns["Data2PTO"].Width = 70;
                    dgvPTO.Columns["codcx"].Width = 20;
                    dgvPTO.Columns["coduth"].Width = 20;
                    dgvPTO.Columns["codbrig"].Width = 20;
                    dgvPTO.Columns["coddet"].Width = 20;
                    dgvPTO.Columns["FIO_Mol"].Width = 200;



                    dgvPTOFromVedR.Columns["IdPTO"].Visible = false;
                    dgvPTOFromVedR.Columns["InventoryNamber"].Visible = true;
                    dgvPTOFromVedR.Columns["NameOS"].Visible = true;
                    ////dgvPTO.Columns["Data1PTO"].Visible = true;
                    ////dgvPTO.Columns["Data2PTO"].Visible = true;
                    //dgvPTOFromVedR.Columns["codcx"].Visible = false;
                    //dgvPTOFromVedR.Columns["coduth"].Visible = false;
                    //dgvPTO.Columns["codbrig"].Visible = false;
                    //dgvPTO.Columns["coddet"].Visible = false;
                    //dgvPTO.Columns["FIO_Mol"].Visible = false;
                    ////dgvPTO.Columns["UserName"].Visible = false;
                    ////dgvPTO.Columns["Original"].Visible = false;

                    dgvPTOFromVedR.Columns["InventoryNamber"].HeaderText = "Інвентар.№";
                    dgvPTOFromVedR.Columns["NameOS"].HeaderText = "Наазва";
                    //dgvPTOFromVedR.Columns["Data2PTO"].HeaderText = "По";

                    dgvPTOFromVedR.Columns["InventoryNamber"].Width = 80;
                    dgvPTOFromVedR.Columns["NameOS"].Width = 250;

                }
                else
                {
                    MessageBox.Show("За Вашим запитом нічого не знайдено!");
                }


           



            //if (dgvPTOFromVedR.RowCount > 0)
            //{

            //    dgvPTO.Select();
            //    if ((ncodcx.ToString() == "1" || (ncodcx.ToString() == "51" && ncoduth.ToString() == "1")) && (Environment.UserName.ToUpper().Trim() == "KUDINA_NI" || Environment.UserName.ToUpper().Trim() == "PISKUN_NA"))
            //    {

            //        this.button2.Visible = true;
            //        //MessageBox.Show("true " + ncodcx.ToString() + "  " + ncoduth.ToString());
            //    }
            //    else
            //    {
            //        this.button2.Visible = false;
            //        //MessageBox.Show("false " + ncodcx.ToString() + "  " + ncoduth.ToString());
            //    }



            //}
            //else
            //{
            //    this.button2.Visible = false;
            //}

        }

        //private void btn_formVedRes_Click(object sender, EventArgs e)
        //{
        //    //clickShowGrid();
        //}

     

     
   

        //private void dgvPTO_CurrentCellChanged(object sender, EventArgs e)
        //{
           


        //   }

        //private void dgvPTO_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        //{

        //}



        private void clickShowGridCeh2(string selectvalue, DateTime datbeg, DateTime  datend)
        {
            //nceh = cmb_reportBoy.SelectedItem.ToString();
            //string vib = cmb_reportBoy.SelectedValue.ToString();
            DAL dal = new DAL();
            //ArrayList DanFind = new ArrayList();          
            //Grid_Viev.DataSource = dal_dbf.GetDanReportBoy(selectvalue.ToString());

            ////string aa = cmb_reportBoy.SelectedItem.SelectedText.ToString();
            ////string aa1 = cmb_reportBoy.SelectedValue.ToString();


            ////Grid_Viev.DataSource = dal_dbf.GetDanReportBoy(cmb_reportBoy.SelectedItem.ToString());
            //string ncodcx, ncoduth, ncodbrig, ncoddet, snamedet, datbeg, datend;
            //ncodcx = Grid_Viev.Rows[0].Cells["codcx"].Value.ToString(); // код цеха 
            //ncoduth = Grid_Viev.Rows[0].Cells["coduth"].Value.ToString(); // код участка
            //ncodbrig = Grid_Viev.Rows[0].Cells["codbrig"].Value.ToString(); // код  бригады
            //ncoddet = Grid_Viev.Rows[0].Cells["coddet"].Value.ToString(); // код 
            //snamedet = Grid_Viev.Rows[0].Cells["namedet"].Value.ToString();
            //datbeg = DTPbeg.Value.ToString("yyyyMMdd");
            //datend = DTPend.Value.ToString("yyyyMMdd");
            // MessageBox.Show(dateTimePicker1.Value.ToShortDateString());

            //MessageBox.Show("hikuiuo");
            string dbeg = DTPbeg.Value.ToString("yyyyMMdd");
            string dend = DTPend.Value.ToString("yyyyMMdd");

            dgvPTO.DataSource = dal.GetDanFromPTOCeh(selectvalue.ToString(), dbeg.ToString(), dend.ToString());
            // textBox1.Text=dal.GetDanFromPTO2(ncodcx, ncoduth, ncodbrig, ncoddet, datbeg, datend);// Для просмотра результата в текстбокс

            
            
                int k;
                if (dgvPTO.RowCount > 0)
        
                {


                    

                        
               //     dgvPTO.Columns["RepairID"].Visible = false;
                    //dgvPTO.Columns["InventoryNamber"].Visible = true;
                    //dgvPTO.Columns["NameOs"].Visible = true;

                    string idPTO;
                    idPTO = dgvPTO.Rows[0].Cells["idPTO"].Value.ToString();
                    dgvPTOFromVedR.DataSource = dal.GetDanPTOFromVedR(idPTO);

                    dgvPTO.Columns["IdPTO"].Visible = false;
                    dgvPTO.Columns["codcx"].Visible = true;
                    dgvPTO.Columns["coduth"].Visible = true;
                    dgvPTO.Columns["codbrig"].Visible = true;
                    dgvPTO.Columns["coddet"].Visible = true;
                    dgvPTO.Columns["FIO_Mol"].Visible = true;

                    dgvPTO.Columns["NomPTO"].HeaderText = "№ ПТЗ";
                    dgvPTO.Columns["Data1PTO"].HeaderText = "З";
                    dgvPTO.Columns["Data2PTO"].HeaderText = "По";
                    dgvPTO.Columns["codcx"].HeaderText = "";
                    dgvPTO.Columns["coduth"].HeaderText = "";
                    dgvPTO.Columns["codbrig"].HeaderText = "";
                    dgvPTO.Columns["coddet"].HeaderText = "";
                    dgvPTO.Columns["FIO_Mol"].HeaderText = "МВО";

                    dgvPTO.Columns["NomPTO"].Width = 40;
                    dgvPTO.Columns["Data1PTO"].Width = 70;
                    dgvPTO.Columns["Data2PTO"].Width = 70;
                    dgvPTO.Columns["codcx"].Width = 20;
                    dgvPTO.Columns["coduth"].Width = 20;
                    dgvPTO.Columns["codbrig"].Width = 20;
                    dgvPTO.Columns["coddet"].Width = 20;
                    dgvPTO.Columns["FIO_Mol"].Width = 200;

                    dgvPTOFromVedR.Columns["IdPTO"].Visible = false;
                    dgvPTOFromVedR.Columns["InventoryNamber"].Visible = true;
                    dgvPTOFromVedR.Columns["NameOS"].Visible = true;

                    dgvPTOFromVedR.Columns["InventoryNamber"].HeaderText = "Інвентар.№";
                    dgvPTOFromVedR.Columns["NameOS"].HeaderText = "Наазва";

                    dgvPTOFromVedR.Columns["InventoryNamber"].Width = 80;
                    dgvPTOFromVedR.Columns["NameOS"].Width = 250;

                }
                else
                {
                    MessageBox.Show("За Вашим запитом нічого не знайдено!");
                }
            






            //if (dgvPTOFromVedR.RowCount > 0)
            //{

            //    dgvPTO.Select();
            //    if ((ncodcx.ToString() == "1" || (ncodcx.ToString() == "51" && ncoduth.ToString() == "1")) && (Environment.UserName.ToUpper().Trim() == "KUDINA_NI" || Environment.UserName.ToUpper().Trim() == "PISKUN_NA"))
            //    {

            //        this.button2.Visible = true;
            //        //MessageBox.Show("true " + ncodcx.ToString() + "  " + ncoduth.ToString());
            //    }
            //    else
            //    {
            //        this.button2.Visible = false;
            //        //MessageBox.Show("false " + ncodcx.ToString() + "  " + ncoduth.ToString());
            //    }



            //}
            //else
            //{
            //    this.button2.Visible = false;
            //}

        }





        private void btn_formDrukPTO_Click(object sender, EventArgs e)
        {
            string datBeg,datEnd,numberPTO,fullname;
            int idPTO;
            string podpis;
            int nRow;
            DateTime dateStart, DateFinish;


            if (dgvPTO.RowCount > 0)
            {
                idPTO = Convert.ToInt32(dgvPTO.CurrentRow.Cells["idPTO"].Value);
                dateStart = Convert.ToDateTime(dgvPTO.CurrentRow.Cells["Data1PTO"].Value);
                DateFinish = Convert.ToDateTime(dgvPTO.CurrentRow.Cells["Data2PTO"].Value);

                datBeg = dateStart.ToString("dd.MM.yyyy");
                datEnd = DateFinish.ToString("dd.MM.yyyy");
                numberPTO = dgvPTO.CurrentRow.Cells["NomPTO"].Value.ToString();
                if (radioButton1.Checked == true)
                {
                    fullname=cmb_reportBoy.SelectedValue.ToString();
                    podpis = ("___________________________________");
                    myfrmReportPTOPrint myfrmReportPTOPrint = new myfrmReportPTOPrint(idPTO, datBeg, datEnd, fullname, numberPTO);
                    myfrmReportPTOPrint.ShowDialog();

                }

                if (radioButton2.Checked == true)
                {
                    //fullname = dgvPTO.
                    fullname = dgvPTO.CurrentRow.Cells["codcx"].Value.ToString()+' '+ dgvPTO.CurrentRow.Cells["coduth"].Value.ToString()+' '+ dgvPTO.CurrentRow.Cells["codbrig"].Value.ToString()+' '+ dgvPTO.CurrentRow.Cells["coddet"].Value.ToString()+' '+ dgvPTO.CurrentRow.Cells["FIO_MOL"].Value.ToString();
                    podpis = ("___________________________________");
                    myfrmReportPTOPrint myfrmReportPTOPrint = new myfrmReportPTOPrint(idPTO, datBeg, datEnd, fullname, numberPTO);
                    myfrmReportPTOPrint.ShowDialog();

                }
                //podpis=("___________________________________");
                //myfrmReportPTOPrint myfrmReportPTOPrint = new myfrmReportPTOPrint(idPTO, datBeg, datEnd, fullname, numberPTO);
                //myfrmReportPTOPrint.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Не існує інформації.");
            }

        }

        private void dgvPTO_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DAL dal = new DAL();
            string idPTO;
            int nRow;
            if (dgvPTO.RowCount > 0)
            {
                nRow = dgvPTO.CurrentRow.Index;
                idPTO = dgvPTO.Rows[nRow].Cells["idPTO"].Value.ToString();
                //MessageBox.Show(strRow);
                dgvPTOFromVedR.DataSource = dal.GetDanPTOFromVedR(idPTO);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string datBeg, datEnd, numberPTO, fullname;
            int idPTO;
            //string podpis;
            //int nRow;
            //DateTime dateStart, DateFinish;


            if (dgvPTO.RowCount > 0)
            {
                idPTO = Convert.ToInt32(dgvPTO.CurrentRow.Cells["idPTO"].Value);
                //dateStart = Convert.ToDateTime(dgvPTO.CurrentRow.Cells["Data1PTO"].Value);
                //DateFinish = Convert.ToDateTime(dgvPTO.CurrentRow.Cells["Data2PTO"].Value);

                //datBeg = dateStart.ToString("dd.MM.yyyy");
                //datEnd = DateFinish.ToString("dd.MM.yyyy");
                //numberPTO = dgvPTO.CurrentRow.Cells["NomPTO"].Value.ToString();
                //fullname = cmb_reportBoy.SelectedValue.ToString();
                //podpis = ("___________________________________");

                //MessageBox.Show(idPTO.ToString() + "  " + datBeg + " " + datEnd + "    " + numberPTO);

                
                ReportPTO_VozvrDetPrint ReportPTO_VozvrDetPrint = new ReportPTO_VozvrDetPrint(idPTO);
                ReportPTO_VozvrDetPrint.ShowDialog();
                    //myfrmReportPTOPrint.ShowDialog();

            }
            else
            {
                MessageBox.Show("Не існує інформації.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string message = "Дійсно вилучити ВТО? ";
            //+ dgv_Repair.CurrentRow.Cells["InventoryNumber"].Value.ToString() +
            //"  " + dgv_Repair.CurrentRow.Cells["Name"].Value.ToString();
            const string caption = "Уважно подумай!!!";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                //string can_del = "no";
                int rabmes = 0;
                int rabgod = 0;
                //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
                SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");

                cn.Open();
                SqlCommand cm0 = new SqlCommand(" SELECT mes FROM [Repairs].[dbo].[Status_mes_ceh] where storeid=" + Grid_Viev.Rows[0].Cells["codcx"].Value.ToString(), cn);
                Debug.WriteLine(cm0.CommandText);
                rabmes = Convert.ToInt32(cm0.ExecuteScalar());

                SqlCommand cm2 = new SqlCommand(" SELECT god FROM [Repairs].[dbo].[Status_mes_ceh] where storeid=" + Grid_Viev.Rows[0].Cells["codcx"].Value.ToString(), cn);
                Debug.WriteLine(cm2.CommandText);
                rabgod = Convert.ToInt32(cm2.ExecuteScalar());

                cn.Close();



                // Определяем по текущей строчке месяц и год по Data2PTO
                DateTime DateFinish = Convert.ToDateTime(dgvPTO.CurrentRow.Cells["Data2PTO"].Value);
                string datEnd = DateFinish.ToString("dd.MM.yyyy");

                string monthEnd = datEnd.ToString().Substring(3, 2);
                string yearEnd = datEnd.ToString().Substring(6, 4);

                //MessageBox.Show("по тек записи "+(Convert.ToInt32(monthEnd)).ToString()+"мес "+Convert.ToInt32(yearEnd).ToString()+"год     В статусах: "+Convert.ToInt32(rabmes).ToString()+"мес "+Convert.ToInt32(rabgod).ToString()+"год");


                //Сравниваем рабочий месяц, год с месяцем,годом на текущей строке. Если они равны, то можно  удалить ПТО
                if (Convert.ToInt32(rabmes).ToString() == Convert.ToInt32(monthEnd).ToString() && Convert.ToInt32(rabgod).ToString() == Convert.ToInt32(yearEnd).ToString())
                {
                    MessageBox.Show("Вилучати можна. ");
                    //    can_del = "no";


                    int id_pto;
                    cn.Open();

                    // Определяем idpto
                    SqlCommand cm3 = new SqlCommand(" select idpto from pto where nompto=" + dgvPTO.Rows[0].Cells["NomPTO"].Value.ToString() + " and data1pto=cast ('" + dgvPTO.Rows[0].Cells["data1pto"].Value.ToString() + "' as date ) and  data2pto=cast('" + dgvPTO.Rows[0].Cells["data2pto"].Value.ToString() + "' as date)", cn);
                    Debug.WriteLine(cm3.CommandText);
                    id_pto = Convert.ToInt32(cm3.ExecuteScalar());
                    cn.Close();
                    //MessageBox.Show("Не буде вилучено. Зверніться до програміста");
                    //MessageBox.Show("ID PTO=" + id_pto.ToString() + " " + cm3.CommandText.Trim() );
                    cn.Open();
                   //  Здесь надо раскомментировать
                    if (id_pto > 0)
                    {
                        SqlCommand cm4 = new SqlCommand("update Vedomost_Resursov set IdPTO=null where IdPTO='" + id_pto.ToString()+"'");
                       // Debug.WriteLine(cm4.CommandText);
                        try
                        {
                            if (cm4.ExecuteNonQuery() >= 1) 
                            {
                                string nompto = dgvPTO.Rows[0].Cells["NomPTO"].Value.ToString();
                                string d1 = Convert.ToDateTime(dgvPTO.Rows[0].Cells["data1pto"].Value.ToString()).ToShortDateString();
                                string d2 = Convert.ToDateTime(dgvPTO.Rows[0].Cells["data2pto"].Value.ToString()).ToShortDateString();
                              
                                SqlCommand cm42 = new SqlCommand("insert into [Repairs].[dbo].[edit_tables] ([komentar],[user],[dat_edit]) values ('del pto№ " + nompto + " d1=" + d1 + " d2=" + d2 + "','" + Environment.UserName.ToUpper().Trim() + "', cast ('" + DateTime.Now.ToString() + "' as datetime))");
                                try  // Записываем в протокол , что удаляем запись
                                {
                                    if (cm42.ExecuteNonQuery() >= 1)
                                    {
                                    }
                                }
                                catch (Exception)
                                {
                                }


                            }
                        }
                        catch (Exception)
                        {
                        }

                        // Удаляем ПТО
                        SqlCommand cm5 = new SqlCommand("delete from pto where idpto=" + id_pto.ToString());
                        Debug.WriteLine(cm5.CommandText);

                        try
                        {
                            if (cm5.ExecuteNonQuery() >= 1)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }


                    }
                    else
                    {
                        MessageBox.Show("Вилучення не виконано.");
                    }


                    cn.Close();


                }
                else
                {
                    string nompto = dgvPTO.Rows[0].Cells["NomPTO"].Value.ToString();
                    string d1 = Convert.ToDateTime(dgvPTO.Rows[0].Cells["data1pto"].Value.ToString()).ToShortDateString();
                    string d2 = Convert.ToDateTime(dgvPTO.Rows[0].Cells["data2pto"].Value.ToString()).ToShortDateString();
                    
                    // Записываем в протокол , что запись пытались удалить , но не удалили запись
                    SqlCommand cm43 = new SqlCommand("insert into [Repairs].[dbo].[edit_tables] ([komentar],[user],[dat_edit]) values ('otkazano del pto№ " + nompto + " d1=" + d1 + " d2=" + d2 + "','" + Environment.UserName.ToUpper().Trim() + "', cast ('" + DateTime.Now.ToString() + "' as datetime))");
                        try
                        {
                            if (cm43.ExecuteNonQuery() >= 1)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }


                        MessageBox.Show("Вилучення неможливе. Робочий місяць  " + rabmes.ToString() + " рік " + rabgod.ToString() );
                    //    can_del = "yes";
                }
            
            }
            else
            {
              //  MessageBox.Show("Нічого вилучати");

            }



            

       
            
            
        }

        private void cmb_reportBoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPTO.DataSource = null;
            dgvPTOFromVedR.DataSource = null;

            //try
            //{
            //   string selectvalue = cmb_reportBoy.SelectedValue.ToString();
            //    clickShowGrid(selectvalue.ToString());
            //}
            //catch
            //{
            //}

            //MessageBox.Show(cmb_reportBoy.SelectedValue.ToString());
        }

        private void DTPbeg_CloseUp(object sender, EventArgs e)
        {
            cmb_reportBoy.DataSource = dal.GetAllReportBoyZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            cmb_reportBoy.DisplayMember = "fulname";
            cmb_reportBoy.ValueMember = "fulcode";

            cmb_reportCeh.DataSource = dal.GetAllReportCehZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            cmb_reportCeh.DisplayMember = "fulname";
            cmb_reportCeh.ValueMember = "fulcode";

        }

        private void DTPend_CloseUp(object sender, EventArgs e)
        {
            cmb_reportBoy.DataSource = dal.GetAllReportBoyZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            cmb_reportBoy.DisplayMember = "fulname";
            cmb_reportBoy.ValueMember = "fulcode";

            cmb_reportCeh.DataSource = dal.GetAllReportCehZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            cmb_reportCeh.DisplayMember = "fulname";
            cmb_reportCeh.ValueMember = "fulcode";

        }

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ////dgvPTO.DataSource = null;
            ////dgvPTOFromVedR.DataSource = null;
            if (radioButton1.Checked == true)
            {
                cmb_reportBoy.Enabled = true;
                cmb_reportCeh.Enabled = false;

                cmb_reportBoy.DataSource = dal.GetAllReportBoyZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
                //cmb_reportBoy.DataSource = dal.GetAllReportBoy();
                cmb_reportBoy.DisplayMember = "fulname";
                cmb_reportBoy.ValueMember = "fulcode";
            }

            button3.Visible=true;
            button1.Visible = false;
            btn_formDrukPTO.Visible = false;
            button2.Visible = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
//            dgvPTO.DataSource = null;
//            dgvPTOFromVedR.DataSource = null;

            if (radioButton2.Checked == true)
            {
                cmb_reportBoy.Enabled = false;
                cmb_reportCeh.Enabled = true;

                cmb_reportCeh.DataSource = dal.GetAllReportCehZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
                cmb_reportCeh.DisplayMember = "fulname";
                cmb_reportCeh.ValueMember = "fulcode";


            //    comboBox1.DataSource = dal.GetAllReportCehZaPeriod(DTPbeg.Value.ToString(), DTPend.Value.ToString());
            //    comboBox1.DisplayMember = "fulname";
            //    comboBox1.ValueMember = "fulcode";
            }
            button3.Visible = true;
            button1.Visible = false;
            btn_formDrukPTO.Visible = false;
            button2.Visible = false;

        }

        private void cmb_reportCeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPTO.DataSource = null;
            dgvPTOFromVedR.DataSource = null;

            //try
            //{
            //    string selectvalue = cmb_reportCeh.SelectedValue.ToString();
            //    clickShowGridCeh(selectvalue.ToString());
            //}
            //catch
            //{
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    string selectvalue = cmb_reportBoy.SelectedValue.ToString();
                    clickShowGrid(selectvalue.ToString());
                    btn_formDrukPTO.Visible = true;
                    button1.Visible = true;
                   // button2.Visible = true;
                    switch (Environment.UserName.ToUpper().Trim()) // кнопка удаление доступна не всем
                    {
                        case "KUDINA_NI":
                        case "PISKUN_NA":
                        case "GRIGORIEVA_OL":
                            button2.Visible = true;
                            
                            break;
                        default:
                            {
                                button2.Visible = false;
                                break;
                            }
                    }

                }
                catch
                {
                    button2.Visible = false;
                }
            }

            if (radioButton2.Checked == true)
            {
                
                    string selectvalue = cmb_reportCeh.SelectedValue.ToString();
                    clickShowGridCeh2(selectvalue.ToString(), Convert.ToDateTime(DTPbeg.Value.ToString()), Convert.ToDateTime(DTPend.Value.ToString()));
                    btn_formDrukPTO.Visible = true;
                    button1.Visible = true;

                    button2.Visible = false;


            }

            dgvPTO.Select();
        }

        private void dgvPTO_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            DAL dal = new DAL();
            string idPTO;
            int nRow;
            if (dgvPTO.RowCount > 0)
            {
                nRow = dgvPTO.CurrentRow.Index;
                idPTO = dgvPTO.Rows[nRow].Cells["idPTO"].Value.ToString();
                //MessageBox.Show(strRow);
                dgvPTOFromVedR.DataSource = dal.GetDanPTOFromVedR(idPTO);
            }
        }

        private void DTPend_ValueChanged(object sender, EventArgs e)
        {

        }

            //if (radioButton2.Checked == true)
            //{


            //    try
            //    {
            //        string selectvalue = cmb_reportCeh.SelectedValue.ToString();
            //        clickShowGridCeh(selectvalue.ToString());
            //    }
            //    catch
            //    {
            //    }


            //}
            //button1.Visible = true;
            //btn_formDrukPTO.Visible = true;
 

        //}

      
     

    
    }
}
