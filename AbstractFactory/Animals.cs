using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Herbivore
    {
    }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }

    class Wildebeest : Herbivore
    {
    }

    class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    class Bison : Herbivore
    {
    }

    class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}
