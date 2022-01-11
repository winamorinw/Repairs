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
    public partial class myfrmReportPTOPrint : Form
    {
        public myfrmReportPTOPrint( int idPTO, string dateStart, string dateFinish, string fullName, string numberPTO)
        {


            InitializeComponent();
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date1", dateStart));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date2", dateFinish));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fulname", fullName));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("number", numberPTO));


            try
            {

                this.proizvodTehOtchetWithNomerTableAdapter.Fill(this.repairsDataSet3.ProizvodTehOtchetWithNomer, Convert.ToInt32(idPTO));
                //this.proi.Fill(this.RepairsDataSet3.ProizvodTehOtchetWithNomer, idPTO);
                //this.reportViewer1.RefreshReport();
                reportViewer1.RefreshReport();
            }
            catch { }

        }

        private void myfrmReportPTOPrint_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairsDataSet3.ProizvodTehOtchetWithNomer". При необходимости она может быть перемещена или удалена.
           // this.proizvodTehOtchetWithNomerTableAdapter.Fill(this.repairsDataSet3.ProizvodTehOtchetWithNomer, );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF". При необходимости она может быть перемещена или удалена.
            //this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.Fill(this.RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF);
           
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF". При необходимости она может быть перемещена или удалена.
            //this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.Fill(this.RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
