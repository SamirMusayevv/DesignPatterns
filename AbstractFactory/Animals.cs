using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    
    abstract class Herbivore
    {
        public abstract void EatGrass();
    }

    abstract class Carnivore
    {
        public abstract void EatHerbivore(Herbivore herbivore);
    }

    class Wildebeest : Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }

    class Lion : Carnivore
    {
        public int Power { get; set; }

        public override void EatHerbivore(Herbivore herbivore)
        {
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    class Bison : Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }

    class Wolf : Carnivore
    {
        public int Power { get; set; }

        public override void EatHerbivore(Herbivore herbivore)
        {
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}
