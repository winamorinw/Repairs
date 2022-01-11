using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Repairs
{
    public partial class myfrmNewJob : Form
    {
        DAL dal = new DAL();
        string Redair_Id;
        public myfrmNewJob(string s, string Repair_ID)
        {
            
            //String s;
            InitializeComponent();
            lbl_nameRepair.Text = s;
            Redair_Id = Repair_ID;
                      
            cbx_Job.DataSource = dal.GetAllJobsforAll();
            cbx_Job.DisplayMember = "JobName";
            cbx_Job.ValueMember = "JobCode";

            //label1.Text = dal.GetUser()[0].ToString();
            dgv_User.DataSource = dal.GetUser();
            dgv_User.RowHeadersVisible = false;
            dgv_User.Columns[0].HeaderText = "Пользователь";
            dgv_User.Visible = false;
            string myname = dgv_User.Rows[0].Cells[0].Value.ToString();

            label1.Text = "Пользователь      " + myname;

           // arra
            

            
            
        }

        private void myfrmNewJob_Load(object sender, EventArgs e)
        {

        }

        private void btn_saveJob_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Redair_Id + cbx_Job.SelectedValue.ToString());


            if (dal.SaveNewJob(Redair_Id, cbx_Job.SelectedValue.ToString())==true)
            {
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                this.DialogResult = DialogResult.No;
            }

        }



        public string RepairId { get; set; }
    }
}
