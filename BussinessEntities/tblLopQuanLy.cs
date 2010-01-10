using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
   public class tblLopQuanLy
    {
       public static String sTABLE_NAME = "LOP_QUAN_LY";

       public static String sMA_LOP = "MA_LOP";
       public static String sTEN_LOP = "TEN_LOP";
       public static String sMA_KHOA = "MA_KHOA";
        private int _maLopQuanLy;
         private String _tenLopQuanLy;
         private String _maKhoa;

         public tblLopQuanLy(int malop,String tenlopQL,String makhoa)
         {
             this._maKhoa = makhoa;
             this._maLopQuanLy = malop;
             this._tenLopQuanLy = tenlopQL;
         }
        public int MaLopQuanLy
        {
            get { return _maLopQuanLy; }
            set { _maLopQuanLy = value; }
        }
       

        public String MaKhoa
        {
            get { return _maKhoa; }
            set { _maKhoa = value; }
        }
       

        public String TenLopQuanLy
        {
            get { return _tenLopQuanLy; }
            set { _tenLopQuanLy = value; }
        }

         
    }
}
