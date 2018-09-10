using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTutorial.cs
{
    class StatusCodeException : Exception
    {
        public void statusCodeMisMatch(String statusCode)
        {
            Console.WriteLine("The status code is not matched. The response code is: "+statusCode);
        }
    }
}
