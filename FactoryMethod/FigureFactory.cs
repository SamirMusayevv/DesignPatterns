using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class FigureFactory
    {
        public static Figure GetFigure(string figure)
        {
            switch(figure)
            {
                case "One": return new One();
                case "Two": return new Two();
                case "Three": return new Three();
                case "Four": return new Four();
                case "Five": return new Five();
                case "Six": return new Six();
                default: throw new Exception($"Invalidate figure: {figure}");
            }
        }
    }
}
