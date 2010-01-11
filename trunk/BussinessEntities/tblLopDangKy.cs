using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
  public  class tblLopDangKy
    {
       
        #region FIELD
      public static String sTABLE_NAME = "LOP_DANG_KY";

      public static String sMA_LOP = "MA_LOP_DANG_KY";
      public static String sMA_GIANG_VIEN = "MA_GIANG_VIEN";
      public static String sMA_PHONG = "MA_PHONG";
      public static String sMA_MON = "MA_MON";
      public static String sMA_HOC_KY = "MA_HOC_KY";
      public static String sTEN_LOP = "TEN_LOP";
      public static String sTHU = "THU";
      public static String sCA = "CA";
      public static String sNGAY_MO_LOP = "NGAY_MO_LOP";

        private int _maLop;
        private String _maMon;
        private String _maGiangVien;
        private String _maPhong;
        private String _tenLop;
        private DayOfWeek _thu;
        private int _ca;
        private int _maHocKy;
        private DateTime _ngayMoLop;
        #endregion

        #region Constructor

        public tblLopDangKy(int maLop, String maGiangVien, String maPhong, String maMon, String tenLop, DayOfWeek thu, int ca, DateTime ngaymolop,int maHocKy)
        {
            this._maLop = maLop;
            this._maMon = maMon;
            this._maGiangVien = maGiangVien;
            this._maPhong = maPhong;
            this._tenLop = tenLop;
            this._thu = thu;
            this._ca = ca;
            this._ngayMoLop = ngaymolop;
            this._maHocKy = maHocKy;
        }
        #endregion
        #region Properties
        public int MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        public String MaMon
        {
            get { return _maMon; }
            set { _maMon = value; }
        }

        public int MaHocKy
        {
            get { return _maHocKy; }
            set { _maHocKy = value; }
        }
        public String MaGiangVien
        {
            get { return _maGiangVien; }
            set { _maGiangVien = value; }
        }
       

        public String MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public String TenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
        }

        public DayOfWeek Thu
        {
            get { return _thu; }
            set { _thu = value; }
        }

        public int Ca
        {
            get { return _ca; }
            set { _ca = value; }
        }
        

        

        public DateTime NgayMoLop
        {
            get { return _ngayMoLop; }
            set { _ngayMoLop = value; }
        }

        #endregion
    }
}
