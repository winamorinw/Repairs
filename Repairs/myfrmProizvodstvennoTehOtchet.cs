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
    public partial class myfrmProizvodstvennoTehOtchet : Form
    {
        DAL dal = new DAL();
        public myfrmProizvodstvennoTehOtchet()
        {
            InitializeComponent();
        }

        private void myfrmProizvodstvennoTehOtchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF". При необходимости она может быть перемещена или удалена.
           // this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.Fill(this.RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF);
            //DateTime d1 = new DateTime(2015, 12, 1);
            //DateTime d2 = new DateTime(2015, 12, 31);
            //string ceh1 ="";
            //string uch1 = "";
            //string brig1 = "";
            //string det1 = "";

            //string s = ceh1 + ". " + uch1 + ". " + brig1 + ". " + det1;

            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date1", d1.ToString()));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date2", d2.ToString()));
            //reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fulname", s));
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF". При необходимости она может быть перемещена или удалена.
            //this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.Fill(this.RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF, d1,
            //    d2, 1, 30, 0, 1);

            cbx_ceh.DataSource = dal.GetAllStoreR();
            cbx_ceh.DisplayMember = "StoreName";
            cbx_ceh.ValueMember = "StoreID";

            int ceh = Convert.ToInt32(cbx_ceh.SelectedValue);
            cbx_uch.DataSource = dal.GetAllUchforJournal(ceh);
            cbx_uch.DisplayMember = "Ispolnitel_coduth";
            cbx_uch.ValueMember = "Ispolnitel_coduth";

            int uch = Convert.ToInt32(cbx_uch.SelectedValue);
            cbx_brig.DataSource = dal.GetAllBrigforJournal(ceh, uch);
            cbx_brig.DisplayMember = "Ispolnitel_codbrig";
            cbx_brig.ValueMember = "Ispolnitel_codbrig";

            int brig = Convert.ToInt32(cbx_brig.SelectedValue);
            cbx_det.DataSource = dal.GetAllDetforJournal(ceh, uch, brig);
            cbx_det.DisplayMember = "Ispolnitel_coddet";
            cbx_det.ValueMember = "Ispolnitel_coddet";


            //this.reportViewer1.RefreshReport();
        }

        private void cbx_ceh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ceh = Convert.ToInt32(cbx_ceh.SelectedValue);

                cbx_uch.DataSource = dal.GetAllUchforJournal(ceh);
                cbx_uch.DisplayMember = "Ispolnitel_coduth";
                cbx_uch.ValueMember = "Ispolnitel_coduth";

                int uch = Convert.ToInt32(cbx_uch.SelectedValue);
                cbx_brig.DataSource = dal.GetAllBrigforJournal(ceh, uch);
                cbx_brig.DisplayMember = "Ispolnitel_codbrig";
                cbx_brig.ValueMember = "Ispolnitel_codbrig";

                int brig = Convert.ToInt32(cbx_brig.SelectedValue);
                cbx_det.DataSource = dal.GetAllDetforJournal(ceh, uch, brig);
                cbx_det.DisplayMember = "Ispolnitel_coddet";
                cbx_det.ValueMember = "Ispolnitel_coddet";
            }
            catch { }
        }

        private void cbx_uch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ceh = Convert.ToInt32(cbx_ceh.SelectedValue);

                //cbx_uch.DataSource = dal.GetAllUchforJournal(ceh);
                //cbx_uch.DisplayMember = "Ispolnitel_coduth";
                //cbx_uch.ValueMember = "Ispolnitel_coduth";

                int uch = Convert.ToInt32(cbx_uch.SelectedValue);
                cbx_brig.DataSource = dal.GetAllBrigforJournal(ceh, uch);
                cbx_brig.DisplayMember = "Ispolnitel_codbrig";
                cbx_brig.ValueMember = "Ispolnitel_codbrig";

                int brig = Convert.ToInt32(cbx_brig.SelectedValue);
                cbx_det.DataSource = dal.GetAllDetforJournal(ceh, uch, brig);
                cbx_det.DisplayMember = "Ispolnitel_coddet";
                cbx_det.ValueMember = "Ispolnitel_coddet";
            }
            catch { }
        }

        private void cbx_brig_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ceh = Convert.ToInt32(cbx_ceh.SelectedValue);

                //cbx_uch.DataSource = dal.GetAllUchforJournal(ceh);
                //cbx_uch.DisplayMember = "Ispolnitel_coduth";
                //cbx_uch.ValueMember = "Ispolnitel_coduth";

                int uch = Convert.ToInt32(cbx_uch.SelectedValue);
                //cbx_brig.DataSource = dal.GetAllBrigforJournal(ceh, uch);
                //cbx_brig.DisplayMember = "Ispolnitel_codbrig";
                //cbx_brig.ValueMember = "Ispolnitel_codbrig";

                int brig = Convert.ToInt32(cbx_brig.SelectedValue);
                cbx_det.DataSource = dal.GetAllDetforJournal(ceh, uch, brig);
                cbx_det.DisplayMember = "Ispolnitel_coddet";
                cbx_det.ValueMember = "Ispolnitel_coddet";
            }
            catch { }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DateTime d1 = dtp_Start.Value;
            DateTime d2 = dtpFinish.Value;

            int ceh = Convert.ToInt32(cbx_ceh.SelectedValue);
            int uch = Convert.ToInt32(cbx_uch.SelectedValue);
            int brig = Convert.ToInt32(cbx_brig.SelectedValue);
            int det = Convert.ToInt32(cbx_det.SelectedValue);

            string s = ceh.ToString() + ". " + uch.ToString() + ". " + brig.ToString() + ". " + det.ToString();

            string name = txt_dolg.Text + "    _______________________________    " + txt_fio.Text;

            string date1T = d1.ToString("dd.MM.yyyy");
            string date2T = d2.ToString("dd.MM.yyyy");

            // Передаем параметры в отчет
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date1", date1T));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("date2", date2T));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fulname", s));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("podpis", name));

            this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.Fill(this.RepairsDataSet2.ProizvodstvoTehnicheskiyOtchetF, d1,
               d2, ceh, uch, brig, det);
            this.reportViewer1.RefreshReport();
            reportViewer1.RefreshReport();
        }

        private void myfrmProizvodstvennoTehOtchet_Resize(object sender, EventArgs e)
        {
            reportViewer1.Width = this.Width - 100;
            reportViewer1.Height = this.Height - 200;
        }
    }
}
