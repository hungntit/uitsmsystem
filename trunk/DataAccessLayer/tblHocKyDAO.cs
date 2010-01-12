using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessEntities;
namespace DataAccessLayer
   
{
    public class tblHocKyDAO:BaseDAO
    {
        public tblHocKyDAO()
            : base()
        {
            
        }
        public tblHocKyDAO(string user,string password)
            : base(user,password)
        {

        }
        public void deleteTblHocKy(int mahocky)
        {
             this.deleteObj("HOC_KY", "MA_HOC_KY", mahocky);
        }
        /*
         *@ Lay Thong tin giang vien boi MaGV
         *@ MaGV: maSV can tim 
         */ 
        public tblHocKy getbyMaHocKy(int maHK)
        {
            tblHocKy HKy = null;
            string QueryStr = "Select * from HOC_KY where MA_HK  =   @MA_HK";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@MA_HK", maHK);
             
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    int mahk = sqldtRd.GetInt32(0);
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
            string QueryStr = "Select * from HOC_KY where HOC_KY  =   @HOCKY and NAM_HOC = @NAM_HOC";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqlcommand.Parameters.AddWithValue("@HOCKY", hocky);
                sqlcommand.Parameters.AddWithValue("@NAM_HOC", namhoc);
                
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    int mahk = sqldtRd.GetInt32(0);
                   

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
        public List<tblHocKy> getAllHocKy()
        {
            List<tblHocKy> list = new List<tblHocKy>();


            string QueryStr = "Select * from HOC_KY";
            SqlDataReader sqldtRd = null;
            SqlCommand sqlcommand = null;
            try
            {
                sqlcommand = new SqlCommand(QueryStr, this.sqlCon);
                sqlcommand.CommandType = System.Data.CommandType.Text;
                sqldtRd = sqlcommand.ExecuteReader();
                while (sqldtRd.Read())
                {
                    tblHocKy HKy = null;
                    int mahk = sqldtRd.GetInt32(0);
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
