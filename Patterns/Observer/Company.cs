using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class Company : IObserver
    {
        public string Name { get; set; }
        public IObservable _observable;
        public Company(IObservable observable)
        {
            _observable = observable;
            _observable.AddObserver(this);
        }
        public void Update(object obj)
        {
            Console.WriteLine($"Company {Name} got the message: \n {obj}");
        }
        public void Unsubscribe()
        {
            _observable.DeleteObserver(this);
        }
    }
}
