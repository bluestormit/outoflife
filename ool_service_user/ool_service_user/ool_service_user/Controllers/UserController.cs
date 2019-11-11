using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ool_service_user.Models;
using ool_service_user.Services.Interfaces;

namespace ool_service_user.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService) =>
            this._userService = userService;

        [HttpPost]
        public User NewUser([FromBody] User User) =>
            this._userService.NewUser(User);
    }
}