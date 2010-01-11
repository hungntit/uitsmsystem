using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentsManagement
{
    public partial class frmDanhSachSinhVien : Form
    {
        public frmDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.panel6.Enabled = true;
            this.panel5.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.panel6.Enabled = false;
            this.panel5.Enabled = true;
        }
    }
}
