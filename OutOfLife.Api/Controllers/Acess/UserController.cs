using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OutOfLife.Models.Acess;
using OutOfLife.Services.Persistence.Acess.Interfaces;

namespace OutOfLife.Api.Controllers.Acess
{
    [Route("api/Acess/[controller]")]
    [ApiController]
    public class UserController : BaseController<IUserService>
    {
        public UserController(IUserService Service) : base(Service)
        {
        }

        [HttpPost]
        public User AddUser([FromBody] User User) =>
            this.service.AddUser(User);

        [HttpPut]
        public User UpdateUser([FromBody] User User) =>
            this.service.UpdateUser(User);

        [HttpDelete]
        public User DeleteUser([FromBody] User User) =>
            this.service.RemoveUser(User);
    }
}