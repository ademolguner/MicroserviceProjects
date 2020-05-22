using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Utilities.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException() : base(@"Invalid Command.")
        {

        }
    }
}
