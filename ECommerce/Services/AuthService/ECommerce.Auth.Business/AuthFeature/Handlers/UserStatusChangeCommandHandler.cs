using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Commands;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Handlers
{
    public class UserStatusChangeCommandHandler : IRequestHandler<UserStatusChangeCommand, User>
    {

        private readonly IUserService _userService;
        public UserStatusChangeCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Handle(UserStatusChangeCommand request, CancellationToken cancellationToken)
        {
            var userInfo = await _userService.UserInfo(request.UserId);
            userInfo.Status = request.ChangedStatus;
            if (request.ChangedStatus == false)
                userInfo.DeletedDate = DateTime.Now;
            return await _userService.Edit(userInfo);
            // user pasife çekildiğinde birşeyler tetikleyebiliriz.
        }
    }
}
