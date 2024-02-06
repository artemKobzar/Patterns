using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public class Folder : Component
    {
        List<Component> folders = new List<Component>();
        public Folder(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            folders.Add(component);
        }

        public override void Delete(Component component)
        {
            if (folders.Count == 0)
            {
                Console.WriteLine("Folder is empty");
            }
            else if(folders.Contains(component))
            {
                folders.Remove(component);
            }
        }

        public override void Display()
        {
            _tabs++;
            Console.WriteLine();
            Console.WriteLine(new string('\t',_tabs+1)+_name+":");
            foreach (Component folder in folders) 
            {
                folder.Display();
            }
            _tabs--;
        }
    }
}
