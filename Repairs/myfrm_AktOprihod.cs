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
    public partial class myfrm_AktOprihod : Form
    {
        DAL dal = new DAL();
        public myfrm_AktOprihod()
        {
            InitializeComponent();
            cbx_Ed_Izm.DataSource = dal.GetAllEdIzm();
            cbx_Ed_Izm.DisplayMember = "Name";
            cbx_Ed_Izm.ValueMember = "Name";
        }

        private void btn_SelectOS_Click(object sender, EventArgs e)
        {
            myfrmSearchTMC myfrmSearchTMC = new myfrmSearchTMC("rem","","");
            //отлавливаем нажатие кнопки на форме выбора ТМЦ


            myfrmSearchTMC.FormClosed += (closedSender, closedE) =>
            {

                {
                    txt_invNumberOS.Text = Inv_Number.Inv_n;
                    txt_NameOS.Text = Inv_Number.Inv_name;
                }

            };
            myfrmSearchTMC.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ProcIznos_TextChanged(object sender, EventArgs e)
        {
            getSumMetalVozvr();
        }

        private void txt_PriceNewTMC_TextChanged(object sender, EventArgs e)
        {
            getSumMetalVozvr();
        }

        //Получение цены износа
        public void getSumMetalVozvr()
        {

            try
            {
                txt_PriceIznos.Text = (Convert.ToDouble(txt_ProcIznos.Text)/100 * Convert.ToDouble(txt_PriceNewTMC.Text)).ToString();
                txt_PriceIznos.BackColor = Color.Yellow;
                txt_PriceIznos.ForeColor = Color.Black;
            }
            catch
            {
                txt_PriceIznos.BackColor = Color.Pink;
                txt_PriceIznos.Text = "Помилка!!!";
                txt_PriceIznos.ForeColor = Color.Black;
            }

        }
        //Кнопк добавления и сохранения
        private void txt_AddBuRepPPart_Click(object sender, EventArgs e)
        {
            bool znak = false;
            if(txt_FIO_Chlen1.Enabled == true){
            //создание акта на оприходывание 
                if (dal.CreateNewAct(txt_NameOS.Text, txt_invNumberOS.Text, txt_FIO_Pred.Text, txt_dolj_pred.Text,
                   txt_FIO_Chlen1.Text, txt_doljChlen1.Text, txt_Fio_Chlen2.Text, txt_doljChlen2.Text,
                   dtp_date.Value.ToString("yyyyMMdd")) == true)
                {
                    txt_NumberAct.Text = dal.ReturnActNumber().ToString();
                    znak = true;
                }
                else {
                   // textBox1.Text = dal.CreateNewActquery(txt_NameOS.Text, txt_invNumberOS.Text, txt_FIO_Pred.Text, txt_dolj_pred.Text,
                 //  txt_FIO_Chlen1.Text, txt_doljChlen1.Text, txt_Fio_Chlen2.Text, txt_doljChlen2.Text,
                 //  dtp_date.Value.ToString("yyyyMMdd"));
                    MessageBox.Show("Акт не створений!!!");
                }
            
            }

            

           // textBox1.Text = dal.AddNewBUReplacedPartQuery(txt_NameOS.Text, txt_invNumberOS.Text, txt_FIO_Pred.Text, txt_dolj_pred.Text,
                  //txt_FIO_Chlen1.Text, txt_doljChlen1.Text, txt_Fio_Chlen2.Text, txt_doljChlen2.Text,
                  //dtp_date.Value.ToString("yyyyMMdd"), txt_NameRepPart.Text, txt_VesEd.Text, cbx_Ed_Izm.SelectedText,
                  //txtKolvo.Text, txt_ProcIznos.Text, txt_PriceNewTMC.Text, txt_PriceIznos.Text, txt_PriceMet1Ton.Text);

            if (dal.AddNewBUReplacedPart(txt_NumberAct.Text, txt_NameRepPart.Text, txt_VesEd.Text.Replace(',', '.'), cbx_Ed_Izm.SelectedValue.ToString(),
                  txtKolvo.Text.Replace(',', '.'), txt_ProcIznos.Text.Replace(',', '.'), txt_PriceNewTMC.Text.Replace(',', '.'),
                  txt_PriceIznos.Text.Replace(',', '.'), txt_PriceMet1Ton.Text.Replace(',', '.')) == true)
            {

                MessageBox.Show("Запис вдало додана");
                SettingsFormBU();

                dgv_bu_RepairPart.DataSource = dal.GetBU_Rep_Part(txt_NumberAct.Text);
                if(dgv_bu_RepairPart.RowCount>0){
                    SettingsdgvbuReplace();
                }
               // textBox1.Text = dal.GetBU_Rep_Partquery(dtp_date.Value.ToString("yyyyMMdd"), txt_invNumberOS.Text, txt_FIO_Pred.Text);
            }
            else {
                textBox1.Text = dal.AddNewBUReplacedPartquery1(txt_NumberAct.Text, txt_NameRepPart.Text, txt_VesEd.Text, cbx_Ed_Izm.SelectedValue.ToString(),
                  txtKolvo.Text, txt_ProcIznos.Text, txt_PriceNewTMC.Text, txt_PriceIznos.Text, txt_PriceMet1Ton.Text);
                MessageBox.Show("Перевірте внесену інформацію");
            }
        }

        public void SettingsFormBU() {
            txt_FIO_Pred.Enabled = false;
            txt_Fio_Chlen2.Enabled = false;
            txt_FIO_Chlen1.Enabled = false;
            txt_dolj_pred.Enabled = false;
            txt_doljChlen1.Enabled = false;
            txt_doljChlen2.Enabled = false;
            dtp_date.Enabled = false;

            txt_NameRepPart.Text = "";
            txt_VesEd.Text = "";
            txtKolvo.Text = "";
            txt_PriceIznos.Text = "0";
            txt_ProcIznos.Text = "0";
            txt_PriceNewTMC.Text = "0";
            txt_PriceMet1Ton.Text = "0";

        }

        public void SettingsdgvbuReplace() {
            dgv_bu_RepairPart.Columns["NameTMC"].HeaderText = "Найменування";
            dgv_bu_RepairPart.Columns["Ves_TMC"].HeaderText = "Вага";
            dgv_bu_RepairPart.Columns["ed_izm_TMC"].HeaderText = "Од.вим";
            dgv_bu_RepairPart.Columns["Kol-voTMC"].HeaderText = "Кіл-ть";
            dgv_bu_RepairPart.Columns["Proc_iznos"].HeaderText = "% зносу";
            dgv_bu_RepairPart.Columns["PriceNewTMC"].HeaderText = "Ціна нової ТМЦ";
            dgv_bu_RepairPart.Columns["PriceIznosTMC"].HeaderText = "Ціна зносу";
            dgv_bu_RepairPart.Columns["PriceTonnaMet"].HeaderText = "Ціна тони";

  

        
        }

        private void myfrm_AktOprihod_Load(object sender, EventArgs e)
        {

        }

    }
}
