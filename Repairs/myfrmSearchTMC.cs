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
using System.Data.Common;

namespace Repairs
{
    public partial class myfrmSearchTMC : Form
    {
        public bool CloseByButton = false;
        string constr = Properties.Settings.Default.RepairOSConnStr;
        public string tip_remusl = "";
        public string cceh = "0";
        public string cuth = "0";

        DAL dal = new DAL();
        public myfrmSearchTMC(string remusl, string ceh, string uth)
        {
            tip_remusl = remusl;
            cceh = ceh;
            cuth = uth;
            InitializeComponent();
            if (remusl == "rem")
            {
                dgv_AllTMC.DataSource = dal.GetAllTMC();
                button2.Visible = true;
                this.Text = "Выбор Основного средства";
                groupBox1.Text = "Список ОС";
            }

            if (remusl == "usl")
            {
                dgv_AllTMC.DataSource = dal.GetAllTMCUsl();
                button2.Visible = false;
                this.Text = "Выбор №";
                groupBox1.Text = "Список";
            }

            if (remusl == "1prostoi" || remusl == "5prostoi")
            {
                if (remusl == "1prostoi")
                    dgv_AllTMC.DataSource = dal.GetAllTMC_Prostoi(cceh, cuth);

                if (remusl == "5prostoi")
                    dgv_AllTMC.DataSource = dal.GetAllTMC_Prostoi(cceh, cuth);

                button2.Visible = true;
                this.Text = "Выбор Основного средства";
                groupBox1.Text = "Список ОС";
            }

            if (dgv_AllTMC.RowCount > 0)
            { SettingsAllOS(); }
            else
            {
                MessageBox.Show("У Вас нет ОС которые можно отправить в ремонт");
                this.Close();
            }
        }

        private void SettingsAllOS()
        {

            dgv_AllTMC.Columns["StoreId"].Visible = false;
            dgv_AllTMC.Columns["GroupOSCode"].Visible = false;
            dgv_AllTMC.Columns["Flag"].Visible = false;
            dgv_AllTMC.Columns["Hours_Beg"].Visible = false;
            dgv_AllTMC.Columns["CODUTH"].Width = 25;
            dgv_AllTMC.Columns["CODBRIG"].Width = 25;
            dgv_AllTMC.Columns["CODDET"].Width = 30;
            dgv_AllTMC.Columns["Obekt"].Width = 25;
            dgv_AllTMC.Columns["b_bal_cena"].Width = 80;
            dgv_AllTMC.Columns["InventoryNumber"].Width = 80;

            dgv_AllTMC.Columns["InventoryNumber"].HeaderText = "Инв. №";
            dgv_AllTMC.Columns["Name"].HeaderText = "Наименование";
            dgv_AllTMC.Columns["DateBeg"].HeaderText = "Дата ввода";
            dgv_AllTMC.Columns["CODUTH"].HeaderText = "Уч";
            dgv_AllTMC.Columns["CODBRIG"].HeaderText = "Бр";
            dgv_AllTMC.Columns["CODDET"].HeaderText = "мол";
            dgv_AllTMC.Columns["Obekt"].HeaderText = "Об";
            dgv_AllTMC.Columns["b_bal_cena"].HeaderText = "Остат.стоим.";

            dgv_AllTMC.Columns["CODUTH"].DisplayIndex = 0;
            dgv_AllTMC.Columns["CODBRIG"].DisplayIndex = 1;
            dgv_AllTMC.Columns["CODDET"].DisplayIndex = 2;
            dgv_AllTMC.Columns["Obekt"].DisplayIndex = 5;
            dgv_AllTMC.Columns["b_bal_cena"].DisplayIndex = 6;

            //dgv_AllTMC.Columns["Name"].Width = dgv_AllTMC.Width - dgv_AllTMC.Columns["InventoryNumber"].Width - dgv_AllTMC.Columns["DateBeg"].Width - 130 - 25;
            dgv_AllTMC.Columns["Name"].Width = 450;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Inv_Number.Inv_n = dgv_AllTMC.CurrentRow.Cells["InventoryNumber"].Value.ToString();
            Inv_Number.Inv_name = dgv_AllTMC.CurrentRow.Cells["Name"].Value.ToString();
            Inv_Number.Obekt = dgv_AllTMC.CurrentRow.Cells["Obekt"].Value.ToString();
            CloseByButton = true;
            this.Close();
        }
        //поиск по инвентарному номеру


