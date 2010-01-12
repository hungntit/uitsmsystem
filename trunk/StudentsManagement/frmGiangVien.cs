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
        tblKhoaServices khoaServices;
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
        public void loadInfoGV(String magv)
        {
            txtMGV.Text = magv;
            tblGiangVien gv= giangvienServices.getbyMaGV(magv);
            this.txtCmnd.Text = gv.CMND;
            txtDiaChi.Text = gv.DiaChi;
            txtHo.Text = gv.Ho;
            txtNoiSinh.Text = gv.NoiSinh;
            txtTen.Text = gv.Ten;
            cmbGioiTinh.SelectedIndex = (gv.GioiTinh ? 0 : 1);
            cmbHocVi.SelectedText = gv.HocVi;
            tblKhoa khoa    =   khoaServices.getbyMaKhoa(gv.MaKhoa);
            if (khoa != null)
                cmbKhoa.SelectedText = khoa.TenKhoa;
           
        }
        public frmGiangVien(String _maGV)
        {
            
            InitializeComponent();
            if (_maGV == null || _maGV.Trim().Equals(""))
            {
                txtMGV.Enabled = true;
                
            }
            else
            {
                txtMGV.Enabled = false;
            }

            monhocservices = new tblMonhocServices();
            khoaServices = new tblKhoaServices();
            giangdayServices = new tblGiangDayServices();
            giangvienServices = new tblGiangVienServices();
            loadInfoGV(_maGV);
        }
        private void frmGiangVien_Load(object sender, EventArgs e)
        {


            List<tblMonhoc> monhocs = monhocservices.getAllMonHoc();
            tblMonhoc[] arrMonhoc = monhocs.ToArray();


            List<tblKhoa> lstKhoa = khoaServices.getAllKhoa();
            tblKhoa[] arrKhoa = lstKhoa.ToArray();

            for (int i = 0; i < monhocs.Count; i++)
            {
                ListViewItem lvItm = new ListViewItem();
                lvItm.Text = arrMonhoc[i].MaMon;
                lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                // lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                lstDanhSachChuaChon.Items.Add(lvItm);
            }
            for (int i = 0; i < lstKhoa.Count; i++)
            {
                cmbKhoa.Items.Add(arrKhoa[i].TenKhoa);
            }
            if (!txtMGV.Enabled)
            {
                List<tblMonhoc> lstmonhocGV = monhocservices.getAllMonHocByMaGiangVien(txtMGV.Text.Trim());
                tblMonhoc[] arrMonhocGV = lstmonhocGV.ToArray();


                for (int i = 0; i < lstmonhocGV.Count; i++)
                {
                    foreach (ListViewItem lvitem in lstDanhSachChuaChon.Items)
                    {
                        if (lvitem.Text.Equals(arrMonhocGV[i].MaMon))
                        {
                            lstDanhSachChuaChon.Items.Remove(lvitem);
                            lstDanhSachChon.Items.Add(lvitem);
                        }
                    }
                }
                
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
            if(txtMGV.Enabled)
                 giangvienServices.insertTblGiangVien(giangvien);
            else
            {
                giangvienServices.updateTblGiangVien(giangvien);
                giangdayServices.deleteTblGiangDay(txtMGV.Text.Trim());
            }
            foreach (ListViewItem lvItem in lstDanhSachChon.SelectedItems)
            {
                tblMonhoc monhoc = new tblMonhoc();
                monhoc.MaMon = lvItem.Text.Trim();
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
