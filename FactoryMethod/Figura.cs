using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Figure
    {
        public int[,] FigureGeometry { get; set; }
        public byte[] Color { get; set; }
        public string Name { get; protected set; }

        public Figure(byte Red, byte Green, byte Blue)
        {
            Color = new byte[3];
            SetColor(Red, Green, Blue);
        }

        public void SetColor(byte Red, byte Green, byte Blue)
        {
            Color[0] = Red;
            Color[1] = Green;
            Color[2] = Blue;
        }

        public override string ToString()
        {
            Console.WriteLine($"Figure name: {Name}");
            string color = $"Color: Red:{Color[0]}, Green:{Color[1]}, Blue:{Color[2]}\n";

            for (int i = 0; i < FigureGeometry.Length / 4; i++)
            {
                for (int j = 0; j < FigureGeometry.Length / 4; j++)
                {
                   Console.Write(FigureGeometry[i, j]);
                }
                Console.WriteLine();
            }
            return color;
        }
    }

    class One : Figure
    {
        public One(byte Red, byte Green, byte Blue) : base(Red, Green, Blue)
        {
            Name = "One";
            FigureGeometry = new int[4, 4]
            {
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 }
            };
        }
    }

    class Two : Figure
    {
        public Two(byte Red, byte Green, byte Blue) : base(Red, Green, Blue)
        {
            Name = "Two";
            FigureGeometry = new int[4, 4]
            {
                { 0, 0, 1, 1 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };
        }
    }

    class Three : Figure
    {
        public Three(byte Red, byte Green, byte Blue) : base(Red, Green, Blue)
        {
            Name = "Three";
            FigureGeometry = new int[4, 4]
            {
                { 1, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };
        }
    }

    class Four : Figure
    {
        public Four(byte Red, byte Green, byte Blue) : base(Red, Green, Blue)
        {
            Name = "Four";
            FigureGeometry = new int[4, 4]
            {
                { 0, 0, 0, 0 },
                { 1, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 }
            };
        }
    }

    class Five : Figure
    {
        public Five(byte Red, byte Green, byte Blue) : base(Red, Green, Blue)
        {
            Name = "Five";
            FigureGeometry = new int[4, 4] 
            {
                { 1, 1, 1, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };
        }
    }

    class Six : Figure
    {
        public Six(byte Red, byte Green, byte Blue) : base(Red, Green, Blue)
        {
            Name = "Six";
            FigureGeometry = new int[4, 4] 
            {
                { 0, 1, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };
        }
    }
}
