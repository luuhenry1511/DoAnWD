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
        int vitri;
        internal string maNV;

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitri = tabControlMain.SelectedIndex;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            frmDangNhap f = new frmDangNhap(this);
            f.ShowDialog();
        }

    
        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("frmSach");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmSach f = new frmSach();
                TabPage p = new TabPage(f.Text);
                p.Name = "frmSach";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControlMain.TabPages.RemoveAt(vitri);
        }


        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("Quản lí nv");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmNhanVien f = new frmNhanVien();
                TabPage p = new TabPage(f.Text);
                p.Name = "Quản lí nv";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;
                
                f.Show();
            }
        }

        private void btnNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("Quản lí ncc");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmNhaCungCap f = new frmNhaCungCap();
                TabPage p = new TabPage(f.Text);
                p.Name = "Quản lí ncc";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;

                f.Show();
            }
        }
    }
}
