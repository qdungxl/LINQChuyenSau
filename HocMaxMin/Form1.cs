using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocMaxMin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        Random rd = new Random();
        private void btnTao_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsInt = new List<int>();
            for(int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstInt.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstInt.Items.Add(x);
            });
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So lon nhat = " + dsInt.Max());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So nho nhat = " + dsInt.Min());
        }
    }
}
