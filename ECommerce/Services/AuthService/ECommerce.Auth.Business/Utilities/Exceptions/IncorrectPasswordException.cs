using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.Utilities.Exceptions
{
   public class IncorrectPasswordException: Exception
    {
        public IncorrectPasswordException():base(@"Incorrect the password")
        {

        }
    }
}
