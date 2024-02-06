using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Walk : IMoveable
    {
        public int speed = new Random().Next(4, 5);
        public void MoveBy(int distance)
        {
            var x = distance/speed;
            var y = ((double)distance/speed-x)*60;
            Console.WriteLine($"Time to get destination: {x} hours {y} minutes. Your speed is {speed} km/h ");
            //if(x < 0)  { Console.WriteLine($"Time to get destination:  {y} minutes"); }
        }
    }
}
//{ (double)distance / speed}