using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Repairs
{
    public partial class myfrmGetToRepairs : Form
    {
        DAL dal = new DAL();
        private string user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;
        public myfrmGetToRepairs(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            user_n = usern;
            user_p = userp;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
            InitializeComponent();
            dgv_Repair.DataSource = dal.GetAllGetRepair();
            if (dgv_Repair.RowCount > 0)
            {
                SettingsRepair();
            }

            cbx_RDiv.DataSource = dal.GetAllStore();
            cbx_RDiv.SelectedIndexChanged += cbx_RDiv_SelectedIndexChanged;
            cbx_RDiv.DisplayMember = "StoreName";
            cbx_RDiv.ValueMember = "StoreName";




        }

        //отображение отправленного в ремонт
        private void SettingsRepair() {
            try
            {
                dgv_Repair.Columns["RepairID"].Visible = false;
                dgv_Repair.Columns["TypeFlaut"].Visible = false;
                dgv_Repair.Columns["Cause"].Visible = false;
                dgv_Repair.Columns["Responsible"].Visible = false;
                dgv_Repair.Columns["Note"].Visible = false;
                dgv_Repair.Columns["plan_r"].Visible = false;
                dgv_Repair.Columns["NoteDataNext"].Visible = false;
                dgv_Repair.Columns["dataNext"].Visible = false;

                dgv_Repair.Columns["DateIn"].HeaderText = "Дата отправки";
                dgv_Repair.Columns["InventoryNumber"].HeaderText = "Инв. №";
                dgv_Repair.Columns["AsRDivis"].HeaderText = "Получатель";
                dgv_Repair.Columns["Divis"].HeaderText = "Отправитель";
                dgv_Repair.Columns["Name"].HeaderText = "Название";
                dgv_Repair.Columns["DateOut"].HeaderText = "Дата окончания ";
                dgv_Repair.Columns["Obekt"].HeaderText = "Об";

                dgv_Repair.Columns["InventoryNumber"].DisplayIndex = 0;
                dgv_Repair.Columns["Obekt"].DisplayIndex = 1;
                dgv_Repair.Columns["Name"].DisplayIndex = 2;
                dgv_Repair.Columns["AsRDivis"].DisplayIndex = 3;
                dgv_Repair.Columns["Divis"].DisplayIndex = 4;
                dgv_Repair.Columns["DateIn"].DisplayIndex = 5;
                dgv_Repair.Columns["DateOut"].DisplayIndex = 6;

                dgv_Repair.Columns["InventoryNumber"].Width = 70;
                dgv_Repair.Columns["Name"].Width = 245;
                dgv_Repair.Columns["AsRDivis"].Width = 190;
                dgv_Repair.Columns["Divis"].Width = 190;
                dgv_Repair.Columns["DateIn"].Width = 90;
                dgv_Repair.Columns["DateOut"].Width = 90;
                dgv_Repair.Columns["Obekt"].Width = 25;

           }
           catch { }
        }

        //Отправить в ремонт
        private void button1_Click(object sender, EventArgs e)
        {
            string rem_usl = "rem";
            myfrmAddNewRepair myfrmAddNewRepair = new myfrmAddNewRepair(rem_usl);
            if (myfrmAddNewRepair.ShowDialog() == DialogResult.OK) {
                dgv_Repair.DataSource = dal.GetAllGetRepair();
                SettingsRepair();
            }
            dgv_Repair.DataSource = dal.GetAllGetRepair();
            SettingsRepair();
        }

        private void dgv_Repair_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_note.Text = dgv_Repair.Rows[e.RowIndex].Cells["Note"].Value.ToString();
                txt_Cause.Text = dgv_Repair.Rows[e.RowIndex].Cells["Cause"].Value.ToString();
                txt_Responsible.Text = dgv_Repair.Rows[e.RowIndex].Cells["Responsible"].Value.ToString();
                txt_TypeFlaut.Text = dgv_Repair.Rows[e.RowIndex].Cells["TypeFlaut"].Value.ToString();
                if (dgv_Repair.Rows[e.RowIndex].Cells["plan_r"].Value.ToString() == "1")
                {
                    cbx_plan.Checked = true;
                }
                else cbx_plan.Checked = false;

                txt_noteDataNext.Text = dgv_Repair.Rows[e.RowIndex].Cells["NoteDataNext"].Value.ToString();
                txt_dataNext.Text = dgv_Repair.Rows[e.RowIndex].Cells["dataNext"].Value.ToString();
            }
            catch { }
        }
        //удаление внесенного ремонта
        private void button3_Click(object sender, EventArgs e)
        {
          
            string message =      "Вы Удаляете отправку в ремонт "
     + dgv_Repair.CurrentRow.Cells["InventoryNumber"].Value.ToString() +
     "  " + dgv_Repair.CurrentRow.Cells["Name"].Value.ToString()  ;
            const string caption = "Внимательно подумай!!!";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if   (dal.DeleteRepair(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString()) == true)
                {
                  //  textBox1.Text = dal.DeleteRepairString(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString()); 
                    MessageBox.Show("Запись удачно удалена");
                    dgv_Repair.DataSource = dal.GetAllGetRepair();
                }
                else
                {
                    MessageBox.Show("Ошибка! Не удалось удалить запись! ");
                  //  textBox1.Text = dal.DeleteRepairString(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString()); 
                }          
            } 
        }

        private void chbx_SearchDataReport_CheckedChanged(object sender, EventArgs e)
        {
            //if (chbx_SearchDataReport.Checked == false)
            //{
            //    dgv_Repair.DataSource = dal.GetAllRepair();
            //    SearchForNotDataEnd();
            //  //  MessageBox.Show(dgv_Repair.Rows[1].Cells["DateOut"].ToString().Length.ToString());
            //}
            //else if (chbx_SearchDataReport.Checked == true)
            //{
            //    dgv_Repair.DataSource = dal.GetAllRepair();
            //    SearchForYesDataEnd();
            // //   MessageBox.Show("2");
            
            //}
        }

        
        //поиск в ремонте (дата пустая)
        private void SearchForNotDataEnd()
        {
            
            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["DateOut"].Value.ToString() == "")
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                  //  MessageBox.Show(dgv_Repair.Rows[i].Cells["DateOut"].ToString().Length.ToString());
                }
            }

        }

        //поиск в ремонте (дата не пустая)
        private void SearchForYesDataEnd()
        {

            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["DateOut"].Value.ToString().Length > 2)
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }

        }

        private void chbx_SearchDataReport_CheckStateChanged(object sender, EventArgs e)
        {
            //    if (chbx_SearchDataReport.Checked == false)
            //    {
            //        dgv_Repair.DataSource = dal.GetAllRepair();
            //        SearchForNotDataEnd();
            //        //  MessageBox.Show(dgv_Repair.Rows[1].Cells["DateOut"].ToString().Length.ToString());
            //    }
            //    else if (chbx_SearchDataReport.Checked == true)
            //    {
            //        dgv_Repair.DataSource = dal.GetAllRepair();
            //        SearchForYesDataEnd();
            //        //   MessageBox.Show("2");

            //    }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dgv_Repair.DataSource = dal.GetAllGetRepair();
                SearchForNotDataEnd();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true){
            dgv_Repair.DataSource = dal.GetAllGetRepair();
           SearchForYesDataEnd();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt_SearchInv_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchInv.Text.Length > 2)
            {
               // dgv_Repair.DataSource = dal.GetAllGetRepair();
                SearchForInventory();
            }
            else
            {
                dgv_Repair.DataSource = dal.GetAllGetRepair();

            }
        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchName.Text.Length > 2)
            {
              //  dgv_Repair.DataSource = dal.GetAllGetRepair();
                SearchForName();
            }
            else
            {
                dgv_Repair.DataSource = dal.GetAllGetRepair();

            }
        }

        //поиск по названию
        private void SearchForName()
        {

            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["Name"].Value.ToString().ToLowerInvariant().Contains(txt_SearchName.Text) == false)
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }

        }

        //поиск по инвентарному номеру
        private void SearchForInventory()
        {

            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["InventoryNumber"].Value.ToString().Contains(txt_SearchInv.Text) == false)
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }

        }

        private void cbx_RDiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            {
               // dgv_Repair.DataSource = dal.GetAllGetRepair();
                SearchRDiv();
            }
        }

        //поиск по цеху отправителю
        private void SearchRDiv()
        {
            for (int i = 0; i < dgv_Repair.RowCount; i++ )
            {
                dgv_Repair.Rows[i].Visible = true;

            }




            dgv_Repair.ReadOnly = false;
            for (int i = 0; i < dgv_Repair.RowCount; i++)
            {
                if (dgv_Repair.Rows[i].Cells["AsRDivis"].Value.ToString()!=cbx_RDiv.SelectedValue.ToString())
                {
                    dgv_Repair.CurrentCell = null;
                    dgv_Repair.Rows[i].Visible = false;
                }
            }

        }

        private void txt_dataNext_TextChanged(object sender, EventArgs e)
        {

        }

        private void myfrmGetToRepairs_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string rem_usl="usl";
            myfrmAddNewRepair myfrmAddNewRepair = new myfrmAddNewRepair(rem_usl);
            if (myfrmAddNewRepair.ShowDialog() == DialogResult.OK)
            {
                dgv_Repair.DataSource = dal.GetAllGetRepair();
                SettingsRepair();
            }
            dgv_Repair.DataSource = dal.GetAllGetRepair();
            SettingsRepair();
        }

        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    if (txt_SearchInv.Text.Length > 1)
        //    {
        //        // dgv_Repair.DataSource = dal.GetAllGetRepair();
        //        SearchForInventory();
        //    }
        //    else
        //    {
        //        dgv_Repair.DataSource = dal.GetAllGetRepair();

        //    }
        //}


    }
}
