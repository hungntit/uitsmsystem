using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblLoaiMonHocDAO : BaseDAO
    {
        public tblLoaiMonHocDAO()
            : base()
        {
            
        }
        public tblLoaiMonHocDAO(string user, string password)
            : base(user,password)
        {

        }

        public void insertTblLoaiMonHoc(tblLoaiMonHoc tblloai)
        {
            string QueryStr = "INSERT INTO " + tblLoaiMonHoc.sTABLE_NAME
                            +"("
                            + tblLoaiMonHoc.sMA_LOAI
                            + ","
                            + tblLoaiMonHoc.sTEN_LOAI 
                            +") "
                            + "VALUES(" + "@" + tblLoaiMonHoc.sMA_LOAI + "," + "@" + tblLoaiMonHoc.sTEN_LOAI + ")";



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLoaiMonHoc.sMA_LOAI, tblloai.MaLoai);
                sqlcommand.Parameters.AddWithValue(tblLoaiMonHoc.sTEN_LOAI, tblloai.TenLoai);
                
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

        public void updateTblLoaiMonHoc(tblLoaiMonHoc tblloaiMonHoc)
        {
            string QueryStr = "UPDATE " + tblLoaiMonHoc.sTABLE_NAME + " "
                            + "SET "
                            + tblLoaiMonHoc.sTEN_LOAI + " = " + "@" + tblLoaiMonHoc.sTEN_LOAI
                            + " WHERE " + tblLoaiMonHoc.sMA_LOAI + " =  " + "@" + tblLoaiMonHoc.sMA_LOAI;


            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLoaiMonHoc.sMA_LOAI, tblloaiMonHoc.MaLoai);
                sqlcommand.Parameters.AddWithValue(tblLoaiMonHoc.sTEN_LOAI, tblloaiMonHoc.TenLoai);
               
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
        public void deleteTblLoaiMonHoc(int maloai)
        {
             this.deleteObj("LOAI_MON_HOC", "MA_LOAI", maloai);
        }
        /*
         *@ Lay Thong tin Khoa boi MaKhoa
         *@ MaGV: maSV can tim 
         */ 
        public tblLoaiMonHoc getbyMaLoai(int maloai)
        {
            tblLoaiMonHoc loai = null;
            string QueryStr = "Select * from LOAI_MON_HOC where MA_LOAI  =   @MA_LOAI";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@MA_LOAI", maloai);
                
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    int Maloai = sqldtRd.GetInt32(0);
                    String tenLoai = sqldtRd.GetString(1);


                    loai = new tblLoaiMonHoc(Maloai, tenLoai);
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

            return loai;
            
        }
        /****************************************/
        private List<tblLoaiMonHoc> getAllLoaiMonHoc(int begin,int end,Boolean All)
        {
            List<tblLoaiMonHoc> list = new List<tblLoaiMonHoc>();


            string QueryStr = "Select * from LOAI_MON_HOC ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
              
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblLoaiMonHoc loai = null;
                    int Maloai = sqldtRd.GetInt32(0);
                    String tenLoai = sqldtRd.GetString(1);


                    loai = new tblLoaiMonHoc(Maloai, tenLoai);
                    list.Add(loai);
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
        public List<tblLoaiMonHoc> getAllLoaiMonHoc(int begin, int end)
        {
            return getAllLoaiMonHoc(begin, end, false);
        }
        public List<tblLoaiMonHoc> getAllLoaiMonHoc()
        {
            return getAllLoaiMonHoc(0, 0, true);
        }

        public int CountLoaiMonHoc()
        {
            int result  =   0;


            string QueryStr = "Select COUNT(MA_LOAI) from LOAI_MON_HOC ";
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
