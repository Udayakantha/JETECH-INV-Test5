using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
   public class DataReceive
    {
        public int intErrorNo = 0;
        private SqlDataAdapter objAdapter = new SqlDataAdapter();
        private SqlCommand objCommand;


        public DataTable LoadGridData()
        {
            try
            {
                intErrorNo = Connection.OpenDefaultConnection();
                if (intErrorNo != 0)
                {
                    return null;
                }
                else
                {
                    objCommand = new SqlCommand();
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "LoadGridData";

                    //  SqlParameter ParamError = new SqlParameter("@ErrorNo", SqlDbType.Int);
                    //ParamError.Direction = ParameterDirection.Output;
                    //objCommand.Parameters.Add(ParamError);
                     objCommand.Connection = Connection.objCon;
                    objAdapter.SelectCommand = objCommand;
                    objCommand.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    objAdapter.Fill(dt);
                    return dt;

                }
            }
            catch
            {

                return null;
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        public int BulkInsert( DataTable  dt)
        {
            intErrorNo = Connection.OpenDefaultConnection();
            if (intErrorNo != 0)
            {
                return intErrorNo;
            }
            else
            {
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(Connection.objCon))
            {
                
                     bulkCopy.DestinationTableName = "dbo.Registration";

                     try
                     {
                         bulkCopy.WriteToServer(dt);
                         return 1;
                     }
                     catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return 0;
                        }

                     finally
                     {
                         Connection.CloseConnection();
                     }
                 }
            }

          
        }

       public int GetMaxSTDNo()
       {
           try
           {
               intErrorNo = Connection.OpenDefaultConnection();
               if (intErrorNo != 0)
               {
                   return intErrorNo;
               }
               else
               {
                   objCommand = new SqlCommand();
                   objCommand.CommandType = CommandType.StoredProcedure;
                   objCommand.CommandText = "GetMaxSTDNO";

                   objCommand.Connection = Connection.objCon;
                   objAdapter.SelectCommand = objCommand;

                   String strVal = objCommand.ExecuteScalar().ToString();
                   if (strVal == "")
                   { return 0; }
                   else
                   { return int.Parse(strVal); }
                    
               }
           }
           catch
           {

               return 2010;
           }
           finally
           {
               Connection.CloseConnection();
           }
       } 

    }
}
