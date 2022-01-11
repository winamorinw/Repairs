/* Changelog
 * 
 * Переписал конструктор формы. Передача прав/цеха происходит через конструктор.
 * 
 * 
 */
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
    public partial class frmWorkOS : Form
    {
        private string user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det, tek_mes, tek_god;

        public frmWorkOS(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet, 
            string tekmes,string tekgod)
        {
            InitializeComponent();
            user_n = usern;
            user_p = userp;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
            tek_mes = tekmes;
            tek_god = tekgod;
        }

        private void frmWorkOS_Load(object sender, EventArgs e)
        {
            if (user_p == "3")
            {

                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                workOSBindingNavigatorSaveItem.Enabled = false;
                workOSDataGridView.ReadOnly = true;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.SprOS". При необходимости она может быть перемещена или удалена.
            this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.WorkOS". При необходимости она может быть перемещена или удалена.
            this.workOSTableAdapter.Fill(this.repairOSDS.WorkOS);


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmReport fm = new frmReport("workos", user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            /*fm.frm = "workos";*/
            if (user_p!="3")
                fm.store_id = Convert.ToInt32(user_n);
            fm.ShowDialog();
        }

        private void workOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workOSBindingSource.EndEdit();
            this.workOSTableAdapter.Update(this.repairOSDS.WorkOS);

        }

        private void workOSDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && !(e.RowIndex < 0))
            {
                System.Windows.Forms.Form fm = new frmSprShow(user_p, user_n);
                fm.Owner = this;
                fm.ShowDialog();
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
                GridSearch(toolStripTextBox1.Text, workOSDataGridView, 0);

            }
        }

        private void workOSDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
