using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnWD.Moduls;

namespace DoAnWD
{
    public partial class InHD : Form
    {
        public string MaHD;
        public InHD()
        {
            InitializeComponent();
        }

        private void InHD_Load(object sender, EventArgs e)
        {
            var query = "SELECT HOADON.MaHD, HOADON.TenKH, HOADON.MaNV, HOADON.NgayLap, SACH.TenSach, CTHD.Soluong, SACH.DonGia, SACH.DonGia * CTHD.Soluong AS ThanhTien"+
                " FROM CTHD INNER JOIN HOADON ON CTHD.MaHD = HOADON.MaHD INNER JOIN " +
             "SACH ON CTHD.MaSach = SACH.MaSach where HOADON.MaHD = '" + MaHD + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG._cnn);
            try
            {
                DataTable tblData = new DataTable();
                da.Fill(tblData);
                rptHoaDon rpt = new rptHoaDon();
                rpt.SetDataSource(tblData);
                crvHD.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
