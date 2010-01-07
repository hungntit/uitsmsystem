using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    class tblKhoa
    {
        
        #region FIELD
        private String _maKhoa;
        private String _tenKhoa;
        #endregion

        #region Constructors
        
        public tblKhoa(String makhoa, String tenkhoa)
        {
            this._maKhoa = makhoa;
            this._tenKhoa = tenkhoa;
        }
        #endregion
        #region Properties
        public String MaKhoa
        {
            get { return _maKhoa; }
            set { _maKhoa = value; }
        }
        

        public String TenKhoa
        {
            get { return _tenKhoa; }
            set { _tenKhoa = value; }
        }
        #endregion

    }
}
