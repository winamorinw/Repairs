using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Repairs
{
    public partial class myfrmSelectMol : Form
    {
        DAL_DBF daldbf = new DAL_DBF();
        public myfrmSelectMol()
        {
            InitializeComponent();
            dgv_AllMol.DataSource = daldbf.GetAllMOL();
            Settings_AllMol();

        }

        private void Settings_AllMol() {
            if (dgv_AllMol.RowCount > 0)
            {

                dgv_AllMol.Columns["CODCX"].HeaderText = "Цех";
                dgv_AllMol.Columns["CODUTH"].HeaderText = "Участок";
                dgv_AllMol.Columns["CODBRIG"].HeaderText = "Бригада";
                dgv_AllMol.Columns["CODDET"].HeaderText = "№ Подотчет. Лица";
                dgv_AllMol.Columns["NAMEDET"].HeaderText = "Должность - ФИО";

                dgv_AllMol.Columns["CODCX"].DisplayIndex = 0;
                dgv_AllMol.Columns["CODUTH"].DisplayIndex = 1;
                dgv_AllMol.Columns["CODBRIG"].DisplayIndex = 2;
                dgv_AllMol.Columns["CODDET"].DisplayIndex = 3;
                dgv_AllMol.Columns["NAMEDET"].DisplayIndex = 4;

                dgv_AllMol.Columns["CODCX"].Width = 40;
                dgv_AllMol.Columns["CODUTH"].Width = 70;
                dgv_AllMol.Columns["CODBRIG"].Width = 85;
                dgv_AllMol.Columns["NAMEDET"].Width = 530;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(InfoRepair.CODCX + " " + InfoRepair.CODUTH + " " + InfoRepair.CODBRIG + " " + InfoRepair.CODDET + " " + InfoRepair.NAMEDET);                        
            this.Close();
        }

        private void dgv_AllMol_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            InfoRepair.CODCX = dgv_AllMol.Rows[e.RowIndex].Cells["CODCX"].Value.ToString();
            InfoRepair.CODUTH = dgv_AllMol.Rows[e.RowIndex].Cells["CODUTH"].Value.ToString();
            InfoRepair.CODBRIG = dgv_AllMol.Rows[e.RowIndex].Cells["CODBRIG"].Value.ToString();
            InfoRepair.CODDET = dgv_AllMol.Rows[e.RowIndex].Cells["CODDET"].Value.ToString();
            InfoRepair.NAMEDET = dgv_AllMol.Rows[e.RowIndex].Cells["NAMEDET"].Value.ToString();
           // this.Close();
        }

        private void myfrmSelectMol_Load(object sender, EventArgs e)
        {

        }

        private void myfrmSelectMol_Load_1(object sender, EventArgs e)
        {

        }

        private void dgv_AllMol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
