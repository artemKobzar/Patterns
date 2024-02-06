using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class FoodOder
    {
        public List<MenuItem> Items { get; set; }
        public FoodOder()
        {
            Items = new List<MenuItem>();
        }
        public void ExecuteComand (IOrderCommand command, MenuItem item)
        {
            command.Execute(Items, item);
        }
        public void ShowItems()
        {
            foreach(var item in Items)
            {
                item.Display();
                Console.WriteLine("- - - - - - - - - - - - - - -");
            }
        }
    }
}
