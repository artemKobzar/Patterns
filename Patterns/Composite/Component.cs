using Patterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public abstract class Component
    {
        protected static int _tabs = -1;
        public string _name;
        public Component(string name)
        {
            _name = name;
        }
        public abstract void Add(Component component);
        public abstract void Delete(Component component);
        public abstract void Display();

    }
}
