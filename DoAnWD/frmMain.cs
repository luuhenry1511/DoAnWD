using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//phancode
namespace DoAnWD
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap(this);
            enableControl(-1);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            f.WindowState = FormWindowState.Normal;

        }
        public void enableControl(int maLTK)
        {
            switch (maLTK)
            {
                case 1: //chu tiem
                    btnDangXuat.Enabled = true;
                    btnDangKy.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnThongTinSach.Enabled = true;
                    btnSach.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnNCC.Enabled = true;
                    btnNhapSach.Enabled = true;
                    btnDoanhThu.Enabled = true;
                    break;
                case 2: //Nhan vien bang hang
                    btnDangXuat.Enabled = true;
                    btnDangKy.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnThongTinSach.Enabled = true;
                    btnSach.Enabled = false;
                    btnDonHang.Enabled = true;
                    btnNCC.Enabled = false;
                    btnNhapSach.Enabled = false;
                    btnDoanhThu.Enabled = false;
                    break;
            
                default:
                    btnDangXuat.Enabled = false;
                    btnDangKy.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnThongTinSach.Enabled = false;
                    btnSach.Enabled = false;
                    btnDonHang.Enabled = false;
                    btnNCC.Enabled = false;
                    btnNhapSach.Enabled = false;
                    btnDoanhThu.Enabled = false;
                    break;
            }
        }

    }
}
