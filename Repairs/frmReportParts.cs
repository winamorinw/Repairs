using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Repairs
{
    public partial class frmReportParts : Form
    {
        ReportDataSource Report4;
        public frmReportParts()
        {
            InitializeComponent();           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Store". При необходимости она может быть перемещена или удалена.
            this.storeTableAdapter.Fill(this.repairOSDS.Store);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefPart". При необходимости она может быть перемещена или удалена.
            this.refPartTableAdapter.Fill(this.repairOSDS.RefPart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.PartsReport". При необходимости она может быть перемещена или удалена.
     //       this.partsReportTableAdapter.Fill(this.repairOSDS.PartsReport);
            datpBeg.Value = Convert.ToDateTime("01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString());
        }

        private void frmReportParts_Load(object sender, EventArgs e)
        {

            if ((chbId.Checked == false) & (chkbStore.Checked == false)) // Период
            {
                this.partsReportTableAdapter.FillByPeriod(repairOSDS.PartsReport, datpBeg.Value.ToShortDateString().ToString(), datpEnd.Value.ToShortDateString().ToString());
            }

            if ((chbId.Checked == false) & (chkbStore.Checked == true)) // Период, Цех
            {
                this.partsReportTableAdapter.FillByPeriodStore(repairOSDS.PartsReport, datpBeg.Value.ToShortDateString().ToString(), datpEnd.Value.ToShortDateString().ToString(), Convert.ToInt32(cbxStore.SelectedValue));
            }

            if ((chbId.Checked == true) & (chkbStore.Checked == false)) // Период, Запчасть
            {
                this.partsReportTableAdapter.FillByPeriodPart(repairOSDS.PartsReport, datpBeg.Value.ToShortDateString().ToString(), datpEnd.Value.ToShortDateString().ToString(), grid[0, grid.CurrentRow.Index].Value.ToString());
            }

            if ((chbId.Checked == true) & (chkbStore.Checked == true)) // Период, Запчасть, Цех
            {
                this.partsReportTableAdapter.FillByPeridStorePart(repairOSDS.PartsReport, datpBeg.Value.ToShortDateString().ToString(), datpEnd.Value.ToShortDateString().ToString(), grid[0, grid.CurrentRow.Index].Value.ToString(), Convert.ToInt32(cbxStore.SelectedValue));
            }


            this.rpvParts.LocalReport.ReportEmbeddedResource = "Repairs.Report4.rdlc";

            Report4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Report4.Name = "DataSet1";
            Report4.Value = repairOSDS.PartsReport;
            this.rpvParts.LocalReport.DataSources.Add(Report4);
            rpvParts.RefreshReport();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GridSearch(textBox1.Text, grid, 0);
        }

        private void chbId_CheckedChanged(object sender, EventArgs e)
        {
            if (chbId.Checked == false)
            { textBox1.Enabled = false;
            textBox1.Text = "";}
            else
            { textBox1.Enabled = true; }
        }

        private void chkbStore_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbStore.Checked == false)
            {
                cbxStore.Enabled = false;
            }
            else
            { cbxStore.Enabled = true; }
        }

        private void rpvParts_Load(object sender, EventArgs e)
        {

        }
    }
}
