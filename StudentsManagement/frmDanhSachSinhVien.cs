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
    public partial class frmDanhSachSinhVien : Form
    {
        tblSinhVienServices sinhVienServices;
        tblKhoaServices khoaServices;
        tblLopQuanLyServices lopQuanLyServices;
        List<tblSinhVien> lstSinhVien;

        public frmDanhSachSinhVien()
        {
            InitializeComponent();
            sinhVienServices = new tblSinhVienServices();
            khoaServices = new tblKhoaServices();
            lopQuanLyServices = new tblLopQuanLyServices();
        }

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            lstSinhVien = sinhVienServices.getAllSinhVien();
            tblSinhVien[] arrSinhVien = lstSinhVien.ToArray();

            for (int i = 0; i < lstSinhVien.Count; i++)
            {
                ListViewItem lvItm = new ListViewItem();
                lvItm.Text = arrSinhVien[i].MaSV;
                lvItm.SubItems.Add(arrSinhVien[i].Ho);
                lvItm.SubItems.Add(arrSinhVien[i].Ten);
                if (!arrSinhVien[i].GioiTinh)
                    lvItm.SubItems.Add("Nam");
                else
                    lvItm.SubItems.Add("Nữ");
                lvItm.SubItems.Add(arrSinhVien[i].NgaySinh.ToShortDateString());
                tblLopQuanLy lopQuanLy = lopQuanLyServices.getbyMaLopQuanLy(arrSinhVien[i].MaLopQuanLy);
                tblKhoa khoa = khoaServices.getbyMaKhoa(lopQuanLy.MaKhoa);
                lvItm.SubItems.Add(khoa.TenKhoa);
                lstDanhSachSinhVien.Items.Add(lvItm);
            }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnTimNangCao_Click(object sender, EventArgs e)
        {
            this.pnlTimCB.Enabled = false;
            this.pnlTimNC.Enabled = true;
        }

        private void btnTimCoBan_Click(object sender, EventArgs e)
        {
            this.pnlTimCB.Enabled = true;
            this.pnlTimNC.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmSinhVien frmNewSV = new frmSinhVien();
            frmNewSV.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstDanhSachSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu");
            }
            else
            {
                frmSinhVien frmEditSV = new frmSinhVien(lstDanhSachSinhVien.SelectedItems[0].Text,true);
                frmEditSV.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa những dòng này ?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem lvItem in lstDanhSachSinhVien.SelectedItems)
                {
                    String maSV = lvItem.Text.Trim();
                    sinhVienServices.deleteTblSinhVien(maSV);
                }
                this.Refresh();
            }
        }
    }
}
