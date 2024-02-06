using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class AddCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem item)
        {
            order.Add(item);
        }
    }
}
