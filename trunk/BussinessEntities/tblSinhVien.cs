using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessEntities
{
   public class tblSinhVien:tblPerson
    {
        #region Field
        private String _maSV;
        private String _maKhoa;
        private int _nienkhoa;
      

        #endregion
        #region Constructor
        
        public tblSinhVien(String maSV, String maKhoa, String hoSV, String tenSV, String cmnd, DateTime ngaysinh, Boolean gioitinh, String noisinh, String diachi, int nienkhoa):base(hoSV,tenSV,cmnd,ngaysinh,gioitinh,noisinh,diachi)
        {
            this._maSV          = maSV;
            this._maKhoa        = maKhoa;
            this._nienkhoa      = nienkhoa;
        }


        #endregion
        #region Properties

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
        public String MaKhoa
        {
            get
            {
                return _maKhoa;

            }
            set
            {
                _maKhoa = value;
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
