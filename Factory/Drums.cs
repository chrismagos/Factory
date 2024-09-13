using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Drums : Instrument
    {
        public void PlaySound()
        {
            Console.WriteLine("Ba Dum tss");
        }
    }
}
