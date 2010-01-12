using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    public class tblGiangVien:tblPerson
    {
        #region FIELD
        private String _maGiangVien;
        private String _hocvi;
        private String _maKhoa;
        public static String sTABLE_NAME = "GIANG_VIEN";
        public static String sMA_GIANG_VIEN = "MA_GIANG_VIEN";
        public static String sHOC_VI = "HOC_VI";
        public static String sMA_KHOA = "MA_KHOA";
        public static String sHO_GIANG_VIEN = "HO_GIANG_VIEN";
        public static String sTEN_GIANG_VIEN = "TEN_GIANG_VIEN";


        #endregion
        #region Constructors

        public tblGiangVien()
        {
        }
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
