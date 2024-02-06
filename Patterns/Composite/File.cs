using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public class MyFile : Component
    {
        public MyFile(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {

        }

        public override void Delete(Component component)
        {

        }

        public override void Display()
        {
            Console.WriteLine(new string('\t',_tabs+2)+_name);
        }
    }
}
