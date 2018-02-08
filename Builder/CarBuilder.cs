using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class CarBuilder
    {
        public Car Car { get; set; }

        public abstract void Housing();
        public abstract void Engine();
        public abstract void Wheels();
        public abstract void TransmissionBox();
    }

    class DaewooLanos : CarBuilder
    {
        public DaewooLanos()
        {
            Car = new Car("Daewoo Lanos");
        }

        public override void Housing()
        {
            Console.WriteLine("Sedan");
        }

        public override void Engine()
        {
            Console.WriteLine("98 (Horsepower)");
        }

        public override void Wheels()
        {
            Console.WriteLine("13 radius");
        }

        public override void TransmissionBox()
        {
            Console.WriteLine("5 Manual");
        }
    }

    class FordProbe : CarBuilder
    {
        public FordProbe()
        {
            Car = new Car("Ford Probe");
        }

        public override void Housing()
        {
            Console.WriteLine("Coupe");
        }

        public override void Engine()
        {
            Console.WriteLine("160 (Horsepower)");
        }

        public override void Wheels()
        {
            Console.WriteLine("14 radius");
        }

        public override void TransmissionBox()
        {
            Console.WriteLine("4 Auto");
        }
    }

    class UAZPatriot : CarBuilder
    {
        public UAZPatriot()
        {
            Car = new Car("UAZ Patriot");
        }

        public override void Housing()
        {
            Console.WriteLine("Wagon");
        }

        public override void Engine()
        {
            Console.WriteLine("120 (Horsepower)");
        }

        public override void Wheels()
        {
            Console.WriteLine("16 radius");
        }

        public override void TransmissionBox()
        {
            Console.WriteLine("4 Manual");
        }
    }
}
