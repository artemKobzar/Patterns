using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class ZeroLevel : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("The lowest level");
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Lifting to first level");
            elevator.ElevatorState = new FirstLevel();
        }
    }
}
