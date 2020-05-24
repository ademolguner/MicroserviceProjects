using System;

namespace ECommerce.Auth.Business.Utilities.Exceptions
{
    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException() : base(@"Incorrect the password")
        {
        }
    }
}