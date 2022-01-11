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
    public partial class myfrm_add_uzel_rem : Form
    {
        public myfrm_add_uzel_rem()
        {
            InitializeComponent();
        }
        public string param_from_frm = "";
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        public DataTable dt = new DataTable();
        //SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
        SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cbx_uzel_rem.Text.Trim() == "")
            {
                MessageBox.Show("Занесите информацию");
            }
            else
            {
                // Передаем параметр в родительскую форму
                myfrmProstoi_Vvod main = this.Owner as myfrmProstoi_Vvod;
                if (main != null)
                {
                    string s = this.cbx_uzel_rem.Text.ToString();
                    main.param_from_frm = s;
                    main.knopka = "add";
                    this.Close();
                }
                //
            }
        }

        private void btn_notsave_Click(object sender, EventArgs e)
        {
            myfrmProstoi_Vvod main = this.Owner as myfrmProstoi_Vvod;
            main.knopka = "";
            this.Close();
        }

        private void myfrm_add_uzel_rem_Load(object sender, EventArgs e)
        {
            // Заполняем узел ремонта
            con.Open();
            dt = new DataTable();
            da = new SqlDataAdapter("SELECT distinct nam_uzla_rem  FROM [Repairs].[dbo].[spis_uzli_rem] order by nam_uzla_rem ", con);
            da.Fill(dt); //Загрузка данных о цехах в DataTable
            for (int i = 0; i < dt.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
            {
                cbx_uzel_rem.Items.Add(dt.Rows[i][0].ToString());
                //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
            }
            da.Dispose();
            con.Close();
        }
    }
}
