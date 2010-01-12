using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessEntities;
using BusinessLogicLayer;
namespace StudentsManagement
{
    public partial class frmNhapDiem : Form
    {
        tblLopDKServices lopDKServices;
        tblChiTietDangKyServices chiTietDKServices;
        tblSinhVienServices sinhVienServices;
        tblPhieuDangKyServices phieuDKServices;

        public frmNhapDiem()
        {
            InitializeComponent();
            lopDKServices = new tblLopDKServices();
            chiTietDKServices = new tblChiTietDangKyServices();
            sinhVienServices = new tblSinhVienServices();
            phieuDKServices = new tblPhieuDangKyServices();
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
         
        }
    }
}
