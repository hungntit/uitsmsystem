using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
   public class tblSinhVienServices
    {
        private tblSinhVienDAO sinhvienDAO;
        public tblSinhVienServices()
        {
            try
            {
                sinhvienDAO = new tblSinhVienDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblSinhVien(tblSinhVien sinhvien)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                sinhvienDAO.insertTblSinhVien( sinhvien);
        }
        public void updateTblSinhVien(tblSinhVien sinhvien)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                sinhvienDAO.updateTblSinhVien(sinhvien);
        }
        public void deleteTblSinhVien(String maSv)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                 sinhvienDAO.deleteTblSinhVien(maSv);
        }
        public tblSinhVien getbyMaSV(String MaSV)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return sinhvienDAO.getbyMaSV(MaSV);
        }
        public tblSinhVien getbyCMND(String cmnd)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return sinhvienDAO.getbyCMND(cmnd);
        }
        public int CountSinhVien()
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return sinhvienDAO.CountSinhVien();
        }
        public List<tblSinhVien> getAllSinhVien(int begin, int end)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return sinhvienDAO.getAllSinhVien(begin,end);
        }
        public List<tblSinhVien> getAllSinhVien()
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return sinhvienDAO.getAllSinhVien();
        }
        public List<tblSinhVien> getAllSinhVienByMaKhoa(String makhoa, int begin, int end)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return sinhvienDAO.getAllSinhVienByMaKhoa(makhoa, begin, end);
        }
       public List<tblSinhVien> getAllSinhVienByMaKhoa(String makhoa)
        {
            if (sinhvienDAO == null)
                throw new Exception("Can't connect DAL");
            else
                return sinhvienDAO.getAllSinhVienByMaKhoa(makhoa);
        }

       public int CountSinhVienByMaKhoa(String makhoa)
       {
           if (sinhvienDAO == null)
               throw new Exception("Can't connect DAL");
           else
               return sinhvienDAO.CountSinhVienByMaKhoa(makhoa);
       }
       public List<tblSinhVien> getAllSinhVienByMaLopQuanLy(int malop, int begin, int end)
         {
             if (sinhvienDAO == null)
                 throw new Exception("Can't connect DAL");
             else
                 return sinhvienDAO.getAllSinhVienByMaLopQuanLy(malop,begin,end);
         }

       public List<tblSinhVien> getAllSinhVienByMaLopQuanLy(int malop)
         {
             if (sinhvienDAO == null)
                 throw new Exception("Can't connect DAL");
             else
                 return sinhvienDAO.getAllSinhVienByMaLopQuanLy(malop);
         }

         public int CountSinhVienByMaLopQuanLy(int malopQly)
         {
             if (sinhvienDAO == null)
                 throw new Exception("Can't connect DAL");
             else
                 return sinhvienDAO.CountSinhVienByMaLopQuanLy(malopQly);
         }
         public void CloseConection()
         {
             if (sinhvienDAO == null)
                 throw new Exception("Can't connect DAL");
             else
                 sinhvienDAO.CloseConection();
         }
    }
  

}
