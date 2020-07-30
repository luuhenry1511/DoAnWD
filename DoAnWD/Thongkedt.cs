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

namespace DoAnWD
{
    public partial class Thongkedt : DevExpress.XtraEditors.XtraForm
    {
        
        public Thongkedt()
        {
            InitializeComponent();
        }

        private void Thongkedt_Load(object sender, EventArgs e)
        {
            cboThang.Items.Add("1");
            cboThang.Items.Add("2");
            cboThang.Items.Add("3");
            cboThang.Items.Add("4");
            cboThang.Items.Add("5");
            cboThang.Items.Add("6");
            cboThang.Items.Add("7");
            cboThang.Items.Add("8");
            cboThang.Items.Add("9");
            cboThang.Items.Add("10");
            cboThang.Items.Add("11");
            cboThang.Items.Add("12");

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frmTK f = new frmTK();
            f.Thang = cboThang.Text;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}