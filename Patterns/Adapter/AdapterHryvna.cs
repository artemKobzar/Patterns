using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class AdapterHryvna: Hryvna, IExchange
    {
        public float _k;
        public AdapterHryvna(float amount, float k) : base(amount) { _k = k; }
        float IExchange.Exchange() 
        { 
            return base.Exchange()*_k; 
        }
    }
}
