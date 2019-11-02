using OutOfLife.Models.Acess;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OutOfLife.Repositories.DataRepositories.Acess.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        User InsertUser(User User);
        User UpdateUser(User User);
        User DeleteUser(User User);

        User FindUser(Expression<Func<User, bool>> Predicate);
        List<User> SelectUser(Expression<Func<User, bool>> Predicate);
    }
}
