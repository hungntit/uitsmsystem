using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessEntities
{
   public class tblSinhVien:tblPerson
    {
        #region Field
       public static String sTABLE_NAME = "SINH_VIEN";

       public static String sMASV = "MA_SINH_VIEN";
       public static String sMA_LOP_QUAN_LY = "MA_LOP_QUAN_LY";
       public static String sNIEN_KHOA = "NIEN_KHOA";
       public static String sHO_SINH_VIEN = "HO_SINH_VIEN";
       public static String sTEN_SINH_VIEN = "TEN_SINH_VIEN";
        private String _maSV;
        private int _maLopQuanLy;

        
        private int _nienkhoa;
      

        #endregion
        #region Constructor
        public tblSinhVien()
        { }
        public tblSinhVien(String maSV, int malopquanly, String hoSV, String tenSV, String cmnd, DateTime ngaysinh, Boolean gioitinh, String noisinh, String diachi, int nienkhoa):base(hoSV,tenSV,cmnd,ngaysinh,gioitinh,noisinh,diachi)
        {
            this._maSV          = maSV;
            this._maLopQuanLy = malopquanly;
            this._nienkhoa      = nienkhoa;
        }


        #endregion
        #region Properties

        public int MaLopQuanLy
        {
            get { return _maLopQuanLy; }
            set { _maLopQuanLy = value; }
        }
        public String MaSV
        {
            get
            {
                return _maSV;

            }
            set
            {
                _maSV = value;
            }

        }
       
       
        

        public int NienKhoa
        {
            get { return _nienkhoa; }
            set { _nienkhoa = value; }
        }
        #endregion
    }

}
