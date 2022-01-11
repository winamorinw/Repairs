/* Changelog
 * 
 * Настроил табиндексы.
 * Из поля логина в поле пароля переход по Enter.
 * ESC теперь вызывает диалог завершения приложения из любого места формы.
 * Закрытие формы (нажатие на красный крестик) теперь вызывает диалог завершения приложения.
 * Обработка ввода Enter и ESC происходит в одном методе txt_KeyPress.
 * Вынес диалог завершения приложения в статический метод tryToEscape класса frmMain.
 *      public static bool tryToEscape() - Вызывает диалог завершения приложения. В случае отмены пользователем возвращает false.
 * Вывод ошибок sql вместо "неверный пароль" на все ошибки.
 * Перевел на русский язык.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace Repairs
{
    public partial class frmVhod : Form
    {

        Cbxvhod_container array_of_objects = new Cbxvhod_container();
        Cbxvhod cbxVhod = new Cbxvhod();
        private SqlConnectionStringBuilder sbConn;
        public frmVhod()
        {      
            InitializeComponent();
            Cbxvhod_container array_of_objects_new = new Cbxvhod_container();
            array_of_objects_new = array_of_objects_new.Deserialize();
            cbxUser.DataSource = array_of_objects_new;
            cbxUser.DisplayMember = "Name";
        }

        private void frmVhod_Load(object sender, EventArgs e)
        {
            sbConn = new SqlConnectionStringBuilder();
            sbConn.ConnectionString = Repairs.Properties.Settings.Default.RepairOSConnStr;
            this.cbxUser.Text = sbConn.UserID;
        }

        private void Log_in()
        {
            sbConn.PacketSize = 4096;
            sbConn.UserID = cbxUser.Text;
            sbConn.Password = txtPass.Text;
            sbConn.WorkstationID = System.Environment.MachineName;
            sbConn.PersistSecurityInfo = true;
            sbConn.ApplicationName = Application.ProductName;

            using (SqlConnection cnProbe = new SqlConnection(sbConn.ConnectionString))
            {
                try
                {
                    cnProbe.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtPass.Select();
                    return;
                }
            }
            Repairs.Properties.Settings.Default["RepairOSConnStr"] = sbConn.ConnectionString;       
            this.DialogResult = DialogResult.OK;
        }

        private void linkLblVhod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_in();

            if (this.DialogResult == DialogResult.OK)
            //MessageBox.Show(txtUser.Text.ToString());
            {
                Cbxvhod_container array_of_objects_new = new Cbxvhod_container();
                array_of_objects_new = array_of_objects_new.Deserialize();


                Name = cbxUser.Text.ToString();
                array_of_objects = array_of_objects_new;
                array_of_objects.Add(Name);
                if (array_of_objects.Count > 0)
                {
                    for (int i = 0; i < array_of_objects.Count - 1; i++)
                    {
                        for (int j = i + 1; j < array_of_objects.Count; j++)
                        {
                            if (array_of_objects[i].Equals(array_of_objects[j]))
                            {
                                array_of_objects[j] = null;
                            }
                        }

                        for (int k = 0; k < array_of_objects.Count; k++)
                        {
                            if (array_of_objects[k] == null)
                            {
                                array_of_objects.Remove(array_of_objects[k]);
                            }          
                        }
                    }
                }

                //удаляем пустые элементы массива
                for (int k = 0; k < array_of_objects.Count; k++)
                {
                    if (array_of_objects[k] == null)
                    {
                        array_of_objects.Remove(array_of_objects[k]);
                    }
                }
              //  MessageBox.Show(array_of_objects.Count.ToString());
                array_of_objects.Serialize();
                Dostup.Login_user = cbxUser.Text.ToString();      
            }

        }

        /// <summary>
        /// Метод вызывает диалог завершения приложения
        /// </summary>
        private void linkLblEsc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!frmMain.tryToEscape() && txtPass.CanFocus) txtPass.Focus();            
            //если пользователь выбрал "Нет" в диалоге закрытия приложения - фокус передается в поле с паролем.
        }

        /// <summary>
        /// Метод обрабатывает нажатия "Enter" и "Escape" в текстбоксах.
        /// </summary>
        /// <param name="sender">object. Объект, вызвавший метод.</param>
        /// <param name="e">KeyPressEventArgs. Аргумент содержит информацию о нажатой клавише.</param>
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //перенес в keydown
        }

        /// <summary>
        /// Метод вызывается перед закрытием формы
        /// </summary>
        /// <param name="sender">object. Объект, вызвавший метод.</param>
        /// <param name="e">FormClosingEventArgs. Содержит свойства, показывающие причину закрытия и позволяющие отменить закрытие.</param>
        private void frmVhod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                //если причина закрытия - ручное закрытие формы, то вызывается подтверждение закрытия.
                if (!frmMain.tryToEscape()) e.Cancel = true;//*/
            //отмена закрытия если пользователь не подтвердил в диалогое.
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //если Escape - вызов диалога завершения приложения.
                    linkLblEsc_LinkClicked(this, null);
                    break;
                case Keys.Enter:
                    //если Enter
                 /*   if ((sender as TextBox).Name == "txtUser" && txtPass.CanFocus)
                    //если sender==txtUser - передать фокус полю с паролем.
                    {
                        txtPass.Focus();
                        txtPass.SelectAll();
                    }
                    else
                        if ((sender as TextBox).Name == "txtPass")
                        //если sender==txtPass - вызов метода с попыткой авторизации.
                        {
                            Log_in();
                     //   }*/

                    linkLblVhod_LinkClicked(this, null);

                    break;
                case Keys.F1:
                    Help.ShowHelp(this, "Repairs_help.chm", HelpNavigator.TableOfContents);
                    break;
                default:
                    break;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}