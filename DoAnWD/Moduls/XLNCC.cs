using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWD.Moduls
{
    class XLNCC: XLBANG
    {
        public XLNCC() : base("NCC") { }
        public XLNCC(string pQuery) : base("NCC", pQuery) { }
    }
}
