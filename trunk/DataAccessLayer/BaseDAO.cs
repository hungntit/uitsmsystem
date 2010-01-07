using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    
    class BaseDAO
    {
       protected internal  SqlConnection sqlCon;
       public BaseDAO()
       {
           sqlCon = new SqlConnection();
           string database = "QLDKMONHOC_HOCPHI";
           string strCon = "server=(local);database=" + database;
           sqlCon.ConnectionString = strCon;
           try
           {

               sqlCon.Open();
           }
           catch (Exception e)
           {
               throw e;
           }
       }
         public BaseDAO(string user,string password)
       {
           sqlCon = new SqlConnection();
           string database = "QLDKMONHOC_HOCPHI";
           string strCon = "server=(local);database=" + database;
           strCon += ";uid=" + user + ";pwd=" + password;
           sqlCon.ConnectionString = strCon;
           try
           {

               sqlCon.Open();
           }
           catch (Exception e)
           {
               throw e;
           }
       }
       public  void CloseConection()
       {
           if (sqlCon.State != ConnectionState.Closed)
           {
               sqlCon.Close();
               sqlCon.Dispose();
           }
       }
    }
}
