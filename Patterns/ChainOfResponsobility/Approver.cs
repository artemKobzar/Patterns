using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsobility
{
    public abstract class Approver
    {
        protected Approver _supervisor;
        public void SetSupervisor(Approver supervisor)
        {
            _supervisor = supervisor;
        }
        public abstract void Request(Purchase purchase);
    }
}
