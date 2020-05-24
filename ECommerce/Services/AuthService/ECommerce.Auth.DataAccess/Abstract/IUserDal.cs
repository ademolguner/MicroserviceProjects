using ECommerce.Auth.Entities.Models;
using ECommerce.Core.DataAccess;
using System.Collections.Generic;

namespace ECommerce.Auth.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<Role> GetClaims(User user);
    }
}