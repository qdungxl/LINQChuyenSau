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
    public partial class DelegateAndExtensionMethod : Form
    {
        public DelegateAndExtensionMethod()
        {
            InitializeComponent();
        }

        private void DelegateAndExtensionMethod_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                lsbSo.Items.Add(i);
            }
        }

        private void btnToChan_Click(object sender, EventArgs e)
        {
            lsbSo.ToSoTrongListBox(x => x % 2 == 0);
        }

        private void btnToSoLe_Click(object sender, EventArgs e)
        {
            lsbSo.ToSoTrongListBox(x => x % 2 != 0);
        }

        private void btnToNguyenTo_Click(object sender, EventArgs e)
        {
            lsbSo.ToSoTrongListBox(x => x.IsPrime());
        }
    }
}
