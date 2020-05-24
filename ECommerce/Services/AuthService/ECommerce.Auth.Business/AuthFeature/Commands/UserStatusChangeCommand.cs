using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.AuthFeature.Commands
{
   public class UserStatusChangeCommand : IRequest<User>
    {
        public int UserId { get; set; }
        public bool ChangedStatus { get; set; }

        public UserStatusChangeCommand(int userId, bool statusValue)
        {
            UserId = userId;
            ChangedStatus = statusValue;
        }
    }
}
