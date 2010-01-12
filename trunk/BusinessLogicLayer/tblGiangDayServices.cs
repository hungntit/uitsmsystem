using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
    public class tblGiangDayServices
    {
        private tblGiangDayDAO giangdayDAO;
        public tblGiangDayServices()
        {
            try
            {
                giangdayDAO = new tblGiangDayDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
       public void insertTblGiangDay(tblGiangVien giangvien, tblMonhoc monhoc)
        {
            if (giangdayDAO == null)
                throw new Exception("Can't connect DAL");
            else
                giangdayDAO.insertTblGiangDay(giangvien, monhoc);
        }
        public void deleteTblGiangDay(String mamonhoc,String maGV)
        {
            if (giangdayDAO == null)
                throw new Exception("Can't connect DAL");
            else
                giangdayDAO.deleteTblGiangDay(mamonhoc, maGV);
        }
        public void CloseConection()
        {
            if (giangdayDAO == null)
                throw new Exception("Can't connect DAL");
            else
                giangdayDAO.CloseConection();
        }
    }
}
