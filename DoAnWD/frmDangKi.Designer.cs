namespace DoAnWD
{
    partial class frmDangKi
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cboLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxhienmk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng ký tài khoản nhân viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.Location = new System.Drawing.Point(289, 296);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(148, 27);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhân viên:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhập lại mật khẩu:";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhapLaiMK.Location = new System.Drawing.Point(289, 356);
            this.txtNhapLaiMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(148, 27);
            this.txtNhapLaiMK.TabIndex = 5;
            this.txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangKy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Appearance.Options.UseFont = true;
            this.btnDangKy.Location = new System.Drawing.Point(109, 453);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(112, 41);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng kí";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "UserName:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Location = new System.Drawing.Point(230, 121);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Loại tài khoản:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(258, 453);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 41);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cboLoaiTK
            // 
            this.cboLoaiTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoaiTK.FormattingEnabled = true;
            this.cboLoaiTK.Location = new System.Drawing.Point(230, 172);
            this.cboLoaiTK.Name = "cboLoaiTK";
            this.cboLoaiTK.Size = new System.Drawing.Size(148, 27);
            this.cboLoaiTK.TabIndex = 3;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhanVien.Location = new System.Drawing.Point(230, 31);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(148, 27);
            this.txtNhanVien.TabIndex = 0;
            this.txtNhanVien.TextChanged += new System.EventHandler(this.txtNhanVien_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.cboLoaiTK);
            this.panel1.Controls.Add(this.txtNhanVien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkBoxhienmk);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(59, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 351);
            this.panel1.TabIndex = 10;
            // 
            // checkBoxhienmk
            // 
            this.checkBoxhienmk.AutoSize = true;
            this.checkBoxhienmk.Location = new System.Drawing.Point(385, 227);
            this.checkBoxhienmk.Name = "checkBoxhienmk";
            this.checkBoxhienmk.Size = new System.Drawing.Size(109, 23);
            this.checkBoxhienmk.TabIndex = 0;
            this.checkBoxhienmk.Text = "checkBox1";
            this.checkBoxhienmk.UseVisualStyleBackColor = true;
            this.checkBoxhienmk.CheckedChanged += new System.EventHandler(this.checkBoxhienmk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(230, 74);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(148, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 538);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKi";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.frmDangKi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ComboBox cboLoaiTK;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxhienmk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
    }
}