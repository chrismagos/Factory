using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class GuitarFactory : Factory
    {
        public override Instrument createInstrument()
        {
            return new Guitar();
        }
    }
}
