using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
{
   public class tblGiangDayDAO:BaseDAO
    {
       public tblGiangDayDAO()
            : base()
        {
            
        }
       public tblGiangDayDAO(string user, string password)
            : base(user,password)
        {

        }

       public void insertTblGiangDay(tblGiangVien giangvien, tblMonhoc monhoc)
       {
           string QueryStr = "INSERT INTO " + "GIANG_DAY"
                            + "("
                           + tblMonhoc.sMA_MON
                           + ","

                           + tblGiangVien.sMA_GIANG_VIEN
                           + ") "
                           + "VALUES(?,?)";



           SqlCommand sqlcommand = null;
           try
           {
               sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
               sqlcommand.CommandType = System.Data.CommandType.Text;
               sqlcommand.Parameters.AddWithValue(tblMonhoc.sMA_MON, monhoc.MaMon);
               sqlcommand.Parameters.AddWithValue(tblGiangVien.sMA_GIANG_VIEN, giangvien.MaGiangVien);
              

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

       
       public void deleteTblGiangDay(String mamonhoc,String maGV)
       {
           
             try
             {
                 deleteObj("GIANG_DAY", tblGiangVien.sMA_GIANG_VIEN, maGV, tblMonhoc.sMA_MON, mamonhoc);
             }
             catch (Exception e)
             {
                 throw e;
             }
             
       }
    }
}
