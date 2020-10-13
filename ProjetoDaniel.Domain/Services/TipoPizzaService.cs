using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class TipoPizzaService : ServiceBase<TipoPizza>, ITipoPizzaService
    {
        private readonly ITipoPizzaRepository _tipoPizzaRepository;
        public TipoPizzaService(ITipoPizzaRepository tipoPizzaRepository) : base(tipoPizzaRepository)
        {
            _tipoPizzaRepository = tipoPizzaRepository;
        }

        public List<TipoPizza> GetAll()
        {
            return _tipoPizzaRepository.GetAll();
        }
    }
}
