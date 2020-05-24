using ECommerce.Auth.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.Abstract
{
    public interface IUserService
    {
        List<Role> GetClaims(User user);
        Task<User> GetUserByMail(string email);
        Task<User> Created(User user);
        Task<User> Login(string email, string password);

        Task<User> Edit(User user);
        Task<User> UserInfo(int userId);
    }
}
