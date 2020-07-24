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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        XLNCC tblNCC;

        BindingManagerBase NCC;
        bool capnhat = false;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            tblNCC = new XLNCC();
            LoaddgvDSS();
            txtMaNCC.DataBindings.Add("text", tblNCC, "MaNCC", true);
            txtTenNCC.DataBindings.Add("text", tblNCC, "TenNCC", true);
            textDiaChi.DataBindings.Add("text", tblNCC, "DiaChi", true);
            txtSDT.DataBindings.Add("text", tblNCC, "SDT", true);
            txtEmail.DataBindings.Add("text", tblNCC, "Email", true);

            NCC = this.BindingContext[tblNCC];
            enaButton();
        }

        private void LoaddgvDSS()
        {
            dgvDSS.AutoGenerateColumns = false;
            dgvDSS.DataSource = tblNCC;
        }

        private void enaButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            dgvDSS.Enabled = !capnhat;
            gTTSach.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
        }

        private void dgvDSS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSS.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}