using System;

namespace ECommerce.Core.Utilities.Exceptions
{
    public class OutOfBorderException : Exception
    {
        public OutOfBorderException() : base(@"Out of Border...")
        {
        }
    }
}