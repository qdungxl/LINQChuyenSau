using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = null;
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            dsInt = new List<int>();
            int n = int.Parse(txtN.Text);
            for(int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            dsInt.ForEach(x => lstInt.Items.Add(x));
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            int take = int.Parse(txtTake.Text);
            var dsKQ = dsInt.Take(take).ToList();
            lstTake.Items.Clear();
            dsKQ.ForEach(x => lstTake.Items.Add(x));
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }
        List<DanhBa> dsDanhBa = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            dsDanhBa = new List<DanhBa>();
            for(int i =0; i<100; i++)
            {
                DanhBa db = new DanhBa();
                db.Ten = "Ten" + i;
                string phone = "090";
                for(int j = 0; j < 7; j++)
                {
                    phone += rd.Next(10);
                }
                db.Phone = phone;
                dsDanhBa.Add(db);
            }
            ShowOneItemOfDanhBa();      
        }
        int skip = 0;
        int take = 10;
        private void ShowOneItemOfDanhBa()
        {
            lvDanhBa.Items.Clear();
            var dsKQ = dsDanhBa.Skip(skip).Take(take).ToList();
            dsKQ.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ten);
                lvi.SubItems.Add(x.Phone);
                lvDanhBa.Items.Add(lvi);
            });
            lblViTri.Text = (skip + 10) + "/" + dsDanhBa.Count;
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if(skip<dsDanhBa.Count-10)
                skip += take;
            ShowOneItemOfDanhBa();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (skip > 0)
                skip -= take;
            ShowOneItemOfDanhBa();
        }

        private void btnVeDau_Click(object sender, EventArgs e)
        {
            skip = 0;
            take = 10;
            ShowOneItemOfDanhBa();
        }

        private void btnVeCuoi_Click(object sender, EventArgs e)
        {
            skip = dsDanhBa.Count - 10;
            take = 10;
            ShowOneItemOfDanhBa();
        }
    }
}
