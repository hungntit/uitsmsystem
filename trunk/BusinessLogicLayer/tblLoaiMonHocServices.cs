using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblLoaiMonHocServies
    {
        private tblLoaiMonHocDAO loaiMonHocDao;
        public tblLoaiMonHocServies()
        {
            try
            {
                loaiMonHocDao = new tblLoaiMonHocDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblLoaiMonHoc(tblLoaiMonHoc tblloai)
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
                loaiMonHocDao.insertTblLoaiMonHoc(tblloai);
        }
        public void updateTblLoaiMonHoc(tblLoaiMonHoc tblloaiMonHoc)
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
                loaiMonHocDao.updateTblLoaiMonHoc( tblloaiMonHoc);
        }
        public void deleteTblLoaiMonHoc(int maloai)
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
                loaiMonHocDao.deleteTblLoaiMonHoc( maloai);
        }
        public tblLoaiMonHoc getbyMaLoai(int maloai)
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
               return loaiMonHocDao.getbyMaLoai( maloai);
        }
       public List<tblLoaiMonHoc> getAllLoaiMonHoc(int begin, int end)
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
                return loaiMonHocDao.getAllLoaiMonHoc(begin, end);
        }
        public List<tblLoaiMonHoc> getAllLoaiMonHoc()
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
                return loaiMonHocDao.getAllLoaiMonHoc();
        }

        public int CountLoaiMonHoc()
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
                return loaiMonHocDao.CountLoaiMonHoc();
        }
        public void CloseConection()
        {
            if (loaiMonHocDao == null)
                throw new Exception("Can't connect DAL");
            else
                loaiMonHocDao.CloseConection();
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
