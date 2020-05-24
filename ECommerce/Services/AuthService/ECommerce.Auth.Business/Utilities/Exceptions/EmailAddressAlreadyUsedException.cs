using System;

namespace ECommerce.Auth.Business.Utilities.Exceptions
{
    public class EmailAddressAlreadyUsedException : Exception
    {
        public EmailAddressAlreadyUsedException() : base(@"This Email Address Already Used, Please use a different email address")
        {
        }
    }
}