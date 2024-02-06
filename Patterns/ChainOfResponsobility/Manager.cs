using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsobility
{
    public class Manager : Approver
    {
        public override void Request(Purchase purchase)
        {
            if(purchase.Price < 500)
            {
                Console.WriteLine($"{GetType().Name} approved purchase");
            }
            else if(_supervisor != null)
            {
                _supervisor.Request(purchase);
            }
        }
    }
}
