using ECommerce.Auth.Entities.Models;
using ECommerce.Core.Utilities.Security.Jwt;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.AuthFeature.Queries
{
    
    public class UserLogingCommandQuery : IRequest<AccessToken>
    {
        public string Email { get; set; }
        public string Password { get; set; } 


        public UserLogingCommandQuery(string email, string password)
        { 
            Email = email;
            Password = password;
        }

    }
}
