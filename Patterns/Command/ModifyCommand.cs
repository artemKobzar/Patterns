using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class ModifyCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem item)
        {
            var orderItem = order.Where(x => x.Name == item.Name).First();
            orderItem.Amount = item.Amount;
        }
    }
}
