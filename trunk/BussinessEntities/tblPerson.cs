using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    public class tblPerson
    {
        #region FIELD
        protected String _ho;
        protected String _ten;
        protected String _cmnd;
        protected DateTime _ngaysinh;
        protected Boolean _gioitinh;
        protected String _noisinh;
        protected String _diachi;
        #endregion

        #region Constructors
        public tblPerson( String ho, String ten, String cmnd, DateTime ngaysinh, Boolean gioitinh, String noisinh, String diachi)
        {
            
            this._ho          = ho;
            this._ten         = ten;
            this._cmnd          = cmnd;
            this._ngaysinh      = ngaysinh;
            this._gioitinh      = gioitinh;
            this._noisinh       = noisinh;
            this._diachi        = diachi;

        }
        #endregion 
        #region Properties
        public String Ho
        {
            get { return _ho; }
            set { _ho = value; }
        }
        public String Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public String CMND
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }


        public DateTime NgaySinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }


        public Boolean GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }


        public String NoiSinh
        {
            get { return _noisinh; }
            set { _noisinh = value; }
        }


        public String DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        #endregion

    }
}
