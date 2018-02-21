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
            if (!(human is Human)) throw new ArgumentException("Only Human can bocome a Warrior!"); 
            _Attact = 30;
            _Speed = 40;
            _Healt = 200;
            _Defence = 10;

            Humans = human;
        }
    }
}
