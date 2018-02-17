using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    interface IComputer
    {
        void GetHardwareInfo();
    }

    class VideoCard : IComputer
    {
        public void GetHardwareInfo()
        {
            Console.WriteLine("Graphic Card: GeForce GTX 560 TI");
        }
    }

    class Processor : IComputer
    {
        public void GetHardwareInfo()
        {
            Console.WriteLine("Processor: Intel i9-7980xe");
        }
    }

    class HDD : IComputer
    {
        public void GetHardwareInfo()
        {
            Console.WriteLine("HDD: Western Digital - 500 GB");
        }
    }

    class Ram : IComputer
    {
        public void GetHardwareInfo()
        {
            Console.WriteLine("RAM: Patriot - 8 GB");
        }
    }
}
