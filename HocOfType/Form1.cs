﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocOfType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<NhanVien> dsNV = new List<NhanVien>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = null;
            if (chkLaThoiVu.Checked)
                nv = new NhanVienThoiVu();
            else
                nv = new NhanVienChinhThuc();
            nv.Ma = txtMa.Text;
            nv.Ten = txtTen.Text;
            dsNV.Add(nv);
            HienThiLenListView();
        }
        void HienThiLenListView()
        {
            lvGoc.Items.Clear();
            dsNV.ForEach(nv =>
            {
                ListViewItem lvi = new ListViewItem(nv.Ma);
                lvi.SubItems.Add(nv.Ten);
                lvGoc.Items.Add(lvi);
                if (nv is NhanVienChinhThuc)
                    lvi.ForeColor = Color.Blue;
                else if (nv is NhanVienThoiVu)
                    lvi.ForeColor = Color.Red;
            });
        }

        private void btnLocChinhThuc_Click(object sender, EventArgs e)
        {
            var dsCT = dsNV.OfType<NhanVienChinhThuc>().ToList();
            lvLoc.Items.Clear();
            dsCT.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvLoc.Items.Add(lvi);
            });

        }
    }
}
