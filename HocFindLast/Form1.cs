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
    }
}
