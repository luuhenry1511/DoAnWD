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
using System.Data.SqlClient;

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

            txtMaNV.Enabled = false;
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

        private void btnFirst_Click(object sender, EventArgs e)
        {
            NHANVIEN.Position = 0;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.Position > 0)
                NHANVIEN.Position -= 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.Position < NHANVIEN.Count - 1)
                NHANVIEN.Position += 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            NHANVIEN.Position = NHANVIEN.Count - 1;
        }

        private void dgvDSNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSNhanVien.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHANVIEN.AddNew();
            try
            {
                SqlCommand cmm = new SqlCommand("Select dbo.fn_CreateMaNV()", XLBANG._cnn);
                XLBANG._cnn.Open();
                txtMaNV.Text = cmm.ExecuteScalar().ToString();
                capnhat = true;
                enaButton();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            XLBANG._cnn.Close();
            capnhat = true;
            enaButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên " + txtTen.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                NHANVIEN.RemoveAt(NHANVIEN.Position);
                tblNHANVIEN.ghi();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enaButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN.EndCurrentEdit();
            tblNHANVIEN.ghi();
            capnhat = false;
            enaButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NHANVIEN.CancelCurrentEdit();
            tblNHANVIEN.RejectChanges();
            capnhat = false;
            enaButton();
        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}