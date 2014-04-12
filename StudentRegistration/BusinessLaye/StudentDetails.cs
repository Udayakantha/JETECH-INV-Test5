using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//using System.Xml;

namespace BusinessLaye
{
   public class StudentDetails
    {
       DataAccessLayer.DataReceive objDataReceive = new DataAccessLayer.DataReceive();


        public static int mMaxId;
        public static DataTable mStuentGridData ;

       
       public DataTable StuentGridData
       {
           get { return mStuentGridData; }
           set { mStuentGridData = value; } 
       }

       public int MaxId
       {
           get { return mMaxId; }
           set { mMaxId = value; }
       }


       public int BGetMaxSTDNo()
       {
           return MaxId = objDataReceive.GetMaxSTDNo();
       }

       public int BBulkInsert()
       {
           return objDataReceive.BulkInsert(mStuentGridData );
       }

       public int  BBulkInsert(DataTable dt)
       {
           return objDataReceive.BulkInsert(dt);
       }

       public DataTable BLoadGridData()
       {
           return objDataReceive.LoadGridData();
       }
    }
}
