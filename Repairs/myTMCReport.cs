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
    public partial class myTMCReport : Form
    {
        private string user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;
        DAL_DBF dal_dbf = new DAL_DBF();

        private void cmb_reportBoy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myTMCReport_Load(object sender, EventArgs e)
        {

        }

        public myTMCReport(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
                user_n = usern;
            user_p = userp;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig; 
            cod_det = coddet;
            InitializeComponent();
            ArrayList AllTMC = dal_dbf.GetAllTMC();
            //dgv_m_kart.DataSource = AllTMC;
            //if (dgv_m_kart.RowCount > 0){

            //    SettingsM_kart();
            //}

            cmb_reportBoy.DataSource = dal_dbf.GetAllReportBoy();
            cmb_reportBoy.DisplayMember = "fulname";
            cmb_reportBoy.ValueMember = "fulcode";
          // MessageBox.Show(cmb_reportBoy.ValueMember.ToString(););

           // MessageBox.Show(dostup_tmc + " " + codcx + " " + coduth + " " + codbrig + " " + coddet);
        }

        public void SettingsM_kart() {
            //dgv_m_kart.Columns["NAMEDET"].Visible = false;
            //dgv_m_kart.Columns["CODCX"].Visible = false;
            //dgv_m_kart.Columns["CODUTH"].Visible = false;
            //dgv_m_kart.Columns["CODBRIG"].Visible = false;
            //dgv_m_kart.Columns["CODDET"].Visible = false;
            dgv_m_kart.Columns["CODCX1"].Visible = false;
            dgv_m_kart.Columns["CODUTH1"].Visible = false;
            dgv_m_kart.Columns["CODBRIG1"].Visible = false;
            dgv_m_kart.Columns["CODDET1"].Visible = false; 
            dgv_m_kart.Columns["shpz"].Visible = false;

            //panel1.Font.Size = 8;
        
        
        }


        public void SettingsM_kart1()
        {
            //dgv_m_kart.Columns["NAMEDET"].Visible = false;
            //dgv_m_kart.Columns["CODCX"].Visible = false;
            //dgv_m_kart.Columns["CODUTH"].Visible = false;
            //dgv_m_kart.Columns["CODBRIG"].Visible = false;
            //dgv_m_kart.Columns["CODDET"].Visible = false;
            dgv_m_kart.Columns["CODCX1"].Visible = false;
            dgv_m_kart.Columns["CODUTH1"].Visible = false;
            dgv_m_kart.Columns["CODBRIG1"].Visible = false;
            dgv_m_kart.Columns["CODDET1"].Visible = false;
            dgv_m_kart.Columns["shpz"].Visible = false;
            dgv_m_kart.Columns["ZAVNOM"].Visible = true;

            dgv_m_kart.Columns["EDNOME"].HeaderText = "Номер";
            dgv_m_kart.Columns["DATSHOP"].HeaderText = "Дата поступления";
            dgv_m_kart.Columns["DATA"].HeaderText = "Дата поступления на участок";
            dgv_m_kart.Columns["NAME"].HeaderText = "Наименование";
            dgv_m_kart.Columns["MERA"].HeaderText = "Ед.Изм";
            dgv_m_kart.Columns["PRACE"].HeaderText = "Цена";
            dgv_m_kart.Columns["KOL"].HeaderText = "Кол-во";
            dgv_m_kart.Columns["ZAVNOM"].HeaderText = "Заводской №";

            dgv_m_kart.Columns["Name"].Width = 400;

            dgv_m_kart.Columns["EDNOME"].Width = 60;
            dgv_m_kart.Columns["DATSHOP"].Width = 90;
            dgv_m_kart.Columns["DATA"].Width = 90;

            dgv_m_kart.Columns["NAMEDET"].Width = 1;
            dgv_m_kart.Columns["CODCX"].Width = 1;
            dgv_m_kart.Columns["CODUTH"].Width = 1;
            dgv_m_kart.Columns["CODBRIG"].Width = 1;
            dgv_m_kart.Columns["CODDET"].Width = 1;
            dgv_m_kart.Columns["MERA"].Width = 60;
            dgv_m_kart.Columns["ZAVNOM"].Width = 120;

            dgv_m_kart.Columns["KOL"].DefaultCellStyle.Format="#0.000000"; // формат колонки
            
        }






        private void cmb_reportBoy_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_reportBoy.SelectedValue.ToString());
        }

        private void btn_searchTMC_Click(object sender, EventArgs e)
        {
          //  cmb_reportBoy.

          //  ArrayList AllTMC = dal_dbf.GetAllTMC();
          //  dgv_m_kart.DataSource = AllTMC;
          //  string a =  cmb_reportBoy.SelectedValue.ToString();
            try
            {
              //  MessageBox.Show(cmb_reportBoy.SelectedValue.ToString());
                ArrayList AllTMCforGuys = dal_dbf.GetAllTMCforGuys(cmb_reportBoy.SelectedValue.ToString());
                
                dgv_m_kart.DataSource = AllTMCforGuys;
                if (dgv_m_kart.RowCount > 0){
                    SettingsM_kart1();
                }



            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_m_kart.RowCount > 0)
            {


                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.RepairOSConnStr))
                {
                    try
                    {

                        conn.Open();


                        //Удаляем таблицу подотчета и шапку для печати отчета
                        SqlCommand cmd1 = new SqlCommand("DeleteReportTMCMOL", conn);
                        cmd1.CommandType = CommandType.StoredProcedure;
         
                        cmd1.ExecuteNonQuery();



                        //заполняем шапку списка материалов на подотчете

                        SqlCommand cmd2 = new SqlCommand("New ReportTMCMOLShapka", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@cx", dgv_m_kart.CurrentRow.Cells["CODCX"].Value.ToString());
                        cmd2.Parameters.AddWithValue("@uch", dgv_m_kart.CurrentRow.Cells["CODUTH"].Value.ToString());
                        cmd2.Parameters.AddWithValue("@brig", dgv_m_kart.CurrentRow.Cells["CODBRIG"].Value.ToString());
                        cmd2.Parameters.AddWithValue("@det", dgv_m_kart.CurrentRow.Cells["CODDET"].Value.ToString());
                        cmd2.Parameters.AddWithValue("@name", dgv_m_kart.CurrentRow.Cells["NAMEDET"].Value.ToString());
                        cmd2.ExecuteNonQuery();




                        for (int i = 0; i < dgv_m_kart.RowCount; i++)
                        {
                            //заполняем таблицу для отчета
                            SqlCommand cmd3 = new SqlCommand("New ReportTMCMOL", conn);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@Date1", Convert.ToDateTime(dgv_m_kart.Rows[i].Cells["DATSHOP"].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@Date2", Convert.ToDateTime(dgv_m_kart.Rows[i].Cells["DATA"].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@Ednome", dgv_m_kart.Rows[i].Cells["EDNOME"].Value.ToString());
                            cmd3.Parameters.AddWithValue("@Name", dgv_m_kart.Rows[i].Cells["Name"].Value.ToString());
                            cmd3.Parameters.AddWithValue("@Mera", dgv_m_kart.Rows[i].Cells["Mera"].Value.ToString());
                            cmd3.Parameters.AddWithValue("@Kolvo1", Convert.ToDecimal(dgv_m_kart.Rows[i].Cells["Kol"].Value.ToString()));
                          //  cmd3.Parameters.AddWithValue("@Kolvo2", dgv_m_kart.Rows[i].Cells["Name"].Value.ToString());
                            cmd3.Parameters.AddWithValue("@Price", Convert.ToDecimal(dgv_m_kart.Rows[i].Cells["PRACE"].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@Zavnom", dgv_m_kart.Rows[i].Cells["ZAVNOM"].Value.ToString());
                            cmd3.ExecuteNonQuery();
                        }

                        myfrmPrintReportTMCMOL myfrmPrintReportTMCMOL = new myfrmPrintReportTMCMOL();
                        myfrmPrintReportTMCMOL.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }


            }
            else {
                MessageBox.Show("Печатать нечего");
            }
        }
    }
}
