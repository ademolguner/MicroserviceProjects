using ECommerce.Auth.Business.Abstract;
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

        public void Add(User user)
        {
            _userDal.AddAsync(user);
        }

        public async Task<User> GetByMail(string email)
        {
            return await _userDal.GetAsync(u => u.Email == email);
        }

        public async Task<User> Created(User user)
        {
            return await _userDal.AddAsync(user);
        }
    }
}
