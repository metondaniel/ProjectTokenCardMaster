using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDaniel.Model
{
    public class Pizza
    {
        public Guid Id { get; set; }

        public TipoPizza TipoPizza { get; set; }

        public Porcao Porcao { get; set; }

        public Pedido Pedido { get; set; }
        
    }
}
