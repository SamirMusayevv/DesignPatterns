using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Elfs : Character
    {
        public Elfs()
        {
            Name = "Elf";
        }
    }

    class Elf : Elfs
    {
        public Elf()
        {
            attact = 15;
            speed = 30;
            healt = 100;
            defence = 0;
        }

        public override string ToString()
        {
            return "No profession";
        }
    }
}
