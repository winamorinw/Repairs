using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Collections;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;


namespace Repairs
{
    class DAL_DBF
    {
        //string filePath = "C:\\gitfolder\\Repair\\db\\";
        string filePath1 = "F:\\BUX\\MALOC\\PODOT\\";

        string filePath2 = "F:\\SLOVARY\\";
        string filePath3 = "F:\\BUX\\1C_EXCH\\DBF\\";
        //string filePath4 = "F:\\OSR\\DB\\";
        string filePath4 = "F:\\SLOVARY\\";
        
        string DBF_FileName1 = "M_KART.dbf";
        string DBF_FileName2 = "M_DETUT.dbf";
        string DBF_FileName4 = "OS_REM.dbf";
        string DBF_FileName5 = "OKRT.dbf";
        string DBF_FileName6 = "M_EDNOME.dbf";

        string constr = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + "F:\\BUX\\MALOC\\PODOT\\" + ";Exclusive=no; NULL=NO;DELETED=No;BACKGROUNDFETCH=NO;deleted= off;";
        //string constr = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + "C:\\gitfolder\\Repair\\db\\" + ";Exclusive=YES; NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
        string constr3 = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + "F:\\BUX\\1C_EXCH\\DBF\\" + ";Exclusive=no; NULL=NO;DELETED=No;BACKGROUNDFETCH=NO;deleted= off;";
        string constr4 = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + "F:\\SLOVARY\\" + ";Exclusive=no; NULL=NO;DELETED=No;BACKGROUNDFETCH=NO;deleted= off;";

        string constr99 = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + "F:\\OSR\\DB\\" + ";Exclusive=no; NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;deleted= off";
        string sConn = "Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" + "F:\\OSR\\DB\\" + ";Exclusive=No; Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
//        string sConn = "Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" + "\\uaesb-fs-001\SYS\SLOVARY\" + ";Exclusive=No; Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
        
        
        //работа со складами
        //адреса
        // F:\BUX\SKLAD15\MTS01 если цех 5 фрунзе
        // F:\BUX\SKLAD15\MTS02 если цех 1 юбилейная


//проверка не списано ли  ОС
        public int ReturnKolNotSpisOS(string Inv_n, string Obekt)
        {

            ArrayList AllREM = new ArrayList();
            int kol = 0;
            OdbcConnection con = new OdbcConnection(sConn);
            //string query = string.Format("SELECT invnum,obekt,god,mes,cex,brig,rem_cum,cht, iif(SUBSTR(alltrim(cht),4,1)='1','поточ.рем',iif(SUBSTR(alltrim(cht),4,1)='2','кап.рем', '') ) as nam_rem FROM  " + filePath4 + DBF_FileName4 + " A where A.invnum=87099  and A.obekt=0 order by god,mes", Inv_n, Obekt);
            //string query = string.Format("SELECT invnum,obekt,god,mes,cex,brig,rem_cum,cht, iif(SUBSTRING(rtrim(ltrim(cht)),4,1)='1','поточ.рем',iif(SUBSTRING(rtrim(ltrim(cht)),4,1)='2','кап.рем', '') ) as nam_rem FROM  " + filePath4 + DBF_FileName4 + " A where A.invnum=87099  and A.obekt=0 order by god,mes", Inv_n, Obekt);


            string query = string.Format("");
            int dopznach = 0;
            ArrayList SpisOS = new ArrayList();
           // OdbcConnection con = new OdbcConnection(constr99);
            {
                //string query = string.Format(@" SELECT SUM(Quantity)  FROM " + filePath4 + DBF_FileName5 + " WHERE invnum="+Inv_n+" and obekt="+Obekt+" and rshdat is null ");
                if (Convert.ToInt32(Obekt) == 0)
                {
                    //query = string.Format(@" SELECT count(invnum)  FROM " + filePath4 + DBF_FileName5 + " WHERE invnum=" + Inv_n + " and (obekt=0 OR obekt is null) AND (ISNULL(rshdat) OR rshdat=CTOD('  .  .    '))");
                    //query = string.Format(@" SELECT invnum  FROM " + filePath4 + DBF_FileName5);

                    //query = string.Format(@" SELECT count(invnum)  FROM " + filePath4 + DBF_FileName5 + "ok WHERE ok.invnum=" + Inv_n + " and (LEFT(ok.kod_ztr,6)!='949400') and (LEFT(ok.kod_ztr,6)!='949410')  and (ok.obekt=0 OR isnull(ok.obekt)) AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))"); 23.12.2019
                    query = string.Format(@" SELECT count(invnum)  FROM " + filePath4 + DBF_FileName5 + "ok WHERE ok.invnum=" + Inv_n + "  and (LEFT(ok.kod_ztr,6)!='949410')  and (ok.obekt=0 OR isnull(ok.obekt)) AND (ISNULL(ok.rshdat) OR ok.rshdat=CTOD('  .  .    '))"); //23.12.2019
                }
                else
                {
                    //query = string.Format(@" SELECT count(invnum)  FROM " + filePath4 + DBF_FileName5 + " WHERE invnum=" + Inv_n + " and obekt="+Obekt+" AND (ISNULL(rshdat) OR rshdat=CTOD('  .  .    '))");

                    //query = string.Format(@" SELECT count(invnum)  FROM " + filePath4 + DBF_FileName5 + "ok  WHERE ok.invnum=" + Inv_n + " and (LEFT(ok.kod_ztr,6)!='949400') and (LEFT(ok.kod_ztr,6)!='949410') and ok.obekt=" + Obekt + " AND (isnull(ok.rshdat) or ok.rshdat=ctod('  .  .    '))");23/12/2019
                    query = string.Format(@" SELECT count(invnum)  FROM " + filePath4 + DBF_FileName5 + "ok  WHERE ok.invnum=" + Inv_n + " and (LEFT(ok.kod_ztr,6)!='949410') and ok.obekt=" + Obekt + " AND (isnull(ok.rshdat) or ok.rshdat=ctod('  .  .    '))"); //23.12.2019
                }

                OdbcCommand com = new OdbcCommand(query, con);
                con.Open();
                dopznach = Convert.ToInt32(com.ExecuteScalar());


            }
            return dopznach;
        }


