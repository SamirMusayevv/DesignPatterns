using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    enum ExceptionType
    {
        Normal,
        Critical,
        Fatal
    }

    class MyException : Exception
    {
        public ExceptionType Type { get; set; }

        public MyException(string message, ExceptionType Type = ExceptionType.Normal) : base(message)
        {
            this.Type = Type;
        }
    }
}
