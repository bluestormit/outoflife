using ool_service_user.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ool_service_user.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User InsertUser(User User);
        User UpdateUser(User User);
        User RemoveUser(User User);
        User SearchUser(Expression<Func<User, bool>> Predicate);
    }
}
