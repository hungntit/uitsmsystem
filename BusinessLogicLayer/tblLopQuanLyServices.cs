using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblLopQuanLyServices
    {
        private tblLopQuanLyDAO lopquanlyDAO;
        public tblLopQuanLyServices()
        {
            try
            {
                lopquanlyDAO = new tblLopQuanLyDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblLopQuanLy(tblLopQuanLy lopQuanLy)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                lopquanlyDAO.insertTblLopQuanLy( lopQuanLy);
        }
        public void updateTblLopQuanLy(tblLopQuanLy lopQuanLy)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                lopquanlyDAO.updateTblLopQuanLy(lopQuanLy);
        }
        public void deleteTblLopQuanLy(int malop)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 lopquanlyDAO.deleteTblLopQuanLy(malop);
        }
        public tblLopQuanLy getbyMaLopQuanLy(int maLopQL)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopquanlyDAO.getbyMaLopQuanLy(maLopQL);
        }
        public int CountLopQuanLy()
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopquanlyDAO.CountLopQuanLy();
        }
        public List<tblLopQuanLy> getAllLopQuanLy(int begin, int end)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopquanlyDAO.getAllLopQuanLy( begin,  end);
        }
        public List<tblLopQuanLy> getAllLopQuanLy()
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopquanlyDAO.getAllLopQuanLy();
        }
        public int CountLopQuanLyByMaKhoa(String maKhoa)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopquanlyDAO.CountLopQuanLyByMaKhoa( maKhoa);
        }
        public List<tblLopQuanLy> getLopQuanLyByMaKhoa(String makhoa, int begin, int end)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopquanlyDAO.getLopQuanLyByMaKhoa( makhoa,  begin,  end);
        }
        public List<tblLopQuanLy> getLopQuanLyByMaKhoa(String makhoa)
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopquanlyDAO.getLopQuanLyByMaKhoa( makhoa);
        }
        public void CloseConection()
        {
            if (lopquanlyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                lopquanlyDAO.CloseConection();
        }

    }
  

}
