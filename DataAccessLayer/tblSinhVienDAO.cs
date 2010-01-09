using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    class tblSinhVienDAO:BaseDAO
    {
        public tblSinhVienDAO()
            : base()
        {
            
        }
        public tblSinhVienDAO(string user,string password)
            : base(user,password)
        {

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
                    String MaKhoa = sqldtRd.GetString(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, MaKhoa, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
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
                    String MaKhoa = sqldtRd.GetString(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, MaKhoa, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
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
                    String MaKhoa = sqldtRd.GetString(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, MaKhoa, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
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

        protected int CountSinhVien()
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

        protected List<tblSinhVien> getAllSinhVienByMaKhoa(String makhoa,int begin,int end, Boolean All)
        {
            List<tblSinhVien> list = new List<tblSinhVien>();

            string QueryStr = "Select * from SINH_VIEN WHERE MA_KHOA = ?";
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
                    String MaKhoa = sqldtRd.GetString(1);
                    String Ho = sqldtRd.GetString(2);
                    String Ten = sqldtRd.GetString(3);
                    String CMND = sqldtRd.GetString(4);
                    DateTime NgaySinh = sqldtRd.GetDateTime(5);
                    Boolean GioiTinh = sqldtRd.GetBoolean(6);
                    String NoiSinh = sqldtRd.GetString(7);
                    String DiaChi = sqldtRd.GetString(8);
                    int nienkhoa = sqldtRd.GetInt32(9);
                    sinhvien = new tblSinhVien(MaSinhVien, MaKhoa, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi, nienkhoa);
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

            string QueryStr = "Select COUNT(MA_SINH_VIEN) AS COUNTSV from SINH_VIEN WHERE MA_KHOA = ?";
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

    }
}
