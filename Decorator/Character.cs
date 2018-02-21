using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Character
    {
        public string Name { get; set; }

        protected int attact;
        protected int speed;
        protected int healt;
        protected int defence;

        virtual public int Attact  { get => attact; set => attact = value; }
        virtual public int Speed  { get => speed; set => speed = value; }
        virtual public int Healt  { get => healt; set => healt = value; }
        virtual public int Defence { get => defence; set => defence = value; }

        public void ShowCharacteristics()
        {
            Console.WriteLine($"***********{Name}***********");
            Console.WriteLine($" Profession: {this}");
            Console.WriteLine($"     Attact: {Attact}");
            Console.WriteLine($"      Speed: {Speed}");
            Console.WriteLine($"      Healt: {Healt}");
            Console.WriteLine($"    Defence: {Defence}");
            Console.WriteLine("***************************");
        }
    }
}
