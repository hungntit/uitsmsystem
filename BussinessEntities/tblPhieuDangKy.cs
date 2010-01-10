using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    public class tblPhieuDangKy
    {
        public static String sTABLE_NAME = "PHIEU_DANG_KY";
        public static String sMA_PHIEU = "MA_PHIEU_DANG_KY";
        public static String sMA_SV = "MA_SINH_VIEN";
        public static String sMA_HOC_KY = "MA_HOC_KY";
        public static String sNGAY_DANG_KY = "NGAY_DANG_KY";
        private int _maPhieuDK;
        private int _maHocKy;

       
        private String _maSV;
        private DateTime _ngayDK;

        public tblPhieuDangKy(int maPhieuDk, String maSV,int maHocKy, DateTime ngayDK)
        {
            this._maPhieuDK = maPhieuDk;
            this._maSV = maSV;
            this._ngayDK = ngayDK;
            this._maHocKy = maHocKy;
        }

        public int MaPhieuDK
        {
            get { return _maPhieuDK; }
            set { _maPhieuDK = value; }
        }
        

        public String MaSV
        {
            get { return _maSV; }
            set { _maSV = value; }
        }
        
        public DateTime NgayDK
        {
            get { return _ngayDK; }
            set { _ngayDK = value; }
        }


        public int MaHocKy
        {
            get { return _maHocKy; }
            set { _maHocKy = value; }
        }
        
    }
}
