using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Services
{
    public interface ITipoPizzaService : IServiceBase<TipoPizza>
    {
        List<TipoPizza> GetAll();
    }
}
