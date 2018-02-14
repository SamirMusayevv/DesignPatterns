using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Tetris
    {
        public List<Figure> Figures { get; set; }
        public FigureCreator Creator { get; set; }

        public Tetris()
        {
            Figures = new List<Figure>();
            Creator = null;
        }

        public void AddFigure(byte[] color)
        {
            Figures.Add(Creator.GetFigure(color[0], color[1], color[2]));
        }

        public void PrintFigures()
        {
            foreach (var figure in Figures)
            {
                Console.WriteLine(figure);
            }
        }
    }
}
