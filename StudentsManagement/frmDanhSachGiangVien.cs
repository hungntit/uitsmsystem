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
    public partial class frmDanhSachGiangVien : Form
    {
        private int countdong  ;
        private int begin;
        private int count;
        List<tblGiangVien> lstGV;
        private tblKhoaServices khoaServices;
        private tblGiangVienServices giangvienServices;
        public frmDanhSachGiangVien()
        {
            InitializeComponent();
            khoaServices = new tblKhoaServices();
            giangvienServices = new tblGiangVienServices();
            countdong = 2;
            begin = 0;
            count = 0;
            lstGV = new List<tblGiangVien>();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmGiangVien frmGV = new frmGiangVien();
            frmGV.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa những dòng này ?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem lvItem in lstDanhSachGiangVien.SelectedItems)
                {
                    String maGV = lvItem.Text.Trim();
                    giangvienServices.deleteTblGiangVien(maGV);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstDanhSachGiangVien.SelectedItems.Count > 1 )
            {
                MessageBox.Show("Chỉ được chọn một dòng để sửa");
                return;
            }
              if (lstDanhSachGiangVien.SelectedItems.Count < 1 )
            {
                MessageBox.Show("Chưa chọn dòng nào");
                return;
            }
              String magv = lstDanhSachGiangVien.SelectedItems[0].SubItems[1].Text.Trim();
            frmGiangVien frmGV = new frmGiangVien(magv);
            frmGV.ShowDialog();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
           
           btnTruoc.Enabled =   true;
           btnSau.Enabled = true;
            begin = 0;
            count = giangvienServices.CountGiangVien();
            countdong   =   2;
            List<tblGiangVien> lstGV = giangvienServices.getAllGiangVien(begin, countdong);
            if (count<=countdong)
            {
                pnlDieuHuong.Visible = false;
            }
            else
            {
                pnlDieuHuong.Visible = true;
            }
            btnTruoc.Enabled = false;
            fillListView(lstGV);
        }

        private void cmbDongTrenTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            countdong = Int32.Parse(cmbDongTrenTrang.SelectedText);
            begin = 0;
        }

        private void fillListView(List<tblGiangVien> lstGV)
        {
            lstDanhSachGiangVien.Items.Clear();
            tblGiangVien[] arrGV = lstGV.ToArray();
            for (int i = 0; i < lstGV.Count; i++)
            {
                tblGiangVien gv = arrGV[i];
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = "";
                lvItem.SubItems.Add(gv.MaGiangVien);
                lvItem.SubItems.Add(gv.Ho);
                lvItem.SubItems.Add(gv.Ten);
                lvItem.SubItems.Add(gv.GioiTinh?"Nam":"Nu");
                lvItem.SubItems.Add(gv.NgaySinh.Date.ToShortDateString());
                tblKhoa khoa = khoaServices.getbyMaKhoa(gv.MaKhoa);
                if(khoa!= null)
                    lvItem.SubItems.Add(khoa.TenKhoa);
                else
                    lvItem.SubItems.Add("");
                lstDanhSachGiangVien.Items.Add(lvItem);
            }
            txtHienThi.Text = (begin + lstDanhSachGiangVien.Items.Count) + "";
            txtTongSo.Text = (count) + "";
        }

        private void btnDau_Click(object sender, EventArgs e)
        {

            begin = 0;
            if (begin <= countdong)
                btnTruoc.Enabled = false;
            else
                btnTruoc.Enabled = true;

            if (begin + countdong >= count)
                btnSau.Enabled = false;
            else
                btnSau.Enabled = true;
            lstDanhSachGiangVien.Items.Clear();
            List<tblGiangVien> lstGV = giangvienServices.getAllGiangVien(begin, countdong);

            fillListView(lstGV);
                
            
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            begin = begin - countdong;
            if (begin <= countdong)
                btnTruoc.Enabled = false;
            else
                btnTruoc.Enabled = true;

            if (begin + countdong >= count)
                btnSau.Enabled = false;
            else
                btnSau.Enabled = true;
            lstDanhSachGiangVien.Items.Clear();
            List<tblGiangVien> lstGV = giangvienServices.getAllGiangVien(begin, countdong);

            fillListView(lstGV);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            begin = begin + countdong;
            if (begin +countdong >= count)
                btnSau.Enabled = false;
            else
                btnSau.Enabled = true;


            if (begin < countdong)
                btnTruoc.Enabled = false;
            else
                btnTruoc.Enabled = true;
            lstDanhSachGiangVien.Items.Clear();
            List<tblGiangVien> lstGV = giangvienServices.getAllGiangVien(begin,begin+ countdong);

            fillListView(lstGV);
            


        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            begin = count/countdong *countdong;
            if (begin + countdong >= count)
                btnSau.Enabled = false;
            else
                btnSau.Enabled = true;


            if (begin < countdong)
                btnTruoc.Enabled = false;
            else
                btnTruoc.Enabled = true;
            lstDanhSachGiangVien.Items.Clear();
            List<tblGiangVien> lstGV = giangvienServices.getAllGiangVien(begin, begin + countdong);

            fillListView(lstGV);
            
        }

        

    }
}
