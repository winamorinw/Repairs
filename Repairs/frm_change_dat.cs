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
    public partial class frm_change_dat : Form
    {

        
        public string ReplId;

        public frm_change_dat(string ReplacedId)
        {
            InitializeComponent();
            this.ReplId = ReplacedId;
            
        }

        private void frm_change_dat_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
//            MessageBox.Show(this.ReplId.ToString());
            if (dal.Update_DatReplacePart(dateTimePicker1.Value.ToShortDateString(), DateTime.Today.ToShortDateString(), this.ReplId.ToString()) == true)
            {
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                this.DialogResult = DialogResult.No;
            }



            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
