using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Repairs
{
    public partial class myfrmPrintVedRes : Form
    {
        public myfrmPrintVedRes()
        {
            InitializeComponent();
        }

        private void myfrmPrintVedRes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RepairOSDS.ReportHatch". При необходимости она может быть перемещена или удалена.
            this.ReportHatchTableAdapter.Fill(this.RepairOSDS.ReportHatch);
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "VedomostResursov.VRVed". При необходимости она может быть перемещена или удалена.
                this.VRVedTableAdapter.Fill(this.VedomostResursov.VRVed);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "VedomostResursov.VRRepPart". При необходимости она может быть перемещена или удалена.
            this.VRRepPartTableAdapter.Fill(this.VedomostResursov.VRRepPart);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "VedomostResursov.VRVozvrDet". При необходимости она может быть перемещена или удалена.
            this.VRVozvrDetTableAdapter.Fill(this.VedomostResursov.VRVozvrDet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "VedomostResursov.VRVozvrMet". При необходимости она может быть перемещена или удалена.
            this.VRVozvrMetTableAdapter.Fill(this.VedomostResursov.VRVozvrMet);

            this.reportViewer1.RefreshReport();
        }
    }
}
