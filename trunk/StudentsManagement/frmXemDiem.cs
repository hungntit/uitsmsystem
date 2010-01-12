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
    public partial class frmXemDiem : Form
    {
        tblBangDiemServices bangDiemServices;
        tblLopDKServices lopDKServices;
        tblMonhocServices monHocServices;
        tblSinhVienServices sinhVienServices;
        tblPhieuDangKyServices phieuDKServices;

        public frmXemDiem()
        {
            InitializeComponent();
            bangDiemServices = new tblBangDiemServices();
            lopDKServices = new tblLopDKServices();
            monHocServices = new tblMonhocServices();
            sinhVienServices = new tblSinhVienServices();
            phieuDKServices = new tblPhieuDangKyServices();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            
            String MaSV = this.txtMSSV.Text.Trim();
            if (MaSV.Equals(""))
                MessageBox.Show("Bạn chưa nhập Mã sinh viên");
            else
            {
                tblSinhVien sinhVien = sinhVienServices.getbyMaSV(MaSV);
                if (sinhVien == null)
                    return;
                this.txtHoVaTen.Text = sinhVien.Ho + sinhVien.Ten;
                this.txtNgaySinh.Text = sinhVien.NgaySinh.ToShortDateString();
                int stt = 1;
                List<tblPhieuDangKy> lstPhieuDK = phieuDKServices.getAllPhieuDangKyByMaSinhVien(MaSV);
                foreach (tblPhieuDangKy phieuDK in lstPhieuDK)
                {
                    List<tblLopDangKy> lstLopDK = lopDKServices.getLopDangKyByMaPhieu(phieuDK.MaPhieuDK.ToString());
                    foreach (tblLopDangKy lopDK in lstLopDK)
                    {
                        tblMonhoc monHoc = monHocServices.getbyMaMonHoc(lopDK.MaMon);
                        float diem = bangDiemServices.getDiem(MaSV,lopDK.MaLop.ToString());

                        ListViewItem lvItm = new ListViewItem();
                        lvItm.Text = stt.ToString();
                        lvItm.SubItems.Add(monHoc.MaMon);
                        lvItm.SubItems.Add(monHoc.TenMon);
                        int tinchi = monHoc.TinchiLyThuyet + monHoc.TinchiThucHanh;
                        lvItm.SubItems.Add(tinchi.ToString());
                        lvItm.SubItems.Add(diem.ToString());
                        lstBangDiem.Items.Add(lvItm);
                    }
                }
            }
        }
    }
}
