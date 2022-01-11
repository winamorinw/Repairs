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
    public partial class myfrm_klassif_pr : Form
    {
        public string nkod_pr = "";
        public string cnam_pr = "";

        public myfrm_klassif_pr(string kod_pr, string nam_pr)
        {
            InitializeComponent();
            nkod_pr = kod_pr;
            cnam_pr = nam_pr;
        }

        private void myfrm_klassif_pr_Load(object sender, EventArgs e)
        {
            label2.Text = cnam_pr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                //SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=STAFF;Integrated Security=True;");
                SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");

                //**

                int kol_povtor_name = 0;
                string query = string.Format(@"select count(nam_klas_pr) from [Repairs].[dbo].[spr_klas_pr] where kod_tip_pr='{0}' and ltrim(rtrim(nam_klas_pr))='{1}' ", nkod_pr.ToString(), textBox1.Text.ToString().Trim());
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    kol_povtor_name = Convert.ToInt32(com.ExecuteScalar());
                }
                catch
                {
                    kol_povtor_name = 0;
                }
                con.Close();

                //**

                if (kol_povtor_name == 0)
                {

                    int new_maxkod = 0;
                    query = string.Format(@"select max(kod_klas_pr) from [Repairs].[dbo].[spr_klas_pr]  ");
                    com = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        new_maxkod = Convert.ToInt32(com.ExecuteScalar()) + 1;
                    }
                    catch
                    {
                        new_maxkod = 0;
                    }
                    con.Close();

                    if (new_maxkod == 0)
                    {
                        MessageBox.Show("Не удалось присвоить максимальный код классификации ");
                    }
                    else
                    {
                        string oshibka = "";
                        string query1 = string.Format(@" insert into [Repairs].[dbo].[spr_klas_pr] (kod_tip_pr,kod_klas_pr,nam_klas_pr) values ('{0}','{1}','{2}')", nkod_pr.ToString(), new_maxkod.ToString(), textBox1.Text.ToString().Trim());
                        {
                            SqlCommand com1 = new SqlCommand(query1, con);
                            try
                            {
                                con.Open();
                                if (com1.ExecuteNonQuery() >= 1)
                                {
                                    oshibka = "";
                                    MessageBox.Show("Успешное сохраниение классификации простоя.");
                                    con.Close();
                                    this.Close();
                                }
                            }
                            catch
                            {
                                oshibka = "yes";
                                MessageBox.Show("Ошибка при сохранении информации. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                                con.Close();
                                this.Close();
                            }
                        }
                        con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Повтор наименования.");
                }
            }
            else
            {
                MessageBox.Show("НЕвозможно сохранить пустое значение.");
                textBox1.Select();
            }

        }
        
        
        }
}
