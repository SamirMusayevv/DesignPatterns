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

        protected int _Attact { get; set; }
        protected int _Speed { get; set; }
        protected int _Healt { get; set; }
        protected int _Defence { get; set; }

        virtual public int Attact  { get => _Attact; set => _Attact = value; }
        virtual public int Speed  { get => _Speed; set => _Speed = value; }
        virtual public int Healt  { get => _Healt; set => _Healt = value; }
        virtual public int Defence { get => _Defence; set => _Defence = value; }

        public void ShowCharacteristics()
        {
            Console.WriteLine($"*****{Name}*****");
            Console.WriteLine($"  Attact: {Attact}");
            Console.WriteLine($"   Speed: {Speed}");
            Console.WriteLine($"   Healt: {Healt}");
            Console.WriteLine($" Defence: {Defence}");
        }
    }
}
