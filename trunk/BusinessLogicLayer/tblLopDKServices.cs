using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblLopDKServices
    {
        private tblLopDangKyDAO lopDAO;
        public tblLopDKServices()
        {
            try
            {
                lopDAO = new tblLopDangKyDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblLopDangKy(tblLopDangKy lopdangky)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                lopDAO.insertTblLopDangKy( lopdangky);
        }
        public void updateTblLopDangKy(tblLopDangKy lopdangky)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                lopDAO.updateTblLopDangKy(lopdangky);
        }
        public void deleteTblLopDangKy(int malop)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 lopDAO.deleteTblLopDangKy(malop);
        }
        public tblLopDangKy getbyMaLop(String maLop)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getbyMaLop(maLop);
        }
        public List<tblLopDangKy> getAllLopDK(int begin, int end)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getAllLopDK(begin,end);
        }
        public List<tblLopDangKy> getAllLopDK()
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getAllLopDK();
        }
        public int CountLopDK()
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.CountLopDK();
        }

        public int CountLopDangKy(String maPhieuDK)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.CountLopDangKy(maPhieuDK);
        }
        public List<tblLopDangKy> getLopDangKy(String maPhieuDK, int begin, int end)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKy(maPhieuDK, begin, end);
        }
        public List<tblLopDangKy> getLopDangKy(String maPhieuDK)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKy(maPhieuDK);
        }
    }
  

}
