using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblLopQuanLyDAO:BaseDAO
    {
        public tblLopQuanLyDAO()
            : base()
        {
            
        }
        public tblLopQuanLyDAO(string user,string password)
            : base(user,password)
        {

        }
        public void insertTblLopQuanLy(tblLopQuanLy lopQuanLy)
        {
            string QueryStr = "INSERT INTO  " + tblLopQuanLy.sTABLE_NAME
                            + "("
                            + tblLopQuanLy.sMA_LOP
                            + ","
                            + tblLopQuanLy.sMA_KHOA
                            + ","
                            + tblLopQuanLy.sTEN_LOP
                            + ") "
                            + "VALUES(?,?,?) ";




            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopQuanLy.sMA_LOP, lopQuanLy.MaLopQuanLy);
                sqlcommand.Parameters.AddWithValue(tblLopQuanLy.sMA_KHOA, lopQuanLy.MaKhoa);
                sqlcommand.Parameters.AddWithValue(tblLopQuanLy.sTEN_LOP, lopQuanLy.TenLopQuanLy);
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

        public void updateTblLopQuanLy(tblLopQuanLy lopQuanLy)
        {
            string QueryStr = "UPDATE  " + tblLopQuanLy.sTABLE_NAME + " "
                            + "WHERE " + tblLopQuanLy.sMA_LOP + " = ? "
                            + "SET "
                            + tblLopQuanLy.sMA_KHOA + " = ?,"
                            + tblLopQuanLy.sTEN_LOP + " = ?";



            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue(tblLopQuanLy.sMA_LOP, lopQuanLy.MaLopQuanLy);
                sqlcommand.Parameters.AddWithValue(tblLopQuanLy.sMA_KHOA, lopQuanLy.MaKhoa);
                sqlcommand.Parameters.AddWithValue(tblLopQuanLy.sTEN_LOP, lopQuanLy.TenLopQuanLy);
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

        public void deleteTblLopQuanLy(int malop)
        {

            try
            {
                tblSinhVienDAO svDao = new tblSinhVienDAO();
                svDao.deleteTblSinhVienByMaLopQL(malop);
                this.deleteObj("LOP_QUAN_LY", "MA_LOP_QUAN_LY", malop);
                svDao.CloseConection();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteTblLopQuanLyByMaKhoa(String maKhoa)
        {

            try
            {
                List<tblLopQuanLy> lstLopQl = getLopQuanLyByMaKhoa(maKhoa);
                tblLopQuanLy[] arrLopQL = lstLopQl.ToArray();
                for (int i = 0; i < lstLopQl.Count; i++)
                    deleteTblLopQuanLy(arrLopQL[i].MaLopQuanLy);
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
        public tblLopQuanLy getbyMaLopQuanLy(int maLopQL)
        {
            tblLopQuanLy lop = null;
            string QueryStr = "Select * from LOP_QUAN_LY where MA_LOP_QUAN_LY  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_LOP_QUAN_LY", maLopQL);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    int malop = sqldtRd.GetInt32(0);
                    String makhoa = sqldtRd.GetString(1);
                    String tenlop = sqldtRd.GetString(2);

                    lop = new tblLopQuanLy(malop, makhoa, tenlop);
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



        private List<tblLopQuanLy> getAllLopQuanLy(int begin,int end,Boolean All)
        {
            List<tblLopQuanLy> list = new List<tblLopQuanLy>();


            string QueryStr = "Select * from LOP_QUAN_LY ";
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
                    int malop = sqldtRd.GetInt32(0);
                    String makhoa = sqldtRd.GetString(1);
                    String tenlop = sqldtRd.GetString(2);

                    tblLopQuanLy lop = new tblLopQuanLy(malop, makhoa, tenlop);
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

        public  int CountLopQuanLy()
        {
            int result = 0;


            string QueryStr = "Select * from LOP_QUAN_LY ";
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

        public List<tblLopQuanLy> getAllLopQuanLy(int begin, int end)
        {
            return getAllLopQuanLy(begin, end, false);
        }
        public List<tblLopQuanLy> getAllLopQuanLy()
        {
            return getAllLopQuanLy(0, 0, true);
        }

        /*************************************************/

        private List<tblLopQuanLy> getLopQuanLyByMaKhoa(String maKhoa,int begin, int end, Boolean All)
        {
            List<tblLopQuanLy> list = new List<tblLopQuanLy>();


            string QueryStr = "Select * "
                            + "from LOP_QUAN_LY "
                            + "WHERE MA_KHOA = ? ";
                           

            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_KHOA", maKhoa);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    int malop = sqldtRd.GetInt32(0);
                    String makhoa = sqldtRd.GetString(1);
                    String tenlop = sqldtRd.GetString(2);

                    tblLopQuanLy lop = new tblLopQuanLy(malop, makhoa, tenlop);
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

        public int CountLopQuanLyByMaKhoa(String maKhoa)
        {
            int result = 0;


            string QueryStr = "Select COUNT(MA_LOP_QUAN_LY) AS COUNTLOPQL "
                            + "from LOP_QUAN_LY "
                            + "WHERE MA_KHOA = ? ";


            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_KHOA", maKhoa);
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

        public List<tblLopQuanLy> getLopQuanLyByMaKhoa(String makhoa,int begin, int end)
        {
            return getLopQuanLyByMaKhoa(makhoa, begin, end, false);
        }
        public List<tblLopQuanLy> getLopQuanLyByMaKhoa(String makhoa)
        {
            return getLopQuanLyByMaKhoa(makhoa,0, 0, true);
        }

    }
}
