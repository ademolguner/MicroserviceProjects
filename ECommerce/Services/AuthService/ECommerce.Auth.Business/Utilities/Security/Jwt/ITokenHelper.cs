using ECommerce.Auth.Entities.Models;
using ECommerce.Core.Utilities.Security.Jwt;
using System.Collections.Generic; 

namespace ECommerce.Auth.Business.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<Role> operationClaims);
    }
}
