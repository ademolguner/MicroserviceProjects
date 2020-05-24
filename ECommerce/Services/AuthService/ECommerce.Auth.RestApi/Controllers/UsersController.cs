using ECommerce.Auth.Business.Abstract;
using ECommerce.Auth.Business.AuthFeature.Commands;
using ECommerce.Auth.Business.AuthFeature.Queries;
using ECommerce.Auth.Entities.AuthFeature.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.Auth.RestApi.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IAuthService _authService;
        private readonly IMediator _mediator;

        public UsersController(IAuthService authService, IMediator mediator)
        {
            _authService = authService;
            _mediator = mediator;
        }

        [Route("api/auth/register")]
        [HttpPost]
        public async Task<ActionResult> Register(UserRegisterCommand userRegisterCommand)
        {
            var createdUser = await _mediator.Send(userRegisterCommand);
            return Created(string.Empty, createdUser);
        }

        [Route("api/auth/login")]
        [HttpPost]
        public async Task<ActionResult> Login(UserLogingCommandQuery userLogingCommandQuery)
        {
            var createdUser = await _mediator.Send(userLogingCommandQuery);
            return Created(string.Empty, createdUser);
        }

        [Route("api/users/editUser")]
        [HttpPost]
        public async Task<ActionResult> Edit(UserEditCommand userEditCommand)
        {
            var updatedUser = await _mediator.Send(userEditCommand);
            return Ok(updatedUser);
        }

        [Route("api/users/StatusChange")]
        [HttpPost]
        public async Task<ActionResult> StatusChange(int userID, UserStatusChangeCommand userStatusChangeCommand)
        {
            if (userID != userStatusChangeCommand.UserId)
            {
                return BadRequest();
            }
            var updatedUser = await _mediator.Send(userStatusChangeCommand);
            return Ok(updatedUser);
        }

        [Route("api/users/{userID}")]
        [HttpGet]
        public async Task<ActionResult> Info(int userID, UserInfoCommandQuery userInfoCommandQuery)
        {
            if (userID != userInfoCommandQuery.UserId)
            {
                return BadRequest();
            }
            var userInfo = await _mediator.Send(userInfoCommandQuery);
            return Ok(userInfo);
        }
    }
}