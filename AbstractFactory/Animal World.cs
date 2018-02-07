using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AnimalWorld
    {
        public Herbivore _herbivore;
        public Carnivore _carnivore;

        public AnimalWorld(Continent continent)
        {
            _carnivore = continent.CreateCarnivore();
            _herbivore = continent.CreateHerbivore();
        }

        public void Eat()
        {
            _herbivore.EatGrass();
            _carnivore.EatHerbivore(_herbivore);
        }
    }
}
