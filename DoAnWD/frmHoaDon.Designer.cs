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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhanVienLap = new System.Windows.Forms.TextBox();
            this.btnHuyHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.deNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLapHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(272, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Location = new System.Drawing.Point(229, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập:";
            // 
            // txtNhanVienLap
            // 
            this.txtNhanVienLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhanVienLap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtNhanVienLap.Location = new System.Drawing.Point(311, 98);
            this.txtNhanVienLap.Name = "txtNhanVienLap";
            this.txtNhanVienLap.Size = new System.Drawing.Size(100, 21);
            this.txtNhanVienLap.TabIndex = 2;
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuyHoaDon.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(483, 200);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(75, 44);
            this.btnHuyHoaDon.TabIndex = 4;
            this.btnHuyHoaDon.Text = "Hủy hóa đơn";
            this.btnHuyHoaDon.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // deNgayLap
            // 
            this.deNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deNgayLap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.deNgayLap.EditValue = null;
            this.deNgayLap.Location = new System.Drawing.Point(309, 68);
            this.deNgayLap.Name = "deNgayLap";
            this.deNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Size = new System.Drawing.Size(100, 20);
            this.deNgayLap.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Xóa});
            this.dataGridView1.Location = new System.Drawing.Point(2, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 148);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label3.Location = new System.Drawing.Point(229, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên lập:";
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapHoaDon.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnLapHoaDon.Location = new System.Drawing.Point(483, 138);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(75, 45);
            this.btnLapHoaDon.TabIndex = 4;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.nudSoLuong);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSoLuong.Cursor = System.Windows.Forms.Cursors.Cross;
            this.nudSoLuong.Location = new System.Drawing.Point(114, 74);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(121, 21);
            this.nudSoLuong.TabIndex = 11;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhachHang.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtKhachHang.Location = new System.Drawing.Point(114, 20);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(183, 21);
            this.txtKhachHang.TabIndex = 8;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtTongTien.Location = new System.Drawing.Point(114, 101);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(133, 21);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSach.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtMaSach.Location = new System.Drawing.Point(114, 47);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(183, 21);
            this.txtMaSach.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label8.Location = new System.Drawing.Point(26, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng tiền:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label7.Location = new System.Drawing.Point(26, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label5.Location = new System.Drawing.Point(26, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã sách:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label4.Location = new System.Drawing.Point(26, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Khách hàng:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NgayLap";
            this.Column1.HeaderText = "Ngày lập";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNV";
            this.Column2.HeaderText = "Nhân viên lập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenKH";
            this.Column3.HeaderText = "Khách hàng";
            this.Column3.Name = "Column3";
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
            // 
            // frmHoaDon
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHuyHoaDon);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.txtNhanVienLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deNgayLap);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhanVienLap;
        private DevExpress.XtraEditors.SimpleButton btnHuyHoaDon;
        private DevExpress.XtraEditors.DateEdit deNgayLap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnLapHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}