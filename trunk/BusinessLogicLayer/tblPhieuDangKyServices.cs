using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblPhieuDangKyServices
    {
        private tblPhieuDangKyDAO phieuDkDAO;
        public tblPhieuDangKyServices()
        {
            try
            {
                phieuDkDAO = new tblPhieuDangKyDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblPhieuDangKy(tblPhieuDangKy phieudangky)
        {
            if (phieuDkDAO == null)
                throw new Exception("Can't connect DAL");
            else
                phieuDkDAO.insertTblPhieuDangKy( phieudangky);
        }
        public void updateTblPhieuDangKy(tblPhieuDangKy phieudangky)
        {
            if (phieuDkDAO == null)
                throw new Exception("Can't connect DAL");
            else
                phieuDkDAO.updateTblPhieuDangKy(phieudangky);
        }
        public void deleteTblPhieuDangKy(int maphieu)
        {
            if (phieuDkDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 phieuDkDAO.deleteTblPhieuDangKy(maphieu);
        }
        public tblPhieuDangKy getbyMaPhieuDKy(int MaPhieu)
        {
            if (phieuDkDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return phieuDkDAO.getbyMaPhieuDKy(MaPhieu);
        }
        public List<tblPhieuDangKy> getAllPhieuDangKy(int begin, int end)
        {
            if (phieuDkDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return phieuDkDAO.getAllPhieuDangKy(begin, end);
        }
       public List<tblPhieuDangKy> getAllPhieuDangKy()
        {
            if (phieuDkDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return phieuDkDAO.getAllPhieuDangKy();
        }

       public int CountPhieuDangKy()
       {
           if (phieuDkDAO == null)
               throw new Exception("Can't connect DAL");
           else
               return phieuDkDAO.CountPhieuDangKy();
       }
       
    }
  

}
