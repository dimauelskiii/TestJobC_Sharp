using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJobC_Sharp
{
    public class InvalidParametersException : Exception
    {
        public InvalidParametersException(string message) : base(message)
        {

        }
    }
}
