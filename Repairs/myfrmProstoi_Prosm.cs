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
    public partial class myfrmProstoi_Prosm : Form
    {
        string kodostup = Dostup.Kod_dostup_pr.Trim();
        public myfrmProstoi_Prosm()
        {
            InitializeComponent();
            dtpBeg.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
         
            if (kodostup == "1")  // gosti
            {
                btn_red.Visible = false;
                btn_del.Visible = false;
            }
            else
            {
                btn_red.Visible = true;
                if (kodostup == "2" || kodostup == "10")  // tehnik
                {
                    btn_del.Visible = true;
                }
                else
                {
                    btn_del.Visible = false;
                }

            }
        }

        public DataTable dt1 = new DataTable();
        string txt_id_prostoi = "";
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        //SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repair;Integrated Security=True;");
        SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void zapis_v_prot(string dejstvie,string idprostoi)
        {
            ////запись в протокол
            string dddejstvie = dejstvie;
            string idpr = idprostoi;
            string uchetka = Environment.UserName.ToString();
            DateTime datnow = DateTime.Now;
            string query2 = string.Format(@" insert into [Repairs].[dbo].[Prostoi_protokol] ([id_prostoi],[dejstvie],[tekdate],[uchetka]) values ('{0}','{1}','{2}','{3}') ", idpr.ToString(), dejstvie.ToString(), datnow, uchetka.ToString());
            SqlCommand com2 = new SqlCommand(query2, con);
            try
            {
                con.Open();
                if (com2.ExecuteNonQuery() >= 1)
                { }
                else
                {

                    MessageBox.Show(dejstvie + " НЕ записалось в протокол. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                }
            }
            catch
            {
                MessageBox.Show(dejstvie + " НЕ записалось в протокол. Обратитесь к разработчику ПО по тел. 409-72-78 ");
            }
            ////////////
        }

        //поиск по инвентарному номеру
        private void SearchForInventory()
        {

            dataGridView1.ReadOnly = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["inv_num"].Value.ToString().Contains(txt_SearchInv.Text) == false)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                }
                else
                    button1.PerformClick();
            }
            
           }

        //поиск по названию
        private void SearchForName()
        {
           

        }


        private void settings_grid()
        {
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["ceh"].Visible = false;
            dataGridView1.Columns["nam_ceh"].Visible = true;
            dataGridView1.Columns["uth"].Visible = false;
            dataGridView1.Columns["nam_uth"].Visible = true;
            dataGridView1.Columns["inv_num"].Visible = true;
            dataGridView1.Columns["objekt"].Visible = true;
            dataGridView1.Columns["nam_inv"].Visible = true;
            dataGridView1.Columns["dat_beg_pr"].Visible = true;
            dataGridView1.Columns["dat_end_pr"].Visible = true;
            dataGridView1.Columns["dat_last_rem"].Visible = true;
            dataGridView1.Columns["uzel_rem"].Visible = true;
            dataGridView1.Columns["dlit_pp_potoka"].Visible = true;
            dataGridView1.Columns["norma_rem"].Visible = true;
            dataGridView1.Columns["fakt_vr_rem"].Visible = true;
            dataGridView1.Columns["otkl_ot_normi"].Visible = true;
            dataGridView1.Columns["prichina_otkl"].Visible = true;
            dataGridView1.Columns["poteri"].Visible = true;
            dataGridView1.Columns["tip_nepr_pr"].Visible = true;
            dataGridView1.Columns["kod_tip_pr"].Visible = false;
            dataGridView1.Columns["kod_klassif_pr"].Visible = false;
            dataGridView1.Columns["opis_polomki"].Visible = true;
            dataGridView1.Columns["primech"].Visible = true;
            dataGridView1.Columns["tektime"].Visible = false;
            dataGridView1.Columns["uchetka"].Visible = false;
            dataGridView1.Columns["ed_izm_poteri"].Visible = true;
            dataGridView1.Columns["nam_tip_pr"].Visible = true;
            dataGridView1.Columns["nam_klas_pr"].Visible = true;
            dataGridView1.Columns["status_del"].Visible = false;


            //dataGridView1.Columns["ceh"].HeaderText = "Цех";
            dataGridView1.Columns["nam_ceh"].HeaderText = "Наименование цеха";
            //dataGridView1.Columns["uth"].HeaderText = "Уч.";
            dataGridView1.Columns["nam_uth"].HeaderText = "Наименование участка";
            dataGridView1.Columns["inv_num"].HeaderText = "Инв.№";
            dataGridView1.Columns["objekt"].HeaderText = "Об.";
            dataGridView1.Columns["nam_inv"].HeaderText = "Наименование инв.№";
            dataGridView1.Columns["dat_beg_pr"].HeaderText = "Начало простоя";
            dataGridView1.Columns["dat_end_pr"].HeaderText = "Конец простоя";
            dataGridView1.Columns["dat_last_rem"].HeaderText = "Последний ремонт";
            dataGridView1.Columns["uzel_rem"].HeaderText = "Узел ремонта";
            dataGridView1.Columns["dlit_pp_potoka"].HeaderText = "Длит. простоя произв. потока, мин.";
            dataGridView1.Columns["norma_rem"].HeaderText = "Норма ремон- та, мин.";
            dataGridView1.Columns["fakt_vr_rem"].HeaderText = "Факт. время ремон- та, мин.";
            dataGridView1.Columns["otkl_ot_normi"].HeaderText = "Откл. от нормы, мин.";
            dataGridView1.Columns["prichina_otkl"].HeaderText = "Причина отклонения";
            dataGridView1.Columns["poteri"].HeaderText = "Потери";
            dataGridView1.Columns["tip_nepr_pr"].HeaderText = "Тип непроизведен. продукта";
            dataGridView1.Columns["opis_polomki"].HeaderText = "Описание поломки";
            dataGridView1.Columns["primech"].HeaderText = "Примечание";
            dataGridView1.Columns["ed_izm_poteri"].HeaderText = "Ед. изм.";
            dataGridView1.Columns["nam_tip_pr"].HeaderText = "Тип простоя";
            dataGridView1.Columns["nam_klas_pr"].HeaderText = "Классификация простоя";

            //dataGridView1.Columns["ceh"].Width = 20;
            dataGridView1.Columns["nam_ceh"].Width = 100;
            // dataGridView1.Columns["uth"].Width = 0;
            dataGridView1.Columns["nam_uth"].Width = 100;
            dataGridView1.Columns["inv_num"].Width = 50;
            dataGridView1.Columns["objekt"].Width = 20;
            dataGridView1.Columns["nam_inv"].Width = 200;
            dataGridView1.Columns["dat_beg_pr"].Width = 70;
            dataGridView1.Columns["dat_end_pr"].Width = 70;
            dataGridView1.Columns["dat_last_rem"].Width = 70;
            dataGridView1.Columns["uzel_rem"].Width = 100;
            dataGridView1.Columns["dlit_pp_potoka"].Width = 50;
            dataGridView1.Columns["norma_rem"].Width = 50;
            dataGridView1.Columns["fakt_vr_rem"].Width = 50;
            dataGridView1.Columns["otkl_ot_normi"].Width = 50;
            dataGridView1.Columns["prichina_otkl"].Width = 100;
            dataGridView1.Columns["poteri"].Width = 50;
            dataGridView1.Columns["tip_nepr_pr"].Width = 100;
            dataGridView1.Columns["opis_polomki"].Width = 200;
            dataGridView1.Columns["primech"].Width = 200;
            dataGridView1.Columns["ed_izm_poteri"].Width = 35;
            dataGridView1.Columns["nam_tip_pr"].Width = 100;
            dataGridView1.Columns["nam_klas_pr"].Width = 100;

            dataGridView1.Columns["nam_ceh"].DisplayIndex = 1;
            dataGridView1.Columns["nam_uth"].DisplayIndex = 2;
            dataGridView1.Columns["inv_num"].DisplayIndex = 3;
            dataGridView1.Columns["objekt"].DisplayIndex = 4;
            dataGridView1.Columns["nam_inv"].DisplayIndex = 5;
            dataGridView1.Columns["uzel_rem"].DisplayIndex = 6;
            dataGridView1.Columns["dat_beg_pr"].DisplayIndex = 7;
            dataGridView1.Columns["dat_end_pr"].DisplayIndex = 8;
            dataGridView1.Columns["dlit_pp_potoka"].DisplayIndex = 9;
            dataGridView1.Columns["norma_rem"].DisplayIndex = 10;
            dataGridView1.Columns["fakt_vr_rem"].DisplayIndex = 11;
            dataGridView1.Columns["otkl_ot_normi"].DisplayIndex = 12;
            dataGridView1.Columns["prichina_otkl"].DisplayIndex = 13;
            dataGridView1.Columns["dat_last_rem"].DisplayIndex = 14;
            dataGridView1.Columns["poteri"].DisplayIndex = 15;
            dataGridView1.Columns["ed_izm_poteri"].DisplayIndex = 16;
            dataGridView1.Columns["tip_nepr_pr"].DisplayIndex = 17;
            dataGridView1.Columns["nam_tip_pr"].DisplayIndex = 18;
            dataGridView1.Columns["nam_klas_pr"].DisplayIndex = 19;
            dataGridView1.Columns["opis_polomki"].DisplayIndex = 20;
            dataGridView1.Columns["primech"].DisplayIndex = 21;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
            con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");

            dataGridView1.DataSource = "";
            this.dataGridView1.MultiSelect = false;
            //dataGridView1.SelectionMode = CellSelect;
            con.Open();
       
             //da = new SqlDataAdapter(" select * from [Repairs].[dbo].[Prostoi]  where cast(dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd")+"' order by " , con);
            //da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "' order by ceh,uth,inv_num", con);


            if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 1)
                da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "' and status_del=0  and ceh=1 order by ceh,uth,inv_num", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 5)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "' and status_del=0 and  ceh=5 order by ceh,uth,inv_num", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 88)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "' and status_del=0 order by ceh,uth,inv_num", con);


            int k = 0;
            DataTable tab = new DataTable();
            da.Fill(tab); //Загрузка наблюдателей в DataTable
            for (int i = 0; i < tab.Rows.Count; i++) //Добавление всех наблюдателей в cbx_fio_nabl
            {
                dataGridView1.DataSource = tab;
                k = k + 1;
            }
            da.Dispose();
            con.Close();


            if (k > 0)
            {
                settings_grid();
    
             }
            else
            {
                MessageBox.Show("Ничего не найдено");
                //button1.PerformClick();
            }
            change_value_in_grid(); // дата 01.01.1900 будет =""
            
        }

        private void txt_SearchInv_TextChanged(object sender, EventArgs e)
        {
            txt_SearchName.Text = "";
            if (txt_SearchInv.Text.Length > 2)
            {
                //con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
                con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
                dataGridView1.DataSource = "";
                con.Open();
                //da = new SqlDataAdapter(" select * from [Repairs].[dbo].[Prostoi]  where cast(dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd")+"' order by " , con);
                //da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr  left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "' and  inv_num like '%" + txt_SearchInv.Text.ToString() + "%' order by ceh,uth,inv_num", con);
               
                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 1)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'  and status_del=0 and ceh=1 and  inv_num like '%" + txt_SearchInv.Text.ToString() + "%' order by ceh,uth,inv_num", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 5)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'  and status_del=0 and  ceh=5 and  inv_num like '%" + txt_SearchInv.Text.ToString() + "%' order by ceh,uth,inv_num", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 88)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'  and status_del=0 and  inv_num like '%" + txt_SearchInv.Text.ToString() + "%' order by ceh,uth,inv_num", con);



                int k = 0;
                DataTable tab = new DataTable();
                da.Fill(tab); //Загрузка наблюдателей в DataTable
                for (int i = 0; i < tab.Rows.Count; i++) //Добавление всех наблюдателей в cbx_fio_nabl
                {
                    dataGridView1.DataSource = tab;
                    k = k + 1;
                }
                da.Dispose();
                con.Close();
                if (k > 0)
                {
                    settings_grid();
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                    txt_SearchInv.Text = "";
                    button1.PerformClick();
                }
            }
            else
            { 
                if(txt_SearchInv.Text.Length <1)
                button1.PerformClick();
            }

        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            txt_SearchInv.Text = "";

            if (txt_SearchName.Text.Length > 2)
            {
                //con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
                con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
                dataGridView1.DataSource = "";
                con.Open();
                //da = new SqlDataAdapter(" select * from [Repairs].[dbo].[Prostoi]  where cast(dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd")+"' order by " , con);
                //da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "' and  nam_inv like '%" + txt_SearchName.Text.ToString() + "%' order by ceh,uth,inv_num", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 1)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'  and status_del=0 and ceh=1 and  nam_inv like '%" + txt_SearchName.Text.ToString() + "%' order by ceh,uth,inv_num", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 5)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'  and status_del=0 and  ceh=5 and  nam_inv like '%" + txt_SearchName.Text.ToString() + "%' order by ceh,uth,inv_num", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 88)
                    da = new SqlDataAdapter(" select pr.* , tp.nam_tip_pr,kp.nam_klas_pr from [Repairs].[dbo].[Prostoi] pr left join spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr  left join spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr  where cast(pr.dat_beg_pr as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'   and status_del=0 and  nam_inv like '%" + txt_SearchName.Text.ToString() + "%' order by ceh,uth,inv_num", con);


                int k = 0;
                DataTable tab = new DataTable();
                da.Fill(tab); //Загрузка наблюдателей в DataTable
                for (int i = 0; i < tab.Rows.Count; i++) //Добавление всех наблюдателей в cbx_fio_nabl
                {
                    dataGridView1.DataSource = tab;
                    k = k + 1;
                }
                da.Dispose();
                con.Close();
                if (k > 0)
                {
                    settings_grid();
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                    txt_SearchName.Text = "";
                    button1.PerformClick();
                }
           
            }
            else
            {
                if (txt_SearchName.Text.Length < 1)
                    button1.PerformClick();

                //  dataGridView1.DataSource = dal.GetAllRepair();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data1 = dtpBeg.Value.ToString("yyyy-MM-dd");
            string data2 = dtpEnd.Value.ToString("yyyy-MM-dd");

            myfrm_otchet_prostoi myfrm_otchet_prostoi = new myfrm_otchet_prostoi(data1, data2);
            myfrm_otchet_prostoi.ShowDialog();

            
        }



      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.ColumnCount > 0)
                {
                    string nam_tip_pr = dataGridView1.CurrentRow.Cells["nam_tip_pr"].Value.ToString();
                    string canred = "";
                    switch (kodostup)
                    {

                        case "1": // gosti
                            {
                                canred = "no";
                                break;
                            }

                        case "2": // tehnik po uchetu
                        case "10": // admin
                            {
                                canred = "yes";
                                break;
                            }
                        case "3": // mehanik
                            {
                                if (nam_tip_pr == "механический")
                                {
                                    canred = "yes";
                                }
                                else
                                {
                                    canred = "no";
                                }
                                break;
                            }
                        case "4": // energetik
                            {
                                if (nam_tip_pr == "электрический")
                                {
                                    canred = "yes";
                                }
                                else
                                {
                                    canred = "no";
                                }
                                break;

                            }

                        case "5": // glav_inzhener
                        case "6": // nach_shahti
                            {
                                if (nam_tip_pr == "технологический" || nam_tip_pr == "прочий")
                                {
                                    canred = "yes";
                                }
                                else
                                {
                                    canred = "no";
                                }
                                break;

                            }
                        default: // 
                            {
                                canred = "no";
                                break;
                            }
                    }


                    if (canred == "no")
                    {
                        MessageBox.Show("Вам не права редактировать тип простоя '" + nam_tip_pr.ToUpper() + "'");
                    }
                    else
                    {
                        int a = 0;
                        a = dataGridView1.CurrentRow.Index;

                        myfrmProstoi_Vvod myfrmVvodProstoi = new myfrmProstoi_Vvod("edit", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                        myfrmVvodProstoi.ShowDialog();
                        button1.PerformClick();

                        dataGridView1.FirstDisplayedCell = dataGridView1.Rows[a].Cells["nam_ceh"];
                        dataGridView1.Rows[a].Selected = true;
                    }

                }
                else
                {
                    MessageBox.Show("Нет информации для редактирования");
                }
            }
            catch
            { 

            }





        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView grid = (sender as DataGridView);
            if ((e.RowIndex > -1) && (e.RowIndex < grid.RowCount - 1))
            {
                // раскрасить в зависимости от значения определенного поля
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "1")
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;

                // разукрашиваем строки через одну
                //if (e.RowIndex % 2 == 1)
                //{
                //    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                //}        
            }
        }

        //private void dataGridView1RowPaint()
        //{
        //    int cur_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

        //    DataGridView grid = (sender as DataGridView);
        //    if ((e.RowIndex > -1) && (e.RowIndex < grid.RowCount - 1))
        //    {
        //        // раскрасить в зависимости от значения определенного поля
        //        if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "1")
        //            grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;

        //        // разукрашиваем строки через одну
        //        //if (e.RowIndex % 2 == 1)
        //        //{
        //        //    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
        //        //}        
        //    }
        //}

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          //  int cur_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

         //   dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Pink;

            //if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) == 60)
            //{
            //   ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            //}
            //else
            //{
            //    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aqua;
            //}


            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
          
        
        }

    

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myfrmProstoi_Prosm_Load(object sender, EventArgs e)
        {
            //if (Dostup.Kod_dostup_pr.Trim() == "1")  // gosti
            //{
            //    btn_red.Visible = false;
            //}
            //else
            //{
            //    btn_red.Visible = true;
            //}

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount > 0)
            {

                string message = "Действительно удалить запись?";
                string id_prostoi = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                DialogResult result = MessageBox.Show(message, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    //string aa=" update [Repairs].[dbo].[Prostoi] set status_del=1  where id='{0}' "+ id_prostoi.ToString();
                    //MessageBox.Show(aa);
                    string query1 = string.Format(@" update [Repairs].[dbo].[Prostoi] set status_del=1  where id='{0}' ", id_prostoi.ToString());
                    SqlCommand com1 = new SqlCommand(query1, con);
                    try
                    {
                        con.Open();
                        if (com1.ExecuteNonQuery() >= 1)
                        {
                            MessageBox.Show("Успешное удаление информации по простоям.");
                            button1.PerformClick();

                            zapis_v_prot("Удаление", id_prostoi.ToString());
                            ////// запись в протокол
                            //string dejstvie = "Удаление";
                            //string uchetka = Environment.UserName.ToString();
                            //DateTime datnow = DateTime.Now;
                            //string query2 = string.Format(@" insert into [Repairs].[dbo].[Prostoi_protokol] ([id_prostoi],[dejstvie],[tekdate],[uchetka]) values ('{0}','{1}','{2}','{3}') ", id_prostoi.ToString(), dejstvie.ToString(),datnow, uchetka.ToString());
                            //SqlCommand com2 = new SqlCommand(query2, con);
                            //try
                            //{
                            //    con.Open();
                            //    if (com2.ExecuteNonQuery() >= 1)
                            //    { }
                            //    else
                            //    {

                            //        MessageBox.Show(dejstvie+" НЕ записалось в протокол. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                            //    }
                            //}
                            //catch
                            //{
                            //    MessageBox.Show(dejstvie+" НЕ записалось в протокол. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                            //}
                            //////////////
                        }
                        else
                        {
                            MessageBox.Show("НЕвозможно удалить информацию. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Ошибка удаления"); }
                }
            }
            else
            {
                MessageBox.Show("Невозможно удалить пустую информацию");
            }
        }

        private void change_value_in_grid() // дата 01.01.1900 будет = ""
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {


                    if (dataGridView1[10, i].Value.ToString().Trim() == "01.01.1900 0:00:00")
                        dataGridView1[10, i].Value="";
                        //  dataGridView1[10, i].Style.ForeColor = Color.White;
//                    else dataGridView1[10, i].Style.ForeColor = Color.Black;
                    if (dataGridView1[9, i].Value.ToString().Trim() == "01.01.1900 0:00:00")
//                        dataGridView1[9, i].Style.ForeColor = Color.White;
                        dataGridView1[9, i].Value = "";
  //                  else dataGridView1[9, i].Style.ForeColor = Color.Black;

                }
            }
            catch { }
       }


        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
