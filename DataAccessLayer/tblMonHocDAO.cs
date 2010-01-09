using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    class tblMonHocDAO:BaseDAO
    {
        public tblMonHocDAO()
            : base()
        {
            
        }
        public tblMonHocDAO(string user,string password)
            : base(user,password)
        {

        }
        /*
         *@ Lay Thong tin giang vien boi MaGV
         *@ MaGV: maSV can tim 
         */ 
        public tblMonhoc getbyMaMonHoc(String maMon)
        {
            tblMonhoc monhoc = null;
            string QueryStr = "Select * from MON_HOC where MA_MON  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MaMon", maMon);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String MaMon = sqldtRd.GetString(0);
                    String tenMon = sqldtRd.GetString(1);
                    int sotclythuyet = sqldtRd.GetInt32(2);
                    int sotcthuchanh = sqldtRd.GetInt32(3);

                    monhoc = new tblMonhoc(MaMon, tenMon, sotclythuyet, sotcthuchanh);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlcommand != null)
                    sqlcommand.Dispose();
                if (sqldtRd != null)
                    sqldtRd.Close();
               
            }

            return monhoc;
            
        }
        private List<tblMonhoc> getAllMonHoc(int begin,int end,Boolean All)
        {
            List<tblMonhoc> list = new List<tblMonhoc>();


            string QueryStr = "Select * from MON_HOC";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
               
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblMonhoc monhoc = null;
                    String MaMon = sqldtRd.GetString(0);
                    String tenMon = sqldtRd.GetString(1);
                    int sotclythuyet = sqldtRd.GetInt32(2);
                    int sotcthuchanh = sqldtRd.GetInt32(3);

                    monhoc = new tblMonhoc(MaMon, tenMon, sotclythuyet, sotcthuchanh);
                    list.Add(monhoc);
                }
                if (!All)
                {
                    list.RemoveRange(end, list.Count - end);
                    list.RemoveRange(0, begin);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlcommand != null)
                    sqlcommand.Dispose();
                if (sqldtRd != null)
                    sqldtRd.Close();

            }
            return list;


        }
        public List<tblMonhoc> getAllMonHoc(int begin, int end)
        {
            return getAllMonHoc(begin, end, false);
        }
        public List<tblMonhoc> getAllMonHoc()
        {
            return getAllMonHoc(0, 0, true);
        }
        public int CountMonHoc()
        {
            int result = 0;


            string QueryStr = "Select COUNT(MA_MON_HOC) AS COUNTMAMH from MON_HOC";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;

                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    result = sqldtRd.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlcommand != null)
                    sqlcommand.Dispose();
                if (sqldtRd != null)
                    sqldtRd.Close();

            }
            return result ;


        }


        public List<tblMonhoc> getAllMonHocTienQuyet(String MaMonhoc)
        {
            List<tblMonhoc> list = new List<tblMonhoc>();


            string QueryStr = "SELECT MTQ.* "
                            + "FROM MON_HOC MH,MON_HOC MTQ,MON_TIEN_QUYET "
                            + "MH.MA_MON = MON_TIEN_QUYET.MA_MON AND "
                            + "MON_TIEN_QUYET.MA_MON_TIEN_QUYET = MTQ.MA_MON "
                            + "MH.MA_MON = ? " ;
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_MON", MaMonhoc);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblMonhoc monhoc = null;
                    String MaMon = sqldtRd.GetString(0);
                    String tenMon = sqldtRd.GetString(1);
                    int sotclythuyet = sqldtRd.GetInt32(2);
                    int sotcthuchanh = sqldtRd.GetInt32(3);

                    monhoc = new tblMonhoc(MaMon, tenMon, sotclythuyet, sotcthuchanh);
                    list.Add(monhoc);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlcommand != null)
                    sqlcommand.Dispose();
                if (sqldtRd != null)
                    sqldtRd.Close();

            }
            return list;


        }

    }
}
