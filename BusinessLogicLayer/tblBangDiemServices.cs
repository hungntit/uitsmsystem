using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
    public class tblBangDiemServices
    {
        private tblBangDiemDAO bangdiemDAO;
        public tblBangDiemServices()
        {
            try
            {
                bangdiemDAO = new tblBangDiemDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblBangDiem(String MaSV, String maLopDK, float diem)
        {
            if (bangdiemDAO == null)
                throw new Exception("Can't connect DAL");
            else
                bangdiemDAO.insertTblBangDiem( MaSV,  maLopDK,  diem);
        }
        public void deleteTblBangDiem(String MaSV, String maLopDK)
        {
            if (bangdiemDAO == null)
                throw new Exception("Can't connect DAL");
            else
                bangdiemDAO.deleteTblBangDiem( MaSV,  maLopDK);
        }
        public void updateTblBangDiem(String MaSV, String maLopDK, float diem)
        {
            if (bangdiemDAO == null)
                throw new Exception("Can't connect DAL");
            else
                bangdiemDAO.updateTblBangDiem( MaSV,  maLopDK,  diem);
        }
    }
}
