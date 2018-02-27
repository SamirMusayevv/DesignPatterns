using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            FatalException fatal = new FatalException();
            CriticalException critical = new CriticalException(fatal);
            NormalException normal = new NormalException(critical);

            normal.Error(new MyException("Normal Error", ExceptionType.Normal));
            Console.WriteLine();
            normal.Error(new MyException("Critical Error", ExceptionType.Critical));
            Console.WriteLine();
            normal.Error(new MyException("Fatal Error", ExceptionType.Fatal));
            Console.WriteLine();
        }
    } 
}
