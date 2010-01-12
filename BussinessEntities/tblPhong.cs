using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessEntities
{
   public class tblPhong
    {
        int _maPhong;
        public static String sTABLE_NAME = "PHONG_HOC";

        public static String sMA_PHONG = "MA_PHONG";
        public static String sTEN_PHONG = "TEN_PHONG";
        public int MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
        String _tenPhong;

        public String TenPhong
        {
            get { return _tenPhong; }
            set { _tenPhong = value; }
        }

        public tblPhong()
        {
        }
        public tblPhong(int maphong, String tenphong)
        {
            _maPhong = maphong;
            _tenPhong = tenphong;
        }
    }
}
