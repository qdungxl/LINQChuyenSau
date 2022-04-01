using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocAny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsInt.Add(x);
            lstGiaTri.Items.Clear();
            dsInt.ForEach(gt => lstGiaTri.Items.Add(gt));
            txtGiaTri.Text = "";
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.Any(x => x % 2 == 0);
            if (kq == true)
                MessageBox.Show("Danh sách có chứa số chẵn.");
            else
                MessageBox.Show("Không chứa số chẵn nào cả.");
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSV.Add(new SinhVien() { Ma = "SV1", Ten = "Dung", DiemTrungBinh = 5.5 });
            dsSV.Add(new SinhVien() { Ma = "SV2", Ten = "Tam", DiemTrungBinh = 6.5 });
            dsSV.Add(new SinhVien() { Ma = "SV3", Ten = "An", DiemTrungBinh = 7.5 });
            dsSV.Add(new SinhVien() { Ma = "SV4", Ten = "Duy", DiemTrungBinh = 8.5 });
            dsSV.Add(new SinhVien() { Ma = "SV5", Ten = "Duc", DiemTrungBinh = 9.5 });
            dsSV.Add(new SinhVien() { Ma = "SV6", Ten = "Huy", DiemTrungBinh = 5.6 });
            dataGridView1.DataSource = dsSV;
        }

        private void btnHocBong_Click(object sender, EventArgs e)
        {
            bool kq = dsSV.Any(sv => sv.DiemTrungBinh >= 8);
            if (kq)
                MessageBox.Show("Lop nay co sinh vien duoc hoc bong.");
            else
                MessageBox.Show("Lop nay khong ai duoc hoc bong.");
        }
    }
}
