using ECommerce.Auth.Entities.Models;
using MediatR;

namespace ECommerce.Auth.Business.AuthFeature.Queries
{
    public class UserInfoCommandQuery : IRequest<User>
    {
        public int UserId { get; set; }
    }
}