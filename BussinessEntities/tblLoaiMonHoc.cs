using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
   public class tblLoaiMonHoc
    {
        
        #region FIELD
        private int _maLoai;
        private String _tenLoai;
        public static String sTABLE_NAME = "LOAI_MON_HOC";

        public static String sMA_LOAI = "MA_LOAI";
        public static String sTEN_LOAI = "TEN_LOAI";
        #endregion

        #region Constructors

        public tblLoaiMonHoc(int maloai, String tenloai)
        {
            this._maLoai = maloai;
            this._tenLoai = tenloai;
        }
        #endregion
        #region Properties
        public int MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }
        

        public String TenLoai
        {
            get { return _tenLoai; }
            set { _tenLoai = value; }
        }
        #endregion

    }
}
