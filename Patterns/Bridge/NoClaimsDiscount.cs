using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class NoClaimsDiscount : InsuranceDiscount
    {
        public override int GetDiscount()
        {
            return 15;
        }
    }
}
