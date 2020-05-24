using ECommerce.Auth.Entities.Models;
using MediatR;

namespace ECommerce.Auth.Business.AuthFeature.Commands
{
    public class UserStatusChangeCommand : IRequest<User>
    {
        public int UserId { get; set; }
        public bool ChangedStatus { get; set; }
    }
}