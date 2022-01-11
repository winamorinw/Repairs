using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Repairs
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


          //frmVhod fmLogin = new frmVhod();
            
          // if (fmLogin.ShowDialog() == DialogResult.Cancel)
          //     return;


            //если авторизация прошла запускаем прогу
           // frmMain frmMain = new frmMain();
            Application.Run(new frmMain());
          
        }
    }
}
