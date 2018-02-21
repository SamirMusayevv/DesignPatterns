using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Humans : Character
    {
        public Humans()
        {
            Name = "Human";
        }
    }

    class Human : Humans
    {
        public Human()
        {
            _Attact = 20;
            _Speed = 20;
            _Healt = 150;
            _Defence = 0;
        }

        public override string ToString()
        {
            return "No profession";
        }
    }
}
