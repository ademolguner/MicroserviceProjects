using ECommerce.Auth.Entities.Models;
using ECommerce.Core.Utilities.Security.Jwt;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.Abstract
{
    public interface IAuthService
    {
        Task<AccessToken> CreateAccessToken(User user);

        Task<User> RegisterUser(User user);

        Task<User> LoginUser(UserForLoginDto userForLoginDto);
    }
}