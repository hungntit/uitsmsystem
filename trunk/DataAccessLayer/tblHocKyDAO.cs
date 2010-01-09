using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    class tblHocKyDAO:BaseDAO
    {
        public tblHocKyDAO()
            : base()
        {
            
        }
        public tblHocKyDAO(string user,string password)
            : base(user,password)
        {

        }
        /*
         *@ Lay Thong tin giang vien boi MaGV
         *@ MaGV: maSV can tim 
         */ 
        public tblHocKy getbyMaHocKy(String maHK)
        {
            tblHocKy HKy = null;
            string QueryStr = "Select * from HOC_KY where MA_HK  =   ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("MA_HK", maHK);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String mahk = sqldtRd.GetString(0);
                    int hocky = sqldtRd.GetInt32(1);
                    int namhoc = sqldtRd.GetInt32(2);

                    HKy = new tblHocKy(mahk, hocky,namhoc);
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

            return HKy;
            
        }


        public tblHocKy getbyHocKy_Namhoc(int hocky,int namhoc)
        {
            tblHocKy HKy = null;
            string QueryStr = "Select * from HOC_KY where HOCKY  =   ? and NAM_HOC = ?";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("HOCKY", hocky);
                sqlcommand.Parameters.AddWithValue("NAM_HOC", namhoc);
                sqlcommand.Prepare();
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    String mahk = sqldtRd.GetString(0);
                   

                    HKy = new tblHocKy(mahk, hocky, namhoc);
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

            return HKy;

        }
        public List<tblHocKy> getAllPhieuDangKy()
        {
            List<tblHocKy> list = new List<tblHocKy>();


            string QueryStr = "Select * from HOC_KY where MA_HOC_KY  =   ?";
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
                    tblHocKy HKy = null;
                    String mahk = sqldtRd.GetString(0);
                    int hocky = sqldtRd.GetInt32(1);
                    int namhoc = sqldtRd.GetInt32(2);

                    HKy = new tblHocKy(mahk, hocky, namhoc);
                    list.Add(HKy);
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
