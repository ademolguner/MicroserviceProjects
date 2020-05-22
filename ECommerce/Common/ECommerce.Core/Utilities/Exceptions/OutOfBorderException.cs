using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Utilities.Exceptions
{
    public class OutOfBorderException : Exception
    {
        public OutOfBorderException() : base(@"Out of Border...")
        {

        }
    }
}
