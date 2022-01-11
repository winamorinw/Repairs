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
    public partial class frmUpdateCh_chas : Form
    {
        public frmUpdateCh_chas(string ID, string name_job, string ch_chas)
        {
            InitializeComponent();
            this.lbl_ID.Text = ID;
            this.label1.Text = name_job;
            this.tbx_ch_chas.Text = ch_chas;

            
        }

        private void frmUpdateCh_chas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            DAL dal = new DAL();
          
            string ch_chas;

            if (String.IsNullOrEmpty(tbx_ch_chas.Text))
                ch_chas = "0.00";
            else
            {
                ch_chas = tbx_ch_chas.Text.Replace(",", ".");
            }




            if (dal.Update_Ch_chas(Convert.ToInt32(lbl_ID.Text),ch_chas.ToString()) == true)
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
