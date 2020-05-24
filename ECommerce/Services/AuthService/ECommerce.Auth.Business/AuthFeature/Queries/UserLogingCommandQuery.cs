using ECommerce.Core.Utilities.Security.Jwt;
using MediatR;

namespace ECommerce.Auth.Business.AuthFeature.Queries
{
    public class UserLogingCommandQuery : IRequest<AccessToken>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}