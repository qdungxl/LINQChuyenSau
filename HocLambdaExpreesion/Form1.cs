using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLambdaExpreesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int ChangeInt(int x);
        public int Tang2(int x)
        {
            return x + 2;
        }
        public delegate int TongDelegate(int x, int y);
        private void btnTest_Click(object sender, EventArgs e)
        {
            ChangeInt d1 = new ChangeInt(Tang2);
            ChangeInt d2 = ((int x) => x + 2);
            ChangeInt d3 = x => x + 2;
            ChangeInt d4 = delegate (int x)
            {
                return x + 2;
            };
            //label1.Text = d3(100) + "";
            TongDelegate d5 = (x, y) => x + y;
            //label1.Text = d5(3, 4) + "";
            TongDelegate d6 = (x, y) => x - y;
            label1.Text = d6(3, 4) + "";
        }
    }
}
