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
    public partial class frmReport_Zvit_Spisok_FromVedRes : Form
    {
        public bool all_ceh;
        public string vibran_ceh;
        public DateTime ddt1;
        public DateTime ddt2;

        public frmReport_Zvit_Spisok_FromVedRes(string dostup_tmc, string dat1, string dat2, bool all, string ceh)
        {
            InitializeComponent();
            all_ceh = all;
            vibran_ceh = ceh;
            radioButton1.Checked = true;
            ddt1 = Convert.ToDateTime(dat1.Substring(6, 2) + "/" + dat1.Substring(4, 2) + "/" + dat1.Substring(0, 4));
            ddt2 = Convert.ToDateTime(dat2.Substring(6, 2) + "/" + dat2.Substring(4, 2) + "/" + dat2.Substring(0, 4));
        }

        private void frmReport_Zvit_Spisok_FromVedRes_Load(object sender, EventArgs e)
        {
            dtpBeg.Value = ddt1;
            dtpEnd.Value = ddt2; 

            //dtpBeg.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            //dtpBeg.Value = Convert.ToDateTime(dat); 

            //int days = DateTime.DaysInMonth(dtpBeg.Value.Year, dtpBeg.Value.Month); // показівает количесво дней в месяце
            //var dd2 = new DateTime(dtpBeg.Value.Year, dtpBeg.Value.Month, days);
            //dtpEnd.Value = Convert.ToDateTime(dd2); // устанавливаем последнее число месяца


            //dtpEnd.Value = dat2;
            //this.reportViewer1.RefreshReport();

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string addQuery = " ";
            string dt1 = dtpBeg.Value.Year.ToString() + "-" + dtpBeg.Value.Month.ToString() + "-" + dtpBeg.Value.Day.ToString();
            string dt2 = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.Month.ToString() + "-" + dtpEnd.Value.Day.ToString();
//            string dt2 = ddt2.Year.ToString() + "-" + ddt2.Month.ToString() + "-" + ddt2.Day.ToString();



            

                if (String.Equals(Dostup.Codcx, "0") || String.Equals(Dostup.Codcx, null))
            {
                //this.RepairTableAdapter.Fill(this.RepairsDataSet10.Repair, dtpBeg.Value, dtpEnd.Value);
                //this.From_ved_resTableAdapter.Fill_all_ceh(this.VedomostResursov.From_ved_res, dtpBeg.Value.ToShortDateString(), dtpEnd.Value.ToShortDateString());
                //this.From_ved_resTableAdapter.Fill_all_ceh(this.VedomostResursov.From_ved_res);
                if (Change_ceh.ALL) 
                      if (radioButton1.Checked==true)
                        this.From_ved_resTableAdapter.Fill_all_ceh_ord_id(this.VedomostResursov.From_ved_res, dt1.ToString(), dt2.ToString());
                      else
                          this.From_ved_resTableAdapter.Fill_all_ceh_ord_ceh(this.VedomostResursov.From_ved_res, dt1.ToString(), dt2.ToString());
                else
                    if (radioButton1.Checked == true)
                        this.From_ved_resTableAdapter.FillBy_one_ceh_ord_id(this.VedomostResursov.From_ved_res, vibran_ceh.ToString(), dt1.ToString(), dt2.ToString());
                    else
                        this.From_ved_resTableAdapter.FillBy_one_ceh_ord_ceh(this.VedomostResursov.From_ved_res, vibran_ceh.ToString(), dt1.ToString(), dt2.ToString());
            }
            else

            
            {
                //this.RepairTableAdapter.FillBy(this.RepairsDataSet10.Repair, dtpBeg.Value, dtpEnd.Value, Dostup.Codcx);
                
              //  this.From_ved_resTableAdapter.FillBy_one_ceh(this.From_ved_resTableAdapter.FillBy_one_ceh, dtpBeg.Value.ToShortDateString(), dtpEnd.Value.ToShortDateString(), Dostup.Codcx.ToString());
//                this.From_ved_resTableAdapter.FillBy_one_ceh(this.VedomostResursov.From_ved_res, dtpBeg.Value.ToShortDateString(), dtpEnd.Value.ToShortDateString());

                if (radioButton1.Checked == true)
                    this.From_ved_resTableAdapter.FillBy_one_ceh_ord_id(this.VedomostResursov.From_ved_res, Dostup.Codcx.ToString(), dt1.ToString(), dt2.ToString());
                else
                    this.From_ved_resTableAdapter.FillBy_one_ceh_ord_ceh(this.VedomostResursov.From_ved_res, Dostup.Codcx.ToString(), dt1.ToString(), dt2.ToString());
            }
            //this.Vedomost_ResursovTableAdapter.Fill(this.RDSet12.Vedomost_Resursov,dtpBeg.Value,dtpEnd.Value);
            string data1 = dtpBeg.Value.ToShortDateString();
            string data2 = dtpEnd.Value.ToShortDateString();
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data1", data1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data2", data2));
            this.reportViewer1.RefreshReport();

        }
    }
}
