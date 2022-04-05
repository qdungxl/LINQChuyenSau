﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai38_BaiTapRenLuyen_QLSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SanPham> dsSPGoc = new List<SanPham>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Ma = txtMa.Text;
            sp.Ten = txtTen.Text;
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            sp.DonGia = int.Parse(txtDonGia.Text);
            sp.XuatXu = txtXuatXu.Text;
            sp.HanDung = dtpNgayHetHan.Value;
            dsSPGoc.Add(sp);
            XoaDuLieuNhapCu();
            HienThiLenListView(dsSPGoc, lvSauKhiNhap);
        }

        private void XoaDuLieuNhapCu()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtXuatXu.Clear();
            txtMa.Focus();
        }
        void HienThiLenListView(List<SanPham> ds, ListView lv)
        {
            lv.Items.Clear();
            ds.ForEach(sp =>
            {
                HienThi1SanPham(sp, lv);
            });
        }

        private void HienThi1SanPham(SanPham sp, ListView lv)
        {
            ListViewItem lvi = new ListViewItem(sp.Ma);
            lvi.SubItems.Add(sp.Ten);
            lvi.SubItems.Add(sp.SoLuong+"");
            lvi.SubItems.Add(sp.DonGia + "");
            lvi.SubItems.Add(sp.XuatXu);
            lvi.SubItems.Add(sp.HanDung.ToString("dd/MM/yyyy"));
            lv.Items.Add(lvi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvSauKhiNhap.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Phải chọn sản phẩm trước khi xóa.");
                return;
            }
            dsSPGoc.RemoveAt(lvSauKhiNhap.SelectedIndices[0]);
            HienThiLenListView(dsSPGoc, lvSauKhiNhap);
        }

        private void btnXoaXuatXu_Click(object sender, EventArgs e)
        {
            for(int i = dsSPGoc.Count - 1; i >= 0; i--)
            {
                if (string.Compare(dsSPGoc[i].XuatXu, txtTheoXuatXu.Text, true) == 0)
                {
                    dsSPGoc.RemoveAt(i);
                }
            }
            txtTheoXuatXu.Clear();
            HienThiLenListView(dsSPGoc, lvSauKhiNhap);
        }

        private void btnKiemTraCoSPQuaHanKhong_Click(object sender, EventArgs e)
        {
            bool kq = dsSPGoc.Any(sp =>
            {
                return sp.HanDung.Date < DateTime.Now.Date;
            });
            if (kq)
            {
                MessageBox.Show("Kho có sp hết hạn.");
            }
            else
            {
                MessageBox.Show("Kho đạt chuẩn.");
            }
        }

        private void btnXoaToanBoSP_Click(object sender, EventArgs e)
        {
            dsSPGoc.Clear();
            HienThiLenListView(dsSPGoc, lvSauKhiNhap);
        }

        private void btnXoaToanBoSPQuaHan_Click(object sender, EventArgs e)
        {
            dsSPGoc.RemoveAll(sp => sp.HanDung.Date < DateTime.Now.Date);
            HienThiLenListView(dsSPGoc, lvSauKhiNhap);
        }

        private void btnDonGiaCaoNhat_Click(object sender, EventArgs e)
        {
            SanPham sp = dsSPGoc.OrderByDescending(x => x.DonGia).First();
            HienThi1SanPham(sp, lvTimKiem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dsQuaHan = dsSPGoc.Where(x => x.HanDung < DateTime.Now.Date).ToList();
            HienThiLenListView(dsQuaHan, lvTimKiem);
        }

        private void btnSPTrongKhoangAb_Click(object sender, EventArgs e)
        {
            int max = int.Parse(txtb.Text);
            int min = int.Parse(txta.Text);
            var dsTim = (from sp in dsSPGoc where sp.DonGia >= min && sp.DonGia <= max select sp).ToList();
            HienThiLenListView(dsTim, lvTimKiem);
        }
    }
}
