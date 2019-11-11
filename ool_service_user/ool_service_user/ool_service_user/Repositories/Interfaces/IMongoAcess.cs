using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ool_service_user.Repositories.Interfaces
{
    public interface IMongoAcess
    {
        IMongoClient Client { get; }
        IMongoDatabase DataBase { get; }

        IMongoCollection<TEntity> Collection<TEntity>();

        TEntity Insert<TEntity>(TEntity Entity);
        TEntity Update<TEntity>(TEntity Entity, Expression<Func<TEntity, bool>> Predicate);
        TEntity Delete<TEntity>(TEntity Entity, Expression<Func<TEntity, bool>> Predicate);

        List<TEntity> Select<TEntity>(Expression<Func<TEntity, bool>> Predicate);
    }
}
