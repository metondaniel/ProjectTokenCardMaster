using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class PizzaRepository : RepositoryBase<Pizza>, IPizzaRepository
    {
        private readonly DataContext context;
        public PizzaRepository(DataContext dataContext) : base(dataContext)
        {
            context = dataContext;
        }

        public Pizza GetById(Guid Id)
        {
            var prato = Db.Set<Pizza>().FirstOrDefault(x => x.Id == Id);
            return prato;
        }

        public List<Pizza> GetByParam(TipoPizza tipoPizza)
        {
            var prato = Db.Set<Pizza>().Where(x => x.TipoPizza.GetType().Name  == tipoPizza.GetType().Name);
            return prato.ToList();
        }
    }
}
