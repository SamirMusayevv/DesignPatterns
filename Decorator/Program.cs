using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Humans

            Humans Hum = new Human();
            Hum.ShowCharacteristics();

            Console.WriteLine();

            Hum = new HumanWarrior(Hum);
            Hum.ShowCharacteristics();

            Console.WriteLine();

            Hum = new Swordbeard(Hum);
            Hum.ShowCharacteristics();

            Console.WriteLine();

            //Hum = new Archer(Hum);
            //Hum.ShowCharacteristics();

            Hum = new Rider(Hum);
            Hum.ShowCharacteristics();

            Console.WriteLine();

            //Elfs

            Elfs elf = new Elf();
            elf.ShowCharacteristics();

            Console.WriteLine();

            elf = new ElfWarrior(elf);
            elf.ShowCharacteristics();

            Console.WriteLine();

            //elf = new ElfTheMage(elf);
            //elf.ShowCharacteristics();

            elf = new Crossbowman(elf);
            elf.ShowCharacteristics();

            Console.WriteLine();

            //elf = new EvilMage(elf);
            //elf.ShowCharacteristics();

            //elf = new KindMage(elf);
            //elf.ShowCharacteristics();
        }
    }
}
