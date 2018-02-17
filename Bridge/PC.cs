using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class PC
    {
        private IComputer hardware;

        public IComputer Hardware { set { hardware = value; } }

        public void GetInfo()
        {
            hardware.GetHardwareInfo();
        }
    }
}
