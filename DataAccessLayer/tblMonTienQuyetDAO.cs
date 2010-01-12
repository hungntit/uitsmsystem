using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
{
   public class tblMonTienQuyetDAO:BaseDAO
    {
       public tblMonTienQuyetDAO()
            : base()
        {
            
        }
       public tblMonTienQuyetDAO(string user, string password)
            : base(user,password)
        {

        }

       public void insertTblMonTienQuyet(tblMonhoc monhoc, tblMonhoc montienquyet)
       {
           string QueryStr = "INSERT INTO " + "MON_TIEN_QUYET"
                            + "("
                           + tblMonhoc.sMA_MON
                           + ","

                           + "MA_MON_TIEN_QUYET"
                           + ") "
                           + "VALUES(?,?)";



           SqlCommand sqlcommand = null;
           try
           {
               sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
               sqlcommand.CommandType = System.Data.CommandType.Text;
               sqlcommand.Parameters.AddWithValue(tblMonhoc.sMA_MON, monhoc.MaMon);
               sqlcommand.Parameters.AddWithValue("MA_MON_TIEN_QUYET", montienquyet.MaMon);
              

               sqlcommand.Prepare();
               sqlcommand.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               throw e;
           }
           finally
           {
               if (sqlcommand != null)
                   sqlcommand.Dispose();


           }
       }


       public void deleteTblMonTienQuyet(String mamonhoc, String mamontienquyet)
       {
           
             try
             {
                 deleteObj("MON_TIET_QUYET", tblMonhoc.sMA_MON, mamonhoc, "MA_MON_TIEN_QUYET", mamontienquyet);
             }
             catch (Exception e)
             {
                 throw e;
             }
             
       }
    }
}
