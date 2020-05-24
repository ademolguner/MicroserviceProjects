using MediatR;

namespace ECommerce.Auth.Entities.AuthFeature.Commands
{
    public class UserRegisterCommand : IRequest<int>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}