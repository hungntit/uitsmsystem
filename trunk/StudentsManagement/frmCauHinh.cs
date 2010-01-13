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
    public partial class frmCauHinh : Form
    {
        private tblKhoaServices khoaServices;
        private tblHocKyServices hockyServices;
        private tblPhongServices phongServices;
        private tblLopQuanLyServices lopQLServies;
        private tblKhoa[] arrKhoa;
        private tblLopQuanLy[] arrLopQL;
        private tblPhong[] arrPhong;
        public frmCauHinh()
        {
            InitializeComponent();
            khoaServices = new tblKhoaServices();
            hockyServices = new tblHocKyServices();
            phongServices = new tblPhongServices();
            lopQLServies = new tblLopQuanLyServices();
        }

        private void btnTaoKhoa_Click(object sender, EventArgs e)
        {
            tblKhoa khoa = new tblKhoa(txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim());
            khoaServices.insertTblKhoa(khoa);
        }

        private void btnTaoLQL_Click(object sender, EventArgs e)
        {
            if (cmbTenKhoaLQL.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn khoa để thêm lớp");
                return;
            }
            tblLopQuanLy lopql = new tblLopQuanLy(135, arrKhoa[cmbTenKhoaLQL.SelectedIndex].MaKhoa, txtTenLopLQL.Text);
            lopQLServies.insertTblLopQuanLy(lopql);
        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            arrKhoa = khoaServices.getAllKhoa().ToArray();
            for (int i = 0; i < arrKhoa.Length; i++)
            {
                cmbTenKhoaLQL.Items.Add(arrKhoa[i].TenKhoa);
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems.Add(arrKhoa[i].MaKhoa);
                lvItem.SubItems.Add(arrKhoa[i].TenKhoa);
                lstDanhSachKhoa.Items.Add(lvItem);
            }
            arrLopQL = lopQLServies.getAllLopQuanLy().ToArray();
            for (int i = 0; i < arrLopQL.Length; i++)
            {
                
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems.Add(arrLopQL[i].TenLopQuanLy);
                tblKhoa khoa = khoaServices.getbyMaKhoa(arrLopQL[i].MaKhoa);

                lvItem.SubItems.Add(khoa.TenKhoa);
                lstDanhsachLQL.Items.Add(lvItem);
            }

            arrPhong = phongServices.getAllPhong().ToArray();
            for (int i = 0; i < arrPhong.Length; i++)
            {

                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems.Add(arrPhong[i].TenPhong);
                lstDanhSachPhong.Items.Add(lvItem);

            }
        }

        private void btnTaoPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
