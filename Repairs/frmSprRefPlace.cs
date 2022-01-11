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
    public partial class frmSprRefPlace : Form
    {
        private string user_n, user_p;

        public frmSprRefPlace(string usern, string userp)
        {
            InitializeComponent();
            user_n = usern;
            user_p = userp;
        }

        private void frmSprRefPlace_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefPlace". При необходимости она может быть перемещена или удалена.
            this.refPlaceTableAdapter.Fill(this.repairOSDS.RefPlace);
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
            this.refPlaceBindingSource.EndEdit();
            this.refPlaceTableAdapter.Update(this.repairOSDS.RefPlace);
        }
    }
}
