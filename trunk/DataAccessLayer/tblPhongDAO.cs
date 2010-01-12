using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblPhongDAO : BaseDAO
    {
        public tblPhongDAO()
            : base()
        {
            
        }
        public tblPhongDAO(string user,string password)
            : base(user,password)
        {

        }

        public void insertTblPhong(tblPhong Phong)
        {
            string QueryStr = "INSERT INTO " + tblPhong.sTABLE_NAME 
                            +"("
                            + tblPhong.sMA_PHONG 
                            + ","
                            + tblPhong.sTEN_PHONG 
                            +") "
                            + "VALUES(" + "@" + tblPhong.sMA_PHONG + "," + "@" + tblPhong.sTEN_PHONG +")";



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblPhong.sMA_PHONG, Phong.MaPhong);
                sqlcommand.Parameters.AddWithValue(tblPhong.sTEN_PHONG, Phong.TenPhong);
                
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

        public void updateTblPhong(tblPhong Phong)
        {
            string QueryStr = "UPDATE " + tblPhong.sTABLE_NAME + " "
                            + "SET "
                            + tblPhong.sTEN_PHONG + " = " + "@" + tblPhong.sTEN_PHONG
                            + " WHERE " + tblPhong.sMA_PHONG + " =  " + "@" + tblPhong.sMA_PHONG;


            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblPhong.sMA_PHONG, Phong.MaPhong);
                sqlcommand.Parameters.AddWithValue(tblPhong.sTEN_PHONG, Phong.TenPhong);
               
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
        public void deleteTblPhong(String maPhong)
        {
            this.deleteObj("PHONG_HOC", "MA_PHONG", maPhong);
        }
        /*
         *@ Lay Thong tin Phong boi MaPhong
         *@ MaGV: maSV can tim 
         */ 
        public tblPhong getbyMaPhong(int maPhong)
        {
            tblPhong Phong = null;
            string QueryStr = "Select * from PHONG_HOC where MA_PHONG  =   @MA_PHONG";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@MA_PHONG", maPhong);
                
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    int MaPhong = sqldtRd.GetInt32(0);
                    String tenPhong = sqldtRd.GetString(1);


                    Phong = new tblPhong(MaPhong, tenPhong);
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

            return Phong;
            
        }
        /****************************************/
        private List<tblPhong> getAllPhong(int begin,int end,Boolean All)
        {
            List<tblPhong> list = new List<tblPhong>();


            string QueryStr = "Select * from PHONG_HOC ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
              
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblPhong Phong = null;
                    int maPhong = sqldtRd.GetInt32(0);
                    String tenPhong = sqldtRd.GetString(1);


                    Phong = new tblPhong(maPhong, tenPhong);
                    list.Add(Phong);
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
        public List<tblPhong> getAllPhong(int begin, int end)
        {
            return getAllPhong(begin, end, false);
        }
        public List<tblPhong> getAllPhong()
        {
            return getAllPhong(0, 0, true);
        }

        public int CountPhong()
        {
            int result  =   0;


            string QueryStr = "Select COUNT(MA_PHONG) from PHONG_HOC ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                
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
        private List<tblMonhoc> getAllMonHoc(String MaPhong,int begin,int end,Boolean All)
        {
            List<tblMonhoc> list = new List<tblMonhoc>();


            string QueryStr = "SELECT MON_HOC.* "
                            + "from MON_HOC,DAO_TAO,Phong "
                            + "MON_HOC.MA_MON = DAO_TAO.MA_MON AND "
                            + "DAO_TAO.MA_PHONG = Phong.MA_PHONG AND "
                            + " Phong.MA_PHONG = ? ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_PHONG", MaPhong);
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
        public List<tblMonhoc> getAllMonHoc(String MaPhong, int begin, int end)
        {
            return getAllMonHoc(MaPhong,begin, end, false);
        }
        public List<tblMonhoc> getAllMonHoc(String MaPhong)
        {
            return getAllMonHoc(MaPhong, 0, 0, true);
        }

        public int CountMonHoc(String MaPhong)
        {
            int result = 0;


            string QueryStr = "SELECT COUNT(MON_HOC.MA_MON) AS COUNTMAMON"
                            + "from MON_HOC,DAO_TAO,Phong "
                            + "MON_HOC.MA_MON = DAO_TAO.MA_MON AND "
                            + "DAO_TAO.MA_PHONG = Phong.MA_PHONG AND "
                            + " Phong.MA_PHONG = ? ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_PHONG", MaPhong);
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
