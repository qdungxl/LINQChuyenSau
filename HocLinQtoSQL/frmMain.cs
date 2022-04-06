using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLinQtoSQL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTruyVanMethod_Click(object sender, EventArgs e)
        {
            frmTruyVanSanPhamMethod frm = new frmTruyVanSanPhamMethod();
            frm.Show();
        }

        private void btnTimSPMethod_Click(object sender, EventArgs e)
        {
            frmTimSanPhamTheoDonGiaMethodSyntax frm = new frmTimSanPhamTheoDonGiaMethodSyntax();
            frm.Show();
        }

        private void btnTimSPQuery_Click(object sender, EventArgs e)
        {
            frmTimSPTheoDonGiaQuerySyntax frm = new frmTimSPTheoDonGiaQuerySyntax();
            frm.Show();
        }

        private void btnXemChiTietMethod_Click(object sender, EventArgs e)
        {
            frmXemChiTietMethod frm = new frmXemChiTietMethod();
            frm.Show();
        }

        private void btnXemChiTietQuery_Click(object sender, EventArgs e)
        {
            frmXemChiTietQuery frm = new frmXemChiTietQuery();
            frm.Show();
        }
    }
}
