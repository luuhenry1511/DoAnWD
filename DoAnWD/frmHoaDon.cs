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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        internal string manv;
        XLCTHD tblCTHD;
        XLHOADON tblHOADON;
        BindingManagerBase HOADON;
        bool capnhat = false;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void enaButton()
        {
            btnLapHoaDon.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            dgvData.Enabled = !capnhat;
            gThongTin.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuyHoaDon.Enabled = capnhat;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dateNgayLap.DataBindings.Add("text", tblHOADON, "NgayLap", true);
            txtKhachHang.DataBindings.Add("text", tblHOADON, "TenKH", true);
            txtNhanVienLap.DataBindings.Add("text", tblHOADON, "MaNV", true);
            tblCTHD = new XLCTHD();
            dateNgayLap.Value = DateTime.Now;
            loadgdvData();
            manv = txtNhanVienLap.Text;
            HOADON = this.BindingContext[tblHOADON];
        }

        private void loadgdvData()
        {
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = tblCTHD;
        }


    }
}