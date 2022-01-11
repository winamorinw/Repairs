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
    public partial class frmAddJobInRepairForAKT_F2 : Form
    {
        public frmAddJobInRepairForAKT_F2(string ID_Repair)
        {
            InitializeComponent();
            lbl_ID.Text = ID_Repair;
            txtBoxNamRab.Text = "";
            txtBoxLjudGod.Text = "";
        }

        private void frmAddJobInRepairForAKT_F2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxNamRab.Text.Trim().Length < 1)
            {
                MessageBox.Show("Не можна зберегти пусте значення");
            }
            else
            {

                DAL dal = new DAL();
                //txtBox2.Text=dal.SaveNewJobToAKT(txtBox.Text, lbl_ID.Text);

                if (dal.SaveNewJobToAKTFromRepair(txtBoxNamRab.Text, lbl_ID.Text, txtBoxLjudGod.Text.Replace(',','.') ) == true)
                {
                    this.DialogResult = DialogResult.OK;
                }

                else
                {
                    this.DialogResult = DialogResult.No;
                }

            
            }



        }
    }
}
