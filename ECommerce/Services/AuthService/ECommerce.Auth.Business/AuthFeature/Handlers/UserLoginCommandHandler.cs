﻿using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Queries;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Handlers
{
    
    public class UserLoginCommandHandler : IRequestHandler<UserLogingCommand, User>
    {

        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        public UserLoginCommandHandler(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        public async Task<User> Handle(UserLogingCommand command, CancellationToken cancellationToken)
        {

            var userToCheck = await _userService.GetUserByMail(command.Email);
            if (userToCheck == null)
            {
                throw new Exception("hata metni");
            }

            if (!HashingHelper.VerifyPasswordHash(command.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new Exception("hata metni"); ;
            }

            return userToCheck;



            //var createdUser= await _authService.LoginUser(new Entities.Dtos.UserForLoginDto { Email = command.Email, Password = command.Password });
            //return createdUser;
        }


    }
}
