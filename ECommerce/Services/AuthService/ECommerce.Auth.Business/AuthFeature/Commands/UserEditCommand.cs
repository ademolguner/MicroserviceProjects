using ECommerce.Auth.Entities.Models;
using MediatR;

namespace ECommerce.Auth.Business.AuthFeature.Commands
{
    public class UserEditCommand : IRequest<User>
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}