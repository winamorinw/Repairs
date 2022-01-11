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

namespace Repairs
{
    public partial class formCurrentMonthSelection : Form
    {
        public formCurrentMonthSelection()
        {
            InitializeComponent();
        }
        public string constr = Properties.Settings.Default.RepairOSConnStr;
        DbDataRecord currentMonth;
        private void formCurrentMonthSelection_Load(object sender, EventArgs e)
        {
            currentMonth = Execute("SELECT * FROM Status_mes WHERE status_mes = 0 and tek_mes = 1", "read")[0] as DbDataRecord;
            label1.Text = $"{currentMonth["mes"]} месяц";
            label2.Text = $"{ currentMonth["god"]} года";
            button2.Select();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ChangeMonth(true);
            label1.Text = $"{currentMonth["mes"]} месяц";
            label2.Text = $"{ currentMonth["god"]} года";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ChangeMonth(false);
            label1.Text = $"{currentMonth["mes"]} месяц";
            label2.Text = $"{ currentMonth["god"]} года";
        }
        private void ChangeMonth(bool prev)
        {
            int month = (int)currentMonth["mes"];
            int year = (int)currentMonth["god"];
            if (prev)
            {
                if (month == 1)
                {
                    month = 12;
                    year--;
                }
                else
                {
                    month--;
                }
            }
            else
            {
                if (month == 12)
                {
                    month = 1;
                    year++;
                }
                else
                {
                    month++;
                }
            }
            var result = Execute($"SELECT * FROM Status_mes WHERE god = {year} and mes = {month}", "read");
            if (result.Count > 0)
            {
                Execute($"UPDATE Status_mes SET status_mes = 1, tek_mes = 0 WHERE id = {currentMonth["id"]}", "exec");
                currentMonth = result[0] as DbDataRecord;
                Execute($"UPDATE Status_mes SET status_mes = 0, tek_mes = 1 WHERE id = {currentMonth["id"]}", "exec");
            }
            else if(!prev)
            {
                Execute($"UPDATE Status_mes SET status_mes = 1, tek_mes = 0 WHERE id = {currentMonth["id"]}", "exec");
                Execute($"INSERT INTO Status_mes VALUES({year}, {month},0,1)", "exec");
                currentMonth = Execute($"SELECT * FROM Status_mes WHERE god = {year} and mes = {month}", "read")[0] as DbDataRecord;
            }
            else
            {
                MessageBox.Show("Предыдущий месяц не существует.");
            }
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
