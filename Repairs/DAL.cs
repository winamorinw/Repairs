using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data.Common;
using System.Diagnostics;
using System.Data;

namespace Repairs
{
    class DAL
    {

        string constr = Properties.Settings.Default.RepairOSConnStr;
        //Получене переданных нашему участку ОС для ремонтов
        public ArrayList GetAllRepair(string tipquery)
        {
            ArrayList AllRepair = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            //            string query = @"SELECT SprOS.d_rem,SprOS.b_bal_cena,
            //     Repair.RepairID, Repair.InventoryNumber, Repair.Obekt, Repair.RDivision, Repair.Division, Repair.DateIn, Repair.DateOut, Repair.TypeFlaut, 
            //	 Repair.Cause, Repair.Note + ' ' + isnull(Repair.KodKontrAgent,'') +
            //isnull(Repair.NameKontragent,'') + isnull(Repair.EdrpouKontragent,'')    as note, Repair.Responsible,  A.StoreName, B.StoreName, SprOS.Name, Repair.dataNext, Repair.NotedataNext, Repair.CODCX,
            //	 Repair.CODUTH, Repair.CODBRIG,  Repair.CODDET,  Repair.NAMEDET
            //	 FROM Repair 
            //		left join SprOS on Repair.InventoryNumber = SprOS.InventoryNumber and SprOS.Obekt = isnull(Repair.Obekt,0)
            //        left join Store A on Repair.RDivision = A.StoreID 
            //		left join Store B on Repair.Division = B.StoreID " + Dostup.AddQueryAddRepair() + " order by Repair.DateOut ";
            string queryNotInVed = "";
            if (tipquery == "queryNotInVed") // параметр tipquery == "queryNotInVed" для того, чтоб отобразить те инв.№, по которым нет сформированных ведомостей
                                             // если параметр tipquery == "" то, не учитываем то, что инв.№ в уже сформированных ведомостях  или нет
            {
                queryNotInVed = @" and Repair.InventoryNumber in ( SELECT
    DISTINCT Repair.InventoryNumber 
       FROM Repair 
	   left join SprOS on Repair.InventoryNumber = SprOS.InventoryNumber and SprOS.Obekt = isnull(Repair.Obekt,0)
       left join Store A on Repair.RDivision = A.StoreID
       left join ReplacedPart on ReplacedPart.RepairID = Repair.RepairID
       left join Store B on Repair.Division = B.StoreID 
                                   where ReplacedPart.Original = 0 and ReplacedPart.TypeRepPartID is null and  " + Dostup.AddQueryAddRepairVedRes() + " )";
            }
            else
            {
                queryNotInVed = "";
            }

            string query = @"SELECT ROW_NUMBER() OVER(ORDER BY Repair.DateOut) no_pp, SprOS.d_rem,SprOS.b_bal_cena,
     Repair.RepairID, Repair.InventoryNumber, Repair.Obekt, Repair.RDivision, Repair.Division, Repair.DateIn, Repair.DateOut, Repair.TypeFlaut, 
	 Repair.Cause, Repair.Note + ' ' + isnull(Repair.KodKontrAgent,'') +
isnull(Repair.NameKontragent,'') + isnull(Repair.EdrpouKontragent,'')    as note, Repair.Responsible,  A.StoreName, B.StoreName, SprOS.Name, Repair.dataNext, Repair.NotedataNext, Repair.CODCX,
	 Repair.CODUTH, Repair.CODBRIG,  Repair.CODDET,  Repair.NAMEDET,
     f2.FIO1f2,f2.dolg1f2,f2.FIO2f2,f2.dolg2f2,f2.FIO3f2,f2.dolg3f2,f2.FIO4f2,f2.dolg4f2,f2.FIO5f2,f2.dolg5f2,Repair.Inv_usl, Repair.Obekt_usl,OS_for_usl.name as name_inv_usl 
	 FROM Repair 
		left join SprOS on Repair.InventoryNumber = SprOS.InventoryNumber and SprOS.Obekt = isnull(Repair.Obekt,0)
        left join SprOS OS_for_usl on Repair.Inv_usl = OS_for_usl.InventoryNumber and OS_for_usl.Obekt = isnull(Repair.Obekt_usl,0)
        left join Store A on Repair.RDivision = A.StoreID 
		left join Store B on Repair.Division = B.StoreID 
        left join PodpisiForAktF2 f2 on Repair.RepairID= f2.RepairID " + Dostup.AddQueryAddRepair() + queryNotInVed + " order by Repair.DateOut ";

            
            

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepair.Add(result);
                }
            }
            con.Close();
            return AllRepair;
        }

        public ArrayList GetAllJobForRepair(string RepairID)
        {
            //throw new NotImplementedException();
            ArrayList allJobs = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT Job.JobId, Job.RepairId, Job.JobCode, RefJob.JobName, RefJob.T_Inspect FROM Job INNER JOIN  RefJob ON Job.JobCode = RefJob.JobCode WHERE Job.RepairId='{0}'", RepairID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allJobs.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allJobs;
        }


        public DataTable GetLastRepairAndVedomostByInventory(string inventory)
        {
            DataTable table = new DataTable();
            string query = "SELECT TOP(1) t1.DateIn, t1.DateOut, t1.Division, t1.RDivision, t1.NAMEDET, t2.zaversh "+
                           "FROM [Repairs].[dbo].[Repair] t1 "+
                           "INNER JOIN Vedomost_Resursov t2 ON t1.RepairID = t2.RepairID "+
                           $"WHERE t1.InventoryNumber = '{inventory}' "+
                           "ORDER BY t1.RepairID desc";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                adapter.Fill(table);
            }
            return table;
        }
        public ArrayList GetAll_Status_MOl(string Codcx)
        {
            //throw new NotImplementedException();
            ArrayList allMol = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT [blocked],[cod_cx],[cod_uth],[cod_brig],[cod_det],[name_mol],[id]  FROM [Repairs].[dbo].[Status_mes_MOL]  WHERE cod_cx='{0}'", Codcx);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allMol.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allMol;
        }


        public ArrayList GetAllJobForAktF2_FromRepair(string RepairID)
        {
            //throw new NotImplementedException();
            ArrayList allJobsForAktF2_FromRepair = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT Job.Id, Job.Id_Repair, Job.Nam_job, Job.ch_chas FROM [Jobs_FromAktF2] Job WHERE Job.Id_Repair='{0}'", RepairID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allJobsForAktF2_FromRepair.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allJobsForAktF2_FromRepair;
        }




        //Выбор всех видов заполняемых работ
        public ArrayList GetAllJobsforAll()
        {
            ArrayList allJobsForAll = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT JobCode, JobName   FROM RefJob where JobCode=36 or JobCode=37 or JobCode=9 or JobCode=38 or JobCode=39";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                            allJobsForAll.Add(result);
                    }
                }
                catch { }
            }
            return allJobsForAll;
        }
        //выбор заменяемой запчасти
        public ArrayList getAllReplacedPartForJob(string JobId)
        {
            //  throw new NotImplementedException();
            ArrayList allReplacedPart = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT JobId, ReplacedPart.PartId,Prace, Quantity, ReplacedId, PartName, Name, Mera, EDNOME, DateInRep, DataReplace, Original, TypeRepPartID, ReplacedPart.RepairID,ReplacedPart.DataToday,ReplacedPart.Zavnom FROM  ReplacedPart left join RefPart on RefPart.PartId = ReplacedPart.PartId where JobId='{0}'", JobId);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allReplacedPart.Add(result);
                        }
                    }
                }
                catch
                {
                }
            }
            return allReplacedPart;
        }
        public bool UpdateVedResIsCapital(int id, bool isCapital)
        {
            string query = $"UPDATE Vedomost_Resursov SET IsCapital = '{isCapital}' WHERE ID = {id}";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                }
            }
            return true;
        }
        public bool SaveNewJob(string RepairId, string jobCode)
        {
            bool flagSum = false;
            string query = string.Format("insert into job (RepairId, JobCode) values('{0}', '{1}' )", RepairId, jobCode);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //выборка данных для места установки
        public ArrayList getAllPlacePart(string ReplacedId)
        {
            // throw new NotImplementedException();
            ArrayList allPlacePart = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT RefPlace.PlaceName, PlacePart.PlaceCode FROM  PlacePart left join  RefPlace on RefPlace.PlaceCode = PlacePart.PlaceCode where ReplacedId ='{0}'", ReplacedId);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allPlacePart.Add(result);
                        }
                    }
                }
                catch
                {
                }
            }
            return allPlacePart;
        }

        //выборка имени пользователя

        public ArrayList GetUser()
        {
            ArrayList allUser = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "DECLARE @sys_usr char(30); SET @sys_usr = SYSTEM_USER; SELECT  @sys_usr";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                            allUser.Add(result);
                    }
                }
                catch { }
            }
            return allUser;
        }
        public string GetKodZtr(string inventoryNumber)
        {
            string result = "";
            string query = $"SELECT kod_ztr FROM SprOS WHERE InventoryNumber = '{inventoryNumber}'";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    result = (string)com.ExecuteScalar() ?? "";
                    con.Close();
                }
                catch
                {
                    result = "";
                }
                
            }
            return result;
        }

        ///Показывать отправки в ремонт
        ///
        public ArrayList GetAllGetRepair()
        {
            ArrayList allGetRepair = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = @"SELECT  Repair.RepairID, Repair.DateIn, Repair.InventoryNumber, Repair.Obekt, Store_1.StoreName AS Divis, SprOS.Name, 
                            Store.StoreName AS AsRDivis, Repair.DateOut, Repair.TypeFlaut, Repair.Cause, Repair.Responsible, Repair.Note + ' ' + isnull(Repair.KodKontrAgent,'') +
isnull(Repair.NameKontragent,'') + isnull(Repair.EdrpouKontragent,'')    as note, Repair.plan_r, Repair.dataNext , Repair.NotedataNext 
                        FROM  Repair INNER JOIN  Store AS Store_1 ON Repair.Division = Store_1.StoreID INNER JOIN
                              Store ON Repair.RDivision = Store.StoreID left join SprOS on SprOS.InventoryNumber = Repair.InventoryNumber and SprOS.Obekt = isnull(Repair.Obekt,0)  " + Dostup.AddQueryALLRepair() + " order by Repair.RepairID desc";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allGetRepair.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allGetRepair;
        }

        //Показывать цеха отправители в ремонт
        public ArrayList GetAllStore()
        {
            ArrayList allStore = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT StoreID, StoreName, Repair FROM dbo.Store " + Dostup.AddQueryNewRepair();
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allStore.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allStore;
        }


        //Показывать цеха отправители для услуг
        public ArrayList GetAllStoreUsl()
        {
            ArrayList allStore = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT StoreID, StoreName, Repair FROM dbo.Store where (StoreName<>null or StoreName<>'') and StoreID<>'9966' ";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allStore.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allStore;
        }

        //Показать ремонтные цеха
        public ArrayList GetAllStoreR()
        {
            ArrayList allStoreR = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT StoreID, StoreName, Repair FROM dbo.Store where Repair = 1";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allStoreR.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allStoreR;
        }


        //выбор ТМЦ
        public ArrayList GetAllTMC()
        {
            ArrayList allTMC = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, coduth, codbrig, coddet, Obekt,b_bal_cena FROM SprOS where Name not like '%послуг%' and DateEnd ='18991230' " + Dostup.AddQueryALLTMC() + "   order by StoreId, coduth, codbrig, coddet";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTMC.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allTMC;
        }



