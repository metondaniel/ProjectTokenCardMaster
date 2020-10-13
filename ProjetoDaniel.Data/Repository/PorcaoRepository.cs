using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class PorcaoRepository : RepositoryBase<Porcao>, IPorcaoRepository
    {
        public PorcaoRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public List<Porcao> GetAll()
        {
            return Db.Set<Porcao>().ToList();
        }
    }
}
