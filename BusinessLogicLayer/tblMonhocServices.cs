using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblMonhocServices
    {
        private tblMonHocDAO monhocDAO;
        public tblMonhocServices()
        {
            try
            {
                monhocDAO = new tblMonHocDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblMonHoc(tblMonhoc monhoc)
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                monhocDAO.insertTblMonHoc( monhoc);
        }
        public void updateTblMonHoc(tblMonhoc monhoc)
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                monhocDAO.updateTblMonHoc(monhoc);
        }
        public void deleteTblMonHoc(String mamonhoc)
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 monhocDAO.deleteTblMonHoc(mamonhoc);
        }
        public tblMonhoc getbyMaMonHoc(String maMon)
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return monhocDAO.getbyMaMonHoc(maMon);
        }
       public List<tblMonhoc> getAllMonHoc(int begin, int end)
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return monhocDAO.getAllMonHoc(begin,end);
        }
        public List<tblMonhoc> getAllMonHoc()
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return monhocDAO.getAllMonHoc();
        }
        public int CountMonHoc()
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return monhocDAO.CountMonHoc();
        }
        public List<tblMonhoc> getAllMonHocTienQuyet(String MaMonhoc)
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return monhocDAO.getAllMonHocTienQuyet(MaMonhoc);
        }
        public void CloseConection()
        {
            if (monhocDAO == null)
                throw new Exception("Can't connect DAL");
            else
                monhocDAO.CloseConection();
        }
    }
  

}
