using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class MenuItem
    {
        public string Name { get; set; }
        //public string Description { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public double Total {  get; set; }
        public MenuItem(string name, int amount, double price)
        {
            Name = name;
            //Description = description;
            Amount = amount;
            Price = price;
            Total = Price*Amount;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Amount: {Amount.ToString()}");
            Console.WriteLine($"Price: {Price.ToString()}$");
            Console.WriteLine($"Total: {Total.ToString()}$");
        }
    }
}
