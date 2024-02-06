using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class SafetyDriverDiscount : InsuranceDiscount
    {
        public override int GetDiscount()
        {
            return 10;
        }
    }
}
