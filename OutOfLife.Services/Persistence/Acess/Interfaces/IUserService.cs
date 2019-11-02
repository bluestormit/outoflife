using OutOfLife.Models.Acess;
using System;

namespace OutOfLife.Services.Persistence.Acess.Interfaces
{
    public interface IUserService : IDisposable
    {
        User AddUser(User User);
        User UpdateUser(User User);
        User RemoveUser(User User);
        User SearchUserByEmail(User User);
    }
}
