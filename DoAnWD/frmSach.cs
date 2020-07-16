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
        XLTHELOAI tblTHELOAI;
        XLKESACH tblKESACH;
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
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            tblSACH = new XLSACH();
            tblTHELOAI = new XLTHELOAI();
            tblKESACH = new XLKESACH();
            LoadDGVSach();
            LoadCBOKeSach();
            LoadCBOTheLoai();
            txtMaSach.DataBindings.Add("text", tblSACH, "MaSach", true);
            txtTenSach.DataBindings.Add("text", tblSACH, "TenSach", true);
            cboKeSach.DataBindings.Add("SelectedValue", tblSACH, "KeSach", true);
            cboTheLoai.DataBindings.Add("SelectedValue", tblSACH, "TheLoai", true);
            txtNhaXB.DataBindings.Add("text", tblSACH, "NhaXB", true);
            txtDonGia.DataBindings.Add("text", tblSACH, "DonGia", true);
            txtGiaGoc.DataBindings.Add("text", tblSACH, "GiaGoc", true);
            nudSoLuong.DataBindings.Add("value", tblSACH, "SoLuong", true, DataSourceUpdateMode.OnValidation);
            txtNamXB.DataBindings.Add("text", tblSACH, "NamXB", true);
            pHinh.DataBindings.Add("Image", tblSACH, "Hinh", true);
            SACH = this.BindingContext[tblSACH];
            enaButton();
        }

        private void LoadCBOTheLoai()
        {
            cboTheLoai.DataSource = tblTHELOAI;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
        }

        private void LoadCBOKeSach()
        {
            cboKeSach.DataSource = tblKESACH;
            cboKeSach.DisplayMember = "TenKeSach";
            cboKeSach.ValueMember = "MaKeSach";
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SACH.EndCurrentEdit();
            tblSACH.ghi();
            capnhat = false;
            enaButton();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SACH.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (SACH.Position > 0)
                SACH.Position -= 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (SACH.Position < SACH.Count - 1)
                SACH.Position += 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            SACH.Position = SACH.Count - 1;
        }

        private void dgvDSSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSSach.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sách "+ txtTenSach.Text+ " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                SACH.RemoveAt(SACH.Position);
                tblSACH.ghi();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enaButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SACH.CancelCurrentEdit();
            tblSACH.RejectChanges();
            capnhat = false;
            enaButton();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            DialogChonhinh.Filter = "JPG Files|*.jpg|PNG Files|*.png| All Files|*.*";
            if (DialogChonhinh.ShowDialog() == DialogResult.OK)
            {
                pHinh.ImageLocation = DialogChonhinh.FileName;
            }
        }
    }
}