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
    public partial class frm_change_year : Form
    {
        public frm_change_year()
        {
            InitializeComponent();
        }

        private void Frm_change_year_Load(object sender, EventArgs e)
        {
            string vibran_year;
            DateTime now = DateTime.Now;
            vibran_year=now.Year.ToString() ;
            this.text_year.Text = vibran_year.ToString();
            this.text_year.Select();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string vibran_year;
            vibran_year = this.text_year.Text.ToString();
             //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True"); 
             cn.Close();
             try
             {
                 cn.Open();
                 SqlCommand s = new SqlCommand("SELECT * FROM [Repairs].[dbo].[Status_mes_ceh] WHERE god = "+vibran_year.ToString(), cn);
                 SqlDataReader dr = s.ExecuteReader();

                 if (dr.HasRows)
                 {
                     frm_zakr_mes frm_zakr_mes = new frm_zakr_mes(vibran_year.ToString());
                     frm_zakr_mes.ShowDialog();
                 }
                 else
                 {
                     MessageBox.Show("Не існує інформація за "+vibran_year.ToString()+" рік.");
                 }
             }
             catch(Exception gg)
             {
                 cn.Close();
                 MessageBox.Show(gg.ToString());
             }
             cn.Close();
             this.Close();
                        
        }

        private void text_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                this.button_ok_Click(null, null);
            }
        }

     
    }
}
