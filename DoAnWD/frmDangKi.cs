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
    public partial class frmDangKi : DevExpress.XtraEditors.XtraForm
    {
        
        XLNHANVIEN tblNHANVIEN;
        XLLOAITK tblLOAITK;

        BindingManagerBase NV;
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

            tblNHANVIEN = new XLNHANVIEN();
            tblLOAITK = new XLLOAITK();
            loadcboLoaiTK();
            txtUsername.DataBindings.Add("text", tblNHANVIEN, "UserName", true);
            cboLoaiTK.DataBindings.Add("SelectedValue", tblNHANVIEN, "MaLTK", true);
            txtMatKhau.DataBindings.Add("text", tblNHANVIEN, "Password", true);

            NV= this.BindingContext[tblNHANVIEN];
        }



        private void loadcboLoaiTK()
        {
            cboLoaiTK.DataSource = tblLOAITK;
            cboLoaiTK.DisplayMember = "TenLTK";
            cboLoaiTK.ValueMember = "MaLTK";
            cboLoaiTK.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboLoaiTK.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu phải trùng khớp nhau!");
            }
            else
            {
                NV.EndCurrentEdit();
                tblNHANVIEN.ghi();
                MessageBox.Show("Đăng ký tài khoản thành công!");
            }

        }

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {
            string std2 = string.Format("TenNV like '%{0}%'", txtNhanVien.Text);
            tblNHANVIEN.DefaultView.RowFilter = std2;
        }

        private void checkBoxhienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxhienmk.Checked) txtMatKhau.UseSystemPasswordChar = false;

            else txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}