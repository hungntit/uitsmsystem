namespace StudentsManagement
{
    partial class frmMonHoc
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblChiTietMonHoc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLoaiMon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlMidle = new System.Windows.Forms.Panel();
            this.grbDanhSachMonTienQuyet = new System.Windows.Forms.GroupBox();
            this.lblDanhSachChuaChon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.grbThongTinMonHoc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTinChiLT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTinChiTH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlHead.SuspendLayout();
            this.pnlMidle.SuspendLayout();
            this.grbDanhSachMonTienQuyet.SuspendLayout();
            this.grbThongTinMonHoc.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.lblChiTietMonHoc);
            this.pnlHead.Location = new System.Drawing.Point(12, 12);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(961, 38);
            this.pnlHead.TabIndex = 6;
            // 
            // lblChiTietMonHoc
            // 
            this.lblChiTietMonHoc.AutoSize = true;
            this.lblChiTietMonHoc.Location = new System.Drawing.Point(7, 12);
            this.lblChiTietMonHoc.Name = "lblChiTietMonHoc";
            this.lblChiTietMonHoc.Size = new System.Drawing.Size(84, 13);
            this.lblChiTietMonHoc.TabIndex = 0;
            this.lblChiTietMonHoc.Text = "Chi tiết Môn học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Loại :";
            // 
            // cmbLoaiMon
            // 
            this.cmbLoaiMon.FormattingEnabled = true;
            this.cmbLoaiMon.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbLoaiMon.Location = new System.Drawing.Point(355, 58);
            this.cmbLoaiMon.Name = "cmbLoaiMon";
            this.cmbLoaiMon.Size = new System.Drawing.Size(160, 21);
            this.cmbLoaiMon.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tín chỉ lý thuyết :";
            // 
            // pnlMidle
            // 
            this.pnlMidle.Controls.Add(this.grbDanhSachMonTienQuyet);
            this.pnlMidle.Controls.Add(this.grbThongTinMonHoc);
            this.pnlMidle.Location = new System.Drawing.Point(12, 62);
            this.pnlMidle.Name = "pnlMidle";
            this.pnlMidle.Size = new System.Drawing.Size(960, 429);
            this.pnlMidle.TabIndex = 7;
            // 
            // grbDanhSachMonTienQuyet
            // 
            this.grbDanhSachMonTienQuyet.Controls.Add(this.lblDanhSachChuaChon);
            this.grbDanhSachMonTienQuyet.Controls.Add(this.label5);
            this.grbDanhSachMonTienQuyet.Controls.Add(this.lstDanhSachChuaChon);
            this.grbDanhSachMonTienQuyet.Controls.Add(this.btnChon);
            this.grbDanhSachMonTienQuyet.Controls.Add(this.btnBoChon);
            this.grbDanhSachMonTienQuyet.Controls.Add(this.lstDanhSachChon);
            this.grbDanhSachMonTienQuyet.Location = new System.Drawing.Point(10, 178);
            this.grbDanhSachMonTienQuyet.Name = "grbDanhSachMonTienQuyet";
            this.grbDanhSachMonTienQuyet.Size = new System.Drawing.Size(935, 239);
            this.grbDanhSachMonTienQuyet.TabIndex = 5;
            this.grbDanhSachMonTienQuyet.TabStop = false;
            this.grbDanhSachMonTienQuyet.Text = "Danh sách môn tiên quyết";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Danh sách chọn";
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
            // grbThongTinMonHoc
            // 
            this.grbThongTinMonHoc.Controls.Add(this.label2);
            this.grbThongTinMonHoc.Controls.Add(this.txtMaMon);
            this.grbThongTinMonHoc.Controls.Add(this.cmbLoaiMon);
            this.grbThongTinMonHoc.Controls.Add(this.label9);
            this.grbThongTinMonHoc.Controls.Add(this.label8);
            this.grbThongTinMonHoc.Controls.Add(this.txtTinChiLT);
            this.grbThongTinMonHoc.Controls.Add(this.label7);
            this.grbThongTinMonHoc.Controls.Add(this.txtTinChiTH);
            this.grbThongTinMonHoc.Controls.Add(this.label6);
            this.grbThongTinMonHoc.Controls.Add(this.txtTenMon);
            this.grbThongTinMonHoc.Location = new System.Drawing.Point(10, 16);
            this.grbThongTinMonHoc.Name = "grbThongTinMonHoc";
            this.grbThongTinMonHoc.Size = new System.Drawing.Size(935, 141);
            this.grbThongTinMonHoc.TabIndex = 3;
            this.grbThongTinMonHoc.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã môn :";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(77, 19);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(167, 20);
            this.txtMaMon.TabIndex = 20;
            // 
            // txtTinChiLT
            // 
            this.txtTinChiLT.Location = new System.Drawing.Point(128, 97);
            this.txtTinChiLT.Name = "txtTinChiLT";
            this.txtTinChiLT.Size = new System.Drawing.Size(40, 20);
            this.txtTinChiLT.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tín chỉ thực hành :";
            // 
            // txtTinChiTH
            // 
            this.txtTinChiTH.Location = new System.Drawing.Point(355, 97);
            this.txtTinChiTH.Name = "txtTinChiTH";
            this.txtTinChiTH.Size = new System.Drawing.Size(43, 20);
            this.txtTinChiTH.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên :";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(77, 59);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(167, 20);
            this.txtTenMon.TabIndex = 3;
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
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(773, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.btnTroVe);
            this.pnlBottom.Location = new System.Drawing.Point(13, 497);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(959, 53);
            this.pnlBottom.TabIndex = 8;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlMidle);
            this.Controls.Add(this.pnlBottom);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlMidle.ResumeLayout(false);
            this.grbDanhSachMonTienQuyet.ResumeLayout(false);
            this.grbDanhSachMonTienQuyet.PerformLayout();
            this.grbThongTinMonHoc.ResumeLayout(false);
            this.grbThongTinMonHoc.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblChiTietMonHoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLoaiMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlMidle;
        private System.Windows.Forms.GroupBox grbThongTinMonHoc;
        private System.Windows.Forms.TextBox txtTinChiLT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTinChiTH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.GroupBox grbDanhSachMonTienQuyet;
        private System.Windows.Forms.Label lblDanhSachChuaChon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstDanhSachChuaChon;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.ListView lstDanhSachChon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;

    }
}