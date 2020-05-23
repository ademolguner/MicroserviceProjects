using ECommerce.Auth.Entities.Models;
using ECommerce.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<Role> GetClaims(User user);
    }
}
