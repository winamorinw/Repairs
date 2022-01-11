using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.OleDb;

namespace Repairs
{
    public partial class frm_zakr_mes : Form
    {
        DAL dal = new DAL();
        public frm_zakr_mes(string vib_year)
        {
            InitializeComponent();
            string vibran_year = vib_year;
            this.label2.Text = vibran_year.ToString();

            DAL_DBF daldbf = new DAL_DBF();
            dataGridView2.DataSource = daldbf.GetAllReportBoy();

        }

        private void frm_zakr_mes_Load(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.Fill(this.tabl.DataTable2, Convert.ToInt32(label2.Text));
            string vibr_year;
            vibr_year = this.label2.Text.ToString();
            //SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=True;");
            SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;Integrated Security=False;User ID=sa;Password=sql1112;Pooling=True"); 
            try
            {
               // cn.Open();
                /*
                SqlCommand s = new SqlCommand("SELECT  Status_mes_ceh.StoreId, Store.StoreName, Status_mes_ceh.st_mes1, Status_mes_ceh.st_mes2, Status_mes_ceh.st_mes3, Status_mes_ceh.st_mes4, 
                         Status_mes_ceh.st_mes5, Status_mes_ceh.st_mes6, Status_mes_ceh.st_mes7, Status_mes_ceh.st_mes8, Status_mes_ceh.st_mes9, Status_mes_ceh.st_mes10, 
                         Status_mes_ceh.st_mes11, Status_mes_ceh.st_mes12
FROM            Status_mes_ceh INNER JOIN
                         Store ON Status_mes_ceh.StoreId = Store.StoreID where god=" + vibr_year.ToString(), cn);
                SqlDataReader dr = s.ExecuteReader();
               
                if (dr.HasRows)
                {
                    


                }
                else
                {
                    MessageBox.Show("No info");
                }*/
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString()+dataGridView1.CurrentRow.Cells[2].Value.ToString()+ dataGridView1.CurrentRow.Cells[3].Value.ToString()+dataGridView1.CurrentRow.Cells[1].Value.ToString());

            // cn.Open();
            /*
          //Debug.WriteLine(dataGridView2.Rows[0].Cells[13].Value);
          foreach (DataGridViewRow r in dataGridView1.Rows)
          {
              int a1 = 0;
              int a2 = 0;
              int a3 = 0;
              int a4 = 0;
              int a5 = 0;
              int a6 = 0;
              int a7 = 0;
              int a8 = 0;
              int a9 = 0;
              int a10 = 0;
              int a11 = 0;
              int a12 = 0;
              int tekmes = 0;
              int storeid = 0;
              foreach(DataGridViewCell r2 in r.Cells)
              {
                  if (r2.ColumnIndex == 0)
                  {
                      storeid = Convert.ToInt32(r2.Value);
                  }
                  if (r2.ColumnIndex != 0 && r2.ColumnIndex != 1)
                  {
                      if (r2.ColumnIndex == 2) { if (Convert.ToString(r2.Value) == "True") { a1 = 1; } }
                      if (r2.ColumnIndex == 3) { if (Convert.ToString(r2.Value) == "True") { a2 = 1; } }
                      if (r2.ColumnIndex == 4) { if (Convert.ToString(r2.Value) == "True") { a3 = 1; } }
                      if (r2.ColumnIndex == 5) { if (Convert.ToString(r2.Value) == "True") { a4 = 1; } }
                      if (r2.ColumnIndex == 6) { if (Convert.ToString(r2.Value) == "True") { a5 = 1; } }
                      if (r2.ColumnIndex == 7) { if (Convert.ToString(r2.Value) == "True") { a6 = 1; } }
                      if (r2.ColumnIndex == 8) { if (Convert.ToString(r2.Value) == "True") { a7 = 1; } }
                      if (r2.ColumnIndex == 9) { if (Convert.ToString(r2.Value) == "True") { a8 = 1; } }
                      if (r2.ColumnIndex == 10) { if (Convert.ToString(r2.Value) == "True") { a9 = 1; } }
                      if (r2.ColumnIndex == 11) { if (Convert.ToString(r2.Value) == "True") { a10 = 1; } }
                      if (r2.ColumnIndex == 12) { if (Convert.ToString(r2.Value) == "True") { a11 = 1; } }
                      if (r2.ColumnIndex == 13) { if (Convert.ToString(r2.Value) == "True") { a12 = 1; } }
                  }
              }
              
              if (a1 == 0) { tekmes = 1; } else if (a2 == 0) { tekmes = 2; } else if (a3 == 0) { tekmes = 3; } else if (a4 == 0) { tekmes = 4; } else if (a5 == 0) { tekmes = 5; } else if (a6 == 0) { tekmes = 6; } else if (a7 == 0) { tekmes = 7; } else if (a8 == 0) { tekmes = 8; } else if (a9 == 0) { tekmes = 9; } else if (a10 == 0) { tekmes = 10; } else if (a11 == 0) { tekmes = 11; } else if (a12 == 0) { tekmes = 12; } else tekmes = 0;
              SqlCommand cm1 = new SqlCommand("UPDATE [Repairs].[dbo].[Status_mes_ceh] SET tek_mes = " + tekmes + ", st_mes1 = " + a1 + ", st_mes2 = " + a2 + ",st_mes3 = " + a3 + ",st_mes4 = " + a4 + ",st_mes5 = " + a5 + ",st_mes6 = " + a6 + ",st_mes7 = " + a7 + ",st_mes8 = " + a8 + ",st_mes9 = " + a9 + ",st_mes10 = " + a10 + ",st_mes11 = " + a11 + ",st_mes12 = " + a12 + " where StoreId = " + storeid, cn);
              cm1.ExecuteNonQuery();
             * */
          
          //cn.Close();
        }
        SqlConnection cn = new SqlConnection("Data Source=UAESB-SQL-02;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True");

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        
            //Debug.WriteLine("11");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //Debug.WriteLine(e.RowIndex);
            //int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //int god = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            //int tekmes = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
            int tekceh = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int god = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int tekmes = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);


