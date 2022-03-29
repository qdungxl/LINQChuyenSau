using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> dsInt = new List<int>();
        Random rd = new Random();
        List<SanPham> dsSP = new List<SanPham>();

        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            for(int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);

            }
            lstNguon.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstNguon.Items.Add(x);
            });
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txtGTTim.Text);
            int kq = dsInt.FindIndex(x=>x==k);
            txtViTriDauTien.Text = kq + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma = "sp1", Ten = "Điện thoại Samsung", XuatXu = "Han Quoc" });
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Điện thoại LG", XuatXu = "Han Quoc" });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "Điện thoại Xiaomi", XuatXu = "Trung Quoc" });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Điện thoại Huwei", XuatXu = "Trung Quoc" });
            dsSP.Add(new SanPham() { Ma = "sp5", Ten = "Điện thoại Sony", XuatXu = "Nhat Ban" });
            lvSanPham.Items.Clear();
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.XuatXu);
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            string xuatxu = txtXuatXu.Text;
            int kq = dsSP.FindIndex(x => x.XuatXu == xuatxu);
            txtViTri.Text = kq + "";
        }
    }
}
