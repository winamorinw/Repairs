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
    public partial class frmReportIstoriyaOS : Form
    {
        public frmReportIstoriyaOS()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Vedomost_ResursovTableAdapter.ClearBeforeFill.ToString();

            string InvNumberOS = textBox4.Text.ToString();

            string Obekt =textBox3.Text.ToString();

            cn.Open();
            SqlCommand s0 = new SqlCommand("select name FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            try
            {
                this.label3.Text = s0.ExecuteScalar().ToString();
                this.button1.Visible = true;
            }
            catch
            {
                this.label3.Text = "Не знайдено";
                this.button1.Visible = false;
            }
            cn.Close();
            this.reportViewer1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text.ToString() == "" || this.textBox4.Text.ToString() == null)
            {
                MessageBox.Show("Виберіть номер ОЗ та об'єкт");
                this.textBox4.Select();

            }
            else
            {
                string invnum = this.textBox4.Text.ToString();
                string ob = this.textBox3.Text.ToString();
                string dat_nach = dtpBeg.Value.ToString("yyyy-MM-dd");
                string dat_konec = dtpEnd.Value.ToString("yyyy-MM-dd");
                string namOS = this.label3.Text.Trim();

                try
                {
                  

                    this.Vedomost_ResursovTableAdapter.Fill(this.RepairsDataSet20.Vedomost_Resursov, invnum, Convert.ToInt16(ob), dtpBeg.Value, dtpEnd.Value);
                    reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data1", dtpBeg.Value.ToShortDateString()));
                    reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data2", dtpEnd.Value.ToShortDateString()));
                    reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("invnum", invnum));
                    reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ob", ob));
                    reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("namOS", namOS));

                    this.reportViewer1.RefreshReport();
                }
                catch { }
                this.button1.Visible = false;
            }
            //string dat_nach = dtpBeg.Value.ToString("yyyy-MM-dd");
            //string dat_konec = dtpEnd.Value.ToString("yyyy-MM-dd");

            ////this.Vedomost_ResursovTableAdapter.FillBy1(this.RDSet12.Vedomost_Resursov, Convert.ToInt32(this.label3.Text.ToString()), dtpBeg.Value, dtpEnd.Value);
            ////this.Vedomost_ResursovTableAdapter.FillBy(this.RDSet12.Vedomost_Resursov, dtpBeg.Value, dtpEnd.Value, Dostup.Codcx);
            ////this.Vedomost_ResursovTableAdapter.FillBy1(this.RDSet12.Vedomost_Resursov, Convert.ToInt32(this.label3.Text.ToString()), dtpBeg.Value, dtpEnd.Value);

            //string c_inv = this.label3.Text.ToString();
            //this.Vedomost_ResursovTableAdapter.Fill(this.RepairsDataSet20.Vedomost_Resursov);

            //string data1 = dtpBeg.Value.ToShortDateString();
            //string data2 = dtpEnd.Value.ToShortDateString();
            ////reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data1", data1));
            ////reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data2", data2));
            ////reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cinvnum",this.label3.Text.ToString()));
            //this.reportViewer1.RefreshReport();
        }

        private void frmReportIstoriyaOS_Load(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            this.Vedomost_ResursovTableAdapter.Dispose();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "RepairsDataSet20.Vedomost_Resursov". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RepairsDataSet20.Vedomost_Resursov". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RDSet12.Vedomost_Resursov". При необходимости она может быть перемещена или удалена.
            
            
            
            
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.button1.Visible = false;
        }
    }
}
