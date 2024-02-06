using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class SecondLevel : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Letting down to first level");
            elevator.ElevatorState = new FirstLevel();
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("The highest level");
        }
    }
}
