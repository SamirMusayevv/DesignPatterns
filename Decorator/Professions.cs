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

        public override int Attact { get => Humans.Attact + attact; set => Attact = value; }
        public override int Speed { get => Humans.Speed + speed; set => Speed = value; }
        public override int Healt { get => Humans.Healt + healt; set => Healt = value; }
        public override int Defence { get => Humans.Defence + defence; set => Defence = value; }
    }

    class ElfsProfessions : Elfs
    {
        public Elfs Elfs { get; set; }

        public override int Attact { get => Elfs.Attact + attact; set => Attact = value; }
        public override int Speed { get => Elfs.Speed + speed; set => Speed = value; }
        public override int Healt { get => Elfs.Healt + healt; set => Healt = value; }
        public override int Defence { get => Elfs.Defence + defence; set => Defence = value; }
    }
}
