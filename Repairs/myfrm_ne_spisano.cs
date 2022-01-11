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
    public partial class myfrm_ne_spisano : Form
    {
        public int nceh ;
        public DateTime D_LastDatOfMonth ;

        public myfrm_ne_spisano(int tekceh,DateTime LastDatOfMonth)
        {
            InitializeComponent();
            nceh = tekceh;
            D_LastDatOfMonth =LastDatOfMonth;
        }

        private void myfrm_ne_spisano_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "VedomostResursov.NeSpisMater". При необходимости она может быть перемещена или удалена.
            string dt2 = D_LastDatOfMonth.Year.ToString() + "-" + D_LastDatOfMonth.Month.ToString() + "-" + D_LastDatOfMonth.Day.ToString();

            this.NeSpisMaterTableAdapter.Fill(this.VedomostResursov.NeSpisMater, nceh, D_LastDatOfMonth);
            int y = 0;
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nceh", nceh.ToString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dt2", dt2));

            int d = 0;
            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
