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
    public partial class myfrmPidpisiForAktF2 : Form
    {
        string repid;
        string remusl = "";
        string cx, uch, brig, det;
        //string FIO1f2, dolg1f2, FIO2f2, dolg2f2, FIO3f2, dolg3f2, FIO4f2, dolg4f2, FIO5f2, dolg5f2;
        string FIO1, State1, FIO2, State2, FIO3, State3, FIO4, State4, FIO5, State5;

        public myfrmPidpisiForAktF2(string rep_id,string nam_remusl, string FIO1f2, string dolg1f2, string FIO2f2, string dolg2f2, string FIO3f2, 
            string dolg3f2, string FIO4f2, string dolg4f2, string FIO5f2, string dolg5f2,string c_cx, string c_uch,string c_brig,string c_det)
        {
            InitializeComponent();
            repid = rep_id;
            remusl = nam_remusl;
            FIO1 = FIO1f2;
            FIO2 = FIO2f2;
            FIO3 = FIO3f2;
            FIO4 = FIO4f2;
            FIO5 = FIO5f2;
            cbx_FIO1.Text = FIO1;
            cbx_FIO2.Text = FIO2;
            cbx_FIO3.Text = FIO3;
            cbx_FIO4.Text = FIO4;
            cbx_FIO5.Text = FIO5;
            cbx_State1.Text = State1;
            cbx_State2.Text = State2;
            cbx_State3.Text = State3;
            cbx_State4.Text = State4;
            cbx_State5.Text = State5;

            State1 = dolg1f2;
            State2 = dolg2f2;
            State3 = dolg3f2;
            State4 = dolg4f2;
            State5 = dolg5f2;
            cx = c_cx;
            uch = c_uch;
            brig = c_brig;
            det = c_det;
    
        }

        private void myfrmPidpisiForAktF2_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            
            switch (remusl)
            {
                case "rem":
                case "usl_mat":
                    cbx_FIO1.DataSource = dal.GetAllFIO1f2(cx, uch, brig, det, remusl);
                    cbx_FIO1.DisplayMember = "fio1f2";
                    cbx_FIO1.ValueMember = "fio1f2";
                    int index_fio1 = cbx_FIO1.FindStringExact(FIO1);
                    cbx_FIO1.SelectedIndex = index_fio1;

                    cbx_FIO2.DataSource = dal.GetAllFIO2f2(cx, uch, brig, det, remusl);
                    cbx_FIO2.DisplayMember = "fio2f2";
                    cbx_FIO2.ValueMember = "fio2f2";
                    int index_fio2 = cbx_FIO2.FindStringExact(FIO2);
                    cbx_FIO2.SelectedIndex = index_fio2;

                    cbx_FIO3.DataSource = dal.GetAllFIO3f2(cx, uch, brig, det, remusl);
                    cbx_FIO3.DisplayMember = "fio3f2";
                    cbx_FIO3.ValueMember = "fio3f2";
                    int index_fio3 = cbx_FIO3.FindStringExact(FIO3);
                    cbx_FIO3.SelectedIndex = index_fio3;

                    cbx_FIO4.DataSource = dal.GetAllFIO4f2(cx, uch, brig, det, remusl);
                    cbx_FIO4.DisplayMember = "fio4f2";
                    cbx_FIO4.ValueMember = "fio4f2";
                    int index_fio4 = cbx_FIO4.FindStringExact(FIO4);
                    cbx_FIO4.SelectedIndex = index_fio4;

                    cbx_FIO5.DataSource = dal.GetAllFIO5f2(cx, uch, brig, det, remusl);
                    cbx_FIO5.DisplayMember = "fio5f2";
                    cbx_FIO5.ValueMember = "fio5f2";
                    int index_fio5 = cbx_FIO5.FindStringExact(FIO5);
                    cbx_FIO5.SelectedIndex = index_fio5;
                    if (String.IsNullOrEmpty(cbx_FIO5.Text))
                        cbx_FIO5.Text = "";

                    cbx_State1.DataSource = dal.GetAllState1f2(cx, uch, brig, det,remusl);
                    cbx_State1.DisplayMember = "dolg1f2";
                    cbx_State1.ValueMember = "dolg1f2";
                    int index_State1 = cbx_State1.FindStringExact(State1);
                    cbx_State1.SelectedIndex = index_State1;

                    cbx_State2.DataSource = dal.GetAllState2f2(cx, uch, brig, det, remusl);
                    cbx_State2.DisplayMember = "dolg2f2";
                    cbx_State2.ValueMember = "dolg2f2";
                    int index_State2 = cbx_State2.FindStringExact(State2);
                    cbx_State2.SelectedIndex = index_State2;

                    cbx_State3.DataSource = dal.GetAllState3f2(cx, uch, brig, det, remusl);
                    cbx_State3.DisplayMember = "dolg3f2";
                    cbx_State3.ValueMember = "dolg3f2";
                    int index_State3 = cbx_State3.FindStringExact(State3);
                    cbx_State3.SelectedIndex = index_State3;

                    cbx_State4.DataSource = dal.GetAllState4f2(cx, uch, brig, det, remusl);
                    cbx_State4.DisplayMember = "dolg4f2";
                    cbx_State4.ValueMember = "dolg4f2";
                    int index_State4 = cbx_State4.FindStringExact(State4);
                    cbx_State4.SelectedIndex = index_State4;


                    cbx_State5.DataSource = dal.GetAllState5f2(cx, uch, brig, det, remusl);
                    cbx_State5.DisplayMember = "dolg5f2";
                    cbx_State5.ValueMember = "dolg5f2";
                    int index_State5 = cbx_State5.FindStringExact(State5);
                    cbx_State5.SelectedIndex = index_State5;

                    break;
                case "usl":
                    //lbl_VedR.Text = ("Акт(Ф2) №");
                    cbx_FIO1.DataSource = dal.GetAllFIO1f2(cx, uch, brig, det, "usl");
                    cbx_FIO1.DisplayMember = "fio1f2";
                    cbx_FIO1.ValueMember = "fio1f2";
                    index_fio1 = cbx_FIO1.FindStringExact(FIO1);
                    cbx_FIO1.SelectedIndex = index_fio1;

                    cbx_FIO2.DataSource = dal.GetAllFIO2f2(cx, uch, brig, det, "usl");
                    cbx_FIO2.DisplayMember = "fio2f2";
                    cbx_FIO2.ValueMember = "fio2f2";
                    index_fio2 = cbx_FIO2.FindStringExact(FIO2);
                    cbx_FIO2.SelectedIndex = index_fio2;

                    cbx_FIO3.DataSource = dal.GetAllFIO3f2(cx, uch, brig, det, "usl");
                    cbx_FIO3.DisplayMember = "fio3f2";
                    cbx_FIO3.ValueMember = "fio3f2";
                    index_fio3 = cbx_FIO3.FindStringExact(FIO3);
                    cbx_FIO3.SelectedIndex = index_fio3;

                    cbx_FIO4.DataSource = dal.GetAllFIO4f2(cx, uch, brig, det, "usl");
                    cbx_FIO4.DisplayMember = "fio4f2";
                    cbx_FIO4.ValueMember = "fio4f2";
                    index_fio4 = cbx_FIO4.FindStringExact(FIO4);
                    cbx_FIO4.SelectedIndex = index_fio4;

                    cbx_FIO5.DataSource = dal.GetAllFIO5f2(cx, uch, brig, det, "usl");
                    cbx_FIO5.DisplayMember = "fio5f2";
                    cbx_FIO5.ValueMember = "fio5f2";
                    index_fio5 = cbx_FIO5.FindStringExact(FIO5);
                    cbx_FIO5.SelectedIndex = index_fio5;
                    if (String.IsNullOrEmpty(cbx_FIO5.Text))
                        cbx_FIO5.Text = "";

                    cbx_State1.DataSource = dal.GetAllState1f2(cx, uch, brig, det, "usl");
                    cbx_State1.DisplayMember = "dolg1f2";
                    cbx_State1.ValueMember = "dolg1f2";
                    index_State1 = cbx_State1.FindStringExact(State1);
                    cbx_State1.SelectedIndex = index_State1;

                    cbx_State2.DataSource = dal.GetAllState2f2(cx, uch, brig, det, "usl");
                    cbx_State2.DisplayMember = "dolg2f2";
                    cbx_State2.ValueMember = "dolg2f2";
                    index_State2 = cbx_State2.FindStringExact(State2);
                    cbx_State2.SelectedIndex = index_State2;

                    cbx_State3.DataSource = dal.GetAllState3f2(cx, uch, brig, det, "usl");
                    cbx_State3.DisplayMember = "dolg3f2";
                    cbx_State3.ValueMember = "dolg3f2";
                    index_State3 = cbx_State3.FindStringExact(State3);
                    cbx_State3.SelectedIndex = index_State3;

                    cbx_State4.DataSource = dal.GetAllState4f2(cx, uch, brig, det, "usl");
                    cbx_State4.DisplayMember = "dolg4f2";
                    cbx_State4.ValueMember = "dolg4f2";
                    index_State4 = cbx_State4.FindStringExact(State4);
                    cbx_State4.SelectedIndex = index_State4;


                    cbx_State5.DataSource = dal.GetAllState5f2(cx, uch, brig, det, "usl");
                    cbx_State5.DisplayMember = "dolg5f2";
                    cbx_State5.ValueMember = "dolg5f2";
                    index_State5 = cbx_State5.FindStringExact(State5);
                    cbx_State5.SelectedIndex = index_State5;

                    break;
                default:
                    break;
            }

      
            cbx_FIO1.Text = FIO1;
            cbx_FIO2.Text = FIO2;
            cbx_FIO3.Text = FIO3;
            cbx_FIO4.Text = FIO4;
            cbx_FIO5.Text = FIO5;
            cbx_State1.Text = State1;
            cbx_State2.Text = State2;
            cbx_State3.Text = State3;
            cbx_State4.Text = State4;
            cbx_State5.Text = State5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(repid.ToString());
             //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
             SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
             try
             {
                 cn.Open();
                 SqlCommand s0 = new SqlCommand("select count(RepairID) FROM [Repairs].[dbo].[PodpisiForAktF2] where RepairID= '" + repid.ToString() + "'", cn);
                 string kol_zap = s0.ExecuteScalar().ToString();


                 {

                     if (kol_zap == "0")
                     {

                         SqlCommand s1 = new SqlCommand("insert into  [Repairs].[dbo].[PodpisiForAktF2] ([RepairID],[FIO1f2],[dolg1f2],[FIO2f2],[dolg2f2],[FIO3f2]," +
                         "[dolg3f2],[FIO4f2],[dolg4f2],[FIO5f2],[dolg5f2]) values ('" +repid+ "','"+ cbx_FIO1.Text.ToString() + "','" + cbx_State1.Text.ToString()
                         + "','"+ cbx_FIO2.Text.ToString() + "','" + cbx_State2.Text.ToString() 
                         + "','"+ cbx_FIO3.Text.ToString() + "','" + cbx_State3.Text.ToString() + "','"+ cbx_FIO4.Text.ToString() + "','" +cbx_State4.Text.ToString() 
                         + "','"+ cbx_FIO5.Text.ToString() + "','" + cbx_State5.Text.ToString()+ "')", cn);
                         s1.ExecuteNonQuery();
                         MessageBox.Show("Обновлено.");
                     }
                     else
                     {
                         SqlCommand s1 = new SqlCommand("update  [Repairs].[dbo].[PodpisiForAktF2] set "+
                             " FIO1f2='" + cbx_FIO1.Text.ToString() + "' , dolg1f2='" + cbx_State1.Text.ToString() +
                             "' , FIO2f2='" + cbx_FIO2.Text.ToString() + "' , dolg2f2='" + cbx_State2.Text.ToString() +
                             "' , FIO3f2='" + cbx_FIO3.Text.ToString() + "' , dolg3f2='" + cbx_State3.Text.ToString() +
                             "' , FIO4f2='" + cbx_FIO4.Text.ToString() + "' , dolg4f2='" + cbx_State4.Text.ToString() +
                             "' , FIO5f2='" + cbx_FIO5.Text.ToString() + "' , dolg5f2='" + cbx_State5.Text.ToString() + "' WHERE RepairID = '" + repid+"'", cn);
                         s1.ExecuteNonQuery();
                         //MessageBox.Show("Обновлено.");
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(this, ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
                
             }

             this.Close();
        }
    }
}
