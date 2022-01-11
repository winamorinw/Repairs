using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Repairs
{
    public partial class formUsersListManager : Form
    {
        string connectionString1 = @"Data Source=UAESB-SQL-01;Initial Catalog=SlujZap;User ID=sa;Password=sql1112;MultipleActiveResultSets=True";
        string connectionString2 = @"Data Source=UAESB-SQL-01;Initial Catalog=Repairs;User ID=sa;Password=sql1112;MultipleActiveResultSets=True";
        public formUsersListManager()
        {
            InitializeComponent();
            comboBox1.DataSource = GetAllAdUsers();
            comboBox1.DisplayMember = "Ім'я";
            comboBox1.ValueMember = "Логін";
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public DataTable GetAllAdUsers()
        {
            DataTable table = new DataTable();
            string sql = "SELECT Name as [Ім'я], Domain as [Логін] FROM testad where Name like N'[А-Я]%[А-Я]' ORDER BY Name";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString1);
            adapter.Fill(table);
            //MessageBox.Show(table.Rows.Count.ToString());
            return table;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                var row = (comboBox1.SelectedItem as DataRowView).Row;
                string sql = $"Select COUNT(*) From Users_list where login_user = '{row.ItemArray[1]}'";
                using (SqlConnection connection = new SqlConnection(connectionString2))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    if (command.ExecuteScalar().ToString() == "0")
                    {
                        sql = $"INSERT INTO Users_list VALUES(@login, @name, @ceh, 4, 4, @ceh, @uch, @brig, 0, NULL, NULL, NULL, NULL)";
                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@login", row.ItemArray[1].ToString());
                        command.Parameters.AddWithValue("@name", row.ItemArray[0].ToString());
                        command.Parameters.AddWithValue("@ceh", (int)numericUpDown1.Value);
                        command.Parameters.AddWithValue("@uch", (int)numericUpDown2.Value);
                        command.Parameters.AddWithValue("@brig", (int)numericUpDown3.Value);
                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("Пользователь успешно добавлен!");
                        }
                        else
                        {
                            MessageBox.Show("По каким-то причинам пользователя не удалось добавить. Зовите программиста!");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Данный пользователь уже добавлен в ремонтах.");
                        DialogResult res = MessageBox.Show(
                            $"{row.ItemArray[0]} уже добавлен в ремонтах. Хотите заменить его цех, участок и бригаду на {numericUpDown1.Value}.{numericUpDown2.Value}.{numericUpDown3.Value}?",
                            "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            string query = $"UPDATE Users_list SET plot = {numericUpDown1.Value}, codcx = {numericUpDown1.Value}, coduth = {numericUpDown2.Value}, codbrig = {numericUpDown3.Value} WHERE login_user = '{row.ItemArray[1]}'";
                            command = new SqlCommand(query, connection);
                            if (command.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Данные успешно обновлены.");
                            }
                            else
                            {
                                MessageBox.Show("По каким-то причинам пользователя не удалось добавить. Зовите программиста!");
                            }
                        }

                    }
                    connection.Close();
                }
            }
            /*
            if(dataGridView1.SelectedRows.Count == 1)
            {
                string sql = $"Select COUNT(*) From Users_list where login_user = '{dataGridView1.SelectedRows[0].Cells[1].Value}'";
                using (SqlConnection connection = new SqlConnection(connectionString2))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    if (command.ExecuteScalar().ToString() == "0")
                    {
                        sql = $"INSERT INTO Users_list VALUES(@login, @name, @ceh, 4, 4, @ceh, @uch, @brig, 0, NULL, NULL, NULL, NULL)";
                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@login", dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                        command.Parameters.AddWithValue("@name", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@ceh", (int)numericUpDown1.Value);
                        command.Parameters.AddWithValue("@uch", (int)numericUpDown2.Value);
                        command.Parameters.AddWithValue("@brig", (int)numericUpDown3.Value);
                        int result = command.ExecuteNonQuery();
                        if( result == 1)
                        {
                            MessageBox.Show("Пользователь успешно добавлен!");
                        }
                        else
                        {
                            MessageBox.Show("По каким-то причинам пользователя не удалось добавить. Зовите программиста!");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Данный пользователь уже добавлен в ремонтах.");
                        DialogResult res = MessageBox.Show(
                            $"{dataGridView1.SelectedRows[0].Cells[0].Value} уже добавлен в ремонтах. Хотите заменить его цех, участок и бригаду на {numericUpDown1.Value}.{numericUpDown2.Value}.{numericUpDown3.Value}?", 
                            "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if(res == DialogResult.OK)
                        {
                            string query = $"UPDATE Users_list SET plot = {numericUpDown1.Value}, codcx = {numericUpDown1.Value}, coduth = {numericUpDown2.Value}, codbrig = {numericUpDown3.Value} WHERE login_user = '{dataGridView1.SelectedRows[0].Cells[1].Value}'";
                            command = new SqlCommand(query, connection);
                            if(command.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Данные успешно обновлены.");
                            }
                            else
                            {
                                MessageBox.Show("По каким-то причинам пользователя не удалось добавить. Зовите программиста!");
                            }
                        }
                        
                    }
                    connection.Close();
                }
            }
            */
        }
        
    }
}
