using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate
{
    public partial class delegateVsListbox : Form
    {
        public delegateVsListbox()
        {
            InitializeComponent();
        }

        private void delegateVsListbox_Load(object sender, EventArgs e)
        {
            for(int i =0; i <= 20; i++)
            {
                lsbSo.Items.Add(i);
            }
        }

        private void btnToChan_Click(object sender, EventArgs e)
        {
            lsbSo.SelectedIndex = -1;
            for(int i =0; i < lsbSo.Items.Count; i++)
            {
                int x = int.Parse(lsbSo.Items[i].ToString());
                if (x % 2 == 0)
                {
                    lsbSo.SelectedIndex = i;
                }
            }
            
        }
        public bool IsPrime(int x)
        {
            int dem = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                    dem++;
            }
            return dem == 2;
        }

        private void btnToSoLe_Click(object sender, EventArgs e)
        {
            lsbSo.SelectedIndex = -1;
            for (int i = 0; i < lsbSo.Items.Count; i++)
            {
                int x = int.Parse(lsbSo.Items[i].ToString());
                if (x % 2!= 0)
                {
                    lsbSo.SelectedIndex = i;
                }
            }
        }

        private void btnToNguyenTo_Click(object sender, EventArgs e)
        {
            lsbSo.SelectedIndex = -1;
            for (int i =0; i < lsbSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lsbSo.Items[i]);
                if (IsPrime(x))
                {
                    lsbSo.SelectedIndex = i;
                }
            }
        }
    }
}
