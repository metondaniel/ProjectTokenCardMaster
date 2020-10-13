using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Repositories
{
    public interface IPedidoRepository : IRepositoryBase<Pedido>
    {
        List<Pedido> GetByParam(string nomeCliente);

        Pedido GetById(Guid Id);
    }
}
