using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Services
{
    public interface IPedidoService : IServiceBase<Pedido>
    {
        List<Pedido> GetByParam(string nomeCliente);

        Pedido GetById(Guid Id);
    }
}
