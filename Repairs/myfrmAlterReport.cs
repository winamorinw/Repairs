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
    public partial class myfrmAlterReport : Form
    {
        DAL dal = new DAL();
        public myfrmAlterReport()
        {
            DateTime date1 = new DateTime(1753, 1, 1);

            InitializeComponent();
            //вот это для даты начала ремонта
            if (InfoRepair.DateNext.Equals(""))
            {
                dtp_dataNext.Value = date1;
                btn_DateNext.Visible = true;
            }
            else
            {
                btn_DateNext.Visible = false;
            }

            //работаем с пустой датой окончания ремонта
            if (InfoRepair.DateOut.Equals(""))
            {
                dtp_dataOut.Value = date1;
                btn_dataOut.Visible = true;
            }
            else
            {
                btn_dataOut.Visible = false;
            }

            txt_AsRDivis.Text = InfoRepair.AsRDivis;
            txt_Divis.Text = InfoRepair.Divis;
            dtp_dateIn.Text = InfoRepair.DataIn;
            txt_typeFlaut.Text = InfoRepair.TypeFlaut;
            txt_cause.Text = InfoRepair.Cause;
            rtxt_Note.Text = InfoRepair.Note;
            dtp_dataOut.Text = InfoRepair.DateOut;

            //дата начала ремонта
            if (InfoRepair.DateNext == "")
            {
                dtp_dataNext.Value = date1;
            }
            else
            {
                dtp_dataNext.Text = InfoRepair.DateNext;
            }

            //Дата окончания ремонта
            if (InfoRepair.DateOut == "")
            {
                dtp_dataOut.Value = date1;
            }
            else
            {
                dtp_dataOut.Text = InfoRepair.DateOut;
            }

            if (Dostup.Visib == 1)
            {
                btn_SelectMol.Enabled = false;
                button1.Enabled = false;

                //btn_delDateOut.Enabled = false;
                //btn_delNextDate.Enabled = false;
                //btn_dataOut.Enabled = false;
                //btn_DateNext.Enabled = false;
                //dtp_dataNext.Enabled = false;
                //dtp_dataOut.Enabled = false;

            }
            else { btn_SelectMol.Enabled = true; button1.Enabled = true; }
            txt_NotedataNext.Text = InfoRepair.Notedatanext;
            txt_Responsible.Text = InfoRepair.CODCX + " " + InfoRepair.CODUTH + " " + InfoRepair.CODBRIG + " " + InfoRepair.CODDET + " " + InfoRepair.NAMEDET;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void cbx_Responsible_Click(object sender, EventArgs e)
        {
            myfrmSelectMol myfrmSelectMol = new myfrmSelectMol();
            myfrmSelectMol.ShowDialog();
            txt_Responsible.Text = InfoRepair.CODCX + " " + InfoRepair.CODUTH + " " + InfoRepair.CODBRIG + " " + InfoRepair.CODDET + " " + InfoRepair.NAMEDET;
        }

        private void SettingsAllMol()
        {


        }

        private void btn_SelectMol_Click(object sender, EventArgs e)
        {
            myfrmSelectMol myfrmSelectMol = new myfrmSelectMol();
            myfrmSelectMol.FormClosed += (closedSender, closedE) =>
            {
                txt_Responsible.Text = InfoRepair.CODCX + " " + InfoRepair.CODUTH + " " + InfoRepair.CODBRIG + " " + InfoRepair.CODDET + " " + InfoRepair.NAMEDET;
            };

            myfrmSelectMol.ShowDialog();
        }

        private void btn_SaveRepair_Click(object sender, EventArgs e)
        {
            InfoRepair.Note = rtxt_Note.Text;
            InfoRepair.Cause = txt_cause.Text;
            InfoRepair.TypeFlaut = txt_typeFlaut.Text;
            InfoRepair.Notedatanext = txt_NotedataNext.Text;

            //это для даты нчаал ремонта
            if (dtp_dataNext.Value.ToString("yyyyMMdd") == "17530101")
            {
                InfoRepair.DateNext = "";
            }
            else
            {
                InfoRepair.DateNext = dtp_dataNext.Value.ToString("yyyyMMdd");
            }

            //а это для даты завершения ремонта

            if (dtp_dataOut.Value.ToString("yyyyMMdd") == "17530101")
            {
                InfoRepair.DateOut = "";
            }
            else
            {
                InfoRepair.DateOut = dtp_dataOut.Value.ToString("yyyyMMdd");
            }
            InfoRepair.DataIn = dtp_dateIn.Value.ToString("yyyyMMdd");
            string mol = txt_Responsible.Text;

            if (dal.AlterRepair(mol.ToString()) == true)
            {
                MessageBox.Show("Запис вдало змінено");
            }
            else
            {
                MessageBox.Show("Помилка! Оновлення закінчилося невдачею :-(");
            }
            this.Close();
        }

        private void dtp_dataNext_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_DateNext_Click(object sender, EventArgs e)
        {

            btn_DateNext.Visible = false;
            dtp_dataNext.Value = DateTime.Today;
        }

        private void btn_delNextDate_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1753, 1, 1);
            dtp_dataNext.Value = date1;
            btn_DateNext.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1753, 1, 1);
            dtp_dataOut.Value = date1;
            btn_dataOut.Visible = true;
        }

        private void btn_dataOut_Click(object sender, EventArgs e)
        {
            btn_dataOut.Visible = false;
            dtp_dataOut.Value = DateTime.Today;
        }

        private void myfrmAlterReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_Responsible.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
