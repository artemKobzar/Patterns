using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    public class TestHardware
    {
        public void CheckRam()
        {
            Console.WriteLine("Check the RAM condition");
        }
        public void CheckHardDrive()
        {
            Console.WriteLine("Check the harddrive condition");
        }
    }
}
