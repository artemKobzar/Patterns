using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public class Direct : Component
    {
        List<Component> discs = new List<Component>();
        public Direct(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            discs.Add(component);
        }

        public override void Delete(Component component)
        {
            if (discs.Count == 0)
            {
                Console.WriteLine("Disc is empty");
            }
            else if (discs.Contains(component))
            {
                discs.Remove(component);
            }
        }

        public override void Display()
        {
            _tabs++;
            Console.WriteLine();
            Console.WriteLine(new string('\t', _tabs) + _name + ":");
            foreach (Component disc in discs)
            {
                disc.Display();
            }
            _tabs--;
        }
    }
}
