namespace StudentsManagement
{
    partial class frmCauHinh
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
            this.grbDanhSachKhoa = new System.Windows.Forms.GroupBox();
            this.lstDanhSachKhoa = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.grbKhoa = new System.Windows.Forms.GroupBox();
            this.btnCapNhatKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoKhoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grbLopQuanLy = new System.Windows.Forms.GroupBox();
            this.btnCapNhatLQL = new System.Windows.Forms.Button();
            this.btnXoaLQL = new System.Windows.Forms.Button();
            this.btnTaoLQL = new System.Windows.Forms.Button();
            this.txtTenLopLQL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTenKhoaLQL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachLQL = new System.Windows.Forms.GroupBox();
            this.lstDanhsachLQL = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.grbPhong = new System.Windows.Forms.GroupBox();
            this.btnCapNhatPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnTaoPhong = new System.Windows.Forms.Button();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDanhSachPhong = new System.Windows.Forms.GroupBox();
            this.lstDanhSachPhong = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.grbHocKyHientai = new System.Windows.Forms.GroupBox();
            this.btnLuuHocKy = new System.Windows.Forms.Button();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.grbDanhSachKhoa.SuspendLayout();
            this.grbKhoa.SuspendLayout();
            this.grbLopQuanLy.SuspendLayout();
            this.grbDanhSachLQL.SuspendLayout();
            this.grbPhong.SuspendLayout();
            this.grbDanhSachPhong.SuspendLayout();
            this.grbHocKyHientai.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhSachKhoa
            // 
            this.grbDanhSachKhoa.Controls.Add(this.lstDanhSachKhoa);
            this.grbDanhSachKhoa.Location = new System.Drawing.Point(408, 0);
            this.grbDanhSachKhoa.Name = "grbDanhSachKhoa";
            this.grbDanhSachKhoa.Size = new System.Drawing.Size(564, 137);
            this.grbDanhSachKhoa.TabIndex = 7;
            this.grbDanhSachKhoa.TabStop = false;
            this.grbDanhSachKhoa.Text = "Danh sách khoa";
            // 
            // lstDanhSachKhoa
            // 
            this.lstDanhSachKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstDanhSachKhoa.Location = new System.Drawing.Point(6, 22);
            this.lstDanhSachKhoa.Name = "lstDanhSachKhoa";
            this.lstDanhSachKhoa.Size = new System.Drawing.Size(552, 109);
            this.lstDanhSachKhoa.TabIndex = 0;
            this.lstDanhSachKhoa.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachKhoa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chọn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã khoa";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên khoa";
            this.columnHeader3.Width = 261;
            // 
            // grbKhoa
            // 
            this.grbKhoa.Controls.Add(this.btnCapNhatKhoa);
            this.grbKhoa.Controls.Add(this.btnXoaKhoa);
            this.grbKhoa.Controls.Add(this.txtTenKhoa);
            this.grbKhoa.Controls.Add(this.txtMaKhoa);
            this.grbKhoa.Controls.Add(this.label2);
            this.grbKhoa.Controls.Add(this.btnTaoKhoa);
            this.grbKhoa.Controls.Add(this.label3);
            this.grbKhoa.Location = new System.Drawing.Point(21, 1);
            this.grbKhoa.Name = "grbKhoa";
            this.grbKhoa.Size = new System.Drawing.Size(347, 137);
            this.grbKhoa.TabIndex = 6;
            this.grbKhoa.TabStop = false;
            this.grbKhoa.Text = "Khoa";
            // 
            // btnCapNhatKhoa
            // 
            this.btnCapNhatKhoa.Location = new System.Drawing.Point(176, 108);
            this.btnCapNhatKhoa.Name = "btnCapNhatKhoa";
            this.btnCapNhatKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatKhoa.TabIndex = 7;
            this.btnCapNhatKhoa.Text = "Cập nhật";
            this.btnCapNhatKhoa.UseVisualStyleBackColor = true;
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(257, 108);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKhoa.TabIndex = 6;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(79, 49);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(262, 20);
            this.txtTenKhoa.TabIndex = 5;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(79, 19);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khoa :";
            // 
            // btnTaoKhoa
            // 
            this.btnTaoKhoa.Location = new System.Drawing.Point(95, 108);
            this.btnTaoKhoa.Name = "btnTaoKhoa";
            this.btnTaoKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTaoKhoa.TabIndex = 3;
            this.btnTaoKhoa.Text = "Tạo";
            this.btnTaoKhoa.UseVisualStyleBackColor = true;
            this.btnTaoKhoa.Click += new System.EventHandler(this.btnTaoKhoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khoa :";
            // 
            // grbLopQuanLy
            // 
            this.grbLopQuanLy.Controls.Add(this.btnCapNhatLQL);
            this.grbLopQuanLy.Controls.Add(this.btnXoaLQL);
            this.grbLopQuanLy.Controls.Add(this.btnTaoLQL);
            this.grbLopQuanLy.Controls.Add(this.txtTenLopLQL);
            this.grbLopQuanLy.Controls.Add(this.label4);
            this.grbLopQuanLy.Controls.Add(this.cmbTenKhoaLQL);
            this.grbLopQuanLy.Controls.Add(this.label1);
            this.grbLopQuanLy.Location = new System.Drawing.Point(21, 143);
            this.grbLopQuanLy.Name = "grbLopQuanLy";
            this.grbLopQuanLy.Size = new System.Drawing.Size(347, 137);
            this.grbLopQuanLy.TabIndex = 8;
            this.grbLopQuanLy.TabStop = false;
            this.grbLopQuanLy.Text = "Lớp quản lý";
            // 
            // btnCapNhatLQL
            // 
            this.btnCapNhatLQL.Location = new System.Drawing.Point(176, 108);
            this.btnCapNhatLQL.Name = "btnCapNhatLQL";
            this.btnCapNhatLQL.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatLQL.TabIndex = 10;
            this.btnCapNhatLQL.Text = "Cập nhật";
            this.btnCapNhatLQL.UseVisualStyleBackColor = true;
            // 
            // btnXoaLQL
            // 
            this.btnXoaLQL.Location = new System.Drawing.Point(257, 108);
            this.btnXoaLQL.Name = "btnXoaLQL";
            this.btnXoaLQL.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLQL.TabIndex = 9;
            this.btnXoaLQL.Text = "Xóa";
            this.btnXoaLQL.UseVisualStyleBackColor = true;
            // 
            // btnTaoLQL
            // 
            this.btnTaoLQL.Location = new System.Drawing.Point(95, 108);
            this.btnTaoLQL.Name = "btnTaoLQL";
            this.btnTaoLQL.Size = new System.Drawing.Size(75, 23);
            this.btnTaoLQL.TabIndex = 8;
            this.btnTaoLQL.Text = "Tạo";
            this.btnTaoLQL.UseVisualStyleBackColor = true;
            this.btnTaoLQL.Click += new System.EventHandler(this.btnTaoLQL_Click);
            // 
            // txtTenLopLQL
            // 
            this.txtTenLopLQL.Location = new System.Drawing.Point(79, 62);
            this.txtTenLopLQL.Name = "txtTenLopLQL";
            this.txtTenLopLQL.Size = new System.Drawing.Size(262, 20);
            this.txtTenLopLQL.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên lớp :";
            // 
            // cmbTenKhoaLQL
            // 
            this.cmbTenKhoaLQL.FormattingEnabled = true;
            this.cmbTenKhoaLQL.Location = new System.Drawing.Point(79, 21);
            this.cmbTenKhoaLQL.Name = "cmbTenKhoaLQL";
            this.cmbTenKhoaLQL.Size = new System.Drawing.Size(262, 21);
            this.cmbTenKhoaLQL.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Khoa :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbDanhSachLQL
            // 
            this.grbDanhSachLQL.Controls.Add(this.lstDanhsachLQL);
            this.grbDanhSachLQL.Location = new System.Drawing.Point(408, 142);
            this.grbDanhSachLQL.Name = "grbDanhSachLQL";
            this.grbDanhSachLQL.Size = new System.Drawing.Size(564, 137);
            this.grbDanhSachLQL.TabIndex = 9;
            this.grbDanhSachLQL.TabStop = false;
            this.grbDanhSachLQL.Text = "Danh sách lớp quản lý";
            // 
            // lstDanhsachLQL
            // 
            this.lstDanhsachLQL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstDanhsachLQL.Location = new System.Drawing.Point(6, 19);
            this.lstDanhsachLQL.Name = "lstDanhsachLQL";
            this.lstDanhsachLQL.Size = new System.Drawing.Size(552, 109);
            this.lstDanhsachLQL.TabIndex = 1;
            this.lstDanhsachLQL.UseCompatibleStateImageBehavior = false;
            this.lstDanhsachLQL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chọn";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên lớp quản lý";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên khoa";
            this.columnHeader6.Width = 84;
            // 
            // grbPhong
            // 
            this.grbPhong.Controls.Add(this.btnCapNhatPhong);
            this.grbPhong.Controls.Add(this.btnXoaPhong);
            this.grbPhong.Controls.Add(this.btnTaoPhong);
            this.grbPhong.Controls.Add(this.txtTenPhong);
            this.grbPhong.Controls.Add(this.label5);
            this.grbPhong.Location = new System.Drawing.Point(21, 286);
            this.grbPhong.Name = "grbPhong";
            this.grbPhong.Size = new System.Drawing.Size(347, 137);
            this.grbPhong.TabIndex = 10;
            this.grbPhong.TabStop = false;
            this.grbPhong.Text = "Phòng";
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.Location = new System.Drawing.Point(176, 99);
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatPhong.TabIndex = 11;
            this.btnCapNhatPhong.Text = "Cập nhật";
            this.btnCapNhatPhong.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(257, 99);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPhong.TabIndex = 10;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            // 
            // btnTaoPhong
            // 
            this.btnTaoPhong.Location = new System.Drawing.Point(95, 99);
            this.btnTaoPhong.Name = "btnTaoPhong";
            this.btnTaoPhong.Size = new System.Drawing.Size(75, 23);
            this.btnTaoPhong.TabIndex = 9;
            this.btnTaoPhong.Text = "Tạo";
            this.btnTaoPhong.UseVisualStyleBackColor = true;
            this.btnTaoPhong.Click += new System.EventHandler(this.btnTaoPhong_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(79, 26);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(262, 20);
            this.txtTenPhong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên phòng :";
            // 
            // grbDanhSachPhong
            // 
            this.grbDanhSachPhong.Controls.Add(this.lstDanhSachPhong);
            this.grbDanhSachPhong.Location = new System.Drawing.Point(408, 285);
            this.grbDanhSachPhong.Name = "grbDanhSachPhong";
            this.grbDanhSachPhong.Size = new System.Drawing.Size(564, 137);
            this.grbDanhSachPhong.TabIndex = 11;
            this.grbDanhSachPhong.TabStop = false;
            this.grbDanhSachPhong.Text = "Danh sách phòng";
            // 
            // lstDanhSachPhong
            // 
            this.lstDanhSachPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lstDanhSachPhong.Location = new System.Drawing.Point(6, 14);
            this.lstDanhSachPhong.Name = "lstDanhSachPhong";
            this.lstDanhSachPhong.Size = new System.Drawing.Size(552, 109);
            this.lstDanhSachPhong.TabIndex = 2;
            this.lstDanhSachPhong.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachPhong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chọn";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên phòng";
            this.columnHeader8.Width = 182;
            // 
            // grbHocKyHientai
            // 
            this.grbHocKyHientai.Controls.Add(this.btnLuuHocKy);
            this.grbHocKyHientai.Controls.Add(this.txtHocKy);
            this.grbHocKyHientai.Controls.Add(this.label6);
            this.grbHocKyHientai.Location = new System.Drawing.Point(21, 440);
            this.grbHocKyHientai.Name = "grbHocKyHientai";
            this.grbHocKyHientai.Size = new System.Drawing.Size(347, 110);
            this.grbHocKyHientai.TabIndex = 12;
            this.grbHocKyHientai.TabStop = false;
            this.grbHocKyHientai.Text = "Học kỳ hiện tại";
            // 
            // btnLuuHocKy
            // 
            this.btnLuuHocKy.Location = new System.Drawing.Point(257, 81);
            this.btnLuuHocKy.Name = "btnLuuHocKy";
            this.btnLuuHocKy.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHocKy.TabIndex = 4;
            this.btnLuuHocKy.Text = "Lưu";
            this.btnLuuHocKy.UseVisualStyleBackColor = true;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(69, 27);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(47, 20);
            this.txtHocKy.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hoc kỳ :";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(891, 524);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 26);
            this.button11.TabIndex = 13;
            this.button11.Text = "Trở về";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.grbHocKyHientai);
            this.Controls.Add(this.grbDanhSachPhong);
            this.Controls.Add(this.grbPhong);
            this.Controls.Add(this.grbDanhSachLQL);
            this.Controls.Add(this.grbLopQuanLy);
            this.Controls.Add(this.grbDanhSachKhoa);
            this.Controls.Add(this.grbKhoa);
            this.Name = "frmCauHinh";
            this.Text = "frmCauHinh";
            this.Load += new System.EventHandler(this.frmCauHinh_Load);
            this.grbDanhSachKhoa.ResumeLayout(false);
            this.grbKhoa.ResumeLayout(false);
            this.grbKhoa.PerformLayout();
            this.grbLopQuanLy.ResumeLayout(false);
            this.grbLopQuanLy.PerformLayout();
            this.grbDanhSachLQL.ResumeLayout(false);
            this.grbPhong.ResumeLayout(false);
            this.grbPhong.PerformLayout();
            this.grbDanhSachPhong.ResumeLayout(false);
            this.grbHocKyHientai.ResumeLayout(false);
            this.grbHocKyHientai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachKhoa;
        private System.Windows.Forms.GroupBox grbKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaoKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbLopQuanLy;
        private System.Windows.Forms.ComboBox cmbTenKhoaLQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLopLQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDanhSachLQL;
        private System.Windows.Forms.GroupBox grbPhong;
        private System.Windows.Forms.ListView lstDanhSachKhoa;
        private System.Windows.Forms.ListView lstDanhsachLQL;
        private System.Windows.Forms.GroupBox grbDanhSachPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstDanhSachPhong;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnCapNhatKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnCapNhatLQL;
        private System.Windows.Forms.Button btnXoaLQL;
        private System.Windows.Forms.Button btnTaoLQL;
        private System.Windows.Forms.Button btnCapNhatPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnTaoPhong;
        private System.Windows.Forms.GroupBox grbHocKyHientai;
        private System.Windows.Forms.Button btnLuuHocKy;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;

    }
}