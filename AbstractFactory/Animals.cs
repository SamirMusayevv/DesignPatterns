using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Herbivore
    {
        public abstract int Weight { get; set; }
        public abstract bool Life { get; set; }

        public void EatGrass()
        {
            Weight += 10;
        }
    }

    abstract class Carnivore
    {
        public abstract int Power { get; set; }

        public abstract void EatHerbivore(Herbivore herbivore);
        
    }

    class Wildebeest : Herbivore
    {
        public override int Weight { get; set; }
        public override bool Life { get; set; }

        public Wildebeest()
        {
            Weight = 70;
            Life = true;
        }
    }

    class Lion : Carnivore
    {
        public override int Power { get ; set; }

        public Lion()
        {
            Power = 300;
        }

        public override void EatHerbivore(Herbivore herbivore)
        {
            Console.WriteLine($"{herbivore.GetType().Name}\nWeight: {herbivore.Weight}\nLife: {herbivore.Life}\n");
            Console.WriteLine($"{GetType().Name}\nPower: {Power}\n");
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
            Console.WriteLine();

            if (Power > herbivore.Weight)
                Power += 10;
            else
                Power -= 10;

            herbivore.Weight /= 5;
            herbivore.Life = false;

            Console.WriteLine($"{herbivore.GetType().Name}\nWeight: {herbivore.Weight}\nLife: {herbivore.Life}\n");
            Console.WriteLine($"{GetType().Name}\nPower: {Power}");
            Console.WriteLine("_________________________\n");
        }
    }

    class Bison : Herbivore
    {
        public override int Weight { get; set; }
        public override bool Life { get; set; }

        public Bison()
        {
            Weight = 300;
            Life = true;
        }
    }

    class Wolf : Carnivore
    {
        public override int Power { get; set; }

        public Wolf()
        {
            Power = 150;
        }

        public override void EatHerbivore(Herbivore herbivore)
        {
            Console.WriteLine($"{herbivore.GetType().Name}\nWeight: {herbivore.Weight}\nLife: {herbivore.Life}\n");
            Console.WriteLine($"{GetType().Name}\nPower: {Power}\n");
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
            Console.WriteLine();

            if (Power > herbivore.Weight)
                Power += 10;
            else
                Power -= 10;

            herbivore.Weight /= 5;
            herbivore.Life = false;

            Console.WriteLine($"{herbivore.GetType().Name}\nWeight: {herbivore.Weight}\nLife: {herbivore.Life}\n");
            Console.WriteLine($"{GetType().Name}\nPower: {Power}");
        }
    }
}
