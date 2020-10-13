using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository) : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public List<Pedido> GetByParam(string nomeCliente)
        {
            return _pedidoRepository.GetByParam(nomeCliente);
        }
        public Pedido GetById(Guid Id)
        {
            return _pedidoRepository.GetById(Id);
        }
    }
}
