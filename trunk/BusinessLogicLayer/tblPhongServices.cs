using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblPhongServices
    {
        private tblPhongDAO phongDAO;
        public tblPhongServices()
        {
            try
            {
                phongDAO = new tblPhongDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
       
        public tblPhong getbyMaPhong(int maPhong)
        {
            if (phongDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return phongDAO.getbyMaPhong( maPhong);
        }
        public List<tblPhong> getAllPhong(int begin, int end)
        {
            if (phongDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return phongDAO.getAllPhong( begin,  end);
        }
        public List<tblPhong> getAllPhong()
        {
            if (phongDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return phongDAO.getAllPhong();
        }

        public int CountPhong()
        {
            if (phongDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return phongDAO.CountPhong();
        }
        public void CloseConection()
        {
            if (phongDAO == null)
                throw new Exception("Can't connect DAL");
            else
                phongDAO.CloseConection();
        }
    }
  

}
