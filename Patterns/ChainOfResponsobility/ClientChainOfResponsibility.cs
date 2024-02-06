using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsobility
{
    public class ClientChainOfResponsibility
    {
        public void Chain()
        {
            Approver mike = new Manager();
            Approver todd = new HeadDepartment();
            Approver clod = new GeneralManager();

            mike.SetSupervisor(todd);
            todd.SetSupervisor(clod);

            Purchase laptop = new Purchase(123, "LapTop", 1300.00, 1);
            mike.Request(laptop);
            Purchase phone = new Purchase(456, "Phone", 390.00, 1);
            mike.Request(phone);
            Purchase tv = new Purchase(789, "TV", 3600.00, 1);
            mike.Request(tv);
            Purchase printer = new Purchase(987, "Printer", 1800.00, 1);
            mike.Request(printer);
        }


        
    }
}
