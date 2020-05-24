using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.Utilities.Security.Hasing;
using ECommerce.Auth.DataAccess.Abstract;
using ECommerce.Auth.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Auth.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<Role> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }


        public async Task<User> GetUserByMail(string email)
        {
            return await _userDal.GetAsync(u => u.Email == email);
        }

        public async Task<User> Created(User user)
        {
            return await _userDal.AddAsync(user);
        }

        public async Task<User> Login(string email, string password)
        {
            return await GetUserByMail(email);
        }
    }
}
