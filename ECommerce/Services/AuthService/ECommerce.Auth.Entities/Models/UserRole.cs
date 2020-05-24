using ECommerce.Core.Entities;

namespace ECommerce.Auth.Entities.Models
{
    public class UserRole : IEntity
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}