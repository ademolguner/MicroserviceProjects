using ECommerce.Auth.Entities.Models;
using ECommerce.Core.Utilities.Security.Jwt;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.AuthFeature.Queries
{
    
    public class UserLogingCommand : IRequest<AccessToken>
    {
        public string Email { get; set; }
        public string Password { get; set; } 


        public UserLogingCommand(string email, string password)
        { 
            Email = email;
            Password = password;
        }

    }
}
