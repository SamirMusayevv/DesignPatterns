using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            PC pc = new PC();

            pc.Hardware = new VideoCard();
            pc.GetInfo();

            pc.Hardware = new Processor();
            pc.GetInfo();

            pc.Hardware = new HDD();
            pc.GetInfo();

            pc.Hardware = new Ram();
            pc.GetInfo();
        }
    }
}
