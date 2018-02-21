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
            Humans Hum = new Human();
            Hum.ShowCharacteristics();
            Hum = new HumanWarrior(Hum);
            Console.WriteLine();
            Hum.ShowCharacteristics();
        }
    }
}
