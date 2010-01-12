namespace StudentsManagement
{
    partial class frmGiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbThongTinGiangVien = new System.Windows.Forms.GroupBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.cmbHocVi = new System.Windows.Forms.ComboBox();
            this.lblHocVi = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblMGV = new System.Windows.Forms.Label();
            this.txtMGV = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.pnlMidle = new System.Windows.Forms.Panel();
            this.grbDanhSachMon = new System.Windows.Forms.GroupBox();
            this.lblDanhSachChuaChon = new System.Windows.Forms.Label();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.lstDanhSachChuaChon = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.lstDanhSachChon = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblChiTietGiangVien = new System.Windows.Forms.Label();
            this.grbThongTinGiangVien.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMidle.SuspendLayout();
            this.grbDanhSachMon.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinGiangVien
            // 
            this.grbThongTinGiangVien.Controls.Add(this.txtNoiSinh);
            this.grbThongTinGiangVien.Controls.Add(this.lblNoiSinh);
            this.grbThongTinGiangVien.Controls.Add(this.cmbHocVi);
            this.grbThongTinGiangVien.Controls.Add(this.lblHocVi);
            this.grbThongTinGiangVien.Controls.Add(this.cmbKhoa);
            this.grbThongTinGiangVien.Controls.Add(this.lblKhoa);
            this.grbThongTinGiangVien.Controls.Add(this.lblMGV);
            this.grbThongTinGiangVien.Controls.Add(this.txtMGV);
            this.grbThongTinGiangVien.Controls.Add(this.dtNgaySinh);
            this.grbThongTinGiangVien.Controls.Add(this.lblNgaySinh);
            this.grbThongTinGiangVien.Controls.Add(this.cmbGioiTinh);
            this.grbThongTinGiangVien.Controls.Add(this.lblGioiTinh);
            this.grbThongTinGiangVien.Controls.Add(this.lblCmnd);
            this.grbThongTinGiangVien.Controls.Add(this.txtCmnd);
            this.grbThongTinGiangVien.Controls.Add(this.lblTen);
            this.grbThongTinGiangVien.Controls.Add(this.txtTen);
            this.grbThongTinGiangVien.Controls.Add(this.lblHo);
            this.grbThongTinGiangVien.Controls.Add(this.txtHo);
            this.grbThongTinGiangVien.Location = new System.Drawing.Point(10, 5);
            this.grbThongTinGiangVien.Name = "grbThongTinGiangVien";
            this.grbThongTinGiangVien.Size = new System.Drawing.Size(935, 176);
            this.grbThongTinGiangVien.TabIndex = 3;
            this.grbThongTinGiangVien.TabStop = false;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(357, 138);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(124, 20);
            this.txtNoiSinh.TabIndex = 26;
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.AutoSize = true;
            this.lblNoiSinh.Location = new System.Drawing.Point(300, 145);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(51, 13);
            this.lblNoiSinh.TabIndex = 25;
            this.lblNoiSinh.Text = "Nơi sinh :";
            // 
            // cmbHocVi
            // 
            this.cmbHocVi.FormattingEnabled = true;
            this.cmbHocVi.Items.AddRange(new object[] {
            "Cử nhân",
            "Thạc sĩ",
            "Tiến sĩ"});
            this.cmbHocVi.Location = new System.Drawing.Point(592, 57);
            this.cmbHocVi.Name = "cmbHocVi";
            this.cmbHocVi.Size = new System.Drawing.Size(124, 21);
            this.cmbHocVi.TabIndex = 22;
            // 
            // lblHocVi
            // 
            this.lblHocVi.AutoSize = true;
            this.lblHocVi.Location = new System.Drawing.Point(533, 64);
            this.lblHocVi.Name = "lblHocVi";
            this.lblHocVi.Size = new System.Drawing.Size(44, 13);
            this.lblHocVi.TabIndex = 21;
            this.lblHocVi.Text = "Học vị :";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(357, 19);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(358, 21);
            this.cmbKhoa.TabIndex = 20;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(313, 26);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 13);
            this.lblKhoa.TabIndex = 19;
            this.lblKhoa.Text = "Khoa :";
            // 
            // lblMGV
            // 
            this.lblMGV.AutoSize = true;
            this.lblMGV.Location = new System.Drawing.Point(36, 30);
            this.lblMGV.Name = "lblMGV";
            this.lblMGV.Size = new System.Drawing.Size(37, 13);
            this.lblMGV.TabIndex = 17;
            this.lblMGV.Text = "MGV :";
            // 
            // txtMGV
            // 
            this.txtMGV.Location = new System.Drawing.Point(81, 23);
            this.txtMGV.Name = "txtMGV";
            this.txtMGV.Size = new System.Drawing.Size(165, 20);
            this.txtMGV.TabIndex = 18;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd-M-yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(81, 138);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtNgaySinh.RightToLeftLayout = true;
            this.dtNgaySinh.Size = new System.Drawing.Size(90, 20);
            this.dtNgaySinh.TabIndex = 14;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(14, 145);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(60, 13);
            this.lblNgaySinh.TabIndex = 13;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(357, 98);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(81, 21);
            this.cmbGioiTinh.TabIndex = 12;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(298, 105);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(53, 13);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Location = new System.Drawing.Point(35, 106);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(40, 13);
            this.lblCmnd.TabIndex = 6;
            this.lblCmnd.Text = "Cmnd :";
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(79, 99);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(167, 20);
            this.txtCmnd.TabIndex = 7;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(319, 68);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(32, 13);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(357, 61);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(124, 20);
            this.txtTen.TabIndex = 5;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(46, 68);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(27, 13);
            this.lblHo.TabIndex = 2;
            this.lblHo.Text = "Họ :";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(79, 61);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(167, 20);
            this.txtHo.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.btnTroVe);
            this.pnlBottom.Location = new System.Drawing.Point(13, 497);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(959, 53);
            this.pnlBottom.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(773, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(869, 16);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 0;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // pnlMidle
            // 
            this.pnlMidle.Controls.Add(this.grbDanhSachMon);
            this.pnlMidle.Controls.Add(this.grbThongTinGiangVien);
            this.pnlMidle.Location = new System.Drawing.Point(12, 62);
            this.pnlMidle.Name = "pnlMidle";
            this.pnlMidle.Size = new System.Drawing.Size(960, 429);
            this.pnlMidle.TabIndex = 4;
            // 
            // grbDanhSachMon
            // 
            this.grbDanhSachMon.Controls.Add(this.lblDanhSachChuaChon);
            this.grbDanhSachMon.Controls.Add(this.lblDanhSachChon);
            this.grbDanhSachMon.Controls.Add(this.lstDanhSachChuaChon);
            this.grbDanhSachMon.Controls.Add(this.btnChon);
            this.grbDanhSachMon.Controls.Add(this.btnBoChon);
            this.grbDanhSachMon.Controls.Add(this.lstDanhSachChon);
            this.grbDanhSachMon.Location = new System.Drawing.Point(10, 187);
            this.grbDanhSachMon.Name = "grbDanhSachMon";
            this.grbDanhSachMon.Size = new System.Drawing.Size(935, 239);
            this.grbDanhSachMon.TabIndex = 4;
            this.grbDanhSachMon.TabStop = false;
            this.grbDanhSachMon.Text = "Danh sách môn học giảng dạy";
            // 
            // lblDanhSachChuaChon
            // 
            this.lblDanhSachChuaChon.AutoSize = true;
            this.lblDanhSachChuaChon.Location = new System.Drawing.Point(515, 27);
            this.lblDanhSachChuaChon.Name = "lblDanhSachChuaChon";
            this.lblDanhSachChuaChon.Size = new System.Drawing.Size(113, 13);
            this.lblDanhSachChuaChon.TabIndex = 6;
            this.lblDanhSachChuaChon.Text = "Danh sách chưa chọn";
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.Location = new System.Drawing.Point(14, 27);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(86, 13);
            this.lblDanhSachChon.TabIndex = 5;
            this.lblDanhSachChon.Text = "Danh sách chọn";
            // 
            // lstDanhSachChuaChon
            // 
            this.lstDanhSachChuaChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstDanhSachChuaChon.Location = new System.Drawing.Point(518, 47);
            this.lstDanhSachChuaChon.Name = "lstDanhSachChuaChon";
            this.lstDanhSachChuaChon.Size = new System.Drawing.Size(402, 186);
            this.lstDanhSachChuaChon.TabIndex = 4;
            this.lstDanhSachChuaChon.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachChuaChon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã môn";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên môn";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Loại";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(432, 140);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "<<";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(432, 111);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(75, 23);
            this.btnBoChon.TabIndex = 2;
            this.btnBoChon.Text = ">>";
            this.btnBoChon.UseVisualStyleBackColor = true;
            // 
            // lstDanhSachChon
            // 
            this.lstDanhSachChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstDanhSachChon.Location = new System.Drawing.Point(17, 47);
            this.lstDanhSachChon.Name = "lstDanhSachChon";
            this.lstDanhSachChon.Size = new System.Drawing.Size(402, 186);
            this.lstDanhSachChon.TabIndex = 0;
            this.lstDanhSachChon.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachChon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã môn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên môn";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại";
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.lblChiTietGiangVien);
            this.pnlHead.Location = new System.Drawing.Point(12, 12);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(961, 38);
            this.pnlHead.TabIndex = 3;
            // 
            // lblChiTietGiangVien
            // 
            this.lblChiTietGiangVien.AutoSize = true;
            this.lblChiTietGiangVien.Location = new System.Drawing.Point(7, 12);
            this.lblChiTietGiangVien.Name = "lblChiTietGiangVien";
            this.lblChiTietGiangVien.Size = new System.Drawing.Size(96, 13);
            this.lblChiTietGiangVien.TabIndex = 0;
            this.lblChiTietGiangVien.Text = "Chi tiết Giảng viên ";
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMidle);
            this.Controls.Add(this.pnlHead);
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.grbThongTinGiangVien.ResumeLayout(false);
            this.grbThongTinGiangVien.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlMidle.ResumeLayout(false);
            this.grbDanhSachMon.ResumeLayout(false);
            this.grbDanhSachMon.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinGiangVien;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Panel pnlMidle;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblChiTietGiangVien;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblMGV;
        private System.Windows.Forms.TextBox txtMGV;
        private System.Windows.Forms.ComboBox cmbHocVi;
        private System.Windows.Forms.Label lblHocVi;
        private System.Windows.Forms.GroupBox grbDanhSachMon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.ListView lstDanhSachChon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstDanhSachChuaChon;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblDanhSachChuaChon;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label lblNoiSinh;
    }
}