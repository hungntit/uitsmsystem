﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentsManagement
{
    public partial class frmLopDangKy : Form
    {

        public frmLopDangKy()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
                cmbNamhoc.Items.Add(i + 1990);

        }

        
    }
}