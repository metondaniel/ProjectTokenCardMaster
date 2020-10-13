using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class PizzaService : ServiceBase<Pizza>, IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        public PizzaService(IPizzaRepository pizzaRepository): base(pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public List<Pizza> GetByParam(TipoPizza sTipoPizza)
        {
            return _pizzaRepository.GetByParam(sTipoPizza);
        }

        public Pizza GetById(Guid id)
        {
            return _pizzaRepository.GetById(id);
        }
    }
}
