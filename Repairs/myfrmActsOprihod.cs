using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Repairs
{
    public partial class myfrmActsOprihod : Form
    {
        DAL dal = new DAL();
        public myfrmActsOprihod()
        {
            InitializeComponent();
            dgv_allActs.DataSource = dal.GetAllActs();
            SettingsAllActs();
        }

        private void myfrmActsOprihod_Load(object sender, EventArgs e)
        {

        }
        private void SettingsAllActs() {
            if (dgv_allActs.RowCount > 0)
            {
                dgv_allActs.Columns["ID"].Visible = false;
                dgv_allActs.Columns["Original"].Visible = false;

                dgv_allActs.ReadOnly = false;
                for (int i = 0; i < dgv_allActs.RowCount; i++ )
                {
                    if (dgv_allActs.Rows[i].Cells["Original"].Value.ToString() == "0")
                    {
                        dgv_allActs.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                    }
                    else {
                        dgv_allActs.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                    
                    }
                }
                dgv_allActs.ReadOnly = true;

                dgv_allActs.Columns["FIO_Pred"].Visible = false;
                dgv_allActs.Columns["State_Pred"].Visible = false;
                dgv_allActs.Columns["FIO_Chlen1"].Visible = false;
                dgv_allActs.Columns["StateChlen1"].Visible = false;
                dgv_allActs.Columns["FIO_Chlen2"].Visible = false;
                dgv_allActs.Columns["StateChlen2"].Visible = false;

                dgv_allActs.Columns["NameOS"].HeaderText = "Найменування";
                dgv_allActs.Columns["InvNumberOS"].HeaderText = "Інв № ";
                dgv_allActs.Columns["date_doc"].HeaderText = "Дата Док";

                dgv_allActs.Columns["NameOS"].Width = 250;

            }


        
        }

        private void dgv_allActs_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_FIO_Pred.Text = dgv_allActs.CurrentRow.Cells["FIO_Pred"].Value.ToString();
            txt_dolj_pred.Text = dgv_allActs.CurrentRow.Cells["State_Pred"].Value.ToString();
            txt_FIO_Chlen1.Text = dgv_allActs.CurrentRow.Cells["FIO_Chlen1"].Value.ToString();
            txt_doljChlen1.Text = dgv_allActs.CurrentRow.Cells["StateChlen1"].Value.ToString();
            txt_Fio_Chlen2.Text = dgv_allActs.CurrentRow.Cells["FIO_Chlen2"].Value.ToString();
            txt_doljChlen2.Text = dgv_allActs.CurrentRow.Cells["StateChlen2"].Value.ToString();

            dgv_bu_Replace.DataSource = dal.GetBU_Rep_Part(dgv_allActs.CurrentRow.Cells["ID"].Value.ToString());
            SettingsBURepplace();


        }

        private void dgv_allActs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SettingsBURepplace() {
            if (dgv_bu_Replace.RowCount > 0)
            {
                dgv_bu_Replace.Columns["NameTMC"].HeaderText = "Найменування";
                dgv_bu_Replace.Columns["Ves_TMC"].HeaderText = "Вага";
                dgv_bu_Replace.Columns["ed_izm_TMC"].HeaderText = "Од. вим";
                dgv_bu_Replace.Columns["Kol-voTMC"].HeaderText = "Кіл-ть";
                dgv_bu_Replace.Columns["Proc_iznos"].HeaderText = "% зносу";
                dgv_bu_Replace.Columns["PriceNewTMC"].HeaderText = "Ст.Новогї ТМЦ";
                dgv_bu_Replace.Columns["PriceIznosTMC"].HeaderText = "Ціна зносу";
                dgv_bu_Replace.Columns["PriceTonnaMet"].HeaderText = "за вартістю мет";

                dgv_bu_Replace.Columns["NameTMC"].Width = 250;
            }
        }
        //Печать акта на оприходывание бу запчасти
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.RepairOSConnStr))
            {
                try
                {

                    conn.Open();
                    //заполняем шапку акта на оприходывание и подписи 
                    SqlCommand cmd1 = new SqlCommand("NewActOprihodBu_Act", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Act_ID", Convert.ToInt32(dgv_allActs.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd1.ExecuteNonQuery();
                    
                    //заполняем список запчастей на оприходывание

                    SqlCommand cmd2 = new SqlCommand("NewActOprihodBu_Details", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@Act_ID", Convert.ToInt32(dgv_allActs.CurrentRow.Cells["ID"].Value.ToString()));
                    cmd2.ExecuteNonQuery();

                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            myfrmReport_ActBuOprihod myfrmReport_ActBuOprihod = new myfrmReport_ActBuOprihod();
            myfrmReport_ActBuOprihod.ShowDialog();


        }



    }
}
