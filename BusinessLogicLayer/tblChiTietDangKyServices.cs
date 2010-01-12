using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
    public class tblChiTietDangKyServices
    {
        private tblChiTietDangKyDAO chitietdangkyDAO;
        public tblChiTietDangKyServices()
        {
            try
            {
                chitietdangkyDAO = new tblChiTietDangKyDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblChiTietDangKy(tblPhieuDangKy phieudk, tblLopDangKy lopdk)
        {
            if (chitietdangkyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                chitietdangkyDAO.insertTblChiTietDangKy( phieudk,  lopdk);
        }
        public void deleteTblChiTietDangKy(String maphieu, String maLopDK)
        {
            if (chitietdangkyDAO == null)
                throw new Exception("Can't connect DAL");
            else
                chitietdangkyDAO.deleteTblChiTietDangKy(maphieu, maLopDK);
        }
    }
}
