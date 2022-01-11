using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

//Repairs for original base
namespace Repairs
{
    public partial class frmTypeMetallManager : Form
    {
        public frmTypeMetallManager()
        {
            InitializeComponent();
        }
        public string constr = Properties.Settings.Default.RepairOSConnStr;
        
        private void frmTypeMetallManager_Load(object sender, EventArgs e)
        {
            updateDataGridViewENC();
            updateDataGridViewTypeMetall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var result = Execute("SELECT TOP(1) * FROM TypeMetall WHERE EdNumber = '" + dataGridView1.CurrentRow.Cells["Ednome"].Value.ToString() + "'", "read").Count;
                if(result > 0)
                {
                    MessageBox.Show("Даний металобрухт вже існує у довіднику!");
                }
                else
                {
                    string edFirstLetter = dataGridView1.CurrentRow.Cells["Edmera"].Value.ToString().Substring(0,1);
                    string query = $"SELECT TOP(1) ID FROM EdIzm WHERE Name LIKE '{edFirstLetter }%'";
                    var edIzmId = Execute(query, "scal")[0];
                    var ednumber = dataGridView1.CurrentRow.Cells["Ednome"].Value;
                    var name = dataGridView1.CurrentRow.Cells["Edname"].Value;
                    var edizm = dataGridView1.CurrentRow.Cells["Edmera"].Value;
                    query = $"INSERT INTO TypeMetall VALUES ('{ednumber}', '{name}', '{edizm}', {edIzmId})";
                    Execute(query, "exec");
                    MessageBox.Show($"Запис {ednumber} успішно додано у довідник металобрухту!");
                    updateDataGridViewTypeMetall();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                
                string message = $"Ви точно хочете видалити запис {dataGridView2.CurrentRow.Cells["EdNumber"].Value.ToString()} з довідника металобрухту?";
                string caption = "Увага";
                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM TypeMetall WHERE EdNumber = '{dataGridView2.CurrentRow.Cells["EdNumber"].Value}'";
                    Execute(query, "exec");
                    MessageBox.Show($"Запис {dataGridView2.CurrentRow.Cells["EdNumber"].Value.ToString()} успішно видалено!");
                    updateDataGridViewTypeMetall();
                }
            }
        }
        private void updateDataGridViewTypeMetall()
        {
            string query = "SELECT * FROM TypeMetall ORDER BY EdNumber";
            dataGridView2.DataSource = Execute(query, "read");
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["EdIzmId"].Visible = false;

            /*
            dataGridView2.Columns["EdNumber"].Width = 50;
            dataGridView2.Columns["EdNumber"].HeaderText = "Номен.";
            dataGridView2.Columns["Name"].Width = 250;
            dataGridView2.Columns["Name"].HeaderText = "Назва";
            dataGridView2.Columns["EdIzm"].Width = 80;
            dataGridView2.Columns["EdIzm"].HeaderText = "Од.виміру";
            dataGridView2.Columns["EdIzmId"].Width = 40;
            */
            dataGridView2.Columns["EdNumber"].FillWeight = 50;
            dataGridView2.Columns["EdNumber"].HeaderText = "Номен.";
            dataGridView2.Columns["Name"].FillWeight = 250;
            dataGridView2.Columns["Name"].HeaderText = "Назва";
            dataGridView2.Columns["EdIzm"].FillWeight = 80;
            dataGridView2.Columns["EdIzm"].HeaderText = "Од.виміру";

        }
        private void updateDataGridViewENC()
        {

            ArrayList result = new ArrayList();
            string constr4 = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + "F:\\SLOVARY\\" + ";Exclusive=no; NULL=NO;DELETED=No;BACKGROUNDFETCH=NO;deleted= off;";
            OdbcConnection con2 = new OdbcConnection(constr4);
            string query = string.Format("SELECT ednome, edname, edmera FROM F:\\SLOVARY\\M_EDNOME.dbf where ednome LIKE '22%' and edname NOT LIKE '-%' and (edmera LIKE 'кг' or edmera LIKE 'т' or edmera LIKE 'шт' or edmera LIKE 'гр') ORDER BY ednome");
            OdbcCommand com;
            try
            {
                com = new OdbcCommand(query, con2);
                con2.Open();
                OdbcDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord row in dr)
                    {
                        result.Add(row);
                    }
                }
                con2.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
            dataGridView1.DataSource = result;
            /*
            dataGridView1.Columns["Ednome"].Width = 50;
            dataGridView1.Columns["Ednome"].HeaderText = "Номен.";
            dataGridView1.Columns["Edname"].Width = 250;
            dataGridView1.Columns["Edname"].HeaderText = "Назва";
            dataGridView1.Columns["Edmera"].Width = 80;
            dataGridView1.Columns["Edmera"].HeaderText = "Од.виміру";
            */
            dataGridView1.Columns["Ednome"].FillWeight = 50;
            dataGridView1.Columns["Ednome"].HeaderText = "Номен.";
            dataGridView1.Columns["Edname"].FillWeight = 250;
            dataGridView1.Columns["Edname"].HeaderText = "Назва";
            dataGridView1.Columns["Edmera"].FillWeight = 80;
            dataGridView1.Columns["Edmera"].HeaderText = "Од.виміру";
        }
        public ArrayList Execute(string query, string reader)
        {
            ArrayList result = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (reader == "read")
                    {
                        SqlDataReader dr = com.ExecuteReader();
                        if (dr.HasRows)
                        {
                            foreach (DbDataRecord row in dr)
                            {
                                result.Add(row);
                            }
                        }
                    }
                    else if (reader == "exec")
                        com.ExecuteNonQuery();
                    else if (reader == "scal")
                        result.Add(com.ExecuteScalar().ToString());
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }
    }
}
