using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsGoc = new List<int>();
        Random rd = new Random();
        List<SanPham> dsSP = new List<SanPham>();
        private void btnTao_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsGoc = new List<int>();
            for(int i =0; i < n; i++)
            {
                dsGoc.Add(rd.Next(100));
            }
            lstGoc.Items.Clear();
            dsGoc.ForEach(x => lstGoc.Items.Add(x));
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<int> dsChan = dsGoc.FindAll(x => x % 2 == 0);
            lstChan.Items.Clear();
            dsChan.ForEach(x => lstChan.Items.Add(x));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma = "SP1", Ten = "Coca", DonGia = 23 });
            dsSP.Add(new SanPham() { Ma = "SP2", Ten = "Pepsi", DonGia = 22 });
            dsSP.Add(new SanPham() { Ma = "SP3", Ten = "Ken", DonGia = 21 });
            dsSP.Add(new SanPham() { Ma = "SP4", Ten = "333", DonGia = 24 });
            dsSP.Add(new SanPham() { Ma = "SP5", Ten = "SaiGon", DonGia = 26 });
            dsSP.Add(new SanPham() { Ma = "SP6", Ten = "Chuoi hot", DonGia = 35 });
            lvSPGoc.Items.Clear();
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                lvSPGoc.Items.Add(lvi);
            });
        }

        private void btnLocSP_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);
            List<SanPham> dsSPTim = dsSP.FindAll(x => x.DonGia >= min && x.DonGia <= max);
            lvSPLoc.Items.Clear();
            dsSPTim.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                lvSPLoc.Items.Add(lvi);
            });
        }
    }
}
