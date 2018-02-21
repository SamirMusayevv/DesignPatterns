using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ElfWarrior : ElfsProfessions
    {
        public ElfWarrior(Elfs elf)
        {
            if (!(elf is Elf))
                throw new ArgumentException("Only elf can bocome a warrior!");
            else
            {
                Elfs = elf;

                attact = 20;
                speed = -10;
                healt = 100;
                defence = 20;
            }
        }

        public override string ToString()
        {
            return "Elf Warrior";
        }
    }

    class ElfTheMage : ElfsProfessions
    {
        public ElfTheMage(Elfs elf)
        {
            if (!(elf is Elf))
                throw new ArgumentException("Only elf can bocome a elf the mage!");
            else
            {
                Elfs = elf;

                attact = 10;
                speed = 10;
                healt = -50;
                defence = 10;
            }
        }

        public override string ToString()
        {
            return "Elf the mage";
        }
    }

    class Crossbowman : ElfsProfessions
    {
        public Crossbowman(Elfs elf)
        {
            if (!(elf is ElfWarrior))
                throw new ArgumentException("Only elf warrior can bocome a crossbowman!");
            else
            {
                Elfs = elf;

                attact = 20;
                speed = 10;
                healt = 50;
                defence = -10;
            }
        }

        public override string ToString()
        {
            return "Crossbowman";
        }
    }

    class EvilMage : ElfsProfessions
    {
        public EvilMage(Elfs elf)
        {
            if (!(elf is ElfTheMage))
                throw new ArgumentException("Only elf the mage can bocome a evil mage!");
            else
            {
                Elfs = elf;

                attact = 70;
                speed = 20;
                healt = 0;
                defence = 0;
            }
        }

        public override string ToString()
        {
            return "Evil mage";
        }
    }

    class KindMage : ElfsProfessions
    {
        public KindMage(Elfs elf)
        {
            if (!(elf is ElfTheMage))
                throw new ArgumentException("Only elf the mage can bocome a kind mage!");
            else
            {
                Elfs = elf;

                attact = 50;
                speed = 30;
                healt = 100;
                defence = 30;
            }
        }

        public override string ToString()
        {
            return "Kind mage";
        }
    }
}
