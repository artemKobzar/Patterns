using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public abstract class CarInsurance
    {
        public decimal discountRatio;
        public string NameOwner { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int YearProdaction { get; set; }
        private readonly InsuranceDiscount _discount;
        public CarInsurance(string nameOwner, string carBrand, string carModel, int yearProdaction, InsuranceDiscount discount)
        {
            NameOwner = nameOwner;
            CarBrand = carBrand;
            CarModel = carModel;
            YearProdaction = yearProdaction;
            _discount = discount;
        }
        public decimal CalculateInsurance()
        {

            var carAge = DateTime.Now.Year - YearProdaction;

            if (carAge > 5 && carAge < 10) 
            {
                discountRatio = 1.15m;
            }
            else if (carAge >=10)
            {
                discountRatio = 1;
            }
            else if (carAge < 5)
            {
                discountRatio = 1.40m;
            }
            
            decimal normalPrice = GetInsurance();
            decimal discountAmount = normalPrice * (_discount.GetDiscount() * discountRatio / 100m);
            return normalPrice - discountAmount;
        }
        protected abstract decimal GetInsurance();
    }
}
