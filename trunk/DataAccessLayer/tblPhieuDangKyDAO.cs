using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblPhieuDangKyDAO : BaseDAO
    {
        public tblPhieuDangKyDAO()
            : base()
        {
            
        }

        public void insertTblPhieuDangKy(tblPhieuDangKy phieudangky)
        {
            string QueryStr = "INSERT INTO"+tblPhieuDangKy.sTABLE_NAME
                            +"("
                            + tblPhieuDangKy.sMA_PHIEU
                            +","
                            + tblPhieuDangKy.sMA_SV 
                            + ","
                            + tblPhieuDangKy.sNGAY_DANG_KY 
                            +") "
                            + "VALUES(?,?,?)";



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblPhieuDangKy.sMA_PHIEU, phieudangky.MaPhieuDK);
                sqlcommand.Parameters.AddWithValue(tblPhieuDangKy.sMA_SV, phieudangky.MaSV);
                sqlcommand.Parameters.AddWithValue(tblPhieuDangKy.sNGAY_DANG_KY, phieudangky.NgayDK);
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

        public void updateTblPhieuDangKy(tblPhieuDangKy phieudangky)
        {
            string QueryStr = "UPDATE PHIEU_DANG_KY "
                            + "WHERE " + tblPhieuDangKy.sMA_PHIEU + " = ? "
                            + "SET "
                            + tblPhieuDangKy.sMA_SV + "= " + phieudangky.MaSV
                            + tblPhieuDangKy.sNGAY_DANG_KY + "= " + phieudangky.NgayDK;



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblPhieuDangKy.sMA_PHIEU, phieudangky.MaPhieuDK);
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

        public tblPhieuDangKyDAO(string user,string password)
            : base(user,password)
        {

        }
        public void deleteTblPhieuDangKy(int maphieu)
        {
            try
            {
                this.deleteObj("CHI_TIET_DANG_KY", "MA_PHIEU_DANG_KY", maphieu);
                this.deleteObj("PHIEU_DANG_KY", "MA_PHIEU_DANG_KY", maphieu);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteTblPhieuDangKyByMaSinhVien(String maSV)
        {
            try
            {
                List<tblPhieuDangKy> lstPhieuDK = getAllPhieuDangKyByMaSinhVien(maSV);
                tblPhieuDangKy[] arrPhieuDk = lstPhieuDK.ToArray();
                for(int i=0;i<lstPhieuDK.Count;i++)
                    deleteTblPhieuDangKy(arrPhieuDk[i].MaPhieuDK);
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
        public tblPhieuDangKy getbyMaPhieuDKy(int MaPhieu)
        {
            tblPhieuDangKy phieudk = null;
            string QueryStr = "Select "
                        +tblPhieuDangKy.sMA_PHIEU+","
                        + tblPhieuDangKy.sMA_SV + ","
                        + tblPhieuDangKy.sNGAY_DANG_KY + " "
                        +"from PHIEU_DANG_KY where MA_PHIEU_DANG_KY  =   ?";
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
                    int Maphieu = sqldtRd.GetInt32(0);
                    String MaSV = sqldtRd.GetString(1);
                    DateTime NgayDangKy = sqldtRd.GetDateTime(2);
                    

                    phieudk = new tblPhieuDangKy(Maphieu, MaSV, NgayDangKy);
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

            string QueryStr = "Select " 
                        +tblPhieuDangKy.sMA_PHIEU + ","
                        + tblPhieuDangKy.sMA_SV + ","
                        + tblPhieuDangKy.sNGAY_DANG_KY + " "
                    +"from PHIEU_DANG_KY ";
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
                    int MaPhieu = sqldtRd.GetInt32(0);
                    String MaSV = sqldtRd.GetString(1);
                    DateTime NgayDangKy = sqldtRd.GetDateTime(2);
                   

                    phieudk = new tblPhieuDangKy(MaPhieu, MaSV, NgayDangKy);
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
        /**************************************************************************/

        private List<tblPhieuDangKy> getAllPhieuDangKyByMaSinhVien(String maSV,int begin, int end, Boolean All)
        {
            List<tblPhieuDangKy> list = new List<tblPhieuDangKy>();

            string QueryStr = "Select " 
                        +tblPhieuDangKy.sMA_PHIEU + ","
                        + tblPhieuDangKy.sMA_SV + ","
                        + tblPhieuDangKy.sNGAY_DANG_KY + " "
                    + "from PHIEU_DANG_KY "
                        +"WHERE " + tblPhieuDangKy.sMA_SV + " = ? ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblPhieuDangKy.sMA_SV, maSV);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblPhieuDangKy phieudk = null;
                    int MaPhieu = sqldtRd.GetInt32(0);
                    String MaSV = sqldtRd.GetString(1);
                    DateTime NgayDangKy = sqldtRd.GetDateTime(2);


                    phieudk = new tblPhieuDangKy(MaPhieu, MaSV, NgayDangKy);
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

        public List<tblPhieuDangKy> getAllPhieuDangKyByMaSinhVien(String maSV,int begin, int end)
        {
            return getAllPhieuDangKyByMaSinhVien(maSV,begin, end, false);
        }
        public List<tblPhieuDangKy> getAllPhieuDangKyByMaSinhVien(String maSV)
        {
            return getAllPhieuDangKyByMaSinhVien(maSV,0, 0, true);
        }

        public int CountPhieuDangKyByMaSV(String maSV)
        {
            int result = 0;

            string QueryStr = "Select COUNT(MA_PHIEU_DANG_KY)"
                            +" from PHIEU_DANG_KY "
                            + "WHERE " + tblPhieuDangKy.sMA_SV + " = ? ";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblPhieuDangKy.sMA_SV, maSV);
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