        //Получене переданных нашему участку ОС для ремонтов
        public ArrayList GetAllTMC()
        {
            ArrayList AllTMC = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);
            string query = "SELECT B.NAMEDET, B.CODCX, B.CODUTH, B.CODBRIG, B.CODDET, A.EDNOME, A.CODCX, A.CODUTH, A.CODBRIG, A.CODDET, A.SHPZ, A.DATSHOP, A.DATA, A.NAME, A.MERA, A.PRACE,  A.KOL, A.ZAVNOM FROM " + filePath1 + DBF_FileName1 + " A left join " +
                filePath2 + DBF_FileName2 + " B on A.CODCX = B.CODCX and A.CODUTH = B.CODUTH and A.CODBRIG = B.CODBRIG and A.CODDET = B.CODDET" + " where (A.SHPZ = '2010009' or A.SHPZ = '2010044' or A.SHPZ = '2050040' or A.SHPZ = '2010004' or A.SHPZ = '2010008' or A.SHPZ = '2010006') and B.NAMEDET not like '--%' "; 
            //
          //  string query = "SELECT * FROM " + filePath + DBF_FileName + " left join  " +
           // filePath + DBF_FileName2 ; 


            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllTMC.Add(result);
                }
            }
            con.Close();
            return AllTMC;
        }




        //выбор Ремонтов по ОС+объект
        public ArrayList GetAllREM(int Inv_n, int Obekt)
        {
          
               // string query = "SELECT mes,god,rem_cum,cht,cex,brig FROM SprOS where DateEnd ='18991230' " + Dostup.AddQueryALLTMC() + "   order by StoreId, coduth, codbrig, coddet";


                ArrayList AllREM = new ArrayList();
                OdbcConnection con = new OdbcConnection(constr99);
                //string query = string.Format("SELECT invnum,obekt,god,mes,cex,brig,rem_cum,cht, iif(SUBSTR(alltrim(cht),4,1)='1','поточ.рем',iif(SUBSTR(alltrim(cht),4,1)='2','кап.рем', '') ) as nam_rem FROM  " + filePath4 + DBF_FileName4 + " A where A.invnum=87099  and A.obekt=0 order by god,mes", Inv_n, Obekt);
                //string query = string.Format("SELECT invnum,obekt,god,mes,cex,brig,rem_cum,cht, iif(SUBSTRING(rtrim(ltrim(cht)),4,1)='1','поточ.рем',iif(SUBSTRING(rtrim(ltrim(cht)),4,1)='2','кап.рем', '') ) as nam_rem FROM  " + filePath4 + DBF_FileName4 + " A where A.invnum=87099  and A.obekt=0 order by god,mes", Inv_n, Obekt);

                string query = string.Format("SELECT god ,mes ,cex ,brig ,rem_cum ,cht  FROM  " + filePath4 + DBF_FileName4 + " A where A.invnum={0} and A.obekt={1} order by god,mes ", Inv_n, Obekt);                
                OdbcCommand com = new OdbcCommand(query, con);
                con.Open();
                OdbcDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {
                        AllREM.Add(result);
                    }
                }
                con.Close();
                return AllREM;
    
        }


      





        public ArrayList GetAllTMC(string codcx, string codutx, string codbrig, string coddet)
        {
            ArrayList AllTMC = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);
            string query = string.Format("SELECT B.NAMEDET, B.CODCX, B.CODUTH, B.CODBRIG, B.CODDET, A.EDNOME, A.CODCX, A.CODUTH, A.CODBRIG, A.CODDET, A.SHPZ, A.DATSHOP, A.DATA, A.NAME, A.MERA, A.PRACE,  A.KOL FROM " + filePath1 + DBF_FileName1 + " A left join " +
                filePath2 + DBF_FileName2 + " B on A.CODCX = B.CODCX and A.CODUTH = B.CODUTH and A.CODBRIG = B.CODBRIG and A.CODDET = B.CODDET" + " where (A.SHPZ = '2010009' or A.SHPZ = '2010044' or A.SHPZ = '2050040' A.SHPZ = '2010004' or A.SHPZ = '2010008' or A.SHPZ = '2010006') and " +
                " A.CODCX = '{0}' and A.CODUTH = '{1}' and A.CODBRIG = '{2}' and A.CODDET = '{3}' and KOL > 0 ", codcx, codutx, codbrig, coddet);
            //
            //  string query = "SELECT * FROM " + filePath + DBF_FileName + " left join  " +
            // filePath + DBF_FileName2 ; 


            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllTMC.Add(result);
                }
            }
            con.Close();
            return AllTMC;
        }



        public ArrayList GetAllReportBoy()
        {
            ArrayList AllReportBoy = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);


            string query = "SELECT NAMEDET, CODCX, CODUTH, CODBRIG, CODDET, str(CODCX) + str(CODUTH) + str(CODBRIG) + str(CODDET)   as fulcode,  str(CODCX) + str(CODUTH) + str(CODBRIG) + str(CODDET)+chr(9)  + NAMEDET    as fulname  FROM " +
                filePath2 + DBF_FileName2 + " where NAMEDET not like '--%' and ((NAMEDET is not null or NAMEDET <> ' ')  and CODCX is not null) order by CODCX, CODUTH, CODBRIG, CODDET ";
            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllReportBoy.Add(result);                   
                }
            }
            con.Close();
            return AllReportBoy;
        }



      


        public ArrayList GetDanReportBoy(string fullcode)
            // public string GetDanReportBoy(string fullcode)
        {
            ArrayList DanReportBoy = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);
            
            string query = "SELECT  distinct CODCX, CODUTH, CODBRIG, CODDET, NAMEDET FROM " + filePath2 + DBF_FileName2 +
                " where ltrim(str(CODCX))+' '+ LTRIM(str(CODUTH))+' '+ LTRIM(str(CODBRIG))+' '+ LTRIM(str(CODDET)) = '" + fullcode.Trim() + "'" ;

            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    DanReportBoy.Add(result);
                }
            }
            con.Close();
            return DanReportBoy;
        }


        public ArrayList GetDanReportBoyZaPeriod(string fullcode,string dat1,string dat2)
        // public string GetDanReportBoy(string fullcode)
        {
            ArrayList DanReportBoy = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);

            string query = "SELECT  CODCX, CODUTH, CODBRIG, CODDET, NAMEDET FROM " + filePath2 + DBF_FileName2 +
                " where ltrim(str(CODCX))+' '+ LTRIM(str(CODUTH))+' '+ LTRIM(str(CODBRIG))+' '+ LTRIM(str(CODDET)) = '" + fullcode.Trim() + "'";

            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    DanReportBoy.Add(result);
                }
            }
            con.Close();
            return DanReportBoy;
        }



  
          //Выбор ТМЦ по подотчетному лицу
        public ArrayList GetAllTMCforGuys(string fulcode)
        {
            ArrayList AllTMCforGuys = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);
            string query = string.Format("SELECT B.NAMEDET, B.CODCX, B.CODUTH, B.CODBRIG, B.CODDET,       A.EDNOME, A.CODCX, A.CODUTH, A.CODBRIG, A.CODDET, A.SHPZ, A.DATSHOP, A.DATA, A.NAME, A.MERA, A.PRACE,  A.KOL, A.ZAVNOM FROM " + filePath1 + DBF_FileName1 + " A left join " +
                filePath2 + DBF_FileName2 + " B on A.CODCX = B.CODCX and A.CODUTH = B.CODUTH and A.CODBRIG = B.CODBRIG and A.CODDET = B.CODDET" + " where (A.SHPZ = '2010009' or A.SHPZ = '2010044' or A.SHPZ = '2050040' or A.SHPZ = '2010004' or A.SHPZ = '2010008' or A.SHPZ = '2010006' ) and (( str(B.CODCX)+str(B.CODUTH)+str(B.CODBRIG) + str(B.CODDET) ) = '{0}') and A.KOL > 0  order by A.NAME", fulcode);


            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllTMCforGuys.Add(result);
                }
            }
            con.Close();

            return AllTMCforGuys;
        }

        //Выбор MOL

        public ArrayList GetAllMOL() {
            ArrayList allMOL = new ArrayList();
            using (OdbcConnection con = new OdbcConnection(constr)) { 
           //20.04.2016
                //string query = "SELECT NAMEDET, CODCX, CODUTH, CODBRIG, CODDET  FROM " +
            //    filePath2 + DBF_FileName2 + " where NAMEDET not like '--%' and ((NAMEDET is not null or NAMEDET <> ' ')   " + Dostup.AddQueryAlterRepair() + " ) order by CODCX, CODUTH, CODBRIG, CODDET ";
            
                string query = "SELECT NAMEDET, CODCX, CODUTH, CODBRIG, CODDET  FROM " +
                filePath2 + DBF_FileName2 + " where NAMEDET not like '--%' and ((NAMEDET is not null or NAMEDET <> ' ') " + Dostup.AddQueryAlterRepair() + " ) order by CODCX, CODUTH, CODBRIG, CODDET ";
                Debug.Write(query);
              

                OdbcCommand com = new OdbcCommand(query, con);
                con.Open();
            
                Debug.WriteLine(com.CommandText);

                OdbcDataReader dr = com.ExecuteReader(); 
           

            if (dr.HasRows) {
                foreach (DbDataRecord result in dr) {
                    allMOL.Add(result);
                }
            }


        }
            return allMOL;
        }



        //выбор по ТМЦ (цех участок бригада и т д)
        public ArrayList GetAllTMCFORMOL()
        {
            ArrayList AllTMC = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);

            //was string query = string.Format("SELECT CODCX, CODUTH, CODBRIG, CODDET, EDNOME, SHPZ, DATA, NAME, MERA, PRACE, SHPZ,  texsod, norma as norma_new,   sum(KOL) as sum_kol FROM " + filePath1 + DBF_FileName1 +
