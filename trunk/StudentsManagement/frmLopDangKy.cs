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
    public partial class frmLopDangKy : Form
    {

        private tblLopDKServices lopdkServies;
        private tblMonhocServices monhocServies;
        private tblGiangVienServices giangvienServies;
        private tblPhongServices phongServies;
        tblHocKyServices hockyServies;
        private tblMonhoc[] arrMonhoc;
        private tblGiangVien[] arrGV;
        private tblPhong[] arrPhong;
        public frmLopDangKy()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
                cmbNamhoc.Items.Add(i + 1990);
            lopdkServies = new tblLopDKServices();
            monhocServies = new tblMonhocServices();
            giangvienServies = new tblGiangVienServices();
            phongServies = new tblPhongServices();
            hockyServies = new tblHocKyServices();
        }


        public frmLopDangKy(int malop)
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
                cmbNamhoc.Items.Add(i + 1990);
            lopdkServies = new tblLopDKServices();
            monhocServies = new tblMonhocServices();
            giangvienServies = new tblGiangVienServices();
            phongServies = new tblPhongServices();
            hockyServies = new tblHocKyServices();
            txtMaLop.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int malop = 0;
            try
            {
                 malop = Int32.Parse(txtMaLop.Text.Trim());
            }
            catch(Exception)
            {
                MessageBox.Show("Mã lớp là một số");
            }
            String tenlop = txtTenLop.Text.Trim();
            String maGV = arrGV[cmbGiangVien.SelectedIndex].MaGiangVien;
            String maMon    =   arrMonhoc[cmbTenMon.SelectedIndex].MaMon;

            int maPhong = 0;
            try
            {
                maPhong = arrPhong[cmbPhong.SelectedIndex].MaPhong;
            }
            catch (Exception)
            {

            }
            int maHK = hockyServies.getbyHocKy_Namhoc(Int32.Parse(cmbHocky.Text), Int32.Parse(cmbNamhoc.Text)).MaHK;
            int thu = 8;
            try
            {
             thu = Int32.Parse(cmbThu.Text);
            }
            catch(Exception)
            {
                thu =8;
            }
            int ca = (int)numCa.Value;
            DateTime ngaymo = dtNgayMoLop.Value.Date;
            
            tblLopDangKy lopdk = new tblLopDangKy(malop, maGV, maPhong, maMon, tenlop, (DayOfWeek)thu, ca, ngaymo, maHK);
            if (txtMaLop.Enabled)
                lopdkServies.insertTblLopDangKy(lopdk);
            else
                lopdkServies.updateTblLopDangKy(lopdk);
            this.Close();
        }

        private void frmLopDangKy_Load(object sender, EventArgs e)
        {
            arrPhong = phongServies.getAllPhong().ToArray();
            for (int i = 0; i < arrPhong.Length; i++)
                cmbPhong.Items.Add(arrPhong[i].TenPhong);

            cmbTenMon.Items.Clear();
            cmbGiangVien.Items.Clear();
           arrMonhoc = monhocServies.getAllMonHoc().ToArray();
           for (int i = 0; i < arrMonhoc.Length; i++)
               cmbTenMon.Items.Add(arrMonhoc[i].TenMon);
           if (arrMonhoc.Length > 0)
               cmbTenMon.SelectedIndex = 0;
           arrGV = giangvienServies.getGiangVienByMaMonHoc(arrMonhoc[cmbTenMon.SelectedIndex].MaMon).ToArray();
           for (int i = 0; i < arrGV.Length; i++)
               cmbGiangVien.Items.Add(arrGV[i].Ten);


        }


    }
}
