using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblHocKyServices
    {
        private tblHocKyDAO hockyDAO;
        public tblHocKyServices()
        {
            try
            {
                hockyDAO = new tblHocKyDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void deleteTblHocKy(int mahocky)
        {
            if (hockyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 hockyDAO.deleteTblHocKy(mahocky);
        }
        public tblHocKy getbyMaHocKy(int maHK)
        {
            if (hockyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return hockyDAO.getbyMaHocKy(maHK);
        }
        public tblHocKy getbyHocKy_Namhoc(int hocky, int namhoc)
        {
            if (hockyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return hockyDAO.getbyHocKy_Namhoc(hocky, namhoc);
        }
        public List<tblHocKy> getAllHocKy()
        {
            if (hockyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return hockyDAO.getAllHocKy();
        }
    }
  

}
