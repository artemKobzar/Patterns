using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class Comprehensive : CarInsurance
    {
        public Comprehensive(string nameOwner, string carBrand, string carModel, int yearProdaction, InsuranceDiscount discount) 
            : base(nameOwner, carBrand, carModel, yearProdaction, discount)
        {
        }

        protected override decimal GetInsurance()
        {
            return 210.00m;
        }
    }
}
