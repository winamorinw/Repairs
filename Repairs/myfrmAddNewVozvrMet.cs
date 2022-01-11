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
    public partial class myfrmAddNewVozvrMet : Form
    {
        DAL dal = new DAL();
        public myfrmAddNewVozvrMet()
        {
          

            InitializeComponent();
            //cbx_EdIzm.DataSource = dal.GetAllEdIzm();
            //cbx_EdIzm.DisplayMember = "Name";
            //cbx_EdIzm.ValueMember = "Name";
            cbx_EdIzm.DataSource = dal.GetAllEdIzmForNumber("220000"); // почему 220000.. а потому..это первый номер в таблице типов металлолома
            cbx_EdIzm.DisplayMember = "Name";
            cbx_EdIzm.ValueMember = "Name";

            cbx_AllMetType.DataSource = dal.GetAllTypeMet();
            cbx_AllMetType.DisplayMember = "fulName";
            cbx_AllMetType.ValueMember = "EdNumber";
            
            cbx_EdIzm.DataSource = dal.GetAllEdIzmForNumber("220000");
            cbx_EdIzm.DisplayMember = "Name";
            cbx_EdIzm.ValueMember = "Name";

          

            

        }
        //расчиываем сумму при изменении кол-ва
        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            getSumMetalVozvr();
        }

        private void SettingsAllVozvrMet() { 
            
        
        
        }


        public void getSumMetalVozvr() {

            try
            {
                txt_Sum.Text = (Convert.ToDouble(txt_Price.Text) * Convert.ToDouble(txt_Quantity.Text)).ToString();
                txt_Sum.BackColor = Color.Yellow;
                txt_Sum.ForeColor = Color.Black;
            }
            catch
            {
                txt_Sum.BackColor = Color.Pink;
                txt_Sum.Text = "Помилка!!!";
                txt_Sum.ForeColor = Color.Black;
            }
        
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            getSumMetalVozvr();
        }


        //Добавление возвращаемого металлолома
        private void btn_SaveNewVozvrMet_Click(object sender, EventArgs e)
        {
            
            
            
            if(cbx_EdIzm.SelectedValue.ToString() != ""){

            //MessageBox.Show(txt_Name.Text + cbx_EdIzm.SelectedValue.ToString() + txt_Price.Text + txt_Quantity.Text + txt_Sum.Text +  txt_Note.Text +
                  //  dtp_dataVozvrMet.Value.ToString("yyyyMMdd"));
                if (dal.SavevozvrMet(cbx_AllMetType.SelectedValue.ToString(), cbx_EdIzm.SelectedValue.ToString(), txt_Price.Text.Replace(",", "."), txt_Quantity.Text.Replace(",", "."), txt_Sum.Text.Replace(",", "."),
                    txt_Note.Text, dtp_dataVozvrMet.Value.ToString("yyyyMMdd")) == true)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    this.DialogResult = DialogResult.Cancel;
                }
            } else {
            MessageBox.Show("Вкажіть одиницю вимірювання!");
            
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void cbx_AllMetType_SelectedIndexChanged(object sender, EventArgs e)
        {


            cbx_EdIzm.DataSource = dal.GetAllEdIzmForNumber(cbx_AllMetType.SelectedValue.ToString());
            cbx_EdIzm.DisplayMember = "Name";
            cbx_EdIzm.ValueMember = "Name";
        }

        private void myfrmAddNewVozvrMet_Load(object sender, EventArgs e)
        {
            this.txt_Price.Enabled = false;
        }




    }
}
