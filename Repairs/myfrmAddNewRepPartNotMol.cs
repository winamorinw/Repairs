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
    public partial class myfrmAddNewRepPartNotMol : Form
    {
        DAL dal = new DAL();
        public myfrmAddNewRepPartNotMol()
        {
            InitializeComponent();

            cbx_EdIzm.DataSource = dal.GetAllEdIzm();
            cbx_EdIzm.DisplayMember = "Name";
            cbx_EdIzm.ValueMember = "Name";
            cbx_TypeDetail.DataSource = dal.GetAllTypeRepPart();
            cbx_TypeDetail.DisplayMember = "Name";
            cbx_TypeDetail.ValueMember = "ID";
            
        }

        private void myfrmAddNewRepPartNotMol_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddRepPart_Click(object sender, EventArgs e)
        {
            SaveRepPart();
        }

        private void btnAddandExit_Click(object sender, EventArgs e)
        {
            SaveRepPart();
            this.Close();
        }

        private void SaveRepPart() {
            if (txt_Name.Text.Trim().Length > 0)
            {


                if (dal.SaveNewReplacedPartNotMol(txt_Quantity.Text.Replace(",", "."), txt_Name.Text, cbx_EdIzm.SelectedValue.ToString(),
                   dtp_date.Value.ToString("yyyyMMdd"), cbx_TypeDetail.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Запис додавання! ");
                    txt_Name.Text = "";
                    txt_Quantity.Text = "";
                }
                else
                {
                    MessageBox.Show("Помилка додавання!");
                    txt_Name.Text = "";
                    txt_Quantity.Text = "";
                }


            }
            else
            {
                MessageBox.Show("Введіть назву деталі!!!");
            }
        
        
        
        
        
        }

    }
}
