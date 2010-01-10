using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblSinhVienDAO : BaseDAO
    {
        public tblSinhVienDAO()
            : base()
        {
            
        }
        public tblSinhVienDAO(string user,string password)
            : base(user,password)
        {

        }

        public void insertTblSinhVien(tblSinhVien sinhvien)
        {
            string QueryStr = "INSERT INTO  " + tblSinhVien.sTABLE_NAME
                            + "("
                            + tblSinhVien.sMASV
                            + "," + tblSinhVien.sCMND
                            + "," + tblSinhVien.sNIEN_KHOA
                            + "," + tblSinhVien.sMA_LOP_QUAN_LY
                            + "," + tblSinhVien.sHO_SINH_VIEN
                            + "," + tblSinhVien.sTEN_SINH_VIEN
                            + "," + tblSinhVien.sNGAYSINH
                            + "," + tblSinhVien.sNOISINH
                            + "," + tblSinhVien.sGIOITINH
                            + "," + tblSinhVien.sDIACHI
                            + ") "
                            + "VALUES(?,?,?,?,?,?,?,?,?,?)";


            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sMASV, sinhvien.MaSV);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sCMND, sinhvien.CMND);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sNIEN_KHOA, sinhvien.NienKhoa);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sMA_LOP_QUAN_LY, sinhvien.MaLopQuanLy);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sHO_SINH_VIEN, sinhvien.Ho);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sTEN_SINH_VIEN, sinhvien.Ten);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sNGAYSINH, sinhvien.NgaySinh);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sNOISINH, sinhvien.NoiSinh);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sGIOITINH, sinhvien.GioiTinh);
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sDIACHI, sinhvien.DiaChi);
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

        public void updateTblSinhVien(tblSinhVien sinhvien)
        {
            string QueryStr = "UPDATE SINH_VIEN "
                            + "WHERE " + tblSinhVien.sMASV + " = ? "
                            + "SET "
                            + tblSinhVien.sCMND + "= " + sinhvien.CMND
                            + tblSinhVien.sNIEN_KHOA + "= " + sinhvien.NienKhoa
                            + tblSinhVien.sMA_LOP_QUAN_LY + "= " + sinhvien.MaLopQuanLy
                            + tblSinhVien.sHO_SINH_VIEN+ "= " + sinhvien.Ho
                            + tblSinhVien.sTEN_SINH_VIEN + "= " + sinhvien.Ten
                            + tblSinhVien.sNGAYSINH + "= " + sinhvien.NgaySinh
                            + tblSinhVien.sNOISINH + "= " + sinhvien.NoiSinh
                            + tblGiangVien.sGIOITINH + "= " + sinhvien.GioiTinh
                            + tblGiangVien.sDIACHI + "= " + sinhvien.DiaChi;

            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblSinhVien.sMASV, sinhvien.MaSV);
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
        public void deleteTbleSinhVien(String maSv)
        {
            this.deleteObj("SINH_VIEN", "MA_SINH_VIEN", maSv);
        }
        /*
         *@ Lay Thong tin giang vien boi MaGV
         *@ MaGV: maSV can tim 
         */ 
        public tblSinhVien getbyMaSV(String MaSV)
        {
            tblSinhVien sinhvien = null;
            string QueryStr = "Select * from SINH_VIEN where MA_SINH_VIEN  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_SINH_VIEN", MaSV);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String MaSinhVien = sqldtRd.GetString(0);
                    int malopquanly = sqldtRd.GetInt32(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, malopquanly, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
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

            return sinhvien;
            
        }

        public tblSinhVien getbyCMND(String cmnd)
        {
            tblSinhVien sinhvien = null;
            string QueryStr = "Select * from SINH_VIEN where CMND  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("CMND", cmnd);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String MaSinhVien = sqldtRd.GetString(0);
                    int malopqly = sqldtRd.GetInt32(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, malopqly, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
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

            return sinhvien;

        }


        private List<tblSinhVien> getAllSinhVien(int begin,int end,bool All)
        {
            List<tblSinhVien> list = new List<tblSinhVien>();

            string QueryStr = "Select * from SINH_VIEN ";
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
                    tblSinhVien sinhvien = null;
                    String MaSinhVien = sqldtRd.GetString(0);
                    int malopqly = sqldtRd.GetInt32(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, malopqly, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
                    list.Add(sinhvien);
                    
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

        public int CountSinhVien()
        {
            int result = 0;

            string QueryStr = "Select COUNT(MA_SINH_VIEN) AS COUNTSV from SINH_VIEN ";
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

        public List<tblSinhVien> getAllSinhVien(int begin, int end)
        {
            return getAllSinhVien(begin, end, false);


        }

        public List<tblSinhVien> getAllSinhVien()
        {
            return getAllSinhVien(0, 0, true);
        }

/*****************************************************************************************************/

        private List<tblSinhVien> getAllSinhVienByMaKhoa(String makhoa,int begin,int end, Boolean All)
        {
            List<tblSinhVien> list = new List<tblSinhVien>();

            string QueryStr = "Select  * from "
                            + "SINH_VIEN,LOP_QUAN_LY "
                            + "WHERE MA_KHOA = ? AND "
                            + "SINH_VIEN.MA_SINH_VIEN = LOP_QUAN_LY.MA_SINH_VIEN ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_KHOA", makhoa);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblSinhVien sinhvien = null;
                    String MaSinhVien = sqldtRd.GetString(0);
                    int malopqly = sqldtRd.GetInt32(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, malopqly, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
                    list.Add(sinhvien);
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

        public List<tblSinhVien> getAllSinhVienByMaKhoa(String makhoa, int begin, int end)
        {
            return getAllSinhVienByMaKhoa(makhoa, begin, end, false);
        }

        public List<tblSinhVien> getAllSinhVienByMaKhoa(String makhoa)
        {
            return getAllSinhVienByMaKhoa(makhoa, 0, 0, true);
        }

         public int CountSinhVienByMaKhoa(String makhoa)
        {
            int result = 0;

            string QueryStr = "Select  COUNT(MA_SINH_VIEN) AS COUNTSV from "
                            + "SINH_VIEN,LOP_QUAN_LY "
                            + "WHERE MA_KHOA = ? AND "
                            + "SINH_VIEN.MA_SINH_VIEN = LOP_QUAN_LY.MA_SINH_VIEN ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_KHOA", makhoa);
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
        /********************************************************************/


         private List<tblSinhVien> getAllSinhVienByMaLopQuanLy(int malopQly, int begin, int end, Boolean All)
         {
             List<tblSinhVien> list = new List<tblSinhVien>();

             string QueryStr = "Select  * from "
                             + "SINH_VIEN "
                             + "WHERE MA_LOP_QUAN_LY = ?  ";
                            
             SqlDataReader sqldtRd = null;
             SqlCommand sqlcommand = null;
             try
             {
                 sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                 sqlcommand.CommandType = System.Data.CommandType.Text;
                 sqlcommand.Parameters.AddWithValue("MA_LOP_QUAN_LY", malopQly);
                 sqlcommand.Prepare();
                 sqldtRd = sqlcommand.ExecuteReader();
                 while (sqldtRd.Read())
                 {
                     tblSinhVien sinhvien = null;
                     String MaSinhVien = sqldtRd.GetString(0);
                     int malopqly = sqldtRd.GetInt32(1);
                     String Ho = sqldtRd.GetString(2);
                     String Ten = sqldtRd.GetString(3);
                     String CMND = sqldtRd.GetString(4);
                     DateTime NgaySinh = sqldtRd.GetDateTime(5);
                     Boolean GioiTinh = sqldtRd.GetBoolean(6);
                     String NoiSinh = sqldtRd.GetString(7);
                     String DiaChi = sqldtRd.GetString(8);
                     int nienkhoa = sqldtRd.GetInt32(9);
                     sinhvien = new tblSinhVien(MaSinhVien, malopqly, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
                     list.Add(sinhvien);
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

         public List<tblSinhVien> getAllSinhVienByMaLopQuanLy(int malop, int begin, int end)
         {
             return getAllSinhVienByMaLopQuanLy(malop, begin, end, false);
         }

         public List<tblSinhVien> getAllSinhVienByMaLopQuanLy(int malop)
         {
             return getAllSinhVienByMaLopQuanLy(malop, 0, 0, true);
         }

         public int CountSinhVienByMaLopQuanLy(int malopQly)
         {
             int result = 0;

             string QueryStr = "Select  * from "
                              + "SINH_VIEN "
                              + "WHERE MA_LOP_QUAN_LY = ?  ";
                            
             SqlDataReader sqldtRd = null;
             SqlCommand sqlcommand = null;
             try
             {
                 sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                 sqlcommand.CommandType = System.Data.CommandType.Text;
                 sqlcommand.Parameters.AddWithValue("MA_LOP_QUAN_LY", malopQly);
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
    }
}