        private void FilterRow_Changed(object sender, EventArgs e)
        {
            if ((tip_remusl == "rem" || tip_remusl == "1prostoi" || tip_remusl == "5prostoi") && (txt_Search.Text.Length >= 0 || txt_SearchName.Text.Length >= 0))
            {
                var result = Search(txt_Search.Text, txt_SearchName.Text);
                dgv_AllTMC.DataSource = result;
            }
            else if (tip_remusl == "usl" && txt_Search.Text.Length >= 1)
            {
                dgv_AllTMC.CurrentCell = null;
                for (int i = 0; i < dgv_AllTMC.Rows.Count; i++)
                {
                    if (dgv_AllTMC.Rows[i].Cells["Name"].Value.ToString().ToLower().Contains(txt_Search.Text.ToLower()))
                        dgv_AllTMC.Rows[i].Visible = true;
                    else
                        dgv_AllTMC.Rows[i].Visible = false;
                }
            }
            else
            {
                if (tip_remusl == "rem")
                {
                    dgv_AllTMC.DataSource = dal.GetAllTMC();
                }
                if (tip_remusl == "usl")
                {
                    dgv_AllTMC.DataSource = dal.GetAllTMCUsl();
                }
                if (tip_remusl == "1prostoi" || tip_remusl == "5prostoi")
                {
                    if (tip_remusl == "1prostoi")
                        dgv_AllTMC.DataSource = dal.GetAllTMC_Prostoi(cceh, cuth);

                    if (tip_remusl == "5prostoi")
                        dgv_AllTMC.DataSource = dal.GetAllTMC_Prostoi(cceh, cuth);

                }
            }
            if (dgv_AllTMC.Rows.Count > 0)
                SettingsAllOS();
        }
        public ArrayList Search(string filter1, string filter2)
        {
            ArrayList allTMC = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand();
                if (tip_remusl == "rem")
                {
                    string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, coduth, codbrig, coddet, Obekt,b_bal_cena FROM SprOS " +
                                        "where GroupOSCode !=75 and DateEnd ='18991230' and InventoryNumber like @inventory and Name like @name " + Dostup.AddQueryALLTMC() +
                                        " ORDER BY len(InventoryNumber), InventoryNumber, Name, StoreId, coduth, codbrig, coddet";
                    com = new SqlCommand(query, con);
                }
                else if(tip_remusl == "1prostoi" || tip_remusl == "5prostoi")
                {

                    string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, coduth, codbrig, coddet, Obekt,b_bal_cena FROM SprOS where DateEnd ='18991230'" +
                        "and InventoryNumber like @inventory and Name like @name and StoreId='" + cceh.ToString() + "' and CODUTH='" + cuth.ToString() + "' order by StoreId, coduth, codbrig, coddet";
                    com = new SqlCommand(query, con);
                }
                com.Parameters.AddWithValue("@inventory", "%" + filter1 + "%");
                com.Parameters.AddWithValue("@name", "%" + filter2 + "%");
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allTMC.Add(result);
                    con.Close();
                }
                catch { }
            }
            return allTMC;
        }


        private void myfrmSearchTMC_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string Inv_n = dgv_AllTMC.CurrentRow.Cells["InventoryNumber"].Value.ToString();
            string Obekt = dgv_AllTMC.CurrentRow.Cells["Obekt"].Value.ToString();
            string Inv_name = dgv_AllTMC.CurrentRow.Cells["Name"].Value.ToString();


            myfrmKolRem myfrmKolRem = new myfrmKolRem(Inv_n, Obekt, Inv_name);
            myfrmKolRem.ShowDialog();
        }

        private void myfrmSearchTMC_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (CloseByButton == true)
            {

            }
            else
            {
                Inv_Number.Inv_n = "";
                Inv_Number.Inv_name = "";
                Inv_Number.Obekt = "";
            }

        }


    }
}
