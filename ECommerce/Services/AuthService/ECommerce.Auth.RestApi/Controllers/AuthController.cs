using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Entities.AuthFeature.Commands;
using ECommerce.Auth.Entities.Dtos;
using ECommerce.Core.Utilities.Security.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ECommerce.Auth.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (userToLogin == null)
            {
                return BadRequest();
            }

            var result = _authService.CreateAccessToken(userToLogin.Result);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest((AccessToken)null);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (userExists)
                return BadRequest(false);

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult);
            if (result == null)
            {
                return Ok((AccessToken)null);
            }

            return BadRequest(error: result);
        }
    }
}
