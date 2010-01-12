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
        List<tblSinhVien> lstSinhVien;

        public frmDanhSachSinhVien()
        {
            InitializeComponent();
            sinhVienServices = new tblSinhVienServices();
            khoaServices = new tblKhoaServices();
        }

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            lstSinhVien = sinhVienServices.getAllSinhVien();
            tblSinhVien[] arrSinhVien = lstSinhVien.ToArray();

            for (int i = 0; i < lstSinhVien.Count; i++)
            {
                ListViewItem lvItm = new ListViewItem();
                lvItm.Text = arrSinhVien[i].MaSV;
                lvItm.SubItems.Add(arrSinhVien[i].MaSV);
                lvItm.SubItems.Add(arrSinhVien[i].Ho);
                lvItm.SubItems.Add(arrSinhVien[i].Ten);
                lvItm.SubItems.Add(arrSinhVien[i].GioiTinh.ToString());
                lvItm.SubItems.Add(arrSinhVien[i].NgaySinh.ToShortDateString());

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
    }
}
