using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Commands;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Auth.Entities.Dtos;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.AuthFeature.Handlers
{
    public class UserEditCommandHandler : IRequestHandler<UserEditCommand, User>
    {


        private readonly IUserService _userService;
        public UserEditCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Handle(UserEditCommand request, CancellationToken cancellationToken)
        {
            var userInfo = await _userService.UserInfo(request.UserId);

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
            var editUserInfo = new User
            {
                //UserId = request.UserId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserId = request.UserId,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = request.Status,
                CreatedDate = userInfo.CreatedDate
            };
            if (request.Status == false)
                editUserInfo.DeletedDate = DateTime.Now;

            //edit bilgisi değiştiği zaman belki sepet bilgiside büncellenebilir event tetiklenebilir sonra eklenecek
            return await _userService.Edit(editUserInfo);
        }


    }
}
