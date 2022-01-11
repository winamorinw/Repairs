using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data.Common;

namespace Repairs
{
    //string constr = Properties.Settings.Default.
    class DAL_Kontragent
    {
        string constr = Properties.Settings.Default.UppSettings;

        public ArrayList GetAllKontragent()
        {
            ArrayList allJobsForAll = new ArrayList();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = @" Select 
                            Kontragentj._Code , 
                            Kontragentj._Description , 
                            Kontragentj._Fld1873 
                                From 
                            _Reference114 As Kontragentj";
                SqlCommand com = new SqlCommand(query, con);
                try {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows) {
                        foreach (DbDataRecord result in dr)
                            allJobsForAll.Add(result);
                    }
                }
                catch { }
            }
            return allJobsForAll;
        }

    }
}
