using System;
using System.Linq;
using System.Linq.Expressions;
using ool_service_user.Models;
using ool_service_user.Repositories.Interfaces;

namespace ool_service_user.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoAcess _mongoAcess;

        public UserRepository(IMongoAcess MongoAcess) =>
            this._mongoAcess = MongoAcess;

        public User InsertUser(User User) => this._mongoAcess.Insert(User);

        public User RemoveUser(User User) => this._mongoAcess.Delete(User, t => t.Id == User.Id);

        public User UpdateUser(User User) => this._mongoAcess.Update(User, t => t.Id == User.Id);

        public User SearchUser(Expression<Func<User, bool>> Predicate)
        {
            return this._mongoAcess.Select<User>(Predicate).FirstOrDefault();
        }
    }
}
