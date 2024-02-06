using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class Money : IExchange
    {
        private float _amount;
        public Money(float amount)
        {
            _amount = amount;
        }
        public float Exchange()
        {
            return _amount;
        }
    }
}
