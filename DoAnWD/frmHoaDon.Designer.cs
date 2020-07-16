﻿namespace DoAnWD
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhanVienLap = new System.Windows.Forms.TextBox();
            this.btnHuyHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLapHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.gThongTin = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(555, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Location = new System.Drawing.Point(475, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập:";
            // 
            // txtNhanVienLap
            // 
            this.txtNhanVienLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhanVienLap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtNhanVienLap.Location = new System.Drawing.Point(461, 101);
            this.txtNhanVienLap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanVienLap.Name = "txtNhanVienLap";
            this.txtNhanVienLap.Size = new System.Drawing.Size(148, 27);
            this.txtNhanVienLap.TabIndex = 2;
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuyHoaDon.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnHuyHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyHoaDon.ImageOptions.Image")));
            this.btnHuyHoaDon.Location = new System.Drawing.Point(856, 229);
            this.btnHuyHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(137, 64);
            this.btnHuyHoaDon.TabIndex = 4;
            this.btnHuyHoaDon.Text = "Hủy hóa đơn";
            this.btnHuyHoaDon.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Xóa});
            this.dgvData.Location = new System.Drawing.Point(-1, 452);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1222, 230);
            this.dgvData.TabIndex = 6;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaCTHD";
            this.Column1.HeaderText = "Mã CTHD";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaHD";
            this.Column2.HeaderText = "Mã Hóa Đơn";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaSach";
            this.Column4.HeaderText = "Mã sách";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tong";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.Name = "Column6";
            // 
            // Xóa
            // 
            this.Xóa.DataPropertyName = "Xóa";
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.Name = "Xóa";
            this.Xóa.Text = "Xóa";
            this.Xóa.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label3.Location = new System.Drawing.Point(341, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên lập:";
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapHoaDon.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnLapHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDon.ImageOptions.Image")));
            this.btnLapHoaDon.Location = new System.Drawing.Point(856, 139);
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(137, 72);
            this.btnLapHoaDon.TabIndex = 4;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            // 
            // gThongTin
            // 
            this.gThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gThongTin.Controls.Add(this.nudSoLuong);
            this.gThongTin.Controls.Add(this.txtKhachHang);
            this.gThongTin.Controls.Add(this.txtTongTien);
            this.gThongTin.Controls.Add(this.txtMaSach);
            this.gThongTin.Controls.Add(this.label8);
            this.gThongTin.Controls.Add(this.label7);
            this.gThongTin.Controls.Add(this.label5);
            this.gThongTin.Controls.Add(this.label4);
            this.gThongTin.Location = new System.Drawing.Point(172, 136);
            this.gThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gThongTin.Name = "gThongTin";
            this.gThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gThongTin.Size = new System.Drawing.Size(627, 218);
            this.gThongTin.TabIndex = 7;
            this.gThongTin.TabStop = false;
            this.gThongTin.Text = "Thông tin";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSoLuong.Cursor = System.Windows.Forms.Cursors.Cross;
            this.nudSoLuong.Location = new System.Drawing.Point(171, 108);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(182, 27);
            this.nudSoLuong.TabIndex = 11;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhachHang.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtKhachHang.Location = new System.Drawing.Point(171, 29);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhachHang.Multiline = true;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(272, 32);
            this.txtKhachHang.TabIndex = 8;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtTongTien.Location = new System.Drawing.Point(171, 148);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(209, 30);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSach.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtMaSach.Location = new System.Drawing.Point(171, 69);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(272, 31);
            this.txtMaSach.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label8.Location = new System.Drawing.Point(39, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng tiền:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label7.Location = new System.Drawing.Point(39, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label5.Location = new System.Drawing.Point(39, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã sách:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label4.Location = new System.Drawing.Point(39, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Khách hàng:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label6.Location = new System.Drawing.Point(637, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBox1.Location = new System.Drawing.Point(757, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 27);
            this.textBox1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1019, 230);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 70);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "&Thoát";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(856, 301);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 66);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(1019, 139);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 72);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            // 
            // simpleButton4
            // 
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(334, 361);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(47, 34);
            this.simpleButton4.TabIndex = 37;
            // 
            // simpleButton3
            // 
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(281, 361);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(47, 34);
            this.simpleButton3.TabIndex = 38;
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(228, 361);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(47, 34);
            this.simpleButton2.TabIndex = 39;
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(175, 361);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(47, 34);
            this.simpleButton1.TabIndex = 40;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(620, 398);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 34);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(151, 405);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(451, 27);
            this.txtNhap.TabIndex = 41;
            this.txtNhap.Text = "Nhập hóa đơn cần tìm...";
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayLap.Location = new System.Drawing.Point(560, 62);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(200, 27);
            this.dateNgayLap.TabIndex = 43;
            // 
            // frmHoaDon
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 684);
            this.Controls.Add(this.dateNgayLap);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gThongTin);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnHuyHoaDon);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNhanVienLap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gThongTin.ResumeLayout(false);
            this.gThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhanVienLap;
        private DevExpress.XtraEditors.SimpleButton btnHuyHoaDon;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnLapHoaDon;
        private System.Windows.Forms.GroupBox gThongTin;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}