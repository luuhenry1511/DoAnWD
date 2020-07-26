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
        internal string maNV;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void enaButton()
        {
            btnLapHoaDon.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            dgvCTHD.Enabled = capnhat;
            gThongTin.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            btnThem.Enabled = capnhat;

            dateNgayLap.Enabled = capnhat;
            txtKhachHang.Enabled = capnhat;
            txtNhanVienLap.Enabled = false;
            txtMaHD.Enabled = false; 
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            maNV = txtNhanVienLap.Text;
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

            capnhat = false;
            enaButton();
   
        }

        private void loadHD()
        {
            bindHD = this.BindingContext[tblHOADON];
            txtMaHD.DataBindings.Add("text", tblHOADON, "MaHD", true);
            dateNgayLap.DataBindings.Add("value", tblHOADON, "NgayLap", true);
            txtNhanVienLap.DataBindings.Add("text", tblHOADON, "MaNV", true);
            txtKhachHang.DataBindings.Add("text", tblHOADON, "TenKH", true);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                bindHD.EndCurrentEdit();
                daHD.Update(tblHOADON);
                tblHOADON.AcceptChanges();

                bindCTHD.EndCurrentEdit();
                daCTHD.Update(tblCTHD);
                tblCTHD.AcceptChanges();
                MessageBox.Show("Cập Nhật Thành Công!!!");
                capnhat = false;
                enaButton();
            }
            catch (SqlException ex)
            {
                tblCTHD.RejectChanges();
                tblHOADON.RejectChanges();
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (cbSach.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn quyển sách nào!");
                return;
            }

            int count = tblCTHD.Select("MaHD = '" + txtMaHD.Text + "' and MaSach='" + cbSach.SelectedValue + "'").Count();
            if (count > 0)
            {
                MessageBox.Show("Quyển sách này đã có trong hóa đơn!");
                return;
            }
            DataRow r = tblCTHD.NewRow();
            r["MaSach"] = cbSach.SelectedValue;
            r["MaHD"] = txtMaHD.Text;
            r["SoLuong"] = nudSoLuong.Value;

            tblCTHD.Rows.Add(r);
            bdHD_PositionChanged(sender, e);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bindCTHD.CancelCurrentEdit();
            tblCTHD.RejectChanges();

            bindHD.CancelCurrentEdit();
            tblHOADON.RejectChanges();
            bdHD_PositionChanged(sender, e);
            capnhat = false;
            enaButton();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = tblCTHD.Select("MaHD = '" + txtMaHD.Text + "'");
                foreach (DataRow r in rows)
                    r.Delete();
                daCTHD.Update(tblCTHD);
                tblCTHD.AcceptChanges();
                MessageBox.Show("Đã xóa");
            }
            catch (SqlException ex)
            {
                tblCTHD.RejectChanges();
                tblHOADON.RejectChanges();
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.ColumnIndex==6)
            {
                try {
                        bindCTHD.RemoveAt(bindCTHD.Position);
                        daCTHD.Update(tblCTHD);
                        tblCTHD.AcceptChanges();
                    }
                catch
                {
                    tblCTHD.RejectChanges();
                    MessageBox.Show("Xóa thất bại!");
                }
            }
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
            bindHD.AddNew();
            dateNgayLap.Value = DateTime.Now;
            txtNhanVienLap.Text = maNV;
            txtKhachHang.Text = "Guest";
            try
            {
                SqlCommand cmm = new SqlCommand("Select dbo.fn_CreateMaHD()", XLBANG._cnn);
                XLBANG._cnn.Open();
                txtMaHD.Text = cmm.ExecuteScalar().ToString();
                capnhat = true;
                enaButton();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            XLBANG._cnn.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enaButton();
        }

 
    }
}