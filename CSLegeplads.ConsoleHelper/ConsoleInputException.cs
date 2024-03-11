using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLegeplads.ConsoleInputHelper
{
    public class ConsoleInputException : Exception
    {
        public ConsoleInputException(string message,
     Exception innerException) : base(message, innerException)
        {
            //other stuff here
        }
    }
}
