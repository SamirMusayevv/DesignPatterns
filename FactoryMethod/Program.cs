using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static byte[] GetRandomColor(Random rnd)
        {
            return new byte[] { (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255) };
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Tetris tetris = new Tetris();

            tetris.Creator = new OneCreator();
            tetris.AddFigure(GetRandomColor(rnd));

            tetris.Creator = new TwoCreator();
            tetris.AddFigure(GetRandomColor(rnd));

            tetris.Creator = new ThreeCreator();
            tetris.AddFigure(GetRandomColor(rnd));

            tetris.Creator = new FourCreator();
            tetris.AddFigure(GetRandomColor(rnd));

            tetris.Creator = new FiveCreator();
            tetris.AddFigure(GetRandomColor(rnd));

            tetris.Creator = new SixCreator();
            tetris.AddFigure(GetRandomColor(rnd));

            tetris.PrintFigures();
        }
    }
}
