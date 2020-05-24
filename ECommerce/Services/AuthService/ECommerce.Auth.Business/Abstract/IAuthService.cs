using ECommerce.Auth.Entities.AuthFeature.Commands;
using ECommerce.Auth.Entities.Dtos;
using ECommerce.Auth.Entities.Models;
using ECommerce.Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.Abstract
{
    public interface IAuthService
    {
        
        AccessToken CreateAccessToken(User user);

        Task<User> RegisterUser(User user);
        Task<User> LoginUser(UserForLoginDto userForLoginDto);
    }
}
