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
    public partial class myfrmUpdateAllForm2 : Form
    {

        DAL dal = new DAL();
        public myfrmUpdateAllForm2(string NameOS,string InvNumber,
                     string FIO1,  string FIO2, string FIO3, string FIO4, string ID, string cx, string uch, string brig, string det)
        {
            InitializeComponent();

            lbl_Name.Text = NameOS;
            lbl_Inv.Text = InvNumber;
           // dtp_dateIn.Text = DateIn;
          //  dtp_dateOut.Text = DateOut;
            lbl_ID.Text = ID;

          //  txt_SHPZ.Text = Shpz;

            //должность 1
            //cbx_State1.DataSource = dal.GetAllState1f2(cx, uch, brig, det);
            //cbx_State1.DisplayMember = "dolg1f2";
            //cbx_State1.ValueMember = "dolg1f2";
            //int index_dolg1 = cbx_State1.FindStringExact(State1);
            //cbx_State1.SelectedIndex = index_dolg1;

            //должность 2
            //cbx_State2.DataSource = dal.GetAllState2f2(cx, uch, brig, det);
            //cbx_State2.DisplayMember = "dolg2f2";
            //cbx_State2.ValueMember = "dolg2f2";
            //int index_dolg2 = cbx_State2.FindStringExact(State2);
            //cbx_State2.SelectedIndex = index_dolg2;

            //фамилия 1
            cbx_FIO1.DataSource = dal.GetAllFIO1f2(cx, uch, brig, det, "rem");
            cbx_FIO1.DisplayMember = "fio1f2";
            cbx_FIO1.ValueMember = "fio1f2";
            int index_fio1 = cbx_FIO1.FindStringExact(FIO1);
            cbx_FIO1.SelectedIndex = index_fio1;

            cbx_FIO2.DataSource = dal.GetAllFIO2f2(cx, uch, brig, det, "rem");
            cbx_FIO2.DisplayMember = "fio2f2";
            cbx_FIO2.ValueMember = "fio2f2";
            int index_fio2 = cbx_FIO2.FindStringExact(FIO2);
            cbx_FIO2.SelectedIndex = index_fio2;


            //cbx_State1.DataSource = dal.GetAllState1f2(cx, uch, brig, det);
            //cbx_State1.DisplayMember = "dolg1f2";
            //cbx_State1.ValueMember = "dolg1f2";
            //int index_State1 = cbx_State1.FindStringExact(State1);
            //cbx_State1.SelectedIndex = index_State1;

            //cbx_State2.DataSource = dal.GetAllState2f2(cx, uch, brig, det);
            //cbx_State2.DisplayMember = "dolg2f2";
            //cbx_State2.ValueMember = "dolg2f2";
            //int index_State2 = cbx_State2.FindStringExact(State2);
            //cbx_State2.SelectedIndex = index_State2;

            //cbx_State3.DataSource = dal.GetAllState3f2(cx, uch, brig, det);
            //cbx_State3.DisplayMember = "dolg3f2";
            //cbx_State3.ValueMember = "dolg3f2";
            //int index_State3 = cbx_State3.FindStringExact(State3);
            //cbx_State3.SelectedIndex = index_State3;

            //cbx_State4.DataSource = dal.GetAllState4f2(cx, uch, brig, det);
            //cbx_State4.DisplayMember = "dolg4f2";
            //cbx_State4.ValueMember = "dolg4f2";
            //int index_State4 = cbx_State4.FindStringExact(State4);
            //cbx_State4.SelectedIndex = index_State4;
            
            
            //должность 3
            //cbx_State3.DataSource = dal.GetAllState3f2(cx, uch, brig, det);
            //cbx_State3.DisplayMember = "dolg3f2";
            //cbx_State3.ValueMember = "dolg3f2";
            //int index_dolg3 = cbx_State3.FindStringExact(State3);
            //cbx_State3.SelectedIndex = index_dolg3;

            ////должность 4
            //cbx_State4.DataSource = dal.GetAllState4f2(cx, uch, brig, det);
            //cbx_State4.DisplayMember = "dolg4f2";
            //cbx_State4.ValueMember = "dolg4f2";
            //int index_dolg4 = cbx_State4.FindStringExact(State4);
            //cbx_State4.SelectedIndex = index_dolg4;

            //фамилия 3
            cbx_FIO3.DataSource = dal.GetAllFIO3f2(cx, uch, brig, det, "rem");
            cbx_FIO3.DisplayMember = "fio3f2";
            cbx_FIO3.ValueMember = "fio3f2";
            int index_fio3 = cbx_FIO3.FindStringExact(FIO3);
            cbx_FIO3.SelectedIndex = index_fio3;

            //фамилия4
            cbx_FIO4.DataSource = dal.GetAllFIO4f2(cx, uch, brig, det, "rem");
            cbx_FIO4.DisplayMember = "fio4f2";
            cbx_FIO4.ValueMember = "fio4f2";
            int index_fio4 = cbx_FIO4.FindStringExact(FIO4);
            cbx_FIO4.SelectedIndex = index_fio4;



        }

        private void button1_Click(object sender, EventArgs e)
        {





            if (dal.UpdateForm2(cbx_FIO1.Text.Trim(), cbx_FIO2.Text.Trim(),  cbx_FIO3.Text.Trim(), cbx_FIO4.Text.Trim(),lbl_ID.Text) == true)    
            {
                   MessageBox.Show("Запись удачно обновлена");
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else {
                MessageBox.Show("Ошибка обновления!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void myfrmUpdateAllForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
