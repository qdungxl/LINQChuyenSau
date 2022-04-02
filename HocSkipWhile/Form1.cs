using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSkipWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = null;
        Random rd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            dsInt = new List<int>();
            int n = int.Parse(txtN.Text);
            for(int i =0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstInt.Items.Clear();
            dsInt.ForEach(x => lstInt.Items.Add(x));
        }

        private void btnSkipWhile_Click(object sender, EventArgs e)
        {
            int SkipWhile = int.Parse(txtDieuKien.Text);
            var dsKQ = dsInt.SkipWhile(k => k > SkipWhile).ToList();
            lstKQ.Items.Clear();
            dsKQ.ForEach(x => lstKQ.Items.Add(x));
        }
    }
}
