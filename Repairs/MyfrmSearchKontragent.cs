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
    public partial class MyfrmSearchKontragent : Form
    {
        DAL_Kontragent dal = new DAL_Kontragent();
        public MyfrmSearchKontragent()
        {
            InitializeComponent();

            dgv_AllKontragent.DataSource = dal.GetAllKontragent();
            if (dgv_AllKontragent.RowCount > 0)
            { 
                SettingsKontrAgent(); 
            }
            else
            {
                MessageBox.Show("У Вас нет Контрагентоа которые могут выполнять ремонт");
                this.Close();
            }

        }

        private void SettingsKontrAgent() {
           // dgv_AllKontragent.Columns[""].Visible = false;

            dgv_AllKontragent.Columns["_Code"].HeaderText = "Код";
            dgv_AllKontragent.Columns["_Description"].HeaderText = "Наименование";
            dgv_AllKontragent.Columns["_Fld1873"].HeaderText = "ЕДРПОУ";

            dgv_AllKontragent.Columns["_Code"].Width = ((dgv_AllKontragent.Width - 50) / 5)-40;
            dgv_AllKontragent.Columns["_Description"].Width = ((dgv_AllKontragent.Width - 50) / 5) * 3 + 50;
            dgv_AllKontragent.Columns["_Fld1873"].Width = ((dgv_AllKontragent.Width - 50) / 5)-20;      
        }

        //Сохранение информации
        private void button1_Click(object sender, EventArgs e)
        {
            KontrAgent.Kod = dgv_AllKontragent.CurrentRow.Cells["_Code"].Value.ToString();
            KontrAgent.Name = dgv_AllKontragent.CurrentRow.Cells["_Description"].Value.ToString();
            KontrAgent.Edrpou = dgv_AllKontragent.CurrentRow.Cells["_Fld1873"].Value.ToString();
            this.Close();
        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchName.Text.Length > 2)
            {
                //dgv_AllTMC.DataSource = dal.GetAllTMC();
                SearchForName();
            }
            else
            {
                dgv_AllKontragent.DataSource = dal.GetAllKontragent();

            }
        }

        private void SearchForName() {
            dgv_AllKontragent.ReadOnly = false;
            for (int i = 0; i < dgv_AllKontragent.RowCount; i++)
            {
                if (dgv_AllKontragent.Rows[i].Cells["_Description"].Value.ToString().ToLowerInvariant().Contains(txt_SearchName.Text) == false)
                {
                    dgv_AllKontragent.CurrentCell = null;
                    dgv_AllKontragent.Rows[i].Visible = false;
                }
            }
        }

        //Поиск по ЕДРПОУ
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length > 2)
            {
                SearchForEDRPOU();
            }
            else
            {
                dgv_AllKontragent.DataSource = dal.GetAllKontragent();
            }
        }


        private void SearchForEDRPOU()
        {
            dgv_AllKontragent.ReadOnly = false;
            for (int i = 0; i < dgv_AllKontragent.RowCount; i++)
            {
                if (dgv_AllKontragent.Rows[i].Cells["_Fld1873"].Value.ToString().ToLowerInvariant().Contains(txt_Search.Text) == false)
                {
                    dgv_AllKontragent.CurrentCell = null;
                    dgv_AllKontragent.Rows[i].Visible = false;
                }
            }
        }

        private void txt_SearchKod_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchKod.Text.Length > 2)
            {
                SearchForKod();
            }
            else
            {
                dgv_AllKontragent.DataSource = dal.GetAllKontragent();
            }
        }


        private void SearchForKod()
        {
            dgv_AllKontragent.ReadOnly = false;
            for (int i = 0; i < dgv_AllKontragent.RowCount; i++)
            {
                if (dgv_AllKontragent.Rows[i].Cells["_Code"].Value.ToString().ToLowerInvariant().Contains(txt_SearchKod.Text) == false)
                {
                    dgv_AllKontragent.CurrentCell = null;
                    dgv_AllKontragent.Rows[i].Visible = false;
                }
            }
        }



    }
}
