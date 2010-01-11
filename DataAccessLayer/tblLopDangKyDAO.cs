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
                            + ","
                            + tblLopDangKy.sMA_HOC_KY
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
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_HOC_KY, lopdangky.MaHocKy);
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
                            + tblLopDangKy.sCA + "= " + lopdangky.Ca
                            + tblLopDangKy.sMA_HOC_KY + "= " + lopdangky.MaHocKy;


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
            try
            {
                this.deleteObj("BANG_DIEM", "MA_LOP_DANG_KY", malop);
                this.deleteObj("CHI_TIET_DANG_KY", "MA_LOP_DANG_KY", malop);
                this.deleteObj("LOP_DANG_KY", "MA_LOP_DANG_KY", malop);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void deleteTblLopDangKyByMamon(String mamon)
        {
            try
            {

                List<tblLopDangKy> lstLopDk = getLopDangKyByMaMonHoc(mamon);
                tblLopDangKy[] arrlopdk = lstLopDk.ToArray();
                for (int i = 0; i < lstLopDk.Count; i++)
                {
                    this.deleteTblLopDangKy(arrlopdk[i].MaLop);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteTblLopDangKyByMaGiangVien(String magiangvien)
        {
            try
            {
                List<tblLopDangKy> lstLopDk = getLopDangKyByMaGiangVien(magiangvien);
                tblLopDangKy[] arrlopdk = lstLopDk.ToArray();
                for (int i = 0; i < lstLopDk.Count; i++)
                {
                    this.deleteTblLopDangKy(arrlopdk[i].MaLop);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteTblLopDangKyByMaPhong(int maPhong)
        {
            try
            {
                List<tblLopDangKy> lstLopDk = getLopDangKyByMaPhong(maPhong);
                tblLopDangKy[] arrlopdk = lstLopDk.ToArray();
                for (int i = 0; i < lstLopDk.Count; i++)
                {
                    this.deleteTblLopDangKy(arrlopdk[i].MaLop);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public tblLopDangKy getbyMaLop(String maLop)
        {
            tblLopDangKy lop = null;

            string QueryStr = "SELECT " + tblLopDangKy.sMA_LOP +","
                                        +tblLopDangKy.sMA_GIANG_VIEN +","
                                        +tblLopDangKy.sMA_PHONG +","
                                        +tblLopDangKy.sMA_MON +","
                                        +tblLopDangKy.sTEN_LOP +","
                                        +tblLopDangKy.sTHU +","
                                        +tblLopDangKy.sCA +","
                                        +tblLopDangKy.sNGAY_MO_LOP
                                        + "LOP_DANG_KY." + tblLopDangKy.sMA_HOC_KY + " "
                            +"from LOP_DANG_KY where MA_LOP_DANG_KY  =   ?";
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
                    int maHK = sqldtRd.GetInt32(8);
                    lop = new tblLopDangKy(MaLop,MaGiangVien, MaPhong, MaMon,  TenLop, thu, Ca, ngaydatdau,maHK);
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
            string QueryStr = "SELECT " + tblLopDangKy.sMA_LOP +","
                                        +tblLopDangKy.sMA_GIANG_VIEN +","
                                        +tblLopDangKy.sMA_PHONG +","
                                        +tblLopDangKy.sMA_MON +","
                                        +tblLopDangKy.sTEN_LOP +","
                                        +tblLopDangKy.sTHU +","
                                        +tblLopDangKy.sCA +","
                                         + tblLopDangKy.sNGAY_MO_LOP
                                         + tblLopDangKy.sMA_HOC_KY + " "
                            +"from LOP_DANG_KY ";
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
                    int maHK = sqldtRd.GetInt32(8);
                    lop = new tblLopDangKy(MaLop, MaGiangVien, MaPhong, MaMon, TenLop, thu, Ca, ngaydatdau, maHK);
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
        private List<tblLopDangKy> getLopDangKyByMaPhieu(String maPhieuDK, int begin, int end, Boolean All)
        {
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "SELECT " +"LOP_DANG_KY."+ tblLopDangKy.sMA_LOP +","
                                        +"LOP_DANG_KY."+tblLopDangKy.sMA_GIANG_VIEN +","
                                        +"LOP_DANG_KY."+tblLopDangKy.sMA_PHONG +","
                                        +"LOP_DANG_KY."+tblLopDangKy.sMA_MON +","
                                        +"LOP_DANG_KY."+tblLopDangKy.sTEN_LOP +","
                                        +"LOP_DANG_KY."+tblLopDangKy.sTHU +","
                                        +"LOP_DANG_KY."+tblLopDangKy.sCA +","
                                        + "LOP_DANG_KY." + tblLopDangKy.sNGAY_MO_LOP
                                        + "LOP_DANG_KY." + tblLopDangKy.sMA_HOC_KY + " "
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
                    int maHK = sqldtRd.GetInt32(8);
                    lop = new tblLopDangKy(MaLop, MaGiangVien, MaPhong, MaMon, TenLop, thu, Ca, ngaydatdau, maHK);
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
        public int CountLopDangKyByMaPhieu(String maPhieuDK)
        {
            int result = 0;
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "Select COUNT(MA_LOP_DANG_KY) AS COUNTLOP "
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
        public List<tblLopDangKy> getLopDangKyByMaPhieu(String maPhieuDK, int begin, int end)
        {
            return getLopDangKyByMaPhieu(maPhieuDK, begin, end, false);
        }
        public List<tblLopDangKy> getLopDangKyByMaPhieu(String maPhieuDK)
        {
            return getLopDangKyByMaPhieu(maPhieuDK, 0, 0, true);
        }


        /*****************************************************************/

        private List<tblLopDangKy> getLopDangKyByMaMonHoc(String mamon, int begin, int end, Boolean All)
        {
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "SELECT " + tblLopDangKy.sMA_LOP +","
                                        +tblLopDangKy.sMA_GIANG_VIEN +","
                                        +tblLopDangKy.sMA_PHONG +","
                                        +tblLopDangKy.sMA_MON +","
                                        +tblLopDangKy.sTEN_LOP +","
                                        +tblLopDangKy.sTHU +","
                                        +tblLopDangKy.sCA +","
                                       +  tblLopDangKy.sNGAY_MO_LOP
                                        + tblLopDangKy.sMA_HOC_KY + " "
                            + "FROM LOP_DANG_KY "
                            + "WHERE "
                            +tblLopDangKy.sMA_MON+" =  ? ";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_MON, mamon);
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
                    int maHK = sqldtRd.GetInt32(8);
                    lop = new tblLopDangKy(MaLop, MaGiangVien, MaPhong, MaMon, TenLop, thu, Ca, ngaydatdau, maHK);
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
        public int CountLopDangKyByMaMon(String mamon)
        {
            int result = 0;
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "Select COUNT(MA_LOP_DANG_KY) AS COUNTLOP "
                            + "FROM LOP_DANG_KY "
                            + "WHERE "
                            +tblLopDangKy.sMA_MON+" =  ? ";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_MON, mamon);
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
        public List<tblLopDangKy> getLopDangKyByMaMonHoc(String mamon, int begin, int end)
        {
            return getLopDangKyByMaMonHoc(mamon, begin, end, false);
        }
        public List<tblLopDangKy> getLopDangKyByMaMonHoc(String mamon)
        {
            return getLopDangKyByMaMonHoc(mamon, 0, 0, true);
        }
        /*******************************************************************/
        

        private List<tblLopDangKy> getLopDangKyByMaPhong(int maphong, int begin, int end, Boolean All)
        {
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "SELECT " + tblLopDangKy.sMA_LOP + ","
                                        + tblLopDangKy.sMA_GIANG_VIEN + ","
                                        + tblLopDangKy.sMA_PHONG + ","
                                        + tblLopDangKy.sMA_MON + ","
                                        + tblLopDangKy.sTEN_LOP + ","
                                        + tblLopDangKy.sTHU + ","
                                        + tblLopDangKy.sCA + ","
                                       + tblLopDangKy.sNGAY_MO_LOP
                                        + tblLopDangKy.sMA_HOC_KY + " "
                            + "FROM LOP_DANG_KY "
                            + "WHERE "
                            + tblLopDangKy.sMA_PHONG + " =  ? ";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_PHONG, maphong);
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
                    int maHK = sqldtRd.GetInt32(8);
                    lop = new tblLopDangKy(MaLop, MaGiangVien, MaPhong, MaMon, TenLop, thu, Ca, ngaydatdau, maHK);
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
        public int CountLopDangKyByMaPhong(int maphong)
        {
            int result = 0;
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "Select COUNT(MA_LOP_DANG_KY) AS COUNTLOP "
                            + "FROM LOP_DANG_KY "
                            + "WHERE "
                            + tblLopDangKy.sMA_PHONG + " =  ? ";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_PHONG, maphong);
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
        public List<tblLopDangKy> getLopDangKyByMaPhong(int maphong, int begin, int end)
        {
            return getLopDangKyByMaPhong(maphong, begin, end, false);
        }
        public List<tblLopDangKy> getLopDangKyByMaPhong(int maphong)
        {
            return getLopDangKyByMaPhong(maphong, 0, 0, true);
        }

        /*******************************************************************/


        private List<tblLopDangKy> getLopDangKyByMaGiangVien(String maGV, int begin, int end, Boolean All)
        {
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "SELECT " + tblLopDangKy.sMA_LOP + ","
                                        + tblLopDangKy.sMA_GIANG_VIEN + ","
                                        + tblLopDangKy.sMA_PHONG + ","
                                        + tblLopDangKy.sMA_MON + ","
                                        + tblLopDangKy.sTEN_LOP + ","
                                        + tblLopDangKy.sTHU + ","
                                        + tblLopDangKy.sCA + ","
                                        + tblLopDangKy.sNGAY_MO_LOP
                                        + tblLopDangKy.sMA_HOC_KY + " "
                            + "FROM LOP_DANG_KY "
                            + "WHERE "
                            + tblLopDangKy.sMA_GIANG_VIEN + " =  ? ";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_GIANG_VIEN, maGV);
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
                    int maHK = sqldtRd.GetInt32(8);
                    lop = new tblLopDangKy(MaLop, MaGiangVien, MaPhong, MaMon, TenLop, thu, Ca, ngaydatdau, maHK);
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
        public int CountLopDangKyByMaGiangVien(String maGV)
        {
            int result = 0;
            List<tblLopDangKy> list = new List<tblLopDangKy>();

            string QueryStr = "Select COUNT(MA_LOP_DANG_KY) AS COUNTLOP "
                            + "FROM LOP_DANG_KY "
                            + "WHERE "
                            + tblLopDangKy.sMA_GIANG_VIEN + " =  ? ";

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopDangKy.sMA_GIANG_VIEN, maGV);
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
        public List<tblLopDangKy> getLopDangKyByMaGiangVien(String maGV, int begin, int end)
        {
            return getLopDangKyByMaGiangVien(maGV, begin, end, false);
        }
        public List<tblLopDangKy> getLopDangKyByMaGiangVien(String maGV)
        {
            return getLopDangKyByMaGiangVien(maGV, 0, 0, true);
        }
    }
}
