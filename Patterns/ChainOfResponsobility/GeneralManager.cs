using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsobility
{
    public class GeneralManager : Approver
    {
        public override void Request(Purchase purchase)
        {
            if (purchase.Price < 3500)
            {
                Console.WriteLine($"{GetType().Name}  approved purchase");
            }
            else
            {
                Console.WriteLine($"Purchase request #{purchase.Id} ({purchase.Name}) will be approved on the meeting"); 
            }
        }
    }
}
