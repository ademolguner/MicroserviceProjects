using ECommerce.Core.Entities;

namespace ECommerce.Auth.Entities.Models
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
}