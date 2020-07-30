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

            txtMaNCC.Enabled = false;
        }

        private void dgvDSS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSS.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text != "") //kiem tra dieu kien
            {
                NCC.EndCurrentEdit();
                tblNCC.ghi();
                capnhat = false;
                enaButton();
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên nhà cung cấp");
                txtTenNCC.Focus();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NCC.AddNew();
            txtTenNCC.Focus();
            try
            {
                SqlCommand cmm = new SqlCommand("Select dbo.fn_CreateMaNCC()", XLBANG._cnn);
                XLBANG._cnn.Open();
                txtMaNCC.Text = cmm.ExecuteScalar().ToString();
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

            if (MessageBox.Show("Bạn có muốn xóa NCC " + txtTenNCC.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable kttt = new DataTable(); // kttt kiểm tra thông tin có trong bảng khác không???

                string sql = "select * from PHIEUNHAP where MaNCC= '" + txtMaNCC.Text + "'";
                kttt = new XLPHIEUNHAP(sql);
                int i = kttt.Rows.Count;
                if (i > 0)
                    MessageBox.Show("Nhà cung cấp  " + txtTenNCC.Text + " có trong bảng Phiếu nhập!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    NCC.RemoveAt(NCC.Position);
                    tblNCC.ghi();
                    MessageBox.Show("Xóa thành công!");
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enaButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NCC.CancelCurrentEdit();
            tblNCC.RejectChanges();
            capnhat = false;
            enaButton();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            NCC.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (NCC.Position > 0)
                NCC.Position -= 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (NCC.Position < NCC.Count - 1)
                NCC.Position += 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            NCC.Position = NCC.Count - 1;
        }
    }
}