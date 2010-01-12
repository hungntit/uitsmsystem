using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BussinessEntities;
namespace BusinessLogicLayer
{
    public class tblMonTienQuyetServices
    {
        private tblMonTienQuyetDAO montienquyetDAO;
        public tblMonTienQuyetServices()
        {
            try
            {
                montienquyetDAO = new tblMonTienQuyetDAO();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void insertTblMonTienQuyet(tblMonhoc monhoc, tblMonhoc montienquyet)
        {
            if (montienquyetDAO == null)
                throw new Exception("Can't connect DAL");
            else
                montienquyetDAO.insertTblMonTienQuyet( monhoc,  montienquyet);
        }
       public void deleteTblMonTienQuyet(String mamonhoc, String mamontienquyet)
        {
            if (montienquyetDAO == null)
                throw new Exception("Can't connect DAL");
            else
                montienquyetDAO.deleteTblMonTienQuyet( mamonhoc,  mamontienquyet);
        }
    }
}
