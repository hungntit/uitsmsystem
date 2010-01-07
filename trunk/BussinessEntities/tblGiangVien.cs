using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    class tblGiangVien:tblPerson
    {
        #region FIELD
        private String _maGiangVien;
        private String _hocvi;
        private String _maKhoa;
       
        #endregion
        #region Constructors

        public tblGiangVien(String maGiangVien, String hocvi, String maKhoa, String hoGV, String tenGV, String cmnd, DateTime ngaysinh, Boolean gioitinh, String noisinh, String diachi)
            : base(hoGV, tenGV, cmnd, ngaysinh, gioitinh, noisinh, diachi)
        {
            this._maGiangVien = maGiangVien;
            this._hocvi = hocvi;
            this._maKhoa = maKhoa;
        }

        #endregion
        #region Properties
        public String MaGiangVien
        {
            get { return _maGiangVien; }
            set { _maGiangVien = value; }
        }


        public String MaKhoa
        {
            get { return _maKhoa; }
            set { _maKhoa = value; }
        }


        public String HocVi
        {
            get { return _hocvi; }
            set { _hocvi = value; }
        }
        #endregion
    }
}
