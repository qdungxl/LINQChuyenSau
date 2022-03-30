using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocRemoveAll
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
            for (int i =0; i < n; i++)
            {
                dsInt.Add(rd.Next(100));
            }
            lstDS.Items.Clear();
            dsInt.ForEach(x => { lstDS.Items.Add(x); });
        }

        private void btnXoaSoLe_Click(object sender, EventArgs e)
        {
            dsInt.RemoveAll(x => x % 2 != 0);
            lstDS.Items.Clear();
            dsInt.ForEach(x => { lstDS.Items.Add(x); });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma = "SP1", Ten = "Dien thoai SamSung", DonGia = 100, XuatXu = "Han Quoc" });
            dsSP.Add(new SanPham() { Ma = "SP2", Ten = "Dien thoai LG", DonGia = 200, XuatXu = "Han Quoc" });
            dsSP.Add(new SanPham() { Ma = "SP3", Ten = "Dien thoai HTC", DonGia = 300, XuatXu = "Dai Loan" });
            dsSP.Add(new SanPham() { Ma = "SP4", Ten = "Dien thoai RedMi", DonGia = 400, XuatXu = "Trung Quoc" });
            dsSP.Add(new SanPham() { Ma = "SP5", Ten = "Dien thoai Xiaomi", DonGia = 500, XuatXu = "Trung Quoc" });
            lstDS.Items.Clear();
            dsSP.ForEach(x =>
            {
                ShowOneItemOfListOnListView(x);
            });
        }

        private void ShowOneItemOfListOnListView(SanPham x)
        {
            ListViewItem lvi = new ListViewItem(x.Ma);
            lvi.SubItems.Add(x.Ten);
            lvi.SubItems.Add(x.DonGia+"");
            lvi.SubItems.Add(x.XuatXu);
            lvSanPham.Items.Add(lvi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);
            string XuatXu = txtXuatXu.Text;
            dsSP.RemoveAll(x => x.DonGia >= min && x.DonGia <= max && x.XuatXu == XuatXu);
            lvSanPham.Items.Clear();
            dsSP.ForEach(x =>
            {
                ShowOneItemOfListOnListView(x);
            });
        }
    }
}