// вібор ТМЦ для услуг
        public ArrayList GetAllTMCUsl()
        {
            ArrayList allTMC = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, coduth, codbrig, coddet, Obekt,b_bal_cena FROM SprOS where name like '%послуг%' or InventoryNumber='9231014' order by StoreId, coduth, codbrig, coddet";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTMC.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allTMC;
        }


        // вібор ТМЦ для prostoev
        public ArrayList GetAllTMC_Prostoi(string nceh, string nuth)
        {
            ArrayList allTMC = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, coduth, codbrig, coddet, Obekt,b_bal_cena FROM SprOS where DateEnd ='18991230' and StoreId='" + nceh.ToString() + "' and CODUTH='"+nuth.ToString()+"'  order by StoreId, coduth, codbrig, coddet";
                
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTMC.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allTMC;
        }
        
        
        //Вібор МОЛ за период
        public ArrayList GetAllReportBoyZaPeriod(string DatBeg, string DatEnd)
        {

            string Ddat_beg = DatBeg.Substring(6, 4) + DatBeg.Substring(3, 2) + DatBeg.Substring(0, 2);
            string Ddat_end = DatEnd.Substring(6, 4) + DatEnd.Substring(3, 2) + DatEnd.Substring(0, 2);


            ArrayList AllReportBoy = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format(@"select distinct CODCX,CODUTH,CODBRIG,CODDET, fio_mol as NAMEDET,concat(cast(CODCX  as nvarchar),' ',cast(CODUTH  as nvarchar),' ',cast(CODBRIG  as nvarchar),' ',cast(CODDET  as nvarchar))  as fulcode, cast(CODCX as varchar)+' '+cast(CODUTH as varchar)+' '+cast(CODBRIG as varchar)+' '+cast(CODDET as varchar)+' '+fio_mol as fulname from PTO WHERE ((Data1PTO >= '{0}' and Data1PTO <= '{1}') ) order by CODCX,CODUTH,CODBRIG,CODDET ", Ddat_beg.ToString(), Ddat_end.ToString());
                
                //string query = string.Format(@"select distinct concat((CODCX),' ',(CODUTH),' ',(CODBRIG),' ', (CODDET) ,'  ')  as fulcode1,   concat((CODCX),' ',(CODUTH),' ',(CODBRIG),' ', (CODDET) ,'  ',fio_mol ) as fulname1 from PTO WHERE ((Data1PTO >= '{0}' and Data1PTO <= '{1}') )", DatBeg.ToString(), DatEnd.ToString());

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            AllReportBoy.Add(result);
                        }
                    }
                }
                catch { }
                con.Close();
            }
            
            return AllReportBoy;

        }


        //Вібор МОЛ за период
        public ArrayList GetAllReportCehZaPeriod(string DatBeg, string DatEnd)
        {

            string Ddat_beg = DatBeg.Substring(6, 4) + DatBeg.Substring(3, 2) + DatBeg.Substring(0, 2);
            string Ddat_end = DatEnd.Substring(6, 4) + DatEnd.Substring(3, 2) + DatEnd.Substring(0, 2);

            ArrayList AllReportBoy = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format(@" select distinct p.codcx as fulcode ,cast(p.codcx as varchar)+' '+s.StoreName  as fulname from pto p left join store s on p.codcx=s.StoreID   WHERE ((p.Data1PTO >= '{0}' and p.Data1PTO <= '{1}') ) order by CODCX", Ddat_beg.ToString(), Ddat_end.ToString());

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            AllReportBoy.Add(result);
                        }
                    }
                }
                catch { }
                con.Close();
            }

            return AllReportBoy;

        }





        //отправка в ремонт. сохранение
        public bool SaveNewRepair(string DateIn, string InventoryNumber, string RDivision, string Division, string plan_r, string obekt, string kodK, string nameK, string edrpouK)
        {
            bool flagsum = false;
            string query = string.Format(@"insert into Repair (DateIn, InventoryNumber, RDivision, Division, plan_r, Obekt, KodKontrAgent, NameKontragent, EdrpouKontragent) values ( 
                          '{0}', '{1}',  
                        '{2}', '{3}', '{4}', '{5}' ,'{6}', '{7}', '{8}')", DateIn, InventoryNumber, RDivision, Division, plan_r, obekt, kodK, nameK, edrpouK);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagsum = true;
                        
                    }
                }
                catch(Exception) 
                {
                    
                }
            }
            return flagsum;
            ;
        }


        //Изменение ремонта


        public bool AlterRepair(string mol)
        {
            //записываем значение нуль в дату начала ремонта

            string datnext;
            if (InfoRepair.DateNext == "")
            {
                datnext = "null";
            }
            else
            {
                datnext = "'{9}'";

            }


            string datout;
            if (InfoRepair.DateOut == "")
            {
                datout = "null";
            }
            else
            {
                datout = "'{8}'";

            }

            string query = "";
            bool flagAlter = false;
            if (mol.ToString().Length > 0)
            {
                query = string.Format("update Repair " +
    "set CODCX = '{0}', CODUTH = '{1}', CODBRIG = '{2}', CODDET = '{3}', NAMEDET = '{4}', TypeFlaut = '{5}', Cause = '{6}', Note = '{7}', " +
    "DateOut = " + datout + ", DataNext = " + datnext + ", Notedatanext = '{10}', Obekt = '{12}' where RepairID = '{11}' ", InfoRepair.CODCX, InfoRepair.CODUTH,
    InfoRepair.CODBRIG, InfoRepair.CODDET, InfoRepair.NAMEDET.ToString().Replace("'", "").Trim(), InfoRepair.TypeFlaut, InfoRepair.Cause, InfoRepair.Note, InfoRepair.DateOut,
    InfoRepair.DateNext, InfoRepair.Notedatanext, InfoRepair.RepairID, InfoRepair.Obekt);
            }
            else
            {
                query = string.Format("update Repair " +
"set CODCX = null, CODUTH = null, CODBRIG = null, CODDET = null, NAMEDET = null, TypeFlaut = '{5}', Cause = '{6}', Note = '{7}', " +
"DateOut = " + datout + ", DataNext = " + datnext + ", Notedatanext = '{10}', Obekt = '{12}' where RepairID = '{11}' ", null, null,
null, null, null, InfoRepair.TypeFlaut, InfoRepair.Cause, InfoRepair.Note, InfoRepair.DateOut,
InfoRepair.DateNext, InfoRepair.Notedatanext, InfoRepair.RepairID, InfoRepair.Obekt);

            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagAlter = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagAlter;
        }




        public bool UpdateRepair_inv_usl(string inv_usl, string ob_usl)
        {
            //записываем значение нуль в дату начала ремонта

            string query = "";
            bool flagAlter = false;
                query = string.Format("update Repair set inv_usl = '{0}', obekt_usl = '{1}' where RepairID = '{2}' ", inv_usl,ob_usl , InfoRepair.RepairID);

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagAlter = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagAlter;
        }
        //              public string AlterRepairString()
        //              {
        //                  //записываем значение нуль в дату начала ремонта

        //                  string datnext;
        //                  if (InfoRepair.DateNext == "")
        //                  {
        //                      datnext = "null";
        //                  }
        //                  else
        //                  {
        //                      datnext = "'{9}'";

        //                  }


        //                  string datout;
        //                  if (InfoRepair.DateOut == "")
        //                  {
        //                      datout = "null";
        //                  }
        //                  else
        //                  {
        //                      datout = "'{8}'";

        //                  }


        //                  bool flagAlter = false;
        //                  string query = string.Format("update Repair " +
        //"set CODCX = '{0}', CODUTH = '{1}', CODBRIG = '{2}', CODDET = '{3}', NAMEDET = '{4}', TypeFlaut = '{5}', Cause = '{6}', Note = '{7}', " +
        //"DateOut = " + datout + ", DataNext = " + datnext + ", Notedatanext = '{10}' where RepairID = '{11}' ", InfoRepair.CODCX, InfoRepair.CODUTH,
        //InfoRepair.CODBRIG, InfoRepair.CODDET, InfoRepair.NAMEDET, InfoRepair.TypeFlaut, InfoRepair.Cause, InfoRepair.Note, InfoRepair.DateOut,
        //InfoRepair.DateNext, InfoRepair.Notedatanext, InfoRepair.RepairID);

        //                  using (SqlConnection con = new SqlConnection(constr))
        //                  {
        //                      SqlCommand com = new SqlCommand(query, con);
        //                      try
        //                      {
        //                          con.Open();
        //                          if (com.ExecuteNonQuery() >= 1)
        //                          {
        //                              flagAlter = true;
        //                          }
        //                      }
        //                      catch (Exception)
        //                      {
        //                      }
        //                  }
        //                  return query;
        //              }







        public ArrayList GetInfoDostup()
        {
            ArrayList infoDostup = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT name, plot, dostup, dostup_tmc, codcx, coduth, codbrig, coddet,kod_dostup_pr, ceh_dostup_pr,gosti,dostup_akt  FROM Users_list where login_user = '{0}'", Dostup.Login_user);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            infoDostup.Add(result);
                        }
                    }
                }
                catch { }
            }
            return infoDostup;
        }
        public ArrayList GetUserAndAdditionalCeh(string user)
        {
            ArrayList userList = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT codcx, coduth, codbrig FROM Users_list where login_user = '{0}' UNION SELECT codcx, coduth, codbrig FROM Users_listAdditionalCeh WHERE login_user = '{0}'",user);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            userList.Add(result);
                        }
                    }
                }
                catch { }
            }
            return userList;
        }
        public ArrayList GetUsers()
        {
            ArrayList userList = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT login_user, name as ФИО, codcx as Цех, coduth as Участок, codbrig as Бригада FROM Users_list where name not like '' and name not in('admin','asdsad') order by name");
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {
                        userList.Add(result);
                    }
                }
            }
            return userList;
        }
        public ArrayList GetAdditionalCeh(string user)
        {
            ArrayList userList = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT codcx as Цех, coduth as Участок, codbrig as Бригада FROM Users_listAdditionalCeh WHERE login_user = '{0}'", user);
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {
                        userList.Add(result);
                    }
                }
            }
            return userList;
        }
        public void AddAdditionalCeh(string user, string codcx, string coduth, string codbrig)
        {
            ArrayList userList = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("INSERT Users_listAdditionalCeh VALUES('{0}', '{1}', '{2}', '{3}')", user, codcx, coduth, codbrig);
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.ExecuteNonQuery();
            }
        }
        public void RemoveAdditionalCeh(string user, string codcx, string coduth, string codbrig)
        {
            ArrayList userList = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("DELETE FROM Users_listAdditionalCeh WHERE login_user = '{0}' and codcx = '{1}' and coduth = '{2}' and codbrig = '{3}'",user,codcx,coduth,codbrig);
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.ExecuteNonQuery();
                
            }
        }


        public bool Update_Status_Mol(string st_string, string id)
        {
            bool flagSum = false;
            
            //int stat;


            string query = string.Format("update [Repairs].[dbo].[Status_mes_MOL] set blocked= '" + st_string.ToString() + "' where id='" + id + "'");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch
                {
                    // flagSum = false;
                }
            }
            return flagSum;
        }


        //Добавление запчасти для выполнения ремонта
        public bool SaveNewReplacedPart(DateTime DatNow)
        {
            bool flagSum = false;



            string query = string.Format("insert into ReplacedPart(JobId, Quantity, RepairID, EDNOME, DateInRep, Name, Mera, Prace, DataReplace, Original, Shpz, tehno, norma, DataToday,ZAVNOM)" +
                "values ({0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}' , '{7}', '{8}', 0, '{9}', '{10}', '{11}', '{12}','{13}') update ReplacedPart set norma = null where norma = '100'  update ReplacedPart set tehno = null where tehno = '100' ",
                ReplacedPart.JobID, ReplacedPart.Quantity, InfoRepair.RepairID, ReplacedPart.EDNOME, ReplacedPart.DateInRep,
                ReplacedPart.Name.Replace("'", "^").Trim(), ReplacedPart.Mera, ReplacedPart.Prace, ReplacedPart.DateReplace, ReplacedPart.Shpz, ReplacedPart.Tehno, ReplacedPart.Norma,DatNow, ReplacedPart.Zavnom);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch
                {
                    // flagSum = false;
                }
            }
            return flagSum;
        }

        //дополнительное значение для актуализации списка запчастей... минусует их

        public double ReturnDopZnach(string prace, string date, string EDNOME, string codcx, string coduth, string codbrig, string coddet, string shpz, string zavnom )
        {
       
            double dopznach = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
//                string query = string.Format(@" SELECT SUM(Quantity)  FROM ReplacedPart WHERE (Original = 0 or Original = 1 ) AND EDNOME = '{0}' 
//AND DateInRep = '{1}' 
//and prace = '{6}'  and Shpz = {7} 
// and  RepairID in ( select RepairID from Repair where codcx = '{2}' and CODUTH = '{3}' and CODBRIG= '{4}'  and CODDET = '{5}' )", EDNOME, date, codcx, coduth, codbrig, coddet, prace, shpz);


                string query = string.Format(@" SELECT SUM(Quantity)  FROM ReplacedPart WHERE (Original = 0 or Original = 1 ) AND EDNOME = '{0}' 
AND DateInRep = '{1}' 
and prace = '{6}'  and Shpz = '{7}'  and trim(Zavnom)='{8}' 
 and  RepairID in ( select RepairID from Repair where codcx = '{2}' and CODUTH = '{3}' and CODBRIG= '{4}'  and CODDET = '{5}'  )", EDNOME, date, codcx, coduth, codbrig, coddet, prace, shpz,zavnom.Trim());                
                

                //CODCX, CODUTH, CODBRIG, CODDET, EDNOME, SHPZ, DATSHOP, DATA, NAME, MERA, PRACE, SHPZ, texsod, norma
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (Convert.ToDouble(com.ExecuteScalar()) == null)
                    {
                        dopznach = 0;
                    }
                    else
                    {
                        dopznach = Convert.ToDouble(com.ExecuteScalar());
                    }


                }
                catch
                {
                    dopznach = 0;
                }

            }

            return dopznach;
        }




        public double ReturnSumReplaceParts(string invnum, string objekt,string year_date2, string month_date2)
        {
            double SumRepPart = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("select sum(rp.Quantity*rp.Prace) as ss  from Vedomost_Resursov vr  left join ReplacedPart rp on vr.ID=rp.VedomostNumber where vr.InventoryNamber='{0}' and  vr.Obekt='{1}' and year(vr.PeriodData2)='{2}' and month(vr.PeriodData2)='{3}' group by vr.InventoryNamber,vr.NameOS", invnum, objekt,year_date2, month_date2);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SumRepPart = Convert.ToDouble(com.ExecuteScalar());
                }
                catch
                {
                    SumRepPart = 0;
                }
            }
            return SumRepPart;
        }


        //Ищем места куда устанавливать
        public ArrayList GetALLRefPlace()
        {
            ArrayList allRefPlace = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT PlaceCode, PlaceName FROM RefPlace";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allRefPlace.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allRefPlace;
        }



        public bool SaveNewPlacePart(string PlaceCode, string Replaced_ID)
        {
            bool flagSum = false;
            string query = string.Format(" insert into PlacePart (PlaceCode, ReplacedId) values('{0}', '{1}')", PlaceCode, Replaced_ID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //удаление отправки в ремонт
        public bool DeleteRepair(String RepairID)
        {
            bool flagDel = false;
            string query = string.Format("  delete from Repair where (RepairID = '{0}' and dataNext is null and DateOut is null and (CODCX  is null or CODCX='') and (coduth is null or coduth='') and (coddet is null or coddet='') and ((select top 1  count(JobId) from Job where RepairId = '{0}') = 0))", RepairID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagDel = true;
                    }
                }
                catch { }

            }

            return flagDel;
        }

        //удаление места установки
        public bool DeletePlacePart(String ReplacedID, string PlaceCode)
        {
            bool flagDel = false;
            string query = string.Format("  delete PlacePart where ReplacedId = '{0}' and PlaceCode = '{1}'", ReplacedID, PlaceCode);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() > 1)
                    {
                        flagDel = true;
                    }
                }
                catch { }
            }
            return flagDel;
        }

        //Удаление запчасти
        public bool DeleteReplacedPart(String ReplacedID)
        {
            bool flagDel = false;
            string query = string.Format("delete ReplacedPart where ReplacedId = '{0}' and (Original is null or Original = 0 or Original = 1)", ReplacedID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagDel = true;
                    }
                }
                catch { }
            }
            return flagDel;
        }
        //Удаление выполняемой работы
        public bool DeleteJob(String JobID)
        {
            bool flagDel = false;
            string query = string.Format("delete Job where JobId = '{0}'", JobID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() > 1)
                    {
                        flagDel = true;
                    }
                }
                catch { }
            }
            return flagDel;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Вывести возвратный металлолом
        public ArrayList GetAllVozvrMet()
        {
            ArrayList allVozvrMet = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT ID, Name, EdIzm, Price, Quantity, Sum, Note, DataVozvr, original FROM VozvrMet where  RepairID = '{0}' ", InfoRepair.RepairID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allVozvrMet.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allVozvrMet;
        }

        //and isnull(Repair.Obekt,0) = isnull('{1}',0)))
        //Вывести возвратный металлолом по ОС
        public ArrayList GetAllVozvrMetforOS()
        {
            ArrayList allVozvrMet = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format(@"SELECT ID, Name, EdIzm, Price, Quantity, Sum, Note, DataVozvr 
                                                       FROM VozvrMet where RepairID in (select Repair.RepairID from Repair 
                    where Repair.InventoryNumber = '{0}' and isnull(Repair.Obekt,0) = isnull('{1}',0) and Repair.Codcx = '{2}'and Repair.Coduth = '{3}'
and Repair.Codbrig = '{4}'and Repair.coddet = '{5}') and Original = 0", InfoRepair.InventotyNomber, InfoRepair.Obekt, InfoRepair.CODCX, InfoRepair.CODUTH,
                                                              InfoRepair.CODBRIG, InfoRepair.CODDET);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allVozvrMet.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allVozvrMet;
        }




        //Добавить возвратный металлолом
        public bool SavevozvrMet(string EdNumber, string EdIzm, string Price, string Quantity, string Sum, string Note, string DataDozvr)
        {
            bool flagSum = false;
            string query = string.Format(@"insert into VozvrMet ( EdNumber, EdIzm, Price, Quantity, Sum, Note, DataVozvr, DataToday, Original, RepairID, Name )
                                                 values( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}',	'{6}', getdate(),  0 , '{7}', (select top 1 Name from TypeMetall where EdNumber = '{0}') )", EdNumber, EdIzm, Price, Quantity, Sum, Note, DataDozvr, InfoRepair.RepairID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        //удалить возвратный металлолом

        public bool DeleteVozvrMet(String VozvrID)
        {
            bool flagDel = false;
            string query = string.Format("  delete from VozvrMet where (ID = '{0}' and Original = 0)", VozvrID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagDel = true;
                    }
                }
                catch { }

            }

            return flagDel;
        }
        //Вывод единиц измерения
        public ArrayList GetAllEdIzm()
        {
            ArrayList allEdIzm = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("Select Name from EdIzm");
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allEdIzm.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allEdIzm;
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        //отображение возвратных деталей
        public ArrayList GetAllVozvrDet()
        {
            ArrayList allVozvrDet = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT ID, Name,  Quantity, Note, DataVozvr, original,DataToday FROM VozvrDet where RepairID = '{0}'", InfoRepair.RepairID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allVozvrDet.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allVozvrDet;
        }

        //отображение возвратных деталей по ОС
        public ArrayList GetAllVozvrDetforOS()
        {
            ArrayList allVozvrDet = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format(@"sELECT ID, Name,  Quantity, Note, DataVozvr FROM VozvrDet where RepairID in (select Repair.RepairID 
        from Repair where  Repair.InventoryNumber = '{0}' and isnull(Repair.Obekt,0) = isnull('{1}',0) and Repair.codcx = '{2}'and Repair.coduth = '{3}'
                            and Repair.codbrig = '{4}'and Repair.coddet = '{5}') and original = 0", InfoRepair.InventotyNomber, InfoRepair.Obekt, InfoRepair.CODCX, InfoRepair.CODUTH,
                                                                         InfoRepair.CODBRIG, InfoRepair.CODDET);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allVozvrDet.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allVozvrDet;
        }







        //добавление возвратной детали
        public bool SavevozvrDet(string Name, string Quantity, string Note, string DataDozvr, string Ednome,DateTime DatNow)
        {
            bool flagSum = false;
            string query = string.Format("insert into VozvrDet (Name, Quantity, Note, DataVozvr,  Original, RepairID, EdNumber,DataToday)" +
                                         "values( '{0}', '{1}', '{2}', '{3}', 0 , '{4}', '{5}','{6}')", Name, Quantity, Note, DataDozvr, InfoRepair.RepairID, Ednome, DatNow);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //удаление возвратной детали
        public bool DeleteVozvrDet(String VozvrID)
        {
            bool flagDel = false;
            string query = string.Format(@"  delete from VozvrDet where (ID = '{0}'
--                   and Original = 0
)", VozvrID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagDel = true;
                    }
                }
                catch { }

            }

            return flagDel;
        }

        //Выбор ремонтов по которым могут быть списания
        public ArrayList GetAllRepairForVedomost()
        {
            ArrayList AllRepair = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = @"SELECT
      DISTINCT Repair.RepairID, Repair.InventoryNumber, Repair.Obekt, Repair.RDivision, Repair.Division, Repair.DateIn, Repair.DateOut, 
	  Repair.TypeFlaut, Repair.Cause, Repair.Note, Repair.Responsible,  A.StoreName, B.StoreName, SprOS.Name, Repair.dataNext, 
	  Repair.NotedataNext, Repair.CODCX, Repair.CODUTH, Repair.CODBRIG,  Repair.CODDET,  Repair.NAMEDET
         FROM Repair 
			  left join SprOS on Repair.InventoryNumber = SprOS.InventoryNumber and SprOS.Obekt = isnull(Repair.Obekt,0)
              left join Store A on Repair.RDivision = A.StoreID 
              left join ReplacedPart on ReplacedPart.RepairID = Repair.RepairID
              left join Store B on Repair.Division = B.StoreID 
            where  ReplacedPart.Original = 0 and ReplacedPart.TypeRepPartID is null and " + Dostup.AddQueryAddRepairVedRes() + "   order by Repair.DateOut ";
            //+Dostup.AddQueryAddRepair() + " and ReplacedPart.Original = 0 and ReplacedPart.TypeRepPartID is null " + " order by Repair.DateOut ";

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepair.Add(result);
                }
            }
            con.Close();
            return AllRepair;
        }


        //Выбор ремонтов по которым могут быть списания 7777777777
        public ArrayList GetAllUslForDokument()
        {
            ArrayList AllRepair = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = @"SELECT
      DISTINCT Repair.RepairID, Repair.InventoryNumber, Repair.Obekt, Repair.RDivision, Repair.Division, Repair.DateIn, Repair.DateOut, 
	    A.StoreName as ispolnitel, B.StoreName as zakazchik, SprOS.Name as nameOS,  
	   Repair.CODCX, Repair.CODUTH, Repair.CODBRIG,  Repair.CODDET,  Repair.NAMEDET, Repair.Inv_usl, Repair.Obekt_usl,OS_for_usl.name as name_inv_usl
         FROM Repair 
			  left join SprOS on Repair.InventoryNumber = SprOS.InventoryNumber and SprOS.Obekt = isnull(Repair.Obekt,0)
              left join SprOS OS_for_usl on Repair.Inv_usl = OS_for_usl.InventoryNumber and OS_for_usl.Obekt = isnull(Repair.Obekt_usl,0)              
              left join Store A on Repair.RDivision = A.StoreID 
              left join Akti_Usl on Akti_Usl.RepairID = Repair.RepairID
              left join Store B on Repair.Division = B.StoreID 
			  left join job on Repair.RepairID=job.RepairId
            where  Job.JobCode=39 and Repair.RepairID not in (select RepairID from Akti_Usl) and " + Dostup.AddQueryAddRepairVedRes() + "   order by Repair.InventoryNumber ";
            //+Dostup.AddQueryAddRepair() + " and ReplacedPart.Original = 0 and ReplacedPart.TypeRepPartID is null " + " order by Repair.DateOut ";

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepair.Add(result);
                }
            }
            con.Close();
            return AllRepair;
        }


        //Выбор ремонтов по ОС
        public ArrayList GetAllRepairForVedomostForOS()
        {
            ArrayList AllRepair = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = @"SELECT
    DISTINCT Repair.InventoryNumber, isnull(Repair.Obekt,0) as Obekt, SprOS.Name, Repair.CODDET, Repair.CODCX, Repair.CODBRIG, Repair.CODUTH
       FROM Repair 
	   left join SprOS on Repair.InventoryNumber = SprOS.InventoryNumber and SprOS.Obekt = isnull(Repair.Obekt,0)
       left join Store A on Repair.RDivision = A.StoreID
       left join ReplacedPart on ReplacedPart.RepairID = Repair.RepairID
       left join Store B on Repair.Division = B.StoreID 
                                   where ReplacedPart.Original = 0 and ReplacedPart.TypeRepPartID is null and  " + Dostup.AddQueryAddRepairVedRes();
            //+ " order by Repair.DateOut ";

            //--, Repair.RepairID,  Repair.RDivision, Repair.Division, Repair.DateIn, Repair.DateOut, Repair.TypeFlaut, Repair.Cause, Repair.Note, Repair.Responsible,  A.StoreName, B.StoreName, SprOS.Name, Repair.dataNext, Repair.NotedataNext, Repair.CODCX, Repair.CODUTH, Repair.CODBRIG,  Repair.CODDET,  Repair.NAMEDET 
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepair.Add(result);
                }
            }
            con.Close();
            return AllRepair;
        }


