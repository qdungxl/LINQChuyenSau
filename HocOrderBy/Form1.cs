using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocOrderBy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        Random rd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i =0; i < int.Parse(txtN.Text); i++)
            {
                dsInt.Add(rd.Next(100));
            }
            lstDS.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstDS.Items.Add(x);
            });
        }

        private void btnTangDan_Click(object sender, EventArgs e)
        {
            dsInt = dsInt.OrderBy(x => x).ToList();
            lstDS.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstDS.Items.Add(x);
            });
        }

        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            dsInt = dsInt.OrderByDescending(x => x).ToList();
            lstDS.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstDS.Items.Add(x);
            });
        }

        private void btnTangDanC2_Click(object sender, EventArgs e)
        {
            var ds = from x in dsInt orderby x select x;
            dsInt = ds.ToList();
            lstDS.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstDS.Items.Add(x);
            });
        }

        private void btnGiamDanC2_Click(object sender, EventArgs e)
        {
            var ds = from x in dsInt orderby x descending select x;
            dsInt = ds.ToList();
            lstDS.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstDS.Items.Add(x);
            });
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSV.Add(new SinhVien() { Ma = 1, Ten = "Binh" });
            dsSV.Add(new SinhVien() { Ma = 1, Ten = "An" });
            dsSV.Add(new SinhVien() { Ma = 1, Ten = "Phan" });
            dsSV.Add(new SinhVien() { Ma = 2, Ten = "Tam" });
            dsSV.Add(new SinhVien() { Ma = 3, Ten = "Dung" });
            dsSV.Add(new SinhVien() { Ma = 4, Ten = "Qui" });
            lvSanPham.Items.Clear();
            dsSV.ForEach(x =>
            {
                ShowOneItemOfSinhVienOnListView(x);
            });
        }

        private void ShowOneItemOfSinhVienOnListView(SinhVien x)
        {
            ListViewItem lvi = new ListViewItem(x.Ma+"");
            lvi.SubItems.Add(x.Ten);
            lvSanPham.Items.Add(lvi);
        }

        private void btnTenTangDan_Click(object sender, EventArgs e)
        {
            dsSV = dsSV.OrderBy(sv => sv.Ten).ToList();
            lvSanPham.Items.Clear();
            dsSV.ForEach(x =>
            {
                ShowOneItemOfSinhVienOnListView(x);
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsSV = dsSV.OrderByDescending(sv => sv.Ten).ToList();
            lvSanPham.Items.Clear();
            dsSV.ForEach(x =>
            {
                ShowOneItemOfSinhVienOnListView(x);
            });
        }

        private void btnTangDanQuery_Click(object sender, EventArgs e)
        {
            var ds = from sv in dsSV orderby sv.Ten select sv;
            dsSV = ds.ToList();
            lvSanPham.Items.Clear();
            dsSV.ForEach(x =>
            {
                ShowOneItemOfSinhVienOnListView(x);
            });
        }

        private void btnGiamDanQuery_Click(object sender, EventArgs e)
        {
            var ds = from sv in dsSV orderby sv.Ten descending select sv;
            dsSV = ds.ToList();
            lvSanPham.Items.Clear();
            dsSV.ForEach(x =>
            {
                ShowOneItemOfSinhVienOnListView(x);
            });
        }

        private void btnPhucHop_Click(object sender, EventArgs e)
        {
            dsSV = dsSV.OrderByDescending(sv => sv.Ten).OrderBy(sv => sv.Ma).ToList();
            lvSanPham.Items.Clear();
            dsSV.ForEach(x =>
            {
                ShowOneItemOfSinhVienOnListView(x);
            });
        }
    }
}
