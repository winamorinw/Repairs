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
    public partial class myfrmRedZhpz : Form
    {
        public myfrmRedZhpz(string ID, string NameOs, string InvNumberOS, string IspCx, string IspUch, string IspBrig, string IspDet, string mes, string god, string Obekt, string PeriodData2, string Shpz)
        {
            InitializeComponent();
            lbl_ID.Text = ID;
            lbl_Name.Text = NameOs;
            lbl_Inv.Text = InvNumberOS;
            lbl_VedR.Text = ("Акт по послугам № ");
            txt_Shpz.Text = Shpz;
        }

        private void myfrmRedZhpz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            //txtBox2.Text=dal.SaveNewJobToAKT(txtBox.Text, lbl_ID.Text);

            if (dal.UpdateShpzAktiUsl(lbl_ID.Text, txt_Shpz.Text) == true)
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
