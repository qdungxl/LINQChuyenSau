using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocWhere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSV.Add(new SinhVien() { Ma = "SV1", Ten = "Mai Quoc Dung", Email = "maiqucodung95@gmail.com", Phone = "090111222" });
            dsSV.Add(new SinhVien() { Ma = "SV2", Ten = "Mai Quoc Huy", Email = "maiqucoduy95@gmail.com", Phone = "090111333" });
            dsSV.Add(new SinhVien() { Ma = "SV3", Ten = "Mai Quoc Hieu", Email = "maiqucohieu95@gmail.com", Phone = "090111444" });
            dsSV.Add(new SinhVien() { Ma = "SV4", Ten = "Mai Quoc Duy", Email = "maiqucoduy95@gmail.com", Phone = "090111555" });
            dsSV.Add(new SinhVien() { Ma = "SV5", Ten = "Mai Quoc Hung", Email = "maiquchung95@gmail.com", Phone = "090111666" });
            dsSV.Add(new SinhVien() { Ma = "SV6", Ten = "Mai Quoc Tuan", Email = "maiqucotuan95@gmail.com", Phone = "090111777" });
            dsSV.Add(new SinhVien() { Ma = "SV7", Ten = "Mai Quoc Anh", Email = "maiqucoanh95@gmail.com", Phone = "090111888" });
            dsSV.ForEach(x =>
            {
                ShowOneSinhVienOnListView(x);
            });
        }

        private void ShowOneSinhVienOnListView(SinhVien x)
        {
            ListViewItem lvi = new ListViewItem(x.Ma);
            lvi.SubItems.Add(x.Ten);
            lvi.SubItems.Add(x.Email);
            lvi.SubItems.Add(x.Phone);
            lvGoc.Items.Add(lvi);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var dsLoc = dsSV.Where(sv => sv.Phone.EndsWith(txtDauSo.Text)).ToList();
            dgvSinhVien.DataSource = dsLoc;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            var dsLoc = (from sv in dsSV where sv.Phone.EndsWith(txtDauSo.Text) select sv).ToList();
            dgvSinhVien.DataSource = dsLoc;
        }
    }
}
