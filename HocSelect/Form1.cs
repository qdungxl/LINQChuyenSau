using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSelect
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
            dsSV.Add(new SinhVien() { Ma = "SV1", Ten = "Mai Quoc Dung", Email = "maiqucodung95@gmail.com" });
            dsSV.Add(new SinhVien() { Ma = "SV2", Ten = "Mai Quoc Huy", Email = "maiqucoduy95@gmail.com" });
            dsSV.Add(new SinhVien() { Ma = "SV3", Ten = "Mai Quoc Hieu", Email = "maiqucohieu95@gmail.com" });
            dsSV.Add(new SinhVien() { Ma = "SV4", Ten = "Mai Quoc Duy", Email = "maiqucoduy95@gmail.com" });
            dsSV.Add(new SinhVien() { Ma = "SV5", Ten = "Mai Quoc Hung", Email = "maiquchung95@gmail.com" });
            dsSV.Add(new SinhVien() { Ma = "SV6", Ten = "Mai Quoc Tuan", Email = "maiqucotuan95@gmail.com" });
            dsSV.Add(new SinhVien() { Ma = "SV7", Ten = "Mai Quoc Anh", Email = "maiqucoanh95@gmail.com" });
            lvGoc.Items.Clear();
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
            lvGoc.Items.Add(lvi);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var dsLoc = dsSV.Select(x => new { x.Ma, x.Ten }).ToList();
            dataGridView1.DataSource = dsLoc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsLoc = (from x in dsSV select new { x.Ma, x.Ten }).ToList();
            dataGridView1.DataSource = dsLoc;
        }
    }
}
