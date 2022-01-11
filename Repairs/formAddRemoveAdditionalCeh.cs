using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repairs
{
    public partial class formAddRemoveAdditionalCeh : Form
    {
        public formAddRemoveAdditionalCeh()
        {
            InitializeComponent();
            dal = new DAL();
            dataGridView1.DataSource = dal.GetUsers();
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.CellClick += DataGridView1_CellClick;
            //dataGridView2.DataSource = dal.GetAdditionalCeh(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            UpdateDataGridView2();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDataGridView2();
        }
        private void UpdateDataGridView2()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var login = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var result = dal.GetAdditionalCeh(login);
                if (result.Count > 0)
                {
                    dataGridView2.DataSource = result;
                    dataGridView2.Columns[0].Width = 50;
                    dataGridView2.Columns[1].Width = 50;
                    dataGridView2.Columns[2].Width = 50;
                }
                else
                {
                    dataGridView2.DataSource = new ArrayList();
                }
            }
        }

        DAL dal;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var form = new formAddAdditionalCeh();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var login = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    dal.AddAdditionalCeh(login, form.cex, form.uch, form.brig);
                    UpdateDataGridView2();
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && dataGridView2.SelectedRows.Count == 1)
            {
                var login = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var cdx = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                var uth = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                var brig = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                dal.RemoveAdditionalCeh(login, cdx, uth, brig);
                UpdateDataGridView2();
            }
        }

        
    }
}
