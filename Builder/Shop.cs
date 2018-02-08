using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Shop
    {
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.Housing();
            carBuilder.Engine();
            carBuilder.Wheels();
            carBuilder.TransmissionBox();
        }
    }
}
