using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class InvokerOrder
    {
        private IOrderCommand _command;
        private MenuItem _item;
        private FoodOder _foodOder;
        public InvokerOrder()
        {
            _foodOder = new FoodOder();
        }
        public void SetCommand (int command)
        {
            _command = new CommandFactory().GetCommand (command);
        }
        public void SetItem (MenuItem item)
        {
            _item = item;
        }
        public void ExecuteCommand()
        {
            _foodOder.ExecuteComand(_command, _item);
        }
        public void ShowOrder()
        {
            _foodOder.ShowItems();
        }
    }
}
