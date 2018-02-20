using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Computer
    {
        private bool Start { get; set; }
        private PowerSupply PowerSupply { get; set; }
        private GraphicCard GraphicCard { get; set; }
        private RAM Ram { get; set; }
        private DVD DVD { get; set; }
        private HDD HDD { get; set; }

        public Computer()
        {
            Start = false;
            PowerSupply = new PowerSupply();
            GraphicCard = new GraphicCard();
            Ram = new RAM();
            DVD = new DVD();
            HDD = new HDD();
        }

        public void BeginWork()
        {
            if (Start)
                Console.WriteLine("Computer is alrady running!");
            else
            {
                Start = true;
                PowerSupply.Start = true;
                PowerSupply.Run();
                PowerSupply.CheckTemperature();
                GraphicCard.CheckTemperature();
                PowerSupply.PowerGraphicCard();
                GraphicCard.Run();
                GraphicCard.CheckMonitorConnection();
                Ram.CheckTemperature();
                PowerSupply.PowerRAM();
                Ram.Run();
                Ram.MemoryCheck();
                PowerSupply.PowerDVD();
                DVD.Run();
                PowerSupply.PowerHDD();
                HDD.Run();
                HDD.CheckBootLoader();
                Console.WriteLine("\nCOMPUTER START");
            }
        }

        public void PowerOff()
        {
            if (!Start)
                Console.WriteLine("Computer is alrady turned off!");
            else
            {
                Start = false;
                PowerSupply.Start = false;
                HDD.Stop();
                Ram.ClearMemory();
                GraphicCard.Stop();
                DVD.Stop();
                PowerSupply.PowerGraphicCard();
                PowerSupply.PowerRAM();
                PowerSupply.PowerDVD();
                PowerSupply.PowerHDD();
                PowerSupply.Stop();
                Console.WriteLine("\nCOMPUTER OFF");
            }
        }
    }
}
