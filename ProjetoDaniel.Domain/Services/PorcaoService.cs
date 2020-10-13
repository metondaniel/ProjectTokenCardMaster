using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class PorcaoService : ServiceBase<Porcao>, IPorcaoService
    {
        private readonly IPorcaoRepository _porcaoRepository;
        public PorcaoService(IPorcaoRepository porcaoRepository) : base(porcaoRepository)
        {
            _porcaoRepository = porcaoRepository;
        }

        public List<Porcao> GetAll()
        {
            return _porcaoRepository.GetAll();
        }
    }
    
}
