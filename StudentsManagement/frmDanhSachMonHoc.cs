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
    public partial class frmDanhSachMonHoc : Form
    {
        tblMonhocServices monhocservices;
        public frmDanhSachMonHoc()
        {
            InitializeComponent();
            monhocservices = new tblMonhocServices();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
        }

        private void frmDanhSachMonHoc_Load(object sender, EventArgs e)
        {
            List<tblMonhoc> monhocs = monhocservices.getAllMonHoc();
            tblMonhoc[] arrMonhoc = monhocs.ToArray();


            //List<tblKhoa> lstKhoa = khoaServices.getAllKhoa();
            //tblKhoa[] arrKhoa = lstKhoa.ToArray();

            for (int i = 0; i < monhocs.Count; i++)
            {
                ListViewItem lvItm = new ListViewItem();
                lvItm.Text = arrMonhoc[i].MaMon;
                //lvItm.SubItems.Add((i + 1).ToString());
                //lvItm.SubItems.Add(arrMonhoc[i].MaMon);
                lvItm.SubItems.Add(arrMonhoc[i].TenMon);
                lvItm.SubItems.Add(arrMonhoc[i].MaLoai.ToString());
                lvItm.SubItems.Add(arrMonhoc[i].TinchiLyThuyet.ToString());
                lvItm.SubItems.Add(arrMonhoc[i].TinchiThucHanh.ToString());
                lstDanhSachMonHoc.Items.Add(lvItm);
            }
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {

            if (lstDanhSachMonHoc.SelectedItems.Count == 0)
                MessageBox.Show(this, "Ban phai chon mot mon hoc de xem");
            else
            {
                foreach (ListViewItem item in lstDanhSachMonHoc.SelectedItems)
                {
                  
                    frmMonHoc monhoc = new frmMonHoc(Int32.Parse(item.SubItems[0].Text), "VIEW");
                    monhoc.Show();
                }         
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmMonHoc monhoc = new frmMonHoc(0, "INSERT");
            monhoc.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstDanhSachMonHoc.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Ban phai chon mot mon hoc de xem");
            }
            else if (lstDanhSachMonHoc.SelectedItems.Count > 1)
            {
                MessageBox.Show(this, "Moi lan chi duoc sua mot mon hoc");
            }
            else
            {
                foreach (ListViewItem item in lstDanhSachMonHoc.SelectedItems)
                {

                    frmMonHoc monhoc = new frmMonHoc(Int32.Parse(item.SubItems[0].Text), "EDIT");
                    monhoc.Show();
                }   
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSachMonHoc.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Ban phai chon mot mon hoc de xoa");
            }
            else
            {
                foreach (ListViewItem item in lstDanhSachMonHoc.SelectedItems)
                {
                    monhocservices.deleteTblMonHoc(item.SubItems[0].Text.Trim());
                    //frmMonHoc monhoc = new frmMonHoc(Int32.Parse(item.SubItems[0].Text), "EDIT");
                    //monhoc.Show();
                }
            }
        }
    }
}
