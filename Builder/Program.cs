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
            DaewooLanos daewooLanos = new DaewooLanos();
            Shop shopDaewoo = new Shop();
            shopDaewoo.SetCarBuilder(daewooLanos);
            shopDaewoo.ConstructCar();
            Car carDaewoo = shopDaewoo.GetCar();
            Console.WriteLine("Daewoo Lanos");
            Console.WriteLine(carDaewoo);

            FordProbe fordProbe = new FordProbe();
            Shop shopFord = new Shop();
            shopFord.SetCarBuilder(fordProbe);
            shopFord.ConstructCar();
            Car car = shopFord.GetCar();
            Console.WriteLine("Ford Probe");
            Console.WriteLine(car);

            UAZPatriot UAZpatriot = new UAZPatriot();
            Shop shopUAZ = new Shop();
            shopUAZ.SetCarBuilder(UAZpatriot);
            shopUAZ.ConstructCar();
            Car carUAZ = shopUAZ.GetCar();
            Console.WriteLine("UAZ Patriot");
            Console.WriteLine(car);
        }
    }
}
