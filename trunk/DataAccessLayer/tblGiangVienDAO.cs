using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblGiangVienDAO : BaseDAO
    {
        public tblGiangVienDAO()
            : base()
        {
            
        }
        public tblGiangVienDAO(string user,string password)
            : base(user,password)
        {

        }

        public void deleteTblGiangVien(String maGiangVien)
        {
            tblLopDangKyDAO lopdkDao = new tblLopDangKyDAO();
            lopdkDao.deleteTblLopDangKyByMaGiangVien(maGiangVien);
            this.deleteObj("GIANG_DAY",tblGiangVien.sMA_GIANG_VIEN, maGiangVien);
            this.deleteObj("GIANG_VIEN", tblGiangVien.sMA_GIANG_VIEN, maGiangVien);
            lopdkDao.CloseConection();
        }
        public void insertTblGiangVien(tblGiangVien giangvien)
        {
            string QueryStr = "INSERT INTO " + tblGiangVien.sTABLE_NAME
                            + "("
                            + tblGiangVien.sMA_GIANG_VIEN
                            + ","
                            + tblGiangVien.sCMND
                            + ","
                            + tblGiangVien.sHOC_VI
                            + ","
                            + tblGiangVien.sMA_KHOA
                            + ","
                            + tblGiangVien.sHO_GIANG_VIEN
                            + ","
                            + tblGiangVien.sTEN_GIANG_VIEN
                            + ","
                            + tblGiangVien.sNGAYSINH
                            + ","
                            + tblGiangVien.sNOISINH
                            + ","
                            + tblGiangVien.sGIOITINH
                            + ","
                            + tblGiangVien.sDIACHI
                            + ") "
                            + "VALUES(?,?,?,?,?,?,?,?,?,?)";



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sMA_GIANG_VIEN, giangvien.MaGiangVien);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sCMND, giangvien.CMND);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sHOC_VI, giangvien.HocVi);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sMA_KHOA, giangvien.MaKhoa);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sHO_GIANG_VIEN, giangvien.Ho);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sTEN_GIANG_VIEN, giangvien.Ten);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sNGAYSINH, giangvien.NgaySinh);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sNOISINH, giangvien.NoiSinh);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sGIOITINH, giangvien.GioiTinh);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sDIACHI, giangvien.DiaChi);
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

        public void updateTblGiangVien(tblGiangVien giangvien)
        {
            string QueryStr = "UPDATE GIANG_VIEN "
                            + "WHERE "+tblGiangVien.sMA_GIANG_VIEN +" = ? "
                            + "SET "
                            + tblGiangVien.sCMND + " = ?," 
                            + tblGiangVien.sHOC_VI + " = ?," 
                            + tblGiangVien.sMA_KHOA + " = ?," 
                            + tblGiangVien.sHO_GIANG_VIEN + " = ?," 
                            + tblGiangVien.sTEN_GIANG_VIEN + " = ?," 
                            + tblGiangVien.sNGAYSINH + " = ?," 
                            + tblGiangVien.sNOISINH + " = ?," 
                            + tblGiangVien.sGIOITINH + " = ?," 
                            + tblGiangVien.sDIACHI + " = " ;

            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sMA_GIANG_VIEN, giangvien.MaGiangVien);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sCMND, giangvien.CMND);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sHOC_VI, giangvien.HocVi);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sMA_KHOA, giangvien.MaKhoa);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sHO_GIANG_VIEN, giangvien.Ho);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sTEN_GIANG_VIEN, giangvien.Ten);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sNGAYSINH, giangvien.NgaySinh);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sNOISINH, giangvien.NoiSinh);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sGIOITINH, giangvien.GioiTinh);
                sqlcommand.Parameters.AddWithValue(tblGiangVien.sDIACHI, giangvien.DiaChi);
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
        public tblGiangVien getbyMaGV(String MaGV)
        {
            tblGiangVien giangvien = null;
            
            string QueryStr = "SELECT  "
                             +tblGiangVien.sMA_GIANG_VIEN +","
                             + tblGiangVien.sHOC_VI + ","
                             + tblGiangVien.sMA_KHOA + ","
                             + tblGiangVien.sHO_GIANG_VIEN + ","
                             + tblGiangVien.sTEN_GIANG_VIEN + ","
                             + tblGiangVien.sCMND + ","
                             + tblGiangVien.sNGAYSINH + ","
                             + tblGiangVien.sGIOITINH + ","
                             + tblGiangVien.sNOISINH + ","
                             + tblGiangVien.sDIACHI +" " 
                             +"from GIANG_VIEN where MA_GIANG_VIEN  =   ?";
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
            string QueryStr = "SELECT  "
                              + tblGiangVien.sMA_GIANG_VIEN + ","
                              + tblGiangVien.sHOC_VI + ","
                              + tblGiangVien.sMA_KHOA + ","
                              + tblGiangVien.sHO_GIANG_VIEN + ","
                              + tblGiangVien.sTEN_GIANG_VIEN + ","
                              + tblGiangVien.sCMND + ","
                              + tblGiangVien.sNGAYSINH + ","
                              + tblGiangVien.sGIOITINH + ","
                              + tblGiangVien.sNOISINH + ","
                              + tblGiangVien.sDIACHI + " " 
                        +"from GIANG_VIEN ";
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
        /**********************************************/

        private List<tblGiangVien> getGiangVienByMaMonHoc(String MaMonHoc,int begin, int end, Boolean All)
        {

            List<tblGiangVien> list = new List<tblGiangVien>();
            string QueryStr = "SELECT  "
                             +"GIANG_VIEN."+ tblGiangVien.sMA_GIANG_VIEN + ","
                             + "GIANG_VIEN." + tblGiangVien.sHOC_VI + ","
                             + "GIANG_VIEN." + tblGiangVien.sMA_KHOA + ","
                             + "GIANG_VIEN." + tblGiangVien.sHO_GIANG_VIEN + ","
                             + "GIANG_VIEN." + tblGiangVien.sTEN_GIANG_VIEN + ","
                             + "GIANG_VIEN." + tblGiangVien.sCMND + ","
                             + "GIANG_VIEN." + tblGiangVien.sNGAYSINH + ","
                             + "GIANG_VIEN." + tblGiangVien.sGIOITINH + ","
                             + "GIANG_VIEN." + tblGiangVien.sNOISINH + ","
                             + "GIANG_VIEN." + tblGiangVien.sDIACHI + " " 
                            + "from GIANG_VIEN,GIANG_DAY "
                            + "WHERE "
                            + "GIANG_VIEN.MA_GIANG_VIEN = GIANG_DAY.MA_GIANG_VIEN AND "
                            + "GIANG_DAY.MA_MON = ?  ";
                            
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_MON", MaMonHoc);
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
        public List<tblGiangVien> getGiangVienByMaMonHoc(String mamon,int begin, int end)
        {
            return getGiangVienByMaMonHoc(mamon,begin, end, false);
        }
        public List<tblGiangVien> getGiangVienByMaMonHoc(String mamon)
        {
            return getGiangVienByMaMonHoc(mamon,0, 0, true);
        }
        public int CountGiangVienByMaMon(String mamon)
        {

            int result = 0;
            string QueryStr = "SELECT  "
                              + tblGiangVien.sMA_GIANG_VIEN + ","
                              + tblGiangVien.sHOC_VI + ","
                              + tblGiangVien.sMA_KHOA + ","
                              + tblGiangVien.sHO_GIANG_VIEN + ","
                              + tblGiangVien.sTEN_GIANG_VIEN + ","
                              + tblGiangVien.sCMND + ","
                              + tblGiangVien.sNGAYSINH + ","
                              + tblGiangVien.sGIOITINH + ","
                              + tblGiangVien.sNOISINH + ","
                              + tblGiangVien.sDIACHI + " " 
                            + "from GIANG_VIEN,GIANG_DAY "
                            + "WHERE "
                            + "GIANG_VIEN.MA_GIANG_VIEN = GIANG_DAY.MA_GIANG_VIEN AND "
                            + "GIANG_DAY.MA_MON = ?  ";
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
    }
}
