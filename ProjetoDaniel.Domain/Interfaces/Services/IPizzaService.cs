using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Services
{
    public interface IPizzaService : IServiceBase<Pizza>
    {
        List<Pizza> GetByParam(TipoPizza tipoPizza);

        Pizza GetById(Guid Id);
    }
}
