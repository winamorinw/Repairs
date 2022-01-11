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
    public partial class frmPlanRepairs : Form
    {
        private string user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;
        string month_n, year_n, note_n;

        public frmPlanRepairs(string userp, string usern, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();
            user_p = userp;
            user_n = usern;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
        }

   


        private void frmPlanRepairs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacedPart". При необходимости она может быть перемещена или удалена.
      //      this.replacedPartTableAdapter.Fill(this.repairOSDS.ReplacedPart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacePartTable". При необходимости она может быть перемещена или удалена.


            if (user_p == "3")
            {
                inspectNormDataGridView.ReadOnly = true;
                inspectBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
            }
 
            this.refJobTableAdapter.FillBy(this.repairOSDS.RefJob);
            this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            this.inspectNormTableAdapter.Fill(this.repairOSDS.InspectNorm);
            this.inspTableTableAdapter.Fill(this.repairOSDS.InspTable);
            this.repairTableAdapter.Fill(this.repairOSDS.Repair);
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Store". При необходимости она может быть перемещена или удалена.
                this.storeTableAdapter.Fill(this.repairOSDS.Store);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.SprOSGroup". При необходимости она может быть перемещена или удалена.
                this.sprOSGroupTableAdapter.Fill(this.repairOSDS.SprOSGroup);

                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefPlace". При необходимости она может быть перемещена или удалена.
                this.refPlaceTableAdapter.Fill(this.repairOSDS.RefPlace);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefPart". При необходимости она может быть перемещена или удалена.
                this.refPartTableAdapter.Fill(this.repairOSDS.RefPart);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacedPart". При необходимости она может быть перемещена или удалена.
                //       this.replacedPartTableAdapter.Fill(this.repairOSDS.ReplacedPart);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.PlacePart". При необходимости она может быть перемещена или удалена.
                //     this.placePartTableAdapter.Fill(this.repairOSDS.PlacePart);


                //*/

                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Repair". При необходимости она может быть перемещена или удалена.

                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.PlanJob". При необходимости она может быть перемещена или удалена.
                this.planJobTableAdapter.Fill(this.repairOSDS.PlanJob);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Job". При необходимости она может быть перемещена или удалена.
                this.jobTableAdapter.Fill(this.repairOSDS.Job);

                //*/
            }
            catch { }



            inspectBindingNavigator.Visible = true;
            //*/
        }

        private void inspectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {



            this.Validate();
            this.inspectNormBindingSource.EndEdit();
            this.inspectNormTableAdapter.Update(this.repairOSDS.InspectNorm);
        }

        private void inspectNormDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {


                //    if (inspectNormDataGridView[0, inspectNormDataGridView.CurrentRow.Index].Value.ToString() != "")
                //      {
                System.Windows.Forms.Form fm = new frmSprShow(user_p, user_n);
                fm.Owner = this;
                fm.ShowDialog();

                //  }
            }
        }


        private void GridSearch(string text, DataGridView grid, int column_num)
        {

            for (int i = 0; i < grid.RowCount; i++)
                if (grid[column_num, i].FormattedValue.ToString().
                    Contains(text.Trim()))
                {
                    grid.CurrentCell = grid[column_num, i];
                    return;
                }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                GridSearch(toolStripTextBox1.Text, inspectNormDataGridView, 0);

            }
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text != "")
            {
                GridSearch(toolStripTextBox2.Text, sprOSDataGridView, 0);

            }
        }

        private void sprOSDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sprOSDataGridView.Rows.Count > 0) & (sprOSDataGridView[0, sprOSDataGridView.CurrentRow.Index].Value.ToString() != ""))
                {
                    this.planJobTableAdapter.FillByInv(this.repairOSDS.PlanJob, Convert.ToInt32(sprOSDataGridView[0, sprOSDataGridView.CurrentRow.Index].Value));
                    this.jobTableAdapter.FillByInv(this.repairOSDS.Job, Convert.ToInt32(sprOSDataGridView[0, sprOSDataGridView.CurrentRow.Index].Value));
                }//*/
            }
            catch {   }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            inspTableTableAdapter.Fill(repairOSDS.InspTable);
            planJobTableAdapter.InsertQuery();
            for (int i = 0; i <= inspTableDataGridView.Rows.Count - 1; i++)
            {

                planJobTableAdapter.UpdateQuery(Convert.ToInt16(inspTableDataGridView[0, i].Value), Convert.ToInt16(inspTableDataGridView[1, i].Value), Convert.ToInt32(inspTableDataGridView[3, i].Value), Convert.ToInt16(inspTableDataGridView[2, i].Value));
            }

            this.planJobTableAdapter.FillByInv(this.repairOSDS.PlanJob, Convert.ToInt32(sprOSDataGridView[0, sprOSDataGridView.CurrentRow.Index].Value));

        }

        private void planJobDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            month_n = planJobDataGridView[3, planJobDataGridView.CurrentRow.Index].Value.ToString();
            year_n = planJobDataGridView[4, planJobDataGridView.CurrentRow.Index].Value.ToString();
            note_n = planJobDataGridView[5, planJobDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void planJobDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (month_n != planJobDataGridView[3, planJobDataGridView.CurrentRow.Index].Value.ToString()) 
            {
                planJobDataGridView[6, planJobDataGridView.CurrentRow.Index].Value = "True";
                this.Validate();
                this.inspectNormBindingSource.EndEdit();
                this.planJobTableAdapter.Update(this.repairOSDS.PlanJob);
            }


               if  (year_n != planJobDataGridView[4, planJobDataGridView.CurrentRow.Index].Value.ToString())
               {
                   planJobDataGridView[6, planJobDataGridView.CurrentRow.Index].Value = "True";
                   this.Validate();
                   this.inspectNormBindingSource.EndEdit();
                   this.planJobTableAdapter.Update(this.repairOSDS.PlanJob);
               }


               if (note_n != planJobDataGridView[4, planJobDataGridView.CurrentRow.Index].Value.ToString())//(month_n == planJobDataGridView[4, planJobDataGridView.CurrentRow.Index].Value.ToString()) & (month_n != planJobDataGridView[3, planJobDataGridView.CurrentRow.Index].Value.ToString()))
               {
                 //  planJobDataGridView[6, planJobDataGridView.CurrentRow.Index].Value = "False";
                   this.Validate();
                   this.inspectNormBindingSource.EndEdit();
                   this.planJobTableAdapter.Update(this.repairOSDS.PlanJob);
               }
        }

        private void jobDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
           try
            {
                this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, Convert.ToInt32(jobDataGridView[0, jobDataGridView.CurrentRow.Index].Value));
            }
            catch { this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, 0);
            }//*/
       

        }

        private void gridReplacedPart_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.placePartTableAdapter.FillBy(this.repairOSDS.PlacePart, Convert.ToInt32(gridReplacedPart[0, gridReplacedPart.CurrentRow.Index].Value));
            }
            catch
            {
                try { this.placePartTableAdapter.FillBy(this.repairOSDS.PlacePart, 0); }
                catch { }
            }//*/
        }

        private void gridReplacedPart_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void placePartDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void jobDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void planJobDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void inspectNormDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && !(e.RowIndex < 0))
            {
                System.Windows.Forms.Form fm = new frmSprShow(user_p, user_n);
                fm.Owner = this;
                fm.ShowDialog();
            }//*/
        }

        private void sprOSDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}