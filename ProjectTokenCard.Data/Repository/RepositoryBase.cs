using Microsoft.EntityFrameworkCore;
using ProjectTokenCard.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectTokenCard.Data.Context;
using System.Reflection;

namespace ProjectTokenCard.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected DataContext Db;

        public RepositoryBase(DataContext authenticationContext)
        {
            Db = authenticationContext;
        }

        public virtual TEntity Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
            return obj;
        }

        public void Dispose()
        {
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>();
        }


        public void Delete(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
