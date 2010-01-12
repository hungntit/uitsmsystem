using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    public class tblMonhoc
    {
        #region FIELD
        public static String sTABLE_NAME = "MON_HOC";
        public static String sMA_MON = "MA_MON";
        public static String sMA_LOAI = "MA_LOAI";
        public static String sTEN_MON = "TEN_MON";
        public static String sTIN_CHI_LY_THUYET = "LY_THUYET";
        public static String sTIN_CHI_THUC_HANH = "THUC_HANH";


        private String _maMon;
        private int _maLoai;

       
        private String _tenMon;
        private int _tinchiLyThuyet;
        private int _tinchiThucHanh;
        #endregion
        #region Constructors
        public tblMonhoc()
        { }
        public tblMonhoc(String maMon,int MaLoai, String tenMon, int soTinchiLythuyet, int soTinchiThucHanh)
        {
            this._maMon = maMon;
            this._maLoai = MaLoai;
            this._tenMon = tenMon;
            this._tinchiLyThuyet = soTinchiLythuyet;
            this._tinchiThucHanh = soTinchiThucHanh;
        }
        #endregion

        #region Properties

        public int MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }
        public String MaMon
        {
            get { return _maMon; }
            set { _maMon = value; }
        }

        public String TenMon
        {
            get { return _tenMon; }
            set { _tenMon = value; }
        }
       

        public int TinchiLyThuyet
        {
            get { return _tinchiLyThuyet; }
            set { _tinchiLyThuyet = value; }
        }
       

        public int TinchiThucHanh
        {
            get { return _tinchiThucHanh; }
            set { _tinchiThucHanh = value; }
        }
        #endregion
    }
}
