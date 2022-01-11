using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace Repairs
{
    public partial class myfrmPTO : Form
    {
        private string user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det,tek_mes,tek_god;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        DAL_DBF dal_dbf = new DAL_DBF();

        public myfrmPTO(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet,
            string tekmes,string tekgod)
        {
            user_n = usern;
            user_p = userp;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig;
            cod_det = coddet;
            tek_mes = tekmes;
            tek_god = tekgod;
            InitializeComponent();
            //dgv_m_kart.DataSource = AllTMC;
            //if (dgv_m_kart.RowCount > 0){

            //    SettingsM_kart();
            //}

            cmb_reportBoy.DataSource = dal_dbf.GetAllReportBoy();
            cmb_reportBoy.DisplayMember = "fulname";
            cmb_reportBoy.ValueMember = "fulcode";
        }

        private void pTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void vedomostResursovBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cmb_reportBoy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myfrmPTO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vedomostResursov.PTO' table. You can move, or remove it, as needed.
            //  this.pTOTableAdapter.Fill(this.vedomostResursov.PTO,"1");
            DTPbeg.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            this.btn_formuvPTO.Visible = false;
        }


        private void clickShow()  
        {
            ArrayList DanFind = new ArrayList();
            Grid_Viev.DataSource = dal_dbf.GetDanReportBoy(cmb_reportBoy.SelectedValue.ToString());
            string ncodcx, ncoduth, ncodbrig, ncoddet, snamedet, datbeg, datend;
            ncodcx = Grid_Viev.Rows[0].Cells["codcx"].Value.ToString(); // код цеха 
            ncoduth = Grid_Viev.Rows[0].Cells["coduth"].Value.ToString(); // код участка
            ncodbrig = Grid_Viev.Rows[0].Cells["codbrig"].Value.ToString(); // код  бригады
            ncoddet = Grid_Viev.Rows[0].Cells["coddet"].Value.ToString(); // код 
            snamedet = Grid_Viev.Rows[0].Cells["namedet"].Value.ToString();
            datbeg = DTPbeg.Value.ToShortDateString();
            datend = DTPend.Value.ToShortDateString();
            // MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
            
            //28.04.
            try
            {
                this.pTOTableAdapter.Fill(this.vedomostResursov.PTO, ncodcx, ncoduth, ncodbrig, ncoddet, datbeg, datend);
            }
            //28.04.catch
            catch
            { 
            }


            if (gridVedom.RowCount > 0)
            {
                this.btn_formuvPTO.Visible = true;
                for (int i = 0; i < gridVedom.RowCount; i++)
                {
                    gridVedom.Rows[i].Cells["ColumnCheck"].Value = 0;
                }
            }
            else
            {
                this.btn_formuvPTO.Visible = false;
            }
        }

        private void btn_formVedRes_Click(object sender, EventArgs e)
        {
            clickShow();


        }



        private void button2_Click(object sender, EventArgs e) //Помечает все чекбоксы
        {
            for (int i = 0; i < gridVedom.RowCount; i++)
            {
                gridVedom.Rows[i].Cells["ColumnCheck"].Value = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)  //Убирает все Пометки с чекбоксов
        {
            for (int i = 0; i < gridVedom.RowCount; i++)
            {
                gridVedom.Rows[i].Cells["ColumnCheck"].Value = 0;
            }
        }

              
        private void btn_formuvPTO_Click(object sender, EventArgs e)
        {
         

            string theMonth = DTPend.Value.ToString("MM");
            string theYear = DTPend.Value.ToString("yyyy");
            if (tek_mes.ToString() == theMonth.ToString() & tek_god.ToString() == theYear.ToString()) // проверка на рабочий месяц
            {



            // Подсчитываем кол-во отмеченых чекбоксов в гриде в переменную kol 


            int kol;
            kol = 0;
            for (int i = 0; i < gridVedom.RowCount; i++)
            {
                int bb2 = Convert.ToInt32(gridVedom.Rows[i].Cells["ColumnCheck"].Value);
                //MessageBox.Show("bb= " + bb.ToString());
                if (bb2 == 1)
                {
                    kol = kol + 1;
                }
            }


            // если kol>0 то выполняем формирование ПТО.

            if (kol > 0)
            {
                string syear;
                syear = DTPend.Value.Year.ToString();     //syear=год из  DTPend2 
                DAL dal = new DAL();
                Int32 MaxNPTO = dal.MaxZnach(syear); // передаем год в класс DAL чтоб высчитать макс значение     //  MessageBox.Show(MaxNPTO.ToString());
                MaxNPTO = MaxNPTO + 1;
                string DatBeg, DatEnd;
                DatBeg = DTPbeg.Value.ToString("yyyyMMdd");
                DatEnd = DTPend.Value.ToString("yyyyMMdd");

                string ncodcx, ncoduth, ncodbrig, ncoddet, sFIO_MOL, namUser;
                int nOrig;
                ncodcx = gridVedom.Rows[0].Cells["Ispolnitel_codcx"].Value.ToString();
                ncoduth = gridVedom.Rows[0].Cells["Ispolnitel_coduth"].Value.ToString(); // код участка
                ncodbrig = gridVedom.Rows[0].Cells["Ispolnitel_codbrig"].Value.ToString(); // код  бригады
                ncoddet = gridVedom.Rows[0].Cells["Ispolnitel_coddet"].Value.ToString(); // код 
                sFIO_MOL = gridVedom.Rows[0].Cells["Ispolnitel_name"].Value.ToString();
                namUser = Environment.UserName;
                nOrig = 1;
                // textBox1.Text=dal.SaveNewNoPTO2(MaxNPTO.ToString(), DatBeg, DatEnd, ncodcx, ncoduth, ncodbrig, ncoddet, sFIO_MOL, namUser, nOrig); Для просмотра результата в текстбокс

                Debug.WriteLine("jkhjkihououy");

                Debug.WriteLine(DatBeg);
                Debug.WriteLine(DatEnd);
                Debug.WriteLine(ncodcx);
                Debug.WriteLine(ncoduth);
                Debug.WriteLine(ncodbrig);
                Debug.WriteLine(ncoddet);
                Debug.WriteLine(sFIO_MOL);
                Debug.WriteLine(namUser);
                Debug.WriteLine("nOrig");

                Debug.WriteLine("jkhjkihououy");



                if (dal.SaveNewNoPTO(MaxNPTO.ToString(), DatBeg, DatEnd, ncodcx, ncoduth, ncodbrig, ncoddet, sFIO_MOL, namUser, nOrig) == true)
                {

                    Int32 MaxIDPTO = dal.MaxIDPTO(); // запоминаем maxIDPTO из таблицы PTO
                    //int NumberPTO = dal.NumberPTO();
                    //MessageBox.Show("Запис успішно додано до PTO" + MaxNPTO.ToString());
                    int sformPTO;
                    sformPTO = 0;

                    for (int i = 0; i < gridVedom.RowCount; i++)
                    {
                        //int idpto;

                        int bb = Convert.ToInt32(gridVedom.Rows[i].Cells["ColumnCheck"].Value);
                        //MessageBox.Show("bb= " + bb.ToString());
                        if (bb == 1)
                        {
                            int idVedRes;
                            idVedRes = Convert.ToInt32(gridVedom.Rows[i].Cells["ID"].Value);
                            //insert 

                            if (dal.UpdateVedRes_IdPTO(MaxIDPTO, idVedRes) == true)
                            {
                               sformPTO=1;
                                // MessageBox.Show("Сформовано ПТЗ № " + MaxNPTO.ToString());
                                //textBox1.Text = dal.UpdateVedRes_IdPTO2(MaxIDPTO, idVedRes);
                            }
                            else
                            {
                                sformPTO = 0;
                                MessageBox.Show("ПТЗ  не сформовано!");
                                //textBox1.Text = dal.UpdateVedRes_IdPTO2(MaxIDPTO, idVedRes);
                            }


                        }
                        else
                        {
                            //MessageBox.Show("bb= " + bb.ToString());
                        }

                    }

                    if (sformPTO==1)
                    {
                    MessageBox.Show("Сформовано ПТЗ № " + MaxNPTO.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Помилка! Запис не додана!!!");
                }

                //  MessageBox.Show(ddd.ToString("yyyyMMdd") + txt_invNum.Text + cbx_cehIn.SelectedValue.ToString() + cbx_cehTo.SelectedValue.ToString() + Convert.ToInt32(cbx_plan.Checked).ToString());
                // this.Close();
                //SaveNewNoPTO
                // Click.btn_formVedRes_Click;
            }
            else
            {
                MessageBox.Show("НЕ сформовано ПТО! Не вибрані відомості ресурсів !!!");
            }
            clickShow();
        
        }
        else
    {
        MessageBox.Show("Не сформовано! Робочий місяць " + theMonth.ToString()+"-"+theYear.ToString()+"р.");
    }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
      
    
           
    }
}
