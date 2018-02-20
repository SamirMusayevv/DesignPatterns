using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    abstract class Device
    {
        public abstract override string ToString();
    }

    class GraphicCard : Device
    {
        public override string ToString()
        {
            return "Graphic Card";
        }

        public void Run()
        {
            Console.WriteLine("Graphic Card running...");
        }

        public void CheckMonitorConnection()
        {
            Console.WriteLine("Monitor connected");
        }

        public void DataOutputRam()
        {
            Console.WriteLine("Ram data output");
        }

        public void DataOutputDVD()
        {
            Console.WriteLine("Dvd data output");
        }

        public void DataOutputHDD()
        {
            Console.WriteLine("HDD data output");
        }
    }

    class PowerSupply : Device
    {
        public override string ToString()
        {
            return "Power Supply";
        }
    }

    class HDD : Device
    {
        public override string ToString()
        {
            return "HDD";
        }
    }

    class DVD : Device
    {
        public override string ToString()
        {
            return "DVD";
        }
    }

    class Ram : Device
    {
        public override string ToString()
        {
            return "Ram";
        }
    }

    class Sensor : Device
    {
        public override string ToString()
        {
            return "Sensor";
        }
    }
}
