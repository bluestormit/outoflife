using OutOfLife.Repositories.DataEstructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace OutOfLife.Repositories.DataRepositories
{
    public abstract class BaseRepository : IDisposable
    {
        protected DataContext dataContext;

        public BaseRepository(DataContext DataContext)
        {
            this.dataContext = DataContext;
        }

        protected TEntity RepositoryInsert<TEntity>(TEntity Entity, bool AutoSave = true)
            where TEntity : class
        {
            var Returned = this.dataContext.Set<TEntity>().Add(Entity);
            this.Save(AutoSave);
            return Returned.Entity;
        }

        protected TEntity RepositoryUpdate<TEntity>(TEntity Entity, bool AutoSave = true)
           where TEntity : class
        {
            var Returned = this.dataContext.Set<TEntity>().Update(Entity);
            this.Save(AutoSave);
            return Returned.Entity;
        }

        protected TEntity RepositoryDelete<TEntity>(TEntity Entity, bool AutoSave = true)
          where TEntity : class
        {
            var Returned = this.dataContext.Set<TEntity>().Remove(Entity);
            this.Save(AutoSave);
            return Returned.Entity;
        }

        private void Save(bool AutoSave)
        {
            if (AutoSave)
                this.dataContext.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
