using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class BassFactory : Factory
    {
        public override Instrument createInstrument()
        {
            return new Bass();
        }
    }
}
