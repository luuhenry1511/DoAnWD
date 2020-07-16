using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnWD.Moduls;

namespace DoAnWD
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        XLNHANVIEN tblNHANVIEN;

        BindingManagerBase NHANVIEN;
        bool capnhat = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void enaButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            dgvDSNhanVien.Enabled = !capnhat;
            gTTSach.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gTTSach_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            tblNHANVIEN = new XLNHANVIEN();

            LoadNV();
            txtMaNV.DataBindings.Add("text", tblNHANVIEN, "MaNV", true);
            txtTen.DataBindings.Add("text", tblNHANVIEN, "TenNV", true);
            dateNgaySinh.DataBindings.Add("text", tblNHANVIEN, "NgaySinh", true);
            rdbNam.DataBindings.Add("checked", tblNHANVIEN, "GioiTinh", true);
            txtSDT.DataBindings.Add("text", tblNHANVIEN, "SDT", true);
            txtEmail.DataBindings.Add("text", tblNHANVIEN, "Email", true);
            txtDiaChi.DataBindings.Add("text", tblNHANVIEN, "DiaChi", true);
            

            NHANVIEN = this.BindingContext[tblNHANVIEN];
            enaButton();
        }

        private void LoadNV()
        {
            dgvDSNhanVien.AutoGenerateColumns = false;
            dgvDSNhanVien.DataSource = tblNHANVIEN;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            rdbNu.Checked = !rdbNam.Checked;
        }
    }
}