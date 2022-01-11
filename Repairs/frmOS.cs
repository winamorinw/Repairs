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
    public partial class frmOS : Form
    {
        private string user_p;

        public frmOS(string userp)
        {
            InitializeComponent();
            user_p = userp;
        }

        private void sprOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sprOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.repairOSDS);
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            if (user_p == "3")
            {
                sprOSDataGridView.Columns[7].ReadOnly = true;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.SprOSGroup". При необходимости она может быть перемещена или удалена.
            this.sprOSGroupTableAdapter.Fill(this.repairOSDS.SprOSGroup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Store". При необходимости она может быть перемещена или удалена.
            this.storeTableAdapter.Fill(this.repairOSDS.Store);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.SprOS". При необходимости она может быть перемещена или удалена.
            this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);

        }
    }
}