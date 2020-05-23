using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Auth.Entities.AuthFeature.Commands
{
    public class RegisterUserCommand : IRequest<int>
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        //public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, int>
        //{
        //    private readonly IUserService _userService;
        //    private readonly IAuthService _authService;
        //    public RegisterUserCommandHandler(IUserService userService, IAuthService authService)
        //    {
        //        _userService = userService;
        //        _authService = authService;
        //    }

        //    public async Task<int> Handle(RegisterUserCommand command, CancellationToken cancellationToken)
        //    {
        //        byte[] passwordHash, passwordSalt;
        //        HashingHelper.CreatePasswordHash(command.Password, out passwordHash, out passwordSalt);

        //        var createdUser = await _authService.re(new User
        //        {
        //            Email = command.Email,
        //            Password = command.Password,
        //            FirstName = command.FirstName,
        //            LastName = command.LastName,
        //            PasswordHash = passwordHash,
        //            PasswordSalt = passwordSalt,
        //            Status = true,
        //            CreatedDate = DateTime.Now
        //        });
        //        return createdUser.UserId;
        //    }
        //}
    }
}
