using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary1;


namespace HocExtensionMethod
{
    public static class MyExtension
    {
        public static int TinhTongTu1ToiN(this int n)
        {
            int sum = 0;
            for (int i = 1; i<=n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static string NoiChuoi(this string s1, string s2)
        {
            return s1 + " " + s2;
        }
        public static int LayGiaTriInt(this TextBox txt)
        {
            int x = 0;
            int.TryParse(txt.Text, out x);
            return x;
        }
        public static void ToMauDo(this Button btn)
        {
            btn.BackColor = Color.Red;
        }
        public static int TinhTuoi(this SinhVien sv)
        {
            return DateTime.Now.Year - sv.NamSinh.Year + 1;
        }
    }
}
