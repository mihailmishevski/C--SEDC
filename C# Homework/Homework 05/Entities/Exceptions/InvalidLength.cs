using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Exceptions
{
    public class InvalidLength : Exception
    {
        public InvalidLength(string message) : base(message)
        {
        }
    }
}