            int newmes = 0;
            int newgod = 0;

            if (tekmes == 12)
            {
                newmes = 1;
                newgod = god + 1;
            }
            else
            {
                newmes = tekmes + 1;
                newgod = god;
            }

            int a=Convert.ToInt32(dataGridView1.CurrentRow.Index);


            int allDayMonth = DateTime.DaysInMonth(god, tekmes);
            DateTime LastDatOfMonth = new DateTime(god, tekmes, allDayMonth);
            DateTime firstDayOfMonth = new DateTime(god, tekmes, 1);

           
            ////---------------------------------------
            //cn.Open();
            //// Будем идти по ведомостям ресурсов и проверять ОС, не списано ли оно или на консервации , или віведено из єксплуатации
            //SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT distinct vr.InventoryNamber ,vr.Obekt from Vedomost_Resursov vr WHERE vr.Ispolnitel_codcx =" + tekceh.ToString() + " and  (cast (vr.PeriodData2 as date ) between cast ('" + firstDayOfMonth + "' as date) and cast('" + LastDatOfMonth + "' as date))"+
            //                   " union SELECT distinct au.Inv_usl as InventoryNamber,au.Obekt_usl as Obekt  from Akti_Usl  au WHERE au.Ispolnitel_codcx =" + tekceh.ToString() + " and  (cast (au.PeriodData2 as date ) between cast ('" + firstDayOfMonth + "' as date) and cast('" + LastDatOfMonth + "' as date))", cn); 
            //DataTable tab = new DataTable();
            //sqlDA.Fill(tab);
            //string StrMessage = "Внимание!!!\nСледующие ОС уже списаны или на консервации, или выведены из эксплуатации:";
            //string StrMessage2 = "";
            //if (tab.Rows.Count == 0)
            //{ }
            //else
            //{
            //    int i = 0;
            //    foreach (DataRow row in tab.Rows)
            //    {
            //        string inv = tab.Rows[i][0].ToString();
            //        string ob_inv = tab.Rows[i][1].ToString();

                    
            //        //  проверку на списано ли ОС,  доступ на f:\slovary\okrt.dbf
            //        //  MessageBox.Show("Проверить ОС");
            //        int KolNeSpisOS = 99;
            //        DAL_DBF DAL_DBF = new DAL_DBF();
            //        KolNeSpisOS = Convert.ToInt32(DAL_DBF.ReturnKolNotSpisOS(inv.ToString(), ob_inv.ToString()));


