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
    public partial class Change_ceh : Form
    {
        public Change_ceh(string i1, string i2)
        {
            InitializeComponent();
            tek_mes = i1;
            tek_god = i2;

            /*https://www.dotnetperls.com/datetime*/
            // Устанавливаем дате первое число текущего месяца 
            var mm = DateTime.Now.Month;
            var yy = DateTime.Now.Year;
            var dd1 = new DateTime(yy, mm, 1);
            dtp_PeriodData2_1.Value = Convert.ToDateTime(dd1);
            //


            int days = DateTime.DaysInMonth(yy, mm); // показівает количесво дней в месяце
            var dd2 = new DateTime(yy, mm, days);
            dtp_PeriodData2_2.Value = Convert.ToDateTime(dd2); // устанавливаем последнее число месяца
                 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }

        }

        private void Change_ceh_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            label2.Text = "Оберіть цех";
            //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True"); 
            try
            {

                cn.Open();
                SqlCommand s0 = new SqlCommand("SELECT [plot] FROM [Repairs].[dbo].[Users_list] WHERE  login_user = '" + Environment.UserName + "'", cn);
                Debug.WriteLine(s0);
                var result = dal.GetUserAndAdditionalCeh("Kharenko_AV");
                int u = 0;

                if (result.Count > 1)
                    u = Convert.ToInt32(Dostup.Codcx);
                else
                    u = Convert.ToInt32(s0.ExecuteScalar());

                SqlCommand s;
                if (u == 0)
                {
                    s = new SqlCommand("SELECT [StoreID],[StoreName] FROM [Repairs].[dbo].[Store] where repair=1", cn);
                }
                else
                {
                    s = new SqlCommand("SELECT [StoreID],[StoreName] FROM [Repairs].[dbo].[Store] WHERE repair=1 and  StoreID = " + u, cn);
                }

                SqlDataReader dr = s.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(new data(Convert.ToInt32(dr.GetValue(0)), Convert.ToString(dr.GetValue(1))));
                    }
                    comboBox1.Enabled = true;
                    comboBox1.Items.Clear();
                    foreach (data i in list)
                    {
                        comboBox1.Items.Add(i.ceh + " " + i.name);
                    }
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    checkBox1.Checked = true;
                    checkBox1.Enabled = false;
                }
            }
            catch
            {
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
                comboBox1.Enabled = false;
                label2.Text = "Натисніть кнопку ДАЛІ !";
            }

          
        }
        List<data> list = new List<data>();
        private void button1_Click(object sender, EventArgs e)
        {
          // label2.Text = "Чекайте. Виконується вибір інформації!";
            if (checkBox1.Checked)
            {
                ALL = true;
                
            }
            else
            {
                ALL = false;
                CEH = list[comboBox1.SelectedIndex].ceh;
            }

            myfrmAllVedomotsResursov myfrmAllVedomotsResursov = new myfrmAllVedomotsResursov(tek_mes, tek_god, dtp_PeriodData2_1.Value.ToString("yyyyMMdd"), dtp_PeriodData2_2.Value.ToString("yyyyMMdd"),ALL,CEH.ToString());
            myfrmAllVedomotsResursov.FFf += Change_ceh_fff;
            myfrmAllVedomotsResursov.FF += Change_ceh_FF;
            myfrmAllVedomotsResursov.ShowDialog();
           
        }
        void Change_ceh_fff()
        {
            label2.Text = "Чекайте. Виконується вибір інформації!";
            label2.Update();
        }
        void Change_ceh_FF()
        {
            label2.Text = "Оберіть цех";            
        }

        public static int CEH = 0;
        public static bool ALL = false;
        public string tek_mes;
        public string tek_god;

        private void Change_ceh_Activated(object sender, EventArgs e)
        {
        }

        private void Change_ceh_Enter(object sender, EventArgs e)
        {
            
        }

        private void Change_ceh_Deactivate(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {


            var mm = DateTime.Now.Month;
            var yy = DateTime.Now.Year;
            int days = DateTime.DaysInMonth(yy, mm); // September.
            var dd = new DateTime(yy, mm, days);
            dtp_PeriodData2_2.Value = Convert.ToDateTime(dd);
            //MessageBox.Show(days.ToString());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                // label2.Text = "Чекайте. Виконується вибір інформації!";
                if (checkBox1.Checked)
                {
                    ALL = true;

                }
                else
                {
                    ALL = false;
                    CEH = list[comboBox1.SelectedIndex].ceh;
                }

                myfrmAllAkt myfrmAllAkt = new myfrmAllAkt(tek_mes, tek_god, dtp_PeriodData2_1.Value.ToString("yyyyMMdd"), dtp_PeriodData2_2.Value.ToString("yyyyMMdd"), ALL, CEH.ToString(),"usl");
                myfrmAllAkt.FFf += Change_ceh_fff;
                myfrmAllAkt.FF += Change_ceh_FF;
                myfrmAllAkt.ShowDialog();

            
        }



       
    }

    public class data
    {
        public int ceh;
        public string name;
        public data(int ceh, string name)
        {
            this.ceh = ceh;
            this.name = name;
        }
    }

}
