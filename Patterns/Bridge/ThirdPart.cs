using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class ThirdPart : CarInsurance
    {
        public ThirdPart(string nameOwner, string carBrand, string carModel, int yearProdaction, InsuranceDiscount discount)
            : base(nameOwner, carBrand, carModel, yearProdaction, discount)
        {
        }

        protected override decimal GetInsurance()
        {
            return 120.00m;
        }
    }
}
