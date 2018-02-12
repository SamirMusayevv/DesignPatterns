using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Car
    {
        public string Housing { get; set; }
        public int Engine { get; set; }
        public int Wheels { get; set; }
        public string TransmissionBox { get; set; }

        public override string ToString()
        {
            return $"Housing: {Housing}\nEngine: {Engine}\nWheels: {Wheels}\nTransmission box: {TransmissionBox}\n";
        }
    }
}
