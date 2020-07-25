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
        DataTable tblSACH, tblHOADON, tblCTHD;
        SqlDataAdapter daHD, daCTHD, daS;
        BindingManagerBase bindHD, bindCTHD;
        bool capnhat;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void enaButton()
        {
            btnLapHoaDon.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            dgvCTHD.Enabled = capnhat;
            gThongTin.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            dateNgayLap.Enabled = capnhat;
            txtNhanVienLap.Enabled = false;
            txtMaHD.Enabled = capnhat;
            txtKhachHang.Enabled = capnhat;
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            tblCTHD = new DataTable();
            tblHOADON = new DataTable();
            tblSACH = new DataTable();
            daCTHD = new SqlDataAdapter("Select * from CTHD", XLBANG._cnn);
            daHD = new SqlDataAdapter("Select * from HOADON", XLBANG._cnn);
            daS= new SqlDataAdapter("Select * from SACH", XLBANG._cnn);
            try
            {
                daCTHD.Fill(tblCTHD);
                daHD.Fill(tblHOADON);
                daS.Fill(tblSACH);

                //TAO CAU NOI DE CAP NHAT XUONG CSDL
                SqlCommandBuilder cmdHD = new SqlCommandBuilder(daHD);
                SqlCommandBuilder cmdCTHD = new SqlCommandBuilder(daCTHD);
            }catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadSACH();
            addcolCTHD();
            loadHD();
            loadCTHD();
        }

        private void loadHD()
        {
            bindHD = this.BindingContext[tblHOADON];
            txtMaHD.DataBindings.Add("text", tblHOADON, "MaHD", true);
            dateNgayLap.DataBindings.Add("text", tblHOADON, "NgayLap", true);
            txtNhanVienLap.DataBindings.Add("text", tblHOADON, "MaNV", true);
            bindHD.PositionChanged += new EventHandler(bdHD_PositionChanged);
        }
        private void bdHD_PositionChanged(object sender, EventArgs e)
        {
            tblCTHD.DefaultView.RowFilter = "MaHD= '" + txtMaHD.Text + "'";
            int s = 0;
            foreach (DataRowView r in tblCTHD.DefaultView)
            {
                s += int.Parse(r["ThanhTien"].ToString());
            }
            txtTongTien.Text = s.ToString();
        }

        private void loadCTHD()
        {
            bindCTHD = this.BindingContext[tblCTHD];
            dgvCTHD.AutoGenerateColumns = false;
            dgvCTHD.DataSource = tblCTHD;
        }

        private void loadSACH()
        {
            cbSach.DataSource = tblSACH;
            cbSach.ValueMember = "MaSach";
            cbSach.DisplayMember = "TenSach";
            cbSach.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSach.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSach.SelectedIndex = -1; //bo chon sach
        }

        private void addcolCTHD()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblSACH, tblCTHD });
            //tao qh
            DataRelation qh = new DataRelation("FRK_SACH_CTHD", tblSACH.Columns["MaSach"], tblCTHD.Columns["MaSach"]);
            ds.Relations.Add(qh);
            //tao cot phu
            DataColumn cot_TenSach = new DataColumn("TenSach", Type.GetType("System.String"), "Parent(FRK_SACH_CTHD).TenSach");
            tblCTHD.Columns.Add(cot_TenSach);

            DataColumn cot_DonGia = new DataColumn("DonGia", Type.GetType("System.String"), "Parent(FRK_SACH_CTHD).DonGia");
            tblCTHD.Columns.Add(cot_DonGia);

            DataColumn cot_ThanhTien = new DataColumn("ThanhTien", Type.GetType("System.String"), "Parent(FRK_SACH_CTHD).DonGia*SoLuong");
            tblCTHD.Columns.Add(cot_ThanhTien);
        }




        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTHD.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindHD.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (bindHD.Position > 0)
                bindHD.Position -= 1;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            string std = string.Format("MaHD like '%{0}%'", txtNhap.Text);
            tblCTHD.DefaultView.RowFilter = std;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bindHD.Position < bindHD.Count - 1)
                bindHD.Position += 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindHD.Position = bindHD.Count - 1;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enaButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


        }
    }
}