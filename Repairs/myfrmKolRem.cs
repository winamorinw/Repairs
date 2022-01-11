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
    public partial class myfrmKolRem : Form
    {
        public myfrmKolRem(string Inv_n, string Obekt, string Inv_name)
        {

            InitializeComponent();
            Inv_n = Inv_n.ToString();
            Obekt = Obekt.ToString();
            Inv_name = Inv_name.ToString();
            
            int Inv_n2 = Convert.ToInt32(Inv_n);
            int Obekt2 = Convert.ToInt32(Obekt);            
            

            label1.Text = Inv_n;
            label2.Text = Obekt;
            label3.Text = Inv_name;
            DAL_DBF dal_dbf = new DAL_DBF();
            dgv_AllREM.DataSource = dal_dbf.GetAllREM(Inv_n2, Obekt2);

            try
            {
                dgv_AllREM.Columns["god"].HeaderText = "Рік";
                dgv_AllREM.Columns["mes"].HeaderText = "місяць ";
                dgv_AllREM.Columns["cex"].HeaderText = "Цех";
                dgv_AllREM.Columns["brig"].HeaderText = "Бюро";
                dgv_AllREM.Columns["rem_cum"].HeaderText = "Сума ремонту";
                dgv_AllREM.Columns["cht"].HeaderText = "Рахунок";
            }
            catch
            {
            }

            
        }

        private void myfrmKolRem_Load(object sender, EventArgs e)
        {
            
            
        }

        private void dgv_AllREM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
