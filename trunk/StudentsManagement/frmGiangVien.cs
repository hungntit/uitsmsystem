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
    public partial class frmGiangVien : Form
    {

        tblMonhocServices monhocservices;
        tblKhoaServices khoaServices ;
        tblGiangDayServices giangdayServices;
        tblGiangVienServices giangvienServices;
        public frmGiangVien()
        {
            InitializeComponent();
             monhocservices = new tblMonhocServices();
             khoaServices = new tblKhoaServices();
             giangdayServices = new tblGiangDayServices();
             giangvienServices = new tblGiangVienServices();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            

            List<tblMonhoc> monhocs =   monhocservices.getAllMonHoc();
            tblMonhoc[] arrMonhoc   =   monhocs.ToArray();
            

            List<tblKhoa> lstKhoa   =   khoaServices.getAllKhoa();
            tblKhoa[] arrKhoa   =   lstKhoa.ToArray();

            for(int i = 0;i<monhocs.Count;i++)
            {
                ListViewItem lvItm = new ListViewItem();
                lvItm.Text = arrMonhoc[i].MaMon;
                lvItm.SubItems.Add(arrMonhoc[i].TenMon);
               // lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                lstDanhSachChuaChon.Items.Add(lvItm);
            }
            for(int i = 0;i<lstKhoa.Count;i++)
            {
                cmbKhoa.Items.Add(arrKhoa[i].TenKhoa);
            }
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            
            
            foreach (ListViewItem item in lstDanhSachChuaChon.SelectedItems)
            {
                lstDanhSachChuaChon.Items.Remove(item);
                lstDanhSachChon.Items.Add(item);
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstDanhSachChon.SelectedItems)
            {
                lstDanhSachChon.Items.Remove(item);
                lstDanhSachChuaChon.Items.Add(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblGiangVien giangvien = new tblGiangVien();
            giangvien.MaGiangVien = txtMGV.Text.Trim();
            giangvien.Ho = txtHo.Text.Trim();
            giangvien.Ten = txtTen.Text.Trim();
            giangvien.GioiTinh = (cmbGioiTinh.SelectedIndex == 0);
            giangvien.HocVi = cmbHocVi.SelectedText;
            giangvien.MaKhoa = cmbKhoa.SelectedText.Trim();
            giangvien.NgaySinh = dtNgaySinh.Value;
            giangvien.NoiSinh = txtNoiSinh.Text.Trim();
            giangvien.CMND = txtCmnd.Text.Trim();
            giangvien.DiaChi = txtDiaChi.Text.Trim();
            giangvienServices.insertTblGiangVien(giangvien);
            foreach (ListViewItem lvItem in lstDanhSachChon.SelectedItems)
            {
                tblMonhoc monhoc    =   new tblMonhoc();
                monhoc.MaMon    =   lvItem.Text.Trim();
                giangdayServices.insertTblGiangDay(giangvien, monhoc);
            }
            
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
