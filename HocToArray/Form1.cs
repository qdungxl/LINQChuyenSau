﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocToArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            List<int> dsInt = new List<int>();
            dsInt.AddRange(new int[] { 5, 7, 1, 0, 25 });
            var arr = dsInt.ToArray();
            lblMang.Text = "";
            for(int i=0; i < arr.Length; i++)
            {
                lblMang.Text += arr[i] + " ";
            }
        }
    }
}
