using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using BussinessEntities;

namespace StudentsManagement
{
    public partial class frmDanhSachLopDangKy : Form
    {

        private int countdong;
        private int begin;
        private int count;
        private tblLopDKServices lopdkServies;
        private tblGiangVienServices giangvienServies;
        private tblMonhocServices monhocServies;

        public frmDanhSachLopDangKy()
        {
            InitializeComponent();
            countdong = 2;
            begin = 0;
            count = 0;
            lopdkServies = new tblLopDKServices();
            giangvienServies = new tblGiangVienServices();
            monhocServies = new tblMonhocServices();
        }

        private void fillListView(List<tblLopDangKy> lstLopDK)
        {
            lstDanhSachLopDangKy.Items.Clear();
            tblLopDangKy[] arrLopDK = lstLopDK.ToArray();
            for (int i = 0; i < lstLopDK.Count; i++)
            {
                tblLopDangKy lop = arrLopDK[i];
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = "";
                lvItem.SubItems.Add(lop.MaLop+"");
                lvItem.SubItems.Add(lop.TenLop);
                tblMonhoc mon = monhocServies.getbyMaMonHoc(lop.MaMon);
                if (mon != null)
                {
                    lvItem.SubItems.Add(mon.TenMon);
                    lvItem.SubItems.Add(mon.TinchiLyThuyet + "");
                    lvItem.SubItems.Add(mon.TinchiThucHanh + "");
                }
                else
                {
                    lvItem.SubItems.Add("");
                    lvItem.SubItems.Add("");
                    lvItem.SubItems.Add("");
                }
                tblGiangVien gv = giangvienServies.getbyMaGV(lop.MaGiangVien);
                if (gv != null)
                {
                    lvItem.SubItems.Add(gv.Ho+" "+gv.Ten);
                }
                else
                {
                    lvItem.SubItems.Add("");
                }
                lvItem.SubItems.Add(lop.Thu + "");
                lvItem.SubItems.Add(lop.Ca + "");
                
                lstDanhSachLopDangKy.Items.Add(lvItem);
            }
            txtHienThi.Text = (begin + lstDanhSachLopDangKy.Items.Count) + "";
            txtTongSo.Text = (count) + "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLopDangKy lopDk = new frmLopDangKy();
            lopDk.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstDanhSachLopDangKy.SelectedItems.Count > 1)
            {
                MessageBox.Show("Chỉ được chọn một dòng để sửa");
                return;
            }
            if (lstDanhSachLopDangKy.SelectedItems.Count < 1)
            {
                MessageBox.Show("Chưa chọn dòng nào");
                return;
            }
            int malop = Int32.Parse(lstDanhSachLopDangKy.SelectedItems[0].SubItems[1].Text.Trim());
            
            frmLopDangKy lopDk = new frmLopDangKy(malop);
            lopDk.ShowDialog();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            btnTruoc.Enabled = true;
            btnSau.Enabled = true;
            begin = 0;
            count = lopdkServies.CountLopDK();
            countdong = 2;
            List<tblLopDangKy> lstLopDK = lopdkServies.getAllLopDK(begin, countdong);
            if (count <= countdong)
            {
                pnlDieuHuong.Visible = false;
            }
            else
            {
                pnlDieuHuong.Visible = true;
            }
            btnTruoc.Enabled = false;
            fillListView(lstLopDK);
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
            lstDanhSachLopDangKy.Items.Clear();
            List<tblLopDangKy> lstLopDK = lopdkServies.getAllLopDK(begin, countdong);

            fillListView(lstLopDK);
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
            lstDanhSachLopDangKy.Items.Clear();
            List<tblLopDangKy> lstLopDK = lopdkServies.getAllLopDK(begin, countdong);

            fillListView(lstLopDK);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            begin = begin + countdong;
            if (begin + countdong >= count)
                btnSau.Enabled = false;
            else
                btnSau.Enabled = true;


            if (begin < countdong)
                btnTruoc.Enabled = false;
            else
                btnTruoc.Enabled = true;
            lstDanhSachLopDangKy.Items.Clear();
            List<tblLopDangKy> lstLopDK = lopdkServies.getAllLopDK(begin, countdong);

            fillListView(lstLopDK);
            

        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            begin = count / countdong * countdong;
            if (begin + countdong >= count)
                btnSau.Enabled = false;
            else
                btnSau.Enabled = true;


            if (begin < countdong)
                btnTruoc.Enabled = false;
            else
                btnTruoc.Enabled = true;
            lstDanhSachLopDangKy.Items.Clear();
            List<tblLopDangKy> lstLopDK = lopdkServies.getAllLopDK(begin, countdong);

            fillListView(lstLopDK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (lstDanhSachLopDangKy.SelectedItems.Count < 1)
            {
                MessageBox.Show("Chưa chọn dòng nào");
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn xóa những trường dữ liệu này?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            for (int i = 0; i < lstDanhSachLopDangKy.CheckedIndices.Count; i++)
            {
                int malop = Int32.Parse(lstDanhSachLopDangKy.SelectedItems[i].SubItems[1].Text.Trim());
                lopdkServies.deleteTblLopDangKy(malop);
               
            }
            btnTruoc.Enabled = true;
            btnSau.Enabled = true;
            begin = 0;
            count = lopdkServies.CountLopDK();
            countdong = 2;
            List<tblLopDangKy> lstLopDK = lopdkServies.getAllLopDK(begin, countdong);
            if (count <= countdong)
            {
                pnlDieuHuong.Visible = false;
            }
            else
            {
                pnlDieuHuong.Visible = true;
            }
            btnTruoc.Enabled = false;
            fillListView(lstLopDK);
        }
    }
}
