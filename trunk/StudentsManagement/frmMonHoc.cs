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
    public partial class frmMonHoc : Form
    {
        tblMonTienQuyetServices montienquyetservice;
        tblMonhocServices monhocservices;
        tblMonhoc monhoc;
        int monHocId;
        String option = "";
        public frmMonHoc()
        {
            InitializeComponent();
            monhocservices = new tblMonhocServices();
            montienquyetservice = new tblMonTienQuyetServices();
            monhoc = new tblMonhoc();
        }
        //Receive argument from danhsachmonhoc
        public frmMonHoc(int monhocId, String OP)
        {
            InitializeComponent();
            option = OP;
            monHocId = monhocId;
            monhocservices = new tblMonhocServices();
            montienquyetservice = new tblMonTienQuyetServices();
            monhoc = new tblMonhoc();
        }

      
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (option == "INSERT")
            {
                List<tblMonhoc> monhocs = monhocservices.getAllMonHoc();
                tblMonhoc[] arrMonhoc = monhocs.ToArray();

                for (int i = 0; i < monhocs.Count; i++)
                {
                    ListViewItem lvItm = new ListViewItem();
                    lvItm.Text = arrMonhoc[i].MaMon;
                    lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                    // lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                    lstDanhSachChuaChon.Items.Add(lvItm);
                }
            }
            if (option == "VIEW" || option == "EDIT")
            {
                monhoc = monhocservices.getbyMaMonHoc(monHocId.ToString());
                txtMaMon.Text = monhoc.MaMon.ToString().Trim();
                txtTenMon.Text = monhoc.TenMon.ToString().Trim();
                txtTinChiLT.Text = monhoc.TinchiLyThuyet.ToString().Trim();
                txtTinChiTH.Text = monhoc.TinchiThucHanh.ToString().Trim();
                cmbLoaiMon.SelectedText = monhoc.MaLoai.ToString().Trim();
                //Load tat ca cac mon hoc vao listview o duoi
                List<tblMonhoc> monhocs = monhocservices.getAllMonHocTienQuyet(monHocId.ToString());
                //tblMonhoc[] arrMonhoc = monhocservices.getAllMonHocTienQuyet(monHocId.ToString());
                //CHi hien thi nhung mon hoc tien quyet
                
                for (int i = 0; i < monhocs.Count(); i++)
                {
                    ListViewItem lvItm = new ListViewItem();
                    lvItm.Text = monhocs[i].MaMon;
                    lvItm.SubItems.Add(monhocs[i].TenMon);
                    // lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                    lstDanhSachChon.Items.Add(lvItm);
                }
                monhocs = monhocservices.getAllMonHoc();
                tblMonhoc[] arrMonhoc = monhocs.ToArray();

                for (int i = 0; i < monhocs.Count; i++)
                {
                    ListViewItem lvItm = new ListViewItem();
                    lvItm.Text = arrMonhoc[i].MaMon;
                    lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                    // lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                    lstDanhSachChuaChon.Items.Add(lvItm);
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (option == "INSERT")
            {
                tblMonhoc monhoc = new tblMonhoc();
                monhoc.MaLoai = Int32.Parse(cmbLoaiMon.SelectedIndex.ToString());
                //monhoc.MaLoai = 11;
                monhoc.MaMon = txtMaMon.Text.Trim();
                monhoc.TenMon = txtTenMon.Text.Trim();
                MessageBox.Show(this, monhoc.TenMon);
                monhoc.TinchiLyThuyet = Int32.Parse(txtTinChiLT.Text.Trim());
                monhoc.TinchiThucHanh = Int32.Parse(txtTinChiTH.Text.Trim());
                //giangvienServices.insertTblGiangVien(giangvien);
                monhocservices.insertTblMonHoc(monhoc);

                foreach (ListViewItem lvItem in lstDanhSachChon.SelectedItems)
                {
                    MessageBox.Show("vong for la" + lvItem.Text);
                    tblMonhoc monhoc1 = new tblMonhoc();
                    monhoc1 = monhocservices.getbyMaMonHoc(lvItem.Text.Trim());
                    //giangdayServices.insertTblGiangDay(giangvien, monhoc1);
                    montienquyetservice.insertTblMonTienQuyet(monhoc, monhoc1);
                }
            }
            if(option == "EDIT"){
                tblMonhoc monhoc = new tblMonhoc();
                monhoc = monhocservices.getbyMaMonHoc(txtMaMon.Text.Trim());
                monhoc.MaLoai = Int32.Parse(cmbLoaiMon.SelectedIndex.ToString());
                //monhoc.MaLoai = 11;
                monhoc.MaMon = txtMaMon.Text.Trim();
                monhoc.TenMon = txtTenMon.Text.Trim();
                MessageBox.Show(this, monhoc.TenMon);
                monhoc.TinchiLyThuyet = Int32.Parse(txtTinChiLT.Text.Trim());
                monhoc.TinchiThucHanh = Int32.Parse(txtTinChiTH.Text.Trim());
                //giangvienServices.insertTblGiangVien(giangvien);              
                monhocservices.updateTblMonHoc(monhoc);
                foreach (ListViewItem lvItem in lstDanhSachChon.SelectedItems)
                {
                    tblMonhoc monhoc1 = new tblMonhoc();
                    monhoc1 = monhocservices.getbyMaMonHoc(lvItem.Text.Trim());
                    //giangdayServices.insertTblGiangDay(giangvien, monhoc1);
                    montienquyetservice.insertTblMonTienQuyet(monhoc, monhoc1);
                }
            }
            this.Close();
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

        private void lstDanhSachChuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
