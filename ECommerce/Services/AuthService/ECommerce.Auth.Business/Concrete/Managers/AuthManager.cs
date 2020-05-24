using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Auth.Business.Utilities.Security.Jwt;
using ECommerce.Auth.Entities.Dtos;
using ECommerce.Auth.Entities.Models;
using ECommerce.Core.Utilities.Security.Jwt;
using ServiceStack;
using System;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.Concrete.Managers
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public async Task<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return await Task.FromResult(accessToken);
        }




        public async Task<User> RegisterUser(User user)
        {
            return await _userService.Created(user);
        }
        public async Task<User> LoginUser(UserForLoginDto userForLoginDto)
        {
            return await _userService.Login(userForLoginDto.Email, userForLoginDto.Password);
        }


        #region YARDIMCI METOTLAR



        #endregion
    }
}
