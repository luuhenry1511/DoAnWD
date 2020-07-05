using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWD.Moduls
{
    class XLSACH: XLBANG
    {
        public XLSACH() : base("SACH") { }
        public XLSACH(string pQuery) : base("SACH", pQuery) { }
    }
}
