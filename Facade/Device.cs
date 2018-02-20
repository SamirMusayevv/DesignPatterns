using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    abstract class Device
    {
        public void CheckTemperature()
        {
            Console.WriteLine($"{this} temperature check: Temperature is normal.");
        }

        public void CheckVoltage()
        {
            Console.WriteLine($"{this} voltage check: Voltage is normal.");
        }

        public void Run()
        {
            Console.WriteLine($"{this} running...");
        }

        public void Stop()
        {
            Console.WriteLine($"{this} stopped.");
        }
    }

    class GraphicCard : Device
    {
        public override string ToString()
        {
            return "Graphic Card";
        }

        public void CheckMonitorConnection()
        {
                Console.WriteLine($"{this}: Monitor connected.");
        }
    }

    class RAM : Device
    {
        public override string ToString()
        {
            return "RAM";
        }

        public void MemoryCheck()
        {
                Console.WriteLine($"{this}: Memory check OK.");
        }

        public void ClearMemory()
        {
            Console.WriteLine($"{this}: Memory Cleared.");
        }
    }

    class HDD : Device
    {
        public override string ToString()
        {
            return "Hard Drive";
        }

        public void CheckBootLoader()
        {
                Console.WriteLine($"{this}: BootLoader OK.");
        }
    }

    class DVD : Device
    {
        public override string ToString()
        {
            return "ROM";
        }

    }

    class PowerSupply : Device
    {
        public bool Start { get; set; }

        public override string ToString()
        {
            return "Power Supply";
        }

        public void PowerGraphicCard()
        {
            if (Start)
                Console.WriteLine("Power Supply: Graphic Card Powered.");
            else
                Console.WriteLine("Power Supply: Graphic Card power stopped.");
        }

        public void PowerDVD()
        {
            if (Start)
                Console.WriteLine("Power Supply: ROM Powered.");
            else
                Console.WriteLine("Power Supply: ROM power stopped.");
        }

        public void PowerHDD()
        {
            if (Start)
                Console.WriteLine("Power Supply: HDD Powered.");
            else
                Console.WriteLine("Power Supply: HDD power stopped.");
        }

        public void PowerRAM()
        {
            if (Start)
                Console.WriteLine("Power Supply: RAM Powered.");
            else
                Console.WriteLine("Power Supply: RAM power stopped.");
        }
    }
}
