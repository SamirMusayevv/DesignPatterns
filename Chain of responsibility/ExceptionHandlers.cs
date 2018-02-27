using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    abstract class ExceptionHandler
    {
        protected ExceptionHandler Next { get; set; }
        abstract public void Error(MyException ex);
    }

    class NormalException : ExceptionHandler
    {
        public NormalException(ExceptionHandler next)
        {
            Next = next;
        }
        public override void Error(MyException exception)
        {
            Console.WriteLine(exception.Message + " - Handled by Normal exception");
            if (exception.Type != ExceptionType.Normal && Next != null)
                Next.Error(exception);
        }
    }

    class CriticalException : ExceptionHandler
    {
        public CriticalException(ExceptionHandler next)
        {
            Next = next;
        }
        public override void Error(MyException exception)
        {
            if (exception.Type == ExceptionType.Normal) return;
            Console.WriteLine(exception.Message + " - Handled by Critical exception");
            if (Next != null) Next.Error(exception);
        }
    }

    class FatalException : ExceptionHandler
    {
        public override void Error(MyException exception)
        {
            if (exception.Type != ExceptionType.Fatal) return;
            Console.WriteLine(exception.Message + " - Handled by Fatal exception");
        }
    }
}
