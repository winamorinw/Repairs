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
    public partial class frmHatch : Form
    {
        string len = "", col = "";
        public frmHatch()
        {
            InitializeComponent();
        }

        private void hatchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hatchBindingSource.EndEdit();
            this.hatchTableAdapter.Update(this.repairOSDS.Hatch);

        }

        private void frmHatch_Load(object sender, EventArgs e)
        {
            try
            {
                repairOSDS.Side.Rows.Add();
                repairOSDS.Side.Rows.Add();
                repairOSDS.Side.Rows[0]["cod"] = "False";
                repairOSDS.Side.Rows[0]["nam"] = "Ліво";
                repairOSDS.Side.Rows[1]["cod"] = "True";
                repairOSDS.Side.Rows[1]["nam"] = "Право";

                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.StatusBranch". При необходимости она может быть перемещена или удалена.
                this.statusBranchTableAdapter.Fill(this.repairOSDS.StatusBranch);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Shtrek". При необходимости она может быть перемещена или удалена.
                this.shtrekTableAdapter.Fill(this.repairOSDS.Shtrek);

                this.branchComboTableAdapter.Fill(this.repairOSDS.BranchCombo);

                this.hatchTableAdapter.FillBy(this.repairOSDS.Hatch);

                this.horizontTableAdapter.Fill(this.repairOSDS.Horizont);

                this.storeTableAdapter.Fill(this.repairOSDS.Store);
            }
            catch { }



        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.horizontBindingSource.EndEdit();
            this.horizontTableAdapter.Update(this.repairOSDS.Horizont);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {




            if (panel3.Visible==true)
            {

                try
                {
                    branch_1TableAdapter.FillBy(repairOSDS.Branch_1, Convert.ToInt32(branchIDTextBox.Text), branch_nameTextBox.Text, Convert.ToInt32(horizontIDTextBox.Text), Convert.ToInt32(branch_numTextBox.Text), Convert.ToInt32(cbxShtrek.SelectedValue), Convert.ToInt32(branch_lenTextBox.Text), Convert.ToInt32(cbxStatus.SelectedValue), Convert.ToDateTime(date_lenDateTimePicker.Value), Convert.ToDateTime(date_statusDateTimePicker.Value));
                }
                catch { }
                if ((date_branchDateTimePicker.Value == DateTime.Now.Date) & (branch_1BindingSource.Count>0 ))
                {
                    this.Validate();
                    this.branchBindingSource.EndEdit();
                    this.branchTableAdapter.Update(this.repairOSDS.Branch);
                }
                else
                {
                   
                    if (branch_1BindingSource.Count == 0)
                    { horizontIDTextBox.Text = horizontDataGridView[2, horizontDataGridView.CurrentRow.Index].Value.ToString();
                        branchTableAdapter.InsertQuery(branch_nameTextBox.Text, Convert.ToInt32(horizontIDTextBox.Text), Convert.ToInt32(branch_numTextBox.Text), Convert.ToInt32(cbxShtrek.SelectedValue), Convert.ToInt32(branch_lenTextBox.Text), Convert.ToInt32(cbxStatus.SelectedValue), Convert.ToDateTime(date_lenDateTimePicker.Value), Convert.ToDateTime(date_statusDateTimePicker.Value)); }
                }


            }

            toolStripButton4.Visible = true;
            toolStripButton7.Visible = true;
            panel3.Visible = false;
            toolStripButton6.Enabled = false;
            try
            {
                this.branchTableAdapter.FillByHorizont(this.repairOSDS.Branch, Convert.ToInt32(horizontDataGridView[2, horizontDataGridView.CurrentRow.Index].Value));
            }
            catch { }


        }

        private void horizontDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.branchTableAdapter.FillByHorizont(this.repairOSDS.Branch, Convert.ToInt32(horizontDataGridView[2, horizontDataGridView.CurrentRow.Index].Value));
            }
            catch { }
        }

        private void hatchDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void hatchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (hatchDataGridView.CurrentCell == hatchDataGridView[0, hatchDataGridView.CurrentRow.Index])
            {
                frmSprShow frm = new frmSprShow("", "");
                frm.frm = "main";
                System.Windows.Forms.Form fm = new frmSprShow("", "");
                fm.Owner = this;
                fm.ShowDialog();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            frmMap frm = new frmMap();
            frm.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
           // toolStripTextBox1.Text= 
            //statusBranchBindingSource.Find("Color", "Красный").ToString();
            this.Validate();
            this.statusBranchBindingSource.EndEdit();
            this.statusBranchTableAdapter.Update(this.repairOSDS.StatusBranch);
        }





        private void branch_lenTextBox_TextChanged(object sender, EventArgs e)
        {
            date_lenDateTimePicker.Value = DateTime.Now.Date;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            date_statusDateTimePicker.Value = DateTime.Now.Date;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            branchBindingSource.AddNew();
            panel3.Visible = true;
            toolStripButton4.Visible = false;
            toolStripButton6.Enabled = true;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
          
            panel3.Visible = true;
            toolStripButton7.Visible = false;
            toolStripButton6.Enabled = true;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripButton4.Visible = true;
            toolStripButton7.Visible = true;
            panel3.Visible = false;
            toolStripButton6.Enabled = false;
            try
            {
                this.branchTableAdapter.FillByHorizont(this.repairOSDS.Branch, Convert.ToInt32(horizontDataGridView[2, horizontDataGridView.CurrentRow.Index].Value));
            }
            catch { }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            frmReportHatch frm = new frmReportHatch();
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
          //  branchTableAdapter.DeleteQuery(Convert.ToInt32(statusBranchDataGridView[5, statusBranchDataGridView.CurrentRow.Index].Value));
            this.Validate();
            this.branchBindingSource.EndEdit();
            this.branchTableAdapter.Update(this.repairOSDS.Branch);
        }



    }
}
