using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Guitar : Instrument
    {
        public void PlaySound()
        {
            Console.WriteLine("*guitar sounds*");
        }
    }
}
