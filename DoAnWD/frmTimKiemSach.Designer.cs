namespace DoAnWD
{
    partial class frmTimKiemSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemSach));
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.gTTSach = new System.Windows.Forms.GroupBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.cboKeSach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTTSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThi.ImageOptions.Image")));
            this.btnHienThi.Location = new System.Drawing.Point(25, 269);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(119, 34);
            this.btnHienThi.TabIndex = 14;
            this.btnHienThi.Text = "Hiển thị tất cả";
            // 
            // gTTSach
            // 
            this.gTTSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gTTSach.Controls.Add(this.txtNamXB);
            this.gTTSach.Controls.Add(this.txtDonGia);
            this.gTTSach.Controls.Add(this.nudSoLuong);
            this.gTTSach.Controls.Add(this.cboTheLoai);
            this.gTTSach.Controls.Add(this.cboKeSach);
            this.gTTSach.Controls.Add(this.label6);
            this.gTTSach.Controls.Add(this.label5);
            this.gTTSach.Controls.Add(this.label9);
            this.gTTSach.Controls.Add(this.label10);
            this.gTTSach.Controls.Add(this.label4);
            this.gTTSach.Controls.Add(this.txtTenSach);
            this.gTTSach.Controls.Add(this.label3);
            this.gTTSach.Controls.Add(this.label2);
            this.gTTSach.Controls.Add(this.label7);
            this.gTTSach.Controls.Add(this.txtNhaXB);
            this.gTTSach.Controls.Add(this.txtMaSach);
            this.gTTSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTTSach.Location = new System.Drawing.Point(25, 70);
            this.gTTSach.Name = "gTTSach";
            this.gTTSach.Size = new System.Drawing.Size(646, 153);
            this.gTTSach.TabIndex = 15;
            this.gTTSach.TabStop = false;
            this.gTTSach.Text = "Thông tin Sách ";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNamXB.Location = new System.Drawing.Point(464, 84);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(88, 20);
            this.txtNamXB.TabIndex = 17;
            this.txtNamXB.TextChanged += new System.EventHandler(this.txtNamXB_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDonGia.Location = new System.Drawing.Point(464, 58);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(88, 20);
            this.txtDonGia.TabIndex = 17;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudSoLuong.Location = new System.Drawing.Point(464, 113);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(57, 20);
            this.nudSoLuong.TabIndex = 16;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(111, 88);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(175, 21);
            this.cboTheLoai.TabIndex = 15;
            // 
            // cboKeSach
            // 
            this.cboKeSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboKeSach.FormattingEnabled = true;
            this.cboKeSach.Location = new System.Drawing.Point(464, 31);
            this.cboKeSach.Name = "cboKeSach";
            this.cboKeSach.Size = new System.Drawing.Size(85, 21);
            this.cboKeSach.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kệ Sách:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhà Xuất Bản:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số lượng:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Năm xuất bản:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(111, 62);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(175, 20);
            this.txtTenSach.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Sách:";
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNhaXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaXB.Location = new System.Drawing.Point(111, 115);
            this.txtNhaXB.MaxLength = 10;
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(175, 20);
            this.txtNhaXB.TabIndex = 0;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(111, 36);
            this.txtMaSach.MaxLength = 10;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(175, 20);
            this.txtMaSach.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(583, 234);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 35);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // txtNhap
            // 
            this.txtNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhap.Location = new System.Drawing.Point(162, 242);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(415, 21);
            this.txtNhap.TabIndex = 16;
            this.txtNhap.Text = "Nhập tên sách hoặc nhà xuất bản cần tìm...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.NamXB,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvDSSach.Location = new System.Drawing.Point(2, 309);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.ReadOnly = true;
            this.dgvDSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSach.Size = new System.Drawing.Size(829, 185);
            this.dgvDSSach.TabIndex = 26;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sách";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sách";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TheLoai";
            this.dataGridViewTextBoxColumn3.HeaderText = "Thể loại";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 3;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.HeaderText = "Năm Xuất Bản";
            this.NamXB.Name = "NamXB";
            this.NamXB.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NhaXB";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nhà Xuất Bản";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "KeSach";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kệ Sách";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn7.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // frmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 497);
            this.Controls.Add(this.dgvDSSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.gTTSach);
            this.Controls.Add(this.btnHienThi);
            this.Name = "frmTimKiemSach";
            this.Text = "frmTimKiemSach";
            this.Load += new System.EventHandler(this.frmTimKiemSach_Load);
            this.gTTSach.ResumeLayout(false);
            this.gTTSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private System.Windows.Forms.GroupBox gTTSach;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.ComboBox cboKeSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtMaSach;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}