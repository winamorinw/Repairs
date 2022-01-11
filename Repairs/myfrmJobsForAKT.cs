using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repairs
{
    public partial class myfrmJobsForAKT : Form
    {
        public string remusl="";
        public string repid = "";
        public myfrmJobsForAKT(string ID,string NameOS,string InvNumber, string rem_usl, string Repair_Id)
        {
            InitializeComponent();
            DAL dal = new DAL();
            remusl = rem_usl;
            repid = Repair_Id;

            if (remusl == "rem")
                lbl_VedR.Text = ("Відомість ресурсів № ");
            if (remusl == "usl")
                lbl_VedR.Text = ("Акт по послугам № ");

            lbl_ID.Text = ID;
            lbl_Name.Text = NameOS;
            lbl_Inv.Text = InvNumber;

            if (remusl == "rem")
            {
                dgv_JobFromAKT.DataSource = dal.GetJobFromAKT(ID,"rem");
                SettingsJob();
            }
            if (remusl == "usl")
            {
                dgv_JobFromAKT.DataSource = dal.GetJobFromAKT(ID,"usl");
                SettingsJob();
            }

        }

        private void myfrmJobsForAKT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairsDataSet4.Jobs_FromAktF2". При необходимости она может быть перемещена или удалена.
            this.jobs_FromAktF2TableAdapter.Fill(this.repairsDataSet4.Jobs_FromAktF2);
            SettingsJob();
        }



        private void SettingsJob()
        {
            if (dgv_JobFromAKT.RowCount > 0)
            {
                dgv_JobFromAKT.Columns["ID"].Visible = false;
                dgv_JobFromAKT.Columns["ID_VedR"].Visible = false;
                dgv_JobFromAKT.Columns["Nam_job"].Visible = true;
                dgv_JobFromAKT.Columns["Ch_chas"].Visible = true;
                dgv_JobFromAKT.Columns["ID_Repair"].Visible = false;

                dgv_JobFromAKT.Columns["Nam_job"].HeaderText = "Найменування робіт";
                dgv_JobFromAKT.Columns["Nam_job"].Width = 250;
                dgv_JobFromAKT.Columns["Ch_chas"].HeaderText = "Люд/годин";
                dgv_JobFromAKT.Columns["Ch_chas"].Width = 100;
                this.button1.Visible = true;
                this.button2.Visible = true;
            }
            else
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
            }


        }





        private void button1_Click(object sender, EventArgs e) // если Добавляем новую работу по АКТу
        {
            DAL dal = new DAL();
            string ID; string name_job; 
            ID = lbl_ID.Text;
            name_job = "";
            string Repair_id = dgv_JobFromAKT.CurrentRow.Cells["ID_Repair"].Value.ToString();

            dgv_JobFromAKT.Visible = false;
            frmAadUupdateJobFromAKT frmAadUupdateJobFromAKT = new frmAadUupdateJobFromAKT(ID, name_job, remusl.ToString(), Repair_id);
            if (frmAadUupdateJobFromAKT.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Add");
            }
            else
            {
                MessageBox.Show("Помилка!!! не додано!");
            }
            dgv_JobFromAKT.DataSource = dal.GetJobFromAKT(ID,remusl.ToString());

            SettingsJob();

            dgv_JobFromAKT.Visible = true;

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Дійсно вилучити роботу?","Вилучення роботи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((result == DialogResult.Yes) && (dgv_JobFromAKT.RowCount > 0))
            {
                               
                string ID;
                ID = lbl_ID.Text;
                DAL dal = new DAL();
                if (dal.DeleteJobFromAKT2(dgv_JobFromAKT.CurrentRow.Cells["ID"].Value.ToString()) == true)
                {
                    //  MessageBox.Show("Запись удачно удалена");
                }
                else
                {
                    MessageBox.Show("Помилка! Не вдалось вилучити запис! ");
                }
                dgv_JobFromAKT.DataSource = dal.GetJobFromAKT(ID, remusl.ToString());


                SettingsJob();
                //if (dgv_JobFromAKT.RowCount > 0)
                //{
                //    dgv_JobFromAKT.Columns["ID"].Visible = false;
                //    dgv_JobFromAKT.Columns["ID_VedR"].Visible = false;
                //    dgv_JobFromAKT.Columns["Nam_job"].Visible = true;

                //    dgv_JobFromAKT.Columns["Nam_job"].HeaderText = "Найменування робіт";
                //    dgv_JobFromAKT.Columns["Nam_job"].Width = 200;
                //}

            }
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            a = dgv_JobFromAKT.CurrentRow.Index;

            DAL dal = new DAL();
            string ID;
            ID = lbl_ID.Text;
            string ID_Job= dgv_JobFromAKT.CurrentRow.Cells["ID"].Value.ToString();
            string name_job =  dgv_JobFromAKT.CurrentRow.Cells["Nam_job"].Value.ToString();
            string ch_chas = dgv_JobFromAKT.CurrentRow.Cells["Ch_chas"].Value.ToString();

            dgv_JobFromAKT.Visible = false;
            frmUpdateCh_chas frmUpdateCh_chas = new frmUpdateCh_chas(ID_Job, name_job, ch_chas);
            if (frmUpdateCh_chas.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Add");
            }
            else
            {
                MessageBox.Show("Не збережено!!!");
            }
            dgv_JobFromAKT.DataSource = dal.GetJobFromAKT(ID,remusl);

            SettingsJob();

            dgv_JobFromAKT.Visible = true;
            dgv_JobFromAKT.FirstDisplayedCell = dgv_JobFromAKT.Rows[a].Cells["Ch_chas"];
            dgv_JobFromAKT.Rows[a].Selected = true;
            
            
                //=a;
                //gridView1.GetRowCellValue([a],["Ch_chas"])
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            string ID; string name_job;
            ID = lbl_ID.Text;
            name_job = "";
            //string Repair_id = dgv_JobFromAKT.CurrentRow.Cells["ID_Repair"].Value.ToString();


            if (dal.UpdateJobToAKT(ID, repid, remusl) == true)
            {
                //this.DialogResult = DialogResult.OK;
                //MessageBox.Show("Оновлено");
            }

            else
            {
                //this.DialogResult = DialogResult.No;
               // MessageBox.Show("Помилка оновлення.");
            }


            dgv_JobFromAKT.DataSource = dal.GetJobFromAKT(ID, remusl.ToString());

            SettingsJob();



        }

            


    }
}
