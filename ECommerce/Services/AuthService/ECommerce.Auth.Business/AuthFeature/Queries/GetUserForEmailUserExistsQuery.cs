using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Queries
{
    public class GetUserForEmailUserExistsQuery : IRequest<User>
    {
        public string EmailAddress { get; set; }
        public class GetUserForEmailUserExistsQueryHandler : IRequestHandler<GetUserForEmailUserExistsQuery, User>
        {
            private readonly IUserService _userService;
            public GetUserForEmailUserExistsQueryHandler(IUserService userService)
            {
                _userService = userService;
            }

            public async Task<User> Handle(GetUserForEmailUserExistsQuery emailUserExistsQuery, CancellationToken cancellationToken)
            {
                var user = await _userService.GetByMail(emailUserExistsQuery.EmailAddress);
                if (user == null) return null;
                return user;
            }
        }
    }
}
