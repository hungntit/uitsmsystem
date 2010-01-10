using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinessEntities;
using DataAccessLayer;
namespace BusinessLogicLayer
{
   public class tblGiangVienServices
    {
       private tblGiangVienDAO giangvienDao;
       public tblGiangVienServices()
       {
           try
           {
               giangvienDao = new tblGiangVienDAO();
           }
           catch (Exception)
           {
               throw;
           }
       }
       public void insertTblGiangVien(tblGiangVien giangvien)
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
               giangvienDao.insertTblGiangVien( giangvien);
       }
       public void updateTblGiangVien(tblGiangVien giangvien)
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
               giangvienDao.updateTblGiangVien(giangvien);
       }
       public void deleteTblGiangVien(String maGiangVien)
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
                giangvienDao.deleteTblGiangVien(maGiangVien);
       }
       public void updateTblGiangVien(tblGiangVien giangvien)
       {

       }
       public tblGiangVien getbyMaGV(String MaGV)
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
               return giangvienDao.getbyMaGV(MaGV);
       }
       public List<tblGiangVien> findByHoTenGiangVien(String ho, String ten)
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
               return giangvienDao.findByHoTenGiangVien(ho,ten);
       }
       public List<tblGiangVien> getAllGiangVien(int begin, int end)
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
               return giangvienDao.getAllGiangVien(begin, end);
       }
       public List<tblGiangVien> getAllGiangVien()
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
               return giangvienDao.getAllGiangVien();
       }
       public int CountGiangVien()
       {
           if (giangvienDao == null)
               throw new Exception("Can't connect DAL");
           else
               return giangvienDao.CountGiangVien();
       }


       public List<tblGiangVien> getGiangVienByMaMonHoc(String mamon,int begin, int end)
        {
            if (giangvienDao == null)
                throw new Exception("Can't connect DAL");
            else
                return giangvienDao.getGiangVienByMaMonHoc(mamon, begin, end);
        }
        public List<tblGiangVien> getGiangVienByMaMonHoc(String mamon)
        {
            if (giangvienDao == null)
                throw new Exception("Can't connect DAL");
            else
                return giangvienDao.getGiangVienByMaMonHoc(mamon);
        }
        public int CountGiangVienByMaMon(String mamon)
        {
            if (giangvienDao == null)
                throw new Exception("Can't connect DAL");
            else
                return giangvienDao.CountGiangVienByMaMon( mamon);
        }
    }
}