// Kudina begin
        //ПТО

        public ArrayList GetForPTO()
        {
            ArrayList AllRepairPTO = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = @"SELECT * from Repair";

            //+ " order by Repair.DateOut ";

            //--, Repair.RepairID,  Repair.RDivision, Repair.Division, Repair.DateIn, Repair.DateOut, Repair.TypeFlaut, Repair.Cause, Repair.Note, Repair.Responsible,  A.StoreName, B.StoreName, SprOS.Name, Repair.dataNext, Repair.NotedataNext, Repair.CODCX, Repair.CODUTH, Repair.CODBRIG,  Repair.CODDET,  Repair.NAMEDET 
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepairPTO.Add(result);
                }
            }
            con.Close();
            return AllRepairPTO;
        }


   
  // Kudina end




        



        //Выборка для запасных частей по ремонту
        public ArrayList GetRepPlaceForRepairVedRes()
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = string.Format("  SELECT ReplacedId, JobId, RepairID, ReplacedPart.PartId, Quantity, ReplacedId, " +
"Name, Mera, EDNOME, DateInRep, DataReplace, Original, Prace, SHPZ " +
"FROM  ReplacedPart " +
"where Original = 0 and ReplacedPart.TypeRepPartID is null and RepairID = '{0}'", InfoRepair.RepairID, InfoRepair.Obekt);
            Debug.WriteLine("----");
            Debug.WriteLine(query);
            Debug.WriteLine("----");
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }

        //выюор запасных частей для ведомости ресурсов для ОС
        //Выборка для запасных частей по ремонту
        public ArrayList GetRepPlaceForOSVedRes()
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = string.Format(@"Select  JobId, RepairID, PartId, Quantity, ReplacedId, 
  Name, Mera, EDNOME, DateInRep, DataReplace, Original, Prace, SHPZ,Zavnom from ReplacedPart 
where original = 0 and RepairID is not null and ReplacedPart.TypeRepPartID is null and RepairID in (select Repair.RepairID from Repair where (Repair.InventoryNumber = '{0}' and isnull(Repair.Obekt,0) = isnull('{1}',0) and Repair.codcx = '{2}'
and Repair.coduth = '{3}'and Repair.codbrig = '{4}'and Repair.coddet = '{5}'))", InfoRepair.InventotyNomber, InfoRepair.Obekt, InfoRepair.CODCX, InfoRepair.CODUTH,
                                                                    InfoRepair.CODBRIG, InfoRepair.CODDET);

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }





        ///добавляем БУ деталь
        ///
        public bool AddNewBUReplacedPart(string txt_NumberAct, string txt_NameRepPart, string txt_VesEd, string cbx_Ed_Izm,
        string txtKolvo, string txt_ProcIznos, string txt_PriceNewTMC, string txt_PriceIznos, string txt_PriceMet1Ton)
        {
            bool flagDel = false;
            string query = string.Format("  INSERT INTO B_U_Form_ACT (ActID, [NameTMC],[Ves_TMC],[ed_izm_TMC],[Kol-voTMC],[Proc_iznos]," +
   "[PriceNewTMC],[PriceIznosTMC],[PriceTonnaMet],[Original]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','0')",
             txt_NumberAct, txt_NameRepPart, txt_VesEd, cbx_Ed_Izm,
        txtKolvo, txt_ProcIznos, txt_PriceNewTMC, txt_PriceIznos, txt_PriceMet1Ton);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagDel = true;
                    }
                }
                catch { }

            }

            return flagDel;

        }


        public string AddNewBUReplacedPartQuery(string txt_NameOS, string txt_invNumberOS, string txt_FIO_Pred, string txt_dolj_pred,
  string txt_FIO_Chlen1, string txt_doljChlen1, string txt_Fio_Chlen2, string txt_doljChlen2,
  string dtp_date, string txt_NameRepPart, string txt_VesEd, string cbx_Ed_Izm,
  string txtKolvo, string txt_ProcIznos, string txt_PriceNewTMC, string txt_PriceIznos, string txt_PriceMet1Ton)
        {
            bool flagDel = false;
            string query = string.Format("  INSERT INTO B_U_Form_ACT ([NameOS],[InvNumberOS],[FIO_Pred],[State_Pred], " +
   "[FIO_Chlen1],[StateChlen1],[FIO_Chlen2],[StateChlen2],[date_doc],[NameTMC],[Ves_TMC],[ed_izm_TMC],[Kol-voTMC],[Proc_iznos]," +
   "[PriceNewTMC],[PriceIznosTMC],[PriceTonnaMet],[Original]) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}," +
            " {11},{12},{13},{14},{15},{16}, 0)", txt_NameOS, txt_invNumberOS, txt_FIO_Pred, txt_dolj_pred,
         txt_FIO_Chlen1, txt_doljChlen1, txt_Fio_Chlen2, txt_doljChlen2,
         dtp_date, txt_NameRepPart, txt_VesEd, cbx_Ed_Izm,
        txtKolvo, txt_ProcIznos, txt_PriceNewTMC, txt_PriceIznos, txt_PriceMet1Ton);
            using (SqlConnection con = new SqlConnection(constr))
                //{
                //    SqlCommand com = new SqlCommand(query, con);
                //    try
                //    {
                //        con.Open();
                //        if (com.ExecuteNonQuery() >= 1)
                //        {
                //            flagDel = true;
                //        }
                //    }
                //    catch { }

                //}

                return query;

        }


        //выбор списаных запчастей под акт
        public ArrayList GetBU_Rep_Part(string txtNumberAct)
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = string.Format(" SELECT NameTMC, Ves_TMC, ed_izm_TMC, [Kol-voTMC], Proc_iznos, PriceNewTMC, " +
" PriceIznosTMC, PriceTonnaMet FROM B_U_Form_ACT where ActID= '{0}' ", txtNumberAct);

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }
        //Показываем строку запроса

        //          public string GetBU_Rep_Partquery(string date, string fiopred, string invnumberOS)
        //          {
        //              ArrayList AllRepPl = new ArrayList();
        //              SqlConnection con = new SqlConnection(constr);
        //              string query = string.Format(" SELECT NameTMC, Ves_TMC, ed_izm_TMC, [Kol-voTMC], Proc_iznos, PriceNewTMC, " +
        //" PriceIznosTMC, PriceTonnaMet FROM B_U_Form_ACT where date_doc = '{0}' and InvNumberOS ='{1}' and FIO_Pred = '{2}' ", date, invnumberOS, fiopred);

        //              //SqlCommand com = new SqlCommand(query, con);
        //              //con.Open();
        //              //SqlDataReader dr = com.ExecuteReader();
        //              //if (dr.HasRows)
        //              //{
        //              //    foreach (DbDataRecord result in dr)
        //              //    {
        //              //        AllRepPl.Add(result);
        //              //    }
        //              //}
        //              //con.Close();
        //              return query;
        //          }

        //создание акта на оприходывание
        public bool CreateNewAct(string txt_NameOS, string txt_invNumberOS, string txt_FIO_Pred, string txt_dolj_pred,
  string txt_FIO_Chlen1, string txt_doljChlen1, string txt_Fio_Chlen2, string txt_doljChlen2,
  string dtp_date)
        {
            bool flagSum = false;
            string query = string.Format("insert into Acts ([NameOS],[InvNumberOS],[FIO_Pred],[State_Pred], " +
   "[FIO_Chlen1],[StateChlen1],[FIO_Chlen2],[StateChlen2],[date_doc], Original)" +
"values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',0)", txt_NameOS, txt_invNumberOS, txt_FIO_Pred, txt_dolj_pred,
         txt_FIO_Chlen1, txt_doljChlen1, txt_Fio_Chlen2, txt_doljChlen2,
         dtp_date);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //Получаем номер акта на оприходывание
        public int ReturnActNumber()
        {
            int dopznach = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = @" SELECT max(ID)  FROM Acts";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    dopznach = Convert.ToInt32(com.ExecuteScalar());
                }
                catch
                {
                    dopznach = 0;
                }
            }
            return dopznach;
        }

        public string CreateNewActquery(string txt_NameOS, string txt_invNumberOS, string txt_FIO_Pred, string txt_dolj_pred,
string txt_FIO_Chlen1, string txt_doljChlen1, string txt_Fio_Chlen2, string txt_doljChlen2,
string dtp_date)
        {
            bool flagSum = false;
            string query = string.Format("insert into Actr ([NameOS],[InvNumberOS],[FIO_Pred],[State_Pred], " +
   "[FIO_Chlen1],[StateChlen1],[FIO_Chlen2],[StateChlen2],[date_doc], Original)" +
"values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',0)", txt_NameOS, txt_invNumberOS, txt_FIO_Pred, txt_dolj_pred,
         txt_FIO_Chlen1, txt_doljChlen1, txt_Fio_Chlen2, txt_doljChlen2,
         dtp_date);
            return query;
        }

        public string AddNewBUReplacedPartquery1(string txt_NumberAct, string txt_NameRepPart, string txt_VesEd, string cbx_Ed_Izm,
string txtKolvo, string txt_ProcIznos, string txt_PriceNewTMC, string txt_PriceIznos, string txt_PriceMet1Ton)
        {
            bool flagDel = false;
            string query = string.Format("  INSERT INTO B_U_Form_ACT (ActID, [NameTMC],[Ves_TMC],[ed_izm_TMC],[Kol-voTMC],[Proc_iznos]," +
   "[PriceNewTMC],[PriceIznosTMC],[PriceTonnaMet],[Original]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','0'",
             txt_NumberAct, txt_NameRepPart, txt_VesEd, cbx_Ed_Izm,
        txtKolvo, txt_ProcIznos, txt_PriceNewTMC, txt_PriceIznos, txt_PriceMet1Ton);
            return query;

        }


        //Выбор списка актов
        public ArrayList GetAllActs()
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = @" SELECT ID ,NameOS ,InvNumberOS,date_doc , Original,[FIO_Pred],[State_Pred],[FIO_Chlen1],[StateChlen1],[FIO_Chlen2],[StateChlen2] FROM Acts ";

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }

        //Создание новой ведомости ресурсов для ремонта
        public bool CreateNewVedomodtResursov(string RepairID, string dtp_date1, string dtp_date2, int kod_rem, int id_zameni, bool zaversh)
        {
            bool flagSum = false;
            string query = string.Format(@"  
  declare @RepairId int 
  declare @dtp_date1 date
  declare @dtp_date2 date
  declare @kod_rem int
  declare @DatBegRem date
  declare @DatEndRem date
  declare @srok_zameni int
  declare @zaversh bit

  set @RepairId = '{0}' 
  set @dtp_date1 = '{1}'
  set @dtp_date2 = '{2}' 
  set @kod_rem='{3}'
  set @srok_zameni='{4}'
  set @zaversh='{5}'

  INSERT INTO Vedomost_Resursov(
   [RepairID],
   [kod_rem],
   [InventoryNamber],
   [NameOS],
   [PeriodData1],
   [PeriodData2],
   [Zakazchik_codcx],
   [Zakazchik_coduth],
   [Ispolnitel_codcx],
   [Ispolnitel_coduth],
   [Ispolnitel_codbrig],
   [Ispolnitel_coddet],
   [Ispolnitel_Name],
   [VedomostNumber],
   [Original],
   [Zakazchik_codbrig], 
   [Zakazchik_coddet],
   Obekt,
   KodKontrAgent,
   NameKontragent,
   EdrpouKontragent,
   srok_zameni,
   zaversh
   )VALUES
( @RepairId,@kod_rem, 
(select InventoryNumber from Repair where RepairID = @RepairId),
(select Name from SprOS where InventoryNumber = (select InventoryNumber from Repair where RepairID = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)),
@dtp_date1, 
@dtp_date2, 
(select StoreId from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0) ), 
(select CODUTH from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)),
(select codcx from Repair where RepairID = @RepairId),
(select CODUTH from Repair where RepairID = @RepairId),
(select CODBRIG from Repair where RepairID = @RepairId),
(select CODDET from Repair where RepairID = @RepairId),
(select NAMEDET from Repair where RepairID = @RepairId),
0, 
0, 
(select CODBRIG from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)), 
(select CODDET from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)) ,
(select isnull(Obekt,0) from Repair where RepairId = @RepairId), 
 (select isnull(KodKontrAgent,'') from Repair where RepairId = @RepairId)   ,
  (select isnull(NameKontragent,'') from Repair where RepairId = @RepairId) ,
  (select isnull(EdrpouKontragent,'') from Repair where RepairId = @RepairId),@srok_zameni,@zaversh  )   ", RepairID, dtp_date1, dtp_date2, kod_rem, id_zameni, zaversh);

            
           // throw new NotImplementedException();

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        //Создание нового документа по услугам
        public bool CreateNewDokUsl(string RepairID, string dtp_date1, string dtp_date2)
        {
            bool flagSum = false;
            string query = string.Format(@"  
  declare @RepairId int 
  declare @dtp_date1 date
  declare @dtp_date2 date

  set @RepairId = '{0}' 
  set @dtp_date1 = '{1}'
  set @dtp_date2 = '{2}' 

  INSERT INTO Akti_Usl([RepairID],[kod_rem],[InventoryNamber],[NameOS],[PeriodData1],
   [PeriodData2],[Zakazchik_codcx],[Zakazchik_coduth],[Ispolnitel_codcx],[Ispolnitel_coduth],[Ispolnitel_codbrig],[Ispolnitel_coddet],
   [Ispolnitel_Name],[VedomostNumber],[Original],[Zakazchik_codbrig],[Zakazchik_coddet],Obekt,Inv_usl,Obekt_usl,Name_inv_usl)VALUES
   (
   @RepairId ,
   9 , 
   (select InventoryNumber from Repair where RepairID = @RepairId) ,
   (select Name from SprOS where InventoryNumber = (select InventoryNumber from Repair where RepairID = @RepairId) and Obekt = isnull   ((select Obekt from Repair where RepairId = @RepairId),0) )  , 
   @dtp_date1  , @dtp_date2 , 
   (select Division from Repair where RepairID = @RepairId) , 
   0 ,
   (select codcx from Repair where RepairID = @RepairId) ,
   (select CODUTH from Repair where RepairID = @RepairId) ,
   (select CODBRIG from Repair where RepairID = @RepairId),
   (select CODDET from Repair where RepairID = @RepairId) ,
   (select NAMEDET from Repair where RepairID = @RepairId),
   0 ,
   0 ,
   0 , 
   0 ,
   (select Obekt from Repair where RepairId = @RepairId),
   (select Inv_usl from Repair where RepairId = @RepairId),
   (select Obekt_usl from Repair where RepairId = @RepairId),
   (select Name from SprOS where InventoryNumber = (select Inv_usl from Repair where RepairId = @RepairId)  and  obekt=(select Obekt_usl from Repair where RepairId = @RepairId))
) 
", RepairID, dtp_date1, dtp_date2);


            // throw new NotImplementedException();

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }
        
        
        //обновляем значение в таблице заменяемых запчастей параметры оригинала и номера ведомости ресурсов

        public bool UpdateRepPlaceVedRes(string ReplacedId, string NumberVedomost)
        {
            bool flagSum = false;
            string query = string.Format("update ReplacedPart set Original = 1, VedomostNumber = '{0}' where ReplacedId = '{1}'", NumberVedomost, ReplacedId);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //Тоже самое в возвратном металлоломе
        public bool UpdateRepPlaceVedVozvrMet(string VedMet, string NumberVedomost)
        {
            bool flagSum = false;
            string query = string.Format("  update VozvrMet set Original = 1, VedomostNumber = '{0}' where ID = '{1}'", NumberVedomost, VedMet);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //Тоже самое в возвратных запчастях
        public bool UpdateRepPlaceVedVozvrDet(string VedMet, string NumberVedomost)
        {
            bool flagSum = false;
            string query = string.Format("  update VozvrDet set Original = 1, VedomostNumber = '{0}' where ID = '{1}'", NumberVedomost, VedMet);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }


        //Получаем максимальное значение ведомости ресурсов
        public int ReturnVedomostNumber()
        {
            int dopznach = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = @" SELECT max(ID)  FROM Vedomost_Resursov";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    dopznach = Convert.ToInt32(com.ExecuteScalar());
                }
                catch
                {
                    dopznach = 0;
                }
            }
            return dopznach;
        }

        public string GetAllJobForRepairqUERY(string RepairID)
        {
            //throw new NotImplementedException();
            ArrayList allJobs = new ArrayList();
            string query = string.Format("SELECT Job.JobId, Job.RepairId, Job.JobCode, RefJob.JobName, RefJob.T_Inspect FROM Job INNER JOIN  RefJob ON Job.JobCode = RefJob.JobCode WHERE Job.RepairId='{0}'", RepairID);
            //using (SqlConnection con = new SqlConnection(constr)) {
            //    string query = string.Format("SELECT Job.JobId, Job.RepairId, Job.JobCode, RefJob.JobName, RefJob.T_Inspect FROM Job INNER JOIN  RefJob ON Job.JobCode = RefJob.JobCode WHERE Job.RepairId='{0}'", RepairID );
            //    SqlCommand com = new SqlCommand(query, con);
            //    ////try
            //    ////{
            //    ////    con.Open();
            //    ////    SqlDataReader dr = com.ExecuteReader();
            //    ////    if (dr.HasRows) {
            //    ////        foreach (DbDataRecord result in dr) {
            //    ////            allJobs.Add(result);                        
            //    ////        }
            //    ////    }
            //    ////}
            //    ////catch {    }            
            //}
            return query;
        }

        //Выбор всех ведомостей ресурсов
        public ArrayList GetAllVedomostsResursov(string PeriodData2_1, string PeriodData2_2)
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string pp = Dostup.AddQueryVedRes();
            string query;
            string data1 = PeriodData2_1;
            string data2 = PeriodData2_2;

            if (Change_ceh.ALL)
            {
                query = @"SELECT x.kol, y.kol1, [ID]
      ,[RepairID]
      ,vr.[InventoryNamber]
      ,[NameOS]
	  ,vr.obekt
      ,[PeriodData1]
      ,[PeriodData2]
      ,[Shpz]
      ,[Zakazchik_codcx]
      ,[Zakazchik_coduth]
      ,[Zakazchik_codbrig]
      ,[Zakazchik_coddet]
      ,[Ispolnitel_codcx]
      ,[Ispolnitel_coduth]
      ,[Ispolnitel_codbrig]
      ,[Ispolnitel_coddet]
      ,[Ispolnitel_Name]
      ,[VedomostNumber]
      ,[Original]
      ,[dolg2]
      ,[FIO2]
      ,[dolg1]
      ,[FIO1], dolg3, fio3, dolg4, fio4 ,[dolg2f2]
      ,[FIO2f2]
      ,[dolg1f2]
      ,[FIO1f2], dolg3f2, fio3f2, dolg4f2, fio4f2, dolg5f2, fio5f2,isnull(kod_rem,1) as kod_rem
      ,[cexVitrProc]
      ,[amortProc]
      ,[vsegoZP]
      ,[sumNalogov]
      ,[TZV]
      ,spros.b_bal_cena
      ,VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F,zaversh,IsCapital
  FROM Vedomost_Resursov vr
  inner join (SELECT InventoryNamber, obekt, count(*) as kol,
				YEAR(PeriodData1) as god, MONTH(PeriodData1) as nonth,
				Ispolnitel_codcx as isp 
				FROM Vedomost_Resursov
				where id is not null
				group by [InventoryNamber], obekt,
				YEAR(PeriodData1), MONTH(PeriodData1),Ispolnitel_codcx
	) x on vr.InventoryNamber = x.InventoryNamber and  isnull(vr.obekt,0) = isnull(x.obekt,0) and   YEAR(vr.PeriodData1) = god and MONTH(vr.PeriodData1) = nonth and vr.Ispolnitel_codcx = isp 
  
left join spros on vr.InventoryNamber =spros.InventoryNumber  and vr.obekt =spros.obekt
inner join (SELECT InventoryNamber, obekt, count(*) as kol1,
				YEAR(PeriodData1) as god1, MONTH(PeriodData1) as nonth1
				--Ispolnitel_codcx as isp1 
				FROM Vedomost_Resursov
				where id is not null
				group by [InventoryNamber], obekt,
				YEAR(PeriodData1), MONTH(PeriodData1)
	) y on vr.InventoryNamber = y.InventoryNamber and  isnull(vr.obekt,0) = isnull(y.obekt,0) and   YEAR(vr.PeriodData1) = god1 and MONTH(vr.PeriodData1) = nonth1
  where id is not null  " + pp + " and ((vr.PeriodData1>='" + @PeriodData2_1 + "' and vr.PeriodData1<='" + @PeriodData2_2 + "') or (vr.PeriodData2>='" + @PeriodData2_1 + "' and vr.PeriodData2<='" + @PeriodData2_2 + "'))  order by id desc";
                //Debug.Write(query);
            }
            else
            {
                query = @"SELECT x.kol, y.kol1, [ID]
      ,[RepairID]
      ,vr.[InventoryNamber]
      ,[NameOS]
	  ,vr.obekt
      ,[PeriodData1]
      ,[PeriodData2]
      ,[Shpz]
      ,[Zakazchik_codcx]
      ,[Zakazchik_coduth]
      ,[Zakazchik_codbrig]
      ,[Zakazchik_coddet]
      ,[Ispolnitel_codcx]
      ,[Ispolnitel_coduth]
      ,[Ispolnitel_codbrig]
      ,[Ispolnitel_coddet]
      ,[Ispolnitel_Name]
      ,[VedomostNumber]
      ,[Original]
      ,[dolg2]
      ,[FIO2]
      ,[dolg1]
      ,[FIO1], dolg3, fio3, dolg4, fio4 ,[dolg2f2]
      ,[FIO2f2]
      ,[dolg1f2]
      ,[FIO1f2], dolg3f2, fio3f2, dolg4f2, fio4f2, dolg5f2, fio5f2,isnull(kod_rem,1) as kod_rem
      ,[cexVitrProc]
      ,[amortProc]
      ,[vsegoZP]
      ,[sumNalogov]
      ,[TZV]
      ,spros.b_bal_cena
      , VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F,zaversh,IsCapital
  FROM Vedomost_Resursov vr
  inner join (SELECT InventoryNamber, obekt, count(*) as kol,
				YEAR(PeriodData1) as god, MONTH(PeriodData1) as nonth,
				Ispolnitel_codcx as isp 
				FROM Vedomost_Resursov
				where id is not null
				group by [InventoryNamber], obekt,
				YEAR(PeriodData1), MONTH(PeriodData1),Ispolnitel_codcx
	) x on vr.InventoryNamber = x.InventoryNamber and  isnull(vr.obekt,0) = isnull(x.obekt,0) and   YEAR(vr.PeriodData1) = god and MONTH(vr.PeriodData1) = nonth and vr.Ispolnitel_codcx = isp 
  
left join spros on vr.InventoryNamber =spros.InventoryNumber  and vr.obekt =spros.obekt
inner join (SELECT InventoryNamber, obekt, count(*) as kol1,
				YEAR(PeriodData1) as god1, MONTH(PeriodData1) as nonth1
				--Ispolnitel_codcx as isp1 
				FROM Vedomost_Resursov
				where id is not null
				group by [InventoryNamber], obekt,
				YEAR(PeriodData1), MONTH(PeriodData1)
	) y on vr.InventoryNamber = y.InventoryNamber and  isnull(vr.obekt,0) = isnull(y.obekt,0) and   YEAR(vr.PeriodData1) = god1 and MONTH(vr.PeriodData1) = nonth1
  where id is not null  and Ispolnitel_codcx=" + Change_ceh.CEH + " " + pp + " and ((vr.PeriodData1>='" + @PeriodData2_1 + "' and vr.PeriodData1<='" + @PeriodData2_2 + "')  or (vr.PeriodData2>='" + @PeriodData2_1 + "' and vr.PeriodData2<='" + @PeriodData2_2 + "')) order by id desc";
                //Debug.Write(query);
            }
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                foreach (DbDataRecord result in dr)
                {

                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }






        public ArrayList GetAllAktsUsl(string PeriodData2_1, string PeriodData2_2)
        {
            ArrayList All_akt_usl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string pp = Dostup.AddQueryVedRes();
            string query;
            string data1 = PeriodData2_1;
            string data2 = PeriodData2_2;

            if (Change_ceh.ALL)
            {
                query = @"SELECT [ID] ,[RepairID] ,[InventoryNamber] ,[NameOS] ,obekt,[PeriodData1] ,[PeriodData2] ,[Shpz] ,[Zakazchik_codcx],[Zakazchik_coduth] ,[Zakazchik_codbrig] ,[Zakazchik_coddet] 
      ,[Ispolnitel_codcx],[Ispolnitel_coduth] ,[Ispolnitel_codbrig] ,[Ispolnitel_coddet],[Ispolnitel_Name],[VedomostNumber],[Original]
      ,[dolg2],[FIO2] ,[dolg1],[FIO1], dolg3, fio3, dolg4, fio4 ,[dolg2f2],[FIO2f2] ,[dolg1f2],[FIO1f2], dolg3f2, fio3f2, dolg4f2, fio4f2, dolg5f2, fio5f2,kod_rem as kod_rem
      ,[cexVitrProc],[amortProc],[vsegoZP],[sumNalogov],[TZV] ,VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F,zaversh,inv_usl,obekt_usl,name_inv_usl
      FROM [Repairs].[dbo].[Akti_usl]  where kod_rem=9 and  id is not null  " + pp + " and ((PeriodData1>='" + @PeriodData2_1 + "' and PeriodData1<='" + @PeriodData2_2 + "') or (PeriodData2>='" + @PeriodData2_1 + "' and PeriodData2<='" + @PeriodData2_2 + "'))  order by id desc";
                //Debug.Write(query);
            }
            else
            {
                query = @"SELECT [ID] ,[RepairID] ,[InventoryNamber] ,[NameOS] ,obekt,[PeriodData1] ,[PeriodData2] ,[Shpz] ,[Zakazchik_codcx],[Zakazchik_coduth] ,[Zakazchik_codbrig] ,[Zakazchik_coddet] 
      ,[Ispolnitel_codcx],[Ispolnitel_coduth] ,[Ispolnitel_codbrig] ,[Ispolnitel_coddet],[Ispolnitel_Name],[VedomostNumber],[Original]
      ,[dolg2],[FIO2] ,[dolg1],[FIO1], dolg3, fio3, dolg4, fio4 ,[dolg2f2],[FIO2f2] ,[dolg1f2],[FIO1f2], dolg3f2, fio3f2, dolg4f2, fio4f2, dolg5f2, fio5f2,kod_rem as kod_rem
      ,[cexVitrProc],[amortProc],[vsegoZP],[sumNalogov],[TZV] ,VidrahProc,VsegoMat,TzvGrn,CehVitrGrn,AmortGrn,Vsego_F,zaversh,inv_usl,obekt_usl,name_inv_usl
       FROM  [Repairs].[dbo].[Akti_usl]  where  kod_rem=9 and id is not null  and Ispolnitel_codcx=" + Change_ceh.CEH + " " + pp + " and ((PeriodData1>='" + @PeriodData2_1 + "' and PeriodData1<='" + @PeriodData2_2 + "')  or (PeriodData2>='" + @PeriodData2_1 + "' and PeriodData2<='" + @PeriodData2_2 + "')) order by id desc";
                //Debug.Write(query);
            }
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                foreach (DbDataRecord result in dr)
                {

                    All_akt_usl.Add(result);
                }
            }
            con.Close();
            return All_akt_usl;
        }


        public string SaveNewReplacedPartquery()
        {
            bool flagSum = false;
            string query = string.Format("insert into ReplacedPart(JobId, Quantity, RepairID, EDNOME, DateInRep, Name, Mera, Prace, DataReplace, DataToday, Original, Shpz)" +
                "values ({0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}' , '{7}', '{8}', GetDate(), 0, '{9}' )",
                ReplacedPart.JobID, ReplacedPart.Quantity, InfoRepair.RepairID, ReplacedPart.EDNOME, ReplacedPart.DateInRep,
                ReplacedPart.Name, ReplacedPart.Mera, ReplacedPart.Prace, ReplacedPart.DateReplace, ReplacedPart.Shpz);
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    SqlCommand com = new SqlCommand(query, con);
            //    try
            //    {
            //        con.Open();
            //        if (com.ExecuteNonQuery() >= 1)
            //        {
            //            flagSum = true;
            //        }
            //    }
            //    catch
            //    {
            //        // flagSum = false;
            //    }
            //}
            return query;
        }

        //Выбор запчастей по номеру ведомости ресурсов
        public ArrayList GetRepPlaceForVedRes(string NumberVed)
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = string.Format(@"  SELECT [ReplacedId],[JobId],[PartId],[Quantity],[RepairID],[EDNOME],[DateInRep],[Name],[Mera],[Prace],[User_kol],[DataReplace]
      ,[DataToday],[Original],[VedomostNumber],[Shpz], tehno, norma, zavnom FROM [Repairs].[dbo].[ReplacedPart] where VedomostNumber = '{0}'", NumberVed);

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }

        //Выбор металлолома по номеру ведомости ресурсов
        public ArrayList GetVozvrMetForVedRes(string NumberVed)
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = string.Format(@"  SELECT ID ,Name,EdIzm,[Price],[Quantity],[Sum],[Note],[DataVozvr],[DataToday],[Original],[RepairID],[VedomostNumber] FROM VozvrMet
  where VedomostNumber = '{0}'", NumberVed);

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }



        //Выбор оприходованных запчастей по номеру ведомости ресурсов
        public ArrayList GetVozvrDetForVedRes(string NumberVed)
        {
            ArrayList AllRepPl = new ArrayList();
            SqlConnection con = new SqlConnection(constr);
            string query = string.Format(@" SELECT ID,Name,Quantity,Note,DataVozvr,DataToday,Original,RepairID,VedomostNumber  FROM VozvrDet where VedomostNumber = '{0}'", NumberVed);

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    AllRepPl.Add(result);
                }
            }
            con.Close();
            return AllRepPl;
        }

        //удаление ведомости ресурсов
        public bool DeleteVedRes(string NumberVedomost)
        {
            bool flagSum = false;
            string query = string.Format(@"   update ReplacedPart set Original = 0 where VedomostNumber = '{0}'
   update ReplacedPart set VedomostNumber = null where VedomostNumber = '{0}'
   update VozvrDet set Original = 0 where VedomostNumber = '{0}'
   update VozvrDet set VedomostNumber = null where VedomostNumber = '{0}'
   update VozvrMet set Original = 0 where VedomostNumber = '{0}'
   update VozvrMet set VedomostNumber = null where VedomostNumber = '{0}'
   delete from Vedomost_Resursov where id = '{0}'
   update [Repairs].[dbo].[Jobs_FromAktF2] set ID_VedR=null where ID_VedR='{0}' ", NumberVedomost);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //редактирование ведомости ресурсов
        public bool UpdateVedResFull(string dateIn, string dateOut, string State1, string Fio1, string State2,
            string Fio2, string ID, string Shpz, string State3, string Fio3, string State4, string Fio4, int kodrem)
        {
            string query = string.Format(@"select RepairID from Vedomost_Resursov where ID = '{0}'",ID);
            string repairID = "";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                repairID = com.ExecuteScalar().ToString();
                con.Close();
            }
            string query1 = string.Format(@"UPDATE ReplacedPart SET VedomostNumber = '{0}', Original = 1 where RepairID = '{1}' and VedomostNumber is null", ID, repairID);
            string query2 = string.Format(@"UPDATE VozvrDet SET VedomostNumber = '{0}', Original = 1 where RepairID = '{1}' and VedomostNumber is null", ID, repairID);
            string query3 = string.Format(@"UPDATE VozvrMet SET VedomostNumber = '{0}', Original = 1 where RepairID = '{1}' and VedomostNumber is null", ID, repairID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(query1, con);
                com.ExecuteNonQuery();
                com = new SqlCommand(query2, con);
                com.ExecuteNonQuery();
                com = new SqlCommand(query3, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool UpdateVedRes(string dateIn, string dateOut, string State1, string Fio1, string State2, 
            string Fio2, string ID, string Shpz, string State3, string Fio3, string State4, string Fio4, int kodrem)
        {
            bool flagSum = false;
//            string query = string.Format(@"update Vedomost_Resursov 
//  set PeriodData1 = '{0}', PeriodData2 = '{1}',  FIO1 = '{2}',
//FIO2 = '{3}', dolg1 = '{4}', dolg2 = '{5}', Shpz = '{7}',FIO3 = '{8}',
//FIO4 = '{9}', dolg3 = '{10}', dolg4 = '{11}', kod_rem='{12}'  where id = '{6}'", dateIn, dateOut, Fio1, Fio2, State1, State2, ID, Shpz, Fio3, Fio4, State3, State4, kodrem);

            string query = string.Format(@"update Vedomost_Resursov 
  set PeriodData1 = '{0}', PeriodData2 = '{1}',  FIO1 = '{2}',
FIO2 = '{3}', dolg1 = '{4}', dolg2 = '{5}', Shpz = '{7}',FIO3 = '{8}',
FIO4 = '{9}', dolg3 = '{10}', dolg4 = '{11}'  where id = '{6}'", dateIn, dateOut, Fio1, Fio2, State1, State2, ID, Shpz, Fio3, Fio4, State3, State4);

            using (SqlConnection con = new SqlConnection(constr))

            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        //редактирование даты для заменяемых запчастей
        public bool Update_DatReplacePart(string dateRep, string datToday, string IDReplacePart)
        {
            bool flagSum = false;
            string query = string.Format(@"update [Repairs].[dbo].[ReplacedPart]  set DataReplace = '{0}', DataToday='{1}'  where ReplacedId = '{2}'", dateRep, datToday, IDReplacePart);
            //Debug.WriteLine(query.ToString());


            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }


        //Выбор типов источников откуда "спиысваются" запчасти
        public ArrayList GetAllTypeRepPart()
        {
            ArrayList allTypeRepPart = new ArrayList();
            string query = @"select ID, Name from TypeReplacedPart where ID = 3 or id = 4";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTypeRepPart.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allTypeRepPart;
        }

        //сохрание деталей не с подотчета
        public bool SaveNewReplacedPartNotMol(string Quantity, string Name, string Mera, string DateRep, string TypeRepPartID)
        {
            bool flagSum = false;
            string query = string.Format("insert into ReplacedPart(JobId, Quantity, RepairID, Name, Mera, DataReplace, DataToday, Original,TypeRepPartID)" +
                "values ({0}, '{1}', {2}, '{3}', '{4}', '{5}',  GetDate(), 0, '{6}' )",
                ReplacedPart.JobID, Quantity, InfoRepair.RepairID,
                Name, Mera, DateRep, TypeRepPartID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch
                {
                    // flagSum = false;
                }
            }
            return flagSum;
        }


        // основные средства для аналитики
        public ArrayList GetAllOSForAnalitAll()
        {
            ArrayList allOS = new ArrayList();
            string query = @"SELECT s.*, col
  FROM SprOS  s 
  left join (select inventoryNumber, obekt, count(*) as col 
  from Repair 
  
  group by InventoryNumber, obekt) r on s.InventoryNumber = r.InventoryNumber and s.Obekt = r.Obekt 
  where s.DateEnd is null";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }


        // основные средства для аналитики для одного цеха
        public ArrayList GetAllOSForAnalitCeh(string codcx)
        {
            ArrayList allOS = new ArrayList();
            string query = string.Format(@"SELECT s.*, col
  FROM SprOS  s 
  left join (select inventoryNumber, count(*) as col 
  from Repair 
  group by InventoryNumber) r on s.InventoryNumber = r.InventoryNumber
  where s.DateEnd is null and s.StoreId = '{0}'
  order by col desc", codcx);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }


        public ArrayList GetAllRepairforInventoryNumber(string invNumber)
        {
            ArrayList allOS = new ArrayList();
            string query = string.Format(@"select RDivision, RepairId, DateIn, DateOut,Cause, Responsible, Note from Repair where InventoryNumber = '{0}'", invNumber);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }

        //поиск старых запчастей для ремонта
        public ArrayList GetAllRepPlace1OldAnalit(string RepairID)
        {
            ArrayList allOS = new ArrayList();
            string query = string.Format(@"  select 
  rp1.PartName, rp.Quantity, rp1.EdIzm 
  from Repair r 
   inner join job j on j.RepairId = r.RepairID
  inner join ReplacedPart rp on rp.JobId = j.JobId
  left join RefPart rp1 on rp1.PartId = rp.PartId
  where r.RepairID = '{0}'", RepairID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }

        public ArrayList GetAllJobAnalit(string RepairID)
        {
            ArrayList allOS = new ArrayList();
            string query = string.Format(@"  select RefJob.JobName from job
  left join RefJob on RefJob.JobCode = job.JobCode
  where RepairId = '{0}'", RepairID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }


        //поиск новых запчастей для ремонта
        public ArrayList GetAllRepPlace1NewAnalit(string RepairID)
        {
            ArrayList allOS = new ArrayList();
            string query = string.Format(@"   select name, quantity, mera from ReplacedPart where RepairID = '{0}'", RepairID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }


        //обновлене технологии с нормы при печати ведомости ресурсов

        //обновляем значение в таблице заменяемых запчастей параметры оригинала и номера ведомости ресурсов

        public bool UpdateRepPlaceVedResNormaTehNorma(string replacedId, string norma)
        {
            bool flagSum = false;
            string query = string.Format("update ReplacedPart set Norma = '{0}' where ReplacedId = '{1}'", norma, replacedId);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }


        public bool UpdateRepPlaceVedResNormaTehnoTehno(string replacedId, string tehno)
        {
            bool flagSum = false;
            string query = string.Format("update ReplacedPart set tehno = '{0}' where ReplacedId = '{1}'", tehno, replacedId);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        public bool UpdateRepPlaceVedResNormaTehnoDatareplace(string replacedId, string Datareplace)
        {
            bool flagSum = false;

            string Datrep = Datareplace.Substring(6, 4) + "-" + Datareplace.Substring(3, 2) + "-"+Datareplace.Substring(0, 2);

//             cast(date_besed as date) between '" + dtpBeg.Value.Date.ToString("yyyy-MM-dd")


            string query = string.Format("update ReplacedPart set Datareplace = cast('{0}' as date) where ReplacedId = '{1}'", Datrep, replacedId);
            
            
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }


        public string SaveNewReplacedPartstringgg()
        {
            bool flagSum = false;



            string query = string.Format("insert into ReplacedPart(JobId, Quantity, RepairID, EDNOME, DateInRep, Name, Mera, Prace, DataReplace, DataToday, Original, Shpz, tehno, norma)" +
                "values ({0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}' , '{7}', '{8}', GetDate(), 0, '{9}', '{10}', '{11}') update ReplacedPart set norma = null where norma = '100'  update ReplacedPart set tehno = null where tehno = '100' ",
                ReplacedPart.JobID, ReplacedPart.Quantity, InfoRepair.RepairID, ReplacedPart.EDNOME, ReplacedPart.DateInRep,
                ReplacedPart.Name.Replace("'", "^"), ReplacedPart.Mera, ReplacedPart.Prace, ReplacedPart.DateReplace, ReplacedPart.Shpz, ReplacedPart.Tehno, ReplacedPart.Norma);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch
                {
                    // flagSum = false;
                }
            }
            return query;
        }

        //показываем все типы металлолома

        public ArrayList GetAllTypeMet()
        {
            ArrayList allOS = new ArrayList();
            string query = string.Format(@"SELECT Id,
      EdNumber,
      Name,
      EdIzm, 
	  EdNumber + ' ' + name + ' ' + EdIzm as fulName
  FROM TypeMetall");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }

        //получаем ШВ удиницы измерения
        //        public int ReturnDopZnachEdIzm(string EdNumber)
        //        {
        //            double dopznach = 1;
        //            using (SqlConnection con = new SqlConnection(constr))
        //            {
        //                string query = string.Format(@" SELECT SUM(Quantity)  FROM ReplacedPart WHERE (Original = 0 or Original = 1 ) AND EDNOME = '{0}' 
        //AND DateInRep = '{1}' 
        //and prace = '{6}' 
        // and  RepairID in ( select RepairID from Repair where codcx = '{2}' and CODUTH = '{3}' and CODBRIG= '{4}'  and CODDET = '{5}')", EDNOME, date, codcx, coduth, codbrig, coddet, prace);
        //                SqlCommand com = new SqlCommand(query, con);
        //                try
        //                {
        //                    con.Open();
        //                    dopznach = Convert.ToDouble(com.ExecuteScalar());


        //                }
        //                catch
        //                {
        //                    dopznach = 1;
        //                }

        //            }

        //            return dopznach;
        //        }

        //Единица измерения по номеру
        //Вывод единиц измерения
        public ArrayList GetAllEdIzmForNumber(string Number)
        {
            ArrayList allEdIzm = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format(@"select name from EdIzm where id = (select top 1 EdIzmId 
                                                    from TypeMetall 
                                                        where ednumber = '{0}')", Number);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allEdIzm.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allEdIzm;
        }

        //создание ведеомости ресурсов по ОС
        //Создание новой ведомости ресурсов для ремонта
        public bool CreateNewVedomodtResursovOS(string RepairID, string dtp_date1, string dtp_date2)
        {
            bool flagSum = false;
            string query = string.Format(@"  
declare @RepairId int 
  declare @dtp_date1 date
  declare @dtp_date2 date
  set @RepairId = '{0}' 
  set @dtp_date1 = '{1}'
  set @dtp_date2 = '{2}' 

  INSERT INTO Vedomost_Resursov(
   [RepairID],
   [InventoryNamber],
   [NameOS],
   [PeriodData1],
   [PeriodData2],
   [Zakazchik_codcx],
   [Zakazchik_coduth],
   [Ispolnitel_codcx],
   [Ispolnitel_coduth],
   [Ispolnitel_codbrig],
   [Ispolnitel_coddet],
   [Ispolnitel_Name],
   [VedomostNumber],
   [Original],
   [Zakazchik_codbrig], 
   [Zakazchik_coddet],
   Obekt
   )VALUES
( @RepairId, 
(select InventoryNumber from Repair where RepairID = @RepairId),
(select Name from SprOS where InventoryNumber = (select InventoryNumber from Repair where RepairID = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)),
@dtp_date1, 
@dtp_date2, 
(select StoreId from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0) ), 
(select CODUTH from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)),
(select codcx from Repair where RepairID = @RepairId),
(select CODUTH from Repair where RepairID = @RepairId),
(select CODBRIG from Repair where RepairID = @RepairId),
(select CODDET from Repair where RepairID = @RepairId),
(select NAMEDET from Repair where RepairID = @RepairId),
0, 
0, 
(select CODBRIG from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)), 
(select CODDET from SprOS where InventoryNumber = ( select InventoryNumber from Repair where RepairId = @RepairId) and Obekt = isnull((select Obekt from Repair where RepairId = @RepairId),0)) ,
(select isnull(Obekt,0) from Repair where RepairId = @RepairId))", RepairID, dtp_date1, dtp_date2);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        //получение должности 1

        public ArrayList GetAllState1(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct dolg1 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }

        public ArrayList GetAllState2(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct dolg2 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }



        public ArrayList GetAllState3(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct dolg3 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }



        public ArrayList GetAllState4(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct dolg4 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }







        public ArrayList GetAllFIO1(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct FIO1 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2> dateadd(mm,-3,getdate()) ", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }

        public ArrayList GetAllFIO2(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct FIO2 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2> dateadd(mm,-3,getdate()) ", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }


        public ArrayList GetAllFIO3(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct FIO3 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2> dateadd(mm,-3,getdate()) ", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }

        public ArrayList GetAllFIO4(string cx1, string uch1, string brig1, string det1)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@" select distinct FIO4 from Vedomost_Resursov 
where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2> dateadd(mm,-3,getdate()) ", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }



        //Подписанты для формы 2

        //получение должности 1

        public ArrayList GetAllState1f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {

            ArrayList allState = new ArrayList();
            string query;
            query="";

            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct dolg1f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }
            if (remusl == "usl")
            {
                query = string.Format(@" select distinct dolg1f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }

        public ArrayList GetAllState2f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            ArrayList allState = new ArrayList();
            string query;
            query = "";
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct dolg2f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            if (remusl == "usl")
            {
                query = string.Format(@" select distinct dolg2f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }



        public ArrayList GetAllState3f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            ArrayList allState = new ArrayList();
            string query;
            query = "";
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct dolg3f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            if (remusl == "usl")
            {
                query = string.Format(@" select distinct dolg3f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }


            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }



        public ArrayList GetAllState4f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            ArrayList allState = new ArrayList();
            string query;
            query = "";
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct dolg4f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            if (remusl == "usl")
            {
                query = string.Format(@" select distinct dolg4f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }


          //  string query = string.Format(@" select distinct dolg4f2 from Vedomost_Resursov 
//where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }




        public ArrayList GetAllState5f2(string cx1, string uch1, string brig1, string det1,string remusl)
        {
            ArrayList allState = new ArrayList();
            string query;
            query = "";
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct dolg5f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            if (remusl == "usl")
            {
                query = string.Format(@" select distinct dolg5f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }







        public ArrayList GetAllFIO1f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            string query;
            query = "";
            ArrayList allState = new ArrayList();

            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct FIO1f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }
            if (remusl == "usl")
            {
                query = string.Format(@" select distinct FIO1f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }



        public ArrayList GetAllFIO2f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            ArrayList allState = new ArrayList();
            string query;
            query = "";
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct FIO2f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            if (remusl == "usl")
            {
                query = string.Format(@" select distinct FIO2f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }


        public ArrayList GetAllFIO3f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            string query;
            query = "";
            ArrayList allState = new ArrayList();
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct FIO3f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }
            if (remusl == "usl")
            {
                query = string.Format(@" select distinct FIO3f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }

        public ArrayList GetAllFIO4f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            string query;
            query = "";
            ArrayList allState = new ArrayList();
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct FIO4f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            if (remusl == "usl")
            {
                query = string.Format(@" select distinct FIO4f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }




        public ArrayList GetAllFIO5f2(string cx1, string uch1, string brig1, string det1, string remusl)
        {
            ArrayList allState = new ArrayList();
            string query;
            query = "";
            if (remusl == "rem" || remusl == "usl_mat")
            {
                query = string.Format(@" select distinct FIO5f2 from Vedomost_Resursov where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            if (remusl == "usl")
            {
                query = string.Format(@" select distinct FIO5f2 from Akti_usl where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}' and PeriodData2>getdate()-90", cx1, uch1, brig1, det1);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }


//        public ArrayList GetAllState1f2 (string cx1, string uch1, string brig1, string det1)
//        {
//            ArrayList allState = new ArrayList();
//            string query = string.Format(@" select distinct dolg1f2 from Vedomost_Resursov
//where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
//            using (SqlConnection con = new SqlConnection(constr))
//            {
//                SqlCommand com = new SqlCommand(query, con);
//                try
//                {
//                    con.Open();
//                    SqlDataReader dr = com.ExecuteReader();
//                    if (dr.HasRows)
//                    {
//                        foreach (DbDataRecord result in dr)
//                        {
//                            allState.Add(result);
//                        }
//                    }
//                }
//                catch { }
//            }

//            return allState;
//        }


//        public ArrayList GetAllState2f2(string cx1, string uch1, string brig1, string det1)
//        {
//            ArrayList allState = new ArrayList();
//            string query = string.Format(@" select distinct dolg2f2 from Vedomost_Resursov 
//where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
//            using (SqlConnection con = new SqlConnection(constr))
//            {
//                SqlCommand com = new SqlCommand(query, con);
//                try
//                {
//                    con.Open();
//                    SqlDataReader dr = com.ExecuteReader();
//                    if (dr.HasRows)
//                    {
//                        foreach (DbDataRecord result in dr)
//                        {
//                            allState.Add(result);
//                        }
//                    }
//                }
//                catch { }
//            }

//            return allState;
//        }


//        public ArrayList GetAllState3f2(string cx1, string uch1, string brig1, string det1)
//        {
//            ArrayList allState = new ArrayList();
//            string query = string.Format(@" select distinct dolg3f2 from Vedomost_Resursov 
//where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
//            using (SqlConnection con = new SqlConnection(constr))
//            {
//                SqlCommand com = new SqlCommand(query, con);
//                try
//                {
//                    con.Open();
//                    SqlDataReader dr = com.ExecuteReader();
//                    if (dr.HasRows)
//                    {
//                        foreach (DbDataRecord result in dr)
//                        {
//                            allState.Add(result);
//                        }
//                    }
//                }
//                catch { }
//            }

//            return allState;
//        }


//        public ArrayList GetAllState4f2(string cx1, string uch1, string brig1, string det1)
//        {
//            ArrayList allState = new ArrayList();
//            string query = string.Format(@" select distinct dolg4f2 from Vedomost_Resursov 
//where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig='{2}' and Ispolnitel_coddet='{3}'", cx1, uch1, brig1, det1);
//            using (SqlConnection con = new SqlConnection(constr))
//            {
//                SqlCommand com = new SqlCommand(query, con);
//                try
//                {
//                    con.Open();
//                    SqlDataReader dr = com.ExecuteReader();
//                    if (dr.HasRows)
//                    {
//                        foreach (DbDataRecord result in dr)
//                        {
//                            allState.Add(result);
//                        }
//                    }
//                }
//                catch { }
//            }

//            return allState;
//        }



        //Редактирование формы 2
        //редактирование ведомости ресурсов
        public bool UpdateAKT_Form2(string Fio1, string Fio2, string Fio3, string Fio4, string State1, string State2, string State3, string State4, string Fio5, string State5, string ID, string remusl)
        {
            bool flagSum = false;
            string query = "";
            if (remusl == "rem")
            {
              query = string.Format(@"update Vedomost_Resursov 
          set FIO1f2 = '{0}',
        FIO2f2 = '{1}', FIO3f2 = '{2}',
        FIO4f2 = '{3}', dolg1f2 = '{4}',dolg2f2 = '{5}',dolg3f2 = '{6}',dolg4f2 = '{7}',   FIO5f2 = '{8}', dolg5f2 = '{9}'  where id = '{10}'", Fio1, Fio2, Fio3, Fio4, State1, State2, State3, State4, Fio5, State5, ID);
            }
            if (remusl == "usl")
            {
                query = string.Format(@"update Akti_Usl  
          set FIO1f2 = '{0}',
        FIO2f2 = '{1}', FIO3f2 = '{2}',
        FIO4f2 = '{3}', dolg1f2 = '{4}',dolg2f2 = '{5}',dolg3f2 = '{6}',dolg4f2 = '{7}',   FIO5f2 = '{8}', dolg5f2 = '{9}'  where id = '{10}'", Fio1, Fio2, Fio3, Fio4, State1, State2, State3, State4, Fio5, State5, ID);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }




        //  
        public bool UpdateForm2(string Fio1, string Fio2, string Fio3, string Fio4, string ID)
        {
            bool flagSum = false;
            string query = string.Format(@"update Vedomost_Resursov 
  set FIO1f2 = '{0}',
FIO2f2 = '{1}', FIO3f2 = '{2}',
FIO4f2 = '{3}'  where id = '{4}'", Fio1, Fio2, Fio3, Fio4, ID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        //смотрим строку 
        public string GetAllTMCstring()
        {
            ArrayList allTMC = new ArrayList();
            string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, coduth, codbrig, coddet, Obekt FROM SprOS where DateEnd is null " + Dostup.AddQueryALLTMC() + "  order by StoreId, coduth, codbrig, coddet";
            using (SqlConnection con = new SqlConnection(constr))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTMC.Add(result);
                        }
                    }
                }
                catch { }
            }
            return query;
        }


        public ArrayList GetAllKontragent()
        {
            ArrayList allTMC = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, coduth, codbrig, coddet, Obekt FROM SprOS where DateEnd ='18991230' " + Dostup.AddQueryALLTMC() + "  order by StoreId, coduth, codbrig, coddet";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTMC.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allTMC;
        }

        //Показать строку
        public string SaveNewRepairString(string DateIn, string InventoryNumber, string RDivision, string Division, string plan_r, string obekt, string kodK, string nameK, string edrpouK)
        {
            bool flagsum = false;
            string query = string.Format(@"insert into Repair (DateIn, InventoryNumber, RDivision, Division, plan_r, Obekt, KodKontrAgent, NameKontragent, EdrpouKontragent) values ( 
                          '{0}', '{1}',  
                        '{2}', '{3}', '{4}', '{5}' ,'{6}', '{7}', '{8}')", DateIn, InventoryNumber, RDivision, Division, plan_r, obekt, kodK, nameK, edrpouK);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagsum = true;

                    }
                }
                catch { }
            }
            return query;
            ;
        }

        //выбор ТМЦ для построения агрегатного журнала
        //выбор ТМЦ
        public ArrayList GetAllTMCForAgrJournal()
        {
            ArrayList allTMC = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, DateEnd, coduth, codbrig, coddet, Obekt FROM SprOS where 1 = 1 " + Dostup.AddQueryALLTMC() + "  order by StoreId, coduth, codbrig, coddet";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTMC.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allTMC;
        }

        public ArrayList GetAllTMCForAgrJournal(string inv)
        {
            ArrayList allTMC = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format("SELECT InventoryNumber, Name, StoreId, DateBeg, GroupOSCode, Flag, Hours_Beg, DateEnd, coduth, codbrig, coddet, Obekt FROM SprOS where 1 = 1 " + Dostup.AddQueryALLTMC() + " and InventoryNumber = '{0}'   order by StoreId, coduth, codbrig, coddet", inv);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allTMC.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allTMC;
        }

        public ArrayList GetAllUchforJournal(int ceh)
        {
            ArrayList allStoreR = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = String.Format(@" select distinct Ispolnitel_coduth from Vedomost_Resursov
  where Ispolnitel_codcx = '{0}'
  order by Ispolnitel_coduth", ceh);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allStoreR.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allStoreR;
        }

        public ArrayList GetAllBrigforJournal(int ceh, int uch)
        {
            ArrayList allStoreR = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = String.Format(@"   select distinct Ispolnitel_codbrig from Vedomost_Resursov
  where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}'
  order by Ispolnitel_codbrig", ceh, uch);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allStoreR.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allStoreR;
        }


        public ArrayList GetAllDetforJournal(int ceh, int uch, int brig)
        {
            ArrayList allStoreR = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = String.Format(@"   select distinct Ispolnitel_coddet from Vedomost_Resursov
  where Ispolnitel_codcx = '{0}' and Ispolnitel_coduth = '{1}' and Ispolnitel_codbrig = '{2}'
  order by Ispolnitel_coddet", ceh, uch,brig);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allStoreR.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allStoreR;
        }

        public ArrayList GetAllsprrem()
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@"SELECT  [kod_rem],[name_rem] FROM SprRem");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }


        // Вічисляем макс номер отчета в году max(NomPTO) из таблиці PTO 
        public int MaxZnach(string YearDat2)
        {
            int maxznach = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = string.Format(@" SELECT MAX(NomPTO) FROM PTO WHERE YEAR(Data2PTO) ='{0}' ", YearDat2);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    maxznach = Convert.ToInt32(com.ExecuteScalar());
                }
                catch
                {
                    maxznach = 0;
                }
            }
            return maxznach;
        }


        // Вічисляем макс номер IDPTO в таблице PTO 
        public int MaxIDPTO()
        {
            int maxidpto = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string query = string.Format(@" SELECT MAX(NomPTO) FROM PTO WHERE YEAR(Data2PTO) ='{0}' ", YearDat2);
                string query = string.Format(@" select top 1 max(idpto) from PTO ");
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    maxidpto = Convert.ToInt32(com.ExecuteScalar());
                }
                catch
                {
                    maxidpto = 0;
                }
            }
            return maxidpto;
        }


      




//Сохраняем новый ПТО из VedomostResursov в таблицу PTO 
        public bool SaveNewNoPTO( string   NomPTO, string Data1PTO, string Data2PTO, string codcx, string coduth,
                                   string codbrig, string coddet, string FIO_MOL, string UserName, int Original)
        {
            bool flagSum = false;
           
            string query = string.Format("insert into PTO (NomPTO, Data1PTO, Data2PTO, codcx, coduth, codbrig, coddet, FIO_MOL, UserName, Original)" +
                " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}' )",
                   NomPTO, Data1PTO, Data2PTO, codcx, coduth, codbrig, coddet, FIO_MOL, UserName, Original);
            Debug.WriteLine(query);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch(Exception e)

                {
                    // flagSum = false;
                    Debug.WriteLine(e.Message);
                }
            }
            return flagSum;
        }


// заносим максимал.№ PTO в таблицу  VedomostResursov ***
        public bool UpdateVedRes_IdPTO(int ID_PTO, int ID_VedRes)
        {
            bool flagSum = false;
            string query = string.Format(@"update Vedomost_Resursov set idPTO = '{0}' where id = '{1}'", ID_PTO, ID_VedRes);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }




        //**********
        //public string UpdateVedRes_IdPTO2(int ID_PTO, int ID_VedRes)
        //{
        //    bool flagSum = false;
        //    string query = string.Format(@"update Vedomost_Resursov set idPTO = '{0}' where id = '{1}'", ID_PTO, ID_VedRes);
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        SqlCommand com = new SqlCommand(query, con);
        //        try
        //        {
        //            con.Open();
        //            if (com.ExecuteNonQuery() >= 1)
        //            {
        //                flagSum = true;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //        }
        //    }
        //    return query;
        //}
     
        //*********



        public bool InsertNoPTOvVedRes(string ID,int IdPTO)
        {
            bool flagSum = false;

            string query = string.Format("insert into Vedomost_Resursov (ID) values ('{0}')", ID);
                
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch
                {
                    // flagSum = false;
                }
            }
            return flagSum;
        }


        //Выбираем все записи из таблицы PTO по условию в dgvPTO
        public ArrayList GetDanFromPTO(string nCodcx, string nCoduth,string nCodbrig,string ncoddet, string datbeg, string datend)
        {
            ArrayList allState = new ArrayList();
 //          string query = string.Format(@"SELECT [idPTO],[NomPTO],[Data1PTO],[Data2PTO],[codcx],[coduth],[codbrig],[coddet],[FIO_MOL] FROM PTO
  //         WHERE codcx='{0}' and coduth='{1}' and codbrig='{2}' and coddet='{3}' ",nCodcx,nCoduth,nCodbrig,ncoddet);


           string query = string.Format(@"SELECT [idPTO],[NomPTO],[Data1PTO],[Data2PTO],[codcx],[coduth],[codbrig],[coddet],[FIO_MOL] FROM PTO
           WHERE codcx='{0}' and coduth='{1}' and codbrig='{2}' and coddet='{3}' and ((Data1PTO >= '{4}' and Data1PTO <= '{5}') )", nCodcx, nCoduth, nCodbrig, ncoddet, datbeg, datend);

  
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }




        //Выбираем все записи из таблицы PTO по условию в dgvPTO
        public ArrayList GetDanFromPTOCeh(string nCodcx, string datbeg, string datend)
        {

//            string Ddat_end = datend.Substring(6, 4) + datend.Substring(3, 2) + datend.Substring(0, 2);

            ArrayList allState = new ArrayList();

//              string query = string.Format(@"SELECT [idPTO],[NomPTO],[Data1PTO],[Data2PTO],[codcx],[coduth],[codbrig],[coddet],[FIO_MOL] FROM [Repairs].[dbo].PTO WHERE codcx='{0}' and ((Data1PTO >= '{1}' and Data1PTO <= '{2}') )", nCodcx, datbeg, datend);
            string query = string.Format(@"SELECT [idPTO],[NomPTO],[Data1PTO],[Data2PTO],[codcx],[coduth],[codbrig],[coddet],[FIO_MOL] FROM [Repairs].[dbo].PTO WHERE codcx='{0}' and (Data1PTO >= '{1}' and Data1PTO <= '{2}') order by codcx,coduth,codbrig,coddet,NomPTO", nCodcx, datbeg, datend);
            


              //string query = string.Format(@"SELECT [idPTO],[NomPTO],[Data1PTO],[Data2PTO],[codcx],[coduth],[codbrig],[coddet],[FIO_MOL] FROM [Repairs].[dbo].PTO WHERE codcx='{0}' ", nCodcx, datbeg, datend);


            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }

        //Выбираем все записи из таблицы VedomostResursov по условию в dgvPTOFromVedR
        public ArrayList GetDanPTOFromVedR(string idPTO)
        {
            ArrayList allState = new ArrayList();
            string query = string.Format(@"SELECT [idPTO],[InventoryNamber],[NameOS] FROM Vedomost_Resursov WHERE idpto='{0}' ", idPTO);


            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allState.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allState;
        }


        //   // Вычисляем по ОС общую cумму из ReplacedPart для использования в акте(форма2)

        public double sum_mater(int ID)
        {
            double sum_mater = 0.00;
            using (SqlConnection con = new SqlConnection(constr))
            {

                string query = string.Format(@"SELECT sum([Quantity]*[Prace]) FROM [Repairs].[dbo].[ReplacedPart] where VedomostNumber ='{0}' group by VedomostNumber", ID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    //sum_mater = Convert.ToInt32(com.ExecuteScalar());
                    sum_mater = Convert.ToDouble(com.ExecuteScalar());
                }
                catch
                {
                    sum_mater = 0;
                }
            }
            return sum_mater;
        }


        public bool UpdateVedRWithProc(int ID_VedResursov,string VsegoZP, string SumNalogov, string CexVitrProc, string AmortProc, string TZV, string remusl)
        {
            bool flagSum = false;
            string query="";
            if (remusl == "rem")
            {
                query = string.Format("update Vedomost_Resursov set VsegoZP = '{0}', SumNalogov= '{1}', CexVitrProc='{2}', AmortProc='{3}' , TZV='{4}'  where Id = '{5}'", VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV, ID_VedResursov);
            }
            if (remusl == "usl")
            {
                query = string.Format("update Akti_usl set VsegoZP = '{0}', SumNalogov= '{1}', CexVitrProc='{2}', AmortProc='{3}' , TZV='{4}'  where Id = '{5}'", VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV, ID_VedResursov);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        

        public bool UpdateVedRWithProc2(int ID_VedResursov, string VidrahProc, string VsegoMat, string TzvGrn, string CehVitrGrn, string AmortGrn,string Vsego_F, string remusl)
        {
            bool flagSum = false;
            string query = "";
            if (remusl == "rem")
            {
                query = string.Format("update Vedomost_Resursov set VidrahProc = '{0}', VsegoMat= '{1}', TzvGrn='{2}', CehVitrGrn='{3}' , AmortGrn='{4}',Vsego_F='{5}'  where Id = '{6}'"
                                          , VidrahProc, VsegoMat, TzvGrn, CehVitrGrn, AmortGrn, Vsego_F, ID_VedResursov);
            }
            if (remusl == "usl")
            {
                query = string.Format("update Akti_usl set VidrahProc = '{0}', VsegoMat= '{1}', TzvGrn='{2}', CehVitrGrn='{3}' , AmortGrn='{4}',Vsego_F='{5}'  where Id = '{6}'"
                                          , VidrahProc, VsegoMat, TzvGrn, CehVitrGrn, AmortGrn, Vsego_F, ID_VedResursov);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        //public string UpdateVedRWithProc2(int ID_VedResursov, string VsegoZP, string SumNalogov, string CexVitrProc, string AmortProc, string TZV)
        //{
        //    bool flagSum = false;
        //    string query = string.Format("update Vedomost_Resursov set VsegoZP = '{0}', SumNalogov= '{1}', CexVitrProc='{2}', AmortProc='{3}' , TZV='{4}'  where Id = '{5}'"
        //                              , VsegoZP, SumNalogov, CexVitrProc, AmortProc, TZV, ID_VedResursov);
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        SqlCommand com = new SqlCommand(query, con);
        //        try
        //        {
        //            con.Open();
        //            if (com.ExecuteNonQuery() >= 1)
        //            {
        //                flagSum = true;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //        }
        //    }
        //    return query;
        //}


// Выбор работ по АКТу форма2

        public ArrayList GetJobFromAKT(string ID_VedR, string remusl )
        {
            ArrayList allOS = new ArrayList();
            string query = "";
            if (remusl == "rem")
            {
                query = string.Format(@"select id, id_vedr,nam_job,ch_chas,ID_Repair from Jobs_FromAktF2 where id_vedr = '{0}'", ID_VedR);
            }
            if (remusl == "usl")
            {
                string ID_AktiUsl = ID_VedR;
                query = string.Format(@"select id, ID_AktiUsl as ID_VedR ,nam_job,ch_chas,ID_Repair from Jobs_FromAktF2 where ID_AktiUsl = '{0}'", ID_AktiUsl);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allOS.Add(result);
                        }
                    }
                }
                catch { }
            }

            return allOS;
        }

        public bool UpdateJobFromAKT(int IDJob, int ID_VedResursov, string name_job)
        {
            bool flagSum = false;
            string query = string.Format("update Jobs_FromAktF2 set name_job = '{0}', Id_vedr= '{1}'  where Id = '{2}'"
                                      , name_job, ID_VedResursov,IDJob);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }





        public bool UpdateJobToAKT(string ID_VedResursov, string ID_Repair, string remusl)
        {
            bool flagSum = false;
            string query="" ;
            if (remusl=="rem")
               query = string.Format("update Jobs_FromAktF2 set ID_VedR= '{0}'  where (ID_VedR='{0}' or id_repair= '{1}' ) and ID_VedR is null", ID_VedResursov, ID_Repair);
            if (remusl == "usl")
                query = string.Format("update Jobs_FromAktF2 set ID_AktiUsl= '{0}'  where (ID_VedR='{0}' or id_repair= '{1}' ) ", ID_VedResursov, ID_Repair);

            string aa = "";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        // сохраняем новую раблту в акт форма2
        public bool SaveNewJobToAKT(string Name_Job, string ID_VedR, string remusl,string RepairID)
        {
            bool flagSum = false;
            string query = "";
            if (remusl == "rem")
            {
                query = string.Format(" insert into Jobs_FromAktF2 (ID_VedR,Nam_job,ID_Repair) values('{0}', '{1}', '{2}')", ID_VedR, Name_Job,RepairID);
            }
            if (remusl == "usl")
            {
                string ID_AktiUsl = ID_VedR;
                query = string.Format(" insert into Jobs_FromAktF2 (ID_AktiUsl,Nam_job,ID_Repair) values('{0}', '{1}', '{2}')", ID_VedR, Name_Job, RepairID);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

        // сохраняем новую работу в акт форма2 из формы Repairs (Ремонты ОС)
        public bool SaveNewJobToAKTFromRepair(string Name_Job, string ID_Repair, string Ljud_god)
        {
            bool flagSum = false;
            string query = "";
            query = string.Format(" insert into Jobs_FromAktF2 (ID_Repair,Nam_job,ch_chas) values('{0}', '{1}', '{2}')", ID_Repair, Name_Job, Ljud_god);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }

// Удаляем  работу из таблиці Job_FromAKTF2
        public bool DeleteJobFromAKT2(string ID)
        {
            bool flagSum = false;
            string query = string.Format(" delete from Jobs_FromAktF2 where id=('{0}')", ID);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }








        // Создаём временную табличку для печати АКТа форма2
        public ArrayList CreateDrukAKT(string ID)
        {
            //throw new NotImplementedException();
            ArrayList allJobs = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string query = string.Format("SELECT * FROM Jobs_FromAktF2");
                string query = string.Format("SELECT * FROM Vedomost_Resursov as VR   inner join Jobs_FromAktF2 on VR.ID=Jobs_FromAktF2.ID_VedR WHERE VR.Id='{0}'", ID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allJobs.Add(result);
                        }
                    }
                }
                catch { }
            }
            return allJobs;
        }



        // сохраняем работы по акту(форма2) во врем таблицу Tmp_JobAKT шаг1
        public bool SaveToTmp_JobAKT_Step1(string ID_VedR, string remusl)
        {

            bool flagSum = false;
            string query = "";
            if (remusl == "rem")
            {
                query = string.Format("INSERT INTO Tmp_JobAKT (nam_job,ch_chas)  SELECT nam_job,ch_chas   FROM Jobs_FromAktF2 where Jobs_FromAktF2.ID_VedR='{0}'", ID_VedR);
            }
            if (remusl == "usl")
            {
                query = string.Format("INSERT INTO Tmp_JobAKT (nam_job,ch_chas)  SELECT nam_job,ch_chas   FROM Jobs_FromAktF2 where Jobs_FromAktF2.ID_Aktiusl='{0}'", ID_VedR);
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }



        // сохраняем работы по акту(форма2) во врем таблицу Tmp_JobAKT шаг2
        public bool SaveToTmp_JobAKT_Step2(string ID_VedR, string remusl)
        {
            bool flagSum = false;
            string query = "";
            if (remusl == "rem")
            {
                 query = string.Format(@"update Tmp_JobAKT set name_os=vr.nameos ,zakazchik_codcx=vr.Zakazchik_codcx ,zakazchik_coduth=vr.Zakazchik_coduth ,zakazchik_codbrig=vr.Zakazchik_codbrig
                 ,zakazchik_coddet=vr.Zakazchik_coddet,ispolnotel_codcx=vr.Ispolnitel_codcx,ispolnotel_coduth=vr.Ispolnitel_coduth
                 ,ispolnotel_codbrig=vr.Ispolnitel_codbrig,ispolnotel_coddet=vr.Ispolnitel_coddet,shpz=vr.Shpz,inventoryNamber=vr.InventoryNamber
                 ,obekt=vr.Obekt,periodData1=vr.PeriodData1,periodDate2=vr.PeriodData2,dolg1F2=vr.dolg1f2,FIO1F2=vr.FIO1f2,dolg2F2=vr.dolg2f2
                 ,FIO2F2=vr.FIO2f2,dolg3F2=vr.dolg3f2,FIO3F2=vr.FIO3f2 ,dolg4F2=vr.dolg4f2,FIO4F2=vr.FIO4f2 ,cexVitrProc=vr.cexVitrProc
                 ,amortProc=vr.amortProc,vsego_ZP=vr.vsegoZP,sumNalogov=vr.sumNalogov,TZV=vr.TZV, FIO5F2=vr.FIO5f2,dolg5F2=vr.dolg5f2   FROM Vedomost_Resursov vr where VR.ID='{0}'", ID_VedR);
            }
            if (remusl == "usl")
            {
                query = string.Format(@"update Tmp_JobAKT set name_os=vr.nameos ,zakazchik_codcx=vr.Zakazchik_codcx ,zakazchik_coduth=vr.Zakazchik_coduth ,zakazchik_codbrig=vr.Zakazchik_codbrig
                 ,zakazchik_coddet=vr.Zakazchik_coddet,ispolnotel_codcx=vr.Ispolnitel_codcx,ispolnotel_coduth=vr.Ispolnitel_coduth
                 ,ispolnotel_codbrig=vr.Ispolnitel_codbrig,ispolnotel_coddet=vr.Ispolnitel_coddet,shpz=vr.Shpz,inventoryNamber=vr.InventoryNamber
                 ,obekt=vr.Obekt,periodData1=vr.PeriodData1,periodDate2=vr.PeriodData2,dolg1F2=vr.dolg1f2,FIO1F2=vr.FIO1f2,dolg2F2=vr.dolg2f2
                 ,FIO2F2=vr.FIO2f2,dolg3F2=vr.dolg3f2,FIO3F2=vr.FIO3f2 ,dolg4F2=vr.dolg4f2,FIO4F2=vr.FIO4f2 ,cexVitrProc=vr.cexVitrProc
                 ,amortProc=vr.amortProc,vsego_ZP=vr.vsegoZP,sumNalogov=vr.sumNalogov,TZV=vr.TZV, FIO5F2=vr.FIO5f2,dolg5F2=vr.dolg5f2   FROM Akti_usl vr where VR.ID='{0}'", ID_VedR);
            }
      
             using (SqlConnection con = new SqlConnection(constr))
                {

                    SqlCommand com = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        if (com.ExecuteNonQuery() >= 1)
                        {
                            flagSum = true;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                return flagSum;
        
        }



        // очищаем врем. таблицу Tmp_JobAKT 
        public bool DelFromTmp_JobAKT()
        {
            bool flagSum = false;
            string query = string.Format("Delete From Tmp_JobAKT");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }





//      
        public string SumPoInv(string InventoryNumber)
        {
            string sum = "0";
            string sum1 = "0";
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string query = string.Format(@" SELECT MAX(NomPTO) FROM PTO WHERE YEAR(Data2PTO) ='{0}' ", YearDat2);
                string query = string.Format(@"select sum(prace*Quantity) as sum from Repair inner join ReplacedPart RP on RP.RepairID=Repair.RepairID  
                  where (Repair.InventoryNumber = '{0}')  and Original=0 ", InventoryNumber);


                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    sum = com.ExecuteScalar().ToString();
                    sum1 = (Math.Round(Convert.ToDouble(sum),3)).ToString();
                    //sum = Math.Round(com.ExecuteScalar().ToString(),2).ToString();  
                }
                catch
                {
                    sum = "0";
                }
            }
            return sum1;
        }


        //заміна цехових витрат по актам (відомості ресурсів) за поточний місяць, рік  по МВО
        public bool UpdateVedResAKTCexVitrProc(string CexVitrProc, string god, string mes, string isp_cx, string isp_uch, string isp_brig, string isp_det)
        {
            bool flag = false;
            string query = string.Format(@"update Vedomost_Resursov 
  set cexVitrProc= '{0}' where YEAR(PeriodData1)='{1}' and  MONTH(PeriodData1)='{2}' and Ispolnitel_codcx='{3}' and Ispolnitel_coduth='{4}'
  and Ispolnitel_codbrig='{5}' and Ispolnitel_coddet='{6}'", CexVitrProc, god, mes, isp_cx, isp_uch, isp_brig,isp_det);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }


        //заміна цехових витрат по актам (відомості ресурсів) за поточний місяць, рік  по МВО
        public bool UpdateVedResAKT_PidpisiCeh(string NamPole, string god, string mes, string isp_cx, string vibor)
        {
            bool flag = false;
            string query = string.Format("");
//            string query = string.Format(@"update Vedomost_Resursov 
//  set cexVitrProc= '{0}' where YEAR(PeriodData1)='{1}' and  MONTH(PeriodData1)='{2}' and Ispolnitel_codcx='{3}' and Ispolnitel_coduth='{4}'
//  and Ispolnitel_codbrig='{5}' and Ispolnitel_coddet='{6}'", CexVitrProc, god, mes, isp_cx, isp_uch, isp_brig, isp_det);
            if (vibor == "pustie")
            {
                query = string.Format(@"UPDATE [Repairs].[dbo].Vedomost_Resursov SET {0} = podpisi.{0}
FROM Vedomost_Resursov ved_r
INNER JOIN (SELECT [ID] ,[RepairID],[FIO1f2],[dolg1f2],[FIO2f2],[dolg2f2],[FIO3f2],[dolg3f2],[FIO4f2],[dolg4f2],[FIO5f2],[dolg5f2]
 FROM [Repairs].[dbo].[PodpisiForAktF2] where RepairID  in 
(select RepairID  from Vedomost_Resursov  where  (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}' and Ispolnitel_codcx='{3}') )
) podpisi ON ved_r.RepairID  = podpisi.RepairID
where  YEAR(ved_r.PeriodData2)='{1}' and  MONTH(ved_r.PeriodData2)='{2}' and ved_r.Ispolnitel_codcx='{3}' and( ved_r.{0} is null or len(ved_r.{0})=0)", NamPole, god, mes, isp_cx);
            }

            if (vibor == "all")
            {
                query = string.Format(@"UPDATE [Repairs].[dbo].Vedomost_Resursov SET {0} = podpisi.{0}
FROM Vedomost_Resursov ved_r
INNER JOIN (SELECT [ID] ,[RepairID],[FIO1f2],[dolg1f2],[FIO2f2],[dolg2f2],[FIO3f2],[dolg3f2],[FIO4f2],[dolg4f2],[FIO5f2],[dolg5f2]
 FROM [Repairs].[dbo].[PodpisiForAktF2] where RepairID  in 
(select RepairID  from Vedomost_Resursov  where  (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}' and Ispolnitel_codcx='{3}') )
) podpisi ON ved_r.RepairID  = podpisi.RepairID
where  YEAR(ved_r.PeriodData2)='{1}' and  MONTH(ved_r.PeriodData2)='{2}' and ved_r.Ispolnitel_codcx='{3}'", NamPole, god, mes, isp_cx);
            }


            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }

        //заміна ТЗВ по актам (відомості ресурсів) за поточний місяць, рік  по цеху 
        public bool UpdateVedResAKT_TZV_ForCehUth(string IspCeh, string IspUth, string IspBr, string TZV, string god, string mes, string vibor2, string vibor4)
        {
            bool flag = false;
            string query = string.Format("");
            string add_filter = "";

            switch (vibor4)
            {
                case "ceh":
                    add_filter = " and Ispolnitel_codcx='" + IspCeh + "'";
                    break;
                case "ceh_uth":
                    add_filter = " and Ispolnitel_codcx='" + IspCeh + "' and Ispolnitel_coduth='" + IspUth + "'";
                    break;
                case "ceh_uth_br":
                    add_filter = " and Ispolnitel_codcx='" + IspCeh + "' and Ispolnitel_coduth='" + IspUth + "' and Ispolnitel_codbrig='" + IspBr + "'";
                    break;


            }

            switch (IspCeh)
            {
                case "50":

                    switch (IspUth)
                    {
                        case "7":
                            break;
                        case "2":
                        case "5":
                            {
                                if (vibor2 == "pustie")
                                {
                                    query = string.Format(@" update Vedomost_Resursov set TZV='{0}'  where (TZV=0 or TZV is null) and (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}' and Zakazchik_codcx<>'" + IspCeh + "' " + add_filter + ")", TZV, god, mes);
                                }
                                else
                                {
                                    query = string.Format(@" update Vedomost_Resursov set TZV='{0}'  where (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}' and Zakazchik_codcx<>'" + IspCeh + "' " + add_filter + ")", TZV, god, mes);
                                }

                            }
                           break;
                        default:
                            {
                                if (vibor2 == "pustie")
                                {
                                    query = string.Format(@" update Vedomost_Resursov set TZV='{0}'  where (TZV=0 or TZV is null) and (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}'" + add_filter + ")", TZV, god, mes);
                                }
                                else
                                {
                                    query = string.Format(@" update Vedomost_Resursov set TZV='{0}'  where (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}'" + add_filter + ")", TZV, god, mes);
                                }
                                
                            }
                            break;
                    }
                    break;
                default:
                    if (vibor2 == "pustie")
                    {
                        query = string.Format(@" update Vedomost_Resursov set TZV='{0}'  where (TZV=0 or TZV is null) and (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}'" + add_filter + ")", TZV, god, mes);
                    }
                    else
                    {
                        query = string.Format(@" update Vedomost_Resursov set TZV='{0}'  where (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}'" + add_filter + ")", TZV, god, mes);
                    }
                    break;
            }
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }


        //заміна ТЗВ по актам (відомості ресурсів) за поточний місяць, рік  по цеху 
        public bool UpdateVedResAKT_CexVitrProc_ForCehUth(string IspCeh, string IspUth, string IspBr,string CexVitrProc, string god, string mes, string vibor2,string vibor4 )
        {
            bool flag = false;
            string query = string.Format("");
            string add_filter="";

            switch (vibor4)
            { 
                case "ceh":
                    add_filter = " and Ispolnitel_codcx='"+IspCeh+"'";
                    break;
                case "ceh_uth":
                    add_filter = " and Ispolnitel_codcx='"+IspCeh+"' and Ispolnitel_coduth='"+IspUth+"'";
                    break;
                case "ceh_uth_br":
                    add_filter = " and Ispolnitel_codcx='" + IspCeh + "' and Ispolnitel_coduth='" + IspUth + "' and Ispolnitel_codbrig='" + IspBr + "'";
                    break;

            
            }

            switch (IspCeh)
            {
                case "50" :
                case "54" :
                    if (vibor2 == "pustie")
                    {
                        query = string.Format(@" update Vedomost_Resursov set cexVitrProc='{0}'  where (cexVitrProc=0 or cexVitrProc is null) and (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}'  and  Zakazchik_codcx<>'"+IspCeh+"' " + add_filter + ")", CexVitrProc, god, mes);
                    }
                    else
                    {
                        query = string.Format(@" update Vedomost_Resursov set cexVitrProc='{0}'  where (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}' and  Zakazchik_codcx<>'"+IspCeh+"' " + add_filter + ")", CexVitrProc, god, mes);
                              
                    }
                    break;
                default:
                    if (vibor2 == "pustie")
                    {
                        query = string.Format(@" update Vedomost_Resursov set cexVitrProc='{0}'  where (cexVitrProc=0 or cexVitrProc is null) and (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}'" + add_filter + ")", CexVitrProc, god, mes);
                    }
                    else
                    {
                        query = string.Format(@" update Vedomost_Resursov set cexVitrProc='{0}'  where (YEAR(PeriodData2)='{1}' and  MONTH(PeriodData2)='{2}'" + add_filter + ")", CexVitrProc, god, mes);
                    }
                    break;
            }
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }

        //заміна амортизації по актам (відомості ресурсів) за поточний місяць, рік  по МВО
        public bool UpdateVedResAKTamortProc(string amortProc, string god, string mes, string isp_cx, string isp_uch, string isp_brig, string isp_det)
        {
            bool flag = false;
            string query = string.Format(@"update Vedomost_Resursov 
  set amortProc= '{0}' where YEAR(PeriodData1)='{1}' and  MONTH(PeriodData1)='{2}' and Ispolnitel_codcx='{3}' and Ispolnitel_coduth='{4}'
  and Ispolnitel_codbrig='{5}' and Ispolnitel_coddet='{6}'", amortProc, god, mes, isp_cx, isp_uch, isp_brig, isp_det);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }


        public bool UpdateVedResAKT_ZP(string idved_r,string zp, string vidrah)
        {
            bool flag = false;
            string query = string.Format(@"update Vedomost_Resursov set vsegoZP='{0}',sumNalogov='{1}' where id='{2}'", zp.Replace(",", "."), vidrah.Replace(",", "."), idved_r);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }


        public bool UpdateVedRes_with_nol(string nam_pole)
        {
            bool flag = false;
            string query = string.Format(@"update Vedomost_Resursov set " + nam_pole + " =0  where "+nam_pole+" is null");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }


        public bool UpdateVedResAKT_ZP2(string idved_r, double df6, double df7, double df1, double df10, double vsego_F, double vsego_Mat)
       {
            bool flag = false;
            string query = string.Format(@"update Vedomost_Resursov set [vidrahProc]='{0}',[tzvGrn]='{1}',[cehVitrGrn]='{2}',[amortGrn]='{3}',[vsego_F]='{4}',vsegoMat='{5}' where id='{6}'", df1.ToString().Replace(",", "."), df10.ToString().Replace(",", "."), df6.ToString().Replace(",", "."), df7.ToString().Replace(",", "."), vsego_F.ToString().Replace(",", "."), vsego_Mat.ToString().Replace(",", "."), idved_r);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }


        //заміна ТЗВ по актам (відомості ресурсів) за поточний місяць, рік  по МВО
        public bool UpdateVedResAKTTZV(string TZV, string god, string mes, string isp_cx, string isp_uch, string isp_brig, string isp_det)
        {
            bool flag = false;
            string query = string.Format(@"update Vedomost_Resursov 
  set TZV= '{0}' where YEAR(PeriodData1)='{1}' and  MONTH(PeriodData1)='{2}' and Ispolnitel_codcx='{3}' and Ispolnitel_coduth='{4}'
  and Ispolnitel_codbrig='{5}' and Ispolnitel_coddet='{6}'", TZV, god, mes, isp_cx, isp_uch, isp_brig, isp_det);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }




        public ArrayList TekMesGod()
        {
            ArrayList mesgod = new ArrayList();
            string query = string.Format(@"SELECT god,mes FROM  [Repairs].[dbo].[Status_mes] where Status_mes=0 and tek_mes=1");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            mesgod.Add(result);
                        }
                    }
                }
                catch { }
            }

            return mesgod;
        }
       



        // Закрываем месяц
          public bool UpdateZakrMes(string tekgod, string tekmes, int nextgod, int nextmes)
        {
            bool flag = false;
            string query = string.Format(@"update Status_mes 
               set Status_mes=1 ,tek_mes=0  where god='{0}' and mes='{1}'", tekgod, tekmes);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flag;
        }


          // редактируем ШПЗ в актах по услугам
          public bool UpdateShpzAktiUsl(string id, string shpz)
          {
              bool flag = false;
              string query = string.Format(@"update Akti_usl set Shpz='{0}' where id='{1}'", shpz, id);
              using (SqlConnection con = new SqlConnection(constr))
              {
                  SqlCommand com = new SqlCommand(query, con);
                  try
                  {
                      con.Open();
                      if (com.ExecuteNonQuery() >= 1)
                      {
                          flag = true;
                      }
                  }
                  catch (Exception)
                  {
                  }
              }
              return flag;
          }



          // При Открытии месяца проверяем есть ли запись с последующим месяцем, годом. Если нет, то добавляем ее(NewZapisInsertMes)
          public int NewZapisOpenMes(int nextgod, int nextmes)
          {
            int kolzap = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string query = @" SELECT max(ID)  FROM Acts";
                string query = string.Format(@"select count(god) from Status_mes  where god='{0}' and mes='{1}'", nextgod, nextmes);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    kolzap = Convert.ToInt32(com.ExecuteScalar());
                }
                catch
                {
                    kolzap = 0;
                }
            }
            return kolzap;
          }


        
          // Добавляем запись с последующим месяцем, годом. 
          public bool NewZapisInsertMes(int nextgod, int nextmes)
          {
              bool flag = false;
              string query = string.Format(@"  insert into Status_mes (god,mes,status_mes,tek_mes) values ('{0}','{1}','0','0')", nextgod, nextmes);
              using (SqlConnection con = new SqlConnection(constr))
              {
                  SqlCommand com = new SqlCommand(query, con);
                  try
                  {
                      con.Open();
                      if (com.ExecuteNonQuery() >= 1)
                      {
                          flag = true;
                      }
                  }
                  catch (Exception)
                  {
                  }
              }
              return flag;
          }


          // Открываем месяц
          public bool UpdateOpenMes(string tekgod, string tekmes, int nextgod, int nextmes)
          {
              bool flag = false;
              string query = string.Format(@"update Status_mes 
               set Status_mes=0 ,tek_mes=1  where god='{0}' and mes='{1}'", nextgod, nextmes);
              using (SqlConnection con = new SqlConnection(constr))
              {
                  SqlCommand com = new SqlCommand(query, con);
                  try
                  {
                      con.Open();
                      if (com.ExecuteNonQuery() >= 1)
                      {
                          flag = true;
                      }
                  }
                  catch (Exception)
                  {
                  }
              }
              return flag;
          }


        // выбираем код работы
        public int SelectJobCode(string partID)
        {
            int JobCode = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string query = string.Format(@" SELECT MAX(NomPTO) FROM PTO WHERE YEAR(Data2PTO) ='{0}' ", YearDat2);

                string query = string.Format(@"select top 1 JobCode from job where RepairId='{0}' ", partID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    JobCode = Convert.ToInt32(com.ExecuteScalar());
                }
                catch
                {
                    JobCode = 0;
                }
            }
            return JobCode;
        }




        public bool UpdateShpz(string shpz,string tek_mes, string tek_god,int kodrem, int cex)
        {
            bool flagSum = false;
            //string query = string.Format("update ReplacedPart set Original = 1, VedomostNumber = '{0}' where ReplacedId = '{1}'", NumberVedomost, ReplacedId);
            string query = string.Format(@"update Vedomost_Resursov set shpz='{0}' where month(PeriodData2)='{1}' and year(PeriodData2)='{2}' and kod_rem='{3}' and 
                          ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) and Ispolnitel_codcx='{4}'", shpz, tek_mes, tek_god,kodrem,cex);
            Debug.Write(query);
            Debug.Write("***************");
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }


        public bool UpdateShpz2(string shpz, int kodrem)
        {
            bool flagSum = false;
            //string query = string.Format("update ReplacedPart set Original = 1, VedomostNumber = '{0}' where ReplacedId = '{1}'", NumberVedomost, ReplacedId);
            string query = string.Format(@"update Vedomost_Resursov set shpz='{0}' where kod_rem='{1}' and  ( (len(rtrim(ltrim(shpz))))<1 or shpz is null) ", shpz, kodrem);
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
        }





        public bool Update_Ch_chas(int IDJob, string Ch_chas)
        {
            
            bool flagSum = false;
            string query = string.Format("update Jobs_FromAktF2 set ch_chas = '{0}'  where Id = '{1}'", Ch_chas,IDJob );
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        flagSum = true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return flagSum;
            
        }


        // выбираем код работы
        public string  SelectB_Bal_cena(string invnum,string objekt)
        {
            //double B_bal_cena = 0;
            string B_bal_cena = "";
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string query = string.Format(@" SELECT MAX(NomPTO) FROM PTO WHERE YEAR(Data2PTO) ='{0}' ", YearDat2);

                string query = string.Format(@"select b_bal_cena from SprOS where InventoryNumber='{0}' and  Obekt='{1}'", invnum, objekt);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    string s = com.ExecuteScalar().ToString();
                   // s = s.Replace('.', ',');
                    //B_bal_cena = Convert.ToDouble(s);
                    B_bal_cena = s.ToString();
                }
                catch
                {
                    B_bal_cena = "99999999999999";
                    //B_bal_cena = 0;
                }
            }
            return B_bal_cena;
        }





        // выбираем код работы
        public double SelectB_Bal_cena_double(string invnum, string objekt)
        {
            //double B_bal_cena = 0;
            double B_bal_cena = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string query = string.Format(@" SELECT MAX(NomPTO) FROM PTO WHERE YEAR(Data2PTO) ='{0}' ", YearDat2);

                string query = string.Format(@"select b_bal_cena2 from SprOS where InventoryNumber='{0}' and  Obekt='{1}'", invnum, objekt);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    double s = Convert.ToDouble(com.ExecuteScalar());
                    // s = s.Replace('.', ',');
                    //B_bal_cena = Convert.ToDouble(s);
                    B_bal_cena = s;
                }
                catch
                {
                    B_bal_cena =999999999999;
                    //B_bal_cena = 0;
                }
            }
            return B_bal_cena;
        }




        public ArrayList TekMesGodForCeh(string nomceh)
        {
            ArrayList mesgodceh = new ArrayList();
            string query = string.Format(@"select StoreId,god,mes from  [Repairs].[dbo].[Status_mes_ceh] where  StoreId ='{0}'", nomceh);
            
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            mesgodceh.Add(result);
                        }
                    }
                }
                catch { }
            }

            return mesgodceh;
        }
       

        //     public string SumPoInv2(string InventoryNumber)
//        {
//            bool flagSum = false;
//                            string query = string.Format(@"select sum(prace*Quantity) as sum from Repair inner join ReplacedPart RP on RP.RepairID=Repair.RepairID  
//                  where (Repair.InventoryNumber = '{0}')  and Original=0 ", InventoryNumber);

//            using (SqlConnection con = new SqlConnection(constr))
//            {
//                SqlCommand com = new SqlCommand(query, con);
//                try
//                {
//                    con.Open();
//                    if (com.ExecuteNonQuery() >= 1)
//                    {
//                        flagSum = true;
//                    }
//                }
//                catch (Exception)
//                {
//                }
//            }
//            return query;
//        }
     
    
    
    
    }
    
}






