using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWD.Moduls
{
    class XLTHELOAI: XLBANG
    {
        public XLTHELOAI() : base("THELOAISACH") { }
        public XLTHELOAI(string pQuery) : base("THELOAISACH", pQuery) { }
    }
}
