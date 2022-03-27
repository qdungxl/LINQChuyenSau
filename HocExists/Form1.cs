using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocExists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnTaoDanhSach_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            for(int i =0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txtTim.Text);
            bool kq = dsInt.Exists(x => x == k);
            if (kq)
                MessageBox.Show("Có tồn tại.");
            else
                MessageBox.Show("Không tồn tại.");
        }
        List<SanPham> dsSp = new List<SanPham>();
        public void TaoGiaDanhSachSanPham()
        {
            dsSp.Add(new SanPham() { Ma = "SP1", Ten = "Coca" });
            dsSp.Add(new SanPham() { Ma = "SP2", Ten = "Sting" });
            dsSp.Add(new SanPham() { Ma = "SP3", Ten = "Pepsi" });
            dsSp.Add(new SanPham() { Ma = "SP4", Ten = "Redbull" });
            dsSp.Add(new SanPham() { Ma = "SP5", Ten = "Cafe" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoGiaDanhSachSanPham();
            dsSp.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem((lvSanPham.Items.Count + 1) + "");
                lvi.SubItems.Add(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            bool kq = dsSp.Exists(x => x.Ten == txtTimSP.Text);
            if (kq)
                MessageBox.Show("Tim thay SP.");
            else
                MessageBox.Show("Khong tim thay SP.");
        }
    }
}
