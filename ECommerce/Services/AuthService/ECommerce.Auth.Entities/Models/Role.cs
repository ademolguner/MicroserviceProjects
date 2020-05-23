using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Entities.Models
{
    
        public class Role:IEntity
        {
            public int RoleId { get; set; }
            public string Name { get; set; }
        }
    
}
