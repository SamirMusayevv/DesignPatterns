using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HumanWarrior : HumanProfessions
    {
        public HumanWarrior(Humans human)
        {
            if (!(human is Human))
                throw new ArgumentException("Only human can bocome a warrior!");
            else
            {
                Humans = human;

                attact = 20;
                speed = 10;
                healt = 50;
                defence = 20;
            }
        }

        public override string ToString()
        {
            return "Human warrior";
        }
    }

    class Swordbeard : HumanProfessions
    {
        public Swordbeard(Humans human)
        {
            if (!(human is HumanWarrior))
                throw new ArgumentException("Only warrior can bocome a swordbeard!");
            else
            {
                Humans = human;

                attact = 40;
                speed = -10;
                healt = 50;
                defence = 40;
            }
        }

        public override string ToString()
        {
            return "Swordbeard";
        }
    }

    class Archer : HumanProfessions
    {
        public Archer(Humans human)
        {
            if (!(human is HumanWarrior))
                throw new ArgumentException("Only warrior can bocome a archer!");
            else
            {
                Humans = human;

                attact = 20;
                speed = 20;
                healt = 50;
                defence = 10;
            }
        }

        public override string ToString()
        {
            return "Archer";
        }
    }

    class Rider : HumanProfessions
    {
        public Rider(Humans human)
        {
            if (!(human is Swordbeard))
                throw new ArgumentException("Only swordbeard can bocome a rider!");
            else
            {
                Humans = human;

                attact = -10;
                speed = 40;
                healt = 200;
                defence = 100;
            }
        }

        public override string ToString()
        {
            return "Rider";
        }
    }
}
