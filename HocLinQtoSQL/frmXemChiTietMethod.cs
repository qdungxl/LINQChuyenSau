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
    public partial class frmXemChiTietMethod : Form
    {
        public frmXemChiTietMethod()
        {
            InitializeComponent();
        }

        private void frmXemChiTietMethod_Load(object sender, EventArgs e)
        {
            CSDL_QLSPDataContext context = new CSDL_QLSPDataContext();
            lstSanPham.Items.Clear();
            var dsMa = context.SanPhams.Select(x => x.Ma);
            foreach(var ma in dsMa)
            {
                lstSanPham.Items.Add(ma);
            }
        }

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedIndex == -1)
                return;
            int ma = int.Parse(lstSanPham.Text);
            SanPham sp = LayChiTietSanPham(ma);
            if (sp != null)
            {
                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtDonGia.Text = sp.DonGia + "";
            }
        }
        public SanPham LayChiTietSanPham(int id)
        {
            CSDL_QLSPDataContext context = new CSDL_QLSPDataContext();
            SanPham sp = context.SanPhams.FirstOrDefault(x => x.Ma == id);
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
