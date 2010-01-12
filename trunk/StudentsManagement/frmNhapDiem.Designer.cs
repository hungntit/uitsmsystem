namespace StudentsManagement
{
    partial class frmNhapDiem
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlThongTinLop = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDanhSachDiem = new System.Windows.Forms.Panel();
            this.lstDanhSachDiem = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.pnlDieuHuong = new System.Windows.Forms.Panel();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.cmbSoDongTrenTrang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlKetQua = new System.Windows.Forms.Panel();
            this.txtTongSo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlThongTinLop.SuspendLayout();
            this.pnlDanhSachDiem.SuspendLayout();
            this.pnlDieuHuong.SuspendLayout();
            this.pnlKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm";
            // 
            // pnlThongTinLop
            // 
            this.pnlThongTinLop.Controls.Add(this.textBox1);
            this.pnlThongTinLop.Controls.Add(this.button3);
            this.pnlThongTinLop.Controls.Add(this.button2);
            this.pnlThongTinLop.Controls.Add(this.btnXemDanhSach);
            this.pnlThongTinLop.Controls.Add(this.txtNamHoc);
            this.pnlThongTinLop.Controls.Add(this.label5);
            this.pnlThongTinLop.Controls.Add(this.txtHocKy);
            this.pnlThongTinLop.Controls.Add(this.label4);
            this.pnlThongTinLop.Controls.Add(this.label2);
            this.pnlThongTinLop.Location = new System.Drawing.Point(14, 65);
            this.pnlThongTinLop.Name = "pnlThongTinLop";
            this.pnlThongTinLop.Size = new System.Drawing.Size(958, 125);
            this.pnlThongTinLop.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(837, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Trở về";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(738, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Location = new System.Drawing.Point(29, 96);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(109, 23);
            this.btnXemDanhSach.TabIndex = 8;
            this.btnXemDanhSach.Text = "Xem danh sách";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Enabled = false;
            this.txtNamHoc.Location = new System.Drawing.Point(267, 43);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(85, 20);
            this.txtNamHoc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Năm học :";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Enabled = false;
            this.txtHocKy.Location = new System.Drawing.Point(124, 43);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(40, 20);
            this.txtHocKy.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Học kỳ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lớp Đăng ký :";
            // 
            // pnlDanhSachDiem
            // 
            this.pnlDanhSachDiem.Controls.Add(this.lstDanhSachDiem);
            this.pnlDanhSachDiem.Location = new System.Drawing.Point(14, 196);
            this.pnlDanhSachDiem.Name = "pnlDanhSachDiem";
            this.pnlDanhSachDiem.Size = new System.Drawing.Size(958, 310);
            this.pnlDanhSachDiem.TabIndex = 2;
            // 
            // lstDanhSachDiem
            // 
            this.lstDanhSachDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8});
            this.lstDanhSachDiem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstDanhSachDiem.Location = new System.Drawing.Point(13, 17);
            this.lstDanhSachDiem.Name = "lstDanhSachDiem";
            this.lstDanhSachDiem.Size = new System.Drawing.Size(933, 275);
            this.lstDanhSachDiem.TabIndex = 0;
            this.lstDanhSachDiem.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachDiem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MSSV";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sinh";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Điểm";
            this.columnHeader8.Width = 129;
            // 
            // pnlDieuHuong
            // 
            this.pnlDieuHuong.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDieuHuong.Controls.Add(this.btnCuoi);
            this.pnlDieuHuong.Controls.Add(this.btnSau);
            this.pnlDieuHuong.Controls.Add(this.btnTruoc);
            this.pnlDieuHuong.Controls.Add(this.btnDau);
            this.pnlDieuHuong.Controls.Add(this.cmbSoDongTrenTrang);
            this.pnlDieuHuong.Controls.Add(this.label6);
            this.pnlDieuHuong.Location = new System.Drawing.Point(493, 521);
            this.pnlDieuHuong.Name = "pnlDieuHuong";
            this.pnlDieuHuong.Size = new System.Drawing.Size(478, 39);
            this.pnlDieuHuong.TabIndex = 21;
            // 
            // btnCuoi
            // 
            this.btnCuoi.Location = new System.Drawing.Point(414, 11);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(51, 23);
            this.btnCuoi.TabIndex = 9;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(360, 12);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(51, 23);
            this.btnSau.TabIndex = 8;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(291, 12);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(51, 23);
            this.btnTruoc.TabIndex = 7;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            // 
            // btnDau
            // 
            this.btnDau.Location = new System.Drawing.Point(237, 13);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(51, 23);
            this.btnDau.TabIndex = 6;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            // 
            // cmbSoDongTrenTrang
            // 
            this.cmbSoDongTrenTrang.FormattingEnabled = true;
            this.cmbSoDongTrenTrang.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cmbSoDongTrenTrang.Location = new System.Drawing.Point(169, 13);
            this.cmbSoDongTrenTrang.Name = "cmbSoDongTrenTrang";
            this.cmbSoDongTrenTrang.Size = new System.Drawing.Size(41, 21);
            this.cmbSoDongTrenTrang.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số dòng hiển thị trên 1 trang :";
            // 
            // pnlKetQua
            // 
            this.pnlKetQua.Controls.Add(this.txtTongSo);
            this.pnlKetQua.Controls.Add(this.label7);
            this.pnlKetQua.Controls.Add(this.txtHienThi);
            this.pnlKetQua.Controls.Add(this.label8);
            this.pnlKetQua.Location = new System.Drawing.Point(14, 521);
            this.pnlKetQua.Name = "pnlKetQua";
            this.pnlKetQua.Size = new System.Drawing.Size(319, 39);
            this.pnlKetQua.TabIndex = 22;
            // 
            // txtTongSo
            // 
            this.txtTongSo.Location = new System.Drawing.Point(245, 9);
            this.txtTongSo.Name = "txtTongSo";
            this.txtTongSo.Size = new System.Drawing.Size(47, 20);
            this.txtTongSo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "kết quả trên tổng số :";
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(78, 9);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(47, 20);
            this.txtHienThi.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hiển thị ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 11;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.pnlDieuHuong);
            this.Controls.Add(this.pnlKetQua);
            this.Controls.Add(this.pnlDanhSachDiem);
            this.Controls.Add(this.pnlThongTinLop);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapDiem";
            this.Text = "NhapDiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlThongTinLop.ResumeLayout(false);
            this.pnlThongTinLop.PerformLayout();
            this.pnlDanhSachDiem.ResumeLayout(false);
            this.pnlDieuHuong.ResumeLayout(false);
            this.pnlDieuHuong.PerformLayout();
            this.pnlKetQua.ResumeLayout(false);
            this.pnlKetQua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlThongTinLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Panel pnlDanhSachDiem;
        private System.Windows.Forms.ListView lstDanhSachDiem;
        private System.Windows.Forms.Panel pnlDieuHuong;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.ComboBox cmbSoDongTrenTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlKetQua;
        private System.Windows.Forms.TextBox txtTongSo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox1;
    }
}