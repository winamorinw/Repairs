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
    public partial class myfrm_otchet_prostoi : Form
    {
        public string datn="";
        public string datk="";
        
        public myfrm_otchet_prostoi(string data1, string data2)
        {
            InitializeComponent();
            datn = data1;
            datk = data2;

        }

        private void myfrm_otchet_prostoi_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataBeg", datn));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataEnd", datk));

            //2018-01-01
            //string dn = datn.Substring(8, 2) + "-" + datn.Substring(5, 2) + "-" + datn.Substring(0, 4);
            //string dk = datk.Substring(8, 2) + "-" + datk.Substring(5, 2) + "-" + datk.Substring(0, 4);

            this.RepairsDataSet19.EnforceConstraints = false;

            try
            {
                if (Dostup.Ceh_dostup_pr.ToString().Trim() == "88")
                {
                    this.ProstoiTableAdapter.Fill(this.RepairsDataSet19.Prostoi, datn, datk);
                }
                else
                {
                    this.ProstoiTableAdapter.FillByCeh(this.RepairsDataSet19.Prostoi, datn, datk, Convert.ToInt32(Dostup.Ceh_dostup_pr.ToString()));
                }

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
