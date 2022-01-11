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
    public partial class frmAadUupdateJobFromAKT : Form
    {
        public string remusl = "";
        public frmAadUupdateJobFromAKT(string ID, string name_job, string rem_usl, string Repair_id)
        {
            InitializeComponent();
            remusl = rem_usl;
            lbl_ID.Text = ID;
            txtBox.Text=name_job;
            lbl_id_repair.Text = Repair_id;


            //MessageBox.Show(vipolnenie);
            //if (vipolnenie == "insert") ;
            //{
            //    MessageBox.Show("insert");
            //}

            //if (vipolnenie == "add") ;
            //{
            //    MessageBox.Show("add");
            //}


        }

        private void frmAadUupdateJobFromAKT_Load(object sender, EventArgs e)
        {

            //if (vipolnenie == "insert") ;
            //{
            //    MessageBox.Show("insert");
            //}

            //if (vipolnenie == "add") ;
            //{
            //    MessageBox.Show("add");
            //}

        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            //txtBox2.Text=dal.SaveNewJobToAKT(txtBox.Text, lbl_ID.Text);

            if (dal.SaveNewJobToAKT(txtBox.Text, lbl_ID.Text, remusl.ToString(), lbl_id_repair.Text) == true)
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
