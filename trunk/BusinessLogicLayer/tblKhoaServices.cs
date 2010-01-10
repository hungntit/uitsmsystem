using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblKhoaServices
    {
        private tblKhoaDAO khoaDAO;
        public tblKhoaServices()
        {
            try
            {
                khoaDAO = new tblKhoaDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblKhoa(tblKhoa khoa)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                khoaDAO.insertTblKhoa(khoa);
        }
        public void updateTblKhoa(tblKhoa khoa)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                khoaDAO.updateTblKhoa(khoa);
        }
        public void deleteTblKhoa(String makhoa)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                khoaDAO.deleteTblKhoa(makhoa);
        }
        public tblKhoa getbyMaKhoa(String maKhoa)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return khoaDAO.getbyMaKhoa(maKhoa);
        }

        public List<tblKhoa> getAllKhoa(int begin, int end)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return khoaDAO.getAllKhoa(begin,end);
        }
        public List<tblKhoa> getAllKhoa()
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return khoaDAO.getAllKhoa();
        }
        public int CountKhoa()
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return khoaDAO.CountKhoa();
        }
       /*
        public List<tblMonhoc> getAllMonHoc(String MaKhoa, int begin, int end)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return khoaDAO.getAllMonHoc(MaKhoa,begin, end);
        }
        public List<tblMonhoc> getAllMonHoc(String MaKhoa)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return khoaDAO.getAllMonHoc(MaKhoa);
        }
        public int CountMonHoc(String MaKhoa)
        {
            if (khoaDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return khoaDAO.CountMonHoc(MaKhoa);
        }
        * */
    }
  

}
