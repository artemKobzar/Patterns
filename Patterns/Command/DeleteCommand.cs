using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class DeleteCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem item)
        {
            order.Remove(order.Where(x => x.Name == item.Name).First());
        }
    }
}
