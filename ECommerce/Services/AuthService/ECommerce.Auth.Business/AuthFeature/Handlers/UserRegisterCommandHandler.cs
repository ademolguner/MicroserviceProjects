using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.Utilities.Exceptions;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Auth.Entities.AuthFeature.Commands;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Handlers
{
    public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommand, int>
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public UserRegisterCommandHandler(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        public async Task<int> Handle(UserRegisterCommand command, CancellationToken cancellationToken)
        {
            var userToCheck = await _userService.GetUserByMail(command.Email);
            if (userToCheck != null)
            {
                throw new EmailAddressAlreadyUsedException();
            }

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