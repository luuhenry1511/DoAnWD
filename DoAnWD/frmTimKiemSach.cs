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
    public partial class frmTimKiemSach : DevExpress.XtraEditors.XtraForm
    {
        XLSACH tblSACH;
        XLTHELOAI tblTHELOAI;
        XLKESACH tblKESACH;
        BindingManagerBase SACH;
        public frmTimKiemSach()
        {
            InitializeComponent();
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            tblSACH = new XLSACH();
            tblTHELOAI = new XLTHELOAI();
            tblKESACH = new XLKESACH();
            LoaddgvDSSach();
            LoadCBOKeSach();
            LoadCBOTheLoai();
            txtMaSach.DataBindings.Add("text", tblSACH, "MaSach", true);
            txtTenSach.DataBindings.Add("text", tblSACH, "TenSach", true);
            cboKeSach.DataBindings.Add("SelectedValue", tblSACH, "KeSach", true);
            cboTheLoai.DataBindings.Add("SelectedValue", tblSACH, "TheLoai", true);
            txtNhaXB.DataBindings.Add("text", tblSACH, "NhaXB", true);
            txtDonGia.DataBindings.Add("text", tblSACH, "DonGia", true);
            nudSoLuong.DataBindings.Add("value", tblSACH, "SoLuong", true);
            txtNamXB.DataBindings.Add("text", tblSACH, "NamXB", true);
            pHinh.DataBindings.Add("Image", tblSACH, "Hinh", true);
            SACH = this.BindingContext[tblSACH];
            gTTSach.Enabled = false;
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
        private void LoaddgvDSSach()
        {
            dgvDSSach.AutoGenerateColumns = false;
            dgvDSSach.DataSource = tblSACH;
        }
        private void txtNamXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            string std = string.Format("TenSach like '%{0}%'", txtNhap.Text);
            tblSACH.DefaultView.RowFilter = std;
            //string std2 = string.Format("NhaXB like '%{0}%'", txtNhap.Text);
            //tblSACH.DefaultView.RowFilter = std2; //
        }
    }
}