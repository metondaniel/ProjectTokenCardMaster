using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Builder
{
    public class PedidoBuilder
    {
        public Pedido Instance = new Pedido();
        public PedidoBuilder()
        {
            Instance.Id = Guid.NewGuid();
        }

        public PedidoBuilder WithId(Guid id)
        {
            Instance.Id = id;
            return this;
        }

        public PedidoBuilder WithDate(DateTimeOffset Date)
        {
            Instance.Data = Date;
            return this;
        }
        public PedidoBuilder WithPizza(List<Pizza> listPizza)
        {
            if ((listPizza.Count - (listPizza.FindAll(x => x.Porcao.Tipo == 0.5).Count)/2) > 10)
                throw new InvalidOperationException("Número de pizzas maior que o permitido");
            if (listPizza.FindAll(x => x.Porcao.Tipo == 0.5).Count % 2 != 0)
                throw new InvalidOperationException("Quantidade de meia pizzas não formam todas inteiras");
            Instance.Pizza = listPizza;
            return this;
        }

        public PedidoBuilder WithCliente(Cliente cliente)
        {
            if (cliente.Endereco == null && cliente.Endereco.Logradouro == null)
                throw new InvalidOperationException("É necessário ter um endereço");
            
            Instance.Cliente = cliente;
            return this;
        }
    }
}
