using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocRemoveAll
{
    public class SanPham
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int DonGia { get; set; }
        public string XuatXu { get; set; }
        public override string ToString()
        {
            return Ten;
        }
    }
}
 