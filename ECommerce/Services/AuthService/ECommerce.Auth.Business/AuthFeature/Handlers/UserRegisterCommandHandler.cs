using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Auth.Entities.AuthFeature.Commands;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Handlers
{
   public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommand, int>
    {

        private readonly IAuthService _authService;
        public UserRegisterCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<int> Handle(UserRegisterCommand command, CancellationToken cancellationToken)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(command.Password, out passwordHash, out passwordSalt);

            var createdUser = await _authService.RegisterUser(new User
            {
                Email = command.Email, 
                FirstName = command.FirstName,
                LastName = command.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true,
                CreatedDate = DateTime.Now
            });
            return createdUser.UserId;
        }


    }
}
