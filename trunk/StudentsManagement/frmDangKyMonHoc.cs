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
    public partial class frmDangKyMonHoc : Form
    {
        private tblSinhVien sinhvien;
        private tblKhoa khoa;
        private tblLopQuanLy lopQL;
        private tblPhieuDangKy[] arrPhieuDK;
        private tblLopDangKy[] arrLopDK;
        private tblSinhVienServices sinhvienServices;
        private tblMonhocServices monhocServices;
        private tblLopDKServices lopDKServies;
        private tblGiangVienServices giangvienServies;
        private tblKhoaServices khoaServies;
        private tblLopQuanLyServices lopQLService;
        private tblPhieuDangKyServices phieuDKServies;
        private tblChiTietDangKyServices chitietdkServices;
        private tblLopDangKy[] alllopDk;
        public frmDangKyMonHoc()
        {
            InitializeComponent();
            sinhvienServices = new tblSinhVienServices();
            monhocServices = new tblMonhocServices();
            lopDKServies = new tblLopDKServices();
            giangvienServies = new tblGiangVienServices();
            khoaServies = new tblKhoaServices();
            lopQLService = new tblLopQuanLyServices();
            chitietdkServices = new tblChiTietDangKyServices();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
            sinhvien = sinhvienServices.getbyMaSV(txtMSSV.Text);
            if (sinhvien == null)
                return;
            txtHo.Text = sinhvien.Ho;
            txtTen.Text = sinhvien.Ten;
            lopQL   =   lopQLService.getbyMaLopQuanLy(sinhvien.MaLopQuanLy);
            if(lopQL!= null)
            {   
                txtLopQl.Text       =   lopQL.TenLopQuanLy;
                khoa = khoaServies.getbyMaKhoa(lopQL.MaKhoa);
                if (khoa != null)
                    txtKhoa.Text = khoa.TenKhoa;
            }
            txtNienKhoa.Text = sinhvien.NienKhoa + "";

            arrPhieuDK = phieuDKServies.getAllPhieuDangKyByMaSinhVien(sinhvien.MaSV).ToArray();
            List<tblLopDangKy> lstLopDK = new List<tblLopDangKy>();

            for (int i = 0; i < arrPhieuDK.Length; i++)
            {
               
                tblLopDangKy[] arlopDk = lopDKServies.getLopDangKyByMaPhieu(arrPhieuDK[i].MaPhieuDK).ToArray();
                for (int j = 0; j < arlopDk.Length; j++)
                {
                    lstLopDK.Add(arlopDk[j]);
                }
            }
            arrLopDK    =   lstLopDK.ToArray();
            for (int i = 0; i < arrLopDK.Length; i++)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems.Add(arrLopDK[i].MaLop+"");
                lvItem.SubItems.Add(arrLopDK[i].TenLop + "");
                tblMonhoc mon = monhocServices.getbyMaMonHoc(arrLopDK[i].MaMon);
                if (mon != null)
                {
                    lvItem.SubItems.Add(mon.TenMon + "");
                    lvItem.SubItems.Add(mon.TinchiLyThuyet + "");
                    lvItem.SubItems.Add(mon.TinchiThucHanh + "");
                }
                else
                {
                    lvItem.SubItems.Add("");
                    lvItem.SubItems.Add("");
                    lvItem.SubItems.Add("");
                }
                tblGiangVien giangvien = giangvienServies.getbyMaGV(arrLopDK[i].MaGiangVien);
                if(giangvien!=null)
                    lvItem.SubItems.Add(giangvien.Ho+" "+ giangvien.Ten + "");
                else
                    lvItem.SubItems.Add("");
                lvItem.SubItems.Add(arrLopDK[i].Thu + "");
                lvItem.SubItems.Add(arrLopDK[i].Ca + "");
                lvItem.SubItems.Add(arrLopDK[i].NgayMoLop + "");
                lvItem.Checked = true;
                lstDanhSachLopDangKy.Items.Add(lvItem);
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            

            foreach (ListViewItem lvItem in lstDanhSachLopDangKy.CheckedItems)
            {

                tblLopDangKy lopdk = lopDKServies.getbyMaLop(lvItem.SubItems[0].ToString());
                
                
            }
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            alllopDk = lopDKServies.getAllLopDK().ToArray();
            for (int i = 0; i < arrLopDK.Length; i++)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems.Add(alllopDk[i].MaLop + "");
                lvItem.SubItems.Add(alllopDk[i].TenLop + "");
                tblMonhoc mon = monhocServices.getbyMaMonHoc(alllopDk[i].MaMon);
                if (mon != null)
                {
                    lvItem.SubItems.Add(mon.TenMon + "");
                    lvItem.SubItems.Add(mon.TinchiLyThuyet + "");
                    lvItem.SubItems.Add(mon.TinchiThucHanh + "");
                }
                else
                {
                    lvItem.SubItems.Add("");
                    lvItem.SubItems.Add("");
                    lvItem.SubItems.Add("");
                }
                tblGiangVien giangvien = giangvienServies.getbyMaGV(alllopDk[i].MaGiangVien);
                if (giangvien != null)
                    lvItem.SubItems.Add(giangvien.Ho + " " + giangvien.Ten + "");
                else
                    lvItem.SubItems.Add("");
                lvItem.SubItems.Add(alllopDk[i].Thu + "");
                lvItem.SubItems.Add(alllopDk[i].Ca + "");
                lvItem.SubItems.Add(alllopDk[i].NgayMoLop + "");
                lvItem.Checked = false;
                lstDanhSachLopDangKy.Items.Add(lvItem);
            }
        }


    }
}
