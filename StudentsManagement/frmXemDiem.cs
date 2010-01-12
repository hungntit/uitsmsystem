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
    public partial class frmXemDiem : Form
    {
        tblBangDiemServices bangDiemServices;
        tblLopDKServices lopDKServices;
        tblMonhocServices monHocServices;
        tblSinhVienServices sinhVienServices;
        tblPhieuDangKyServices phieuDKServices;
        public frmXemDiem()
        {
            InitializeComponent();
            bangDiemServices = new tblBangDiemServices();
            lopDKServices = new tblLopDKServices();
            monHocServices = new tblMonhocServices();
            sinhVienServices = new tblSinhVienServices();
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
