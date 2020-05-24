using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Queries;
using ECommerce.Auth.Business.Utilities.Exceptions;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Core.Utilities.Security.Jwt;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Handlers
{
    public class UserLoginCommandHandler : IRequestHandler<UserLogingCommandQuery, AccessToken>
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public UserLoginCommandHandler(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        public async Task<AccessToken> Handle(UserLogingCommandQuery command, CancellationToken cancellationToken)
        {
            var userToCheck = await _userService.GetUserByMail(command.Email);
            if (userToCheck == null)
            {
                throw new UserNotFoundException();
            }

            if (!HashingHelper.VerifyPasswordHash(command.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new IncorrectPasswordException();
            }

            return await _authService.CreateAccessToken(userToCheck);
        }
    }
}