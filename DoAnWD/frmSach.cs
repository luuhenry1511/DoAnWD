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
using System.Data.SqlClient;
using DoAnWD.Moduls;

namespace DoAnWD
{
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        XLSACH tblSACH;
        BindingManagerBase SACH;
        bool capnhat = false;
        public frmSach()
        {
            InitializeComponent();
        }

        private void enaButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            dgvDSSach.Enabled = !capnhat;
            gTTSach.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            btnChonHinh.Enabled = capnhat;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            tblSACH = new XLSACH();
            LoadDGVSach();
            LoadCBOKeSach();
            LoadCBOTheLoai();
            txtMaSach.DataBindings.Add("text", tblSACH, "MaSach", true);
            txtTenSach.DataBindings.Add("text", tblSACH, "TenSach", true);
            cboKeSach.DataBindings.Add("text", tblSACH, "KeSach", true);
            cboTheLoai.DataBindings.Add("text", tblSACH, "TheLoai", true);
            txtNhaXB.DataBindings.Add("text", tblSACH, "NhaXB", true);
            txtDonGia.DataBindings.Add("text", tblSACH, "DonGia", true);
            txtGiaGoc.DataBindings.Add("text", tblSACH, "GiaGoc", true);
            nudSoLuong.DataBindings.Add("value", tblSACH, "SoLuong", true);
            txtNamXB.DataBindings.Add("text", tblSACH, "NamXB", true);
            SACH = this.BindingContext[tblSACH];
            enaButton();
        }

        private void LoadCBOTheLoai()
        {
            cboTheLoai.DataSource = tblSACH.;
            cboTheLoai.DisplayMember = "TheLoai";
            cboTheLoai.ValueMember = "MaSach";
        }

        private void LoadCBOKeSach()
        {
            cboKeSach.DataSource = tblSACH;
            cboKeSach.DisplayMember = "KeSach";
            cboKeSach.ValueMember = "MaSach";
        }

        private void LoadDGVSach()
        {
            dgvDSSach.AutoGenerateColumns = false;
            dgvDSSach.DataSource = tblSACH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SACH.AddNew();
            capnhat = true;
            enaButton();
        }
    }
}