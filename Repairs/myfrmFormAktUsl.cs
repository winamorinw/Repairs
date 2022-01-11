using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Repairs
{
    public partial class myfrmFormAktUsl : Form
    {
        DAL dal = new DAL();
        public myfrmFormAktUsl()
        {
            InitializeComponent();
            dgv_os_usl.DataSource = dal.GetAllUslForDokument();
            Settings_all_usl();
        }

        private void myfrmFormAktUsl_Load(object sender, EventArgs e)
        {

        }

        private void Settings_all_usl()
        {
            if (dgv_os_usl.RowCount > 0)
            {
                dgv_os_usl.Columns["RepairID"].Visible = false;
                dgv_os_usl.Columns["InventoryNumber"].Visible = true;
                dgv_os_usl.Columns["Obekt"].Visible = true;
                dgv_os_usl.Columns["NameOs"].Visible = true;
                dgv_os_usl.Columns["Rdivision"].Visible = false;
                dgv_os_usl.Columns["Ispolnitel"].Visible = false;
                dgv_os_usl.Columns["CODCX"].Visible = true;
                dgv_os_usl.Columns["CODUTH"].Visible = true;
                dgv_os_usl.Columns["CODDET"].Visible = true;
                dgv_os_usl.Columns["CODBRIG"].Visible = true;
                dgv_os_usl.Columns["NAMEDET"].Visible = true;
                dgv_os_usl.Columns["Datein"].Visible = true;
                dgv_os_usl.Columns["Division"].Visible = true;
                dgv_os_usl.Columns["Dateout"].Visible = false;
                dgv_os_usl.Columns["Zakazchik"].Visible = true;

                dgv_os_usl.Columns["Inv_usl"].Visible = true;
                dgv_os_usl.Columns["Obekt_usl"].Visible = true;
                dgv_os_usl.Columns["name_inv_usl"].Visible = true;

                //dgv_os_usl.Columns["RepairID"].HeaderText ="";
                dgv_os_usl.Columns["InventoryNumber"].HeaderText = "Інв.№";
                dgv_os_usl.Columns["Obekt"].HeaderText = "Об'єкт";
                dgv_os_usl.Columns["NameOs"].HeaderText = "Найменування ";
                dgv_os_usl.Columns["Rdivision"].HeaderText = "";
                dgv_os_usl.Columns["Ispolnitel"].HeaderText ="";
                dgv_os_usl.Columns["CODCX"].HeaderText = "Цех виконавець";
                dgv_os_usl.Columns["CODUTH"].HeaderText = "";
                dgv_os_usl.Columns["CODDET"].HeaderText = "";
                dgv_os_usl.Columns["CODBRIG"].HeaderText = "";
                dgv_os_usl.Columns["NAMEDET"].HeaderText = "Підзвіт";
                dgv_os_usl.Columns["Datein"].HeaderText = "Дата відправки";
                dgv_os_usl.Columns["Division"].HeaderText = "Цех замовник";
                dgv_os_usl.Columns["Zakazchik"].HeaderText = "Найменування замовника";

                dgv_os_usl.Columns["Inv_usl"].HeaderText = "Інв.(послуга)";
                dgv_os_usl.Columns["Obekt_usl"].HeaderText = "об.(послуга)";
                dgv_os_usl.Columns["name_inv_usl"].HeaderText = "Назва інв.(послуга)";

                //dgv_os_usl.Columns["RepairID"].DisplayIndex = 0;
                dgv_os_usl.Columns["InventoryNumber"].DisplayIndex = 0;
                dgv_os_usl.Columns["Obekt"].DisplayIndex = 1;
                dgv_os_usl.Columns["NameOs"].DisplayIndex = 2;
                //dgv_os_usl.Columns["Rdivision"].DisplayIndex = 4;
                //dgv_os_usl.Columns["Ispolnitel"].DisplayIndex = 5;
                dgv_os_usl.Columns["CODCX"].DisplayIndex = 3;
                dgv_os_usl.Columns["CODUTH"].DisplayIndex = 4;
                dgv_os_usl.Columns["CODBRIG"].DisplayIndex = 5;
                dgv_os_usl.Columns["CODDET"].DisplayIndex = 6;
                dgv_os_usl.Columns["NAMEDET"].DisplayIndex = 7;
                dgv_os_usl.Columns["Datein"].DisplayIndex = 8;
                dgv_os_usl.Columns["Division"].DisplayIndex = 9;
                dgv_os_usl.Columns["Zakazchik"].DisplayIndex = 10;


                dgv_os_usl.Columns["RepairID"].Width = 30;
                dgv_os_usl.Columns["InventoryNumber"].Width = 50;
                dgv_os_usl.Columns["Obekt"].Width = 30;
                dgv_os_usl.Columns["NameOs"].Width = 350;
                dgv_os_usl.Columns["Rdivision"].Width = 20;
                dgv_os_usl.Columns["Ispolnitel"].Width = 20;
                dgv_os_usl.Columns["CODCX"].Width = 30;
                dgv_os_usl.Columns["CODUTH"].Width = 20;
                dgv_os_usl.Columns["CODDET"].Width = 20;
                dgv_os_usl.Columns["CODBRIG"].Width = 20;
                dgv_os_usl.Columns["NAMEDET"].Width = 250;
                dgv_os_usl.Columns["Datein"].Width = 80;
                dgv_os_usl.Columns["Division"].Width = 30;
                dgv_os_usl.Columns["Zakazchik"].Width = 200;

                dgv_os_usl.Columns["Inv_usl"].Width = 65;
                dgv_os_usl.Columns["Obekt_usl"].Width = 25;
                dgv_os_usl.Columns["name_inv_usl"].Width = 300;



                //dgv_Repair.Columns[1].HeaderText = "sdfaadf";
                //dgv_Repair.Columns["RepairID"].Visible = false;
            }
        }

        private void btn_formVedRes_Click(object sender, EventArgs e)
        {
            var mm = DateTime.Now.Month;
            var yy = DateTime.Now.Year;
            var dd = DateTime.Now.Day;
            var dd1 = new DateTime(yy, mm, dd);
            this.dateTimePicker1.Value = Convert.ToDateTime(dd1);
            this.dateTimePicker2.Value = Convert.ToDateTime(dd1);

            this.label1.Visible = true;
            this.label2.Visible = true;
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;
            this.btn_save.Visible = true;
            this.btn_cancel.Visible = true;
            this.btn_formVedRes.Visible = false;
            this.dgv_os_usl.Enabled = false;
            this.dateTimePicker1.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string theMonthBeg = dateTimePicker1.Value.ToString("MM");
            string theYearBeg = dateTimePicker1.Value.ToString("yyyy");

            string theMonthEnd = dateTimePicker2.Value.ToString("MM");
            string theYearEnd = dateTimePicker2.Value.ToString("yyyy");


            DAL dal = new DAL();
            dgv_mes_god.DataSource = dal.TekMesGod();
            string tek_mes  = dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
            if (tek_mes.Length == 1)
                tek_mes = "0" + dgv_mes_god.CurrentRow.Cells["mes"].Value.ToString();
            string tek_god = dgv_mes_god.CurrentRow.Cells["god"].Value.ToString();


            //tslblMes.Text = "Робочий місяць: " + tek_mes.ToString()+"-"+tek_god.ToString()+"p."; 25,11,2016 

            if (theMonthBeg == theMonthEnd && theYearBeg == theYearEnd && theMonthEnd == tek_mes && theYearEnd==tek_god)
            {

                //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;MultipleActiveResultSets=True");
                SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
                cn.Open();
                if (dal.CreateNewDokUsl(dgv_os_usl.CurrentRow.Cells["RepairID"].Value.ToString(),
                dateTimePicker1.Value.ToString("yyyyMMdd"), dateTimePicker2.Value.ToString("yyyyMMdd")) == true)
                {
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }

                this.label1.Visible = false;
                this.label2.Visible = false;
                this.dateTimePicker1.Visible = false;
                this.dateTimePicker2.Visible = false;
                this.btn_save.Visible = false;
                this.btn_cancel.Visible = false;
                this.btn_formVedRes.Visible = true;
                this.dgv_os_usl.Enabled = true;
                dgv_os_usl.DataSource = dal.GetAllUslForDokument();
                Settings_all_usl();
                this.dgv_os_usl.Focus();
                cn.Close();
            }
            else
            {
                if (theMonthEnd != tek_mes || theYearEnd != tek_god)
                MessageBox.Show("Помилка. Дати не в робочому місяці . Робочий "+tek_mes.ToString()+" місяць "+tek_god.ToString()+"pік");
                else
                    MessageBox.Show("Помилка. Місяць та рік виконання послуги повинні  бути однаковими.");
                this.dateTimePicker1.Focus();
            }
            

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
            this.btn_save.Visible = false;
            this.btn_cancel.Visible = false;
            this.btn_formVedRes.Visible = true;
            this.dgv_os_usl.Enabled = true;
            this.dgv_os_usl.Focus();

        }

    }
}
