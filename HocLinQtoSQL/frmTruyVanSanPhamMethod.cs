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
    public partial class frmTruyVanSanPhamMethod : Form
    {
        public frmTruyVanSanPhamMethod()
        {
            InitializeComponent();
        }

        private void frmTruyVanSanPhamMethod_Load(object sender, EventArgs e)
        {
            CSDL_QLSPDataContext context = new CSDL_QLSPDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            dataGridView1.DataSource = dsSP;
        }
    }
}
