using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Continent Africa = new Africa();
            AnimalWorld animalWorld = new AnimalWorld(Africa);
            animalWorld.Eat();

            Continent America = new NorthAmerica();
            AnimalWorld animalWorld2 = new AnimalWorld(America);
            animalWorld2.Eat();
        }
    }
}
