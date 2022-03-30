using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTrueForAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            dsInt.Add(int.Parse(txtNhap.Text));
            lstDS.Items.Add(dsInt[dsInt.Count - 1]);
            txtNhap.Text = "";
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.TrueForAll(x => x % 2 != 0);
            if (kq)
            {
                MessageBox.Show("Danh sach toan le");
            }
            else
            {
                MessageBox.Show("Danh sach khong phai toan so le");
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.TrueForAll(x => x % 2 == 0);
            if (kq)
            {
                MessageBox.Show("Danh sach toan chan");
            }
            else
            {
                MessageBox.Show("Danh sach khong phai toan so chan");
            }
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma = "SP1", Ten = "Banh Bao", HanDung = new DateTime(2022, 4, 10) });
            dsSP.Add(new SanPham() { Ma = "SP2", Ten = "Banh Pia", HanDung = new DateTime(2022, 3, 11) });
            dsSP.Add(new SanPham() { Ma = "SP3", Ten = "Banh Man", HanDung = new DateTime(2022, 4, 12) });
            dsSP.Add(new SanPham() { Ma = "SP4", Ten = "Banh Beo", HanDung = new DateTime(2022, 4, 13) });
            dsSP.Add(new SanPham() { Ma = "SP5", Ten = "Banh Duc", HanDung = new DateTime(2022, 4, 14) });
            dsSP.ForEach(x => ShowOneItemOfListOnListView(x));
        }

        private void ShowOneItemOfListOnListView(SanPham x)
        {
            ListViewItem lvi = new ListViewItem(x.Ma);
            lvi.SubItems.Add(x.Ten);
            lvi.SubItems.Add(x.HanDung.ToString("dd/MM/yyyy"));
            lvSanPham.Items.Add(lvi);
        }

        private void btnHanDung_Click(object sender, EventArgs e)
        {
            bool kq = dsSP.TrueForAll(x => x.HanDung.Date >= DateTime.Now.Date);
            if (kq)
            {
                MessageBox.Show("Tat ca con han dung.");
            }
            else
            {
                MessageBox.Show("Co san pham het han su dung.");
            }
        }
    }
}
