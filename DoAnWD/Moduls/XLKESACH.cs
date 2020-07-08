using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWD.Moduls
{
    class XLKESACH: XLBANG
    {
        public XLKESACH() : base("KESACH") { }
        public XLKESACH(string pQuery) : base("KESACH", pQuery) { }
    }
}
