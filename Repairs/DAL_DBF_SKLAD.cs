using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Collections;
using System.Data.Common;

namespace Repairs
{
    class DAL_DBF_SKLAD
    {
        string filePath1 = "F:\\BUX\\SKLAD15\\MTS01\\"; //Фрунзе

        string filePath2 = "F:\\BUX\\SKLAD15\\MTS02\\";  //Юбилейная

        string DBF_FileName1 = "m_nmkmc.dbf";
        string DBF_FileName2 = "m_rsh.dbf";
        string DBF_FileName3 = "M_RSHD.dbf";


        string constr = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + "F:\\BUX\\SKLAD15\\MTS01\\" + ";Exclusive=no; NULL=NO;DELETED=No;BACKGROUNDFETCH=NO;";

        public ArrayList GetAllTMC_Sklad()
        {
            ArrayList AllTMC = new ArrayList();
            OdbcConnection con = new OdbcConnection(constr);
            string query = "SELECT A.NMKNUM, A.EDNOME, A.NMKNAME, A.MERA,    B.CODDET, A.EDNOME, A.CODCX, A.CODUTH, A.CODBRIG, A.CODDET, A.SHPZ, A.DATSHOP, A.DATA, A.NAME, A.MERA, A.PRACE,  A.KOL FROM " + filePath1 + DBF_FileName1 + " A left join " +
                filePath2 + DBF_FileName2 + " B on A.CODCX = B.CODCX and A.CODUTH = B.CODUTH and A.CODBRIG = B.CODBRIG and A.CODDET = B.CODDET" + " where (A.SHPZ = '2010009' or A.SHPZ = '2010044' or A.SHPZ = '2050040' or A.SHPZ = '2010004') and B.NAMEDET not like '--%' ";
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



    }
}
