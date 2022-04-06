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
    public partial class frmTimSPTheoDonGiaQuerySyntax : Form
    {
        public frmTimSPTheoDonGiaQuerySyntax()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtGiaMin.Text);
            int max = int.Parse(txtGiaMax.Text);
            CSDL_QLSPDataContext context = new CSDL_QLSPDataContext();
            List<SanPham> dsSP = (from x in context.SanPhams where x.DonGia >= min && x.DonGia <= max select x).ToList();
            lvSanPham.Items.Clear();
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma + "");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                lvSanPham.Items.Add(lvi);
            });
        }
    }
}
