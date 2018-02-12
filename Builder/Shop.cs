using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Shop
    {
        private CarBuilder _carBuilder;

        public void SetCarBuilder(CarBuilder ICarBuilder)
        {
            _carBuilder = ICarBuilder;
        }

        public Car GetCar()
        {
            return _carBuilder.GetMyCar();
        }

        public void ConstructCar()
        {
           _carBuilder.CreateNewCar();
           _carBuilder.SetHousing();
           _carBuilder.SetEngine();
           _carBuilder.SetWheels();
           _carBuilder.SetTransmissionBox();
        }
    }
}
