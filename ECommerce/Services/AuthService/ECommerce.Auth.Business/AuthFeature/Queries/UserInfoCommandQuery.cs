using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.AuthFeature.Queries
{
    public class UserInfoCommandQuery : IRequest<User>
    {
        public int UserId { get; set; }
        public UserInfoCommandQuery(int userId)
        {
            UserId = userId;
        }
    }
}
