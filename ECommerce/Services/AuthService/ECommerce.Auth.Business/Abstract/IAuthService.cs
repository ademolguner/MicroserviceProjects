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
        User Register(UserForRegisterDto userForRegisterDto, string password);

        Task<User> Login(UserForLoginDto userForLoginDto);

        bool UserExists(string email);

        AccessToken CreateAccessToken(User user);
    }
}
