using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    class Program
    {
        static void Main(string[] args)
        {
            Component folder = new MyFolder(@"C:\Intel");
            folder.Draw();

            //Console.WriteLine("\n");

            //Component file = new MyFile(@"D:\Step it academy\C#\C Exam.mp4");
            //file.Display();
        }
    }
}
