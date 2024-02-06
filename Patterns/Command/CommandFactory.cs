using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class CommandFactory
    {
        public IOrderCommand GetCommand (int commandNumber)
        {
           switch(commandNumber)
           {
                case 1:
                    return new AddCommand();
                case 2:
                    return new DeleteCommand();
                case 3:
                    return new ModifyCommand();
                default:
                    return new AddCommand();
           }
        }
    }
}
