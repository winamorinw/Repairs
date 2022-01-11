/* Сделал 2 конструктора. Один принимает параметры вызвавшей формы и права пользователя, второй то же + родительскую форму.
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
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Repairs
{
    public partial class frmReport : Form
    {
        private string frm, user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;

        public int store_id;
        ReportDataSource  Report1, Report2, Report3;
       // DataTable agr = new DataTable();

        public frmReport(string frmfrom, string userp, string usern, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();
            frm = frmfrom;
            user_p = userp;
            user_n = usern;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
            datpBeg.Value = Convert.ToDateTime("01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString());
            textBox2.Text = DateTime.Now.Year.ToString();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.SprOS". При необходимости она может быть перемещена или удалена.
            this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            checkBox1.Checked = false;
        }

        public frmReport(string frmfrom, string userp, Form theparent)
        {
            InitializeComponent();
            frm = frmfrom;
            user_p = userp;
            this.MdiParent = theparent;
            datpBeg.Value = Convert.ToDateTime("01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString());
            textBox2.Text = DateTime.Now.Year.ToString();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.SprOS". При необходимости она может быть перемещена или удалена.
            this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            checkBox1.Checked = false;
        }


        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReportWorkOS". При необходимости она может быть перемещена или удалена.
            //this.reportWorkOSTableAdapter.Fill(this.repairOSDS.ReportWorkOS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.WorkOSTable". При необходимости она может быть перемещена или удалена.
            rpvRepair.Clear();
            rpvAgr.Clear();
            this.Text = "Отчет";
            if (frm == "main" || ((frm == "carriagesrepair" || frm == "gettorepair")))
            //if (frm == "main" || (user_p == "3" && (frm == "carriagesrepair" || frm == "gettorepair"))) //было так я поменял
            {
                button1.Visible = true;
                rbtnInvNum.Visible = true;
                textBox1.Visible = true;
                if (rbtnReportIn.Checked)
                {
                    grid.Visible = false;
                    datpEnd.Enabled = false;
                    this.repairTableTableAdapter.FillByd1(this.repairOSDS.RepairTable, datpBeg.Value);
                }
                if (rbtnReportOut.Checked)
                {
                    grid.Visible = false;
                    datpEnd.Enabled = true;
                    repairOSDS.EnforceConstraints = false;
                    this.repairTableTableAdapter.FillByd1d2(this.repairOSDS.RepairTable, datpBeg.Value, datpEnd.Value);
                }
                if (rbtnInvNum.Checked)
                {
                    grid.Visible = true;
                    datpEnd.Enabled = true;
                    this.repairTableTableAdapter.FillByInvD1D2(this.repairOSDS.RepairTable, datpBeg.Value, datpEnd.Value, Convert.ToInt32(grid[0, grid.CurrentRow.Index].Value));
                }
            }
            else
            if (frm == "carriagesrepair")
            {
                if (rbtnReportIn.Checked)
                {
                    datpEnd.Enabled = false;
                    this.repairTableTableAdapter.FillByRDivD1(this.repairOSDS.RepairTable, store_id, datpBeg.Value);
                }
                if (rbtnReportOut.Checked)
                {
                    datpEnd.Enabled = true;
                    this.repairTableTableAdapter.FillByRDivision(this.repairOSDS.RepairTable,store_id, datpBeg.Value, datpEnd.Value);
                }
            }
            else
            if (frm == "gettorepair")
            {
                if (rbtnReportIn.Checked)
                {
                    datpEnd.Enabled = false;
                    this.repairTableTableAdapter.FillByDivD1(this.repairOSDS.RepairTable, store_id, datpBeg.Value);
                }
                if (rbtnReportOut.Checked)
                {
                    datpEnd.Enabled = true;
                    this.repairTableTableAdapter.FillByDivD1D2(this.repairOSDS.RepairTable, store_id, datpBeg.Value, datpEnd.Value);
                }
            }
            else
            if (frm == "workos")
            {
                rpvRepair.Visible =false;
                rpvAgr.Visible =false;
                rpvWorkOS.Visible = true;
                grid.Visible = true;
/*                grid.Location = new Point(1, 58);
                grid.Size = new System.Drawing.Size(245, 453);*/
                this.reportWorkOSTableAdapter.Fill(this.repairOSDS.ReportWorkOS);
                
                if (textBox1.Text == "")
                {
                    this.reportWorkOSTableAdapter.Fill(this.repairOSDS.ReportWorkOS);
                }
                else
                {
                    try
                    {
                        this.reportWorkOSTableAdapter.FillBy(this.repairOSDS.ReportWorkOS, Convert.ToInt32(grid[0, grid.CurrentRow.Index].Value), Convert.ToInt32(textBox2.Text));
                    }
                    catch { }
                }
                this.rpvWorkOS.LocalReport.ReportEmbeddedResource = "Repairs.Report2.rdlc";

                Report2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Report2.Name = "DataSet1";
                Report2.Value = repairOSDS.ReportWorkOS;
                this.rpvWorkOS.LocalReport.DataSources.Add(Report2);
                rbtnInvNum.Visible = true;
                textBox1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                datpBeg.Visible = false;
                datpEnd.Visible = false;
                rbtnReportIn.Visible = false;
                rbtnReportOut.Visible = false;
                grid.Visible = true;
                rpvWorkOS.Visible = true;
                rpvWorkOS.RefreshReport();
            }


            if ((frm == "gettorepair") || (frm == "carriagesrepair") || (frm == "main"))
            {
                rpvRepair.Clear();
                this.rpvRepair.LocalReport.ReportEmbeddedResource = "Repairs.Report1.rdlc";
                Report1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Report1.Name = "DataSet1";
                Report1.Value = repairOSDS.RepairTable;
                this.rpvRepair.LocalReport.DataSources.Add(Report1);
                //  rbtnInvNum.Visible = false;
                //  textBox1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                // button1.Visible = false;
                datpBeg.Visible = true;
                datpEnd.Visible = true;
                rbtnReportIn.Visible = true;
                rbtnReportOut.Visible = true;
                //  rpvRepair.Visible = true;
                // rpvWorkOS.Visible = false;
                // rpvAgr.Visible = false;
            }
            //***************************************


            if (frm == "agr")
            {
                this.Text = "Агрегатний журнал";
                panel2.Height = 58;
                grid.Location = new Point(1, 58);
                grid.Height = 600;
/*                grid.Location = new Point(1, 58);
                grid.Size = new System.Drawing.Size(245, 453);*/
                rpvAgr.Clear();
                grid.Visible = true;
                if (grid.Rows.Count > 0)
                {
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = Repairs.Properties.Settings.Default.RepairOSConnStr;
                    cn.Open();
                    string query_inv = "SELECT InventoryNumber, GroupOSCode, Name, StoreID, DateBeg, DateEnd, isnull(obekt,0) FROM SprOS"
+ " WHERE InventoryNumber=" + grid[0, grid.CurrentRow.Index].Value.ToString() + " and isnull(obekt,0) =" + grid[1, grid.CurrentRow.Index].Value.ToString();
                    MessageBox.Show(grid[0, grid.CurrentRow.Index].Value.ToString() + "  " + " це інвентарний номер ");
                    MessageBox.Show(query_inv);

                    SqlDataAdapter sqlDA_inv = new SqlDataAdapter(query_inv, cn);
                    DataTable inv_tab = new DataTable();
                    sqlDA_inv.Fill(inv_tab);
                    if (inv_tab.Rows.Count > 0)
                    {
                        ReportParameter InvAndName = new ReportParameter("InvAndName", (inv_tab.Rows[0][0].ToString() + "   " + inv_tab.Rows[0][2].ToString()));

                        MessageBox.Show(" yfi bydytqv" + inv_tab.Rows[0][0].ToString() + "   " + inv_tab.Rows[0][2].ToString());
                        rpvAgr.LocalReport.SetParameters(new ReportParameter[] { InvAndName });
                       // MessageBox.Show(inv_tab.Rows[0][2].ToString() + " пришли");

                        ReportParameter DateBeg = new ReportParameter("DateBeg", ("в роботі з " + inv_tab.Rows[0][4].ToString().Substring(0, 10)));
                        MessageBox.Show(inv_tab.Rows[0][4].ToString().Substring(0, 10) + "   " + "Дата початку");
                        rpvAgr.LocalReport.SetParameters(new ReportParameter[] { DateBeg });

                        try
                        {
                            ReportParameter DateEnd = new ReportParameter("DateEnd", (" по " + inv_tab.Rows[0][5].ToString().Substring(0, 10)));
                            rpvAgr.LocalReport.SetParameters(new ReportParameter[] { DateEnd });
                            MessageBox.Show(datpEnd.ToString());
                        }
                        catch
                        {
                            ReportParameter DateEnd = new ReportParameter("DateEnd", " ");
                            rpvAgr.LocalReport.SetParameters(new ReportParameter[] { DateEnd });
                        }

                        ////    MessageBox.Show("Агрегатый журнал" + Convert.ToInt32(grid[0, grid.CurrentRow.Index].Value).ToString());
                        //this.agrJornalReportTableAdapter.Fill(repairOSDS.AgrJornalReport, Convert.ToInt32(grid[0, grid.CurrentRow.Index].Value),0);
                        ////   MessageBox.Show("Агрегатый журнал" + Convert.ToInt32(grid[0, grid.CurrentRow.Index].Value).ToString());
                        //this.rpvAgr.LocalReport.ReportEmbeddedResource = "Repairs.Report3.rdlc";

                        //Report3 = new Microsoft.Reporting.WinForms.ReportDataSource();
                        //Report3.Name = "DataSet1";
                        //Report3.Value = repairOSDS.AgrJornalReport;
                        //MessageBox.Show(Report3.Value.ToString() + this.Text);
                        //this.rpvAgr.LocalReport.DataSources.Add(Report3);
                        //this.rpvAgr.RefreshReport();
                        /////////////////////////////////////////////////////////////////////////////////////////////
                        this.agrJornalReportTableAdapter.Fill(repairOSDS.AgrJornalReport, Convert.ToInt32(grid[0, grid.CurrentRow.Index].Value.ToString()), 0);
                        this.rpvAgr.LocalReport.ReportEmbeddedResource = "Repairs.Report3.rdlc";
                        MessageBox.Show("Вотсюда мы пришли " + rpvAgr.LocalReport.ReportEmbeddedResource.ToString());
                        MessageBox.Show("а вот это значение для табла" + grid[0, grid.CurrentRow.Index].Value.ToString());
                        Report3 = new Microsoft.Reporting.WinForms.ReportDataSource();
                        //  Report3 = ;
                        Report3.Name = "DataSet1";
                        Report3.Value = repairOSDS.AgrJornalReport;
                        this.rpvAgr.LocalReport.DataSources.Add(Report3);
                        this.rpvAgr.RefreshReport();
                        /////////////////////////////////////////////////////////////////////////
                    }
                    else
                    {
                        MessageBox.Show("Такого інвентарного номеру не існує");
                    }
                }
              
                    rbtnInvNum.Visible = true;
                    textBox1.Visible = true;
                    label2.Visible = false;
                    textBox2.Visible = false;
                    button1.Visible = true;
                    datpBeg.Visible = false;
                    datpEnd.Visible = false;
                    rbtnReportIn.Visible = false;
                    rbtnReportOut.Visible = false;
                    rpvAgr.Visible = true;
                
            }
            this.rpvRepair.RefreshReport();
        }

        private void rpvRepair_Load(object sender, EventArgs e)
        {

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


        /// <summary>
        /// Заполняет таблицу справа от отчета.
        /// Отдельные права для гостя админа и рмц.
        /// </summary>
        private void LoadThatTableInTheRight()
        {
            //if (!checkBox1.Checked)
            //{
            //    if ((user_p == "3" || user_p == "4") || user_n == "14")
            //    {
            //        this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            //    }
            //    else
            //        if (user_p == "1" || user_p == "2" || user_p == "5")
            //        {
            //            this.sprOSTableAdapter.FillByStorId(this.repairOSDS.SprOS, int.Parse(user_n));
            //        }
            //}
            //else
            //{
            //    if ((user_p == "3" || user_p == "4") || user_n == "14")
            //    {
            //        this.sprOSTableAdapter.FillByFlag(this.repairOSDS.SprOS);
            //    }
            //    else
            //        if (user_p == "1" || user_p == "2" || user_p == "5")
            //        {
            //            this.sprOSTableAdapter.FillByStorFlag(this.repairOSDS.SprOS, int.Parse(user_n));
            //        }
            //}

            this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            LoadThatTableInTheRight();
        }

        private void rbtnInvNum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sprOSTableAdapter.FillBy(this.repairOSDS.SprOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void AgrJornalReportBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
