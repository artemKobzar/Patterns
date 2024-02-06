using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class Elevator : IElevatorState
    {
        public IElevatorState ElevatorState { get; set; }
        public Elevator(IElevatorState elevatorState)
        {
            ElevatorState = elevatorState;
        }
        public void Down(Elevator elevator)
        {
            ElevatorState.Down(elevator);
        }

        public void Up(Elevator elevator)
        {
            ElevatorState.Up(elevator);
        }
    }
}
