using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> GetCliente(string nomeCliente)
        {
            return _clienteRepository.GetByParam(nomeCliente);
        }
    }
}
