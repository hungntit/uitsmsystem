using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    class tblLopDAO:BaseDAO
    {
        public tblLopDAO()
            : base()
        {
            
        }
        public tblLopDAO(string user,string password)
            : base(user,password)
        {

        }
        public tblLopDK getbyMaLop(String maLop)
        {
            tblLopDK lop = null;

            string QueryStr = "Select * from LOP_DANG_KY where MA_LOP  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_LOP", maLop);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String MaLop = sqldtRd.GetString(0);
                    String MaMon = sqldtRd.GetString(1);
                    String MaGiangVien = sqldtRd.GetString(2);
                    String MaPhong = sqldtRd.GetString(3);
                    String TenLop = sqldtRd.GetString(4);
                    DayOfWeek thu = (DayOfWeek)sqldtRd.GetInt32(5);

                    int Ca = sqldtRd.GetInt32(6);
                    int sisoToithieu = sqldtRd.GetInt32(7);
                    int sisoToida = sqldtRd.GetInt32(8);
                    
                    String GhiChu = sqldtRd.GetString(9);
                    DateTime ngaydatdau = sqldtRd.GetDateTime(10);
                    lop = new tblLopDK(MaLop, MaMon, MaGiangVien, MaPhong, TenLop, thu, Ca, sisoToithieu, sisoToida, GhiChu, ngaydatdau);
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
        private List<tblLopDK> getAllGiangVien(int begin,int end,Boolean All)
        {

            List<tblLopDK> list = new List<tblLopDK>();
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
                    tblLopDK lop = null;
                    String MaLop = sqldtRd.GetString(0);
                    String MaMon = sqldtRd.GetString(1);
                    String MaGiangVien = sqldtRd.GetString(2);
                    String MaPhong = sqldtRd.GetString(3);
                    String TenLop = sqldtRd.GetString(4);
                    DayOfWeek thu = (DayOfWeek)sqldtRd.GetInt32(5);

                    int Ca = sqldtRd.GetInt32(6);
                    int sisoToithieu = sqldtRd.GetInt32(7);
                    int sisoToida = sqldtRd.GetInt32(8);

                    String GhiChu = sqldtRd.GetString(9);
                    DateTime ngaydatdau = sqldtRd.GetDateTime(10);
                    lop = new tblLopDK(MaLop, MaMon, MaGiangVien, MaPhong, TenLop, thu, Ca, sisoToithieu, sisoToida, GhiChu, ngaydatdau);
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

        public List<tblLopDK> getAllGiangVien(int begin, int end)
        {
            return getAllGiangVien(begin, end, false);
        }
        public List<tblLopDK> getAllGiangVien()
        {
            return getAllGiangVien(0, 0, true);
        }
        public int CountGiangVien()
        {

            int result = 0;
            string QueryStr = "Select COUNT(MA_GIANG_VIEN) AS COUNTGV from LOP_DANG_KY ";
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
