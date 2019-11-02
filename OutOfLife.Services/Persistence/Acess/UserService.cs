using OutOfLife.Models.Acess;
using OutOfLife.Repositories.DataRepositories.Acess.Interfaces;
using OutOfLife.Services.Persistence.Acess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OutOfLife.Services.Persistence.Acess
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository) =>
            this.userRepository = userRepository;

        public User AddUser(User User)
        {
            return this.userRepository.InsertUser(User);
        }

        public void Dispose()
        {
            this.userRepository.Dispose();
        }

        public User RemoveUser(User User)
        {
            var PersistedUser = this.SearchUserByEmail(User);
            return this.userRepository.DeleteUser(PersistedUser);
        }

        public User SearchUserByEmail(User User)
        {
            return this.userRepository.FindUser(t => t.Email == User.Email);
        }

        public User UpdateUser(User User)
        {
            var PersistedUser = this.SearchUserByEmail(User);
            if (PersistedUser == null)
                throw new InvalidOperationException("User not saved in context");
            PersistedUser.Name = User.Name;
            this.userRepository.UpdateUser(PersistedUser);
            return PersistedUser;
        }
    }
}
