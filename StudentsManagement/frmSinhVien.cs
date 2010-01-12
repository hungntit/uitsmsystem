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
    public partial class frmSinhVien : Form
    {
        tblLopQuanLyServices lopQuanLyServices;
        tblKhoaServices khoaServices;
        tblSinhVienServices sinhVienServices;
        List<tblKhoa> lstKhoa; // khoa
        List<tblLopQuanLy> lstLopQuanLy; // lop quan ly

        Boolean isEdit = false;
        String msv = "";

        public frmSinhVien()
        {
            InitializeComponent();
            khoaServices = new tblKhoaServices();
            lopQuanLyServices = new tblLopQuanLyServices();
            sinhVienServices = new tblSinhVienServices();
        }

        public frmSinhVien(String msv , Boolean isEdit)
        {
            InitializeComponent();
            khoaServices = new tblKhoaServices();
            lopQuanLyServices = new tblLopQuanLyServices();
            sinhVienServices = new tblSinhVienServices();
            this.msv = msv;
            this.isEdit = isEdit;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            lstKhoa = khoaServices.getAllKhoa();
            tblKhoa[] arrKhoa = lstKhoa.ToArray();
            for (int i = 0; i < lstKhoa.Count; i++)
            {
                cmbKhoa.Items.Add(arrKhoa[i].TenKhoa);
            }

            if (isEdit)
            {
                tblSinhVien sinhvien = sinhVienServices.getbyMaSV(this.msv);
                tblLopQuanLy lopQuanLy = lopQuanLyServices.getbyMaLopQuanLy(sinhvien.MaLopQuanLy);
                tblKhoa khoa = khoaServices.getbyMaKhoa(lopQuanLy.MaKhoa);

                this.txtMSSV.Text = sinhvien.MaSV;
                this.txtCmnd.Text = sinhvien.CMND;
                this.txtHo.Text = sinhvien.Ho;
                this.txtTen.Text = sinhvien.Ten;
                this.txtNoiSinh.Text = sinhvien.NoiSinh;
                this.txtDiaChi.Text = sinhvien.DiaChi;
                this.dtNgaySinh.Text = sinhvien.NgaySinh.ToShortDateString();
                this.cmbKhoa.SelectedItem = khoa.TenKhoa;
                this.cmbLopQuanLy.SelectedItem = lopQuanLy.TenLopQuanLy;
                this.cmbNienKhoa.Text = sinhvien.NienKhoa.ToString();
                if (sinhvien.GioiTinh)
                    this.cmbGioiTinh.Text = "Nữ";
                else
                    this.cmbGioiTinh.Text = "Nam";
                this.txtMSSV.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLopQuanLy = lopQuanLyServices.getLopQuanLyByMaKhoa(lstKhoa.ToArray()[cmbKhoa.SelectedIndex].MaKhoa);
            tblLopQuanLy[] arrLopQuanLy = lstLopQuanLy.ToArray();
            cmbLopQuanLy.Items.Clear();
            for (int i = 0; i < lstLopQuanLy.Count; i++)
            {
                cmbLopQuanLy.Items.Add(arrLopQuanLy[i].TenLopQuanLy);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblSinhVien sinhvien = new tblSinhVien();
            sinhvien.MaSV = txtMSSV.Text.Trim();
            sinhvien.Ho = txtHo.Text.Trim();
            sinhvien.Ten = txtTen.Text.Trim();
            sinhvien.GioiTinh = (cmbGioiTinh.SelectedIndex == 0);
            sinhvien.MaLopQuanLy = lstLopQuanLy.ToArray()[cmbLopQuanLy.SelectedIndex].MaLopQuanLy;
            sinhvien.NgaySinh = dtNgaySinh.Value;
            sinhvien.NoiSinh = txtNoiSinh.Text.Trim();
            sinhvien.CMND = txtCmnd.Text.Trim();
            sinhvien.DiaChi = txtDiaChi.Text.Trim();
            sinhvien.NienKhoa = Int32.Parse(cmbNienKhoa.SelectedItem.ToString());
            if(isEdit)
                sinhVienServices.updateTblSinhVien(sinhvien);
            else
                sinhVienServices.insertTblSinhVien(sinhvien);
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
