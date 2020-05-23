using ECommerce.Auth.DataAccess.Abstract;
using ECommerce.Auth.DataAccess.Concrete.EntityFramework.Context;
using ECommerce.Auth.Entities.Models;
using ECommerce.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ECommerce.Auth.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ECommerceAuthApiProjectDbContext>, IUserDal
    {
        public List<Role> GetClaims(User user)
        {
            using var context = new ECommerceAuthApiProjectDbContext();
            var result = from uoc in context.UserRole
                         join oc in context.Role
                             on uoc.RoleId equals oc.RoleId
                         where uoc.UserId == user.UserId
                         select new Role { RoleId = oc.RoleId, Name = oc.Name };
            return result.ToList();
        }
    }
}
