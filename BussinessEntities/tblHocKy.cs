using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
   public class tblHocKy
    {
        #region FIELDS
        private int _maHK;
        private int _hocky;
        private int _namhoc;
        #endregion

        #region Constructors
        public tblHocKy(int maHK, int hocky, int namhoc)
        {
            _maHK = maHK;
            _hocky = hocky;
            _namhoc = namhoc;
        }
        #endregion

        #region Properties
        public int MaHK
        {
            get { return _maHK; }
            set { _maHK = value; }
        }
        

        public int HocKy
        {
            get { return _hocky; }
            set { _hocky = value; }
        }
       

        public int NamHoc
        {
            get { return _namhoc; }
            set { _namhoc = value; }
        }
        #endregion
    }
}
