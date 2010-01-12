using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblKhoaDAO : BaseDAO
    {
        public tblKhoaDAO()
            : base()
        {
            
        }
        public tblKhoaDAO(string user,string password)
            : base(user,password)
        {

        }

        public void insertTblKhoa(tblKhoa khoa)
        {
            string QueryStr = "INSERT INTO " + tblKhoa.sTABLE_NAME 
                            +"("
                            +tblKhoa.sMA_KHOA 
                            + ","
                            + tblKhoa.sTEN_KHOA 
                            +") "
                            + "VALUES(?,?)";



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblKhoa.sMA_KHOA, khoa.MaKhoa);
                sqlcommand.Parameters.AddWithValue(tblKhoa.sTEN_KHOA, khoa.TenKhoa);
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

        public void updateTblKhoa(tblKhoa khoa)
        {
            string QueryStr = "UPDATE " + tblKhoa.sTABLE_NAME + " "
                            + " WHERE " + tblKhoa.sMA_KHOA + " = ? "
                            + "SET "
                            + tblKhoa.sTEN_KHOA + " = ?" ;


            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblKhoa.sMA_KHOA, khoa.MaKhoa);
                sqlcommand.Parameters.AddWithValue(tblKhoa.sTEN_KHOA, khoa.TenKhoa);
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
        public void deleteTblKhoa(String makhoa)
        {
             this.deleteObj("KHOA", "MA_KHOA", makhoa);
        }
        /*
         *@ Lay Thong tin Khoa boi MaKhoa
         *@ MaGV: maSV can tim 
         */ 
        public tblKhoa getbyMaKhoa(String maKhoa)
        {
            tblKhoa khoa = null;
            string QueryStr = "Select * from KHOA where MA_KHOA  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_KHOA", maKhoa);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String MaKhoa = sqldtRd.GetString(0);
                    String tenKhoa = sqldtRd.GetString(1);


                    khoa = new tblKhoa(MaKhoa, tenKhoa);
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

            return khoa;
            
        }
        /****************************************/
        private List<tblKhoa> getAllKhoa(int begin,int end,Boolean All)
        {
            List<tblKhoa> list = new List<tblKhoa>();


            string QueryStr = "Select * from KHOA ";
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
                    tblKhoa khoa = null;
                    String maKhoa = sqldtRd.GetString(0);
                    String tenKhoa = sqldtRd.GetString(1);


                    khoa = new tblKhoa(maKhoa, tenKhoa);
                    list.Add(khoa);
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
        public List<tblKhoa> getAllKhoa(int begin, int end)
        {
            return getAllKhoa(begin, end, false);
        }
        public List<tblKhoa> getAllKhoa()
        {
            return getAllKhoa(0, 0, true);
        }

        public int CountKhoa()
        {
            int result  =   0;


            string QueryStr = "Select COUNT(MA_KHOA) from KHOA ";
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
                    result  =   sqldtRd.GetInt32(0);
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
            return result;


        }
        /*************************************************/

        /*
        private List<tblMonhoc> getAllMonHoc(String MaKhoa,int begin,int end,Boolean All)
        {
            List<tblMonhoc> list = new List<tblMonhoc>();


            string QueryStr = "SELECT MON_HOC.* "
                            + "from MON_HOC,DAO_TAO,KHOA "
                            + "MON_HOC.MA_MON = DAO_TAO.MA_MON AND "
                            + "DAO_TAO.MA_KHOA = KHOA.MA_KHOA AND "
                            + " KHOA.MA_KHOA = ? ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_KHOA", MaKhoa);
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
        public List<tblMonhoc> getAllMonHoc(String MaKhoa, int begin, int end)
        {
            return getAllMonHoc(MaKhoa,begin, end, false);
        }
        public List<tblMonhoc> getAllMonHoc(String MaKhoa)
        {
            return getAllMonHoc(MaKhoa, 0, 0, true);
        }

        public int CountMonHoc(String MaKhoa)
        {
            int result = 0;


            string QueryStr = "SELECT COUNT(MON_HOC.MA_MON) AS COUNTMAMON"
                            + "from MON_HOC,DAO_TAO,KHOA "
                            + "MON_HOC.MA_MON = DAO_TAO.MA_MON AND "
                            + "DAO_TAO.MA_KHOA = KHOA.MA_KHOA AND "
                            + " KHOA.MA_KHOA = ? ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_KHOA", MaKhoa);
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
            return result;


        }
         
        */

    }
}
