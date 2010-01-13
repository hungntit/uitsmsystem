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

        public int CountLopDangKyByMaPhieu(int maPhieuDK)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.CountLopDangKyByMaPhieu(maPhieuDK);
        }
        public List<tblLopDangKy> getLopDangKyByMaPhieu(int maPhieuDK, int begin, int end)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaPhieu(maPhieuDK, begin, end);
        }
        public List<tblLopDangKy> getLopDangKyByMaPhieu(int maPhieuDK)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaPhieu(maPhieuDK);
        }

        public int CountLopDangKyByMaPhong(int maPhong)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.CountLopDangKyByMaPhong(maPhong);
        }
        public List<tblLopDangKy> getLopDangKyByMaPhong(int maPhong, int begin, int end)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaPhong(maPhong, begin, end);
        }
        public List<tblLopDangKy> getLopDangKyByMaPhong(int maPhong)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaPhong(maPhong);
        }


        public int CountLopDangKyByMaMon(String maMon)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.CountLopDangKyByMaMon(maMon);
        }
        public List<tblLopDangKy> getLopDangKyByMaMonHoc(String maMon, int begin, int end)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaMonHoc(maMon, begin, end);
        }
        public List<tblLopDangKy> getLopDangKyByMaMonHoc(String maMon)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaMonHoc(maMon);
        }



        public int CountLopDangKyByMaGiangVien(String maGV)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.CountLopDangKyByMaGiangVien(maGV);
        }
        public List<tblLopDangKy> getLopDangKyByMaGiangVien(String maGV, int begin, int end)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaGiangVien(maGV, begin, end);
        }
        public List<tblLopDangKy> getLopDangKyByMaGiangVien(String maGV)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return lopDAO.getLopDangKyByMaGiangVien(maGV);
        }


        public void deleteTblLopDangKyByMamon(String mamon)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 lopDAO.deleteTblLopDangKyByMamon(mamon);
        }

        public void deleteTblLopDangKyByMaGiangVien(String magiangvien)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 lopDAO.deleteTblLopDangKyByMaGiangVien(magiangvien);
        }

        public void deleteTblLopDangKyByMaPhong(int maPhong)
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 lopDAO.deleteTblLopDangKyByMaPhong(maPhong);
        }
        public void CloseConection()
        {
            if (lopDAO == null)
                throw new Exception("Can't connect DAL");
            else
                lopDAO.CloseConection();
        }
    }
  

}
