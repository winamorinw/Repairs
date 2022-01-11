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
    public partial class myfrmAnalitika : Form
    {
        DAL dal = new DAL();
        public myfrmAnalitika()
        {
            InitializeComponent();
            dgv_analit.DataSource = dal.GetAllOSForAnalitAll();
            cbx_Rep.DataSource = dal.GetAllStore();

            cbx_Rep.DisplayMember = "StoreName";
            cbx_Rep.ValueMember = "StoreID";
            SettingsAnalit();
        }

        private void myfrmAnalitika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'analitika.SprOS' table. You can move, or remove it, as needed.
         //   this.sprOSTableAdapter.Fill(this.analitika.SprOS);
            // TODO: This line of code loads data into the 'reportTMCMOL._ReportTMCMOL' table. You can move, or remove it, as needed.
          //  this.reportTMCMOLTableAdapter.Fill(this.reportTMCMOL._ReportTMCMOL);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Rep_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_analit.DataSource = dal.GetAllOSForAnalitCeh(cbx_Rep.SelectedValue.ToString());
            SettingsAnalit();
        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchName.Text.Length > 2)
            {
            //   dgv_analit.DataSource = dal.GetAllOSForAnalitCeh(cbx_Rep.SelectedValue.ToString()); ;
                SearchForName();
                SettingsAnalit();
            }
            else
            {
                dgv_analit.DataSource = dal.GetAllOSForAnalitCeh(cbx_Rep.SelectedValue.ToString()); ;
                SettingsAnalit();
            }
        }

        private void SearchForName()
        {

            dgv_analit.ReadOnly = false;
            for (int i = 0; i < dgv_analit.RowCount; i++)
            {
                if (dgv_analit.Rows[i].Cells["Name"].Value.ToString().ToLowerInvariant().Contains(txt_SearchName.Text) == false)
                {
                    dgv_analit.CurrentCell = null;
                    dgv_analit.Rows[i].Visible = false;
                }
                SettingsAnalit();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void analitikaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SettingsAnalit() {

            if (dgv_analit.RowCount > 0)
            {
                dgv_analit.Columns["StoreID"].Visible = false;
                dgv_analit.Columns["DateEnd"].Visible = false;
                dgv_analit.Columns["GroupOSCode"].Visible = false;
                dgv_analit.Columns["Full_Srok"].Visible = false;
                dgv_analit.Columns["Hours_Beg"].Visible = false;
                dgv_analit.Columns["Flag"].Visible = false;
                dgv_analit.Columns["Obekt"].Visible = false;

                dgv_analit.Columns["InventoryNumber"].HeaderText = "Інв.№";
                dgv_analit.Columns["Name"].HeaderText = "Найменування";
                dgv_analit.Columns["DateBeg"].HeaderText = "Дата пос.";
                dgv_analit.Columns["Coduth"].HeaderText = "Діл";
                dgv_analit.Columns["CodBrig"].HeaderText = "Бр";
                dgv_analit.Columns["CodDet"].HeaderText = "МВО";
                dgv_analit.Columns["col"].HeaderText = "Кіл-ть";

                dgv_analit.Columns["InventoryNumber"].Width = 50;
                dgv_analit.Columns["Name"].Width = 240;
                dgv_analit.Columns["DateBeg"].Width = 70;
                dgv_analit.Columns["Coduth"].Width = 20;
                dgv_analit.Columns["CodBrig"].Width = 20;
                dgv_analit.Columns["CodDet"].Width = 20;
                dgv_analit.Columns["col"].Width = 50;


            }

        }

        private void dgv_analit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_analit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgv_RepPartNew.Visible = false;
            dgv_Repair.Visible = false;
            dgv_job.Visible = false;
            dgv_RepPartOld.Visible = false;
            dgv_Repair.DataSource = dal.GetAllRepairforInventoryNumber(dgv_analit.Rows[e.RowIndex].Cells["InventoryNumber"].Value.ToString());

            if (dgv_Repair.RowCount > 0) {
                dgv_Repair.Visible = true;
                SettingsAllRepair();
            }
        }

        private void dgv_Repair_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            dgv_RepPartOld.Visible = false;
            dgv_RepPartOld.DataSource = dal.GetAllRepPlace1OldAnalit(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString());
            if (dgv_RepPartOld.RowCount > 0) {
                dgv_RepPartOld.Visible = true;
                SettingsRepOld();
            
            }

            dgv_job.Visible = false;
            
            dgv_job.DataSource = dal.GetAllJobAnalit(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString());

            if (dgv_job.RowCount > 0) {
                dgv_job.Visible = true;
                SettingsAllJob();
            
            }

            dgv_RepPartNew.Visible = false;
            dgv_RepPartNew.DataSource = dal.GetAllRepPlace1NewAnalit(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString());
            if (dgv_RepPartNew.RowCount > 0) {
                dgv_RepPartNew.Visible = true;
            }





        }
        //настройка ремонтов
        private void SettingsAllRepair() {
            if (dgv_Repair.RowCount > 0){
                dgv_Repair.Columns["RepairID"].Visible = false;

                dgv_Repair.Columns["RDivision"].HeaderText = "р.ц.";
                dgv_Repair.Columns["DATEIN"].HeaderText = "Поч. р";
                dgv_Repair.Columns["DateOut"].HeaderText = "Зав. р";
                dgv_Repair.Columns["Cause"].HeaderText = "Поломка";
                dgv_Repair.Columns["Responsible"].HeaderText = "Відпов.";
                dgv_Repair.Columns["Note"].HeaderText = "Примітка";

                dgv_Repair.Columns["RDivision"].Width = 30;
                dgv_Repair.Columns["DATEIN"].Width = 70;
                dgv_Repair.Columns["DateOut"].Width = 70;
                dgv_Repair.Columns["Cause"].Width = 100;
                dgv_Repair.Columns["Responsible"].Width = 70;
                dgv_Repair.Columns["Note"].Width = 100;

            }
        }



        //настройка видов работ
        private void SettingsAllJob() {
            if (dgv_job.RowCount > 0)
            {
                dgv_job.Columns["JobName"].HeaderText = "Назва";
                dgv_job.Columns["JobName"].Width = dgv_job.Width - 50;
            }
        }

        private void SettingsRepOld() { 
            if(dgv_RepPartOld.RowCount > 0){
                dgv_RepPartOld.Columns["PartName"].HeaderText = "Найменування";
                dgv_RepPartOld.Columns["Quantity"].HeaderText = "Кіл-ть";
                dgv_RepPartOld.Columns["EdIzm"].HeaderText = "Од.вим.";

                dgv_RepPartOld.Columns["PartName"].Width = 220;
            }
        
        }

        private void dgv_Repair_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            dgv_RepPartOld.Visible = false;
            dgv_RepPartOld.DataSource = dal.GetAllRepPlace1OldAnalit(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString());
            if (dgv_RepPartOld.RowCount > 0)
            {
                dgv_RepPartOld.Visible = true;
                SettingsRepOld();

            }

            dgv_job.Visible = false;

            dgv_job.DataSource = dal.GetAllJobAnalit(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString());

            if (dgv_job.RowCount > 0)
            {
                dgv_job.Visible = true;
                SettingsAllJob();

            }

            dgv_RepPartNew.Visible = false;
            dgv_RepPartNew.DataSource = dal.GetAllRepPlace1NewAnalit(dgv_Repair.CurrentRow.Cells["RepairID"].Value.ToString());
            if (dgv_RepPartNew.RowCount > 0)
            {
                dgv_RepPartNew.Visible = true;
            }



        }






    }
}
