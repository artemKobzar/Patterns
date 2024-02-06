using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class ClientAdapter
    {
        public void UseAdapter()
        {
            Console.WriteLine("Select the currency which you want to exchange (usd,euro) :");
            var currency = Console.ReadLine();
            Console.WriteLine("Enter the amount for exchange:");
            float sum = Convert.ToSingle(Console.ReadLine());
            IExchange money = new Money(sum);
            switch (currency)
            {
                case "usd":
                    float k = 38.75f;
                    IExchange hrnUsd = new AdapterHryvna(sum, k);
                    Console.WriteLine($"You exchange {money.Exchange()} '$' and get {hrnUsd.Exchange()} hryvnias");
                    break;
                case "euro":
                    float m = 43.10f;
                    IExchange hrnEuro = new AdapterHryvna(sum, m);
                    Console.WriteLine($"You exchange {money.Exchange()} 'Є' and get {hrnEuro.Exchange()} hryvnias");
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }
        }
    }
}
