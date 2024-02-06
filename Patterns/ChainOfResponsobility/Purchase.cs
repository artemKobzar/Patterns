using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsobility
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public Purchase(int id, string name, double price, int amount)
        {
            Id = id; 
            Name = name; 
            Price = price; 
            Amount = amount;
        }
    }
}
