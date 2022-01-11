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
    public partial class myfrmProstoi_Vvod : Form
    {
        
        public string tip_formi ="";
        public string id_prostoi = "";
        public DataTable dt1 = new DataTable();
        public DataTable dt2 = new DataTable();
        public DataTable dt3 = new DataTable();
        public DataTable dt4 = new DataTable();
        public DataTable dt5 = new DataTable();
        public DataTable dt6 = new DataTable();
        string txt_tip_pr = "";
        string txt_klassif_pr = "";
        string txt_tip_nepr_pr = "";
        string txt_uzel_rem = "";
        string txt_kod_tip_pr = "";
        string txt_id_prostoi="";
        string kodostup = Dostup.Kod_dostup_pr.Trim();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlDataAdapter da2;
        public string param_from_frm = "";
        public string knopka = "";
        //SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=STAFF;Integrated Security=True;");
        SqlConnection con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");

        public myfrmProstoi_Vvod(string tipformi, string idprostoi)
        {
            InitializeComponent();
            tip_formi = tipformi;
            id_prostoi = idprostoi;
        }


        private void btn_delNextDate_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1900,1,1);
            dtp_DataEnd.Value = date1;
            btn_DataEnd.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1900, 1, 1);
            dtp_DataLastRem.Value = date1;
            btn_DataLastRem.Visible = true;

        }

        private void btn_dataOut_Click(object sender, EventArgs e)
        {
            
            btn_DataEnd.Visible = false;
            dtp_DataEnd.Value = DateTime.Today;
        }

        private void btn_DateLastRem_Click(object sender, EventArgs e)
        {
            btn_DataLastRem.Visible = false;
            dtp_DataLastRem.Value = DateTime.Today;
        }


        private void zapis_v_prot(string dejstvie, string idprostoi)
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
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show(dejstvie + " НЕ записалось в протокол. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                con.Close();
            }
            ////////////
        }

        private void nastrojka_dostup()
        {

            cbx_NamCeh.Enabled = false;
            cbx_NamUth.Enabled = false;

            switch (kodostup)
            {
                case "3": // mehanik
                case "4": // energetik
                case "5": // glav_inzhener
                case "6": // nach_shahti
                    {
                        btn_vib_inv.Enabled = false;
                        btn_bez_inv.Enabled = false;
                        cbx_uzel_rem.Enabled = false;
                        dtp_DataBegin.Enabled = false;
                        btn_DataEnd.Enabled = false;
                        btn_DelDataEnd.Enabled = false;
                        dtp_DataEnd.Enabled = false;
                        nud_dlit_ppp.Enabled = false;
                        nud_norma_rem.Enabled = false;
                        nud_fakt_vr_rem.Enabled = false;
                        nud_poteri_ob.Enabled = false;
                        cbx_ed_izm_poteri.Enabled = false;
                        cbx_tip_nepr_prod.Enabled = false;
                        cbx_tip_pr.Enabled = false;
                        cbx_klassif_pr.Enabled = false;
                        btn_add_klassif_pr.Enabled = false;
                        
                        nud_otkl_ot_normi.Enabled = true;
                        cbx_prich_otkl.Enabled = true;
                        btn_DataLastRem.Enabled = true;
                        btn_DelDataLastRem.Enabled = true;
                        dtp_DataLastRem.Enabled = true;
                        txt_opis_polom.Enabled = true;
                        txt_primech.Enabled = true;

                        break;
                    }

                case "2": // tehnik po uchetu
                    {

                        if (tip_formi == "add")
                        {
                            btn_vib_inv.Enabled = true;
                            btn_bez_inv.Enabled = true;
                        }
                        else
                        {
                            btn_vib_inv.Enabled = false;
                            btn_bez_inv.Enabled = false;
                        }



                        cbx_uzel_rem.Enabled = true;
                        dtp_DataBegin.Enabled = true;
                        btn_DataEnd.Enabled = true;
                        btn_DelDataEnd.Enabled = true;
                        dtp_DataEnd.Enabled = true;
                        nud_dlit_ppp.Enabled = true;
                        nud_norma_rem.Enabled = true;
                        nud_fakt_vr_rem.Enabled = true;
                        nud_otkl_ot_normi.Enabled = true;
                        cbx_prich_otkl.Enabled = true;
                        btn_DataLastRem.Enabled = true;
                        btn_DelDataLastRem.Enabled = true;
                        dtp_DataLastRem.Enabled = true;
                        nud_poteri_ob.Enabled = true;
                        cbx_ed_izm_poteri.Enabled = true;
                        cbx_tip_nepr_prod.Enabled = true;
                        cbx_tip_pr.Enabled = true;
                        cbx_klassif_pr.Enabled = true;
                        btn_add_klassif_pr.Enabled = true;
                        txt_opis_polom.Enabled = true;
                        txt_primech.Enabled = true;
                        break;
                    }
                default:
                    {
                        btn_vib_inv.Enabled = false;
                        btn_bez_inv.Enabled = false;
                        cbx_uzel_rem.Enabled = false;
                        dtp_DataBegin.Enabled = false;
                        btn_DataEnd.Enabled = false;
                        btn_DelDataEnd.Enabled = false;
                        dtp_DataEnd.Enabled = false;
                        nud_dlit_ppp.Enabled = false;
                        nud_norma_rem.Enabled = false;
                        nud_fakt_vr_rem.Enabled = false;
                        nud_otkl_ot_normi.Enabled = false;
                        cbx_prich_otkl.Enabled = false;
                        btn_DataLastRem.Enabled = false;
                        btn_DelDataLastRem.Enabled = false;
                        dtp_DataLastRem.Enabled = false;
                        nud_poteri_ob.Enabled = false;
                        cbx_ed_izm_poteri.Enabled = false;
                        cbx_tip_nepr_prod.Enabled = false;
                        cbx_tip_pr.Enabled = false;
                        cbx_klassif_pr.Enabled = false;
                        btn_add_klassif_pr.Enabled = false;
                        txt_opis_polom.Enabled = false;
                        txt_primech.Enabled = false;
                        break;
                    }
            }
                
        }
        private void myfrmVvodProstoi_Load(object sender, EventArgs e)
        {
            if (tip_formi == "add")
            {
                var column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "";
                column1.Name = "Column1";
                column1.Width = 250;
                DateTime date1 = new DateTime(1900, 1, 1);
                dtp_DataEnd.Value = date1;
                dtp_DataLastRem.Value = date1;

                //con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
                con = new SqlConnection("Data Source=UAESB-SQL-01;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
                con.Open();
                dt1 = new DataTable();

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 1)
                    da = new SqlDataAdapter("SELECT [_IDRRef],[_Code],[_Description],[_Fld9356RRef]  FROM [Staff].[dbo].[_Reference85] r85 where  (r85.[_Code]='1') and  r85._ParentIDRRef=0x00000000000000000000000000000000 ", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 5)
                    da = new SqlDataAdapter("SELECT [_IDRRef],[_Code],[_Description],[_Fld9356RRef]  FROM [Staff].[dbo].[_Reference85] r85 where  (r85.[_Code]='5') and  r85._ParentIDRRef=0x00000000000000000000000000000000 ", con);

                if (Convert.ToInt32(Dostup.Ceh_dostup_pr) == 88)
                    da = new SqlDataAdapter("SELECT [_IDRRef],[_Code],[_Description],[_Fld9356RRef]  FROM [Staff].[dbo].[_Reference85] r85 where  (r85.[_Code]='1' or r85.[_Code]='5') and  r85._ParentIDRRef=0x00000000000000000000000000000000 ", con);

                da.Fill(dt1); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt1.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
                {
                    cbx_NamCeh.Items.Add(dt1.Rows[i][2].ToString());
                    
                }
                cbx_NamCeh.SelectedIndex = 0;

                da.Dispose();
                con.Close();

                con.Open();
                dt2 = new DataTable();
                da = new SqlDataAdapter("SELECT  [id],[kod_tip_pr] ,[nam_tip_pr] FROM [Repairs].[dbo].[spr_tip_pr]  order by nam_tip_pr", con);
                da.Fill(dt2); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt2.Rows.Count; i++) //Добавление 
                {
                    cbx_tip_pr.Items.Add(dt2.Rows[i][2].ToString());
                    
                }
                da.Dispose();
                con.Close();

                txt_invNum.Text = "";
                txt_Obekt.Text = "";
                txt_InvName.Text = "";
                btn_save.Visible = false;


                // Заполняем узел ремонта
                con.Open();
                dt6 = new DataTable();
                da = new SqlDataAdapter("SELECT distinct uzel_rem  FROM [Repairs].[dbo].[Prostoi] order by uzel_rem ", con);
                da.Fill(dt6); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt6.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
                {
                    cbx_uzel_rem.Items.Add(dt6.Rows[i][0].ToString());
                    //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
                }
                da.Dispose();
                con.Close();

                // Заполняем тип непр.пр.
                con.Open();
                dt6 = new DataTable();
                da = new SqlDataAdapter("SELECT distinct tip_nepr_pr  FROM [Repairs].[dbo].[Prostoi] order by tip_nepr_pr ", con);
                da.Fill(dt6); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt6.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
                {
                    cbx_tip_nepr_prod.Items.Add(dt6.Rows[i][0].ToString());
                    //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
                }
                da.Dispose();
                con.Close();

                // Заполняем ед.изм.потери
                con.Open();
                dt6 = new DataTable();
                da = new SqlDataAdapter("SELECT distinct ed_izm_poteri FROM [Repairs].[dbo].[Prostoi] order by ed_izm_poteri ", con);
                da.Fill(dt6); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt6.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
                {
                    cbx_ed_izm_poteri.Items.Add(dt6.Rows[i][0].ToString());
                    //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
                }
                da.Dispose();
                con.Close();

            }
            if (tip_formi == "edit")
            {
                btn_save.Visible = true;
                btn_save.Enabled = true;
                //string txt_tip_pr = "";
                //string txt_klassif_pr="";
                //con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
                con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
                con.Open();
                dt1 = new DataTable();
                         
                da = new SqlDataAdapter("SELECT pr.[id],[ceh],[nam_ceh],[uth],[nam_uth],[inv_num],[objekt],[nam_inv],[dat_beg_pr],[dat_end_pr],[dat_last_rem],[dlit_pp_potoka] ,"+
  "[norma_rem],[fakt_vr_rem],[otkl_ot_normi],[prichina_otkl],[poteri],[tip_nepr_pr],pr.[kod_tip_pr],[kod_klassif_pr],[opis_polomki],[primech],[tektime],[uchetka] ,[ed_izm_poteri] "+
  ",tp.nam_tip_pr,kp.nam_klas_pr,pr.uzel_rem FROM [Repairs].[dbo].[Prostoi] pr " +
  " left join [Repairs].[dbo].spr_tip_pr tp on pr.kod_tip_pr=tp.kod_tip_pr "+
  " left join [Repairs].[dbo].spr_klas_pr kp on pr.kod_tip_pr=kp.kod_tip_pr and pr.kod_klassif_pr=kp.kod_klas_pr where pr.id='" + id_prostoi.ToString() + "'", con);
                da.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++) //Добавление 
                {
                    txt_id_prostoi = dt1.Rows[i][0].ToString();
                    cbx_NamCeh.Items.Add(dt1.Rows[i][2].ToString());
                    cbx_NamUth.Items.Add(dt1.Rows[i][4].ToString());
                    txt_invNum.Text = dt1.Rows[i][5].ToString();
                    txt_Obekt.Text = dt1.Rows[i][6].ToString();
                    txt_InvName.Text = dt1.Rows[i][7].ToString();
                    DateTime d_b_pr =  Convert.ToDateTime(dt1.Rows[i][8].ToString());
                    DateTime d_e_pr = Convert.ToDateTime(dt1.Rows[i][9].ToString());
                    DateTime d_l_rem = Convert.ToDateTime(dt1.Rows[i][10].ToString());
                    dtp_DataBegin.Value = new DateTime(d_b_pr.Year, d_b_pr.Month, d_b_pr.Day);
                    dtp_DataEnd.Value = new DateTime(d_e_pr.Year, d_e_pr.Month, d_e_pr.Day); 
                    dtp_DataLastRem.Value = new DateTime(d_l_rem.Year, d_l_rem.Month, d_l_rem.Day);
                    
                    //DateTime date1 = new DateTime(1900, 1, 1);
                    //if (dtp_DataEnd.Value == date1)
                    //{
                    //    btn_DataEnd.Visible = true;
                    //}
                    //else
                    //{
                    //    btn_DataEnd.Visible = false;
                    //}

                    //if (dtp_DataLastRem.Value == date1)
                    //{
                    //    btn_DataLastRem.Visible = true; 
                    //}
                    //else
                    //{
                    //    btn_DataLastRem.Visible = false;
                    //}

                    nud_dlit_ppp.Value = Convert.ToDecimal(dt1.Rows[i][11].ToString());
                    nud_norma_rem.Value = Convert.ToDecimal(dt1.Rows[i][12].ToString());
                    nud_fakt_vr_rem.Value = Convert.ToDecimal(dt1.Rows[i][13].ToString());
                    nud_otkl_ot_normi.Value = Convert.ToDecimal(dt1.Rows[i][14].ToString());
                    cbx_prich_otkl.Text = dt1.Rows[i][15].ToString();
                    nud_poteri_ob.Value = Convert.ToDecimal(dt1.Rows[i][16].ToString());
                    cbx_ed_izm_poteri.Text=dt1.Rows[i][24].ToString();
                    
                    //cbx_tip_nepr_prod.Text=dt1.Rows[i][17].ToString();
                    txt_tip_nepr_pr = dt1.Rows[i][17].ToString();
                    txt_tip_pr=dt1.Rows[i][25].ToString();
                    txt_klassif_pr = dt1.Rows[i][26].ToString();
                    //cbx_tip_pr.Items.Add(dt1.Rows[i][25].ToString());
                    //cbx_klassif_pr.Items.Add(dt1.Rows[i][26].ToString());
                    txt_uzel_rem = dt1.Rows[i][27].ToString();
                    txt_opis_polom.Text=dt1.Rows[i][20].ToString();
                    txt_primech.Text = dt1.Rows[i][21].ToString();
                   // txt_kod_tip_pr = dt1.Rows[i][19].ToString();
                }
                da.Dispose();
                con.Close();



                ////////// заполняем тип простоев
                con.Open();
                dt2 = new DataTable();
                da = new SqlDataAdapter("SELECT  [id],[kod_tip_pr] ,[nam_tip_pr] FROM [Repairs].[dbo].[spr_tip_pr] order by nam_tip_pr", con);
                da.Fill(dt2); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt2.Rows.Count; i++) //Добавление 
                {
                    cbx_tip_pr.Items.Add(dt2.Rows[i][2].ToString());
                }
                da.Dispose();
                con.Close();
                cbx_tip_pr.SelectedIndex = cbx_tip_pr.FindString(txt_tip_pr); // становимся на 

                ///////////

                ////////// заполняем классиф.простоев
                //con.Open();
                //dt2 = new DataTable();
                //da = new SqlDataAdapter("SELECT  [id],[kod_tip_pr],[kod_klas_pr],[nam_klas_pr] FROM [Repairs].[dbo].[spr_klas_pr] where kod_tip_pr='" + txt_kod_tip_pr.ToString() + "'", con);

                //da.Fill(dt2); //Загрузка данных о цехах в DataTable
                //for (int i = 0; i < dt2.Rows.Count; i++) //Добавление 
                //{
                //    cbx_klassif_pr.Items.Add(dt2.Rows[i][2].ToString());
                //}
                //da.Dispose();
                //con.Close();
                //cbx_klassif_pr.SelectedIndex = cbx_klassif_pr.FindString(txt_tip_pr); // становимся на 

                ///////////


                // Заполняем тип непр.пр.
                con.Open();
                dt6 = new DataTable();
                da = new SqlDataAdapter("SELECT distinct tip_nepr_pr  FROM [Repairs].[dbo].[Prostoi] order by tip_nepr_pr ", con);
                da.Fill(dt6); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt6.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
                {
                    cbx_tip_nepr_prod.Items.Add(dt6.Rows[i][0].ToString());
                    //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
                }
                da.Dispose();
                con.Close();
                cbx_tip_nepr_prod.SelectedIndex = cbx_tip_nepr_prod.FindString(txt_tip_nepr_pr);
                //////////////


                // Заполняем узел ремонта
                con.Open();
                dt6 = new DataTable();
                da = new SqlDataAdapter("SELECT distinct uzel_rem  FROM [Repairs].[dbo].[Prostoi] order by uzel_rem ", con);
                da.Fill(dt6); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt6.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
                {
                    cbx_uzel_rem.Items.Add(dt6.Rows[i][0].ToString());
                    //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
                }
                da.Dispose();
                con.Close();
                cbx_uzel_rem.SelectedIndex = cbx_uzel_rem.FindString(txt_uzel_rem);
                /////

                DateTime date1 = new DateTime(1900, 1, 1);
                if (dtp_DataEnd.Value == date1)
                {
                    btn_DataEnd.Visible = true;
                }
                else
                {
                    btn_DataEnd.Visible = false;
                }

                if (dtp_DataLastRem.Value == date1)
                {
                    btn_DataLastRem.Visible = true;
                }
                else
                {
                    btn_DataLastRem.Visible = false;
                }


                //// Добавляем одну строку в грид
                //var column1 = new DataGridViewTextBoxColumn();
                //column1.HeaderText = "";
                //column1.Name = "Column1";
                //column1.Width = 250;
                //this.dgv_uzel_rem.Columns.AddRange(new DataGridViewColumn[] { column1 });
                //this.dgv_uzel_rem.ReadOnly = true;
                ////

                //con.Open();
                //dt6 = new DataTable();
                //string dd = "  SELECT  nam_uzla_rem  FROM [Repairs].[dbo].[spis_uzli_rem]  where id_prostoi='" + id_prostoi.ToString() + "' order by nam_uzla_rem ";
                //da = new SqlDataAdapter("  SELECT  nam_uzla_rem  FROM [Repairs].[dbo].[spis_uzli_rem]  where id_prostoi='" + id_prostoi.ToString() + "' order by nam_uzla_rem ", con);
                //da.Fill(dt6); //Загрузка данных  в DataTable


                //for (int i = 0; i < dt6.Rows.Count; i++) //Добавление 
                //{
                //    int rowId = dgv_uzel_rem.Rows.Add();
                //    DataGridViewRow row = dgv_uzel_rem.Rows[rowId];
                //    row.Cells["Column1"].Value = dt6.Rows[i][0].ToString();
                //    //cbx_uzel_rem.Items.Add(dt6.Rows[i][0].ToString());
                //}
                //da.Dispose();
                //con.Close();



                cbx_NamCeh.SelectedIndex= 0;
                cbx_NamCeh.Enabled=false;

                cbx_NamUth.SelectedIndex = 0;
                cbx_NamUth.Enabled = false;
                
                //cbx_tip_pr.SelectedIndex = 0;
                cbx_tip_pr.Enabled = true;
                
                //cbx_klassif_pr.SelectedIndex = 0;
                cbx_klassif_pr.Enabled = true;
         //   }
            
            //cbx_klassif_pr.Enabled = false;
            //btn_add_klassif_pr.Visible = true;

            // Заполняем наименования узлов ремонта

                nastrojka_dostup();
           }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_InvName.ReadOnly = true;
            //txt_InvName.BackColor = Color.Gray;
            txt_InvName.BorderStyle = System.Windows.Forms.BorderStyle.None; 


            myfrmSearchTMC myfrmSearchTMC = new myfrmSearchTMC(txt_NomCeh.Text.ToString().Trim() + "prostoi", txt_NomCeh.Text.ToString(), txt_NomUth.Text.ToString());
           

            //отлавливаем нажатие кнопки на форме выбора ТМЦ

            myfrmSearchTMC.FormClosed += (closedSender, closedE) =>
            {
                {
                    txt_invNum.Text = Inv_Number.Inv_n;
                    txt_InvName.Text = Inv_Number.Inv_name.Trim();
                    txt_Obekt.Text = Inv_Number.Obekt;
                    if (txt_invNum.Text.Trim() == "")
                    {
                        btn_save.Visible = false;
                    }
                    else
                    {
                        btn_save.Visible = true;
                    }
                    btn_vib_inv.Enabled = true;
                }
            };
            //исправил. надо вернуть на место
            try
            {
                myfrmSearchTMC.ShowDialog();
            }
            catch { }
            
        }

        private void cbx_NamCeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tip_formi == "add")
            {
                txt_NomCeh.Text = dt1.Rows[cbx_NamCeh.SelectedIndex][1].ToString();

                btn_vib_inv.Enabled = true;

                //string ff = "select _Description,_code from [Staff].[dbo].[_Reference85] where _Fld9356RRef in  (SELECT [_IDRRef] FROM [Staff].[dbo].[_Reference85] r85 where  (r85.[_Code]='" + txt_NomCeh.Text + "')) and len(_code)>1";
                con.Close();
                con.Open();
                da2 = new SqlDataAdapter("select _Description,_code from [Staff].[dbo].[_Reference85] where _Fld9356RRef in  (SELECT [_IDRRef] FROM [Staff].[dbo].[_Reference85] r85 where  (r85.[_Code]='" + txt_NomCeh.Text + "')) and len(_code)>1", con);

                cbx_NamUth.Items.Clear();
                cbx_NamUth.Text = "";
                dt3 = new DataTable();

                da2.Fill(dt3); //Загрузка данных о цехах в DataTable
                for (int i = 0; i < dt3.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
                {
                    cbx_NamUth.Items.Add(dt3.Rows[i][0].ToString());
                    //cbx_fio_nabludaemogo.Items.Add(dt.Rows[i][1].ToString());
                }
                da2.Dispose();
                con.Close();
                txt_invNum.Text = "";
                txt_Obekt.Text = "";
                txt_InvName.Text = "";
                if (txt_invNum.Text.Trim() == "")
                    btn_save.Visible = false;
                else
                    btn_save.Visible = true;

                btn_vib_inv.Enabled = false;
            }
        }

        private void cbx_NamUth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tip_formi == "add")
            {
                string koduth = dt3.Rows[cbx_NamUth.SelectedIndex][1].ToString();
                //txt_NamUth.Text = dt3.Rows[cbx_NamUth.SelectedIndex][1].ToString().Trim();
                int len_kod_ch = txt_NomCeh.Text.Trim().Length;
                txt_NomUth.Text = koduth.Substring(len_kod_ch + 1, 2);
                //string s = "";
                txt_invNum.Text = "";
                txt_Obekt.Text = "";
                txt_InvName.Text = "";
                if (txt_invNum.Text.Trim() == "")
                    btn_save.Visible = false;
                else
                    btn_save.Visible = true;

                btn_vib_inv.Enabled = true;
                btn_bez_inv.Enabled = true;
            }
        }

        private void txt_InvName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tip_formi == "add")
            {
                // (cbx_tip_pr.Text.ToString().Trim() == "" || cbx_klassif_pr.Text.ToString().Trim() == "" || cbx_ed_izm_poteri.Text.ToString().Trim() == "")
                if (cbx_tip_pr.Text.ToString().Trim() == "" || cbx_ed_izm_poteri.Text.ToString().Trim() == "")
                {
                    if (cbx_tip_pr.Text.ToString().Trim() == "")
                        MessageBox.Show("Заполните тип простоя");
                    //if (cbx_klassif_pr.Text.ToString().Trim() == "")
                    //    MessageBox.Show("Заполните классификацию простоя");
                    if (cbx_ed_izm_poteri.Text.ToString().Trim() == "")
                        MessageBox.Show("Заполните единицы измерения потерь объема производства");
                }
                else
                {

                    string oshibka = "";
                    string uchetka = Environment.UserName.ToString();
                    string tekdat = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    string dat_nach_pr = dtp_DataBegin.Value.ToString("yyyy-MM-dd");
                    string dat_konec_pr = dtp_DataEnd.Value.ToString("yyyy-MM-dd");
                    string dat_last_rem = dtp_DataLastRem.Value.ToString("yyyy-MM-dd");

                    string query1 = string.Format(@" insert  into [Repairs].[dbo].[Prostoi]  
                  ([ceh] ,[nam_ceh],[uth],[nam_uth]
                  ,[inv_num] ,[objekt],[nam_inv]
                  ,[dat_beg_pr] ,[dat_end_pr] ,[dat_last_rem]
                  ,[dlit_pp_potoka] ,[norma_rem] ,[fakt_vr_rem] 
                  ,[otkl_ot_normi],[prichina_otkl]
                  ,[poteri]
                  ,[tip_nepr_pr] ,[kod_tip_pr] ,[kod_klassif_pr]
                  ,[opis_polomki] ,[primech]
                  ,[tektime] ,[uchetka], [ed_izm_poteri],[uzel_rem],[status_del])  
                    values 
                   ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}',
                    '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}','{23}','{24}','{25}') ", txt_NomCeh.Text.ToString(), cbx_NamCeh.Text.ToString(), txt_NomUth.Text.ToString(), cbx_NamUth.Text.ToString(),
                                                                        txt_invNum.Text.ToString(), txt_Obekt.Text.ToString(), txt_InvName.Text.ToString(),
                                                                        dat_nach_pr, dat_konec_pr, dat_last_rem,
                                                                        nud_dlit_ppp.Value.ToString(), nud_norma_rem.Value.ToString(), nud_fakt_vr_rem.Value.ToString(),
                                                                        nud_otkl_ot_normi.Value.ToString(), cbx_prich_otkl.Text.ToString(),
                                                                        nud_poteri_ob.Value.ToString().Replace(",", "."),
                                                                        cbx_tip_nepr_prod.Text.ToString(), dt2.Rows[cbx_tip_pr.SelectedIndex][1].ToString(), dt5.Rows[cbx_klassif_pr.SelectedIndex][2].ToString(),
                                                                        txt_opis_polom.Text.ToString(), txt_primech.Text.ToString(),
                                                                        tekdat, uchetka, cbx_ed_izm_poteri.Text.ToString(), cbx_uzel_rem.Text.ToString(),0);
                    SqlCommand com1 = new SqlCommand(query1, con);
                    try
                    {
                        con.Open();
                        if (com1.ExecuteNonQuery() >= 1)
                        {
                            oshibka = "";
                            MessageBox.Show("Успешное сохраниение информации по простоям.");
                           
                        }
                        else
                        {
                            oshibka = "yes";
                            MessageBox.Show("НЕвозможно схранить информацию. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                        }
                    }
                    catch
                    {
                        oshibka = "yes";
                        MessageBox.Show("НЕвозможно схранить информацию. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                    }

                    con.Close();
                    this.Close();

                }
            }
            if (tip_formi == "edit")
            {
                if (cbx_tip_pr.Text.ToString().Trim() == "" || cbx_ed_izm_poteri.Text.ToString().Trim() == "")
                {
                    if (cbx_tip_pr.Text.ToString().Trim() == "")
                        MessageBox.Show("Заполните тип простоя");
                    //if (cbx_klassif_pr.Text.ToString().Trim() == "")
                    //    MessageBox.Show("Заполните классификацию простоя");
                    if (cbx_ed_izm_poteri.Text.ToString().Trim() == "")
                        MessageBox.Show("Заполните единицы измерения потерь объема производства");
                }
                else
                {

                    string oshibka = "";
                    string uchetka = Environment.UserName.ToString();
//                    DateTime tekdat = DateTime.Now;
                    string tekdat = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    string dat_nach_pr = dtp_DataBegin.Value.ToString("yyyy-MM-dd");
                    string dat_konec_pr = dtp_DataEnd.Value.ToString("yyyy-MM-dd");
                    string dat_last_rem = dtp_DataLastRem.Value.ToString("yyyy-MM-dd");


                    string query1 = string.Format(@" update [Repairs].[dbo].[Prostoi]  set 
                  [dat_beg_pr]='{7}' ,[dat_end_pr]='{8}' ,[dat_last_rem]='{9}'
                  ,[dlit_pp_potoka]='{10}' ,[norma_rem]='{11}' ,[fakt_vr_rem] ='{12}'
                  ,[otkl_ot_normi]='{13}',[prichina_otkl]='{14}'
                  ,[poteri]='{15}'
                  ,[tip_nepr_pr]='{16}' ,[kod_tip_pr]='{17}' ,[kod_klassif_pr]='{18}'
                  ,[opis_polomki] ='{19}',[primech]='{20}'
                  ,[tektime]='{21}' ,[uchetka]='{22}', [ed_izm_poteri]='{23}',[uzel_rem]='{24}' where id='{25}' ", txt_NomCeh.Text.ToString(), cbx_NamCeh.Text.ToString(), txt_NomUth.Text.ToString(), cbx_NamUth.Text.ToString(),
                                                                        txt_invNum.Text.ToString(), txt_Obekt.Text.ToString(), txt_InvName.Text.ToString(),
                                                                        dat_nach_pr, dat_konec_pr, dat_last_rem,
                                                                        nud_dlit_ppp.Value.ToString(), nud_norma_rem.Value.ToString(), nud_fakt_vr_rem.Value.ToString(),
                                                                        nud_otkl_ot_normi.Value.ToString(), cbx_prich_otkl.Text.ToString(),
                                                                        nud_poteri_ob.Value.ToString().Replace(",", "."),
                                                                        cbx_tip_nepr_prod.Text.ToString(), dt2.Rows[cbx_tip_pr.SelectedIndex][1].ToString(), dt5.Rows[cbx_klassif_pr.SelectedIndex][2].ToString(),
                                                                        txt_opis_polom.Text.ToString(), txt_primech.Text.ToString(),
                                                                        tekdat, uchetka, cbx_ed_izm_poteri.Text.ToString(), cbx_uzel_rem.Text.ToString(), id_prostoi.ToString());
                    string aa = "";
                    SqlCommand com1 = new SqlCommand(query1, con);
                    try
                    {
                        con.Open();
                        if (com1.ExecuteNonQuery() >= 1)
                        {
                            oshibka = "";
                            MessageBox.Show("Успешное сохраниение информации по простоям.");
                            con.Close();
                            zapis_v_prot("Редактирование", id_prostoi.ToString());
                        }
                        else
                        {
                            oshibka = "yes";
                            MessageBox.Show("НЕвозможно схранить информацию. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                        }
                    }
                    catch
                    {
                        oshibka = "yes";
                        MessageBox.Show("НЕвозможно схранить информацию. Обратитесь к разработчику ПО по тел. 409-72-78 ");
                    }

                    con.Close();
                    this.Close();

                }
            }
        }

        private void cbx_tip_pr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
            con = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True");
            con.Open();

            string kod_tip_pr = dt2.Rows[cbx_tip_pr.SelectedIndex][1].ToString();
            cbx_klassif_pr.Items.Clear();
            cbx_klassif_pr.Text = "";
            dt5 = new DataTable();
            da = new SqlDataAdapter("SELECT  [id],[kod_tip_pr],[kod_klas_pr],[nam_klas_pr] FROM [Repairs].[dbo].[spr_klas_pr] where kod_tip_pr='" + kod_tip_pr.ToString() + "' order by nam_klas_pr ", con);
            da.Fill(dt5); //Загрузка данных о цехах в DataTable
            for (int i = 0; i < dt5.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
            {
                cbx_klassif_pr.Items.Add(dt5.Rows[i][3].ToString());
            }
            da.Dispose();
            con.Close();
            cbx_klassif_pr.Enabled = true;
            btn_add_klassif_pr.Visible = true;

            if (tip_formi == "edit")
            {
                cbx_klassif_pr.SelectedIndex = cbx_klassif_pr.FindString(txt_klassif_pr.Trim());
            }
            else
            {
                cbx_klassif_pr.SelectedIndex = 0;
            }
        }

        private void btn_dataOut_Click_1(object sender, EventArgs e)
        {
            btn_DataEnd.Visible = false;
            dtp_DataEnd.Value = DateTime.Now;

            
        }

        private void btn_delNextDate_Click_1(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1900, 1, 1);
            dtp_DataEnd.Value = date1;
            btn_DataEnd.Visible = true;
        }

        private void btn_DelDataLastRem_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1900, 1, 1);
            dtp_DataLastRem.Value = date1;
            btn_DataLastRem.Visible = true;

        }

        private void btn_DataLastRem_Click(object sender, EventArgs e)
        {
            btn_DataLastRem.Visible = false;
            dtp_DataLastRem.Value = DateTime.Now;
        }

        private void nud_dlit_ppp_ValueChanged(object sender, EventArgs e)
        {
            nud_fakt_vr_rem.Value = nud_dlit_ppp.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kod_tip_pr = dt2.Rows[cbx_tip_pr.SelectedIndex][1].ToString();
            string nam_tip_pr =dt2.Rows[cbx_tip_pr.SelectedIndex][2].ToString();
            myfrm_klassif_pr myfrm_klassif_pr = new myfrm_klassif_pr(kod_tip_pr, nam_tip_pr);
            myfrm_klassif_pr.ShowDialog();

            // обновляем справ.классификации простоев
            kod_tip_pr = dt2.Rows[cbx_tip_pr.SelectedIndex][1].ToString();
            cbx_klassif_pr.Items.Clear();
            cbx_klassif_pr.Text = "";
            dt5 = new DataTable();
            da = new SqlDataAdapter("SELECT  [id],[kod_tip_pr],[kod_klas_pr],[nam_klas_pr] FROM [Repairs].[dbo].[spr_klas_pr] where kod_tip_pr='" + kod_tip_pr.ToString() + "' order by nam_klas_pr", con);
            da.Fill(dt5); //Загрузка данных о цехах в DataTable
            for (int i = 0; i < dt5.Rows.Count; i++) //Добавление всех пользователей в comboBox1, 4, 5
            {
                cbx_klassif_pr.Items.Add(dt5.Rows[i][3].ToString());
            }
            da.Dispose();
            con.Close();
            cbx_klassif_pr.Enabled = true;
            btn_add_klassif_pr.Visible = true;

        }

        private void nud_norma_rem_ValueChanged(object sender, EventArgs e)
        {
         //  nud_otkl_ot_normi.Value = nud_norma_rem.Value - nud_fakt_vr_rem.Value; 
        }

        private void nud_fakt_vr_rem_ValueChanged(object sender, EventArgs e)
        {
           // nud_otkl_ot_normi.Value = nud_norma_rem.Value - nud_fakt_vr_rem.Value; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_save.Visible = true;
            txt_invNum.Text = "0";
            txt_Obekt.Text = "0";
            txt_InvName.Text = "";
            txt_InvName.ReadOnly = false;
            //txt_InvName.BackColor=Color.White;
            txt_InvName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
            txt_InvName.Select();


        }

        private void txt_InvName_Validated(object sender, EventArgs e)
        {
            if (txt_InvName.Text.Trim().Length > 1)
            {
                btn_save.Visible = true;
            }
            else
            {
                MessageBox.Show("Заполните 'Наименование оборудования'");
                txt_InvName.Select();
                btn_save.Visible = false;
            }
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    // Будем получать параметр из дочерной формы
        //    myfrm_add_uzel_rem myfrm_add_uzel_rem = new myfrm_add_uzel_rem();
        //    myfrm_add_uzel_rem.Owner = this;
        //    myfrm_add_uzel_rem.ShowDialog();

        //    //this.dgv_uzel_rem.Rows.Add(param_from_frm);
        //    //this.dgv_uzel_rem.Rows[1].Cells[0].Value = param_from_frm;

        //    if (knopka == "add")
        //    {
        //        int rowId = dgv_uzel_rem.Rows.Add();
        //        DataGridViewRow row = dgv_uzel_rem.Rows[rowId];
        //        row.Cells["Column1"].Value = param_from_frm;
        //    }

        // if (dgv_uzel_rem.RowCount > 1)
        // {
        //     btn_del_uzel.Visible = true;
        // }
        // else
        // {
        //     btn_del_uzel.Visible = false;
        // }

            
        //    //textBox1.Text  = param_from_frm;

        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    удаление строки датагид
        //    int ind = dgv_uzel_rem.SelectedCells[0].RowIndex;
        //    dgv_uzel_rem.Rows.RemoveAt(ind);
        //    if (dgv_uzel_rem.RowCount > 1)
        //    {
        //        btn_del_uzel.Visible = true;
        //    }
        //    else
        //    {
        //        btn_del_uzel.Visible = false;
        //    }

        //}

       
    }
}
