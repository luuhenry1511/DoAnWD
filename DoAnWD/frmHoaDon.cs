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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public static string cnnStr = "Data Source=DESKTOP-RD7GGH3\\SQLEXPRESS;Initial Catalog=DOAN_WD;Integrated Security=True";
        private static SqlConnection _cnn;
        internal string manv;
        XLCTHD tblCTHD;
        XLHOADON tblHOADON;
        BindingManagerBase bindCTHD, bindHD;
        SqlDataAdapter daHD, daCTHD;
        bool capnhat = false;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void enaButton()
        {
            btnLapHoaDon.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            dgvData.Enabled = capnhat;
            gThongTin.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            dateNgayLap.Enabled = capnhat;
            txtNhanVienLap.Enabled = false;
            txtMaHD.Enabled = capnhat;
            txtKhachHang.Enabled = capnhat;
        }
        private void simpleButton2_Click(object sender, EventArgs e)        //btn Huy
        {
            bindCTHD.CancelCurrentEdit();
            tblCTHD.RejectChanges();
            tblHOADON.RejectChanges();

            capnhat = false;
            enaButton();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            daCTHD = new SqlDataAdapter("Select * from CTHD", cnnStr);
            daHD = new SqlDataAdapter("Select * From HOADON", cnnStr);
            dateNgayLap.Value = DateTime.Now;
            tblCTHD = new XLCTHD();
            tblHOADON = new XLHOADON();

            SqlCommandBuilder cmdHD = new SqlCommandBuilder(daHD); //Tao cau noi de cap nhat xuong CSDL
            SqlCommandBuilder cmdCTHD = new SqlCommandBuilder(daCTHD); //

            manv = txtNhanVienLap.Text;
            addcol();
            loadgdvDatachuan();
            bindHD = this.BindingContext[tblHOADON];
            dateNgayLap.DataBindings.Add("text", tblCTHD, "NgayLap", true);
            txtNhanVienLap.DataBindings.Add("text", tblCTHD, "MaNV", true);
            txtMaHD.DataBindings.Add("text", tblCTHD, "MaHD", true);
            txtKhachHang.DataBindings.Add("text", tblCTHD, "TenKH", true);
            txtMaSach.DataBindings.Add("text", tblCTHD, "MaSach", true);
            nudSoLuong.DataBindings.Add("value", tblCTHD, "Soluong", true);
            txtTongTien.DataBindings.Add("text", tblCTHD, "Tong", true);

            enaButton();

        }

        private void loadgdvDatachuan()
        {
            
            bindCTHD = this.BindingContext[tblCTHD];
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = tblCTHD;
        }

        private void addcol()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblCTHD, tblHOADON });
            //tao qh
            DataRelation qh = new DataRelation("FRK_CTHD_HD", tblHOADON.Columns["MaHD"], tblCTHD.Columns["MaHD"]);
            ds.Relations.Add(qh);
            //tao cot phu
            DataColumn cot_MaNV = new DataColumn("MaNV", Type.GetType("System.String"), "Parent(FRK_CTHD_HD).MaNV");
            tblCTHD.Columns.Add(cot_MaNV);

            DataColumn cot_TenKH = new DataColumn("TenKH", Type.GetType("System.String"), "Parent(FRK_CTHD_HD).TenKH");
            tblCTHD.Columns.Add(cot_TenKH);

            DataColumn cot_NgayLap = new DataColumn("NgayLap", Type.GetType("System.String"), "Parent(FRK_CTHD_HD).NgayLap");
            tblCTHD.Columns.Add(cot_NgayLap);
        }
        private void loadgdvData()
        {

            if (_cnn == null)
                _cnn = new SqlConnection(cnnStr);
            _cnn.Open();
            SqlCommand cmd = new SqlCommand("exec ProSelectCTHD "+ txtMaHD.Text +"",_cnn);
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(data);
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = data;

            _cnn.Close();
    
        }

    private void btnTempt_Click(object sender, EventArgs e)
    {
        loadgdvData();
    }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enaButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            bindCTHD.EndCurrentEdit();         
            bindHD.EndCurrentEdit();
            daCTHD.Update(tblCTHD);
            daHD.Update(tblHOADON);
            tblCTHD.AcceptChanges();
            MessageBox.Show("Cap nhat thanh cong!!");

            capnhat = false;
            enaButton();
        }
    }
}