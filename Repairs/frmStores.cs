/* Changelog
 * 
 * Переписал конструктор формы. Передача прав происходит через конструктор.
 * 
 */

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
    public partial class frmStores : Form
    {
        private string user_p;

        public frmStores(string userp)
        {
            InitializeComponent();
            user_p = userp;
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((user_p == "3") || (user_p == "2") || (user_p == "1") || (user_p == "5"))
            {
                storeBindingNavigator.Enabled = false;
            }
            else
                if (user_p == "4")
                {
                    storeBindingNavigator.Enabled = true;
                }

            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.repairOSDS);
        }

        private void frmStores_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Store". При необходимости она может быть перемещена или удалена.
            this.storeTableAdapter.Fill(this.repairOSDS.Store);
        }
    }
}