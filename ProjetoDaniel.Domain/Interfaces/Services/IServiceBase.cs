using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
    }
}
