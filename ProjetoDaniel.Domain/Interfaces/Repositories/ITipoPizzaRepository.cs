using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Repositories
{
    public interface ITipoPizzaRepository : IRepositoryBase<TipoPizza>
    {
        List<TipoPizza> GetAll();
    }
}
