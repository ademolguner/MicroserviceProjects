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

        void Add(User user);

        Task<User> GetByMail(string email);
    }
}
