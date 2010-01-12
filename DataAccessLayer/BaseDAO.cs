using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace DataAccessLayer
{
    
   public class BaseDAO
    {
       protected internal  SqlConnection sqlCon;
       public BaseDAO()
       {
           sqlCon = new SqlConnection();
           string database = "QLSV";
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
         public void deleteObj(string TableName,string IDName,Object value)
         {
             string QueryStr = "Delete from " + TableName
                                 + " where " + IDName + "= ? " ;

             SqlCommand sqlcommand = null;
             try
             {
                 sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                 sqlcommand.CommandType = System.Data.CommandType.Text;
                 sqlcommand.Parameters.AddWithValue(IDName, value);
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


         public void deleteObj(string TableName, string IDName1, Object value1, string IDName2, Object value2)
         {
             string QueryStr = "Delete from " + TableName
                                 + " where " + IDName1 + "= ? AND "
                                 + IDName2 + "= ?  ";

             SqlCommand sqlcommand = null;
             try
             {
                 sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                 sqlcommand.CommandType = System.Data.CommandType.Text;
                 sqlcommand.Parameters.AddWithValue(IDName1, value1);
                 sqlcommand.Parameters.AddWithValue(IDName2, value2);
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
