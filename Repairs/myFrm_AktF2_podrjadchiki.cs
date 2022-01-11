using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Repairs
{
    public partial class myFrm_AktF2_podrjadchiki : Form
    {
        public myFrm_AktF2_podrjadchiki()
        {
            InitializeComponent();
        }
        
        SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True");

        private void button4_Click(object sender, EventArgs e)
        {

            string zamovnik = "ПрАТ ''СУХА БАЛКА''"; 

            string vikonav = textBox1.Text.ToString();
            if (vikonav.Length < 1)
            {
                vikonav = " ";
            }
            string edrpou = "00191329"; 
            string ID = textBox2.Text.ToString();
            if (ID.Length < 1)
            {
                ID = " ";
            }


            //string NomAkt = textBox2.Text.ToString();
            string DatAkt = dateTimePicker1.Value.ToString();
            string NameOs = label5.Text.ToString();
            if (NameOs.Length < 1 || NameOs.Trim()=="Найменування інв.№")
            {
                NameOs = " ";
            }
            string InvNumberOS = textBox4.Text.ToString();
            if (InvNumberOS.Length < 1)
            {
                InvNumberOS = " ";
            }
            string Obekt = textBox3.Text.ToString();
            if (Obekt.Length < 1 || Obekt=="0")
            {
                Obekt = " ";
            }
            string PeriodData1 = dateTimePicker2.Value.ToString();
            string PeriodData2 = dateTimePicker3.Value.ToString();


            string Dat_Rem1 = dateTimePicker2.Value.ToString().Substring(1,10);
            string Dat_Rem2 = dateTimePicker3.Value.ToString().Substring(1, 10);


            DateTime PD1 = Convert.ToDateTime(PeriodData1);
            DateTime PD2 = Convert.ToDateTime(PeriodData2);


            
            

            //int koldn = (((TimeSpan)(PD1 - PD2)).Days-1)*(-1); // Кол-во дней  между двумя датами в днях

            cn.Open();
            SqlCommand s0 = new SqlCommand("select b_bal_cena FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            Debug.WriteLine(s0);

            string b_bal_cena;
            //string b_bal_cena = s0.ExecuteScalar().ToString();
            try
            {
                b_bal_cena = s0.ExecuteScalar().ToString();
            }
            catch
            {
                b_bal_cena = " ";
            }
            cn.Close();


            cn.Open();
            SqlCommand s1 = new SqlCommand("select pasport FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            
//            string pasport = s1.ExecuteScalar().ToString();
            string pasport;
            try
            {
                pasport = s1.ExecuteScalar().ToString();
            }
            catch
            {
                pasport = " ";
            }
            cn.Close();


            cn.Open();
            SqlCommand s2 = new SqlCommand("select mdl_crt FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            //string mdl_crt = s2.ExecuteScalar().ToString();
            string mdl_crt ;
            try
            {
                mdl_crt = s2.ExecuteScalar().ToString();
            }
            catch
            {
                mdl_crt = " ";
            }

            cn.Close();

            cn.Open();
            SqlCommand s3 = new SqlCommand("select poln_srok FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            //int poln_srok = 0;
            //string poln_srokk = s3.ExecuteScalar().ToString();
            string poln_srok;
            try
            {
                poln_srok = s3.ExecuteScalar().ToString();
            }
            catch
            {
                poln_srok = " ";
            }


            cn.Close();


            cn.Open();
            SqlCommand s4 = new SqlCommand("select srok FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            //int srok = Convert.ToInt32(s4.ExecuteScalar());
            //int srok;
            string srok;
            try
            {
                srok = s4.ExecuteScalar().ToString();
            }
            catch
            {
                srok = " ";
            }

            cn.Close();


            Debug.WriteLine(b_bal_cena.ToString());
            Debug.WriteLine(pasport.ToString());
            Debug.WriteLine(mdl_crt.ToString());
            Debug.WriteLine(poln_srok.ToString());
            Debug.WriteLine(srok.ToString());

            int god_blank=2019;
            //frm_vibor_druk frm_vibor_druk = new frm_vibor_druk(ID, ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, b_bal_cena.ToString(), pasport.ToString(), mdl_crt.ToString(), poln_srok.ToString(), srok.ToString());
            if (radioButton2.Checked == true)
            {
                god_blank = 2019;
            }
            else 
            {
                god_blank = 2017;
            }


            frm_vibor_druk frm_vibor_druk = new frm_vibor_druk(ID, " ", " ", " ", " ", " ", " ", " ", " ", NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, b_bal_cena.ToString(), pasport.ToString(), mdl_crt.ToString(), poln_srok.ToString(), srok.ToString(), zamovnik, edrpou, DatAkt, Dat_Rem1, Dat_Rem2, vikonav, "podrjadchik_yes",god_blank," ", "", "");
            frm_vibor_druk.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InvNumberOS = textBox4.Text.ToString();
            string Obekt = textBox3.Text.ToString();

            cn.Open();
            SqlCommand s0 = new SqlCommand("select name FROM [Repairs].[dbo].[SprOS] where InventoryNumber='" + InvNumberOS.ToString() + "' and obekt='" + Obekt.ToString() + "'", cn);
            try
            {
                this.label5.Text = s0.ExecuteScalar().ToString();
            }
            catch 
            {
                this.label5.Text ="Не знайдено";
            }
            cn.Close();
            
        }

        private void myFrm_AktF2_podrjadchiki_Load(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            DateTime date1 = new DateTime(1900, 1, 1);
            DateTime date2 = new DateTime(1900, 1, 1);
            DateTime date3 = new DateTime(1900, 1, 1);
            dateTimePicker1.Value = date1;
            dateTimePicker2.Value = date2;
            dateTimePicker3.Value = date3;
        }

        private void btn_DelDataLastRem_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1900, 1, 1);
            dateTimePicker1.Value = date1;
            btn_dateTimePicker1.Visible = true;

        }

        private void btn_dateTimePicker1_Click(object sender, EventArgs e)
        {
            btn_dateTimePicker1.Visible = false;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime date2 = new DateTime(1900, 1, 1);
            dateTimePicker2.Value = date2;
            btn_dateTimePicker2.Visible = true;

        }


        private void button3_Click(object sender, EventArgs e)
        {

            DateTime date3 = new DateTime(1900, 1, 1);
            dateTimePicker3.Value = date3;
            btn_dateTimePicker3.Visible = true;

        }


        private void btn_dateTimePicker2_Click(object sender, EventArgs e)
        {
            btn_dateTimePicker2.Visible = false;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btn_dateTimePicker3_Click(object sender, EventArgs e)
        {
            btn_dateTimePicker3.Visible = false;
            dateTimePicker3.Value = DateTime.Now;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string vikonav = textBox1.Text.ToString();
            string DatAkt = dateTimePicker1.Value.ToString();
            string PeriodData1 = dateTimePicker2.Value.ToString();
            string PeriodData2 = dateTimePicker3.Value.ToString();


            string Dat_Rem1 = dateTimePicker2.Value.ToString().Substring(1, 10);
            string Dat_Rem2 = dateTimePicker3.Value.ToString().Substring(1, 10);

            int god_blank;
            //frm_vibor_druk frm_vibor_druk = new frm_vibor_druk(ID, ZakCx, ZakUch, ZakBrig, ZakDet, IspCx, IspUch, IspBrig, IspDet, NameOs, InvNumberOS, Obekt, PeriodData1, PeriodData2, b_bal_cena.ToString(), pasport.ToString(), mdl_crt.ToString(), poln_srok.ToString(), srok.ToString());
            if (radioButton2.Checked == true)
            {
                god_blank = 2019;
            }
            else
            {
                god_blank = 2017;
            }


            frm_vibor_druk frm_vibor_druk = new frm_vibor_druk(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", PeriodData1, PeriodData2, " "," "," "," "," "," "," ", DatAkt, Dat_Rem1, Dat_Rem2, " ", "podrjadchik_yes",god_blank," ", "", "");
            frm_vibor_druk.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
