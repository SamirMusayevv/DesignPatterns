using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    abstract class PC
    {
    }

    class VideoCard
    {

    }

    class Ram
    {

    }

    class HDD
    {

    }

    class DVD
    {

    }

    class PowerSupply
    {
        public bool Power { get; set; }
        public bool PowerTheGraphicsCard { get; set; }
        public int PowerTheRam { get; set; }
        public int PowerTheDVD { get; set; }
        public int PowerTheHDD { get; set; }
    }

    class Sensors
    {

    }
}
