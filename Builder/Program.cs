using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder;
            Shop shop = new Shop();

            builder = new DaewooLanos();
            shop.Construct(builder);
            //builder.Car.Show();

            builder = new FordProbe();
            shop.Construct(builder);
            //builder.Car.Show();

            builder = new UAZPatriot();
            shop.Construct(builder);
            //builder.Car.Show();
        }
    }
}
