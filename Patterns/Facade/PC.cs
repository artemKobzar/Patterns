using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    public class PC
    {
        private Bios bios = new Bios();
        private TestHardware hardware = new TestHardware();
        private TurnOnPC turnOn = new TurnOnPC();
        private TurnOffPC turnOff = new TurnOffPC();

        public void TurnOn()
        {
            turnOn.PowerSupply();
            turnOn.TurnOnVideocard();
            bios.CheckParams();
            Thread.Sleep(1000);
            hardware.CheckRam();
            Thread.Sleep(500);
            hardware.CheckHardDrive();
            Thread.Sleep(500);
            turnOn.TurnOnSystem();
        }
        public void TurnOff() 
        {
            turnOff.TurnOffPCPower();
        }


    }
}
