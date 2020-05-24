using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.Utilities.Exceptions
{
   public class UserNotFoundException: Exception
    {
        public UserNotFoundException():base(@"Kullanıcı bilgileri hatalı, bilgileri girerek tekrar deneyiniz")
        {

        }
    }
}
