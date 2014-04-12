using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
 public  static  class Connection
    {
        private static  String strConnectionString = "";
        public static SqlConnection objCon;
       

        public static int OpenDefaultConnection()
        {
           
            try
            {
                SqlConnectionStringBuilder SQLBulder = new SqlConnectionStringBuilder(strConnectionString);
                SQLBulder.DataSource = "UDAUAKANTHA-PC";
                SQLBulder.InitialCatalog = "Test5";
                SQLBulder.IntegratedSecurity = true;
                SQLBulder.ConnectTimeout = 0;
                objCon = new SqlConnection(SQLBulder.ConnectionString);
                objCon.Open();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 18456)
                {
                    return 2002;
                }
                else
                {
                    return 2001;
                }
            }

        }

        static public void CloseConnection()
        {
            objCon.Close();
            objCon.Dispose();
        }

     

    }
}
