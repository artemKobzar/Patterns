using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    public class Bios
    {
        public void CheckParams()
        {
            Console.WriteLine("Check parameters in the BIOS");
        }
    }
}
