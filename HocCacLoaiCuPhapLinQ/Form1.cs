﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocCacLoaiCuPhapLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrData = { 4, 6, 1, 7, 9, 1, 4, 0 };
        private void btnVD1_Click(object sender, EventArgs e)
        {
            var dsChan = from x in arrData
                         where x % 2 == 0
                         select x;

        }

        private void btnVD3_Click(object sender, EventArgs e)
        {
            var dsChan = arrData.Where(x => x % 2 == 0);
        }

        private void btnVD4_Click(object sender, EventArgs e)
        {
            var dsLe = (from x in arrData
                        where x % 2 != 0
                        select x).OrderByDescending(x => x);
        }
    }
}
