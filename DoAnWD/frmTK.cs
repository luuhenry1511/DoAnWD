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
    
    public partial class frmTK : Form
    {
        public string Thang;
        public frmTK()
        {
            InitializeComponent();
        }

        private void frmTK_Load(object sender, EventArgs e)
        {
            var query = "SELECT HOADON.MaHD, SUM(CTHD.Soluong) AS SL, HOADON.NgayLap, SUM(CTHD.Soluong * SACH.DonGia) AS ThanhTien " +
                    "FROM CTHD INNER JOIN HOADON ON CTHD.MaHD = HOADON.MaHD INNER JOIN" +
             " SACH ON CTHD.MaSach = SACH.MaSach" +
             " where MONTH(HOADON.NgayLap)= " + Thang +
                " GROUP BY HOADON.MaHD, HOADON.NgayLap ";
                
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG._cnn);
            try
            {
                DataTable tblData = new DataTable();
                da.Fill(tblData);
                rptThongKe rpt = new rptThongKe();
                rpt.SetDataSource(tblData);
                crvTK.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
