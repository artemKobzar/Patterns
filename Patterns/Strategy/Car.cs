using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Car : IMoveable
    {
        public int speed = new Random().Next(45, 65);
        public void MoveBy(int distance)
        {
            var x = distance / speed;
            var y = ((double)distance / speed - x) * 60;
            Console.WriteLine($"Time to get destination: {x} hours {y} minutes. Your speed is {speed} km/h ");
            //Console.WriteLine($"Time to get destination: {(double)distance/speed} hours");
        }
    }
}
