using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class ClientStrategy
    {
        public void UseStrategy()
        {
            while (true)
            {
                Console.WriteLine("Enter the distance (km):");
                var distance = Convert.ToInt32(Console.ReadLine());
                IMoveable moveableByCar = new Car();
                Navigator navigator1 = new Navigator(moveableByCar, distance);

                IMoveable moveByTransport = new Transport();
                Navigator navigator2 = new Navigator(moveByTransport, distance);

                IMoveable moveByWalk = new Walk();
                Navigator navigator3 = new Navigator(moveByWalk, distance);
                Console.WriteLine("Chose how you will move (car, transport, walk) or press ''enter'' to quit:");
                var typeMovable = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(typeMovable))
                    break;

                switch (typeMovable)
                {
                    case "car":
                        navigator1.Move();
                        break;
                    case "transport":
                        navigator2.Move();
                        break;
                    case "walk":
                        navigator3.Move();
                        break;
                    default:
                        Console.WriteLine("Unknown operation");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
