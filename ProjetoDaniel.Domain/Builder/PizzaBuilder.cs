using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Builder
{
    public class PizzaBuilder
    {
        public Pizza Instance = new Pizza();
        public PizzaBuilder()
        {
            Instance.Id = Guid.NewGuid();
        }

        public PizzaBuilder WithId(Guid id)
        {
            Instance.Id = id;
            return this;
        }

        public PizzaBuilder WithName(TipoPizza tipoPizza)
        {
            Instance.TipoPizza = tipoPizza;
            return this;
        }
        public PizzaBuilder WithPreco(Porcao porcao)
        {
            Instance.Porcao = porcao;
            return this;
        }
    }
}
