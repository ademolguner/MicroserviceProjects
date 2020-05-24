using ECommerce.Auth.Entities.Dtos;
using ECommerce.Auth.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Auth.Business.AuthFeature.Commands
{
    public class UserEditCommand:IRequest<User>
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public bool Status { get; set; }

        public UserEditCommand(UserEditDto userEditDto)
        {
            this.Email = userEditDto.Email;
            this.FirstName = userEditDto.FirstName;
            this.LastName = userEditDto.LastName; 
            this.Password = userEditDto.Password;
            this.UserId = userEditDto.UserId;
            this.Status = userEditDto.Status;
        }
    }
}
