using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.Utilities.Exceptions
{
   public class EmailAddressAlreadyUsedException: Exception
    {
        public EmailAddressAlreadyUsedException():base(@"This Email Address Already Used, Please use a different email address")
        {

        }
    }
}
