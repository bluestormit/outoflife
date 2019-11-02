using OutOfLife.Models.Acess;
using OutOfLife.Repositories.DataEstructure;
using OutOfLife.Repositories.DataRepositories.Acess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OutOfLife.Repositories.DataRepositories.Acess
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(DataContext DataContext) : base(DataContext)
        {
        }

        public User DeleteUser(User User)
        {
            return this.RepositoryDelete(User);
        }

        public User FindUser(Expression<Func<User, bool>> Predicate)
        {
            return this.dataContext.User.Where(Predicate).FirstOrDefault();
        }

        public User InsertUser(User User)
        {
            return this.RepositoryInsert(User);
        }

        public List<User> SelectUser(Expression<Func<User, bool>> Predicate)
        {
            return this.dataContext.User.Where(Predicate).ToList();
        }

        public User UpdateUser(User User)
        {
            return this.RepositoryUpdate(User);
        }
    }
}