//                 " " + " where (SHPZ = '2010009' or SHPZ = '2010044' or SHPZ = '2050040' or SHPZ = '2010004' or SHPZ = '2010008' or SHPZ = '2010006' ) and " +
            //                " CODCX = {0} and CODUTH = {1} and CODBRIG = {2} and CODDET = {3}  group by CODCX, CODUTH, CODBRIG, CODDET, EDNOME, SHPZ, DATA, NAME, MERA, PRACE, SHPZ,texsod, norma having sum(kol) > 0  order by NAME ", InfoRepair.CODCX, InfoRepair.CODUTH, InfoRepair.CODBRIG, InfoRepair.CODDET);

            
            
            string query = string.Format("SELECT CODCX, CODUTH, CODBRIG, CODDET, EDNOME, ZAVNOM, SHPZ, DATA, NAME, MERA, PRACE, SHPZ, '' as texsod, '' as norma_new,   sum(KOL) as sum_kol FROM " + filePath1 + DBF_FileName1 +
                 " " + " where (SHPZ = '2010009' or SHPZ = '2010044' or SHPZ = '2050040' or SHPZ = '2010004' or SHPZ = '2010008' or SHPZ = '2010006' ) and " +
                " CODCX = {0} and CODUTH = {1} and CODBRIG = {2} and CODDET = {3}  group by CODCX, CODUTH, CODBRIG, CODDET, EDNOME, ZAVNOM,SHPZ, DATA, NAME, MERA, PRACE, SHPZ having sum(kol) > 0  order by NAME ", InfoRepair.CODCX, InfoRepair.CODUTH, InfoRepair.CODBRIG, InfoRepair.CODDET);

            Debug.WriteLine(query);
            Debug.WriteLine("/////////////////////////////////////////");
            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllTMC.Add(result);
                }
            }
            con.Close();
            return AllTMC;
        }


        //для контрагента
        public ArrayList GetAllTMCFORMOLKontragent()
        {
            ArrayList AllTMC = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);
            string query = string.Format("SELECT CODCX, CODUTH, CODBRIG, CODDET, EDNOME,ZAVNOM, SHPZ, DATSHOP, DATA, NAME, MERA, PRACE, SHPZ, texsod, norma as norma_new,   sum(KOL) as sum_kol FROM " + filePath1 + DBF_FileName1 +
                 " " + " where (SHPZ = '2060000') and " +
                " CODCX = {0} and CODUTH = {1} and CODBRIG = {2} and CODDET = {3}  group by CODCX, CODUTH, CODBRIG, CODDET, EDNOME,ZAVNOM, SHPZ, DATSHOP, DATA, NAME, MERA, PRACE, SHPZ, texsod, norma having sum(kol) > 0  order by NAME ", InfoRepair.CODCX, InfoRepair.CODUTH, InfoRepair.CODBRIG, InfoRepair.CODDET);
            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllTMC.Add(result);
                }
            }
            con.Close();
            return AllTMC;
        }


        public string GetAllTMCFORMOLstring()
        {
            ArrayList AllTMC = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);
            string query = string.Format("SELECT CODCX, CODUTH, CODBRIG, CODDET, EDNOME, SHPZ, DATSHOP, DATA, NAME, MERA, PRACE, SHPZ,   sum(KOL) as KOL FROM " + filePath1 + DBF_FileName1 +
                 " " + " where (SHPZ = '2010009' or SHPZ = '2010044' or SHPZ = '2050040' or SHPZ = '2010004' or SHPZ = '2010008' or SHPZ = '2010006' ) and " +
                " CODCX = {0} and CODUTH = {1} and CODBRIG = {2} and CODDET = {3}  group by CODCX, CODUTH, CODBRIG, CODDET, EDNOME, SHPZ, DATSHOP, DATA, NAME, MERA, PRACE, SHPZ having sum(kol) > 0  order by NAME ", InfoRepair.CODCX, InfoRepair.CODUTH, InfoRepair.CODBRIG, InfoRepair.CODDET);

            OdbcCommand com = new OdbcCommand(query, con);
            con.Open();
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {


                    AllTMC.Add(result);
                }
            }
            con.Close();
            return query;
        }



           //Получене сумм по зарплате по ОС за месяц, год

        public ArrayList GetZP(string mes,string god, string invnum, string cx, string uch, string brig,string obekt,string shpz)
        {
            Debug.WriteLine("---");
            Debug.WriteLine(brig);
            ArrayList Zp = new ArrayList();
              OdbcConnection con = new OdbcConnection(constr3);
             // string query = "SELECT B.NAMEDET, B.CODCX, B.CODUTH, B.CODBRIG, B.CODDET, A.EDNOME, A.CODCX, A.CODUTH, A.CODBRIG, A.CODDET, A.SHPZ, A.DATSHOP, A.DATA, A.NAME, A.MERA, A.PRACE,  A.KOL FROM " + filePath1 + DBF_FileName1 + " A left join " +
              //    filePath2 + DBF_FileName2 + " B on A.CODCX = B.CODCX and A.CODUTH = B.CODUTH and A.CODBRIG = B.CODBRIG and A.CODDET = B.CODDET" + " where (A.SHPZ = '2010009' or A.SHPZ = '2010044' or A.SHPZ = '2050040' or A.SHPZ = '2010004') and B.NAMEDET not like '--%' ";
              string query;

              
              switch (cx)
              {
                  case "50":
                      
                      
                      //if (uch == "4" && brig == "2" )
                      //{
                      //    query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro is null or inno='{0}' and ceh={1} and uch={2} and buro=0 and (dt='910200' or dt='910100' )", invnum, cx, uch, brig);
                      //}
                      //else
                      //{
                      //    query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro={3} and (dt='910200' or dt='910100' ) ", invnum, cx, uch, brig);
                      //}


                      if (uch == "6" )
                      {
                          //invnum = "89007/2";
                          if (obekt == "0" || obekt == null)
                          {
                              if (brig == "1")
                                  query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh=50 and uch=6 and buro=1 and (dt='910200' or dt='910100' or dt='232000' or dt='231000') and shpz='{4}'", invnum, cx, uch, brig, shpz.Trim());
                              else
                                  query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where ((inno='{0}' and ceh={1} and uch={2} and buro is null) or (inno='{0}' and ceh={1} and uch={2} and buro=0)) and (dt='910200' or dt='910100' or dt='232000' or dt='231000') and shpz='{4}'", invnum, cx, uch, brig, shpz.Trim());
                          }
                          else
                          {
                              if (brig == "1")
                                  query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}/{4}' and ceh=50 and uch=6 and buro=1 and (dt='910200' or dt='910100' or dt='232000' or dt='231000') and shpz='{5}'", invnum.Trim(), cx, uch, brig, obekt.Trim(), shpz.Trim());
                              else
                                  query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where ((inno='{0}/{4}' and ceh={1} and uch={2} and buro is null) or (inno='{0}/{4}' and ceh={1} and uch={2} and buro=0 ))and (dt='910200' or dt='910100' or dt='232000' or dt='231000')  and shpz='{5}'", invnum.Trim(), cx, uch, brig, obekt.Trim(), shpz.Trim());
                          }


                      }
                      else
                      {

                          if (uch == "4" && brig == "2")
                          {
                              query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh=50 and uch=4 and buro=2 and shpz='{4}'", invnum, cx, uch, brig, shpz.Trim());
                          }
                          else
                          {

                              if (brig == "0" || brig == null)
                              {
                                  query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro is null or inno='{0}' and ceh={1} and uch={2} and buro=0 and shpz='{4}'", invnum, cx, uch, brig,shpz.Trim());
                              }
                              else
                              {
                                  query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro={3} and shpz='{4}' ", invnum, cx, uch, brig,shpz.Trim());
                              }
                          }

                      }

                      
                      
                      
                      break;
                  
                  case "54":
                      if (brig == "0" || brig == null)
                          {
                              query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where ((inno='{0}' and ceh={1} and uch={2} and buro is null) or (inno='{0}' and ceh={1} and uch={2} and buro=0 )) and (dt='910200' or dt='910100' or dt='232000' or dt='231000') and shpz='{4}'", invnum, cx, uch, brig, shpz.Trim());
                          }
                          else
                          {
                              query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro={3} and (dt='910200' or dt='910100' or dt='232000'  or dt='231000' ) and shpz='{4}' ", invnum, cx, uch, brig, shpz.Trim());
                          }

                        break;

                  case "22":
                        {
                            query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and (dt='910200' or dt='910100' or dt='232000'  or dt='231000') and shpz='{2}'", invnum, cx, shpz.Trim());
                            //query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and shpz='{2}'", invnum,cx,shpz.Trim());
                        }
                        break;
                  
                  default:
                           if (brig == "0" || brig==null)
                          {
                               //query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where ((inno='{0}' and ceh={1} and uch={2} and buro is null ) or (inno='{0}' and ceh={1} and uch={2} and buro=0)) and (dt='910200' or dt='910100' or dt='232000' or dt='231000' ) and shpz='{4}' ", invnum, cx, uch, brig, shpz.Trim());
                                   if (obekt == "0" || obekt == null)
                                  {
                                      query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where ((inno='{0}' and ceh={1} and uch={2} and buro is null ) or (inno='{0}' and ceh={1} and uch={2} and buro=0)) and (dt='910200' or dt='910100' or dt='232000' or dt='231000' ) and shpz='{4}' ", invnum, cx, uch, brig, shpz.Trim());
                                   }
                                      else
                                   {
                                       
                                       query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where ((inno='{0}/{5}' and ceh={1} and uch={2} and buro is null ) or (inno='{0}/{5}' and ceh={1} and uch={2} and buro=0)) and (dt='910200' or dt='910100' or dt='232000' or dt='231000' ) and shpz='{4}' ", invnum, cx, uch, brig, shpz.Trim(), obekt.ToString());
                                   }

                           
                           }
                          else
                          {
                              //query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro={3} and (dt='910200' or dt='910100' or dt='232000' or dt='231000' ) and shpz='{4}' ", invnum, cx, uch, brig, shpz.Trim());                                   
                               if (obekt == "0" || obekt == null)
                                  {
                                      query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro={3} and (dt='910200' or dt='910100' or dt='232000' or dt='231000' ) and shpz='{4}' ", invnum, cx, uch, brig, shpz.Trim());
                                   
                                  }
                                   else
                                   {
                                       query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}/{5}' and ceh={1} and uch={2} and buro={3} and (dt='910200' or dt='910100' or dt='232000' or dt='231000' ) and shpz='{4}' ", invnum, cx, uch, brig, shpz.Trim(), obekt.ToString());
                                   }
                          }
               break;
              }


            
            //if (brig == "0")
            //  {
            //      query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro is null or inno='{0}' and ceh={1} and uch={2} and buro=0 and (dt='910200' or dt='910100' )", invnum, cx, uch, brig);
            //  }
            //  else
            //  {
            //      query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + ".dbf where inno='{0}' and ceh={1} and uch={2} and buro={3} and (dt='910200' or dt='910100' ) ", invnum, cx, uch, brig);
            //  }
                  //
              //  string query = "SELECT * FROM " + filePath + DBF_FileName + " left join  " +
              // filePath + DBF_FileName2 ; 
              Debug.WriteLine(query);
          
              OdbcCommand com = new OdbcCommand(query, con);
            //con.Open();

            //OleDbConnection con = new OleDbConnection(constr3);
            // string query = "SELECT B.NAMEDET, B.CODCX, B.CODUTH, B.CODBRIG, B.CODDET, A.EDNOME, A.CODCX, A.CODUTH, A.CODBRIG, A.CODDET, A.SHPZ, A.DATSHOP, A.DATA, A.NAME, A.MERA, A.PRACE,  A.KOL FROM " + filePath1 + DBF_FileName1 + " A left join " +
            //    filePath2 + DBF_FileName2 + " B on A.CODCX = B.CODCX and A.CODUTH = B.CODUTH and A.CODBRIG = B.CODBRIG and A.CODDET = B.CODDET" + " where (A.SHPZ = '2010009' or A.SHPZ = '2010044' or A.SHPZ = '2050040' or A.SHPZ = '2010004') and B.NAMEDET not like '--%' ";
           // string query;
            /*
            if (brig == "0")
            {
                query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + "2.dbf where inno='{0}' and ceh={1} and uch={2} and buro=iif(buro=null,0,0)  ", invnum, cx, uch, brig);
            }
            else
            {
                query = string.Format("SELECT kt,inno,ceh,uch,buro,sum FROM " + filePath3 + "ZP" + mes + god + "2.dbf where inno='{0}' and ceh={1} and uch={2} and buro={3}", invnum, cx, uch, brig);
            }
            //
            //  string query = "SELECT * FROM " + filePath + DBF_FileName + " left join  " +
            // filePath + DBF_FileName2 ;*/ 
            Debug.WriteLine(query);

            //OdbcCommand com = new OdbcCommand(query, con);
            try
            {
                con.Open();
            }
            catch (OdbcException e)
            {
                string errorMessages="";
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    errorMessages += "Index #" + i + "\n" +
                                     "Message: " + e.Errors[i].Message + "\n" +
                                     "NativeError: " + e.Errors[i].NativeError.ToString() + "\n" +
                                     "Source: " + e.Errors[i].Source + "\n" +
                                     "SQL: " + e.Errors[i].SQLState + "\n";
                }


                // error;
            }

            //  OdbcCommand d = new OdbcCommand("UPDATE " + filePath3 + "ZP" + mes + god + ".dbf SET Buro = 0 WHERE Buro is null", con);
            //  d.ExecuteNonQuery();
            //OdbcDataReader dr = com.ExecuteReader();
            OdbcDataReader dr = null;
            try
            {
               dr = com.ExecuteReader();
            }
            catch
            {
                return Zp;
            }

            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {

                    Zp.Add(result);
                }
            }
            con.Close();
            return Zp;
        }



        //смотрим признак возвратной детали

        public ArrayList Get_Priznak_vozvr_det()
        {
           
            Debug.WriteLine("---");
            ArrayList Pr_vozvr_det = new ArrayList();
            OdbcConnection con2 = new OdbcConnection(constr4);
            string query;
            //query = string.Format("SELECT ednome, priz_pereb FROM F:\\SLOVARY\\M_EDNOME.dbf where priz_pereb=2");
            query = string.Format("SELECT ednome, priz_pereb FROM uaesb-FS-001\\SYS\\SLOVARY\\M_EDNOME.dbf where priz_pereb=2");

            OdbcCommand com;
            try
            {
                Debug.WriteLine(query);
                com = new OdbcCommand(query, con2);
                Debug.WriteLine(query);

                con2.Open();
                //  OdbcCommand d = new OdbcCommand("UPDATE " + filePath3 + "ZP" + mes + god + ".dbf SET Buro = 0 WHERE Buro is null", con);
                //  d.ExecuteNonQuery();
                //OdbcDataReader dr = com.ExecuteReader();

                OdbcDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {

                        Pr_vozvr_det.Add(result);
                    }
                }
                con2.Close();
            }
            catch (OdbcException e)
            {
                con2.Close();
                //string errorMessages = "";
                //for (int i = 0; i < e.Errors.Count; i++)
                //{
                //    errorMessages += "Index #" + i + "\n" +
                //                     "Message: " + e.Errors[i].Message + "\n" +
                //                     "NativeError: " + e.Errors[i].NativeError.ToString() + "\n" +
                //                     "Source: " + e.Errors[i].Source + "\n" +
                //                     "SQL: " + e.Errors[i].SQLState + "\n";
                //}
                query = string.Format("SELECT ednome, priz_pereb FROM F:\\SLOVARY\\M_EDNOME.dbf where priz_pereb=2");
                try
                {
                    Debug.WriteLine(query);
                    com = new OdbcCommand(query, con2);
                    Debug.WriteLine(query);

                    con2.Open();
                    //  OdbcCommand d = new OdbcCommand("UPDATE " + filePath3 + "ZP" + mes + god + ".dbf SET Buro = 0 WHERE Buro is null", con);
                    //  d.ExecuteNonQuery();
                    //OdbcDataReader dr = com.ExecuteReader();

                    OdbcDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {

                            Pr_vozvr_det.Add(result);
                        }
                    }
                    con2.Close();
                }
                catch (OdbcException ee)
                {
                    string errorMessages = "";
                    for (int i = 0; i < ee.Errors.Count; i++)
                    {
                        errorMessages += "Index #" + i + "\n" +
                                         "Message: " + ee.Errors[i].Message + "\n" +
                                         "NativeError: " + ee.Errors[i].NativeError.ToString() + "\n" +
                                         "Source: " + ee.Errors[i].Source + "\n" +
                                         "SQL: " + ee.Errors[i].SQLState + "\n";
                    }
                }
                con2.Close();
            }

            
            return Pr_vozvr_det;
        }


    }
}
