using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Figure
    {
        public abstract int[,] Arr { get; set; }
        public abstract void draw(int[,] Arr);
    }

    class One : Figure
    {
        public One()
        {
            Arr = new int[4, 4]
            {
                { 1, 1, 1, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            draw(Arr);
        }

        public override int[,] Arr { get{ return Arr; } set { Arr = value; } }

        public override void draw(int[,] Arr)
        {
            for (int i = 0; i < Arr.Length / 4; i++)
            {
                for (int j = 0; j < Arr.Length / 4; j++)
                {
                    Console.Write(Arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Two : Figure
    {
        public Two()
        {
            Arr = new int[4, 4]
            {
                { 0, 1, 1, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            draw(Arr);
        }

        public override int[,] Arr { get { return Arr; } set { Arr = value; } }

        public override void draw(int[,] Arr)
        {
            for (int i = 0; i < Arr.Length / 4; i++)
            {
                for (int j = 0; j < Arr.Length / 4; j++)
                {
                    Console.Write(Arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Three : Figure
    {
        public Three()
        {
            Arr = new int[4, 4]
            {
                { 1, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            draw(Arr);
        }

        public override int[,] Arr { get { return Arr; } set { Arr = value; } }

        public override void draw(int[,] Arr)
        {
            for (int i = 0; i < Arr.Length / 4; i++)
            {
                for (int j = 0; j < Arr.Length / 4; j++)
                {
                    Console.Write(Arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Four : Figure
    {
        public Four()
        {
            Arr = new int[4, 4]
            {
                { 0, 1, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            draw(Arr);
        }

        public override int[,] Arr { get { return Arr; } set { Arr = value; } }

        public override void draw(int[,] Arr)
        {
            for (int i = 0; i < Arr.Length / 4; i++)
            {
                for (int j = 0; j < Arr.Length / 4; j++)
                {
                    Console.Write(Arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Five : Figure
    {
        public Five()
        {
            Arr = new int[4, 4]
            {
                { 1, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            draw(Arr);
        }

        public override int[,] Arr { get { return Arr; } set { Arr = value; } }

        public override void draw(int[,] Arr)
        {
            for (int i = 0; i < Arr.Length / 4; i++)
            {
                for (int j = 0; j < Arr.Length / 4; j++)
                {
                    Console.Write(Arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Six : Figure
    {
        public Six()
        {
            Arr = new int[4, 4]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 }
            };

            draw(Arr);
        }

        public override int[,] Arr { get { return Arr; } set { Arr = value; } }

        public override void draw(int[,] Arr)
        {
            for (int i = 0; i < Arr.Length / 4; i++)
            {
                for (int j = 0; j < Arr.Length / 4; j++)
                {
                    Console.Write(Arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
