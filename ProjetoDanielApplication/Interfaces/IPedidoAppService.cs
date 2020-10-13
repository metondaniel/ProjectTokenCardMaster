using ProjetoDaniel.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Interfaces
{
    public interface IPedidoAppService
    {
        List<PedidoDto> GetPedido(string nomeCliente);

        PedidoDto GetPedidoById(Guid id);

        PedidoDto SavePedido(PedidoDto dtoRequest);

        void UpdatePedido(PedidoDto dtoRequest);

        void DeletePedido(Guid RestauranteId);
    }
}
