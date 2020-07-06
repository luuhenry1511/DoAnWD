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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        frmMain fMain = null;
        XLNHANVIEN tblNhanVien;
        public frmDangNhap(frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DataRow[] r = tblNhanVien.Select("Username='" + txtTenDangNhap.Text + "' and Password = '" + txtMatKhau.Text + "'");
            if (r.Count() > 0)
            {
                frmMain f = (frmMain)this.MdiParent;
                fMain.Text = "Quản lí Nhà Sách - Chào " + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                fMain.enableControl((int)r[0]["MaLTK"]);

                this.Close();
            }
            else
                MessageBox.Show("Sai tên tài khoản và mật khẩu!!!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}