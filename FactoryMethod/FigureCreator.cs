using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class FigureCreator
    {
        public abstract Figure GetFigure(byte Red, byte Green, byte Blue);
    }

    class OneCreator : FigureCreator
    {
        public override Figure GetFigure(byte Red, byte Green, byte Blue)
        {
            return new Three(Red, Green, Blue);
        }
    }

    class TwoCreator : FigureCreator
    {
        public override Figure GetFigure(byte Red, byte Green, byte Blue)
        {
            return new Two(Red, Green, Blue);
        }
    }

    class ThreeCreator : FigureCreator
    {
        public override Figure GetFigure(byte Red, byte Green, byte Blue)
        {
            return new One(Red, Green, Blue);
        }
    }

    class FourCreator : FigureCreator
    {
        public override Figure GetFigure(byte Red, byte Green, byte Blue)
        {
            return new Six(Red, Green, Blue);
        }
    }

    class FiveCreator : FigureCreator
    {
        public override Figure GetFigure(byte Red, byte Green, byte Blue)
        {
            return new Four(Red, Green, Blue);
        }
    }

    class SixCreator : FigureCreator
    {
        public override Figure GetFigure(byte Red, byte Green, byte Blue)
        {
            return new Five(Red, Green, Blue);
        }
    }
}
