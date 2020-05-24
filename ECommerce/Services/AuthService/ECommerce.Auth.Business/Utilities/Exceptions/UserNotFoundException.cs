using System;

namespace ECommerce.Auth.Business.Utilities.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base(@"Kullanıcı bulunamadı")
        {
        }
    }
}