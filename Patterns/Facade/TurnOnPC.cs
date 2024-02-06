using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    public class TurnOnPC
    {
        public void PowerSupply()
        {
            Console.WriteLine("Power supply to the motherboard");
        }
        public void TurnOnVideocard()
        {
            Console.WriteLine("Turn on and check the videocard");
        }
        public void TurnOnSystem()
        {
            Console.WriteLine("Turn on and check the system");
        }
    }
}
