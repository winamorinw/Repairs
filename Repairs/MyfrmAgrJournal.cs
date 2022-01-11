using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Collections;

namespace Repairs
{
    public partial class MyfrmAgrJournal : Form
    {
        DAL dal = new DAL();
        public MyfrmAgrJournal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadMyjournal() {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RepairOSDS.AgrJornalReport". При необходимости она может быть перемещена или удалена.
            string name = dgv_os.CurrentRow.Cells["inventoryNumber"].Value.ToString() + "  " + dgv_os.CurrentRow.Cells["obekt"].Value.ToString() + "   " + dgv_os.CurrentRow.Cells["name"].Value.ToString().Trim();
            ReportParameter InvAndName = new ReportParameter("InvAndName", name);
            ReportParameter DateBeg = new ReportParameter("DateBeg", (" з " + dgv_os.CurrentRow.Cells["dateBeg"].Value.ToString().Substring(0,10)));
            ReportParameter DateEnd = new ReportParameter();

            DateTime dateend = new DateTime();

            DateTime today = new DateTime();
            today = DateTime.Today;

            try
            {
                 dateend = Convert.ToDateTime(dgv_os.CurrentRow.Cells["Dateend"].Value.ToString());
                 if (dateend.Year == 1899)
                 {
                     DateEnd = new ReportParameter("DateEnd", ("            на " + today.ToString().Substring(0,10) + " в роботі"));
                 }
                 else {
                     DateEnd = new ReportParameter("DateEnd", ("            на " + today.ToString().Substring(0,10) + " списаний"));
                 }
            }
            catch
            {
                DateEnd = new ReportParameter("DateEnd", " ");
            }
            this.reportViewer1.LocalReport.SetParameters(InvAndName);
            this.reportViewer1.LocalReport.SetParameters(DateBeg);
            this.reportViewer1.LocalReport.SetParameters(DateEnd);

            int invNum = Convert.ToInt32(dgv_os.CurrentRow.Cells["inventoryNumber"].Value);
            int obekt = Convert.ToInt32(dgv_os.CurrentRow.Cells["obekt"].Value);
            this.AgrJornalReportTableAdapter.Fill(this.RepairOSDS.AgrJornalReport, invNum, obekt);
            this.reportViewer1.RefreshReport();
        
        }



        private void MyfrmAgrJournal_Load(object sender, EventArgs e)
        {
              dgv_os.DataSource = dal.GetAllTMCForAgrJournal();
            SettingsOS();

            
          
        }

        private void SettingsOS()
        {
            if (dgv_os.RowCount > 0)
            {
                dgv_os.Columns["GroupOsCode"].Visible = false;
                dgv_os.Columns["Flag"].Visible = false;
                dgv_os.Columns["Hours_Beg"].Visible = false;
                dgv_os.Columns["DateEnd"].Visible = false;

                dgv_os.Columns["inventoryNumber"].HeaderText = "Інв.№";
                dgv_os.Columns["obekt"].HeaderText = "Об";
                dgv_os.Columns["storeid"].HeaderText = "Цех";
                dgv_os.Columns["coduth"].HeaderText = "Діл";
                dgv_os.Columns["codbrig"].HeaderText = "Бр.";
                dgv_os.Columns["coddet"].HeaderText = "МВО";
                dgv_os.Columns["datebeg"].HeaderText = "Д. поч";
                dgv_os.Columns["name"].HeaderText = "Найменування";

                dgv_os.Columns["inventoryNumber"].Width =50;
                dgv_os.Columns["obekt"].Width  = 30;
                dgv_os.Columns["storeid"].Width  = 30;
                dgv_os.Columns["coduth"].Width =  30;
                dgv_os.Columns["codbrig"].Width = 30;
                dgv_os.Columns["coddet"].Width = 30;
                dgv_os.Columns["datebeg"].Width = 70;
                dgv_os.Columns["name"].Width = 250;
            }

            for (int i = 0; i < dgv_os.RowCount; i++)
            {
                DateTime dateend = new DateTime();

                if (DateTime.TryParse(dgv_os.Rows[i].Cells["dateend"].Value.ToString().Trim(), out dateend) == true)
                {

                    dateend = Convert.ToDateTime(dgv_os.Rows[i].Cells["dateend"].Value.ToString());
                    if (dateend.Year != 1899)
                    {
                        for (int j = 0; j < dgv_os.ColumnCount; j++)
                            dgv_os.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                }
            }
        }

        private void btn_formjournal_Click(object sender, EventArgs e)
        {
     
            dgv_os.DataSource = dal.GetAllTMCForAgrJournal(txt_SearchInv.Text.Trim());
            SettingsOS(); 

        }

        private void dgv_os_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadMyjournal();
        }

        private void txt_SearchInv_TextChanged(object sender, EventArgs e)
        {
 

        }


        private void SearchForInventory()
        {

        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchName.Text.Length > 2)
            {
                SearchForName();
            }
            else
            {
                dgv_os.DataSource = dal.GetAllTMCForAgrJournal();
                SettingsOS(); 
            }
        }

        private void SearchForName()
        {
            dgv_os.ReadOnly = false;
            for (int i = 0; i < dgv_os.RowCount; i++)
            {
                if (dgv_os.Rows[i].Cells["Name"].Value.ToString().ToLowerInvariant().Contains(txt_SearchName.Text) == false)
                {
                    dgv_os.CurrentCell = null;
                    dgv_os.Rows[i].Visible = false;
                }
            }

        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            dgv_os.DataSource = dal.GetAllTMCForAgrJournal();
            SettingsOS();
        }

    }
}
