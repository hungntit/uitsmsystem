using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblMonHocDAO : BaseDAO
    {
        public tblMonHocDAO()
            : base()
        {
            
        }
        public tblMonHocDAO(string user,string password)
            : base(user,password)
        {

        }

        public void insertTblMonHoc(tblMonhoc monhoc)
        {
            string QueryStr = "INSERT INTO "+tblMonhoc.sTABLE_NAME
                +"("
                            + tblMonhoc.sMA_MON 
                            + ","
                            + tblMonhoc.sMA_LOAI 
                            + ","
                            + tblMonhoc.sTEN_MON 
                            + ","
                            + tblMonhoc.sTIN_CHI_LY_THUYET 
                            + ","
                            + tblMonhoc.sTIN_CHI_THUC_HANH 
                            +") "
                            + "VALUES(@" + tblMonhoc.sMA_MON + "," + "@" + tblMonhoc.sMA_LOAI + "," + "@" + tblMonhoc.sTIN_CHI_LY_THUYET + ","
                            + "@" + tblMonhoc.sTIN_CHI_LY_THUYET + ","
                            + "@" + tblMonhoc.sTIN_CHI_THUC_HANH + ")";



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sMA_MON, monhoc.MaMon);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sMA_LOAI, monhoc.MaLoai);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sTEN_MON, monhoc.TenMon);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sTIN_CHI_LY_THUYET, monhoc.TinchiLyThuyet);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sTIN_CHI_THUC_HANH, monhoc.TinchiThucHanh);

                ////sqlcommand.Prepare();
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

        public void updateTblMonHoc(tblMonhoc monhoc)
        {
            string QueryStr = "UPDATE MON_HOC "
                            + "SET "
                            + tblMonhoc.sMA_LOAI + " = @" + tblMonhoc.sMA_LOAI + ","
                            + tblMonhoc.sTEN_MON + " = @" + tblMonhoc.sTEN_MON + ","
                            + tblMonhoc.sTIN_CHI_LY_THUYET + " = @" + tblMonhoc.sTIN_CHI_LY_THUYET + ","
                            + tblMonhoc.sTIN_CHI_THUC_HANH + " = @" + tblMonhoc.sTIN_CHI_THUC_HANH
                            + "WHERE " + tblMonhoc.sMA_MON + " = @" + tblMonhoc.sMA_MON +" ";


            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sMA_MON, monhoc.MaMon);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sMA_LOAI, monhoc.MaLoai);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sTEN_MON, monhoc.TenMon);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sTIN_CHI_LY_THUYET, monhoc.TinchiLyThuyet);
                sqlcommand.Parameters.AddWithValue("@" + tblMonhoc.sTIN_CHI_THUC_HANH, monhoc.TinchiThucHanh);
                //sqlcommand.Prepare();
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
        public void deleteTblMonHoc(String mamonhoc)
        {
            try
            {
                tblLopDangKyDAO lopdkDao = new tblLopDangKyDAO();
                lopdkDao.deleteTblLopDangKyByMamon(mamonhoc);
                
                this.deleteObj("MON_TIEN_QUYET", tblMonhoc.sMA_MON, mamonhoc);
                this.deleteObj("MON_TIEN_QUYET", "MA_MON_TIEN_QUYET", mamonhoc);
                this.deleteObj("GIANG_DAY", tblMonhoc.sMA_MON, mamonhoc);
                this.deleteObj("MON_HOC", tblMonhoc.sMA_MON, mamonhoc);
                lopdkDao.CloseConection();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         *@ Lay Thong tin giang vien boi MaGV
         *@ MaGV: maSV can tim 
         */ 
        public tblMonhoc getbyMaMonHoc(String maMon)
        {
            tblMonhoc monhoc = null;
            string QueryStr = "Select * from MON_HOC where MA_MON  = @MA_MON";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@MA_MON", maMon);
                //sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String MaMon = sqldtRd.GetString(0);
                    int maloai = sqldtRd.GetInt32(1);
                    String tenMon = sqldtRd.GetString(2);
                    int sotclythuyet = sqldtRd.GetInt32(3);
                    int sotcthuchanh = sqldtRd.GetInt32(4);

                    monhoc = new tblMonhoc(MaMon,maloai, tenMon, sotclythuyet, sotcthuchanh);
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

            return monhoc;
            
        }
        private List<tblMonhoc> getAllMonHoc(int begin,int end,Boolean All)
        {
            List<tblMonhoc> list = new List<tblMonhoc>();


            string QueryStr = "Select * from MON_HOC";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
               
                //sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblMonhoc monhoc = null;

                    String MaMon = sqldtRd.GetString(0);
                    int maloai = sqldtRd.GetInt32(1);
                    String tenMon = sqldtRd.GetString(2);
                    int sotclythuyet = sqldtRd.GetInt32(3);
                    int sotcthuchanh = sqldtRd.GetInt32(4);

                    monhoc = new tblMonhoc(MaMon,maloai, tenMon, sotclythuyet, sotcthuchanh);
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
        public List<tblMonhoc> getAllMonHoc(int begin, int end)
        {
            return getAllMonHoc(begin, end, false);
        }
        public List<tblMonhoc> getAllMonHoc()
        {
            return getAllMonHoc(0, 0, true);
        }
        public int CountMonHoc()
        {
            int result = 0;


            string QueryStr = "Select COUNT(MA_MON) AS COUNTMAMH from MON_HOC";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;

                //sqlcommand.Prepare();
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


        public List<tblMonhoc> getAllMonHocTienQuyet(String MaMonhoc)
        {
            List<tblMonhoc> list = new List<tblMonhoc>();


            string QueryStr = "SELECT MON_HOC.* "
                            + "FROM MON_HOC ,MON_TIEN_QUYET "
                            + "WHERE "
                            + "MON_TIEN_QUYET.MA_MON_TIEN_QUYET = MON_HOC.MA_MON "
                            + "MON_TIEN_QUYET.MA_MON = @MA_MON ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@MA_MON", MaMonhoc);
                //sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblMonhoc monhoc = null;
                    String MaMon = sqldtRd.GetString(0);
                    int maloai = sqldtRd.GetInt32(1);
                    String tenMon = sqldtRd.GetString(2);
                    int sotclythuyet = sqldtRd.GetInt32(3);
                    int sotcthuchanh = sqldtRd.GetInt32(4);

                    monhoc = new tblMonhoc(MaMon,maloai, tenMon, sotclythuyet, sotcthuchanh);
                    list.Add(monhoc);
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

    }
}
