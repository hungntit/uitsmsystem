using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
{
   public class tblBangDiemDAO:BaseDAO
    {
       public tblBangDiemDAO()
            : base()
        {
            
        }
       public tblBangDiemDAO(string user, string password)
            : base(user,password)
        {

        }

       public void insertTblBangDiem(String MaSV, String maLopDK,float diem)
       {
           string QueryStr = "INSERT INTO " + "BANG_DIEM"
               + "("
                           + tblSinhVien.sMASV
                           + ","

                           + tblLopDangKy.sMA_LOP
                           + ","
                           +"DIEM"
                           + ") "
                           + "VALUES(@a,@b,@c)";



           SqlCommand sqlcommand = null;
           try
           {
               sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
               sqlcommand.CommandType = System.Data.CommandType.Text;
               sqlcommand.Parameters.AddWithValue("@a", MaSV);
               sqlcommand.Parameters.AddWithValue("@b", maLopDK);
               sqlcommand.Parameters.AddWithValue("@c", diem);
              

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


       public void deleteTblBangDiem(String MaSV, String maLopDK)
       {
           
             try
             {
                 deleteObj("BANG_DIEM", tblSinhVien.sMASV, MaSV, tblLopDangKy.sMA_LOP, maLopDK);
             }
             catch (Exception e)
             {
                 throw e;
             }
             
       }


       public void updateTblBangDiem(String MaSV, String maLopDK, float diem)
       {
           string QueryStr = "UPDATE BANG_DIEM "

                           + "SET "
                           + "DIEM" + " = @c"
                           + "WHERE " + tblLopDangKy.sMA_LOP + " = @a AND "
                           + tblSinhVien.sMASV + " = @b  ";

           SqlCommand sqlcommand = null;
           try
           {
               sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
               sqlcommand.CommandType = System.Data.CommandType.Text;
               sqlcommand.Parameters.AddWithValue("@a", MaSV);
               sqlcommand.Parameters.AddWithValue("@b", maLopDK);
               sqlcommand.Parameters.AddWithValue("@c", diem);
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

    }
}
