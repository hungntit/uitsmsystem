using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblLopDangKyDAO : BaseDAO
    {
        public tblLopDangKyDAO()
            : base()
        {
            
        }
        public tblLopDangKyDAO(string user,string password)
            : base(user,password)
        {

        }

        public void insertTblLopDangKy(tblLopDangKy lopdangky)
        {
            string QueryStr = "INSERT INTO " + tblLopDangKy.sTABLE_NAME
                            + "("
                            + tblLopDangKy.sMA_LOP
                            + ","
                            + tblLopDangKy.sMA_GIANG_VIEN
                            + ","
                            + tblLopDangKy.sMA_MON
                            + ","
                            + tblLopDangKy.sMA_PHONG
                            + ","
                            + tblLopDangKy.sNGAY_MO_LOP
                            + ","
                            + tblLopDangKy.sTEN_LOP
                            + ","
                            + tblLopDangKy.sTHU
                            + ","
                            + tblLopDangKy.sCA
                            + ") "
                            + "VALUES(?,?,?,?,?,?,?,?)";




            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_LOP, lopdangky.MaLop);
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_GIANG_VIEN, lopdangky.MaGiangVien);
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_MON, lopdangky.MaMon);
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_PHONG, lopdangky.MaPhong);
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sNGAY_MO_LOP, lopdangky.NgayMoLop);
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sTEN_LOP, lopdangky.TenLop);
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sTHU, lopdangky.Thu);
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sCA, lopdangky.Ca);
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

        public void updateTblLopDangKy(tblLopDangKy lopdangky)
        {
            string QueryStr = "UPDATE " + tblLopDangKy.sTABLE_NAME + " "
                            + " WHERE " + tblLopDangKy.sMA_LOP + " = ? "
                            + "SET "
                            + tblLopDangKy.sMA_GIANG_VIEN + "= " + lopdangky.MaGiangVien
                            + tblLopDangKy.sMA_MON + "= " + lopdangky.MaMon
                            + tblLopDangKy.sMA_PHONG + "= " + lopdangky.MaPhong
                            + tblLopDangKy.sNGAY_MO_LOP + "= " + lopdangky.NgayMoLop
                            + tblLopDangKy.sTEN_LOP + "= " + lopdangky.TenLop
                            + tblLopDangKy.sTHU + "= " + lopdangky.Thu
                            + tblLopDangKy.sCA + "= " + lopdangky.Ca;


            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_LOP, lopdangky.MaLop);
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
        public void deleteTblLopDangKy(int malop)
        {
             this.deleteObj("LOP_DANG_KY", "MA_LOP_DANG_KY", malop);
        }
        public tblLopDangKy getbyMaLop(String maLop)
        {
            tblLopDangKy lop = null;

            string QueryStr = "Select * from LOP_DANG_KY where MA_LOP_DANG_KY  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_LOP_DANG_KY", maLop);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    int MaLop = sqldtRd.GetInt32(0);
                    String MaGiangVien = sqldtRd.GetString(1);
                    String MaPhong = sqldtRd.GetString(2);
                    String MaMon = sqldtRd.GetString(3);
                    
                    String TenLop = sqldtRd.GetString(4);
                    DayOfWeek thu = (DayOfWeek)sqldtRd.GetInt32(5);

                    int Ca = sqldtRd.GetInt32(6);
                    
                    
                    
                    DateTime ngaydatdau = sqldtRd.GetDateTime(7);
                    lop = new tblLopDangKy(MaLop,MaGiangVien, MaPhong, MaMon,  TenLop, thu, Ca, ngaydatdau);
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
            return lop;

            
        }
        /**************************************************/
        private List<tblLopDangKy> getAllLopDK(int begin,int end,Boolean All)
        {

            List<tblLopDangKy> list = new List<tblLopDangKy>();
            string QueryStr = "Select * from LOP_DANG_KY ";
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
                    tblLopDangKy lop = null;
                    int MaLop = sqldtRd.GetInt32(0);
                    String MaGiangVien = sqldtRd.GetString(1);
                    String MaPhong = sqldtRd.GetString(2);
                    String MaMon = sqldtRd.GetString(3);

                    String TenLop = sqldtRd.GetString(4);
                    DayOfWeek thu = (DayOfWeek)sqldtRd.GetInt32(5);

                    int Ca = sqldtRd.GetInt32(6);



                    DateTime ngaydatdau = sqldtRd.GetDateTime(7);
                    lop = new tblLopDangKy(MaLop, MaGiangVien, MaPhong, MaMon, TenLop, thu, Ca, ngaydatdau);
                    list.Add(lop);
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

        public List<tblLopDangKy> getAllLopDK(int begin, int end)
        {
            return getAllLopDK(begin, end, false);
        }
        public List<tblLopDangKy> getAllLopDK()
        {
            return getAllLopDK(0, 0, true);
        }
        public int CountLopDK()
        {

            int result = 0;
            string QueryStr = "Select COUNT(MA_LOP_DANG_KY) AS COUNTLOP from LOP_DANG_KY ";
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
        /***********************************************************************/
        private List<tblLopDangKy> getLopDangKy(String maPhieuDK, int begin, int end, Boolean All)
        {
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "SELECT LOP_DANG_KY.* "
                            + "FROM LOP_DANG_KY,CHI_TIET_DANG_KY "
                            + "WHERE "
                            + "LOP_DANG_KY.MA_LOP_DANG_KY = CHI_TIET_DANG_KY.MA_LOP_DANG_KY AND "
                            + "CHI_TIET_DANG_KY.MA_PHIEU_DANG_KY =  ?";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("PHIEU_DANG_KY.MA_PHIEU_DANG_KY", maPhieuDK);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblLopDangKy lop = null;
                    int MaLop = sqldtRd.GetInt32(0);
                    String MaGiangVien = sqldtRd.GetString(1);
                    String MaPhong = sqldtRd.GetString(2);
                    String MaMon = sqldtRd.GetString(3);

                    String TenLop = sqldtRd.GetString(4);
                    DayOfWeek thu = (DayOfWeek)sqldtRd.GetInt32(5);

                    int Ca = sqldtRd.GetInt32(6);



                    DateTime ngaydatdau = sqldtRd.GetDateTime(7);
                    lop = new tblLopDangKy(MaLop, MaGiangVien, MaPhong, MaMon, TenLop, thu, Ca, ngaydatdau);
                    list.Add(lop);
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
        public int CountLopDangKy(String maPhieuDK)
        {
            int result = 0;
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "SELECT LOP_DANG_KY.* "
                             + "FROM LOP_DANG_KY,CHI_TIET_DANG_KY "
                             + "WHERE "
                             + "LOP_DANG_KY.MA_LOP_DANG_KY = CHI_TIET_DANG_KY.MA_LOP_DANG_KY AND "
                             + "CHI_TIET_DANG_KY.MA_PHIEU_DANG_KY =  ?";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("PHIEU_DANG_KY.MA_PHIEU_DANG_KY", maPhieuDK);
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
        public List<tblLopDangKy> getLopDangKy(String maPhieuDK, int begin, int end)
        {
            return getLopDangKy(maPhieuDK, begin, end, false);
        }
        public List<tblLopDangKy> getLopDangKy(String maPhieuDK)
        {
            return getLopDangKy(maPhieuDK, 0, 0, true);
        }
    }
}
