using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Entities.AuthFeature.Commands;
using ECommerce.Auth.Entities.Dtos;
using ECommerce.Core.Utilities.Security.Jwt;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ECommerce.Auth.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private readonly IMediator _mediator;

        public AuthController(IAuthService authService, IMediator mediator)
        {
            _authService = authService;
            _mediator = mediator;
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
        public async Task<ActionResult> RegisterAsync(UserForRegisterDto userForRegisterDto)
        {
            var createdUser = await _mediator.Send(new UserRegisterCommand(userForRegisterDto.FirstName, userForRegisterDto.LastName, userForRegisterDto.Email, userForRegisterDto.Password));
            return Created(string.Empty, createdUser);
        }
         
         
    }
}
