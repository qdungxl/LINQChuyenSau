using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocForeach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            List<int> dsInt = new List<int>();
            Random rd = new Random();
            int n = int.Parse(txtN.Text);
            for(int i =0; i < n; i++)
            {
                dsInt.Add(rd.Next(100));
            }
            lstN.Items.Clear();
            dsInt.ForEach(x => { lstN.Items.Add(x); });
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham() { Ma = txtMa.Text, Ten = txtTen.Text };
            dsSP.Add(sp);
            HienThiSanPham();
        }
        public void HienThiSanPham()
        {
            lvSanPham.Items.Clear();
            dsSP.ForEach(x => { HienThi1SanPham(x); });
        }
        public void HienThi1SanPham( SanPham sp)
        {
            ListViewItem lvi = new ListViewItem(sp.Ma);
            lvi.SubItems.Add(sp.Ten);
            lvSanPham.Items.Add(lvi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
