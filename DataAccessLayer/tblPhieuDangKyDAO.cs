using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    class tblPhieuDangKyDAO:BaseDAO
    {
        public tblPhieuDangKyDAO()
            : base()
        {
            
        }
        public tblPhieuDangKyDAO(string user,string password)
            : base(user,password)
        {

        }
        /*
         *@ Lay Thong tin giang vien boi MaGV
         *@ MaGV: maSV can tim 
         */ 
        public tblPhieuDangKy getbyMaPhieuDKy(String MaPhieu)
        {
            tblPhieuDangKy phieudk = null;
            string QueryStr = "Select * from PHIEU_DANG_KY where MA_PHIEU_DANG_KY  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_PHIEU_DANG_KY", MaPhieu);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String Maphieu = sqldtRd.GetString(0);
                    String MaSV = sqldtRd.GetString(1);
                    DateTime NgayDangKy = sqldtRd.GetDateTime(2);
                    DateTime NgayCapNhat = sqldtRd.GetDateTime(3);

                    phieudk = new tblPhieuDangKy(Maphieu, MaSV, NgayDangKy, NgayCapNhat);
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

            return phieudk;
            
        }


        /**************************************************************************/

        private List<tblPhieuDangKy> getAllPhieuDangKy(int begin,int end,Boolean All)
        {
            List<tblPhieuDangKy> list = new List<tblPhieuDangKy>();

            string QueryStr = "Select * from PHIEU_DANG_KY ";
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
                    tblPhieuDangKy phieudk = null;
                    String MaPhieu = sqldtRd.GetString(0);
                    String MaSV = sqldtRd.GetString(1);
                    DateTime NgayDangKy = sqldtRd.GetDateTime(2);
                    DateTime NgayCapNhat = sqldtRd.GetDateTime(3);

                    phieudk = new tblPhieuDangKy(MaPhieu, MaSV, NgayDangKy, NgayCapNhat);
                    list.Add(phieudk);
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

        public List<tblPhieuDangKy> getAllPhieuDangKy(int begin, int end)
        {
            return getAllPhieuDangKy(begin, end, false);
        }
        public List<tblPhieuDangKy> getAllPhieuDangKy()
        {
            return getAllPhieuDangKy(0, 0, true);
        }

        public int CountPhieuDangKy()
        {
            int result = 0;

            string QueryStr = "Select COUNT(MA_PHIEU_DANG_KY) from PHIEU_DANG_KY ";
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
            return result;
        }

        private List<tblLopDK> getLopDangKy(String maPhieuDK,int begin,int end,Boolean All)
        {
            List<tblLopDK> list = new List<tblLopDK>();

            string QueryStr = "SELECT LOP_DANG_KY.* "
                            + "FROM LOP_DANG_KY,PHIEU_DANG_KY,CHI_TIET_DANG_KY "
                            + "WHERE "
                            + "LOP_DANG_KY.MA_LOP = CHI_TIET_DANG_KY.MA_LOP AND "
                            + "PHIEU_DANG_KY.MA_PHIEU_DANG_KY = CHI_TIET_DANG_KY.MA_PHIEU_DANG_KY AND "
                            + "PHIEU_DANG_KY.MA_PHIEU_DANG_KY =  ?";
                            
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
        public int CountLopDangKy(String maPhieuDK)
        {
            int result = 0;
            List<tblLopDK> list = new List<tblLopDK>();

            string QueryStr = "SELECT COUNT(LOP_DANG_KY.MA_LOP) AS COUNTLOP "
                            + "FROM LOP_DANG_KY,PHIEU_DANG_KY,CHI_TIET_DANG_KY "
                            + "WHERE "
                            + "LOP_DANG_KY.MA_LOP = CHI_TIET_DANG_KY.MA_LOP AND "
                            + "PHIEU_DANG_KY.MA_PHIEU_DANG_KY = CHI_TIET_DANG_KY.MA_PHIEU_DANG_KY AND "
                            + "PHIEU_DANG_KY.MA_PHIEU_DANG_KY =  ?";

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
         public List<tblLopDK> getLopDangKy(String maPhieuDK,int begin,int end)
         {
             return getLopDangKy(maPhieuDK, begin,end,false);
         }
         public List<tblLopDK> getLopDangKy(String maPhieuDK)
         {
             return getLopDangKy(maPhieuDK,0, 0, true);
         }
    }
}
