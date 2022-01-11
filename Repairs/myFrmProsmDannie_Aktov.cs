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
    public partial class myFrmProsmDannie_Aktov : Form
    {
        public string now_dat1, now_dat2, ceh, nam_ch;

        public myFrmProsmDannie_Aktov(string rmes, string rgod,string nceh, string namceh)
        {
            InitializeComponent();
            ceh = nceh;
            nam_ch = namceh;

            int Month = Convert.ToInt32(rmes);
            int Year = Convert.ToInt32(rgod);

            int allDayMonth = DateTime.DaysInMonth(Year, Month);
            DateTime Begin = new DateTime(Year, Month, 1);
            DateTime End = new DateTime(Year, Month, allDayMonth);

            now_dat1 = Begin.ToShortDateString();
            now_dat2 = End.ToShortDateString();
        }

        private void myFrmProsmDannie_Aktov_Load(object sender, EventArgs e)
        {
            string cnow_dat1 = now_dat1.Substring(6, 4) + "-" + now_dat1.Substring(3, 2) + "-" + now_dat1.Substring(0, 2);
            string cnow_dat2 = now_dat2.Substring(6, 4) + "-" + now_dat2.Substring(3, 2) + "-" + now_dat2.Substring(0, 2);
            //this.DataTable1TableAdapter.Fill_Data_FioNabl_Uchetka(this.PABDataSet.DataTable1, cnow_dat1.ToString(), cnow_dat2.ToString(), now_nam_nabl1.ToString(),Environment.UserName.ToString());


            // строка 41 заменена на 42 так как понял датаадаптер изза малоценки в инвентарных номерах г  
            //this.Vedomost_ResursovTableAdapter.Fill(this.VedomostResursov.Vedomost_Resursov, ceh,cnow_dat1, cnow_dat2);
            this.vedomost_ResursovTableAdapter1.Fill(this.vedomostResursov_stringInventoryNumber1.Vedomost_Resursov, ceh, cnow_dat1, cnow_dat2);







            // string dat1 = now_dat1.Substring(0, 2) + "-" + now_dat1.Substring(3, 2) + "-" + now_dat1.Substring(6, 4);
            // string dat2 = now_dat2.Substring(0, 2) + "-" + now_dat2.Substring(3, 2) + "-" + now_dat2.Substring(6, 4);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("now_dat1", now_dat1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("now_dat2", now_dat2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nam_ch", nam_ch));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
