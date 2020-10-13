using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public List<Cliente> GetByParam(string nomeCliente)
        {
            return Db.Set<Cliente>().Where(x => nomeCliente != null ? x.Nome == nomeCliente : true).ToList();
        }
    }
}
