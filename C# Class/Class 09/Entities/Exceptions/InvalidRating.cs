using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Exceptions
{
    public class InvalidRating : Exception
    {
        public InvalidRating(string message) : base(message)
        {

        }
    }
}
