using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSkip
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
            lstDSGoc.Items.Clear();
            dsInt.ForEach(x =>
            {
                lstDSGoc.Items.Add(x);
            });
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSkip.Text);
            var dsMoi = dsInt.Skip(n).ToList();
            lstDSSkip.Items.Clear();
            dsMoi.ForEach(x => lstDSSkip.Items.Add(x));
        }
    }
}
