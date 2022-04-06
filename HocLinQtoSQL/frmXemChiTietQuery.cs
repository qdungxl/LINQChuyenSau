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
    public partial class frmXemChiTietQuery : Form
    {
        public frmXemChiTietQuery()
        {
            InitializeComponent();
        }

        private void frmXemChiTietQuery_Load(object sender, EventArgs e)
        {
            CSDL_QLSPDataContext context = new CSDL_QLSPDataContext();
            lstMaSP.Items.Clear();
            var dsMa = context.SanPhams.Select(x => x.Ma);
            foreach (var ma in dsMa)
            {
                lstMaSP.Items.Add(ma);
            }
        }

        private void lstMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMaSP.SelectedIndex == -1)
                return;
            int ma = int.Parse(lstMaSP.Text);
            SanPham sp = LayChiTietSanPham(ma);
            if (sp != null)
            {
                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtDonGia.Text = sp.DonGia + "";
            }
        }

        private SanPham LayChiTietSanPham(int ma)
        {
            CSDL_QLSPDataContext context = new CSDL_QLSPDataContext();
            SanPham sp = (from x in context.SanPhams where x.Ma == ma select x).FirstOrDefault();
            return sp;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimTheoMa.Text == "")
                return;
            int ma = int.Parse(txtTimTheoMa.Text);
            SanPham sp = LayChiTietSanPham(ma);
            if (sp != null)
            {
                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtDonGia.Text = sp.DonGia + "";
            }
        }
    }
}
