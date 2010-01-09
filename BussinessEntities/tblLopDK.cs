using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
  public  class tblLopDK
    {
       
        #region FIELD
        private String _maLop;
        private String _maMon;
        private String _maGiangVien;
        private String _maPhong;
        private String _tenLop;
        private DayOfWeek _thu;
        private int _ca;
        private int _sisoToithieu;
        private int _sisoToida;
        private String _ghichu;
        private DateTime _ngayBatdau;
        #endregion

        #region Constructor
        
        public tblLopDK(String maLop, String maMon, String maGiangVien, String maPhong, String tenLop, DayOfWeek thu, int ca, int sisoToithieu, int sisoToida, String ghichu, DateTime ngaybatdau)
        {
            this._maLop = maLop;
            this._maMon = maMon;
            this._maGiangVien = maGiangVien;
            this._maPhong = maPhong;
            this._tenLop = tenLop;
            this._thu = thu;
            this._ca = ca;
            this._sisoToithieu = sisoToithieu;
            this._sisoToida = sisoToida;
            this._ghichu = ghichu;
            this._ngayBatdau = ngaybatdau;
        }
        #endregion
        #region Properties
        public String MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        public String MaMon
        {
            get { return _maMon; }
            set { _maMon = value; }
        }
       

        public String MaGiangVien
        {
            get { return _maGiangVien; }
            set { _maGiangVien = value; }
        }
       

        public String MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public String TenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
        }

        public DayOfWeek Thu
        {
            get { return _thu; }
            set { _thu = value; }
        }

        public int Ca
        {
            get { return _ca; }
            set { _ca = value; }
        }
        

        public int SiSoToiThieu
        {
            get { return _sisoToithieu; }
            set { _sisoToithieu = value; }
        }
        

        public int SiSoToiDa
        {
            get { return _sisoToida; }
            set { _sisoToida = value; }
        }
       

        public String GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
        

        public DateTime NgayBatDau
        {
            get { return _ngayBatdau; }
            set { _ngayBatdau = value; }
        }

        #endregion
    }
}
