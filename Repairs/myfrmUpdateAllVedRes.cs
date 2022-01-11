using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Repairs
{
    public partial class myfrmUpdateAllVedRes : Form
    {

        DAL dal = new DAL();
        public myfrmUpdateAllVedRes(string NameOS, string InvNumber, string DateIn, string DateOut,
            string State1, string FIO1, string State2, string FIO2, string State3, string FIO3, string State4, string FIO4, string ID, string Shpz, string cx, string uch, string brig, string det, string kod_rem)
        {
            InitializeComponent();

            lbl_Name.Text = NameOS;
            lbl_Inv.Text = InvNumber;
            dtp_dateIn.Text = DateIn;
            dtp_dateOut.Text = DateOut;
            lbl_ID.Text = ID;
      
            txt_SHPZ.Text = Shpz;
     
           //должность 1
            cbx_State1.DataSource = dal.GetAllState1(cx, uch, brig, det);       
            cbx_State1.DisplayMember = "dolg1";
            cbx_State1.ValueMember = "dolg1";
            int index_dolg1 = cbx_State1.FindStringExact(State1);
            cbx_State1.SelectedIndex = index_dolg1 ;

            //должность 2
            cbx_State2.DataSource = dal.GetAllState2(cx, uch, brig, det);
            cbx_State2.DisplayMember = "dolg2";
            cbx_State2.ValueMember = "dolg2";
            int index_dolg2 = cbx_State2.FindStringExact(State2);
            cbx_State2.SelectedIndex = index_dolg2;

            //фамилия 1
            cbx_FIO1.DataSource = dal.GetAllFIO1(cx, uch, brig, det);
            cbx_FIO1.DisplayMember = "fio1";
            cbx_FIO1.ValueMember = "fio1";
            int index_fio1 = cbx_FIO1.FindStringExact(FIO1);
            cbx_FIO1.SelectedIndex = index_fio1;

            cbx_FIO2.DataSource = dal.GetAllFIO2(cx, uch, brig, det);
            cbx_FIO2.DisplayMember = "fio2";
            cbx_FIO2.ValueMember = "fio2";
            int index_fio2 = cbx_FIO2.FindStringExact(FIO2);
            cbx_FIO2.SelectedIndex = index_fio2;

            //должность 3
            cbx_State3.DataSource = dal.GetAllState3(cx, uch, brig, det);
            cbx_State3.DisplayMember = "dolg3";
            cbx_State3.ValueMember = "dolg3";
            int index_dolg3 = cbx_State3.FindStringExact(State3);
            cbx_State3.SelectedIndex = index_dolg3;

            //должность 4
            cbx_State4.DataSource = dal.GetAllState4(cx, uch, brig, det);
            cbx_State4.DisplayMember = "dolg4";
            cbx_State4.ValueMember = "dolg4";
            int index_dolg4 = cbx_State4.FindStringExact(State4);
            cbx_State4.SelectedIndex = index_dolg4;

            //фамилия 3
            cbx_FIO3.DataSource = dal.GetAllFIO3(cx, uch, brig, det);
            cbx_FIO3.DisplayMember = "fio3";
            cbx_FIO3.ValueMember = "fio3";
            int index_fio3 = cbx_FIO3.FindStringExact(FIO3);
            cbx_FIO3.SelectedIndex = index_fio3;

            //фамилия4
            cbx_FIO4.DataSource = dal.GetAllFIO4(cx, uch, brig, det);
            cbx_FIO4.DisplayMember = "fio4";
            cbx_FIO4.ValueMember = "fio4";
            int index_fio4 = cbx_FIO4.FindStringExact(FIO4);
            cbx_FIO4.SelectedIndex = index_fio4;

            //sprravochnik
            cbx_sprrem.DataSource = dal.GetAllsprrem();
            cbx_sprrem.DisplayMember = "name_rem";
            cbx_sprrem.ValueMember = "kod_rem";
            //int index_kod_rem = cbx_sprrem. FindStringExact(kod_rem);
            var list = new List<int>();
            //дописать индекс при добавлении в БД типы ремонтов
            list.Add(1);
            list.Add(2);
            list.Add(5);
            list.Add(6);

            cbx_sprrem.SelectedIndex = list.IndexOf(Convert.ToInt32(kod_rem)) ;



        }

        private void myfrmUpdateAllVedRes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dal.UpdateVedRes(dtp_dateIn.Value.ToString("yyyyMMdd"), dtp_dateOut.Value.ToString("yyyyMMdd"),
                cbx_State1.Text, cbx_FIO1.Text, cbx_State2.Text, cbx_FIO2.Text, lbl_ID.Text, txt_SHPZ.Text.Trim(), 
                cbx_State3.Text, cbx_FIO3.Text, cbx_State4.Text, cbx_FIO4.Text, Convert.ToInt32(cbx_sprrem.SelectedValue)) == true)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbx_sprrem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dal.UpdateVedResFull(dtp_dateIn.Value.ToString("yyyyMMdd"), dtp_dateOut.Value.ToString("yyyyMMdd"),
                   cbx_State1.Text, cbx_FIO1.Text, cbx_State2.Text, cbx_FIO2.Text, lbl_ID.Text, txt_SHPZ.Text.Trim(),
                   cbx_State3.Text, cbx_FIO3.Text, cbx_State4.Text, cbx_FIO4.Text, Convert.ToInt32(cbx_sprrem.SelectedValue));
            MessageBox.Show("Ведомость ресурсов успешно обновила ремонт.");
        }
    }
}
