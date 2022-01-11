/* Changelog
 * 
 * Переписал конструктор формы. Передача логина/прав/цеха происходит через конструктор.
 * Гостю открыл доступ к этой форме (66-69строки)
 * 
 */

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
    public partial class frmGetToRepair : Form
    {
        SqlConnection cn = new SqlConnection();
        private string user_l, user_n, pravo_dostupa, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det,tek_mes,tek_god;


        /// <summary>
        /// Конструктор формы.
        /// </summary>
        /// <param name="userl">Логин</param>
        /// <param name="usern">Цех</param>
        /// <param name="userp">Права</param>
        public frmGetToRepair(string userl, string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet,
            string tekmes, string tekgod)
        {
            InitializeComponent();
            cn.ConnectionString = Repairs.Properties.Settings.Default.RepairOSConnStr;
            user_l = userl;
            user_p = userp;
            user_n = usern;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
            tek_mes = tekmes;
            tek_god = tekgod;
        }

     //   private SqlConnectionStringBuilder sbConn;

        private void frmGetToRepair_Load(object sender, EventArgs e)
        {
            if (user_p == "4")
            {
                pnl.Visible = false;
                btnSave.Enabled = false;
                this.repairTableTableAdapter.Fill(this.repairOSDS1.RepairTable);
            }
            else
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS1.RepairTable". При необходимости она может быть перемещена или удалена.
                this.repairTableTableAdapter.FillByDivision(this.repairOSDS1.RepairTable, Convert.ToInt32(user_n));
                // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Repair". При необходимости она может быть перемещена или удалена.
                this.repairTableAdapter.FillByDivision(this.repairOSDS.Repair, Convert.ToInt32(user_n));
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Store". При необходимости она может быть перемещена или удалена.
            this.storeTableAdapter.FillByRep(this.repairOSDS1.Store, true);
            mtxtDateIn.Text = DateTime.Now.ToShortDateString();

            cn.Open();


            SqlDataAdapter sqlDA_ok2;
            if (user_p == "3")//Гостю открыл доступ к этой форме
            {
                sqlDA_ok2 = new SqlDataAdapter("SELECT StoreName FROM Store WHERE (StoreID = 1) or (StoreID = 5)", cn);
            }
            else
                sqlDA_ok2 = new SqlDataAdapter("SELECT StoreName FROM Store WHERE StoreID = " + user_n, cn);



            DataTable tab = new DataTable();
            sqlDA_ok2.Fill(tab);//*/
            cn.Close();
            txtDivision.Text = user_n;
            label1.Text = tab.Rows[0][0].ToString();
        }

        private void btnRefOkrt_Click(object sender, EventArgs e)
        {
            frmSprShow frm = new frmSprShow(user_p, user_n);
            frm.frm = "main";
            System.Windows.Forms.Form fm = new frmSprShow(user_p, user_n);
            fm.Owner = this;
            fm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport fm = new frmReport("gettorepair", user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            /*fm.frm = "gettorepair";
            fm.user_p = user_p;*/
            if (user_p != "3")
            { fm.store_id = Convert.ToInt32(user_n); }
            fm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInventoryNumber.Text != "")
            {
                try
                {
                    this.repairTableAdapter.InsertQuery(Convert.ToDateTime(mtxtDateIn.Text), Convert.ToInt32(txtInventoryNumber.Text), Convert.ToInt32(cbxSprRepairDivision.SelectedValue), Convert.ToInt32(user_n), Convert.ToBoolean(checkBox1.Checked));//, txtTypeFlaut.Text, txtCause.Text, txtResponsible.Text, txtNote.Text);
                    this.repairTableTableAdapter.FillByDivision(this.repairOSDS1.RepairTable, Convert.ToInt32(user_n));
                    MessageBox.Show("ОЗ з інв. №" + txtInventoryNumber.Text + " відправлено в " + cbxSprRepairDivision.Text);
                }
                catch (Exception ex)
                {
                    if (ex.Message.ToUpper().Contains("CHECK \"CK_REPAIR\""))
                        MessageBox.Show("Можна відправити тільки в ремонтний цех " + label1.Text + " або до РМЦ");
                    else
                        if(ex.Message.ToUpper().Contains("\"IX_REPAIR\". ПОВТОРЮВАЛЬНЕ ЗНАЧЕННЯ КЛЮЧА"))
                        {
                            MessageBox.Show("Ви сьогодні вже відправляли ОЗ з Інв№" + txtInventoryNumber.Text + " в " + cbxSprRepairDivision.Text);
                        }
                }
            }
            else MessageBox.Show("Виберіть інвентарний номер");
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (user_p == "3")//кнопка обновить для гостя
            {
                this.repairTableTableAdapter.FillByGuest(this.repairOSDS1.RepairTable);
            }
            else
                this.repairTableTableAdapter.FillByDivision(this.repairOSDS1.RepairTable, Convert.ToInt32(user_n));
        }

        private void cbxSprRepairDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string caption = "Видалення даних";
            string message = "Ви дійсно бажаєте видалити дані про ремонт?";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            } 

            try
            {
                DataRowView drw = repairTableBindingSource.Current as DataRowView;
                this.repairTableTableAdapter.DeleteQuery(Convert.ToInt16(drw["RepairID"].ToString()));
                this.repairTableTableAdapter.FillByDivision(this.repairOSDS1.RepairTable, Convert.ToInt32(user_n));
            }
            catch (Exception ex)
            { MessageBox.Show("Запис не може бути видалена, по ній вже внесена інформація про ремонт"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}