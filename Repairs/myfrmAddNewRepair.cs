using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Repairs
{
    public partial class myfrmAddNewRepair : Form
    {
        private string user_l, user_n, pravo_dostupa, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;
        DAL dal = new DAL();
        // Inv_Number inv_number = new Inv_Number();
        public static string inver_number;
        public string remusl;
        public myfrmAddNewRepair(string rem_usl)
        {
            remusl=rem_usl;
            InitializeComponent();
            //Цех заказчик
            if (remusl == "rem")
            {
                cbx_cehIn.DataSource = dal.GetAllStore();
                this.Text = "Отправка ОС в ремонт";
                btn_searchTMC.Text = "Выбор ОС";
                label1.Text="Отправитель";
                label2.Text="Получатель";
                label4.Text = "Дата отправки";
            }
            if (remusl == "usl")
                {
                    cbx_cehIn.DataSource = dal.GetAllStoreUsl();
                    this.Text = "Отправка. Услуги для цеха";
                    btn_searchTMC.Text = "Выбор услуги для цеха";
                    label1.Text = "Услуга для цеха";
                    label2.Text = "Исполнитель";
                    label4.Text = "Дата заказа услуги";

                }
            cbx_cehIn.DisplayMember = "StoreName";
            cbx_cehIn.ValueMember = "StoreID";
            if (remusl == "rem")
            cbx_cehTo.DataSource = dal.GetAllStoreR();
            
            if (remusl == "usl")
                cbx_cehTo.DataSource = dal.GetAllStore();
            
            cbx_cehTo.DisplayMember = "StoreName";
            cbx_cehTo.ValueMember = "StoreID";
            txt_invNum.Text = "";
            txt_InvName.Text = "";
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{

        //}




        private string Found_rab_mes(string NOMCEH, string NAMPOLE)
        {
            string constr = Properties.Settings.Default.RepairOSConnStr;
            SqlConnection SqlCon = new SqlConnection(constr);
            //string my_result = "";
            SqlCommand com = new SqlCommand("SELECT " + NAMPOLE + " FROM [Repairs].[dbo].[Store]    INNER JOIN Status_mes_ceh ON Store.StoreID = Status_mes_ceh.StoreId " +
                "WHERE Status_mes_ceh.StoreId=@N_CEH", SqlCon);
            com.Parameters.Add("@N_CEH", SqlDbType.NVarChar).Value = NOMCEH;
            //com.Parameters.Add("@nampole", SqlDbType.NVarChar).Value = NAMPOLE;
            SqlCon.Open();
            object ress = com.ExecuteScalar();
            SqlCon.Close();
            string my_result = "";
            if (ress == null)
                my_result = "";
            else
                my_result = ress.ToString();
            return my_result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ncx = "";
            //if (remusl == "usl")
            //{
            //    ncx = cbx_cehIn.SelectedValue.ToString();
            //}
            //else
            //{
            //    if (remusl == "rem")
            //    {
            //        ncx = cbx_cehTo.SelectedValue.ToString();
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}

            ncx = cbx_cehTo.SelectedValue.ToString();
            string rabmesrem = Found_rab_mes(ncx, "Status_mes_ceh.mes");
            string rabgodrem = Found_rab_mes(ncx, "Status_mes_ceh.god");
            string mesdtp = dtp_datein.Value.Month.ToString();
            string goddtp = dtp_datein.Value.Year.ToString();
            if (rabmesrem == mesdtp && rabgodrem == goddtp)
            {
                //MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("Не буде збережено.\nДата відправки в ремонт не співпадає з робочим місяцем.\nпо цеху " + ncx + " робочий " + rabmesrem + "міс." + rabgodrem + " рік");
                return;
            }

            




            DateTime ddd = new DateTime();
            ddd = dtp_datein.Value;
            if (txt_invNum.Text.ToString()=="" || txt_invNum.Text.ToString()==null) 
            {
                MessageBox.Show("Не заполнена информация! Нажмите кнопку ''" + btn_searchTMC.Text+"''");
            }
            else
            {
                //сохранение записи о ремонте
                //    textBox1.Text = dal.SaveNewRepairString(ddd.ToString("yyyyMMdd"), txt_invNum.Text, cbx_cehTo.SelectedValue.ToString(), cbx_cehIn.SelectedValue.ToString(), Convert.ToInt32(cbx_plan.Checked).ToString(), txt_Obekt.Text, txt_Kod.Text, txt_kontragent.Text, txt_EDRPOU.Text.Trim());

                // System.Threading.Thread.Sleep(10000);

                //  MessageBox.Show(dal.SaveNewRepairString(ddd.ToString("yyyyMMdd"), txt_invNum.Text, cbx_cehTo.SelectedValue.ToString(), cbx_cehIn.SelectedValue.ToString(), Convert.ToInt32(cbx_plan.Checked).ToString(), txt_Obekt.Text, txt_Kod.Text, txt_kontragent.Text, txt_EDRPOU.Text.Trim()));


             /*
             var table = dal.GetLastRepairAndVedomostByInventory(txt_invNum.Text.Trim());
             if(table.Rows.Count == 1)
                MessageBox.Show($"{table.Rows[0][0].GetType()} {table.Rows[0][1].GetType()} {table.Rows[0][2].GetType()} {table.Rows[0][3].GetType()} {table.Rows[0][4].GetType()} {table.Rows[0][5].GetType()}");
             return;
             */










            if (dal.SaveNewRepair(ddd.ToString("yyyyMMdd"), txt_invNum.Text.Trim(), cbx_cehTo.SelectedValue.ToString(), cbx_cehIn.SelectedValue.ToString(), Convert.ToInt32(cbx_plan.Checked).ToString(), txt_Obekt.Text.Trim(), txt_Kod.Text.Trim(), txt_kontragent.Text.Trim(), txt_EDRPOU.Text.Trim()) == true)
            {
                MessageBox.Show("Запис успішно додано!");
            }
            else
            {
                MessageBox.Show("Помилка! Запис не створено!!!");
            }
            //  MessageBox.Show(ddd.ToString("yyyyMMdd") + txt_invNum.Text + cbx_cehIn.SelectedValue.ToString() + cbx_cehTo.SelectedValue.ToString() + Convert.ToInt32(cbx_plan.Checked).ToString());
            this.Close();
            //// dtp_datein. 
            // DateTime ddd = new DateTime();
            // ddd = dtp_datein.Value;
            // MessageBox.Show(ddd.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dal.GetAllTMCstring());
            myfrmSearchTMC myfrmSearchTMC = new myfrmSearchTMC(remusl,"","");
            //отлавливаем нажатие кнопки на форме выбора ТМЦ

            myfrmSearchTMC.FormClosed += (closedSender, closedE) =>
            {
                {
                    txt_invNum.Text = Inv_Number.Inv_n;
                    txt_InvName.Text = Inv_Number.Inv_name;
                    txt_Obekt.Text = Inv_Number.Obekt;
                }
            };
            //исправил. надо вернуть на место
            myfrmSearchTMC.ShowDialog();
        }

        //private void cbx_cehIn_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //добавление контрагента
        private void btnAddKontragent_Click(object sender, EventArgs e)
        {

            MyfrmSearchKontragent myfrmSearchKontragent = new MyfrmSearchKontragent();
            myfrmSearchKontragent.FormClosed += (closedSender, closedE) =>
            {
                {
                    txt_Kod.Text = KontrAgent.Kod;
                    txt_kontragent.Text = KontrAgent.Name;
                    txt_EDRPOU.Text = KontrAgent.Edrpou;
                }
            };
            myfrmSearchKontragent.ShowDialog();
        }

        private void cbx_cehTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //дикая проверка. проверяется на исполнитель - контрагент
            if (cbx_cehTo.SelectedValue.ToString() == "9966")
            {
                btnAddKontragent.Enabled = true;
            }
            else
            {
                btnAddKontragent.Enabled = false;
            }
        }

        private void myfrmAddNewRepair_Load(object sender, EventArgs e)
        {

        }

        private void cbx_cehIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ncx = cbx_cehIn.SelectedValue.ToString();
            string rabmes = Found_rab_mes(ncx, "Status_mes_ceh.mes");
            string rabgod = Found_rab_mes(ncx, "Status_mes_ceh.god");

            string mesdtp = dtp_datein.Value.Month.ToString();
            string goddtp = dtp_datein.Value.Year.ToString();

            if (rabmes == mesdtp && rabgod == goddtp)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("Дата відправки в ремонт не співпадає з робочим місяцем. \nРобочий " + rabmes + "міс." + rabgod + " рік");
                return;
            }
            
        }
    }

    public class Inv_Number
    {
        private static string inv_n = " ";  // Для передачи инвентарного номера 
        private static string inv_name = ""; // для передачи названия
        private static string obekt = ""; // для передачи номера объекта


        public static string Inv_n
        {
            get
            {
                return inv_n;
            }
            set
            {
                inv_n = value;
            }
        }

        public static string Inv_name
        {
            get
            {
                return inv_name;
            }
            set
            {
                inv_name = value;
            }
        }

        public static string Obekt { get; set; }
    }
}
