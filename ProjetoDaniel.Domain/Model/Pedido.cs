using ProjetoDaniel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDaniel.Model
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public DateTimeOffset Data { get; set; }

        public List<Pizza> Pizza { get; set; }

        public Cliente Cliente { get; set; }

        public double ValorTotal { get; set; }
    }
}
