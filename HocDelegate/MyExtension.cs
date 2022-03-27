﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate
{
    public static class MyExtension
    {
        public delegate bool HandleFunction(int x);
        public static void ToSoTrongListBox(this ListBox lst, HandleFunction hd)
        {
            lst.SelectedIndex = -1;
            for(int i = 0; i < lst.Items.Count; i++)
            {
                int x = Convert.ToInt32(lst.Items[i]);
                if (hd(x) == true)
                {
                    lst.SelectedIndex = i;
                }
            }
        }
        public static bool IsPrime(this int x)
        {
            int dem = 0;
            for(int i = 1; i<=x; i++)
            {
                if (x % i == 0)
                    dem++;
            }
            return dem == 2;
        }
    }
}
