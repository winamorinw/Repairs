using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repairs
{
    public partial class myfrmUpdateReplacedPart : Form
    {
        DAL dal = new DAL();

        public myfrmUpdateReplacedPart()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            if (dgv_RepPlace.RowCount > 0)
            {
                for (int i = 0; i < dgv_RepPlace.RowCount; i++)
                {
                    if ((dgv_RepPlace.Rows[i].Cells["Norma1"].Value.ToString().Trim().Length == 1)  == true )
                    {
                        //MessageBox.Show(dgv_RepPlace.Rows[i].Cells["Norma1"].Value.ToString().Trim().Length.ToString());





                        if (dal.UpdateRepPlaceVedResNormaTehNorma(dgv_RepPlace.Rows[i].Cells["ReplacedId"].Value.ToString(),
                            dgv_RepPlace.Rows[i].Cells["Norma1"].Value.ToString().Trim()) == true)
                        {
                          //  MessageBox.Show("всё хорошо");
                        }
                        else
                        {
                            a = a++;
                        }
                    }

                    if ((dgv_RepPlace.Rows[i].Cells["tehno1"].Value.ToString().Trim().Length == 1) == true)
                    {
                        //MessageBox.Show(dgv_RepPlace.Rows[i].Cells["Norma1"].Value.ToString().Trim().Length.ToString());





                        if (dal.UpdateRepPlaceVedResNormaTehnoTehno(dgv_RepPlace.Rows[i].Cells["ReplacedId"].Value.ToString(),
                            dgv_RepPlace.Rows[i].Cells["tehno1"].Value.ToString().Trim()) == true)
                        {
                          //  MessageBox.Show("всё хорошо");
                        }
                        else
                        {
                            a = a++;
                        }
                    }


                    dal.UpdateRepPlaceVedResNormaTehnoDatareplace(dgv_RepPlace.Rows[i].Cells["ReplacedId"].Value.ToString(), dgv_RepPlace.Rows[i].Cells["datareplace1"].Value.ToString().Trim());

                    //*************
                    if ((dgv_RepPlace.Rows[i].Cells["datareplace1"].Value.ToString().Trim().Length >0) == true)
                    {
                        //MessageBox.Show(dgv_RepPlace.Rows[i].Cells["Norma1"].Value.ToString().Trim().Length.ToString());

                        if (dal.UpdateRepPlaceVedResNormaTehnoDatareplace(dgv_RepPlace.Rows[i].Cells["ReplacedId"].Value.ToString(),
                            dgv_RepPlace.Rows[i].Cells["datareplace1"].Value.ToString().Trim()) == true)
                        {
                            //  MessageBox.Show("всё хорошо");
                        }
                        else
                        {
                            a = a++;
                        }
                    }
                    //*******************



                }
                if (a > 0)
                {
                    MessageBox.Show("Не вся информация внесена. Повторите действие!");
                }
                else
                {
                    this.Close();                
                } 
            }
            else
            {
                MessageBox.Show("Сохранять нечего");
            }
        }

        private void myfrmUpdateReplacedPart_Load(object sender, EventArgs e)
        {
            dgv_RepPlace.DataSource = dal.GetRepPlaceForVedRes(Vedomost.Id);
            dgv_RepPlace.ReadOnly = false;
            dgv_RepPlace.Columns.Add("tehno1", "Тех");
            dgv_RepPlace.Columns.Add("norma1", "Нор");
            
            dgv_RepPlace.Columns.Add("DataReplace1", "Дата.уст.запчастини");

          //  dgv_RepPlace.Columns["norma1"].ReadOnly = false;
            if (dgv_RepPlace.RowCount > 0)
            {
                for (int i = 0; i < dgv_RepPlace.RowCount; i++)
                {

                    dgv_RepPlace.Rows[i].Cells["tehno1"].ReadOnly = false;
                    dgv_RepPlace.Rows[i].Cells["tehno1"].Value = dgv_RepPlace.Rows[i].Cells["tehno"].Value;

                    dgv_RepPlace.Rows[i].Cells["norma1"].ReadOnly = false;
                    dgv_RepPlace.Rows[i].Cells["norma1"].Value = dgv_RepPlace.Rows[i].Cells["norma"].Value;


                    dgv_RepPlace.Rows[i].Cells["DataReplace1"].ReadOnly = true;
                    dgv_RepPlace.Rows[i].Cells["DataReplace1"].Value = dgv_RepPlace.Rows[i].Cells["DataReplace"].Value;

                    //string query = string.Format(@"update [Repairs].[dbo].[ReplacedPart]  set DataReplace = '{0}', DataToday='{1}'  where ReplacedId = '{2}'", dateRep, datToday, IDReplacePart);



                    // dgv_RepPlace.Rows[i].Cells["norma"]
                }





                // dgv_RepPlace.Columns["tehno"].ReadOnly = false;
                //dgv_RepPlace.Columns["norma"].ReadOnly = false;
                SettingsUpdateRep();
            }
        }

        private void SettingsUpdateRep()
        {
            if (dgv_RepPlace.RowCount > 0)
            {
                dgv_RepPlace.Columns["ReplacedID"].Visible = false;
                dgv_RepPlace.Columns["JobID"].Visible = false;
                dgv_RepPlace.Columns["PartID"].Visible = false;
                dgv_RepPlace.Columns["vedomostnumber"].Visible = false;
                dgv_RepPlace.Columns["RepairID"].Visible = false;
                dgv_RepPlace.Columns["dateinrep"].Visible = false;
                dgv_RepPlace.Columns["User_kol"].Visible = false;
                dgv_RepPlace.Columns["datatoday"].Visible = false;
                dgv_RepPlace.Columns["original"].Visible = false;
                dgv_RepPlace.Columns["tehno"].Visible = false;
                dgv_RepPlace.Columns["norma"].Visible = false;
                dgv_RepPlace.Columns["shpz"].Visible = false;
                dgv_RepPlace.Columns["datareplace"].Visible = false;
                

                dgv_RepPlace.Columns["Name"].Width = 300;
                dgv_RepPlace.Columns["EDNOME"].Width = 65;
                dgv_RepPlace.Columns["mera"].Width = 45;
                dgv_RepPlace.Columns["tehno1"].Width = 42;
                dgv_RepPlace.Columns["norma1"].Width = 42;
                dgv_RepPlace.Columns["datareplace"].Width = 200;

                dgv_RepPlace.Columns["EDNOME"].HeaderText = "Номер";
               // dgv_RepPlace.Columns["DATA"].HeaderText = "Дата поступления";
                dgv_RepPlace.Columns["NAME"].HeaderText = "Название";
                dgv_RepPlace.Columns["MERA"].HeaderText = "Ед. изм.";
                dgv_RepPlace.Columns["PRACE"].HeaderText = "Цена";
                dgv_RepPlace.Columns["quantity"].HeaderText = "Кол-во";
                dgv_RepPlace.Columns["datareplace"].HeaderText = "Дата уст";

                dgv_RepPlace.Columns["EDNOME"].DisplayIndex = 0;
                dgv_RepPlace.Columns["NAME"].DisplayIndex = 1;
              //  dgv_RepPlace.Columns["DATA"].DisplayIndex = 2;
                dgv_RepPlace.Columns["quantity"].DisplayIndex = 3;
                dgv_RepPlace.Columns["MERA"].DisplayIndex = 4;
                dgv_RepPlace.Columns["PRACE"].DisplayIndex = 5;
                dgv_RepPlace.Columns["datareplace"].DisplayIndex = 6;


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_RepPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //private void dgv_RepPlace_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{

        //}
    }
}
