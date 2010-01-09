using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
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
         protected void getObjByAttribute(SqlDataReader sqldtrd,SqlCommand sqlcommand,ParamSQL[] paramSQLs, String tableName)
         {
             if (paramSQLs == null)
             {
                 throw new Exception("No paramSQL init");
                
             }
             String sql = "SELECT * FROM " + tableName + " "
                 + "WHERE ";
             IEnumerator listSQL =         paramSQLs.GetEnumerator();
             ParamSQL firstparam = (ParamSQL) listSQL.Current;
             if(firstparam.Value is String)
                sql += firstparam.Name + " LIKE ? ";
             else
                 sql += firstparam.Name + " = ? ";
            while (listSQL.MoveNext())
             {
                 ParamSQL paramSQL = (ParamSQL)listSQL.Current;
               if (paramSQL != null)
               {
                   if (firstparam.Value is String)
                       sql += "AND " + firstparam.Name + " like ? ";
                   else
                         sql += "AND " + paramSQL.Name + " = ? ";

               }
             }
            try
            {
                sqlcommand = new SqlCommand(sql, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                foreach (ParamSQL param in paramSQLs)
                {
                    if (param != null)
                    {
                        sqlcommand.Parameters.AddWithValue(param.Name, param.Value);
                    }
                }
                
                sqlcommand.Prepare();
                sqldtrd = sqlcommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcommand != null)
                    sqlcommand.Dispose();
                
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
