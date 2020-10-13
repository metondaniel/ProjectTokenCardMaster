using Microsoft.EntityFrameworkCore;
using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        DataContext _dataContext;
        public PedidoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public Pedido GetById(Guid Id)
        {
            var prato = Db.Set<Pedido>().FirstOrDefault(x => x.Id == Id);
            return prato;
        }

        public List<Pedido> GetByParam(string name)
        {
            var pedido = _dataContext.Pedido.Include(p => p.Pizza).ThenInclude(p => p.TipoPizza).Include(p => p.Pizza).ThenInclude(p => p.Porcao).Where(x => !string.IsNullOrEmpty(name) ? x.Cliente.Nome == name : true);
            return pedido.ToList();
        }

        public override Pedido Add(Pedido obj)
        {
            List<Pizza> listPizza = new List<Pizza>();
            Pedido pedido = new Pedido();
            double valorTotal = 0.0;
            foreach (Pizza pizza in obj.Pizza)
            {
                Pizza pizzaEntity = new Pizza();
                var tipoPizza = Db.Set<TipoPizza>().Where(x => x.Id == pizza.TipoPizza.Id).FirstOrDefault();
                var porcao = Db.Set<Porcao>().Where(x => x.Id == pizza.Porcao.Id).FirstOrDefault();
                if (porcao.Tipo == 0.5)
                    valorTotal += tipoPizza.Preco / 2;
                else
                    valorTotal += tipoPizza.Preco;
                pizzaEntity.TipoPizza = tipoPizza;
                pizzaEntity.Porcao = porcao;
                listPizza.Add(pizzaEntity);
            }
            pedido.Pizza = listPizza;
            pedido.ValorTotal = valorTotal;
            if (obj.Cliente.Id == Guid.Empty)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = obj.Cliente.Nome;
                cliente.Endereco = obj.Cliente.Endereco;
                pedido.Cliente = cliente;
            }
            else
            {
                var cliente = Db.Set<Cliente>().Where(x => x.Id == obj.Cliente.Id).FirstOrDefault();
                pedido.Cliente = cliente;
            }
            pedido.Data = obj.Data; ;
            Db.Set<Pedido>().Add(pedido);
            Db.SaveChanges();
            return obj;
        }
    }
}
