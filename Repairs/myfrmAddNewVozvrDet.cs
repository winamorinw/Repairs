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
    public partial class myfrmAddNewVozvrDet : Form
    {
        DAL dal = new DAL();
        public myfrmAddNewVozvrDet()
        {
            InitializeComponent();
        }

        private void btn_SaveNewVozvrMet_Click(object sender, EventArgs e)
        {

            //if (txt_ednome.Text.ToString().Trim().Length == 0)
            //{
            //    MessageBox.Show("Не заповнен Единий №");
            //    txt_ednome.Select();
            //    return;
            //}
              

                //MessageBox.Show(txt_Name.Text + cbx_EdIzm.SelectedValue.ToString() + txt_Price.Text + txt_Quantity.Text + txt_Sum.Text +  txt_Note.Text +
                //  dtp_dataVozvrMet.Value.ToString("yyyyMMdd"));
                 DateTime DatNow = DateTime.Now;
                if (dal.SavevozvrDet(txt_Name.Text, txt_Quantity.Text, 
                    txt_Note.Text, dtp_dataVozvrDet.Value.ToString("yyyyMMdd"),"",DatNow) == true)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }

        }

        private void myfrmAddNewVozvrDet_Load(object sender, EventArgs e)
        {

        }
    }
}
