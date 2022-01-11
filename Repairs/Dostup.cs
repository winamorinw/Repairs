using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repairs
{
   public class Dostup
    {
        private static string login_user = "";
        private static string name = "";
        private static string plot = "";
        private static string dostup1 = "";
        private static string dostup_tmc = "";
        private static string codcx = "";
        private static string coduth = "";
        private static string codbrig = "";
        private static string coddet = "";
        private static string kod_dostup_pr = "";
        private static string ceh_dostup_pr = "";
        private static string gosti = "";        
       private static int visib = 0;


        public static string dateIn1;
        public static string dateIn2;
        public static int a = 0;

        public static string Login_user { get; set; }
        public static string Name       { get; set; }
        public static string Plot       { get; set; }
        public static string Dostup1     { get; set; }
        public static string Dostup_tmc    { get; set; }
        public static string Codcx      { get; set; }
        public static string Coduth     { get; set; }
        public static string Codbrig    { get; set; }
        public static string Coddet     { get; set; }
        public static string Kod_dostup_pr { get; set; }
        public static string Ceh_dostup_pr { get; set; }
        public static string Gosti { get; set; }
        public static string Dostup_akt { get; set; }

        //для фильтрации
        public static int A { get; set; }
       //Для отображения кнопки подотчетного лица
        public static int Visib { get; set; }

        public static string DateIn1 { get; set; }
        public static string DateIn2 { get; set; }



        public static string AddQueryAddRepair() {
            string addQuery = "";
            string dop = "";

            if (A == 0) { 

            dop = " and MONTH(DateIn) = month(GETDATE()) and year(DateIn) = year(GETDATE()) ";
            }   else 
                if(A == 1){
                    dop = string.Format(" and DateIn >= '{0}' and DateIn <= '{1}'  ", Dostup.DateIn1, Dostup.DateIn2);
                }  
            if (String.Equals(Dostup.Codcx,"0"))
            {
                    addQuery = " where 1 = 1  " + dop; 
            }
            else {
                addQuery = string.Format("where (Repair.RDivision = '{0}' or Repair.RDivision = '9966'  )  " + dop, Dostup.Codcx);    
                //  addQuery = string.Format("where (Repair.RDivision = '{0}' or Repair.Division = '{0}')  " + dop , Dostup.Codcx);    
            }
            return addQuery;
        }

       //для предформирования ведомости ресурсов
        public static string AddQueryAddRepairVedRes()
        {
            string addQuery = "";
          //  string dop = "";
            if (String.Equals(Dostup.Codcx, "0"))
            {
                addQuery = " 1 = 1  " ;
            }
            else
            {
                addQuery = string.Format("Repair.codcx = '{0}'", Dostup.Codcx);
                //  addQuery = string.Format("where (Repair.RDivision = '{0}' or Repair.Division = '{0}')  " + dop , Dostup.Codcx);    
            }
            return addQuery;
        }


        public static string AddQueryAlterRepair()
        {
            string addQuery = " ";

            if (InfoRepair.NumberDivis != "9966")
            {

                addQuery = string.Format(" and CODCX = {0} ", InfoRepair.NumberDivis);
            }
            else { 
            
            }
            return addQuery;
        }

        public static string AddQueryNewRepair()
        {
            string addQuery = "";
            if (String.Equals(Dostup.Codcx, "0"))
            {
                addQuery = "";
            }
            else
            {
                addQuery = string.Format(" where StoreID = '{0}'", Dostup.Codcx);
            }
            return addQuery;    
        }


        public static string AddQueryALLRepair()
        {
            string addQuery = "";
            if (String.Equals(Dostup.Codcx, "0"))
            {
                addQuery = "";
            }
            else
            {
                addQuery = string.Format("where (Repair.RDivision = '{0}' or Repair.Division = '{0}')", Dostup.Codcx); 
            }
            return addQuery;
        }

       //Выбор Ос по своему участку
        public static string AddQueryALLTMC()
        {
            string addQuery = "";
            if (String.Equals(Dostup.Codcx, "0"))
            {
                addQuery = "";
            }
            else
            {
                addQuery = string.Format(" and StoreID = '{0}' ", Dostup.Codcx);
            }
            return addQuery;
        }

       //выбор ведомости ресурсов по своему участку
        public static string AddQueryVedRes()
        {
            string addQuery = "";
            if (String.Equals(Dostup.Codcx, "0"))
            {
                addQuery = "";
            }
            else
            {
                if (Change_ceh.ALL == true) //*** если выбраны все цеха , а доступ только к одному цеху(будут показані все цеха , но редактировать их нельзя будет, настроено будет в форме ведомости ресурсов )
                {
                    addQuery = "";
                }
                else
                {
                    addQuery = string.Format(" and Ispolnitel_codcx = '{0}' ", Dostup.Codcx);
                }

                //addQuery = string.Format(" and Ispolnitel_codcx = '{0}' ", Dostup.Codcx);  
            }
            return addQuery;
        }


        





    }



   public class gomVedRes { 
   
   
   }
}
