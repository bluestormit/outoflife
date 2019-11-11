using System;
using ool_service_user.Models;
using ool_service_user.Repositories.Interfaces;
using ool_service_user.Services.Interfaces;

namespace ool_service_user.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository UserReporitory) =>
            this._userRepository = UserReporitory;

        public User NewUser(User User)
        {
            var user = this._userRepository.SearchUser(t => t.Email == User.Email);
            if (user != null)
                throw new InvalidOperationException("User exists in ool");
            return this._userRepository.InsertUser(User);
        }
    }
}
