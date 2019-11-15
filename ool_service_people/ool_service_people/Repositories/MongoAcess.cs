using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ool_service_people.Repositories.Interfaces;

namespace ool_service_people.Repositories
{
    public class MongoAcess : IMongoAcess
    {
        private IConfiguration _configuration;
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _mongoDatabase;

        public MongoAcess(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._mongoClient = new MongoClient(this._configuration.GetValue<string>("mongo_server"));
            this._mongoDatabase = this._mongoClient.GetDatabase(this._configuration.GetValue<string>("mongo_database"));
        }

        public IMongoClient Client => this._mongoClient;

        public IMongoDatabase DataBase => this._mongoDatabase;

        public IMongoCollection<TEntity> Collection<TEntity>()
        {
            return _mongoDatabase.GetCollection<TEntity>(typeof(TEntity).Name.ToLower());
        }

        public TEntity Insert<TEntity>(TEntity Entity)
        {
            this.Collection<TEntity>().InsertOne(Entity);
            return Entity;
        }

        public TEntity Update<TEntity>(TEntity Entity, Expression<Func<TEntity, bool>> Predicate)
        {
            this.Collection<TEntity>().ReplaceOne(Predicate, Entity);
            return Entity;
        }

        public TEntity Delete<TEntity>(TEntity Entity, Expression<Func<TEntity, bool>> Predicate)
        {
            this.Collection<TEntity>().DeleteOne(Predicate);
            return Entity;
        }

        public List<TEntity> Select<TEntity>(Expression<Func<TEntity, bool>> Predicate)
        {
            return this.Collection<TEntity>().Find(Predicate).ToList();
        }
    }
}
