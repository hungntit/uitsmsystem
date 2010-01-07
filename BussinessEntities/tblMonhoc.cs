using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    class tblMonhoc
    {
        #region FIELD
        private String _maMon;
        private String _tenMon;
        private int _tinchiLyThuyet;
        private int _tinchiThucHanh;
        #endregion
        #region Constructors
        public tblMonhoc(String maMon, String tenMon, int soTinchiLythuyet, int soTinchiThucHanh)
        {
            this._maMon = maMon;
            this._tenMon = tenMon;
            this._tinchiLyThuyet = soTinchiLythuyet;
            this._tinchiThucHanh = soTinchiThucHanh;
        }
        #endregion

        #region Properties
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
