using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    public class User
    {
        public void UseComputer(PC computer)
        {
            computer.TurnOn();
        }
        public void StopComputer(PC computer)
        {
            computer.TurnOff(); 
        }
    }
}
