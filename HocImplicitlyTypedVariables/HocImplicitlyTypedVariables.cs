using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocImplicitlyTypedVariables
{
    public partial class HocImplicitlyTypedVariables : Form
    {
        public HocImplicitlyTypedVariables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = 113;
            var y = 5.5;
            var z = 7.5f;
            var s = "Obama";
            var d = new DateTime(2022, 3, 26);
            lblMess.Text = y.GetType().ToString();
        }
    }
}
