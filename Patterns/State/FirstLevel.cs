using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class FirstLevel : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Letting down to zero level");
            elevator.ElevatorState = new ZeroLevel();
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Lifting to second level");
            elevator.ElevatorState = new SecondLevel();
        }
    }
}
