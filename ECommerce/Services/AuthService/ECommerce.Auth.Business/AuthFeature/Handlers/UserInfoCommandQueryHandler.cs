using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Queries;
using ECommerce.Auth.Business.Utilities.Exceptions;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Handlers
{
    public class UserInfoCommandQueryHandler : IRequestHandler<UserInfoCommandQuery, User>
    {
        private readonly IUserService _userService;

        public UserInfoCommandQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Handle(UserInfoCommandQuery request, CancellationToken cancellationToken)
        {
            var userInfo = await _userService.UserInfo(request.UserId);
            if (userInfo == null) throw new UserNotFoundException();
            return userInfo;
        }
    }
}