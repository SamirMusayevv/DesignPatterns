﻿using System;
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
            attact = 20;
            speed = 20;
            healt = 150;
            defence = 0;
        }

        public override string ToString()
        {
            return "No profession";
        }
    }
}
