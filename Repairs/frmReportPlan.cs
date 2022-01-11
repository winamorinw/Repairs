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
    public partial class frmReportPlan : Form
    {
        public int store_id;
        ReportDataSource Report5, Report6, ds2, ds3;

        public frmReportPlan()
        {
            InitializeComponent();
            repairOSDS.EnforceConstraints = false; //  формирует отчет несмотря на какие-то ошибки, если будет тру, то отчет не сформирует.
            this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            this.reportNormTableAdapter.Fill(this.repairOSDS.ReportNorm);
            checkBox1.Checked = false;
        }

        private void frmReportPlan_Load(object sender, EventArgs e)
        {

            try
            {
                this.reportNormTableAdapter.FillByInv(this.repairOSDS.ReportNorm, Convert.ToInt32(dgNormOS[0, dgNormOS.CurrentRow.Index].Value));

                this.reportOSTableAdapter.Fill(this.repairOSDS.ReportOS, Convert.ToInt32(dgNormOS[0, dgNormOS.CurrentRow.Index].Value));
                this.reportJobPlanTableAdapter.Fill(this.repairOSDS.ReportJobPlan, Convert.ToInt32(dgNormOS[0, dgNormOS.CurrentRow.Index].Value));
                this.reportJobFaktTableAdapter.Fill(this.repairOSDS.ReportJobFakt, Convert.ToInt32(dgNormOS[0, dgNormOS.CurrentRow.Index].Value));

            }
            catch { }

            this.rpvPlan.LocalReport.ReportEmbeddedResource = "Repairs.Report6.rdlc";
            Report6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Report6.Name = "DataSet1";  //ОС
            Report6.Value = repairOSDS.ReportOS;
            ds2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            ds2.Name = "DataSet2";  //Плановые
            ds2.Value = repairOSDS.ReportJobPlan;
            ds3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            ds3.Name = "DataSet3";  //Фактические
            ds3.Value = repairOSDS.ReportJobFakt;
            this.rpvPlan.LocalReport.DataSources.Add(Report6);
            this.rpvPlan.LocalReport.DataSources.Add(ds2);
            this.rpvPlan.LocalReport.DataSources.Add(ds3);
            rpvPlan.RefreshReport();
            //*/


            this.rpvNorm.LocalReport.ReportEmbeddedResource = "Repairs.Report5.rdlc";
            Report5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Report5.Name = "DataSet1";
            Report5.Value = repairOSDS.ReportNorm;
            this.rpvNorm.LocalReport.DataSources.Add(Report5);
            rpvNorm.RefreshReport();

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            GridSearch(textBox4.Text, dgNormOS, 0);
        }

        private void dgNormOS_CurrentCellChanged(object sender, EventArgs e)
        {
            frmReportPlan_Load(this, null);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            { this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS); }
            else { this.sprOSTableAdapter.FillByFlag(this.repairOSDS.SprOS); }
        }


    }
}
