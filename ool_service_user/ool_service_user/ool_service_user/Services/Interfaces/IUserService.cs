using ool_service_user.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ool_service_user.Services.Interfaces
{
    public interface IUserService
    {
        User NewUser(User User);
    }
}
