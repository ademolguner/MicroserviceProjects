﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Commands;
using ECommerce.Auth.Business.AuthFeature.Queries;
using ECommerce.Auth.Entities.AuthFeature.Commands;
using ECommerce.Auth.Entities.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Auth.RestApi.Controllers
{
    //[Route("api/[controller]/{action}")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private IAuthService _authService;
        private readonly IMediator _mediator;

        public UsersController(IAuthService authService, IMediator mediator)
        {
            _authService = authService;
            _mediator = mediator;
        }

        [Route("api/auth/register")]
        [HttpPost]
        public async Task<ActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var createdUser = await _mediator.Send(new UserRegisterCommand(userForRegisterDto.FirstName, userForRegisterDto.LastName, userForRegisterDto.Email, userForRegisterDto.Password));
            return Created(string.Empty, createdUser);
        }

        [Route("api/auth/login")]
        [HttpPost]
        public async Task<ActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var createdUser = await _mediator.Send(new UserLogingCommandQuery(userForLoginDto.Email, userForLoginDto.Password));
            return Created(string.Empty, createdUser);
        }

        [Route("api/users/editUSer")]
        [HttpPost]
        public async Task<ActionResult> Edit(UserEditDto userEditDto)
        {
            var updatedUser = await _mediator.Send(new UserEditCommand(userEditDto));
            return Ok(updatedUser);
        }
    }
}