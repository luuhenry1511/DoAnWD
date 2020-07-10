namespace DoAnWD
{
    partial class frmPhieuNhapcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapcs));
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.gTTSach = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.gTTSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "PHIẾU NHẬP";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column3,
            this.Column2,
            this.NamXB,
            this.Column6,
            this.Column7,
            this.Column4});
            this.dgvDSSach.Location = new System.Drawing.Point(4, 304);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.ReadOnly = true;
            this.dgvDSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSach.Size = new System.Drawing.Size(823, 187);
            this.dgvDSSach.TabIndex = 33;
            // 
            // gTTSach
            // 
            this.gTTSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gTTSach.Controls.Add(this.dtpNgayLap);
            this.gTTSach.Controls.Add(this.txtMaNV);
            this.gTTSach.Controls.Add(this.txtDonGia);
            this.gTTSach.Controls.Add(this.txtTong);
            this.gTTSach.Controls.Add(this.txtMaSach);
            this.gTTSach.Controls.Add(this.nudSoLuong);
            this.gTTSach.Controls.Add(this.label5);
            this.gTTSach.Controls.Add(this.label9);
            this.gTTSach.Controls.Add(this.label8);
            this.gTTSach.Controls.Add(this.label10);
            this.gTTSach.Controls.Add(this.label4);
            this.gTTSach.Controls.Add(this.label3);
            this.gTTSach.Controls.Add(this.label2);
            this.gTTSach.Controls.Add(this.la);
            this.gTTSach.Controls.Add(this.txtMaNCC);
            this.gTTSach.Controls.Add(this.txtMaPN);
            this.gTTSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTTSach.Location = new System.Drawing.Point(12, 55);
            this.gTTSach.Name = "gTTSach";
            this.gTTSach.Size = new System.Drawing.Size(806, 153);
            this.gTTSach.TabIndex = 32;
            this.gTTSach.TabStop = false;
            this.gTTSach.Text = "Thông tin Phiếu Nhập";
            this.gTTSach.Enter += new System.EventHandler(this.gTTSach_Enter);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Location = new System.Drawing.Point(489, 89);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(70, 20);
            this.txtDonGia.TabIndex = 18;
            // 
            // txtTong
            // 
            this.txtTong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTong.Location = new System.Drawing.Point(489, 115);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(88, 20);
            this.txtTong.TabIndex = 17;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSach.Location = new System.Drawing.Point(489, 32);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(88, 20);
            this.txtMaSach.TabIndex = 17;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSoLuong.Location = new System.Drawing.Point(489, 62);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(57, 20);
            this.nudSoLuong.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã NCC:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số lượng:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đơn Giá:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tổng Tiền:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Sách";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã NV lập: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập:";
            // 
            // la
            // 
            this.la.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(105, 39);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(45, 13);
            this.la.TabIndex = 1;
            this.la.Text = "MaPN:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(191, 115);
            this.txtMaNCC.MaxLength = 10;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(175, 20);
            this.txtMaNCC.TabIndex = 1;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(191, 36);
            this.txtMaPN.MaxLength = 10;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(175, 20);
            this.txtMaPN.TabIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(128, 212);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(31, 23);
            this.simpleButton4.TabIndex = 35;
            // 
            // simpleButton3
            // 
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(93, 212);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(31, 23);
            this.simpleButton3.TabIndex = 36;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(522, 248);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "&Thoát";
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(58, 212);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(31, 23);
            this.simpleButton2.TabIndex = 37;
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(22, 212);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(31, 23);
            this.simpleButton1.TabIndex = 38;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(441, 248);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 38);
            this.btnHuy.TabIndex = 44;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(360, 248);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(278, 248);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(198, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(117, 248);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 38);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNV.Location = new System.Drawing.Point(191, 89);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(131, 20);
            this.txtMaNV.TabIndex = 19;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Location = new System.Drawing.Point(191, 59);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(175, 20);
            this.dtpNgayLap.TabIndex = 20;
            this.dtpNgayLap.Value = new System.DateTime(2020, 7, 10, 12, 43, 54, 0);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSach";
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "Mã NV lâp:";
            this.Column3.MinimumWidth = 3;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayLap";
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "MaNCC";
            this.NamXB.HeaderText = "Mã NCC";
            this.NamXB.Name = "NamXB";
            this.NamXB.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DonGia";
            this.Column7.HeaderText = "Đơn Giá";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TongTien";
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmPhieuNhapcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 492);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDSSach);
            this.Controls.Add(this.gTTSach);
            this.Name = "frmPhieuNhapcs";
            this.Text = "frmPhieuNhapcs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.gTTSach.ResumeLayout(false);
            this.gTTSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.GroupBox gTTSach;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}