using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> dsDouble = new List<double>();
        List<SanPham> dsSanPham = null;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            dsDouble.Clear();
            for (int i = 0; i < n; i++)
            {
                double x = Math.Round(rd.NextDouble() * 100, 2);
                dsDouble.Add(x);
            }
            lstN.Items.Clear();
            dsDouble.ForEach(x => lstN.Items.Add(x));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double k = double.Parse(txtTim.Text);
            double kq = dsDouble.Find(x => x == k);
            MessageBox.Show(kq + "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsSanPham = new List<SanPham>();
            dsSanPham.Add(new SanPham() { Ma = "SP1", Ten = "Coca cola", DonGia = 150 });
            dsSanPham.Add(new SanPham() { Ma = "SP2", Ten = "Pepsi", DonGia = 140 });
            dsSanPham.Add(new SanPham() { Ma = "SP3", Ten = "Red bull", DonGia = 140 });
            dsSanPham.Add(new SanPham() { Ma = "SP4", Ten = "caffe", DonGia = 130 });
            dsSanPham.Add(new SanPham() { Ma = "SP5", Ten = "Lipton", DonGia = 160 });
            dsSanPham.Add(new SanPham() { Ma = "SP6", Ten = "Tra chanh", DonGia = 110 });
            HienThiLenLV();
        }

        private void HienThiLenLV()
        {
            dsSanPham.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnTimDonGia_Click(object sender, EventArgs e)
        {
            double gia = double.Parse(txtDonGia.Text);
            SanPham sp = dsSanPham.Find(x => x.DonGia == gia);
            if (sp != null)
            {
                MessageBox.Show("Tim thay SP: " + sp.Ten);
            }
            else
            {
                MessageBox.Show("Khong tim thay");
            }
        }
    }
}
