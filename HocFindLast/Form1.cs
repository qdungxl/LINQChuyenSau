using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindLast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> dsNguon = new List<double>();
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            for (int i =0; i < n; i++)
            {
                double x = Math.Round(rd.NextDouble() * 100, 2);
                dsNguon.Add(x);
            }
            lstDS.Items.Clear();
            dsNguon.ForEach(x =>
            {
                lstDS.Items.Add(x);
            });
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double k = double.Parse(txtTim.Text);
            double kq = dsNguon.FindLast(x => x == k);
            txtKQ.Text = kq + "";
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma = "SP1", Ten = "Banh mi", HanDung = new DateTime(2022, 3, 2) });
            dsSP.Add(new SanPham() { Ma = "SP2", Ten = "Banh kem", HanDung = new DateTime(2022, 3, 5) });
            dsSP.Add(new SanPham() { Ma = "SP3", Ten = "Banh trang", HanDung = new DateTime(2022, 3, 7) });
            dsSP.Add(new SanPham() { Ma = "SP4", Ten = "Banh sua", HanDung = new DateTime(2022, 3, 10) });
            dsSP.Add(new SanPham() { Ma = "SP5", Ten = "Banh gao", HanDung = new DateTime(2022, 3, 6) });
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.HanDung.ToString("dd/MM/yyyy"));
                lvSP.Items.Add(lvi);
            });
        }

        private void btnTimNgay_Click(object sender, EventArgs e)
        {
            DateTime ngay = dateTimePicker1.Value;           
            SanPham sp = dsSP.FindLast(x => x.HanDung.Date == ngay.Date);
            if (sp == null)
            {
                MessageBox.Show("Khong tim thay.");
            }
            else
            {
                MessageBox.Show("Tim thay.");
            }
        }
    }
}
