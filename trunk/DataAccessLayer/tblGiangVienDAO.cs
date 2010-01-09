using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    class tblGiangVienDAO:BaseDAO
    {
        public tblGiangVienDAO()
            : base()
        {
            
        }
        public tblGiangVienDAO(string user,string password)
            : base(user,password)
        {

        }
        public tblGiangVien getbyMaGV(String MaGV)
        {
            tblGiangVien giangvien = null;
            
            string QueryStr = "Select * from GIANG_VIEN where MA_GIANG_VIEN  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_GIANG_VIEN", MaGV);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String MaGiangVien = sqldtRd.GetString(0);
                    String HocVi = sqldtRd.GetString(1);
                    String MaKhoa = sqldtRd.GetString(2);
                    String Ho = sqldtRd.GetString(3);
                    String Ten = sqldtRd.GetString(4);
                    String CMND = sqldtRd.GetString(5);
                    DateTime NgaySinh = sqldtRd.GetDateTime(6);
                    Boolean GioiTinh = sqldtRd.GetBoolean(7);
                    String NoiSinh = sqldtRd.GetString(8);
                    String DiaChi = sqldtRd.GetString(9);
                    giangvien = new tblGiangVien(MaGiangVien, HocVi, MaKhoa, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi);
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
            return giangvien;

            
        }

        public List<tblGiangVien> findByHoTenGiangVien(String ho,String ten)
        {

            List<tblGiangVien> list = new List<tblGiangVien>();
           
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                ParamSQL[]  paramSQLs   =   new ParamSQL[2]{new ParamSQL("HOGV",ho),new ParamSQL("TENGV",ten)};
                getObjByAttribute(sqldtRd, sqlcommand, paramSQLs, "GIANGVIEN");
                while (sqldtRd.Read())
                {
                    tblGiangVien giangvien = null;
                    String MaGiangVien = sqldtRd.GetString(0);
                    String HocVi = sqldtRd.GetString(1);
                    String MaKhoa = sqldtRd.GetString(2);
                    String Ho = sqldtRd.GetString(3);
                    String Ten = sqldtRd.GetString(4);
                    String CMND = sqldtRd.GetString(5);
                    DateTime NgaySinh = sqldtRd.GetDateTime(6);
                    Boolean GioiTinh = sqldtRd.GetBoolean(7);
                    String NoiSinh = sqldtRd.GetString(8);
                    String DiaChi = sqldtRd.GetString(9);
                    giangvien = new tblGiangVien(MaGiangVien, HocVi, MaKhoa, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi);
                    list.Add(giangvien);
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
        private List<tblGiangVien> getAllGiangVien(int begin,int end,Boolean All)
        {

            List<tblGiangVien> list = new List<tblGiangVien>();
            string QueryStr = "Select * from GIANG_VIEN ";
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
                    tblGiangVien giangvien = null;
                    String MaGiangVien = sqldtRd.GetString(0);
                    String HocVi = sqldtRd.GetString(1);
                    String MaKhoa = sqldtRd.GetString(2);
                    String Ho = sqldtRd.GetString(3);
                    String Ten = sqldtRd.GetString(4);
                    String CMND = sqldtRd.GetString(5);
                    DateTime NgaySinh = sqldtRd.GetDateTime(6);
                    Boolean GioiTinh = sqldtRd.GetBoolean(7);
                    String NoiSinh = sqldtRd.GetString(8);
                    String DiaChi = sqldtRd.GetString(9);
                    giangvien = new tblGiangVien(MaGiangVien, HocVi, MaKhoa, Ho, Ten, CMND, NgaySinh, GioiTinh, NoiSinh, DiaChi);
                    list.Add(giangvien);
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
        public List<tblGiangVien> getAllGiangVien(int begin, int end)
        {
            return getAllGiangVien(begin, end, false);
        }
        public List<tblGiangVien> getAllGiangVien()
        {
            return getAllGiangVien(0, 0, true);
        }
        public int CountGiangVien()
        {

            int result = 0;
            string QueryStr = "Select COUNT(MA_GIANG_VIEN) from GIANG_VIEN ";
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
    }
}
