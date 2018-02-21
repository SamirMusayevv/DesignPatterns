using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HumanProfessions : Humans
    {
        public Humans Humans { get; set; }

        public override int Attact { get => Humans.Attact + _Attact; set => Attact = value; }
        public override int Speed { get => Humans.Speed + _Speed; set => Speed = value; }
        public override int Healt { get => Humans.Healt + _Healt; set => Healt = value; }
        public override int Defence { get => Humans.Defence + _Defence; set => Defence = value; }
    }
}
