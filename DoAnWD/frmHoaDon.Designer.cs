namespace DoAnWD
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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLapHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.gThongTin = new System.Windows.Forms.GroupBox();
            this.cbSach = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.gThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(542, 26);
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
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(508, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập:";
            // 
            // txtNhanVienLap
            // 
            this.txtNhanVienLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhanVienLap.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNhanVienLap.Location = new System.Drawing.Point(636, 205);
            this.txtNhanVienLap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanVienLap.Name = "txtNhanVienLap";
            this.txtNhanVienLap.Size = new System.Drawing.Size(148, 27);
            this.txtNhanVienLap.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(856, 172);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(136, 64);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToOrderColumns = true;
            this.dgvCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.Xóa});
            this.dgvCTHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCTHD.Location = new System.Drawing.Point(452, 406);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(203, 229);
            this.dgvCTHD.TabIndex = 6;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            this.dgvCTHD.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvData_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaCTHD";
            this.Column1.HeaderText = "Mã CTHD";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaHD";
            this.Column2.HeaderText = "Mã Hóa Đơn";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenSach";
            this.Column4.HeaderText = "Tên sách";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ThanhTien";
            this.Column3.HeaderText = "Thành tiền";
            this.Column3.Name = "Column3";
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
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(508, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên lập:";
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLapHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDon.ImageOptions.Image")));
            this.btnLapHoaDon.Location = new System.Drawing.Point(856, 83);
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(136, 72);
            this.btnLapHoaDon.TabIndex = 4;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // gThongTin
            // 
            this.gThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gThongTin.Controls.Add(this.cbSach);
            this.gThongTin.Controls.Add(this.nudSoLuong);
            this.gThongTin.Controls.Add(this.txtTongTien);
            this.gThongTin.Controls.Add(this.label8);
            this.gThongTin.Controls.Add(this.label7);
            this.gThongTin.Controls.Add(this.label5);
            this.gThongTin.Cursor = System.Windows.Forms.Cursors.Default;
            this.gThongTin.Location = new System.Drawing.Point(14, 83);
            this.gThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gThongTin.Name = "gThongTin";
            this.gThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gThongTin.Size = new System.Drawing.Size(452, 202);
            this.gThongTin.TabIndex = 7;
            this.gThongTin.TabStop = false;
            this.gThongTin.Text = "Thông tin";
            // 
            // cbSach
            // 
            this.cbSach.FormattingEnabled = true;
            this.cbSach.Location = new System.Drawing.Point(152, 45);
            this.cbSach.Name = "cbSach";
            this.cbSach.Size = new System.Drawing.Size(221, 27);
            this.cbSach.TabIndex = 12;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSoLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudSoLuong.Location = new System.Drawing.Point(152, 91);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(138, 27);
            this.nudSoLuong.TabIndex = 11;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTongTien.Location = new System.Drawing.Point(152, 132);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(210, 30);
            this.txtTongTien.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Location = new System.Drawing.Point(20, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng cộng:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Location = new System.Drawing.Point(20, 102);
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
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(20, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sách:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKhachHang.Location = new System.Drawing.Point(636, 241);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhachHang.Multiline = true;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(148, 32);
            this.txtKhachHang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(506, 241);
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
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(508, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaHD.Location = new System.Drawing.Point(636, 170);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(148, 27);
            this.txtMaHD.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1020, 246);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 70);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(856, 246);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 66);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(1020, 83);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 72);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.ImageOptions.Image")));
            this.btnLast.Location = new System.Drawing.Point(692, 324);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(46, 34);
            this.btnLast.TabIndex = 37;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.Location = new System.Drawing.Point(638, 324);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 34);
            this.btnNext.TabIndex = 38;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ImageOptions.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(585, 324);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(46, 34);
            this.btnPrevious.TabIndex = 39;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.ImageOptions.Image")));
            this.btnFirst.Location = new System.Drawing.Point(532, 324);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(46, 34);
            this.btnFirst.TabIndex = 40;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayLap.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayLap.Location = new System.Drawing.Point(636, 129);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(157, 27);
            this.dateNgayLap.TabIndex = 43;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1020, 172);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 62);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(856, 324);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(136, 54);
            this.btnIn.TabIndex = 46;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(163, 292);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 37);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHoaDon
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 684);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dateNgayLap);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gThongTin);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtNhanVienLap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnLapHoaDon;
        private System.Windows.Forms.GroupBox gThongTin;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.ComboBox cbSach;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}