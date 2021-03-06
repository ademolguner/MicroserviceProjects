﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Queries;
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

        [Route("auth/register")]
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var createdUser = await _mediator.Send(new UserRegisterCommand(userForRegisterDto.FirstName, userForRegisterDto.LastName, userForRegisterDto.Email, userForRegisterDto.Password));
            return Created(string.Empty, createdUser);
        }

        [Route("auth/login")]
        [HttpPost("login")]
        public async Task<ActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var createdUser = await _mediator.Send(new UserLogingCommandQuery(userForLoginDto.Email, userForLoginDto.Password));
            return Created(string.Empty, createdUser);
        }


        
    }
}
