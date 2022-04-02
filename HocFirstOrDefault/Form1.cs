using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFirstOrDefault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> dsChuoi = new List<string>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            dsChuoi.Add(txtNhap.Text);
            lstString.Items.Clear();
            dsChuoi.ForEach(s => lstString.Items.Add(s));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string kq = dsChuoi.FirstOrDefault(s => s == txtTim.Text);
            MessageBox.Show(kq);
        }
        List<SanPham> dsSP = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP = new List<SanPham>();
            dsSP.Add(new SanPham() { Ma = "SP1", Ten = "Coca", Gia = 12 });
            dsSP.Add(new SanPham() { Ma = "SP2", Ten = "Pepsi", Gia = 13 });
            dsSP.Add(new SanPham() { Ma = "SP3", Ten = "Fanta", Gia = 14 });
            dsSP.Add(new SanPham() { Ma = "SP4", Ten = "Olong", Gia = 15 });
            dsSP.Add(new SanPham() { Ma = "SP5", Ten = "Kocha", Gia = 16 });
            dsSP.Add(new SanPham() { Ma = "SP6", Ten = "Cha", Gia = 17 });
            gvSanPham.DataSource = dsSP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanPham sp = dsSP.FirstOrDefault(x=>x.Gia>16);
            if(sp!=null)
            {
                txtMa.Text = sp.Ma;
                txtTen.Text = sp.Ten;
                txtGia.Text = sp.Gia + "";
            }
        }
    }
}
