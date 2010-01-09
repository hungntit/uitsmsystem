using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
    public class tblPhieuDangKy
    {
        private String _maPhieuDK;
        private DateTime _ngayCapnhat;
        private String _maSV;
        private DateTime _ngayDK;

        public tblPhieuDangKy(String maPhieuDk, String maSV, DateTime ngayDK, DateTime ngayCapNhat)
        {
            this._maPhieuDK = maPhieuDk;
            this._maSV = maSV;
            this._ngayDK = ngayDK;
            this._ngayCapnhat = ngayCapNhat;
        }

        public String MaPhieuDK
        {
            get { return _maPhieuDK; }
            set { _maPhieuDK = value; }
        }
        

        public String MaSV
        {
            get { return _maSV; }
            set { _maSV = value; }
        }
        
        public DateTime NgayDK
        {
            get { return _ngayDK; }
            set { _ngayDK = value; }
        }
      

        public DateTime NgayCapNhat
        {
            get { return _ngayCapnhat; }
            set { _ngayCapnhat = value; }
        }
        
    }
}
