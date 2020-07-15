namespace DoAnWD
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.gTTSach = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.gTTSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "QUẢN LÍ NHÂN VIÊN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Ngaysinh,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDSNhanVien.Location = new System.Drawing.Point(117, 300);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.ReadOnly = true;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(481, 194);
            this.dgvDSNhanVien.TabIndex = 33;
            // 
            // gTTSach
            // 
            this.gTTSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gTTSach.Controls.Add(this.simpleButton4);
            this.gTTSach.Controls.Add(this.simpleButton3);
            this.gTTSach.Controls.Add(this.simpleButton2);
            this.gTTSach.Controls.Add(this.simpleButton1);
            this.gTTSach.Controls.Add(this.dateTimePicker1);
            this.gTTSach.Controls.Add(this.txtDiaChi);
            this.gTTSach.Controls.Add(this.txtEmail);
            this.gTTSach.Controls.Add(this.txtSDT);
            this.gTTSach.Controls.Add(this.rdbNu);
            this.gTTSach.Controls.Add(this.rdbNam);
            this.gTTSach.Controls.Add(this.label3);
            this.gTTSach.Controls.Add(this.label6);
            this.gTTSach.Controls.Add(this.label8);
            this.gTTSach.Controls.Add(this.label4);
            this.gTTSach.Controls.Add(this.label5);
            this.gTTSach.Controls.Add(this.txtTen);
            this.gTTSach.Controls.Add(this.label2);
            this.gTTSach.Controls.Add(this.label1);
            this.gTTSach.Controls.Add(this.txtMaNV);
            this.gTTSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTTSach.Location = new System.Drawing.Point(12, 47);
            this.gTTSach.Name = "gTTSach";
            this.gTTSach.Size = new System.Drawing.Size(800, 180);
            this.gTTSach.TabIndex = 32;
            this.gTTSach.TabStop = false;
            this.gTTSach.Text = "Thông tin Nhân Viên";
            this.gTTSach.Enter += new System.EventHandler(this.gTTSach_Enter);
            // 
            // simpleButton4
            // 
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(142, 144);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(36, 23);
            this.simpleButton4.TabIndex = 55;
            // 
            // simpleButton3
            // 
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(102, 144);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(36, 23);
            this.simpleButton3.TabIndex = 56;
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(62, 144);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(36, 23);
            this.simpleButton2.TabIndex = 57;
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(22, 144);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(36, 23);
            this.simpleButton1.TabIndex = 58;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 96);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDiaChi.Location = new System.Drawing.Point(487, 116);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(171, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmail.Location = new System.Drawing.Point(487, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSDT.Location = new System.Drawing.Point(487, 64);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 12;
            // 
            // rdbNu
            // 
            this.rdbNu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(557, 35);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(41, 17);
            this.rdbNu.TabIndex = 11;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(487, 36);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(50, 17);
            this.rdbNam.TabIndex = 10;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SDT:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giới Tính:";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(168, 65);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(175, 20);
            this.txtTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên NV:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(168, 39);
            this.txtMaNV.MaxLength = 10;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(175, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(523, 245);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(441, 245);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 38);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(361, 245);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(280, 245);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(199, 245);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(117, 245);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 38);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STT";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ Tên NV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 3;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.HeaderText = "Ngaysinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            this.Ngaysinh.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SDT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 496);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDSNhanVien);
            this.Controls.Add(this.gTTSach);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.gTTSach.ResumeLayout(false);
            this.gTTSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.GroupBox gTTSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}