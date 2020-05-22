using System;

namespace ECommerce.Core.Utilities.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException() : base(@"Invalid Command.")
        {
        }
    }
}