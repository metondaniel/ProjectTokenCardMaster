using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class TipoPizzaRepository : RepositoryBase<TipoPizza>, ITipoPizzaRepository
    {
        public TipoPizzaRepository(DataContext dataContext) : base(dataContext)
        {
        }

        List<TipoPizza> ITipoPizzaRepository.GetAll()
        {
            return Db.Set<TipoPizza>().ToList();
        }
    }
}
