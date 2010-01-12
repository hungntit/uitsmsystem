using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
{
   public class tblChiTietDangKyDAO:BaseDAO
    {
       public tblChiTietDangKyDAO()
            : base()
        {
            
        }
       public tblChiTietDangKyDAO(string user, string password)
            : base(user,password)
        {

        }

       public void insertTblChiTietDangKy(tblPhieuDangKy phieudk, tblLopDangKy lopdk)
       {
           string QueryStr = "INSERT INTO " + "CHI_TIET_DANG_KY"
               + "("
                           + tblPhieuDangKy.sMA_PHIEU
                           + ","

                           + tblLopDangKy.sMA_LOP
                           + ") "
                           + "VALUES(@a,@b)";



           SqlCommand sqlcommand = null;
           try
           {
               sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
               sqlcommand.CommandType = System.Data.CommandType.Text;
               sqlcommand.Parameters.AddWithValue("@a", phieudk.MaPhieuDK);
               sqlcommand.Parameters.AddWithValue("@b", lopdk.MaLop);
              

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


       public void deleteTblChiTietDangKy(String maphieu, String maLopDK)
       {
           
             try
             {
                 deleteObj("CHI_TIET_DANG_KY", tblLopDangKy.sMA_LOP, maLopDK, tblPhieuDangKy.sMA_PHIEU, maphieu);
             }
             catch (Exception e)
             {
                 throw e;
             }
             
       }
    }
}
