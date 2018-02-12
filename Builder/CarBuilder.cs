using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class CarBuilder
    {
        protected Car Car { get; private set; }

        public void CreateNewCar()
        {
            Car = new Car();
        }

        public Car GetMyCar()
        {
            return Car;
        }

        public abstract void SetHousing();
        public abstract void SetEngine();
        public abstract void SetWheels();
        public abstract void SetTransmissionBox();
    }

    class DaewooLanos : CarBuilder
    {
        public override void SetEngine()
        {
            Car.Engine = 98;
        }

        public override void SetHousing()
        {
            Car.Housing = "Sedan";
        }

        public override void SetTransmissionBox()
        {
            Car.TransmissionBox = "5 Manual";
        }

        public override void SetWheels()
        {
            Car.Wheels = 14;
        }
    }

    class FordProbe : CarBuilder
    {
        public override void SetEngine()
        {
            Car.Engine = 160;
        }

        public override void SetHousing()
        {
            Car.Housing = "Coupe";
        }

        public override void SetTransmissionBox()
        {
            Car.TransmissionBox = "4 Auto";
        }

        public override void SetWheels()
        {
            Car.Wheels = 14;
        }
    }

    class UAZPatriot : CarBuilder
    {
        public override void SetEngine()
        {
            Car.Engine = 120;
        }

        public override void SetHousing()
        {
            Car.Housing = "Universal";
        }

        public override void SetTransmissionBox()
        {
            Car.TransmissionBox = "4 Manual";
        }

        public override void SetWheels()
        {
            Car.Wheels = 16;
        }
    }
}