            //        if (KolNeSpisOS == 1)
            //        {
            //            // MessageBox.Show("Не списано");
            //        }
            //        else
            //        {
            //            StrMessage2=StrMessage2+"\n                   інв. "+inv.ToString()+"/"+ob_inv.ToString();
            //        }
            //        i = i + 1;
            //    }


            //    cn.Close();
    
               
            //    StrMessage = StrMessage + StrMessage2;
            //    if (StrMessage2.Length == 0) // если есть списанніе ОС
            //    {}
            //    else
            //    {
            //        MessageBox.Show(StrMessage);
            //        //MessageBox.Show("Месяц не будет закрыт.\n" + StrMessage);
            //        //return;
            //    }

            //}

            ////---------------------------------------






           
            //---------------------------------------
            cn.Open();
            // Будем идти по ведомостям ресурсов и по актам-услуги  проверять ОС, не списано ли оно или на консервации , или віведено из єксплуатации
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT distinct vr.InventoryNamber ,vr.Obekt from Vedomost_Resursov vr WHERE vr.Ispolnitel_codcx =" + tekceh.ToString() + " and  (cast (vr.PeriodData2 as date ) between cast ('" + firstDayOfMonth + "' as date) and cast('" + LastDatOfMonth + "' as date))"+
                               " union SELECT distinct au.Inv_usl as InventoryNamber,au.Obekt_usl as Obekt  from Akti_Usl  au WHERE au.Ispolnitel_codcx =" + tekceh.ToString() + " and  (cast (au.PeriodData2 as date ) between cast ('" + firstDayOfMonth + "' as date) and cast('" + LastDatOfMonth + "' as date)) and au.Inv_usl <>0", cn); 
            DataTable tab = new DataTable();
            sqlDA.Fill(tab);
            string StrMessage = "Внимание!!!\nСледующие ОС уже списаны или на консервации, или выведены из эксплуатации:";
            string StrMessage2 = "";
            if (tab.Rows.Count == 0)
            { }
            else
            {
                int i = 0;
                foreach (DataRow row in tab.Rows)
                {
                    string inv = tab.Rows[i][0].ToString();
                    string ob_inv = tab.Rows[i][1].ToString();
                    int int_ob_inv;
                    if (String.IsNullOrEmpty(ob_inv))
                    {
                        int_ob_inv = 0;
                    }
                    else
                    {
                        int_ob_inv = Convert.ToInt32(ob_inv);
                    }
                    
                    //  проверку на списано ли ОС,  доступ на f:\slovary\okrt.dbf
                    //  MessageBox.Show("Проверить ОС");

                    DataTable YourResultSet = new DataTable();
                    OleDbConnection yourConnectionHandler = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=\\uaesb-fs-001\sys\SLOVARY\");
                    yourConnectionHandler.Open();
                    try
                    {

                        if (yourConnectionHandler.State == ConnectionState.Open)
                        {
                            string mySQL = @"";
                            if (inv.EndsWith("М") || inv.EndsWith("M"))
                            {
                                mySQL = @" SELECT count(inven) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\spis_mal.dbf ok WHERE ok.inven=" + inv.Substring(0,inv.Length-1)+""; //23.12.2019
                            }
                            else
                            {
                                if (int_ob_inv == 0)
                                {
                                    //mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949400') and (LEFT(ok.kod_ztr,6)!='949410')  and (ok.obekt=0 OR isnull(ok.obekt)) AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))"; 23.12.2019
                                    mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949410')  and (ok.obekt=0 OR isnull(ok.obekt)) AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))"; //23.12.2019
                                }
                                else
                                {
                                    //mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949400') and (LEFT(ok.kod_ztr,6)!='949410')  and ok.obekt=" + ob_inv + " AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))";  //23.12.2019
                                    mySQL = @" SELECT count(invnum) as kol  FROM \\uaesb-fs-001\sys\SLOVARY\okrt.dbf ok WHERE ok.invnum=" + inv + " and (LEFT(ok.kod_ztr,6)!='949410')  and ok.obekt=" + ob_inv + " AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))"; //23.12.2019
                                }
                            }
                            

                            OleDbCommand MyQuery = new OleDbCommand(mySQL, yourConnectionHandler);
                            OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);

                            DA.Fill(YourResultSet);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        cn.Close();
                        System.Environment.Exit(0);
                    }
                    yourConnectionHandler.Close();
                    int kkol = Convert.ToInt32(YourResultSet.Rows[0][0]);

                    if (kkol == 0 )
                    {
                        StrMessage2 = StrMessage2 + "\n                   інв. " + inv.ToString() + "/" + ob_inv.ToString();
                        
                    }
                    else
                    {
                        // MessageBox.Show("Можно");
                    }
                    i = i + 1;
                }
                cn.Close();
    
               
                StrMessage = StrMessage + StrMessage2;
                if (StrMessage2.Length == 0) // если есть списанніе ОС или на консерв, или віведені из єкспл.
                {}
                else
                {
                    MessageBox.Show(StrMessage);
                    //MessageBox.Show("Месяц не будет закрыт.\n" + StrMessage);
                    //return;
                }

            }
            //---------------------------------------
            cn.Close();
            cn.Open();
            // Подсчитываем не списанные материалы, если они есть, то закрытие месяца не производится
            SqlCommand cm2 = new SqlCommand("SELECT  count(rr.InventoryNumber) from ReplacedPart rp	left join  Repair rr on rp.RepairID=rr.RepairID  WHERE (Original = 0 or Original = 1 )  and rr.RDivision='" + tekceh.ToString() + "' and  (rr.DateIn <= '" + LastDatOfMonth + "'  OR rr.DateOut <='" + LastDatOfMonth + "')", cn);
            object count = cm2.ExecuteScalar();
            cn.Close();
            if (Convert.ToInt32(count) > 0)
            {
                MessageBox.Show("Нельзя закрыть месяц. Есть несписанные материалы.");
                myfrm_ne_spisano myfrm_ne_spisano = new myfrm_ne_spisano(tekceh,LastDatOfMonth);
                myfrm_ne_spisano.ShowDialog();

            }
            else
            {
                cn.Open();
                SqlCommand cm1 = new SqlCommand("UPDATE [Repairs].[dbo].[Status_mes_ceh] SET mes = " + newmes + ",god = " + newgod + " where StoreId = " + tekceh, cn);
                Debug.WriteLine(cm1.CommandText);
                cm1.ExecuteNonQuery();

                if (cm1.ExecuteNonQuery() >= 1) // если віполнилось update 
                {
                    // uspeh

                    SqlCommand cmd1 = new SqlCommand("update [Repairs].[dbo].[Status_mes_mol]  set blocked = '' where cod_cx='" + tekceh+"'", cn);
                    // Update

                    if (cmd1.ExecuteNonQuery() >= 1)
                    {
                        //                         MessageBox.Show("Запис вдало змінено");
                    }
                    else
                    {
                        MessageBox.Show("Помилка! Оновлення закінчилося невдачею :-(");
                    }

                }
                else
                {
                    MessageBox.Show("Помилка закриття місяцю! Оновлення закінчилося невдачею :-(");
                }
                cn.Close();
                this.dataTable2TableAdapter.Fill(this.tabl.DataTable2, Convert.ToInt32(label2.Text));
                if (tekmes == 12) { } else { dataGridView1.Rows[a].Selected = true; }
            }
            
         
        }




        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int god = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int tekmes = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            int tekceh = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            int newmes = 0;
            int newgod = 0;

            if (tekmes == 1)
            {
                newmes = 12;
                newgod = god - 1;
            }
            else
            {
                newmes = tekmes - 1;
                newgod = god;
            }
            int a = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            cn.Open();
            SqlCommand cm2 = new SqlCommand("UPDATE [Repairs].[dbo].[Status_mes_ceh] SET mes = " + newmes + ",god = " + newgod + " where StoreId = " + id, cn);
            Debug.WriteLine(cm2.CommandText);
            cm2.ExecuteNonQuery();



            if (cm2.ExecuteNonQuery() >= 1) // если віполнилось update 
            {
                // uspeh

                SqlCommand cmd1 = new SqlCommand("update [Repairs].[dbo].[Status_mes_mol]  set blocked = '' where cod_cx='" + tekceh + "'", cn);
                // Update

                if (cmd1.ExecuteNonQuery() >= 1)
                {
                    //                         MessageBox.Show("Запис вдало змінено");
                }
                else
                {
                    MessageBox.Show("Помилка! Оновлення закінчилося невдачею :-(");
                }

            }
            else
            {
                MessageBox.Show("Помилка закриття місяцю! Оновлення закінчилося невдачею :-(");
            }




            cn.Close();
            this.dataTable2TableAdapter.Fill(this.tabl.DataTable2, Convert.ToInt32(label2.Text));
            if (tekmes == 1) { } else { dataGridView1.Rows[a].Selected = true; }
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            Settings_grid1();
        }

        private void Settings_grid1()
        {
            int tekceh = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            dgvMol.DataSource = dal.GetAll_Status_MOl(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (dgvMol.RowCount > 0)
            {
                dgvMol.Visible = true;
                Settings_dgvMol();
            }
            else
            {
                dgvMol.Visible = false;
            }


        }
        //Настройка выполненых ремонтов
        private void Settings_dgvMol()
        {
            
            dgvMol.Columns["Id"].Visible = true;
            dgvMol.Columns["cod_cx"].Visible = true;
            dgvMol.Columns["cod_uth"].Visible = true;
            dgvMol.Columns["cod_brig"].Visible = true;
            dgvMol.Columns["cod_det"].Visible = true;
            dgvMol.Columns["name_mol"].Visible = true;
            dgvMol.Columns["blocked"].Visible = true;

            dgvMol.Columns["Id"].HeaderText = "ID";
            dgvMol.Columns["cod_cx"].HeaderText = "Цех";
            dgvMol.Columns["cod_uth"].HeaderText = "Діл.";
            dgvMol.Columns["cod_brig"].HeaderText = "Бр.";
            dgvMol.Columns["cod_det"].HeaderText = "Підзв.";
            dgvMol.Columns["name_mol"].HeaderText = "МВО";
            dgvMol.Columns["blocked"].HeaderText = "Забо- ронити";

            dgvMol.Columns["Id"].Width = 0;
            dgvMol.Columns["cod_cx"].Width = 30;
            dgvMol.Columns["cod_uth"].Width = 30;
            dgvMol.Columns["cod_brig"].Width = 30;
            dgvMol.Columns["cod_det"].Width = 30;
            dgvMol.Columns["name_mol"].Width = 270;
            dgvMol.Columns["blocked"].Width = 45;
             
            for (int i = 0; i < dgvMol.RowCount; i++)
             dgvMol.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                

            

        }



      
        
            
          private void dostup_block()
          {
            string nid = dgvMol.CurrentRow.Cells["Id"].Value.ToString();
            string ncod_cx = dgvMol.CurrentRow.Cells["cod_cx"].Value.ToString();
            string cblocked = dgvMol.CurrentRow.Cells["blocked"].Value.ToString();

            if (Dostup.Codcx == ncod_cx || Dostup.Codcx=="0")
            {
                
                string stat_string ;

                if (cblocked=="так")
                 {
                     stat_string = " ";
                 }
                 else
                 {
                     stat_string = "так";
                 }


                //MessageBox.Show(nid);
                if (dal.Update_Status_Mol(stat_string, nid) == true)
                {
                    Settings_grid1();
                }

            }
            else
            { 
               MessageBox.Show("У вас доступ тільки до цеха № "+Dostup.Codcx);
            }


        }

        private void dgvMol_DoubleClick(object sender, EventArgs e)
        {
            //button4.PerformClick();
        }

        private void dgvMol_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //button4.PerformClick();
            dostup_block();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DAL_DBF daldbf = new DAL_DBF();
            //dataGridView2.DataSource = daldbf.GetAllReportBoy();

            

            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                //foreach( row in dataGridView2)
                    

                {
                    
                    string codcex = dataGridView2.Rows[i].Cells["codcx"].Value.ToString();
                    string coduth = dataGridView2.Rows[i].Cells["coduth"].Value.ToString();
                    string codbrig = dataGridView2.Rows[i].Cells["codbrig"].Value.ToString();
                    string coddet = dataGridView2.Rows[i].Cells["coddet"].Value.ToString();
                    string namedet = dataGridView2.Rows[i].Cells["namedet"].Value.ToString().Replace("'","`");
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select count(cod_cx) from [Repairs].[dbo].[Status_mes_mol] where cod_cx='" + codcex + "' and cod_uth ='" + coduth + "' and cod_brig='" + codbrig + "' and cod_det='" + coddet + "'", cn);
                    int kol = Convert.ToInt32(cmd.ExecuteScalar());
                    if (kol > 0)
                    {
                        SqlCommand cmd1 = new SqlCommand("update [Repairs].[dbo].[Status_mes_mol]  set name_mol = '" + namedet + "' where cod_cx='" + codcex + "' and cod_uth ='" + coduth + "' and cod_brig='" + codbrig + "' and cod_det='" + coddet + "'", cn);
                        // Update

                        if (cmd1.ExecuteNonQuery() >= 1)
                        {
                            //                         MessageBox.Show("Запис вдало змінено");
                        }
                        else
                        {
                            MessageBox.Show("Помилка! Оновлення закінчилося невдачею :-(");
                        }




                    }
                    else
                    {
                        //insert
                        SqlCommand cmd3 = new SqlCommand("insert into [Repairs].[dbo].[Status_mes_mol] (cod_cx,cod_uth,cod_brig,cod_det,name_mol) values('" + codcex + "','" + coduth + "','" + codbrig +"','" + coddet + "','" + namedet + "')", cn);
                        if (cmd3.ExecuteNonQuery() >= 1)
                        {
                            //                         MessageBox.Show("Запис вдало змінено");
                        }
                        else
                        {
                            MessageBox.Show("Помилка! Додавання закінчилося невдачею :-(");
                        }

                    }

                    cn.Close();
                }
            }

            catch ( Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            //cn.Open();
                //SqlCommand cm2 = new SqlCommand("UPDATE [Repairs].[dbo].[Status_mes_ceh] SET mes = " + newmes + ",god = " + newgod + " where StoreId = " + id, cn);
                //Debug.WriteLine(cm2.CommandText);
                //cm2.ExecuteNonQuery();


                //Console.WriteLine(i);



        }


    }
   
}
