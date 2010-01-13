namespace StudentsManagement
{
    partial class frmLopDangKy
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.pnlMidle = new System.Windows.Forms.Panel();
            this.grbThongTinLopDangKy = new System.Windows.Forms.GroupBox();
            this.cmbNamhoc = new System.Windows.Forms.ComboBox();
            this.cmbHocky = new System.Windows.Forms.ComboBox();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.cmbGiangVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTenMon = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbThu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.dtNgayMoLop = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numCa = new System.Windows.Forms.NumericUpDown();
            this.pnlBottom.SuspendLayout();
            this.pnlMidle.SuspendLayout();
            this.grbThongTinLopDangKy.SuspendLayout();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(773, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.pnlMidle.Controls.Add(this.grbThongTinLopDangKy);
            this.pnlMidle.Location = new System.Drawing.Point(12, 62);
            this.pnlMidle.Name = "pnlMidle";
            this.pnlMidle.Size = new System.Drawing.Size(960, 429);
            this.pnlMidle.TabIndex = 4;
            // 
            // grbThongTinLopDangKy
            // 
            this.grbThongTinLopDangKy.Controls.Add(this.numCa);
            this.grbThongTinLopDangKy.Controls.Add(this.label3);
            this.grbThongTinLopDangKy.Controls.Add(this.dtNgayMoLop);
            this.grbThongTinLopDangKy.Controls.Add(this.cmbNamhoc);
            this.grbThongTinLopDangKy.Controls.Add(this.cmbHocky);
            this.grbThongTinLopDangKy.Controls.Add(this.cmbPhong);
            this.grbThongTinLopDangKy.Controls.Add(this.cmbGiangVien);
            this.grbThongTinLopDangKy.Controls.Add(this.label2);
            this.grbThongTinLopDangKy.Controls.Add(this.cmbTenMon);
            this.grbThongTinLopDangKy.Controls.Add(this.label15);
            this.grbThongTinLopDangKy.Controls.Add(this.label14);
            this.grbThongTinLopDangKy.Controls.Add(this.cmbThu);
            this.grbThongTinLopDangKy.Controls.Add(this.label13);
            this.grbThongTinLopDangKy.Controls.Add(this.label12);
            this.grbThongTinLopDangKy.Controls.Add(this.label10);
            this.grbThongTinLopDangKy.Controls.Add(this.label8);
            this.grbThongTinLopDangKy.Controls.Add(this.label9);
            this.grbThongTinLopDangKy.Controls.Add(this.txtTenLop);
            this.grbThongTinLopDangKy.Controls.Add(this.txtMaLop);
            this.grbThongTinLopDangKy.Controls.Add(this.label7);
            this.grbThongTinLopDangKy.Location = new System.Drawing.Point(10, 3);
            this.grbThongTinLopDangKy.Name = "grbThongTinLopDangKy";
            this.grbThongTinLopDangKy.Size = new System.Drawing.Size(935, 413);
            this.grbThongTinLopDangKy.TabIndex = 0;
            this.grbThongTinLopDangKy.TabStop = false;
            this.grbThongTinLopDangKy.Text = "Thông Tin Lớp Đăng Ký";
            // 
            // cmbNamhoc
            // 
            this.cmbNamhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamhoc.FormattingEnabled = true;
            this.cmbNamhoc.Location = new System.Drawing.Point(146, 127);
            this.cmbNamhoc.Name = "cmbNamhoc";
            this.cmbNamhoc.Size = new System.Drawing.Size(109, 21);
            this.cmbNamhoc.TabIndex = 60;
            // 
            // cmbHocky
            // 
            this.cmbHocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocky.FormattingEnabled = true;
            this.cmbHocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbHocky.Location = new System.Drawing.Point(146, 95);
            this.cmbHocky.Name = "cmbHocky";
            this.cmbHocky.Size = new System.Drawing.Size(109, 21);
            this.cmbHocky.TabIndex = 59;
            // 
            // cmbPhong
            // 
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "CN"});
            this.cmbPhong.Location = new System.Drawing.Point(716, 19);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(75, 21);
            this.cmbPhong.TabIndex = 58;
            // 
            // cmbGiangVien
            // 
            this.cmbGiangVien.FormattingEnabled = true;
            this.cmbGiangVien.Location = new System.Drawing.Point(394, 55);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Size = new System.Drawing.Size(231, 21);
            this.cmbGiangVien.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Giảng viên :";
            // 
            // cmbTenMon
            // 
            this.cmbTenMon.FormattingEnabled = true;
            this.cmbTenMon.Location = new System.Drawing.Point(394, 22);
            this.cmbTenMon.Name = "cmbTenMon";
            this.cmbTenMon.Size = new System.Drawing.Size(231, 21);
            this.cmbTenMon.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(83, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Năm học :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(90, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = " Học kỳ :";
            // 
            // cmbThu
            // 
            this.cmbThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThu.FormattingEnabled = true;
            this.cmbThu.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "CN"});
            this.cmbThu.Location = new System.Drawing.Point(716, 52);
            this.cmbThu.Name = "cmbThu";
            this.cmbThu.Size = new System.Drawing.Size(42, 21);
            this.cmbThu.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(333, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Tên môn :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(684, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ca :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(679, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Thứ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tên phòng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tên Lớp Đăng ký:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(144, 56);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(111, 20);
            this.txtTenLop.TabIndex = 42;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(143, 23);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(112, 20);
            this.txtMaLop.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mã Lớp Đăng ký :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết Lớp đăng ký";
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Location = new System.Drawing.Point(12, 12);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(961, 38);
            this.pnlHead.TabIndex = 3;
            // 
            // dtNgayMoLop
            // 
            this.dtNgayMoLop.CustomFormat = "dd-M-yyyy";
            this.dtNgayMoLop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayMoLop.Location = new System.Drawing.Point(405, 96);
            this.dtNgayMoLop.Name = "dtNgayMoLop";
            this.dtNgayMoLop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtNgayMoLop.RightToLeftLayout = true;
            this.dtNgayMoLop.Size = new System.Drawing.Size(90, 20);
            this.dtNgayMoLop.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ngày Mở lớp";
            // 
            // numCa
            // 
            this.numCa.Location = new System.Drawing.Point(717, 92);
            this.numCa.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCa.Name = "numCa";
            this.numCa.Size = new System.Drawing.Size(74, 20);
            this.numCa.TabIndex = 63;
            this.numCa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmLopDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMidle);
            this.Controls.Add(this.pnlHead);
            this.Name = "frmLopDangKy";
            this.Text = "LopDangKy";
            this.Load += new System.EventHandler(this.frmLopDangKy_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlMidle.ResumeLayout(false);
            this.grbThongTinLopDangKy.ResumeLayout(false);
            this.grbThongTinLopDangKy.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Panel pnlMidle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.GroupBox grbThongTinLopDangKy;
        private System.Windows.Forms.ComboBox cmbTenMon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbThu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.ComboBox cmbHocky;
        private System.Windows.Forms.ComboBox cmbNamhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayMoLop;
        private System.Windows.Forms.NumericUpDown numCa;
    }
}