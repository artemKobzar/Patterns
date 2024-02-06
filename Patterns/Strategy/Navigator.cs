using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Navigator
    {
        public IMoveable Moveable { private get; set; }
        public int Distance { get; set; }
        public Navigator(IMoveable movable, int distance)
        {
            Moveable = movable;
            Distance = distance;
        }
        public void Move()
        {
            Moveable.MoveBy(Distance);
        }
    }
}
