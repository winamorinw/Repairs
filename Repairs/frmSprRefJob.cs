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
    public partial class frmSprRefJob : Form
    {
        private string user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;

        public frmSprRefJob(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();
            user_n = usern;
            user_p = userp;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
        }

        private void frmSprRefJobRefPlace_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefJob". При необходимости она может быть перемещена или удалена.
            this.refJobTableAdapter.Fill(this.repairOSDS.RefJob);
            if (user_p == "3")
            {
                this.bindingNavigator1.Enabled = false;
                this.dataGridView1.AllowUserToAddRows = false;
                this.dataGridView1.AllowUserToDeleteRows = false;
                this.dataGridView1.ReadOnly = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.refJobBindingSource.EndEdit();
            this.refJobTableAdapter.Update(this.repairOSDS.RefJob);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
